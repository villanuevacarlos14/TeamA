using AppKeep.Data;
using AppKeep.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppKeep.Service
{
    public interface IMachineService
    {
        Task<Machine> AddMachineAsync(Machine machine);

        Task<List<Machine>> GetAllMachinesAsync();

        Task<Machine> GetMachineByIdAsync(int id);

        Task<Machine> UpdateMachineAsync(Machine machine);

        Task<IEnumerable<Machine>> SearchMachine(string searchValue);
    }
}