using AppKeep.Domain;
using System.Threading.Tasks;

namespace AppKeep.Service
{
    public class UserAuthenticationService : IUserAuthenticationService
    {
        private readonly IUserService _userService;

        public UserAuthenticationService(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<AuthenticateUserResponse> AuthenticateUser(string email, string password)
        {
            var response = new AuthenticateUserResponse();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                return response;
            }

            // Load user by email address
            var user = await _userService.GetUserByEmailAsync(email);

            if (user != null)
            {
                response.EmailAddressFound = true;
                response.PasswordValid = user.Password == password;  // Validate password
                response.Authenticated = response.PasswordValid;
                response.User = user;
            }

            return response;
        }
    }
}