#pragma checksum "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Appraisal\AddTemplate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "513313b4440f4d17695be71ae97bb7ae46332b29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Appraisal_AddTemplate), @"mvc.1.0.view", @"/Views/Appraisal/AddTemplate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Appraisal/AddTemplate.cshtml", typeof(AspNetCore.Views_Appraisal_AddTemplate))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"513313b4440f4d17695be71ae97bb7ae46332b29", @"/Views/Appraisal/AddTemplate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0d6bd66a948813bdfc09794c8b8e3a2f8caf788", @"/Views/_ViewImports.cshtml")]
    public class Views_Appraisal_AddTemplate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Appraisal\AddTemplate.cshtml"
  
    ViewData["Title"] = "Add Template";
    Layout = "~/Views/Shared/_LayoutHumanResouces.cshtml";

#line default
#line hidden
            BeginContext(110, 372, true);
            WriteLiteral(@"
<style>
    .body-card {
        margin-left: 2%;
        margin-right: 2%;
        margin-top: 1%;
        margin-bottom: 2%;
    }

    .button-padding {
        margin-right: 10px
    }
</style>

<div class=""content"">
  <div class=""row"">

    



    <div class=""col-lg-12"">
      <div class=""card"">
        <div class=""card-header body-card"">
");
            EndContext();
            BeginContext(1394, 53, true);
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-md-10\">\r\n");
            EndContext();
            BeginContext(1482, 135, true);
            WriteLiteral("          <div class=\"card-header \">\r\n            <h4 class=\"card-title\">Add Template Name</h4>\r\n            <br />\r\n          </div>\r\n");
            EndContext();
            BeginContext(1657, 10, true);
            WriteLiteral("          ");
            EndContext();
            BeginContext(1667, 346, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c53707f7a84a4bac9998292e1c6f5c39", async() => {
                BeginContext(1697, 309, true);
                WriteLiteral(@"
          <div class=""row"">
            <label class=""col-md-3 col-form-label"">Template Name</label>
            <div class=""col-md-6"">
              <div class=""form-group"">
                <input type=""text"" class=""form-control"">
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2013, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2059, 599, true);
            WriteLiteral(@"        </div>

        <div class=""card-body body-card"">
          <h4 class=""card-title col-md-4"">Add Template</h4>

          <div class=""row"">
            <div class=""col-lg-12"">
              <div class=""table-responsive table-responsive-sm"" style=""overflow:auto;"">
                <table id=""datatable"" class=""table table-hover"">
                  <thead>
                    <tr>
                      <th><strong>S/N</strong></th>
                      <th scope=""col""><strong>Template Name</strong></th>
                      <th scope=""col""><strong>Assigned To</strong></th>
");
            EndContext();
            BeginContext(2730, 412, true);
            WriteLiteral(@"                      <th scope=""col"" class=""disabled-sorting""><strong>Actions</strong></th>
                    </tr>
                  </thead>
                  <tbody class=""fontweight"">
                    <tr>
                      <td scope=""row"" class=""table-font"">1</td>
                      <td scope=""row"">Associates Template</td>
                      <td scope=""row"">Devops Associates</td>
");
            EndContext();
            BeginContext(3196, 802, true);
            WriteLiteral(@"
                      <td class="""">
                        <a href=""#"" class=""btn btn-md btn-info btn-sm like"" data-toggle=""tooltip"" data-placement=""top"" title=""View/Update""><i class=""fas fa-eye""></i></a>
                        <a href=""#"" class=""btn btn-success btn-icon btn-sm edit"" data-toggle=""tooltip"" data-placement=""top"" title=""Send as Mail""><i class=""fas fa-paper-plane""></i></a>
                        <a href=""#"" class=""btn btn-primary btn-icon btn-sm remove"" data-toggle=""tooltip"" data-placement=""top"" title=""Convert to Invoice""><i class=""far fa-file-alt""></i></a>
                      </td>
                    </tr>
                    <tr>
                      <td>2</td>
                      <td>Consultants Template</td>
                      <td>TSS Consultants</td>
");
            EndContext();
            BeginContext(4039, 823, true);
            WriteLiteral(@"
                      <td class="""">
                        <a href=""#"" class=""btn btn-md btn-info btn-sm like"" data-toggle=""tooltip"" data-placement=""top"" title=""View/Update""><i class=""fas fa-eye""></i></a>
                        <a href=""#"" class=""btn btn-success btn-icon btn-sm edit"" data-toggle=""tooltip"" data-placement=""top"" title=""Send as Mail""><i class=""fas fa-paper-plane""></i></a>
                        <a href=""#"" class=""btn btn-primary btn-icon btn-sm remove"" data-toggle=""tooltip"" data-placement=""top"" title=""Convert to Invoice""><i class=""far fa-file-alt""></i></a>
                      </td>
                    </tr>
                  </tbody>
                </table>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
      </div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
