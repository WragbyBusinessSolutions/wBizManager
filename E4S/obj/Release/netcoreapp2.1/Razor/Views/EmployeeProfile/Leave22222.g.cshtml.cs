#pragma checksum "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\Leave22222.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc19ac699e48b100ebfc0876d822749c8db3eae9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EmployeeProfile_Leave22222), @"mvc.1.0.view", @"/Views/EmployeeProfile/Leave22222.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/EmployeeProfile/Leave22222.cshtml", typeof(AspNetCore.Views_EmployeeProfile_Leave22222))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc19ac699e48b100ebfc0876d822749c8db3eae9", @"/Views/EmployeeProfile/Leave22222.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0d6bd66a948813bdfc09794c8b8e3a2f8caf788", @"/Views/_ViewImports.cshtml")]
    public class Views_EmployeeProfile_Leave22222 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<E4S.Models.HumanResource.Dependant>>
    {
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
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\Leave22222.cshtml"
  
  ViewData["Title"] = "Dependents";
  Layout = "~/Views/Shared/_LayoutEmployee.cshtml";

#line default
#line hidden
            BeginContext(155, 281, true);
            WriteLiteral(@"
<div class=""content"">
  <div class=""card"">
    <div class=""card-header text-center"" data-background-color=""orange"">
      <h3 class=""card-title"">
        Dependents
      </h3>
      <h5 class=""description"">
        On boarding our new employee.
      </h5>
    </div>
");
            EndContext();
            BeginContext(488, 1193, true);
            WriteLiteral(@"
    <div class=""row"">
      <div class=""col-md-12"">
        <div class=""card "">

          <div class=""card-body "">

            <!-- Start of the Emergency Contact tabs-->


            <div class=""card-header"">
              <div class=""justify-content-end align-items-center "">
                <a class=""btn btn-fill btn-primary"" data-toggle=""modal"" data-target=""#noticeModal"">Create New</a>
              </div>
            </div>
            <!-- notice modal -->
            <div class=""modal fade"" id=""noticeModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
              <div class=""modal-dialog modal-notice"">
                <div class=""modal-content"">
                  <div class=""modal-header"">
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">
                      <i class=""now-ui-icons ui-1_simple-remove""></i>
                    </button>
                    <h5 class=""modal-title"" id=""myModalLabe");
            WriteLiteral("l\">Enter New Dependents</h5>\r\n                  </div>\r\n                  <div class=\"modal-body\">\r\n                    <div class=\"instruction\">\r\n                      ");
            EndContext();
            BeginContext(1681, 1697, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca850afc99ac47cb96096c72ffa804fe", async() => {
                BeginContext(1687, 1684, true);
                WriteLiteral(@"
                        <div class=""row"">
                          <div class=""col-md-12"">
                            <div class=""form-group"">
                              <label>Name</label>
                              <input id=""Name"" name=""Name"" type=""text"" class=""form-control"" placeholder=""Name"" required>
                            </div>
                          </div>
                        </div>

                        <div class=""row"">
                          <div class=""col-md-12"">
                            <div class=""form-group"">
                              <label>Relationship</label>
                              <input id=""Relationship"" name=""Relationship"" type=""text"" class=""form-control"" placeholder=""Relationship"">
                            </div>
                          </div>
                        </div>
                        <div class=""row"">
                          <div class=""col-md-12"">
                            <div class=""form-group"">
   ");
                WriteLiteral(@"                           <label>Address</label>
                              <input id=""Address"" name=""Address"" type=""text"" class=""form-control"" placeholder=""Address"">
                            </div>
                          </div>
                        </div>

                        <hr />
                        <div class=""card-footer "">
                          <button type=""button"" class=""btn btn-fill btn-primary btn-round"" id=""submitDependent"">Submit</button>
                          <button type=""button"" class=""btn btn-info btn-round"" data-dismiss=""modal"">Close</button>
                        </div>
                      ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3378, 890, true);
            WriteLiteral(@"
                    </div>
                  </div>
                </div>
              </div>
            </div>
            <!-- end notice modal -->

            <div class=""card-body"">
              <br />
              <table id=""datatable"" class=""table table-striped "" cellspacing=""10"" width=""100%"">
                <thead>
                  <tr>
                    <th> Name</th>
                    <th>Relationship</th>
                    <th class=""disabled-sorting text-right"">Actions</th>
                  </tr>
                </thead>
                <tfoot>
                  <tr>
                    <th> Name</th>
                    <th>Relationship</th>
                    <th>Address</th>
                    <th class=""disabled-sorting text-right"">Actions</th>
                  </tr>
                </tfoot>
                <tbody>

");
            EndContext();
#line 106 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\Leave22222.cshtml"
                   foreach (var item in Model)
                  {

#line default
#line hidden
            BeginContext(4337, 48, true);
            WriteLiteral("                  <tr>\r\n                    <td>");
            EndContext();
            BeginContext(4386, 9, false);
#line 109 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\Leave22222.cshtml"
                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4395, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(4427, 17, false);
#line 110 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\Leave22222.cshtml"
                   Write(item.Relationship);

#line default
#line hidden
            EndContext();
            BeginContext(4444, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(4476, 12, false);
#line 111 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\Leave22222.cshtml"
                   Write(item.Address);

#line default
#line hidden
            EndContext();
            BeginContext(4488, 358, true);
            WriteLiteral(@"</td>
                    <td class=""text-right"">
                      <a href=""#"" class=""btn btn-round btn-warning btn-icon btn-sm edit""><i class=""far fa-calendar-alt""></i></a>
                      <a href=""#"" class=""btn btn-round btn-danger btn-icon btn-sm remove""><i class=""fas fa-times""></i></a>
                    </td>
                  </tr>
");
            EndContext();
#line 117 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\Leave22222.cshtml"

                  }

#line default
#line hidden
            BeginContext(4869, 211, true);
            WriteLiteral("\r\n                </tbody>\r\n              </table>\r\n            </div>\r\n            <!-- the End of Emergency Contact Tabs-->\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n  </div>\r\n</div>\r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5098, 1378, true);
                WriteLiteral(@"


  <script type=""text/javascript"">

    $(document).ready(function () {

      $(""#submitDependent"").click(function (event) {

        event.preventDefault();

        var PostEmergencyContact = {
          Name: $(""#Name"").val(),
          Relationship: $(""#Relationship"").val(),
          Address: $(""#Address"").val(),
        };


        // console.log(Items);
        console.log(PostEmergencyContact);

        $.ajax({
          type: ""POST"",
          url: ""/EmployeeProfile/PostDependent"",
          data: JSON.stringify(PostEmergencyContact),
          dataType: ""json"",
          contentType: 'application/json; charset=utf-8',
          headers: {
            RequestVerificationToken:
              $('input:hidden[name=""__RequestVerificationToken""]').val()
          },
          success: function (r) {

            if (r.msg == ""Success"") {

              demo.showSwal('success-message');

            } else if (r.msg == ""Fail"") {

              alert(r.msg);

  ");
                WriteLiteral(@"          } else if (r.msg == ""No Data"") {
              alert(r.msg);

            } else {
              alert(r.msg);
            }
            //alert(r.msg);
            // window.location.reload();

          },
          error: function () {
            alert(r.msg);
          }
        });
      });


    });

  </script>

");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<E4S.Models.HumanResource.Dependant>> Html { get; private set; }
    }
}
#pragma warning restore 1591
