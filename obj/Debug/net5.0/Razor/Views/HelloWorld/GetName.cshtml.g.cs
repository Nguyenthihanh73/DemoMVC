#pragma checksum "C:\DoNet\demoMVC\Views\HelloWorld\GetName.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15f385a6010dc5f5082dbd04974dfbf13776caca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HelloWorld_GetName), @"mvc.1.0.view", @"/Views/HelloWorld/GetName.cshtml")]
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
#line 1 "C:\DoNet\demoMVC\Views\_ViewImports.cshtml"
using demoMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\DoNet\demoMVC\Views\_ViewImports.cshtml"
using demoMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15f385a6010dc5f5082dbd04974dfbf13776caca", @"/Views/HelloWorld/GetName.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11bb858ae580a9ca14e6d5634213429fc1aebe75", @"/Views/_ViewImports.cshtml")]
    public class Views_HelloWorld_GetName : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\DoNet\demoMVC\Views\HelloWorld\GetName.cshtml"
  
    ViewData["Title"] = "Welcome";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Welcome</h2>\r\n\r\n<ul>\r\n");
#nullable restore
#line 8 "C:\DoNet\demoMVC\Views\HelloWorld\GetName.cshtml"
     for (int i = 0; i < (int)ViewData["NumTimes"]; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 10 "C:\DoNet\demoMVC\Views\HelloWorld\GetName.cshtml"
       Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 11 "C:\DoNet\demoMVC\Views\HelloWorld\GetName.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
