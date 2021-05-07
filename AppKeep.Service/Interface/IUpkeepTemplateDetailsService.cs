using AppKeep.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppKeep.Service
{
    public interface IUpkeepTemplateDetailService
    {
        Task<UpkeepTemplateDetail> AddUpkeepTemplateDetailAsync(UpkeepTemplateDetail upkeepTemplate, int userId);

        Task<List<UpkeepTemplateDetail>> GetAllUpkeepTemplateDetailsAsync();

        Task<UpkeepTemplateDetail> GetUpkeepTemplateDetailByIdAsync(int id);

        Task<UpkeepTemplateDetail> UpdateUpkeepTemplateDetailAsync(UpkeepTemplateDetail upkeepTemplate, int userId);
        Task<UpkeepTemplateDetail> GetUpkeepTemplateDetailByIdForPartAsync(int id);
        Task<List<MyPlanItem>> GetUpkeepTemplateDetailByIdForPlan(MyPlanFilters request);

        Task SetUpkeepDetailWorkItem(UpkeepTemplateDetail upkeepTemplateDetail, int userId = 0);

        Task DeleteWorkItem(UpkeepTemplateDetail upkeepTemplateDetail);

    }
}