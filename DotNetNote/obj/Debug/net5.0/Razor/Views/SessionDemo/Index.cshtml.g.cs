#pragma checksum "D:\VsTest2\ASPNETCoreFundPart3\DotNetNote\Views\SessionDemo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8140867aa91ca1569ac8214065445129a0c9cf61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SessionDemo_Index), @"mvc.1.0.view", @"/Views/SessionDemo/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8140867aa91ca1569ac8214065445129a0c9cf61", @"/Views/SessionDemo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0daafac8a85ee43e3c34bc74f0c87c74269b2818", @"/Views/_ViewImports.cshtml")]
    public class Views_SessionDemo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\VsTest2\ASPNETCoreFundPart3\DotNetNote\Views\SessionDemo\Index.cshtml"
  
    ViewData["Title"] = "세션 저장(페이지 로드)";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 5 "D:\VsTest2\ASPNETCoreFundPart3\DotNetNote\Views\SessionDemo\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</h2>\r\n\r\n<div>\r\n    <a href=\"/SessionDemo/GetSession\">세션 확인</a>\r\n</div>");
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