#pragma checksum "E:\MyProjects\AbcTestApp\AbcTestApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89fa15115fffbdfd68ba1da01d3e0bbed440bd60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "E:\MyProjects\AbcTestApp\AbcTestApp\Views\_ViewImports.cshtml"
using AbcTestApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\MyProjects\AbcTestApp\AbcTestApp\Views\_ViewImports.cshtml"
using AbcTestApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89fa15115fffbdfd68ba1da01d3e0bbed440bd60", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b39a3e24e43f976cdf8465e65c42dbcaeedc79a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\MyProjects\AbcTestApp\AbcTestApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 class=""mt-4"">Dashboard</h1>
<ol class=""breadcrumb mb-4"">
    <li class=""breadcrumb-item active"">Dashboard</li>
</ol>
<div class=""row"">
    <div class=""col-xl-3 col-md-6"">
        <div class=""card bg-primary text-white mb-4"">
            <div class=""card-body"">Primary Card</div>
            <div class=""card-footer d-flex align-items-center justify-content-between"">
                <a class=""small text-white stretched-link"" href=""#"">View Details</a>
                <div class=""small text-white""><i class=""fas fa-angle-right""></i></div>
            </div>
        </div>
    </div>
    <div class=""col-xl-3 col-md-6"">
        <div class=""card bg-warning text-white mb-4"">
            <div class=""card-body"">Warning Card</div>
            <div class=""card-footer d-flex align-items-center justify-content-between"">
                <a class=""small text-white stretched-link"" href=""#"">View Details</a>
                <div class=""small text-white""><i class=""fas fa-angle-right""></i></div>
          ");
            WriteLiteral(@"  </div>
        </div>
    </div>
    <div class=""col-xl-3 col-md-6"">
        <div class=""card bg-success text-white mb-4"">
            <div class=""card-body"">Success Card</div>
            <div class=""card-footer d-flex align-items-center justify-content-between"">
                <a class=""small text-white stretched-link"" href=""#"">View Details</a>
                <div class=""small text-white""><i class=""fas fa-angle-right""></i></div>
            </div>
        </div>
    </div>
    <div class=""col-xl-3 col-md-6"">
        <div class=""card bg-danger text-white mb-4"">
            <div class=""card-body"">Danger Card</div>
            <div class=""card-footer d-flex align-items-center justify-content-between"">
                <a class=""small text-white stretched-link"" href=""#"">View Details</a>
                <div class=""small text-white""><i class=""fas fa-angle-right""></i></div>
            </div>
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-xl-6"">
        <div clas");
            WriteLiteral(@"s=""card mb-4"">
            <div class=""card-header"">
                <i class=""fas fa-chart-area mr-1""></i>
                Area Chart Example
            </div>
            <div class=""card-body""><canvas id=""myAreaChart"" width=""100%"" height=""40""></canvas></div>
        </div>
    </div>
    <div class=""col-xl-6"">
        <div class=""card mb-4"">
            <div class=""card-header"">
                <i class=""fas fa-chart-bar mr-1""></i>
                Bar Chart Example
            </div>
            <div class=""card-body""><canvas id=""myBarChart"" width=""100%"" height=""40""></canvas></div>
        </div>
    </div>
</div>
");
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
