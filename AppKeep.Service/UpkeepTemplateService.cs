using AppKeep.Data;
using AppKeep.Data.Repository;
using AppKeep.Domain;
using AppKeep.Service.Mapping;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System;

namespace AppKeep.Service
{
    public class UpkeepTemplateService : IUpkeepTemplateService, IAutoMapperService
    {
        private readonly IUpkeepTemplateRepository _upkeepTemplateRepository;
        private readonly IUpkeepTemplateDetailService _upkeepTemplateDetailService;

        public IMapper Mapper
        {
            get { return ObjectMapper.Mapper; }
        }

        public UpkeepTemplateService(IUpkeepTemplateRepository upkeepTemplateRepository,
            IUpkeepTemplateDetailService upkeepTemplateDetailService)
        {
            _upkeepTemplateRepository = upkeepTemplateRepository;
            _upkeepTemplateDetailService = upkeepTemplateDetailService;
        }

        public async Task<UpkeepTemplate> AddUpkeepTemplateAsync(UpkeepTemplate upkeepTemplate)
        {
            var upkeepTemplateEntity = Mapper.Map<UpkeepTemplateEntity>(upkeepTemplate);

            if (upkeepTemplate.UpkeepProfileTemplateId == 0)
            {
                upkeepTemplateEntity = await _upkeepTemplateRepository.AddAsync(upkeepTemplateEntity);
            }
            else
            {
                upkeepTemplateEntity = await _upkeepTemplateRepository.UpdateV2Async(upkeepTemplateEntity);
            }

            upkeepTemplate = Mapper.Map<UpkeepTemplate>(upkeepTemplateEntity);

            foreach (var upkeepDetail in upkeepTemplate.UpkeepTemplateDetails)
            {
                await _upkeepTemplateDetailService.SetUpkeepDetailWorkItem(upkeepDetail);
            }

            return upkeepTemplate;
        }

        public async Task<List<UpkeepTemplate>> GetAllUpkeepTemplatesAsync()
        {
            var upkeepTemplateEntities = await _upkeepTemplateRepository.GetAll().ToListAsync();

            return Mapper.Map<List<UpkeepTemplate>>(upkeepTemplateEntities);
        }

        public async Task<List<UpkeepTemplate>> GetTemplatesFilteredByMachineNameAsync(string machineName)
        {

            // .Include(x=>x.UpkeepTemplateDetails)
            // .Include(r=>r.UserMachine)
            // .ThenInclude(x=>x.Machine)
            var upkeepTemplateEntities = await _upkeepTemplateRepository
            .GetAll()
            .Include(x=>x.UpkeepTemplateDetails)
            .Include(x=>x.UserMachine)
            .ThenInclude(x=>x.Machine)
            .Where(x=>x.UserMachine.Machine.Name.ToLower().Contains(machineName.ToLower()) || x.UserMachine.Machine.Make.ToLower().Contains(machineName.ToLower()))
            .ToListAsync();

            return Mapper.Map<List<UpkeepTemplate>>(upkeepTemplateEntities);
        } 

        public async Task<UpkeepTemplate> GetUpkeepTemplateByIdAsync(int id)
        {
            var upkeepTemplateEntity = await _upkeepTemplateRepository
                .GetAll()
                .Include(x => x.UpkeepTemplateDetails)
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.UpkeepProfileTemplateId == id);

            var upkeepTemplate = Mapper.Map<UpkeepTemplate>(upkeepTemplateEntity);

            return upkeepTemplate;
        }

        public async Task<UpkeepTemplate> UpdateUpkeepTemplateAsync(UpkeepTemplate upkeepTemplate)
        {
            var upkeepTemplateEntity = Mapper.Map<UpkeepTemplateEntity>(upkeepTemplate);

            upkeepTemplateEntity = await _upkeepTemplateRepository.UpdateAsync(upkeepTemplateEntity);

            upkeepTemplate = Mapper.Map<UpkeepTemplate>(upkeepTemplateEntity);

            return upkeepTemplate;
        }

        public void RemoveUpkeepProfile(UpkeepTemplate upkeepTemplate)
        {
            var upkeepTemplateEntity = Mapper.Map<UpkeepTemplateEntity>(upkeepTemplate);
            _upkeepTemplateRepository.Delete(upkeepTemplateEntity);
        }
    }
}