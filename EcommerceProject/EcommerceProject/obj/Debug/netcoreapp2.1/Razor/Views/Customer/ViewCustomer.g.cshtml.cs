#pragma checksum "C:\Users\Jahir\source\repos\EcommerceProject\EcommerceProject\Views\Customer\ViewCustomer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38f8cf8c2d76e692fd4036f62168eb4215eca0ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_ViewCustomer), @"mvc.1.0.view", @"/Views/Customer/ViewCustomer.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/ViewCustomer.cshtml", typeof(AspNetCore.Views_Customer_ViewCustomer))]
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
#line 1 "C:\Users\Jahir\source\repos\EcommerceProject\EcommerceProject\Views\_ViewImports.cshtml"
using EcommerceProject;

#line default
#line hidden
#line 2 "C:\Users\Jahir\source\repos\EcommerceProject\EcommerceProject\Views\_ViewImports.cshtml"
using EcommerceProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38f8cf8c2d76e692fd4036f62168eb4215eca0ac", @"/Views/Customer/ViewCustomer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"221fb0acfc1751d620f02ffa1e872e29d71f88d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_ViewCustomer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EcommerceProject.ViewModels.ViewModel_Customer>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-user btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Jahir\source\repos\EcommerceProject\EcommerceProject\Views\Customer\ViewCustomer.cshtml"
  
    ViewData["Title"] = "View Customer";
    Layout = "_MyLayout";

#line default
#line hidden
            BeginContext(144, 34, true);
            WriteLiteral("<h2 class=\"h3 mb-4 text-gray-800\">");
            EndContext();
            BeginContext(179, 17, false);
#line 6 "C:\Users\Jahir\source\repos\EcommerceProject\EcommerceProject\Views\Customer\ViewCustomer.cshtml"
                             Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(196, 16, true);
            WriteLiteral("</h2>\r\n<p>\r\n    ");
            EndContext();
            BeginContext(212, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e39a013097064c909a12938c04f5ce61", async() => {
                BeginContext(278, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(292, 151, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                #Sl.\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(444, 48, false);
#line 17 "C:\Users\Jahir\source\repos\EcommerceProject\EcommerceProject\Views\Customer\ViewCustomer.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(492, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(548, 43, false);
#line 20 "C:\Users\Jahir\source\repos\EcommerceProject\EcommerceProject\Views\Customer\ViewCustomer.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(591, 57, true);
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(649, 45, false);
#line 24 "C:\Users\Jahir\source\repos\EcommerceProject\EcommerceProject\Views\Customer\ViewCustomer.cshtml"
           Write(Html.DisplayNameFor(model => model.ContactNo));

#line default
#line hidden
            EndContext();
            BeginContext(694, 69, true);
            WriteLiteral("\r\n            </th>\r\n            \r\n            <th>\r\n                ");
            EndContext();
            BeginContext(764, 48, false);
#line 28 "C:\Users\Jahir\source\repos\EcommerceProject\EcommerceProject\Views\Customer\ViewCustomer.cshtml"
           Write(Html.DisplayNameFor(model=> model.UserType.Type));

#line default
#line hidden
            EndContext();
            BeginContext(812, 63, true);
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 33 "C:\Users\Jahir\source\repos\EcommerceProject\EcommerceProject\Views\Customer\ViewCustomer.cshtml"
      
        int count = 1;
    

#line default
#line hidden
            BeginContext(914, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 36 "C:\Users\Jahir\source\repos\EcommerceProject\EcommerceProject\Views\Customer\ViewCustomer.cshtml"
     foreach (var item in Model)
    {


#line default
#line hidden
            BeginContext(957, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(988, 5, false);
#line 40 "C:\Users\Jahir\source\repos\EcommerceProject\EcommerceProject\Views\Customer\ViewCustomer.cshtml"
           Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(993, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1017, 47, false);
#line 41 "C:\Users\Jahir\source\repos\EcommerceProject\EcommerceProject\Views\Customer\ViewCustomer.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(1064, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1088, 42, false);
#line 42 "C:\Users\Jahir\source\repos\EcommerceProject\EcommerceProject\Views\Customer\ViewCustomer.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1130, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1154, 44, false);
#line 43 "C:\Users\Jahir\source\repos\EcommerceProject\EcommerceProject\Views\Customer\ViewCustomer.cshtml"
           Write(Html.DisplayFor(modelItem => item.ContactNo));

#line default
#line hidden
            EndContext();
            BeginContext(1198, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1222, 46, false);
#line 44 "C:\Users\Jahir\source\repos\EcommerceProject\EcommerceProject\Views\Customer\ViewCustomer.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserType.id));

#line default
#line hidden
            EndContext();
            BeginContext(1268, 41, true);
            WriteLiteral("</td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1310, 49, false);
#line 46 "C:\Users\Jahir\source\repos\EcommerceProject\EcommerceProject\Views\Customer\ViewCustomer.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new {id=item.Id}));

#line default
#line hidden
            EndContext();
            BeginContext(1359, 19, true);
            WriteLiteral("|\r\n                ");
            EndContext();
            BeginContext(1379, 55, false);
#line 47 "C:\Users\Jahir\source\repos\EcommerceProject\EcommerceProject\Views\Customer\ViewCustomer.cshtml"
           Write(Html.ActionLink("Details", "Details", new {id=item.Id}));

#line default
#line hidden
            EndContext();
            BeginContext(1434, 19, true);
            WriteLiteral("|\r\n                ");
            EndContext();
            BeginContext(1454, 57, false);
#line 48 "C:\Users\Jahir\source\repos\EcommerceProject\EcommerceProject\Views\Customer\ViewCustomer.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new {/*id=item.Id*/}));

#line default
#line hidden
            EndContext();
            BeginContext(1511, 37, true);
            WriteLiteral("|\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 51 "C:\Users\Jahir\source\repos\EcommerceProject\EcommerceProject\Views\Customer\ViewCustomer.cshtml"
        count++;
    }

#line default
#line hidden
            BeginContext(1573, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EcommerceProject.ViewModels.ViewModel_Customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
