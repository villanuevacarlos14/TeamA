#pragma checksum "/Users/carlosvillanuevaiii/Projects/TeamA/AppKeep/Shared/MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21acaa3eed42aec9acef5fc5438c2b6889f231ee"
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
#line 2 "/Users/carlosvillanuevaiii/Projects/TeamA/AppKeep/Shared/MainLayout.razor"
using AppKeep.Web.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "top-row");
            __builder.AddAttribute(4, "style", "z-index: 999999;");
            __builder.OpenComponent<AppKeep.Web.Shared.NavTop>(5);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\n\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "content px-4");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "row");
            __builder.AddMarkupContent(11, "<div class=\"col-1\"></div>\n            ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "col-10");
            __builder.AddContent(14, 
#nullable restore
#line 13 "/Users/carlosvillanuevaiii/Projects/TeamA/AppKeep/Shared/MainLayout.razor"
                 Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n            <div class=\"col-1\"></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n    ");
            __builder.AddMarkupContent(17, @"<div class=""card-footer text-center"" style=""margin-top: 30px;"">Disclaimer: The developers of this app are not liable to any loss, damages or death of your machines, applicances, home, or pets during or the aftermath of using AppKeep. By using this app you agree to our <a href=""#"">Terms of Service</a>.</div>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
