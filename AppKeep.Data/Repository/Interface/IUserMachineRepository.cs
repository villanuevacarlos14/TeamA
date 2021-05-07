using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppKeep.Data.Repository
{
    public interface IUserMachineRepository : IRepository<UserMachineEntity>
    {
        Task<List<UserMachineEntity>> GetUserMachines(int userId);

        Task<UserMachineEntity> UpdateAsync(UserMachineEntity entity);
    }
}