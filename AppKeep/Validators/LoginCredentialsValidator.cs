using AppKeep.Domain;
using AppKeep.Service;
using AppKeep.Web.Data;
using FluentValidation;
using System.Threading;
using System.Threading.Tasks;

namespace AppKeep.Web.Validators
{
    public class LoginCredentialsValidator : AbstractValidator<LoginCredentials>
    {
        private readonly IUserAuthenticationService _userAuthenticationService;

        private AuthenticateUserResponse _authenticateUserResponse = null;

        public LoginCredentialsValidator(IUserAuthenticationService userAuthenticationService)
        {
            _userAuthenticationService = userAuthenticationService;

            RuleFor(x => x.EmailAddress)
                .NotEmpty()
                .WithMessage("Email address is required");

            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage("Password is required");

            When(x => !string.IsNullOrEmpty(x.EmailAddress), () => {
                RuleFor(x => x)
                    .NotEmpty()
                    .MustAsync(AuthenticateEmailAddress)
                    .WithMessage("User not found for the given email address");
            });

            When(x => !string.IsNullOrEmpty(x.EmailAddress) && !string.IsNullOrEmpty(x.Password), () => {
                RuleFor(x => x)
                    .NotEmpty()
                    .MustAsync(AuthenticatePassword)
                    .WithMessage("Password is invalid for the given email address");
            });
        }

        private async Task<bool> AuthenticateEmailAddress(LoginCredentials loginCredentials, CancellationToken token)
        {
            if (_authenticateUserResponse == null)
            {
                _authenticateUserResponse = await _userAuthenticationService.AuthenticateUser(loginCredentials.EmailAddress, loginCredentials.Password);
            }

            return _authenticateUserResponse.EmailAddressFound;
        }

        private async Task<bool> AuthenticatePassword(LoginCredentials loginCredentials, CancellationToken token)
        {
            if (_authenticateUserResponse == null)
            {
                _authenticateUserResponse = await _userAuthenticationService.AuthenticateUser(loginCredentials.EmailAddress, loginCredentials.Password);
            }

            return _authenticateUserResponse.PasswordValid;
        }
    }
}