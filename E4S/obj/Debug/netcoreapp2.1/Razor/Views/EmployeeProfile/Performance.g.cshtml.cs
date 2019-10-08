#pragma checksum "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\Performance.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8dd260826edae6a9fd24a6417bef6a1e8e87f121"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EmployeeProfile_Performance), @"mvc.1.0.view", @"/Views/EmployeeProfile/Performance.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/EmployeeProfile/Performance.cshtml", typeof(AspNetCore.Views_EmployeeProfile_Performance))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dd260826edae6a9fd24a6417bef6a1e8e87f121", @"/Views/EmployeeProfile/Performance.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0d6bd66a948813bdfc09794c8b8e3a2f8caf788", @"/Views/_ViewImports.cshtml")]
    public class Views_EmployeeProfile_Performance : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<E4S.ViewModel.EmployeePerformanceViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AppraisalTemplate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-round btn-warning btn-icon btn-sm "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Click to View"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\Performance.cshtml"
  
  ViewData["Title"] = "Performance";
  Layout = "~/Views/Shared/_LayoutEmployee.cshtml";

#line default
#line hidden
            BeginContext(152, 1008, true);
            WriteLiteral(@"
  <div class=""content"">
    <div class=""row"">
      <div class=""col-md-12"">
        <div class=""card card-stats card-raised"">
          <div class=""card-body"">
            <div class=""row"">
              <div class=""col-md-4"">
                <h4>Ongoing Appraisal</h4>
              </div>

            </div>

            <div class=""row"">
              <div class=""col-md-12"">
                <div class=""card"">

                  <div class=""card-body"">
                    <br />
                    <table id=""datatable"" class=""table table-striped table-bordered"" cellspacing=""0"" width=""100%"">
                      <thead>
                        <tr>
                          <th>Title</th>
                          <th>Start Date</th>
                          <th>End Date</th>
                          <th>IsActive</th>
                          <th class=""disabled-sorting text-right"">Actions</th>
                        </tr>
                      </thead>


");
            EndContext();
#line 38 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\Performance.cshtml"
                           foreach (var item in Model.AppraisalAssignedTemplates)
                          {

#line default
#line hidden
            BeginContext(1272, 68, true);
            WriteLiteral("                            <tr>\r\n                              <td>");
            EndContext();
            BeginContext(1341, 31, false);
#line 41 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\Performance.cshtml"
                             Write(item.AppraisalTemplate.Template);

#line default
#line hidden
            EndContext();
            BeginContext(1372, 41, true);
            WriteLiteral("</td>\r\n                              <td>");
            EndContext();
            BeginContext(1414, 50, false);
#line 42 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\Performance.cshtml"
                             Write(item.Appraisal.StartDate.ToString("MMMM dd, yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1464, 41, true);
            WriteLiteral("</td>\r\n                              <td>");
            EndContext();
            BeginContext(1506, 48, false);
#line 43 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\Performance.cshtml"
                             Write(item.Appraisal.EndDate.ToString("MMMM dd, yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1554, 75, true);
            WriteLiteral("</td>\r\n                              <td>\r\n                                ");
            EndContext();
            BeginContext(1630, 11, false);
#line 45 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\Performance.cshtml"
                           Write(item.Status);

#line default
#line hidden
            EndContext();
            BeginContext(1641, 126, true);
            WriteLiteral("\r\n                              </td>\r\n                              <td class=\"text-right\">\r\n                                ");
            EndContext();
            BeginContext(1767, 205, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2be7f65570e04431a9114b3fb8d078f8", async() => {
                BeginContext(1933, 35, true);
                WriteLiteral("<i class=\"far fa-calendar-alt\"></i>");
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
#line 48 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\Performance.cshtml"
                                                                    WriteLiteral(item.AppraisalTemplateId);

#line default
#line hidden
            WriteLiteral(",");
#line 48 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\Performance.cshtml"
                                                                                              WriteLiteral(item.AppraisalId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(1972, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2136, 72, true);
            WriteLiteral("                              </td>\r\n                            </tr>\r\n");
            EndContext();
#line 52 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\Performance.cshtml"

                          }

#line default
#line hidden
            BeginContext(2239, 1223, true);
            WriteLiteral(@"                      </tbody>
                    </table>
                  </div>




                </div>
              </div>

            </div>

          </div>
        </div>
      </div>
    </div>

    <div class=""row"">
      <div class=""col-md-12"">
        <div class=""card card-stats card-raised"">
          <div class=""card-body"">
            <div class=""row"">
              <div class=""col-md-4"">
                <h4>Appraisal Record</h4>
              </div>

            </div>

            <div class=""row"">
              <div class=""col-md-12"">
                <div class=""card"">

                  <div class=""card-body"">
                    <br />
                    <table  class=""table table-striped table-bordered"" cellspacing=""0"" width=""100%"">
                      <thead>
                        <tr>
                          <th>Title</th>
                          <th>Start Date</th>
                          <th>End Date</th>
                      ");
            WriteLiteral("    <th>IsActive</th>\r\n                          <th class=\"disabled-sorting text-right\">Actions</th>\r\n                        </tr>\r\n                      </thead>\r\n\r\n                      <tbody>\r\n");
            EndContext();
            BeginContext(4418, 242, true);
            WriteLiteral("\r\n                      </tbody>\r\n                    </table>\r\n                  </div>\r\n\r\n\r\n\r\n\r\n                </div>\r\n              </div>\r\n\r\n            </div>\r\n\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n\r\n\r\n  </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<E4S.ViewModel.EmployeePerformanceViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
