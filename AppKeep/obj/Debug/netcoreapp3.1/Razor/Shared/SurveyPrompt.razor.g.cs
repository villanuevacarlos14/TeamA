#pragma checksum "/Users/carlosvillanuevaiii/Projects/TeamA/AppKeep/Shared/SurveyPrompt.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0743694fcb99c939d89423a23f9d8c1561b32b11"
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
    public partial class SurveyPrompt : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "alert alert-secondary mt-4");
            __builder.AddAttribute(2, "role", "alert");
            __builder.AddMarkupContent(3, "<span class=\"oi oi-pencil mr-2\" aria-hidden=\"true\"></span>\n    ");
            __builder.OpenElement(4, "strong");
            __builder.AddContent(5, 
#nullable restore
#line 3 "/Users/carlosvillanuevaiii/Projects/TeamA/AppKeep/Shared/SurveyPrompt.razor"
             Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\n\n    ");
            __builder.AddMarkupContent(7, "<span class=\"text-nowrap\">\n        Please take our\n        <a target=\"_blank\" class=\"font-weight-bold\" href=\"https://go.microsoft.com/fwlink/?linkid=2112271\">brief survey</a></span>\n    and tell us what you think.\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "/Users/carlosvillanuevaiii/Projects/TeamA/AppKeep/Shared/SurveyPrompt.razor"
       
    // Demonstrates how a parent component can supply parameters
    [Parameter]
    public string Title { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
