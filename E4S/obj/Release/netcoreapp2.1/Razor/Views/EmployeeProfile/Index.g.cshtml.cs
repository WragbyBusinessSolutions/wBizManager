#pragma checksum "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44ebb370885f0a77c62ff34b742df795558968f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EmployeeProfile_Index), @"mvc.1.0.view", @"/Views/EmployeeProfile/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/EmployeeProfile/Index.cshtml", typeof(AspNetCore.Views_EmployeeProfile_Index))]
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
#line 1 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\_ViewImports.cshtml"
using E4S;

#line default
#line hidden
#line 3 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\_ViewImports.cshtml"
using E4S.Models;

#line default
#line hidden
#line 4 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\_ViewImports.cshtml"
using E4S.Models.AccountViewModels;

#line default
#line hidden
#line 5 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\_ViewImports.cshtml"
using E4S.Models.ManageViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44ebb370885f0a77c62ff34b742df795558968f7", @"/Views/EmployeeProfile/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0d6bd66a948813bdfc09794c8b8e3a2f8caf788", @"/Views/_ViewImports.cshtml")]
    public class Views_EmployeeProfile_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<E4S.ViewModel.EmployeeDashboardViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("avatar border-gray"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/default-avatar1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("---"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PersonalDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\Index.cshtml"
  
    ViewData["Title"] = "Employee Profile";
    Layout = "~/Views/Shared/_LayoutEmployee.cshtml";

#line default
#line hidden
            BeginContext(159, 402, true);
            WriteLiteral(@"

<div class=""content"">
    <div class=""row"">
      <div class="" card-title"">
        <div class=""row"">
          <div class=""col-md-4"">
            <div class=""card card-user"">
              <div class=""image"">
                <img src=""../../assets/img/bg5.jpg"" alt=""..."">
              </div>
              <div class=""card-body"">
                <div class=""author"">
                  ");
            EndContext();
            BeginContext(561, 762, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07ed273208014849877571c2777380e9", async() => {
                BeginContext(593, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 21 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\Index.cshtml"
                     if (Model.ImageURL == null)
                    {

#line default
#line hidden
                BeginContext(668, 22, true);
                WriteLiteral("                      ");
                EndContext();
                BeginContext(690, 81, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "15d17cf8b0c04126b305e1fb9e094e55", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(771, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 24 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\Index.cshtml"

                    }
                    else
                    {

#line default
#line hidden
                BeginContext(847, 53, true);
                WriteLiteral("                      <img class=\"avatar border-gray\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 900, "\"", 921, 1);
#line 28 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\Index.cshtml"
WriteAttributeValue("", 906, Model.ImageURL, 906, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(922, 32, true);
                WriteLiteral(" alt=\"Employee Profile Image\">\r\n");
                EndContext();
#line 29 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\Index.cshtml"

                    }

#line default
#line hidden
                BeginContext(979, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 32 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\Index.cshtml"
                     if (Model.FirstName != null)
                    {

#line default
#line hidden
                BeginContext(1055, 40, true);
                WriteLiteral("                      <h5 class=\"title\">");
                EndContext();
                BeginContext(1096, 15, false);
#line 34 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\Index.cshtml"
                                   Write(Model.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(1111, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(1113, 14, false);
#line 34 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\Index.cshtml"
                                                    Write(Model.LastName);

#line default
#line hidden
                EndContext();
                BeginContext(1127, 7, true);
                WriteLiteral("</h5>\r\n");
                EndContext();
#line 35 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\Index.cshtml"

                    }
                    else
                    {

#line default
#line hidden
                BeginContext(1208, 68, true);
                WriteLiteral("                      <h5 class=\"title\">Please Update Profile</h5>\r\n");
                EndContext();
#line 40 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\Index.cshtml"

                    }

#line default
#line hidden
                BeginContext(1301, 18, true);
                WriteLiteral("                  ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1323, 65, true);
            WriteLiteral("\r\n                  <p class=\"description\">\r\n                    ");
            EndContext();
            BeginContext(1389, 14, false);
#line 44 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\Index.cshtml"
               Write(Model.JobTitle);

#line default
#line hidden
            EndContext();
            BeginContext(1403, 121, true);
            WriteLiteral("\r\n                  </p>\r\n                </div>\r\n                <p class=\"description text-center\">\r\n                  ");
            EndContext();
            BeginContext(1525, 16, false);
#line 48 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\Index.cshtml"
             Write(Model.Department);

#line default
#line hidden
            EndContext();
            BeginContext(1541, 66, true);
            WriteLiteral("\r\n                </p>\r\n              </div>\r\n              <hr>\r\n");
            EndContext();
            BeginContext(2184, 42, true);
            WriteLiteral("            </div>\r\n          </div>\r\n\r\n\r\n");
            EndContext();
            BeginContext(5487, 56, true);
            WriteLiteral("\r\n        </div>\r\n\r\n\r\n      </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<E4S.ViewModel.EmployeeDashboardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
