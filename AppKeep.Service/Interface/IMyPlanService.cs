using AppKeep.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppKeep.Service
{
    public interface IMyPlanService
    {
        Task<MyPlanItem> AddMyPlanAsync(MyPlanItem planItem);

        Task<List<MyPlanItem>> GetAllMyPlansAsync();

        Task<MyPlanItem> GetMyPlanByIdAsync(int id);

        Task<MyPlanItem> UpdatePlanAsync(MyPlanItem planItem);

        Task<MyPlanItem> SaveOrUpdatePlanAsync(MyPlanItem planItem);
    }
}