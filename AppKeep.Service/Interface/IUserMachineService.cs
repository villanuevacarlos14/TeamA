using AppKeep.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppKeep.Service
{
    public interface IUserMachineService
    {
        Task<List<UserMachine>> GetUserMachines(int userId);

        Task<UserMachine> AddUserMachineAsync(UserMachine userMachine);

        Task<List<UserMachine>> GetAllUserMachinesAsync();

        Task<UserMachine> GetUserMachineByIdAsync(int id);

        Task<UserMachine> UpdateUserMachineAsync(UserMachine userMachine);

        Task RemoveUserMachine(UserMachine userMachine);
    }
}