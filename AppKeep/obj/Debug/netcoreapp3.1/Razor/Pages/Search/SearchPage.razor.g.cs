#pragma checksum "/Users/carlosvillanuevaiii/Projects/TeamA/AppKeep/Pages/Search/SearchPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ac21b36c9aa9eded2dabfe03aed9677c0ac8777"
// <auto-generated/>
#pragma warning disable 1591
namespace AppKeep.Web.Pages.Search
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
#line 12 "/Users/carlosvillanuevaiii/Projects/TeamA/AppKeep/_Imports.razor"
using AppKeep.Web.Pages.MyMachines;

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
#line 3 "/Users/carlosvillanuevaiii/Projects/TeamA/AppKeep/Pages/Search/SearchPage.razor"
using AppKeep.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/carlosvillanuevaiii/Projects/TeamA/AppKeep/Pages/Search/SearchPage.razor"
using AppKeep.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/carlosvillanuevaiii/Projects/TeamA/AppKeep/Pages/Search/SearchPage.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/carlosvillanuevaiii/Projects/TeamA/AppKeep/Pages/Search/SearchPage.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/search")]
    public partial class SearchPage : PageBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 12 "/Users/carlosvillanuevaiii/Projects/TeamA/AppKeep/Pages/Search/SearchPage.razor"
 if (isVisible)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<AppKeep.Web.Pages.Search.SearchComponent>(0);
            __builder.AddAttribute(1, "SearchValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 14 "/Users/carlosvillanuevaiii/Projects/TeamA/AppKeep/Pages/Search/SearchPage.razor"
                                         SearchValueChanged

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(2, "IsCompact", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "/Users/carlosvillanuevaiii/Projects/TeamA/AppKeep/Pages/Search/SearchPage.razor"
                                                                         isCompact

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container pt-2");
            __builder.AddAttribute(6, "style", "max-height: 800px; margin-bottom: 30px;");
            __builder.AddMarkupContent(7, "<div class=\"progress\" hidden=\"isHidden\"><div class=\"progress-bar progress-bar-striped progress-bar-animated\" role=\"progressbar\" aria-valuenow=\"100\" aria-valuemin=\"0\" aria-valuemax=\"100\" style=\"width: 100%\"></div></div>\n        ");
            __builder.OpenComponent<AppKeep.Web.Pages.Search.SearchListComponent>(8);
            __builder.AddAttribute(9, "Templates", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<AppKeep.Domain.UpkeepTemplate>>(
#nullable restore
#line 19 "/Users/carlosvillanuevaiii/Projects/TeamA/AppKeep/Pages/Search/SearchPage.razor"
                                                     templates

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(10, (__value) => {
#nullable restore
#line 19 "/Users/carlosvillanuevaiii/Projects/TeamA/AppKeep/Pages/Search/SearchPage.razor"
                                   child = (AppKeep.Web.Pages.Search.SearchListComponent)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "row text-center");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col-md-12 text-center");
            __builder.AddMarkupContent(16, "<span>OR</span>\n            <br>\n            <br>\n            ");
            __builder.OpenComponent<AppKeep.Web.Pages.SetupMachine.NewMachineButton>(17);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 31 "/Users/carlosvillanuevaiii/Projects/TeamA/AppKeep/Pages/Search/SearchPage.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(18, "<div class=\"row\"><div class=\"col-12 text-center\"><br>\n            <br>\n            <br>\n            <div><img src=\"images/spinner.gif\"></div>\n            <br>\n            <div>Loading, please wait...</div></div></div>");
#nullable restore
#line 44 "/Users/carlosvillanuevaiii/Projects/TeamA/AppKeep/Pages/Search/SearchPage.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "/Users/carlosvillanuevaiii/Projects/TeamA/AppKeep/Pages/Search/SearchPage.razor"
 if (!isCompact)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(19, "<div style=\"min-height: 700px;\"></div>");
#nullable restore
#line 48 "/Users/carlosvillanuevaiii/Projects/TeamA/AppKeep/Pages/Search/SearchPage.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "/Users/carlosvillanuevaiii/Projects/TeamA/AppKeep/Pages/Search/SearchPage.razor"
      

    private AppKeep.Web.Pages.Search.SearchListComponent child;
    private bool isHidden { get; set; } = true;
    private IEnumerable<UpkeepTemplate> templates { get; set; } = new List<UpkeepTemplate>();
    private bool isVisible = false;
    private bool isCompact = false;

    [Parameter]
    public bool IsCompact { get; set; }

    private async Task SearchValueChanged(string searchValue)
    {
        isHidden = false;
        templates = await appkeepProfileTemplateService.GetTemplatesFilteredByMachineNameAsync(searchValue);
        child.ResetSearchList();
        isHidden = true;
    }

    protected override void OnParametersSet()
    {
        base.OnParametersSet();

        if (GetUserType() == UserTypeEnum.Assistant)
        {
            Navigation.NavigateTo("myPlans");
        }
        else
        {
            isVisible = true;
            isCompact = IsCompact;
        }
    }

    protected override void OnInitialized()
    {
        System.Diagnostics.Debug.WriteLine($"UserId: {GetUserId()}");
        Console.WriteLine($"UserId: {GetUserId()}");
    }

    private int GetUserId()
    {
        int userId = 0;

        if (httpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
        {
            var claim = httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(c => c.Type == "UserId");

            if (claim != null && Int32.TryParse(claim.Value, out int claimUserId))
            {
                userId = claimUserId;
            }
        }

        return userId;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor httpContextAccessor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUpkeepTemplateService appkeepProfileTemplateService { get; set; }
    }
}
#pragma warning restore 1591