#pragma checksum "/Users/carlosvillanuevaiii/Projects/TeamA/AppKeep/Pages/UpkeepTemplate/WorkItemStatus.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44b449e380309e9cc28bc9f133899300b58d4b90"
// <auto-generated/>
#pragma warning disable 1591
namespace AppKeep.Web.Pages.UpkeepTemplate
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
    public partial class WorkItemStatus : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "/Users/carlosvillanuevaiii/Projects/TeamA/AppKeep/Pages/UpkeepTemplate/WorkItemStatus.razor"
 if (workStatus == WorkStatusEnum.Pending)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<button class=\"btn btn-info\">Pending</button>");
#nullable restore
#line 4 "/Users/carlosvillanuevaiii/Projects/TeamA/AppKeep/Pages/UpkeepTemplate/WorkItemStatus.razor"
}
else if (workStatus == WorkStatusEnum.InProgress)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<button class=\"btn btn-warning\">In Progress</button>");
#nullable restore
#line 8 "/Users/carlosvillanuevaiii/Projects/TeamA/AppKeep/Pages/UpkeepTemplate/WorkItemStatus.razor"
}
else if (workStatus == WorkStatusEnum.Done)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<button class=\"btn btn-success\">Completed</button>");
#nullable restore
#line 12 "/Users/carlosvillanuevaiii/Projects/TeamA/AppKeep/Pages/UpkeepTemplate/WorkItemStatus.razor"
}
else if (workStatus == WorkStatusEnum.NeedsAction)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "<button class=\"btn btn-danger\">Needs Action</button>");
#nullable restore
#line 16 "/Users/carlosvillanuevaiii/Projects/TeamA/AppKeep/Pages/UpkeepTemplate/WorkItemStatus.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "/Users/carlosvillanuevaiii/Projects/TeamA/AppKeep/Pages/UpkeepTemplate/WorkItemStatus.razor"
       
    [Parameter]
    public WorkStatusEnum WorkStatus { get; set; }

    private WorkStatusEnum workStatus;

    protected override void OnParametersSet()
    {
        base.OnParametersSet();

        workStatus = WorkStatus;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
