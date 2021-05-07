using AppKeep.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppKeep.Service
{
    public interface IUpkeepTemplateService
    {
        Task<UpkeepTemplate> AddUpkeepTemplateAsync(UpkeepTemplate upkeepTemplate);

        Task<List<UpkeepTemplate>> GetAllUpkeepTemplatesAsync();

        Task<UpkeepTemplate> GetUpkeepTemplateByIdAsync(int id);

        Task<UpkeepTemplate> UpdateUpkeepTemplateAsync(UpkeepTemplate upkeepTemplate);

        void RemoveUpkeepProfile(UpkeepTemplate upkeepProfile);
       Task<List<UpkeepTemplate>> GetTemplatesFilteredByMachineNameAsync(string machineName);
    }
}