#pragma checksum "C:\Users\b.khodakarami\Documents\Projects\saleFinal\Sale.FrontEnd\Views\Customers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3352af05ecb4695ae947623d974bf4a98e115756"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_Index), @"mvc.1.0.view", @"/Views/Customers/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customers/Index.cshtml", typeof(AspNetCore.Views_Customers_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3352af05ecb4695ae947623d974bf4a98e115756", @"/Views/Customers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52d79ad08d11418ded2b13adb4a9b2619d15bb23", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Sale.Domain.Customers.Customer>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\b.khodakarami\Documents\Projects\saleFinal\Sale.FrontEnd\Views\Customers\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(95, 56, true);
            WriteLiteral("\r\n<h2>لیست مشتریان موجود</h2>\r\n<div class=\"container\">\r\n");
            EndContext();
#line 9 "C:\Users\b.khodakarami\Documents\Projects\saleFinal\Sale.FrontEnd\Views\Customers\Index.cshtml"
     if ((string)TempData["State"] == "Successfully created")
    {

#line default
#line hidden
            BeginContext(221, 231, true);
            WriteLiteral("        <div class=\"alert alert-success alert-dismissible \">\r\n            <a href=\"#\" class=\"close\" data-dismiss=\"alert\" aria-label=\"close\">&times;</a>\r\n            <strong>اطلاعات مشتری با موفقیت ثبت شد!</strong>\r\n        </div>\r\n");
            EndContext();
#line 15 "C:\Users\b.khodakarami\Documents\Projects\saleFinal\Sale.FrontEnd\Views\Customers\Index.cshtml"
    }
    else if ((string)TempData["State"] == "Successfully Edited")
    {

#line default
#line hidden
            BeginContext(532, 233, true);
            WriteLiteral("        <div class=\"alert alert-success alert-dismissible\">\r\n            <a href=\"#\" class=\"close\" data-dismiss=\"alert\" aria-label=\"close\">&times;</a>\r\n            <strong>اطلاعات مشتری با موفقیت ویرایش شد!</strong>\r\n        </div>\r\n");
            EndContext();
#line 22 "C:\Users\b.khodakarami\Documents\Projects\saleFinal\Sale.FrontEnd\Views\Customers\Index.cshtml"
    }
    else if ((string)TempData["State"] == "Successfully Deleted")
    {

#line default
#line hidden
            BeginContext(846, 225, true);
            WriteLiteral("        <div class=\"alert alert-success alert-dismissible\">\r\n            <a href=\"#\" class=\"close\" data-dismiss=\"alert\" aria-label=\"close\">&times;</a>\r\n            <strong>محصول با موفقیت حذف گردید!</strong>\r\n        </div>\r\n");
            EndContext();
#line 29 "C:\Users\b.khodakarami\Documents\Projects\saleFinal\Sale.FrontEnd\Views\Customers\Index.cshtml"
    }
    else if ((string)TempData["State"] == "Fail")
    {

#line default
#line hidden
            BeginContext(1136, 221, true);
            WriteLiteral("        <div class=\"alert alert-danger alert-dismissible\">\r\n            <a href=\"#\" class=\"close\" data-dismiss=\"alert\" aria-label=\"close\">&times;</a>\r\n            <strong>عملیات با شکست موجه شد!</strong>\r\n        </div>\r\n");
            EndContext();
#line 36 "C:\Users\b.khodakarami\Documents\Projects\saleFinal\Sale.FrontEnd\Views\Customers\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1364, 19, true);
            WriteLiteral("\r\n    <p>\r\n        ");
            EndContext();
            BeginContext(1383, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b8a644a66de4aebaa5fa4065ba14326", async() => {
                BeginContext(1406, 16, true);
                WriteLiteral("ایجاد مشتری جدید");
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
            BeginContext(1426, 247, true);
            WriteLiteral("\r\n    </p>\r\n    <table class=\"table table-striped table-bordered\" id=\"dtBasicExample\" cellspacing=\"0\" width=\"100%\">\r\n        <thead>\r\n            <tr>\r\n\r\n\r\n\r\n\r\n\r\n                <th></th>\r\n\r\n                <th class=\"th-sm\">\r\n                    ");
            EndContext();
            BeginContext(1674, 45, false);
#line 52 "C:\Users\b.khodakarami\Documents\Projects\saleFinal\Sale.FrontEnd\Views\Customers\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1719, 81, true);
            WriteLiteral("\r\n                </th>\r\n                <th class=\"th-sm\">\r\n                    ");
            EndContext();
            BeginContext(1801, 44, false);
#line 55 "C:\Users\b.khodakarami\Documents\Projects\saleFinal\Sale.FrontEnd\Views\Customers\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1845, 81, true);
            WriteLiteral("\r\n                </th>\r\n                <th class=\"th-sm\">\r\n                    ");
            EndContext();
            BeginContext(1927, 47, false);
#line 58 "C:\Users\b.khodakarami\Documents\Projects\saleFinal\Sale.FrontEnd\Views\Customers\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1974, 25, true);
            WriteLiteral("\r\n                </th>\r\n");
            EndContext();
#line 69 "C:\Users\b.khodakarami\Documents\Projects\saleFinal\Sale.FrontEnd\Views\Customers\Index.cshtml"
                 if (User.IsInRole("CustomerManager"))
                {

#line default
#line hidden
            BeginContext(2361, 31, true);
            WriteLiteral("                    <th></th>\r\n");
            EndContext();
#line 72 "C:\Users\b.khodakarami\Documents\Projects\saleFinal\Sale.FrontEnd\Views\Customers\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2411, 58, true);
            WriteLiteral("                </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 76 "C:\Users\b.khodakarami\Documents\Projects\saleFinal\Sale.FrontEnd\Views\Customers\Index.cshtml"
             foreach (var item in Model)
            {



#line default
#line hidden
            BeginContext(2530, 18, true);
            WriteLiteral("            <tr>\r\n");
            EndContext();
#line 81 "C:\Users\b.khodakarami\Documents\Projects\saleFinal\Sale.FrontEnd\Views\Customers\Index.cshtml"
                 if (User.IsInRole("InvoiceManager"))
                {

#line default
#line hidden
            BeginContext(2622, 50, true);
            WriteLiteral("                    <td>\r\n                        ");
            EndContext();
            BeginContext(2673, 83, false);
#line 84 "C:\Users\b.khodakarami\Documents\Projects\saleFinal\Sale.FrontEnd\Views\Customers\Index.cshtml"
                   Write(Html.ActionLink("ایجاد صورت حساب جدید", "Create", "Invoices", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(2756, 31, true);
            WriteLiteral("\r\n\r\n                    </td>\r\n");
            EndContext();
#line 87 "C:\Users\b.khodakarami\Documents\Projects\saleFinal\Sale.FrontEnd\Views\Customers\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2806, 42, true);
            WriteLiteral("                <td>\r\n                    ");
            EndContext();
            BeginContext(2849, 44, false);
#line 89 "C:\Users\b.khodakarami\Documents\Projects\saleFinal\Sale.FrontEnd\Views\Customers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(2893, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2961, 43, false);
#line 92 "C:\Users\b.khodakarami\Documents\Projects\saleFinal\Sale.FrontEnd\Views\Customers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(3004, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3072, 46, false);
#line 95 "C:\Users\b.khodakarami\Documents\Projects\saleFinal\Sale.FrontEnd\Views\Customers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(3118, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
#line 106 "C:\Users\b.khodakarami\Documents\Projects\saleFinal\Sale.FrontEnd\Views\Customers\Index.cshtml"
                 if (User.IsInRole("CustomerManager"))
                {

#line default
#line hidden
            BeginContext(3502, 50, true);
            WriteLiteral("                    <td>\r\n                        ");
            EndContext();
            BeginContext(3553, 54, false);
#line 109 "C:\Users\b.khodakarami\Documents\Projects\saleFinal\Sale.FrontEnd\Views\Customers\Index.cshtml"
                   Write(Html.ActionLink("تغییر", "Edit", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(3607, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(3636, 58, false);
#line 110 "C:\Users\b.khodakarami\Documents\Projects\saleFinal\Sale.FrontEnd\Views\Customers\Index.cshtml"
                   Write(Html.ActionLink("جزئیات", "Details", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(3694, 104, true);
            WriteLiteral(" |\r\n\r\n                        <a href=\"#myModal\" class=\"trigger-btn\" data-toggle=\"modal\" data-whatever=\"");
            EndContext();
            BeginContext(3799, 7, false);
#line 112 "C:\Users\b.khodakarami\Documents\Projects\saleFinal\Sale.FrontEnd\Views\Customers\Index.cshtml"
                                                                                             Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(3806, 40, true);
            WriteLiteral("\">حذف</a>\r\n\r\n                    </td>\r\n");
            EndContext();
#line 115 "C:\Users\b.khodakarami\Documents\Projects\saleFinal\Sale.FrontEnd\Views\Customers\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(3865, 23, true);
            WriteLiteral("                </tr>\r\n");
            EndContext();
#line 117 "C:\Users\b.khodakarami\Documents\Projects\saleFinal\Sale.FrontEnd\Views\Customers\Index.cshtml"

            }

#line default
#line hidden
            BeginContext(3905, 820, true);
            WriteLiteral(@"        </tbody>
    </table>
</div>









<div id=""myModal"" class=""modal fade"" tabindex=""0"">
    <div class=""modal-dialog modal-confirm"">
        <div class=""modal-content"">
            <div class=""modal-header"">
               
                
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
            </div>
            <div class=""modal-body"">
                <p>آیا برای حذف مورد انتخابی اطمینان دارید؟</p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-info"" data-dismiss=""modal"">بازگشت</button>
                <button type=""button"" class=""btn btn-danger deleteButton"">حذف</button>
            </div>
        </div>
    </div>
</div>









");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4744, 374, true);
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            var customerId;
            $('.trigger-btn').on(""click"", function (event) {
                customerId = $(this).attr('data-whatever');
               
            });


            $('.deleteButton').on(""click"", function (event) {

                
              $.ajax({

            url: '");
                EndContext();
                BeginContext(5119, 33, false);
#line 174 "C:\Users\b.khodakarami\Documents\Projects\saleFinal\Sale.FrontEnd\Views\Customers\Index.cshtml"
             Write(Url.Action("Delete", "Customers"));

#line default
#line hidden
                EndContext();
                BeginContext(5152, 243, true);
                WriteLiteral("\',\r\n            type: \"GET\",\r\n\r\n            data: {id:customerId },//this is as per your requirement\r\n            success: successFunc\r\n        });\r\n                function successFunc(response) {\r\n                     window.location.href =\'");
                EndContext();
                BeginContext(5396, 32, false);
#line 181 "C:\Users\b.khodakarami\Documents\Projects\saleFinal\Sale.FrontEnd\Views\Customers\Index.cshtml"
                                       Write(Url.Action("Index", "Customers"));

#line default
#line hidden
                EndContext();
                BeginContext(5428, 1091, true);
                WriteLiteral(@"';
                }



            });














            $('.close').click(function () {
                $('.alert').fadeOut(1000);
            });
            $('.alert').fadeOut(3000);

            $('#dtBasicExample').DataTable({
                ""language"": {
                    ""paginate"": {

                        ""first"": ""اولین صفحه"",
                        ""last"": ""آخرین صفحه"",

                        ""next"": ""صفحه ی بعد"",
                        ""previous"": ""صفحه ی قبل"",


                    },

                    ""emptyTable"": ""داده ای در جدول وجود ندارد."",
                    ""search"": ""جستجو"",
                    ""info"": ""نمایش  صفحه _PAGE_ از _PAGES_"",
                    ""zeroRecords"": ""نتیجه ای برای این جستجو یافت نشد."",
                    ""sLengthMenu"": ""نمایش _MENU_ در هر صفحه"",
                    ""sInfoFiltered"": """",

                    ""sInfoEmpty"": """"
                }

            });

            $('.dataTables_length').a");
                WriteLiteral("ddClass(\'bs-select\');\r\n        });\r\n\r\n      \r\n    </script>\r\n\r\n\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(6522, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Sale.Domain.Customers.Customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
