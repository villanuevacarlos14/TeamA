using System;
using System.Linq;
using System.Threading.Tasks;

namespace AppKeep.Data.Repository
{
    public class UpkeepTemplateRepository : Repository<UpkeepTemplateEntity>, IUpkeepTemplateRepository
    {
        public UpkeepTemplateRepository(AppKeepContext context) : base(context)
        {

        }

        public async Task<UpkeepTemplateEntity> UpdateV2Async(UpkeepTemplateEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(AddAsync)} entity must not be null");
            }

            try
            {
                var upkeepTemplate = _context.UpkeepTemplates.First(e => e.UpkeepProfileTemplateId == entity.UpkeepProfileTemplateId);
                _context.Entry(upkeepTemplate).CurrentValues.SetValues(entity);
                await _context.SaveChangesAsync();

                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(entity)} could not be updated: {ex.Message}");
            }
        }
    }
}