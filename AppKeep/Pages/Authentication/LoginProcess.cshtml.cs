using AppKeep.Service;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AppKeep.Web.Pages.Authentication
{
    public class LoginProcessModel : PageModel
    {
        protected IUserAuthenticationService _userAuthenticationService { get; set; }

        public LoginProcessModel(IUserAuthenticationService userAuthenticationService)
        {
            _userAuthenticationService = userAuthenticationService;
        }

        public async Task<IActionResult> OnGetAsync(string username, string password)
        {
            try
            {
                // Clear the existing external cookie
                await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            }
            catch { }

            var authenticateUserResponse = await _userAuthenticationService.AuthenticateUser(username, password);

            if (authenticateUserResponse.Authenticated)
            {
                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name, authenticateUserResponse.User.Email),
                    new Claim("UserId", authenticateUserResponse.User.UserId.ToString()),
                    new Claim("UserType", authenticateUserResponse.User.UserType.ToString()),
                    new Claim("FullName", $"{authenticateUserResponse.User.FirstName} {authenticateUserResponse.User.LastName}"),
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties
                {
                    IsPersistent = true,
                    RedirectUri = this.Request.Host.Value
                };

                try
                {
                    await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    authProperties);
                }
                catch (Exception ex)
                {
                    string error = ex.Message;
                }

                return LocalRedirect(Url.Content("~/search"));
            }
            else
            {
                return LocalRedirect(Url.Content("~/authentication/login"));
            }
        }
    }
}