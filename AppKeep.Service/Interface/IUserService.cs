using AppKeep.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppKeep.Service
{
    public interface IUserService
    {
        Task<User> AddUserAsync(User user);

        Task<List<User>> GetAllUsersAsync();

        Task<User> GetUserByIdAsync(int id);

        Task<User> GetUserByEmailAsync(string email);

        Task<User> UpdateUserAsync(User user);
    }
}