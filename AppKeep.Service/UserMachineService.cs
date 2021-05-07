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
    public class UserMachineService : IUserMachineService, IAutoMapperService
    {
        private readonly IUserMachineRepository _userMachineRepository;
        private readonly IUpkeepTemplateDetailService _upkeepDetailService;

        public IMapper Mapper
        {
            get { return ObjectMapper.Mapper; }
        }

        public UserMachineService(IUserMachineRepository userMachineRepository,
            IUpkeepTemplateDetailService upkeepDetailService)
        {
            _userMachineRepository = userMachineRepository;
            _upkeepDetailService = upkeepDetailService;
        }

        public async Task<UserMachine> AddUserMachineAsync(UserMachine userMachine)
        {
            var userMachineEntity = Mapper.Map<UserMachineEntity>(userMachine);

            userMachineEntity = await _userMachineRepository.AddAsync(userMachineEntity);

            userMachine = Mapper.Map<UserMachine>(userMachineEntity);

            return userMachine;
        }

        public async Task<List<UserMachine>> GetUserMachines(int userId)
        {
            var userMachineEntities = await _userMachineRepository.GetUserMachines(userId);

            return Mapper.Map<List<UserMachine>>(userMachineEntities);
        }

        public async Task<List<UserMachine>> GetAllUserMachinesAsync()
        {
            var userMachineEntities = await _userMachineRepository.GetAll().ToListAsync();

            return Mapper.Map<List<UserMachine>>(userMachineEntities);
        }

        public async Task<UserMachine> GetUserMachineByIdAsync(int id)
        {
            var userMachineEntity = await _userMachineRepository
                .GetAll()
                .Include(u => u.Machine)
                .Include(x => x.UpkeepProfiles)
                .ThenInclude(x => x.UpkeepTemplateDetails)
                .ThenInclude(x => x.Assistant)
                .AsNoTracking()
                .FirstOrDefaultAsync(u => u.UserMachineId == id);

            var machine = Mapper.Map<UserMachine>(userMachineEntity);

            // Set the work items for work items on the user machine profile(s)
            var workItems = await _upkeepDetailService.GetUpkeepTemplateDetailByIdForPlan(new MyPlanFilters
            {
                UpkeepTemplateDetailIds = userMachineEntity.UpkeepProfiles.SelectMany(x => x.UpkeepTemplateDetails.Select(y => y.UpkeepTemplateDetailId)).ToList(),
                StartDate = DateTime.Now.Date,
                EndDate = DateTime.Now.Date.AddDays(1).AddMilliseconds(-1),
                UserId = userMachineEntity.UserId
            });

            foreach(var profile in machine.UpkeepProfiles)
            {
                foreach (var profileDetail in profile.UpkeepTemplateDetails)
                {
                    profileDetail.WorkItem = workItems.FirstOrDefault(x => x.UpkeepTemplateDetailId == profileDetail.UpkeepTemplateDetailId);
                }
            }

            return machine;
        }

        public async Task<UserMachine> UpdateUserMachineAsync(UserMachine userMachine)
        {
            var userMachineEntity = Mapper.Map<UserMachineEntity>(userMachine);

            userMachineEntity = await _userMachineRepository.UpdateAsync(userMachineEntity);

            userMachine = Mapper.Map<UserMachine>(userMachineEntity);

            return userMachine;
        }

        public async Task RemoveUserMachine(UserMachine userMachine)
        {
            var userMachineEntity = Mapper.Map<UserMachineEntity>(userMachine);
            await _userMachineRepository.Delete(userMachineEntity);
        }
    }
}