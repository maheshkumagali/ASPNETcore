#pragma checksum "C:\Users\Mahesh\source\repos\ASPNETcore\Views\Employee\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78cba05b177b9143167137cff805e9ed1425e93e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Details), @"mvc.1.0.view", @"/Views/Employee/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/Details.cshtml", typeof(AspNetCore.Views_Employee_Details))]
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
#line 1 "C:\Users\Mahesh\source\repos\ASPNETcore\Views\_ViewImports.cshtml"
using TagHelpersDemo;

#line default
#line hidden
#line 2 "C:\Users\Mahesh\source\repos\ASPNETcore\Views\_ViewImports.cshtml"
using TagHelpersDemo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78cba05b177b9143167137cff805e9ed1425e93e", @"/Views/Employee/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6dfdbfc72f340aee8e653be9b3716fc64042b529", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Employee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Mahesh\source\repos\ASPNETcore\Views\Employee\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(60, 26, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\nId: ");
            EndContext();
            BeginContext(87, 8, false);
#line 8 "C:\Users\Mahesh\source\repos\ASPNETcore\Views\Employee\Details.cshtml"
Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(95, 15, true);
            WriteLiteral("\r\n<br/>\r\nName: ");
            EndContext();
            BeginContext(111, 10, false);
#line 10 "C:\Users\Mahesh\source\repos\ASPNETcore\Views\Employee\Details.cshtml"
 Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(121, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591
