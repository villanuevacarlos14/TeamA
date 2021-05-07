using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppKeep.Data.Repository
{
    public interface IMachinePartRepository : IRepository<MachinePartEntity>
    {
        Task<List<MachinePartEntity>> GetMachinePartsByMachineAsync(int machineId);
    }
}