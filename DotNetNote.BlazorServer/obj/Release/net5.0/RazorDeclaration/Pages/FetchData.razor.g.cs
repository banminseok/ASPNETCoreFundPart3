// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DotNetNote.BlazorServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\VsTest2\ASPNETCoreFundPart3\DotNetNote.BlazorServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\VsTest2\ASPNETCoreFundPart3\DotNetNote.BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\VsTest2\ASPNETCoreFundPart3\DotNetNote.BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\VsTest2\ASPNETCoreFundPart3\DotNetNote.BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\VsTest2\ASPNETCoreFundPart3\DotNetNote.BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\VsTest2\ASPNETCoreFundPart3\DotNetNote.BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\VsTest2\ASPNETCoreFundPart3\DotNetNote.BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\VsTest2\ASPNETCoreFundPart3\DotNetNote.BlazorServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\VsTest2\ASPNETCoreFundPart3\DotNetNote.BlazorServer\_Imports.razor"
using DotNetNote.BlazorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\VsTest2\ASPNETCoreFundPart3\DotNetNote.BlazorServer\_Imports.razor"
using DotNetNote.BlazorServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\VsTest2\ASPNETCoreFundPart3\DotNetNote.BlazorServer\Pages\FetchData.razor"
using DotNetNote.BlazorServer.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "D:\VsTest2\ASPNETCoreFundPart3\DotNetNote.BlazorServer\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
