#pragma checksum "C:\Users\m_shy\source\repos\mentaas\simple-asp-net-core-app-with-clean-architecture\src\AbcTestApp\Views\Locations\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ddf7b8f77b446d9e6f7fbb04739c3e34d2b5b6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Locations_Index), @"mvc.1.0.view", @"/Views/Locations/Index.cshtml")]
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
#line 1 "C:\Users\m_shy\source\repos\mentaas\simple-asp-net-core-app-with-clean-architecture\src\AbcTestApp\Views\_ViewImports.cshtml"
using AbcTestApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\m_shy\source\repos\mentaas\simple-asp-net-core-app-with-clean-architecture\src\AbcTestApp\Views\_ViewImports.cshtml"
using AbcTestApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\m_shy\source\repos\mentaas\simple-asp-net-core-app-with-clean-architecture\src\AbcTestApp\Views\Locations\Index.cshtml"
using AbcTestApp.SharedModel.Locations;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ddf7b8f77b446d9e6f7fbb04739c3e34d2b5b6d", @"/Views/Locations/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b39a3e24e43f976cdf8465e65c42dbcaeedc79a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Locations_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LocationModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "locations", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\m_shy\source\repos\mentaas\simple-asp-net-core-app-with-clean-architecture\src\AbcTestApp\Views\Locations\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 class=""mt-4"">Locations</h1>
<ol class=""breadcrumb mb-4"">
    <li class=""breadcrumb-item active"">Locations</li>
</ol>
<div class=""card mb-4"">
    <div class=""card-header"">
        <i class=""fas fa-table mr-1""></i>
        Locations Table
        <span class=""float-right"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ddf7b8f77b446d9e6f7fbb04739c3e34d2b5b6d5039", async() => {
                WriteLiteral("New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</span>
    </div>
    <div class=""card-body"">
        <div class=""table-responsive"">
            <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                <thead>
                    <tr>
                        <th>Name</th>
                        <th>Address</th>
                        <th>City</th>
                        <th>Longitude</th>
                        <th>Latitude</th>
                        <th>Action</th>
                    </tr>
                </thead>
                <tfoot>
                    <tr>
                        <th>Name</th>
                        <th>Address</th>
                        <th>City</th>
                        <th>Longitude</th>
                        <th>Latitude</th>
                        <th>Action</th>
                    </tr>
                </tfoot>
                <tbody>
");
#nullable restore
#line 42 "C:\Users\m_shy\source\repos\mentaas\simple-asp-net-core-app-with-clean-architecture\src\AbcTestApp\Views\Locations\Index.cshtml"
                     if (Model.Any())
                    {
                        foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1654, "\"", 1717, 1);
#nullable restore
#line 47 "C:\Users\m_shy\source\repos\mentaas\simple-asp-net-core-app-with-clean-architecture\src\AbcTestApp\Views\Locations\Index.cshtml"
WriteAttributeValue("", 1661, Url.Action("Details", "Locations", new { Id = item.Id}), 1661, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 47 "C:\Users\m_shy\source\repos\mentaas\simple-asp-net-core-app-with-clean-architecture\src\AbcTestApp\Views\Locations\Index.cshtml"
                                                                                                  Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                <td>");
#nullable restore
#line 48 "C:\Users\m_shy\source\repos\mentaas\simple-asp-net-core-app-with-clean-architecture\src\AbcTestApp\Views\Locations\Index.cshtml"
                               Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 49 "C:\Users\m_shy\source\repos\mentaas\simple-asp-net-core-app-with-clean-architecture\src\AbcTestApp\Views\Locations\Index.cshtml"
                               Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 50 "C:\Users\m_shy\source\repos\mentaas\simple-asp-net-core-app-with-clean-architecture\src\AbcTestApp\Views\Locations\Index.cshtml"
                               Write(item.Longitude);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 51 "C:\Users\m_shy\source\repos\mentaas\simple-asp-net-core-app-with-clean-architecture\src\AbcTestApp\Views\Locations\Index.cshtml"
                               Write(item.Latitude);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td><a href=\"javascript:void(0)\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2028, "\"", 2064, 3);
            WriteAttributeValue("", 2038, "deleteFunction(\'", 2038, 16, true);
#nullable restore
#line 52 "C:\Users\m_shy\source\repos\mentaas\simple-asp-net-core-app-with-clean-architecture\src\AbcTestApp\Views\Locations\Index.cshtml"
WriteAttributeValue("", 2054, item.Id, 2054, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2062, "\')", 2062, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-link\">Delete</a></td>\r\n                            </tr>\r\n");
#nullable restore
#line 54 "C:\Users\m_shy\source\repos\mentaas\simple-asp-net-core-app-with-clean-architecture\src\AbcTestApp\Views\Locations\Index.cshtml"
                        }

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@" 
    <script>
        function deleteFunction(id) {
            debugger;
            var r = confirm(""Are you sure?"");
            if (r == true) {
                window.location.href = ""/locations/delete/"" + id;
            }
        }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LocationModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
