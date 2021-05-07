using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AppKeep.Data.Repository
{
    public class UpkeepTemplateDetailRepository : Repository<UpkeepTemplateDetailEntity>, IUpkeepTemplateDetailRepository
    {
        public UpkeepTemplateDetailRepository(AppKeepContext context) : base(context)
        {

        }

        public async Task<UpkeepTemplateDetailEntity> GetUpkeepTemplateDetailsPart(int templateDetailId)
        {
            var upkeeptemplateDetail = await GetAll().Where(t => t.UpkeepTemplateDetailId == templateDetailId).AsNoTracking().SingleOrDefaultAsync();

            return upkeeptemplateDetail;
        }

        public async Task<List<UpkeepTemplateDetailEntity>> GetAllByTemplateId(int templateId)
        {
            var upkeeptemplateDetail = await GetAll().Where(t => t.UpkeepProfileTemplateId == templateId).ToListAsync();

            return upkeeptemplateDetail;
        }

        public async Task<UpkeepTemplateDetailEntity> UpdateAsync(UpkeepTemplateDetailEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(AddAsync)} entity must not be null");
            }

            try
            {
                var upkeepTempDetail = _context.UpkeepTemplateDetails.First(e => e.UpkeepTemplateDetailId == entity.UpkeepTemplateDetailId);
                _context.Entry(upkeepTempDetail).CurrentValues.SetValues(entity);
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