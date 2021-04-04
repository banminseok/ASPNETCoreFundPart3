#pragma checksum "F:\VSTEst2\ASPNETCoreFundPart3\DotNetNote.BlazorServer\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb0857b559202d8d42c338c65dc47b4fc342a376"
// <auto-generated/>
#pragma warning disable 1591
namespace DotNetNote.BlazorServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\VSTEst2\ASPNETCoreFundPart3\DotNetNote.BlazorServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\VSTEst2\ASPNETCoreFundPart3\DotNetNote.BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\VSTEst2\ASPNETCoreFundPart3\DotNetNote.BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\VSTEst2\ASPNETCoreFundPart3\DotNetNote.BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\VSTEst2\ASPNETCoreFundPart3\DotNetNote.BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\VSTEst2\ASPNETCoreFundPart3\DotNetNote.BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\VSTEst2\ASPNETCoreFundPart3\DotNetNote.BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\VSTEst2\ASPNETCoreFundPart3\DotNetNote.BlazorServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\VSTEst2\ASPNETCoreFundPart3\DotNetNote.BlazorServer\_Imports.razor"
using DotNetNote.BlazorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\VSTEst2\ASPNETCoreFundPart3\DotNetNote.BlazorServer\_Imports.razor"
using DotNetNote.BlazorServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\VSTEst2\ASPNETCoreFundPart3\DotNetNote.BlazorServer\Pages\FetchData.razor"
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
            __builder.AddMarkupContent(0, "<h1>Weather forecast</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from a service.</p>");
#nullable restore
#line 10 "F:\VSTEst2\ASPNETCoreFundPart3\DotNetNote.BlazorServer\Pages\FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 13 "F:\VSTEst2\ASPNETCoreFundPart3\DotNetNote.BlazorServer\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "<thead><tr><th>Date</th>\r\n                <th>Temp. (C)</th>\r\n                <th>Temp. (F)</th>\r\n                <th>Summary</th></tr></thead>\r\n        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 26 "F:\VSTEst2\ASPNETCoreFundPart3\DotNetNote.BlazorServer\Pages\FetchData.razor"
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 29 "F:\VSTEst2\ASPNETCoreFundPart3\DotNetNote.BlazorServer\Pages\FetchData.razor"
                         forecast.Date.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 30 "F:\VSTEst2\ASPNETCoreFundPart3\DotNetNote.BlazorServer\Pages\FetchData.razor"
                         forecast.TemperatureC

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 31 "F:\VSTEst2\ASPNETCoreFundPart3\DotNetNote.BlazorServer\Pages\FetchData.razor"
                         forecast.TemperatureF

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 32 "F:\VSTEst2\ASPNETCoreFundPart3\DotNetNote.BlazorServer\Pages\FetchData.razor"
                         forecast.Summary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 34 "F:\VSTEst2\ASPNETCoreFundPart3\DotNetNote.BlazorServer\Pages\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 37 "F:\VSTEst2\ASPNETCoreFundPart3\DotNetNote.BlazorServer\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "F:\VSTEst2\ASPNETCoreFundPart3\DotNetNote.BlazorServer\Pages\FetchData.razor"
       
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
