#pragma checksum "D:\VsTest2\ASPNETCoreFundPart3\DotNetNote\Views\MyNotification\MyNotificatonWithModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49d3eac115e2e625a128b9f7c553d38eb88b612f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MyNotification_MyNotificatonWithModal), @"mvc.1.0.view", @"/Views/MyNotification/MyNotificatonWithModal.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49d3eac115e2e625a128b9f7c553d38eb88b612f", @"/Views/MyNotification/MyNotificatonWithModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0daafac8a85ee43e3c34bc74f0c87c74269b2818", @"/Views/_ViewImports.cshtml")]
    public class Views_MyNotification_MyNotificatonWithModal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\VsTest2\ASPNETCoreFundPart3\DotNetNote\Views\MyNotification\MyNotificatonWithModal.cshtml"
  
    ViewData["Title"] = "알림이 있으면 출력(modal)";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>");
#nullable restore
#line 4 "D:\VsTest2\ASPNETCoreFundPart3\DotNetNote\Views\MyNotification\MyNotificatonWithModal.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
            WriteLiteral("<hr />\r\n<div>\r\n    <input type=\"button\" id=\"btnCheck\" value=\"알림이있는지 확인\" />\r\n    <input type=\"hidden\" id=\"hdnUserId\"");
            BeginWriteAttribute("value", " value=\"", 339, "\"", 362, 1);
#nullable restore
#line 11 "D:\VsTest2\ASPNETCoreFundPart3\DotNetNote\Views\MyNotification\MyNotificatonWithModal.cshtml"
WriteAttributeValue("", 347, ViewBag.UserId, 347, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
</div>
<!-- Modal -->
<div class=""modal fade"" tabindex=""-1"" role=""dialog"" id=""myNotification"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">알림이 있습니다.</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <a href=""/MyNotification/MyPage"">알림을 확인하시겠습니까?</a>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-primary"">Save changes</button>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>
");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(function () {
            $(""#btnCheck"").click(function () {
                var userId = parseInt($(""#hdnUserId"").val(), 10);
                // 웹 API 호출
                $.get(""/api/IsNotification?userId="" + userId).done(function (data) {
                    if (data) {
                        $(""#myNotification"").modal(); //모달띄우기
                    } else {
                        alert(""알림이 없습니다."");
                    }
                });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591