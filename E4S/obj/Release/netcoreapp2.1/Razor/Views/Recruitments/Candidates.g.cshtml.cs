#pragma checksum "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Recruitments\Candidates.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18614a54f26922215188086b9155708dcffb672f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recruitments_Candidates), @"mvc.1.0.view", @"/Views/Recruitments/Candidates.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Recruitments/Candidates.cshtml", typeof(AspNetCore.Views_Recruitments_Candidates))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18614a54f26922215188086b9155708dcffb672f", @"/Views/Recruitments/Candidates.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0d6bd66a948813bdfc09794c8b8e3a2f8caf788", @"/Views/_ViewImports.cshtml")]
    public class Views_Recruitments_Candidates : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Recruitments\Candidates.cshtml"
  
    ViewData["Title"] = "Candidates";
    Layout = "~/Views/Shared/_LayoutHumanResouces.cshtml";

#line default
#line hidden
            BeginContext(108, 290, true);
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
");
            EndContext();
            BeginContext(632, 849, true);
            WriteLiteral(@"
                  <h4 class=""card-title"">List of Candidates</h4>
                </div>
                <div class=""card-body"">
                  <br />
                  <table id=""datatable"" class=""table table-striped "" cellspacing=""10"" width=""100%"">
                    <thead>
                      <tr>
                        <th>Vacancy</th>
                        <th>First Name</th>
                        <th>Last Name</th>
                        <th>Middle Name</th>
                        <th>Phone Number</th>
                        <th>Email</th>
                        <th>Resume</th>
                        <th>Hiring Manager</th>
                        <th>Status</th>
                        <th class=""disabled-sorting text-right"">Options</th>
                      </tr>
                    </thead>
");
            EndContext();
            BeginContext(2074, 61, true);
            WriteLiteral("                    <tbody>\r\n\r\n                    </tbody>\r\n");
            EndContext();
            BeginContext(4983, 302, true);
            WriteLiteral(@"                  </table>
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