#pragma checksum "C:\Users\Md Jahan\source\repos\Student Portal\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "773b89af43b65c680b3e6d3d97e6a4d65c23c42c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
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
#line 1 "C:\Users\Md Jahan\source\repos\Student Portal\Views\_ViewImports.cshtml"
using Student_Portal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Md Jahan\source\repos\Student Portal\Views\_ViewImports.cshtml"
using Student_Portal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"773b89af43b65c680b3e6d3d97e6a4d65c23c42c", @"/Views/Home/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48d6ffe86fadcb415cc05245c2fd39c294220092", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Md Jahan\source\repos\Student Portal\Views\Home\Login.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""d-flex justify-content-center align-items-center mt-5"">
    <div class=""card"">
        <ul class=""nav nav-pills mb-3"" id=""pills-tab"" role=""tablist"">
            <li class=""nav-item text-center""> <a class=""nav-link active btl"" id=""pills-home-tab"" data-toggle=""pill"" href=""#pills-home"" role=""tab"" aria-controls=""pills-home"" aria-selected=""true"">Login</a> </li>
            <li class=""nav-item text-center""> <a class=""nav-link btr"" id=""pills-profile-tab"" data-toggle=""pill"" href=""#pills-profile"" role=""tab"" aria-controls=""pills-profile"" aria-selected=""false"">Signup</a> </li>
        </ul>
        <div class=""tab-content"" id=""pills-tabContent"">
            <div class=""tab-pane fade show active"" id=""pills-home"" role=""tabpanel"" aria-labelledby=""pills-home-tab"">
                <div class=""form px-4 pt-5""> <input type=""text""");
            BeginWriteAttribute("name", " name=\"", 890, "\"", 897, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" placeholder=\"Email or Phone\"> <input type=\"text\"");
            BeginWriteAttribute("name", " name=\"", 968, "\"", 975, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" placeholder=""Password""> <button class=""btn btn-dark btn-block"">Login</button> </div>
            </div>
            <div class=""tab-pane fade"" id=""pills-profile"" role=""tabpanel"" aria-labelledby=""pills-profile-tab"">
                <div class=""form px-4""> <input type=""text""");
            BeginWriteAttribute("name", " name=\"", 1274, "\"", 1281, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" placeholder=\"Name\"> <input type=\"text\"");
            BeginWriteAttribute("name", " name=\"", 1342, "\"", 1349, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" placeholder=\"Email\"> <input type=\"text\"");
            BeginWriteAttribute("name", " name=\"", 1411, "\"", 1418, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" placeholder=\"Phone\"> <input type=\"text\"");
            BeginWriteAttribute("name", " name=\"", 1480, "\"", 1487, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" placeholder=\"Password\"> <button class=\"btn btn-dark btn-block\">Signup</button> </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
