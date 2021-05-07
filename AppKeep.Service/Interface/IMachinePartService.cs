using AppKeep.Data;
using AppKeep.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppKeep.Service
{
    public interface IMachinePartService
    {
        Task<MachinePart> AddMachinePartAsync(MachinePart machinePart);

        Task<MachinePart> GetMachinePartByIdAsync(int id);

        Task<List<MachinePart>> GetAllMachinePartsAsync();

        Task<MachinePart> UpdateMachinePartAsync(MachinePart machinePart);
    }
}