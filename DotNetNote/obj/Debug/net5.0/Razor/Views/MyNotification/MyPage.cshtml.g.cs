#pragma checksum "D:\VsTest2\ASPNETCoreFundPart3\DotNetNote\Views\MyNotification\MyPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fd279215c3acbf746031b634255877707533564"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MyNotification_MyPage), @"mvc.1.0.view", @"/Views/MyNotification/MyPage.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\VsTest2\ASPNETCoreFundPart3\DotNetNote\Views\_ViewImports.cshtml"
using DotNetNote;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\VsTest2\ASPNETCoreFundPart3\DotNetNote\Views\_ViewImports.cshtml"
using DotNetNote.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fd279215c3acbf746031b634255877707533564", @"/Views/MyNotification/MyPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0daafac8a85ee43e3c34bc74f0c87c74269b2818", @"/Views/_ViewImports.cshtml")]
    public class Views_MyNotification_MyPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DotNetNote.Models.MyNotification>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\VsTest2\ASPNETCoreFundPart3\DotNetNote\Views\MyNotification\MyPage.cshtml"
  
    ViewData["Title"] = "My Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>");
#nullable restore
#line 6 "D:\VsTest2\ASPNETCoreFundPart3\DotNetNote\Views\MyNotification\MyPage.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
            WriteLiteral("<hr />\r\n<div>\r\n    <input type=\"hidden\" id=\"hdnUserId\"");
            BeginWriteAttribute("value", " value=\"", 311, "\"", 334, 1);
#nullable restore
#line 12 "D:\VsTest2\ASPNETCoreFundPart3\DotNetNote\Views\MyNotification\MyPage.cshtml"
WriteAttributeValue("", 319, ViewBag.UserId, 319, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n</div>\r\n\r\n<div>\r\n    <ul>\r\n        <li>");
#nullable restore
#line 17 "D:\VsTest2\ASPNETCoreFundPart3\DotNetNote\Views\MyNotification\MyPage.cshtml"
       Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 17 "D:\VsTest2\ASPNETCoreFundPart3\DotNetNote\Views\MyNotification\MyPage.cshtml"
                   Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 17 "D:\VsTest2\ASPNETCoreFundPart3\DotNetNote\Views\MyNotification\MyPage.cshtml"
                                    Write(Model.Timestamp.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n    </ul>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(function () {

            var userId = parseInt($(""#hdnUserId"").val(), 10);
            // ??? API ?????? - ??????????????????
            $.get(""/api/Completefication?userId="" + userId)
                .done(function (data) {
                    if (data) {
                        alert(""???????????? ????????????."");
                    } 
                });
        });
    </script>

");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DotNetNote.Models.MyNotification> Html { get; private set; }
    }
}
#pragma warning restore 1591
