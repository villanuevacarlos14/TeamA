using AppKeep.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppKeep.Service
{
    public interface IUpkeepProfileService
    {
        Task<List<UpkeepProfile>> GetAllUpkeepProfilesAsync();

        Task<UpkeepProfile> GetUpkeepProfileByIdAsync(int id);

        Task<UpkeepProfile> AddUpkeepProfileAsync(UpkeepProfile upkeepProfile);

        Task<UpkeepProfile> UpdateUpkeepProfileAsync(UpkeepProfile upkeepProfile);
    }
}