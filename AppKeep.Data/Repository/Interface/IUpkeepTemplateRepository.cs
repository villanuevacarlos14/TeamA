using System.Threading.Tasks;

namespace AppKeep.Data.Repository
{
    public interface IUpkeepTemplateRepository : IRepository<UpkeepTemplateEntity>
    {
        Task<UpkeepTemplateEntity> UpdateV2Async(UpkeepTemplateEntity entity);
    }
}