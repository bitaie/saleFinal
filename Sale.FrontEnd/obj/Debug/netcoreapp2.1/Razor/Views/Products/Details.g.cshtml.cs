#pragma checksum "C:\Users\Bita\Documents\Projects\Sale\Sale.FrontEnd\Views\Products\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abd354fa94ac2f67d6b00dc3b4b2f2d61e17b022"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Details), @"mvc.1.0.view", @"/Views/Products/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/Details.cshtml", typeof(AspNetCore.Views_Products_Details))]
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
#line 1 "C:\Users\Bita\Documents\Projects\Sale\Sale.FrontEnd\Views\_ViewImports.cshtml"
using UI;

#line default
#line hidden
#line 2 "C:\Users\Bita\Documents\Projects\Sale\Sale.FrontEnd\Views\_ViewImports.cshtml"
using UI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abd354fa94ac2f67d6b00dc3b4b2f2d61e17b022", @"/Views/Products/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52d79ad08d11418ded2b13adb4a9b2619d15bb23", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Sale.Domain.Products.Product>
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
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Bita\Documents\Projects\Sale\Sale.FrontEnd\Views\Products\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(82, 201, true);
            WriteLiteral("\r\n    <h2>جزئیات محصول</h2>\r\n\r\n<div>\r\n   \r\n    <hr />\r\n    <div class=\"class=\"container\"\">\r\n\r\n        <dl>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-md-6\">\r\n                    ");
            EndContext();
            BeginContext(284, 36, false);
#line 18 "C:\Users\Bita\Documents\Projects\Sale\Sale.FrontEnd\Views\Products\Details.cshtml"
               Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(320, 86, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-6\">\r\n                    ");
            EndContext();
            BeginContext(407, 40, false);
#line 21 "C:\Users\Bita\Documents\Projects\Sale\Sale.FrontEnd\Views\Products\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(447, 137, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-md-6\">\r\n                    ");
            EndContext();
            BeginContext(585, 37, false);
#line 26 "C:\Users\Bita\Documents\Projects\Sale\Sale.FrontEnd\Views\Products\Details.cshtml"
               Write(Html.DisplayFor(model => model.Brand));

#line default
#line hidden
            EndContext();
            BeginContext(622, 86, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-6\">\r\n                    ");
            EndContext();
            BeginContext(709, 41, false);
#line 29 "C:\Users\Bita\Documents\Projects\Sale\Sale.FrontEnd\Views\Products\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Brand));

#line default
#line hidden
            EndContext();
            BeginContext(750, 137, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-md-6\">\r\n                    ");
            EndContext();
            BeginContext(888, 37, false);
#line 34 "C:\Users\Bita\Documents\Projects\Sale\Sale.FrontEnd\Views\Products\Details.cshtml"
               Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(925, 97, true);
            WriteLiteral("&nbsp;تومان\r\n                </div>\r\n                <div class=\"col-md-6\">\r\n                    ");
            EndContext();
            BeginContext(1023, 41, false);
#line 37 "C:\Users\Bita\Documents\Projects\Sale\Sale.FrontEnd\Views\Products\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1064, 91, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n     \r\n    </dl>\r\n</div>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1156, 56, false);
#line 45 "C:\Users\Bita\Documents\Projects\Sale\Sale.FrontEnd\Views\Products\Details.cshtml"
Write(Html.ActionLink("تغییر", "Edit", new {  id = Model.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1212, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1220, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "975b207eeefa4303b303c69b8e051134", async() => {
                BeginContext(1242, 22, true);
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
            BeginContext(1268, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Sale.Domain.Products.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
