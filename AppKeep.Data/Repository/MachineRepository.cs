using System;
using System.Linq;
using System.Threading.Tasks;

namespace AppKeep.Data.Repository
{
    public class MachineRepository : Repository<MachineEntity>, IMachineRepository
    {
        public MachineRepository(AppKeepContext context) : base(context)
        {

        }

        public async Task<MachineEntity> UpdateAsync(MachineEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(AddAsync)} entity must not be null");
            }

            try
            {
                var machine = _context.Machines.First(e => e.MachineId == entity.MachineId);
                _context.Entry(machine).CurrentValues.SetValues(entity);
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