#pragma checksum "C:\Users\User\source\repos\BookLib\ComiShop\Areas\Admin\Views\Admin\DataWarehouse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f3323c8dc5b8adae10179b5673fe919c6921c8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Admin_DataWarehouse), @"mvc.1.0.view", @"/Areas/Admin/Views/Admin/DataWarehouse.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Admin/DataWarehouse.cshtml", typeof(AspNetCore.Areas_Admin_Views_Admin_DataWarehouse))]
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
#line 1 "C:\Users\User\source\repos\BookLib\ComiShop\Areas\Admin\Views\_ViewImports.cshtml"
using ComiShop;

#line default
#line hidden
#line 2 "C:\Users\User\source\repos\BookLib\ComiShop\Areas\Admin\Views\_ViewImports.cshtml"
using ComiShop.Models;

#line default
#line hidden
#line 3 "C:\Users\User\source\repos\BookLib\ComiShop\Areas\Admin\Views\_ViewImports.cshtml"
using ComiShop.Controllers;

#line default
#line hidden
#line 4 "C:\Users\User\source\repos\BookLib\ComiShop\Areas\Admin\Views\_ViewImports.cshtml"
using ComiShop.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f3323c8dc5b8adae10179b5673fe919c6921c8c", @"/Areas/Admin/Views/Admin/DataWarehouse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9292eff7977125bb3107af751ebab9a2b12a4d75", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Admin_DataWarehouse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ComiShop.ViewModels.WarehouseView>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\User\source\repos\BookLib\ComiShop\Areas\Admin\Views\Admin\DataWarehouse.cshtml"
  
    ViewData["Title"] = "DataWarehouse";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(158, 663, true);
            WriteLiteral(@"
<div id=""page-wrapper"">
    <div class=""main-page"">
        <div class=""row"">
            <h4>Warehouse</h4>
            <hr />
            <div class=""col-md-10"">
                <table class=""table table-responsive table-bordered table-condensed"">
                    <thead>
                        <tr>
                            <th>Category</th>
                            <th>Product Name</th>
                            <th>Product Description</th>
                            <th>Product Price</th>
                            <th>Quantity</th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 25 "C:\Users\User\source\repos\BookLib\ComiShop\Areas\Admin\Views\Admin\DataWarehouse.cshtml"
                         foreach (var item in Model)
                        {
                            

#line default
#line hidden
#line 27 "C:\Users\User\source\repos\BookLib\ComiShop\Areas\Admin\Views\Admin\DataWarehouse.cshtml"
                             foreach (var product in item.ProductList)
                            {
                                

#line default
#line hidden
#line 29 "C:\Users\User\source\repos\BookLib\ComiShop\Areas\Admin\Views\Admin\DataWarehouse.cshtml"
                                 if (product.Equals(item.ProductList[0]))
                                {

#line default
#line hidden
            BeginContext(1115, 85, true);
            WriteLiteral("                                    <tr>\r\n                                        <td");
            EndContext();
            BeginWriteAttribute("rowspan", " rowspan=\"", 1200, "\"", 1235, 1);
#line 32 "C:\Users\User\source\repos\BookLib\ComiShop\Areas\Admin\Views\Admin\DataWarehouse.cshtml"
WriteAttributeValue("", 1210, item.ProductList.Count(), 1210, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1236, 32, true);
            WriteLiteral(" style=\"vertical-align: middle\">");
            EndContext();
            BeginContext(1269, 17, false);
#line 32 "C:\Users\User\source\repos\BookLib\ComiShop\Areas\Admin\Views\Admin\DataWarehouse.cshtml"
                                                                                                          Write(item.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(1286, 97, true);
            WriteLiteral("</td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(1383, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44e0b39adfea463ba1f87f4203406b8f", async() => {
                BeginContext(1443, 19, false);
#line 34 "C:\Users\User\source\repos\BookLib\ComiShop\Areas\Admin\Views\Admin\DataWarehouse.cshtml"
                                                                                                  Write(product.ProductName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 34 "C:\Users\User\source\repos\BookLib\ComiShop\Areas\Admin\Views\Admin\DataWarehouse.cshtml"
                                                                             WriteLiteral(product.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1466, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(1606, 18, false);
#line 37 "C:\Users\User\source\repos\BookLib\ComiShop\Areas\Admin\Views\Admin\DataWarehouse.cshtml"
                                       Write(product.ProductDes);

#line default
#line hidden
            EndContext();
            BeginContext(1624, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(1764, 17, false);
#line 40 "C:\Users\User\source\repos\BookLib\ComiShop\Areas\Admin\Views\Admin\DataWarehouse.cshtml"
                                       Write(product.UnitPrice);

#line default
#line hidden
            EndContext();
            BeginContext(1781, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(1921, 16, false);
#line 43 "C:\Users\User\source\repos\BookLib\ComiShop\Areas\Admin\Views\Admin\DataWarehouse.cshtml"
                                       Write(product.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(1937, 92, true);
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 46 "C:\Users\User\source\repos\BookLib\ComiShop\Areas\Admin\Views\Admin\DataWarehouse.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(2137, 132, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(2269, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aabae1cc90004c31a6496e0bdc0a9724", async() => {
                BeginContext(2329, 19, false);
#line 51 "C:\Users\User\source\repos\BookLib\ComiShop\Areas\Admin\Views\Admin\DataWarehouse.cshtml"
                                                                                                  Write(product.ProductName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 51 "C:\Users\User\source\repos\BookLib\ComiShop\Areas\Admin\Views\Admin\DataWarehouse.cshtml"
                                                                             WriteLiteral(product.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2352, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(2492, 18, false);
#line 54 "C:\Users\User\source\repos\BookLib\ComiShop\Areas\Admin\Views\Admin\DataWarehouse.cshtml"
                                       Write(product.ProductDes);

#line default
#line hidden
            EndContext();
            BeginContext(2510, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(2650, 17, false);
#line 57 "C:\Users\User\source\repos\BookLib\ComiShop\Areas\Admin\Views\Admin\DataWarehouse.cshtml"
                                       Write(product.UnitPrice);

#line default
#line hidden
            EndContext();
            BeginContext(2667, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(2807, 16, false);
#line 60 "C:\Users\User\source\repos\BookLib\ComiShop\Areas\Admin\Views\Admin\DataWarehouse.cshtml"
                                       Write(product.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(2823, 92, true);
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 63 "C:\Users\User\source\repos\BookLib\ComiShop\Areas\Admin\Views\Admin\DataWarehouse.cshtml"
                                }

#line default
#line hidden
#line 63 "C:\Users\User\source\repos\BookLib\ComiShop\Areas\Admin\Views\Admin\DataWarehouse.cshtml"
                                 
                            }

#line default
#line hidden
#line 64 "C:\Users\User\source\repos\BookLib\ComiShop\Areas\Admin\Views\Admin\DataWarehouse.cshtml"
                             
                        }

#line default
#line hidden
            BeginContext(3008, 178, true);
            WriteLiteral("                        </tbody>                    \r\n                </table>\r\n                <div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div>\r\n");
            EndContext();
            BeginContext(3260, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(3272, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fec9f602e564ee2a7ded16e2f41d6cf", async() => {
                BeginContext(3294, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3310, 44, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n    \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ComiShop.ViewModels.WarehouseView>> Html { get; private set; }
    }
}
#pragma warning restore 1591
