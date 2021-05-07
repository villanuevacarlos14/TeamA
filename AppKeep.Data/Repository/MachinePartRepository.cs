using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppKeep.Data.Repository
{
    public class MachinePartRepository : Repository<MachinePartEntity>, IMachinePartRepository
    {
        public MachinePartRepository(AppKeepContext context) : base(context)
        {

        }

        public async Task<List<MachinePartEntity>> GetMachinePartsByMachineAsync(int machineId)
        {
            return await GetAll()
                .Where(p => p.MachineId == machineId)
                .ToListAsync();
        }
    }
}