// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AppKeep.Web.Pages.Authentication
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/carlosvillanuevaiii/Documents/Carlos Personal/Projects/TeamA/AppKeep/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/carlosvillanuevaiii/Documents/Carlos Personal/Projects/TeamA/AppKeep/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/carlosvillanuevaiii/Documents/Carlos Personal/Projects/TeamA/AppKeep/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/carlosvillanuevaiii/Documents/Carlos Personal/Projects/TeamA/AppKeep/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/carlosvillanuevaiii/Documents/Carlos Personal/Projects/TeamA/AppKeep/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/carlosvillanuevaiii/Documents/Carlos Personal/Projects/TeamA/AppKeep/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/carlosvillanuevaiii/Documents/Carlos Personal/Projects/TeamA/AppKeep/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/carlosvillanuevaiii/Documents/Carlos Personal/Projects/TeamA/AppKeep/_Imports.razor"
using AppKeep;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/carlosvillanuevaiii/Documents/Carlos Personal/Projects/TeamA/AppKeep/_Imports.razor"
using AppKeep.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/carlosvillanuevaiii/Documents/Carlos Personal/Projects/TeamA/AppKeep/_Imports.razor"
using AppKeep.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/carlosvillanuevaiii/Documents/Carlos Personal/Projects/TeamA/AppKeep/_Imports.razor"
using AppKeep.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/carlosvillanuevaiii/Documents/Carlos Personal/Projects/TeamA/AppKeep/_Imports.razor"
using AppKeep.Web.Pages.MyMachines;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/carlosvillanuevaiii/Documents/Carlos Personal/Projects/TeamA/AppKeep/_Imports.razor"
using AppKeep.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/carlosvillanuevaiii/Documents/Carlos Personal/Projects/TeamA/AppKeep/_Imports.razor"
using AppKeep.Web.Pages.UpkeepTemplate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/carlosvillanuevaiii/Documents/Carlos Personal/Projects/TeamA/AppKeep/_Imports.razor"
using AppKeep.Web.Shared.TabControl;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/carlosvillanuevaiii/Documents/Carlos Personal/Projects/TeamA/AppKeep/Pages/Authentication/Login.razor"
using AppKeep.Web.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/carlosvillanuevaiii/Documents/Carlos Personal/Projects/TeamA/AppKeep/Pages/Authentication/Login.razor"
using AppKeep.Web.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/carlosvillanuevaiii/Documents/Carlos Personal/Projects/TeamA/AppKeep/Pages/Authentication/Login.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/carlosvillanuevaiii/Documents/Carlos Personal/Projects/TeamA/AppKeep/Pages/Authentication/Login.razor"
using System.Web;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/authentication/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "/Users/carlosvillanuevaiii/Documents/Carlos Personal/Projects/TeamA/AppKeep/Pages/Authentication/Login.razor"
       
    public LoginCredentials LoginCredentials = new LoginCredentials();
    protected bool Disabled { get; set; } = false;

    protected void DisableButtons()
    {
        Disabled = true;
    }

    protected void SubmitLoginCredentials(EditContext editContext)
    {
        if (editContext.Validate())
        {
            // Validate method confirms credentials

            var usernameEncoded = Encode(LoginCredentials.EmailAddress);
            var passwordEncoded = Encode(LoginCredentials.Password);

            NavigationManager.NavigateTo($"/authentication/loginprocess?username={usernameEncoded}&password={passwordEncoded}", forceLoad: true);
        }
        else
        {
            Disabled = false;
        }
    }

    private string Encode(string param)
    {
        return HttpUtility.UrlEncode(param);
    }

    private string CurrentYear()
    {
        // Don't you know it's the Current Year!!!!
        return DateTime.Now.Year.ToString();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor httpContextAccessor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserAuthenticationService UserAuthenticationService { get; set; }
    }
}
#pragma warning restore 1591
