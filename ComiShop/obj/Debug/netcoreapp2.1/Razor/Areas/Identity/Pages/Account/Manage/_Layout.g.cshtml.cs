#pragma checksum "C:\Users\User\source\repos\BookLib\ComiShop\Areas\Identity\Pages\Account\Manage\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca5a5079833b7dd4ee49478f573175eefcd17cc5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ComiShop.Areas.Identity.Pages.Account.Manage.Areas_Identity_Pages_Account_Manage__Layout), @"mvc.1.0.view", @"/Areas/Identity/Pages/Account/Manage/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Identity/Pages/Account/Manage/_Layout.cshtml", typeof(ComiShop.Areas.Identity.Pages.Account.Manage.Areas_Identity_Pages_Account_Manage__Layout))]
namespace ComiShop.Areas.Identity.Pages.Account.Manage
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\User\source\repos\BookLib\ComiShop\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\User\source\repos\BookLib\ComiShop\Areas\Identity\Pages\_ViewImports.cshtml"
using ComiShop.Areas.Identity;

#line default
#line hidden
#line 3 "C:\Users\User\source\repos\BookLib\ComiShop\Areas\Identity\Pages\_ViewImports.cshtml"
using ComiShop.Models;

#line default
#line hidden
#line 1 "C:\Users\User\source\repos\BookLib\ComiShop\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using ComiShop.Areas.Identity.Pages.Account;

#line default
#line hidden
#line 1 "C:\Users\User\source\repos\BookLib\ComiShop\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using ComiShop.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca5a5079833b7dd4ee49478f573175eefcd17cc5", @"/Areas/Identity/Pages/Account/Manage/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90b591b780a176888c1262fe1794b962c01883ba", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66704a9ff1d14faa039c30dba331a5a869f77d84", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c54d2f1fef62bb5ee49ce65e7548a518df1f2734", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Manage__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ManageNav", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\User\source\repos\BookLib\ComiShop\Areas\Identity\Pages\Account\Manage\_Layout.cshtml"
   
    Layout = "/Areas/Identity/Pages/_Layout.cshtml";

#line default
#line hidden
            BeginContext(62, 163, true);
            WriteLiteral("\r\n<h2>Manage your account</h2>\r\n\r\n<div>\r\n    <h4>Change your account settings</h4>\r\n    <hr />\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">\r\n            ");
            EndContext();
            BeginContext(225, 29, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b5636e26bb134f8fb0df0b6ba1b3277b", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(254, 62, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-9\">\r\n            ");
            EndContext();
            BeginContext(317, 12, false);
#line 15 "C:\Users\User\source\repos\BookLib\ComiShop\Areas\Identity\Pages\Account\Manage\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
            EndContext();
            BeginContext(329, 40, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(387, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(394, 41, false);
#line 21 "C:\Users\User\source\repos\BookLib\ComiShop\Areas\Identity\Pages\Account\Manage\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(435, 2, true);
                WriteLiteral("\r\n");
                EndContext();
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
