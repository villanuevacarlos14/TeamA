#pragma checksum "/Users/carlosvillanuevaiii/Projects/TeamA/AppKeep/Shared/LoginControl.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a64fe5052112a29a4970384a6fbcfbb34939ae3"
// <auto-generated/>
#pragma warning disable 1591
namespace AppKeep.Web.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/carlosvillanuevaiii/Projects/TeamA/AppKeep/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/carlosvillanuevaiii/Projects/TeamA/AppKeep/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/carlosvillanuevaiii/Projects/TeamA/AppKeep/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/carlosvillanuevaiii/Projects/TeamA/AppKeep/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/carlosvillanuevaiii/Projects/TeamA/AppKeep/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/carlosvillanuevaiii/Projects/TeamA/AppKeep/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/carlosvillanuevaiii/Projects/TeamA/AppKeep/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/carlosvillanuevaiii/Projects/TeamA/AppKeep/_Imports.razor"
using AppKeep;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/carlosvillanuevaiii/Projects/TeamA/AppKeep/_Imports.razor"
using AppKeep.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/carlosvillanuevaiii/Projects/TeamA/AppKeep/_Imports.razor"
using AppKeep.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/carlosvillanuevaiii/Projects/TeamA/AppKeep/_Imports.razor"
using AppKeep.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/carlosvillanuevaiii/Projects/TeamA/AppKeep/_Imports.razor"
using AppKeep.Web.Pages.MyMachines;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/carlosvillanuevaiii/Projects/TeamA/AppKeep/_Imports.razor"
using AppKeep.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/carlosvillanuevaiii/Projects/TeamA/AppKeep/_Imports.razor"
using AppKeep.Web.Pages.UpkeepTemplate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/carlosvillanuevaiii/Projects/TeamA/AppKeep/_Imports.razor"
using AppKeep.Web.Shared.TabControl;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/carlosvillanuevaiii/Projects/TeamA/AppKeep/Shared/LoginControl.razor"
using System.Web;

#line default
#line hidden
#nullable disable
    public partial class LoginControl : PageBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\n        Hello, ");
                __builder2.AddContent(3, 
#nullable restore
#line 6 "/Users/carlosvillanuevaiii/Projects/TeamA/AppKeep/Shared/LoginControl.razor"
                GetFullName()

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(4, "!&nbsp;\n        ");
                __builder2.AddMarkupContent(5, "<a class=\"ml-md-auto btn btn-link\" href=\"/authentication/logout?returnUrl=/\" target=\"_top\">Logout</a>");
            }
            ));
            __builder.AddAttribute(6, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "/Users/carlosvillanuevaiii/Projects/TeamA/AppKeep/Shared/LoginControl.razor"
       
    string Username = "";
    string Password = "";
    private string encode(string param)
    {
        return HttpUtility.UrlEncode(param);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591