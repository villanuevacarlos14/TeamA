using AppKeep.Domain;
using System.Threading.Tasks;

namespace AppKeep.Service
{
    public interface IUserAuthenticationService
    {
        Task<AuthenticateUserResponse> AuthenticateUser(string email, string password);
    }
}