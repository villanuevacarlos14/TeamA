using AppKeep.Data;
using AppKeep.Data.Repository;
using AppKeep.Domain;
using AppKeep.Service.Mapping;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppKeep.Service
{
    public class UpkeepProfileService : IUpkeepProfileService, IAutoMapperService
    {
        private readonly IUpkeepProfileRepository _upkeepProfileRepository;

        public IMapper Mapper
        {
            get { return ObjectMapper.Mapper; }
        }

        public UpkeepProfileService(IUpkeepProfileRepository upkeepProfileRepository)
        {
            _upkeepProfileRepository = upkeepProfileRepository;
        }

        public async Task<UpkeepProfile> AddUpkeepProfileAsync(UpkeepProfile upkeepProfile)
        {
            var upkeepProfileEntity = Mapper.Map<UpkeepProfileEntity>(upkeepProfile);

            upkeepProfileEntity = await _upkeepProfileRepository.AddAsync(upkeepProfileEntity);

            upkeepProfile = Mapper.Map<UpkeepProfile>(upkeepProfileEntity);

            return upkeepProfile;
        }

        public async Task<List<UpkeepProfile>> GetAllUpkeepProfilesAsync()
        {
            var upkeepProfileEntities = await _upkeepProfileRepository.GetAll().ToListAsync();

            return Mapper.Map<List<UpkeepProfile>>(upkeepProfileEntities);
        }

        public async Task<UpkeepProfile> GetUpkeepProfileByIdAsync(int id)
        {
            var upkeepProfileEntity = await _upkeepProfileRepository.GetAsync(id);

            var machine = Mapper.Map<UpkeepProfile>(upkeepProfileEntity);

            return machine;
        }

        public async Task<UpkeepProfile> UpdateUpkeepProfileAsync(UpkeepProfile upkeepProfile)
        {
            var upkeepProfileEntity = Mapper.Map<UpkeepProfileEntity>(upkeepProfile);

            upkeepProfileEntity = await _upkeepProfileRepository.UpdateAsync(upkeepProfileEntity);

            upkeepProfile = Mapper.Map<UpkeepProfile>(upkeepProfileEntity);

            return upkeepProfile;
        }
    }
}