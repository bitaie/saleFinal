#pragma checksum "C:\Users\b.khodakarami\Documents\Projects\saleFinal\Sale.FrontEnd\Views\Customers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8cde0ea7452dae45c2137ff27cef89cc937b5e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_Details), @"mvc.1.0.view", @"/Views/Customers/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customers/Details.cshtml", typeof(AspNetCore.Views_Customers_Details))]
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
#line 1 "C:\Users\b.khodakarami\Documents\Projects\saleFinal\Sale.FrontEnd\Views\_ViewImports.cshtml"
using UI;

#line default
#line hidden
#line 2 "C:\Users\b.khodakarami\Documents\Projects\saleFinal\Sale.FrontEnd\Views\_ViewImports.cshtml"
using UI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8cde0ea7452dae45c2137ff27cef89cc937b5e3", @"/Views/Customers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52d79ad08d11418ded2b13adb4a9b2619d15bb23", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Sale.Domain.Customers.Customer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\b.khodakarami\Documents\Projects\saleFinal\Sale.FrontEnd\Views\Customers\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(84, 164, true);
            WriteLiteral("\r\n    <h2>جزئیات محصول</h2>\r\n\r\n<div>\r\n \r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-6\">\r\n                ");
            EndContext();
            BeginContext(249, 41, false);
#line 15 "C:\Users\b.khodakarami\Documents\Projects\saleFinal\Sale.FrontEnd\Views\Customers\Details.cshtml"
           Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(290, 74, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-6\">\r\n                ");
            EndContext();
            BeginContext(365, 45, false);
#line 18 "C:\Users\b.khodakarami\Documents\Projects\saleFinal\Sale.FrontEnd\Views\Customers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(410, 117, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-6\">\r\n                ");
            EndContext();
            BeginContext(528, 40, false);
#line 23 "C:\Users\b.khodakarami\Documents\Projects\saleFinal\Sale.FrontEnd\Views\Customers\Details.cshtml"
           Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(568, 74, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-6\">\r\n                ");
            EndContext();
            BeginContext(643, 44, false);
#line 26 "C:\Users\b.khodakarami\Documents\Projects\saleFinal\Sale.FrontEnd\Views\Customers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(687, 117, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-6\">\r\n                ");
            EndContext();
            BeginContext(805, 43, false);
#line 31 "C:\Users\b.khodakarami\Documents\Projects\saleFinal\Sale.FrontEnd\Views\Customers\Details.cshtml"
           Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(848, 74, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-6\">\r\n                ");
            EndContext();
            BeginContext(923, 47, false);
#line 34 "C:\Users\b.khodakarami\Documents\Projects\saleFinal\Sale.FrontEnd\Views\Customers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(970, 38, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
            EndContext();
            BeginContext(1534, 30, true);
            WriteLiteral("    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1565, 56, false);
#line 58 "C:\Users\b.khodakarami\Documents\Projects\saleFinal\Sale.FrontEnd\Views\Customers\Details.cshtml"
Write(Html.ActionLink("تغییر", "Edit", new {  id = Model.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1621, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1629, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bda7d6f7821f4a469d0874badb76752b", async() => {
                BeginContext(1651, 22, true);
                WriteLiteral("بازگشت به لیست محصولات");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1677, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Sale.Domain.Customers.Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591
