using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppKeep.Data.Repository
{
    public interface IUpkeepTemplateDetailRepository : IRepository<UpkeepTemplateDetailEntity>
    {
        Task<UpkeepTemplateDetailEntity> GetUpkeepTemplateDetailsPart(int templateDetailId);
        Task<List<UpkeepTemplateDetailEntity>> GetAllByTemplateId(int templateId);
    }
}