using AppKeep.Data;
using AppKeep.Data.Repository;
using AppKeep.Domain;
using AppKeep.Service.Mapping;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AppKeep.Service
{
    public class UpkeepTemplateDetailService : IUpkeepTemplateDetailService, IAutoMapperService
    {
        private readonly IUpkeepTemplateDetailRepository _upkeepTemplateDetailRepository;

        private readonly IUpkeepTemplateRepository _upkeepTemplateRepository;

        private readonly IMyPlanRepository _myPlanRepository;

        public IMapper Mapper
        {
            get { return ObjectMapper.Mapper; }
        }

        public UpkeepTemplateDetailService(IUpkeepTemplateDetailRepository upkeepTemplateDetailRepository, 
            IUpkeepTemplateRepository upkeepTemplateRepository,
            IMyPlanRepository myPlanRepository)
        {
            _upkeepTemplateDetailRepository = upkeepTemplateDetailRepository;
            _upkeepTemplateRepository = upkeepTemplateRepository;
            _myPlanRepository = myPlanRepository;
        }

        public async Task<UpkeepTemplateDetail> AddUpkeepTemplateDetailAsync(UpkeepTemplateDetail upkeepTemplateDetail, int userId)
        {
            var upkeepTemplateDetailEntity = Mapper.Map<UpkeepTemplateDetailEntity>(upkeepTemplateDetail);

            upkeepTemplateDetailEntity = await _upkeepTemplateDetailRepository.AddAsync(upkeepTemplateDetailEntity);

            upkeepTemplateDetail = Mapper.Map<UpkeepTemplateDetail>(upkeepTemplateDetailEntity);

            await SetUpkeepDetailWorkItem(upkeepTemplateDetail, userId);

            return upkeepTemplateDetail;
        }

        public async Task<UpkeepTemplateDetail> UpdateUpkeepTemplateDetailAsync(UpkeepTemplateDetail upkeepTemplateDetail, int userId)
        {
            var upkeepTemplateDetailEntity = Mapper.Map<UpkeepTemplateDetailEntity>(upkeepTemplateDetail);

            upkeepTemplateDetailEntity = await _upkeepTemplateDetailRepository.UpdateAsync(upkeepTemplateDetailEntity);

            upkeepTemplateDetail = Mapper.Map<UpkeepTemplateDetail>(upkeepTemplateDetailEntity);

            await SetUpkeepDetailWorkItem(upkeepTemplateDetail, userId);

            return upkeepTemplateDetail;
        }

        public async Task SetUpkeepDetailWorkItem(UpkeepTemplateDetail upkeepTemplateDetail, int userId = 0)
        {
            // Set the work items for work items on the user machine profile(s)
            var workItems = await GetUpkeepTemplateDetailByIdForPlan(new MyPlanFilters
            {
                UpkeepTemplateDetailIds = new List<int> { upkeepTemplateDetail.UpkeepTemplateDetailId },
                StartDate = DateTime.Now.Date,
                EndDate = DateTime.Now.Date.AddDays(1).AddMilliseconds(-1),
                UserId = userId
            });

            upkeepTemplateDetail.WorkItem = workItems.FirstOrDefault();
        }

        public async Task<List<UpkeepTemplateDetail>> GetAllUpkeepTemplateDetailsAsync()
        {
            var upkeepTemplateDetailEntities = await _upkeepTemplateDetailRepository.GetAll().ToListAsync();

            return Mapper.Map<List<UpkeepTemplateDetail>>(upkeepTemplateDetailEntities);
        }

        public async Task<UpkeepTemplateDetail> GetUpkeepTemplateDetailByIdAsync(int id)
        {
            var upkeepTemplateDetailEntity = await _upkeepTemplateDetailRepository.GetAsync(id);

            var machine = Mapper.Map<UpkeepTemplateDetail>(upkeepTemplateDetailEntity);

            return machine;
        }

        public async Task DeleteWorkItem(UpkeepTemplateDetail upkeepTemplateDetail)
        {
            var upkeepTemplateDetailEntity = Mapper.Map<UpkeepTemplateDetailEntity>(upkeepTemplateDetail);
            await _upkeepTemplateDetailRepository.Delete(upkeepTemplateDetailEntity);
        }

        public async Task<UpkeepTemplateDetail> GetUpkeepTemplateDetailByIdForPartAsync(int id)
        {
            var upkeepTemplateDetailEntity = await _upkeepTemplateDetailRepository.GetUpkeepTemplateDetailsPart(id);

            var machine = Mapper.Map<UpkeepTemplateDetail>(upkeepTemplateDetailEntity);

            return machine;
        }

        public async Task<List<MyPlanItem>> GetUpkeepTemplateDetailByIdForPlan(MyPlanFilters requestHelper)
        {
            requestHelper.StartDate = requestHelper.StartDate.Date;
            requestHelper.EndDate = requestHelper.EndDate.Date.AddDays(1).AddMilliseconds(-1);

            // If user is an assistant, he gets all the work items from all users
            if (requestHelper.UserType == UserTypeEnum.Assistant)
            {
                requestHelper.UserId = 0;
            }

            var virtualItems = new List<MyPlanItem>();

            var myPlanWorkItems = await _upkeepTemplateRepository.GetAll()
                .Where(t => t.AuthorId == requestHelper.UserId || requestHelper.UserId == 0)
                .SelectMany(x => x.UpkeepTemplateDetails)
                .Select(x => new MyPlanItem
                {
                    Category = x.Template.Machine.Category,
                    Machine = x.Template.Machine.Name,
                    ProfileName = x.Template.ProfileName,
                    Description = x.Template.Description,
                    IsRecurring = x.IsRecurring,
                    ScheduleDate = x.StartDate,
                    Status = WorkStatusEnum.Pending,
                    UpkeepTemplateDetailId = x.UpkeepTemplateDetailId,
                    UpkeepTemplateId = x.Template.UpkeepProfileTemplateId,
                    WorkDescription = x.Description,
                    Interval = x.Interval,
                    Period = x.Period,
                    OwnerName = x.Template.Author.FullName,
                    TemplateWorkDetail = Mapper.Map<UpkeepTemplateDetail>(x)
                })
                .ToListAsync();

            // Generate virtual items based on recurrence
            foreach(var workItem in myPlanWorkItems)
            {
                if (workItem.IsRecurring && workItem.Interval != 0 && workItem.Period != 0)
                {
                    for(var i = 1; i < workItem.Period; i++)
                    {
                        var virtualWorkItem = new MyPlanItem
                        {
                            Category = workItem.Category,
                            Machine = workItem.Machine,
                            ProfileName = workItem.ProfileName,
                            Description = workItem.Description,
                            IsRecurring = workItem.IsRecurring,
                            ScheduleDate = workItem.ScheduleDate.AddDays(i * workItem.Interval),
                            Status = WorkStatusEnum.Pending,
                            UpkeepTemplateDetailId = workItem.UpkeepTemplateDetailId,
                            UpkeepTemplateId = workItem.UpkeepTemplateId,
                            WorkDescription = workItem.WorkDescription,
                            Interval = workItem.Interval,
                            Period = workItem.Period,
                            OwnerName = workItem.OwnerName,
                            TemplateWorkDetail = workItem.TemplateWorkDetail
                        };
                        virtualItems.Add(virtualWorkItem);
                    }
                }
            }

            myPlanWorkItems.AddRange(virtualItems);

            // Replace the work items with non-virtual work items
            var relatedtemplateDetails = myPlanWorkItems.Select(x => x.UpkeepTemplateDetailId).Distinct().ToList();
            var existingWorkItems = _myPlanRepository.GetAll()
                .Include(x => x.Assistant)
                .Where(x => relatedtemplateDetails.Contains(x.UpkeepTemplateDetailId))
                .Select(x => new MyPlanItem
                {
                    WorkPlanItemId = x.WorkPlanItemId,
                    UpkeepTemplateDetailId = x.UpkeepTemplateDetailId,
                    WorkedByUserId = x.WorkedByUserId,
                    Category = x.TemplateWorkDetail.Template.Machine.Category,
                    Machine = x.TemplateWorkDetail.Template.Machine.Name,
                    ProfileName = x.TemplateWorkDetail.Template.ProfileName,
                    Description = x.TemplateWorkDetail.Template.Description,
                    IsRecurring = x.TemplateWorkDetail.IsRecurring,
                    ScheduleDate = x.ScheduleDate,
                    Status = x.Status,
                    OwnerName = x.TemplateWorkDetail.Template.Author.FullName,
                    WorkDescription = x.TemplateWorkDetail.Description,
                    Interval = x.TemplateWorkDetail.Interval,
                    Period = x.TemplateWorkDetail.Period,
                    TemplateWorkDetail = Mapper.Map<UpkeepTemplateDetail>(x.TemplateWorkDetail),
                    Assistant = Mapper.Map<User>(x.Assistant),
                    StartWorkDateTime = x.StartWorkDateTime,
                    CompleteWorkDateTime = x.CompleteWorkDateTime,
                    NeedActionDateTime = x.NeedActionDateTime
                })
                .ToList();

            if (existingWorkItems.Any())
            {
                var existingWorkItemsKeys = existingWorkItems.Select(x => new { x.UpkeepTemplateDetailId, x.ScheduleDate }).ToList();
                myPlanWorkItems.RemoveAll(x => existingWorkItemsKeys.Contains(new { x.UpkeepTemplateDetailId, x.ScheduleDate }));

                myPlanWorkItems.AddRange(existingWorkItems);
            }

            // Filters
            myPlanWorkItems = myPlanWorkItems.Where(x => x.ScheduleDate.Date >= requestHelper.StartDate && x.ScheduleDate.Date <= requestHelper.EndDate).OrderBy(x => x.ScheduleDate).ToList();

            if (requestHelper.UpkeepTemplateDetailIds != null && requestHelper.UpkeepTemplateDetailIds.Any())
            {
                myPlanWorkItems = myPlanWorkItems.Where(x => requestHelper.UpkeepTemplateDetailIds.Contains(x.UpkeepTemplateDetailId)).ToList();
            }

            return myPlanWorkItems;
        }

       
    }
}