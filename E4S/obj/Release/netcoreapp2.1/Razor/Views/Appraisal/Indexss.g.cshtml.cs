#pragma checksum "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Appraisal\Indexss.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eecf76f26d9bfc73fc8d4b4462ca70fa726a9445"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Appraisal_Indexss), @"mvc.1.0.view", @"/Views/Appraisal/Indexss.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Appraisal/Indexss.cshtml", typeof(AspNetCore.Views_Appraisal_Indexss))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eecf76f26d9bfc73fc8d4b4462ca70fa726a9445", @"/Views/Appraisal/Indexss.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0d6bd66a948813bdfc09794c8b8e3a2f8caf788", @"/Views/_ViewImports.cshtml")]
    public class Views_Appraisal_Indexss : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Leaves", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Appraisal\Indexss.cshtml"
  
    ViewData["Title"] = "Leaves";
    Layout = "~/Views/Shared/_LayoutHumanResouces.cshtml";

#line default
#line hidden
            BeginContext(104, 459, true);
            WriteLiteral(@"
<div class=""content"">
    <div class=""row"">
        <!-- Column -->
        <div class=""container-fluid"">
            <div class=""content"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        <div class=""card"">
                            <div class=""card-header"">
                                <div class=""justify-content-end align-items-center pull-right"">
                                    ");
            EndContext();
            BeginContext(563, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df931838e19b4ce7a965e02a82a2b454", async() => {
                BeginContext(638, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
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
            BeginContext(652, 6129, true);
            WriteLiteral(@"
                                </div>
                                <h4 class=""card-title"">List of Leave Application</h4>
                            </div>
                            <div class=""card-body"">
                                <br />
                                <table id=""datatable"" class=""table table-striped "" cellspacing=""10"" width=""100%"">
                                    <thead>
                                        <tr>
                                            <th>Employee Name</th>
                                            <th>Leave</th>
                                            <th>Description</th>
                                            <th>Start Date</th>
                                            <th>End Date</th>
                                            <th>Approved Date</th>
                                            <th>Status</th>
                                            <th class=""disabled-sorting text-right"">Actions</th>
           ");
            WriteLiteral(@"                             </tr>
                                    </thead>
                                    <tfoot>
                                        <tr>
                                            <th>Employee Name</th>
                                            <th>Leave</th>
                                            <th>Description</th>
                                            <th>Start Date</th>
                                            <th>End Date</th>
                                            <th>Approved Date</th>
                                            <th>Status</th>
                                            <th class=""disabled-sorting text-right"">Actions</th>
                                        </tr>
                                    </tfoot>
                                    <tbody>
                                        <tr>
                                            <td>Tiger Nixon</td>
                                            <td>info");
            WriteLiteral(@"@TigerNixon.com</td>
                                            <td>Super Admin</td>
                                            <th></th>
                                            <th></th>
                                            <th></th>
                                            <td>Active</td>
                                            <td class=""text-right"">
                                                <a href=""#"" class=""btn btn-round btn-warning btn-icon btn-sm edit""><i class=""far fa-calendar-alt""></i></a>
                                                <a href=""#"" class=""btn btn-round btn-danger btn-icon btn-sm remove""><i class=""fas fa-times""></i></a>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>Garrett Winters</td>
                                            <td>info@GatterrWinters.com</td>
                                           ");
            WriteLiteral(@" <td>Admin</td>
                                            <th></th>
                                            <th></th>
                                            <th></th>
                                            <td>Pending</td>
                                            <td class=""text-right"">
                                                <a href=""#"" class=""btn btn-round btn-warning btn-icon btn-sm edit""><i class=""far fa-calendar-alt""></i></a>
                                                <a href=""#"" class=""btn btn-round btn-danger btn-icon btn-sm remove""><i class=""fas fa-times""></i></a>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>Ashton Cox</td>
                                            <td>ArthurCox@mail.com</td>
                                            <td>Employee</td>
                                            <th></th>
     ");
            WriteLiteral(@"                                       <th></th>
                                            <th></th>
                                            <td>Active</td>
                                            <td class=""text-right"">
                                                <a href=""#"" class=""btn btn-round btn-warning btn-icon btn-sm edit""><i class=""far fa-calendar-alt""></i></a>
                                                <a href=""#"" class=""btn btn-round btn-danger btn-icon btn-sm remove""><i class=""fas fa-times""></i></a>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>Cedric Kelly</td>
                                            <td>cedrickelly@mail.com</td>
                                            <td>Accountant</td>
                                            <th></th>
                                            <th></th>
                      ");
            WriteLiteral(@"                      <th></th>
                                            <td>Active</td>
                                            <td class=""text-right"">
                                                <a href=""#"" class=""btn btn-round btn-warning btn-icon btn-sm edit""><i class=""far fa-calendar-alt""></i></a>
                                                <a href=""#"" class=""btn btn-round btn-danger btn-icon btn-sm remove""><i class=""fas fa-times""></i></a>
                                            </td>
                                        </tr>

                                    </tbody>
                                </table>
                            </div>
                            <!-- end content-->
                        </div>
                        <!--  end card  -->
                    </div>
                    <!-- end col-md-12 -->
                </div>
                <!-- end row -->
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
