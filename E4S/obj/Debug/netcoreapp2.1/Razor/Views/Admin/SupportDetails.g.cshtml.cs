#pragma checksum "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\SupportDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98ee6934d78dd8dc11db7d9cd994cd6c3ddf55f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_SupportDetails), @"mvc.1.0.view", @"/Views/Admin/SupportDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/SupportDetails.cshtml", typeof(AspNetCore.Views_Admin_SupportDetails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98ee6934d78dd8dc11db7d9cd994cd6c3ddf55f0", @"/Views/Admin/SupportDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0d6bd66a948813bdfc09794c8b8e3a2f8caf788", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_SupportDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<E4S.Models.WragbyAdmin.Ticket>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "createbranch", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\SupportDetails.cshtml"
  
  ViewData["Title"] = "Support Details";

#line default
#line hidden
            BeginContext(89, 254, true);
            WriteLiteral("\r\n\r\n<div class=\"content\">\r\n  <div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n      <div class=\"card \">\r\n        <div class=\"card-header \">\r\n          <h4 class=\"card-title\">Support Details</h4>\r\n        </div>\r\n        <div class=\"card-body \">\r\n          ");
            EndContext();
            BeginContext(343, 2348, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a26da8839db4cb6b3ad3ecbcb96b569", async() => {
                BeginContext(413, 221, true);
                WriteLiteral("\r\n            <div class=\"row\">\r\n              <label class=\"col-md-3 col-form-label\">Ticket ID</label>\r\n              <div class=\"col-md-9\">\r\n                <div class=\"form-group\">\r\n                  <input type=\"text\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 634, "\"", 658, 1);
#line 21 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\SupportDetails.cshtml"
WriteAttributeValue("", 642, Model.SupportId, 642, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(659, 340, true);
                WriteLiteral(@" class=""form-control"" placeholder=""Branch Name"" readonly>
                </div>
              </div>
            </div>
            <div class=""row"">
              <label class=""col-md-3 col-form-label"">Title</label>
              <div class=""col-md-9"">
                <div class=""form-group"">
                  <input type=""text""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 999, "\"", 1019, 1);
#line 29 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\SupportDetails.cshtml"
WriteAttributeValue("", 1007, Model.Title, 1007, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1020, 304, true);
                WriteLiteral(@" class=""form-control"" placeholder=""Email"" readonly>
                </div>
              </div>
            </div>
            <div class=""row"">
              <label class=""col-md-3 col-form-label"">Description</label>
              <div class=""col-md-9"">
                <div class=""form-group"">
");
                EndContext();
                BeginContext(1444, 27, true);
                WriteLiteral("                  <textarea");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1471, "\"", 1497, 1);
#line 38 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\SupportDetails.cshtml"
WriteAttributeValue("", 1479, Model.Description, 1479, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1498, 363, true);
                WriteLiteral(@" class=""form-control"" placeholder=""Description"" rows=""3"" readonly></textarea>
                </div>
              </div>
            </div>
            <div class=""row"">
              <label class=""col-md-3 col-form-label"">Severity</label>
              <div class=""col-md-9"">
                <div class=""form-group"">
                  <input type=""text""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1861, "\"", 1884, 1);
#line 46 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\SupportDetails.cshtml"
WriteAttributeValue("", 1869, Model.Severity, 1869, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1885, 118, true);
                WriteLiteral(" class=\"form-control\" placeholder=\"City\" readonly>\r\n                </div>\r\n              </div>\r\n            </div>\r\n");
                EndContext();
                BeginContext(2354, 330, true);
                WriteLiteral(@"            <div class=""card-footer "">
              <div class=""row"">
                <label class=""col-md-3""></label>
                <div class=""col-md-9"">
                  <button type=""submit"" class=""btn btn-fill btn-primary"">Reply</button>
                </div>
              </div>
            </div>

          ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2691, 70, true);
            WriteLiteral("\r\n        </div>\r\n      </div>\r\n    </div>\r\n  </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<E4S.Models.WragbyAdmin.Ticket> Html { get; private set; }
    }
}
#pragma warning restore 1591
