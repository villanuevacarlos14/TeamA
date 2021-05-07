using AppKeep.Data;
using AppKeep.Data.Repository;
using AppKeep.Domain;
using AppKeep.Service.Mapping;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppKeep.Service
{
    public class MyPlanService : IMyPlanService, IAutoMapperService
    {
        private readonly IMyPlanRepository _myPlanRepository;

        public IMapper Mapper
        {
            get { return ObjectMapper.Mapper; }
        }

        public MyPlanService(IMyPlanRepository myPlanRepository)
        {
            _myPlanRepository = myPlanRepository;
        }

        public async Task<MyPlanItem> AddMyPlanAsync(MyPlanItem planItem)
        {
            var myPlanEntity = Mapper.Map<MyPlanEntity>(planItem);

            myPlanEntity = await _myPlanRepository.AddAsync(myPlanEntity);

            planItem = Mapper.Map<MyPlanItem>(myPlanEntity);

            return planItem;
        }

        public async Task<List<MyPlanItem>> GetAllMyPlansAsync()
        {
            var myPlanEntities = await _myPlanRepository.GetAll().ToListAsync();

            return Mapper.Map<List<MyPlanItem>>(myPlanEntities);
        }

        public async Task<MyPlanItem> GetMyPlanByIdAsync(int id)
        {
            var myPlanEntity = await _myPlanRepository.GetAsync(id);

            var planItem = Mapper.Map<MyPlanItem>(myPlanEntity);

            return planItem;
        }

        public async Task<MyPlanItem> UpdatePlanAsync(MyPlanItem planItem)
        {
            var myPlanEntity = Mapper.Map<MyPlanEntity>(planItem);

            myPlanEntity = await _myPlanRepository.UpdateAsync(myPlanEntity);

            planItem = Mapper.Map<MyPlanItem>(myPlanEntity);

            return planItem;
        }

        public async Task<MyPlanItem> SaveOrUpdatePlanAsync(MyPlanItem planItem)
        {
            planItem.TemplateWorkDetail = null;
            //planItem.Assistant = null;
            if (planItem.WorkPlanItemId != 0)
            {
                return await UpdatePlanAsync(planItem);
            }
            else
            {
                return await AddMyPlanAsync(planItem);
            }
        }
    }
}