#pragma checksum "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\CompanyListing.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab67f52c154c93a46f2bf282f9bf9a5057a16243"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_CompanyListing), @"mvc.1.0.view", @"/Views/Admin/CompanyListing.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/CompanyListing.cshtml", typeof(AspNetCore.Views_Admin_CompanyListing))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab67f52c154c93a46f2bf282f9bf9a5057a16243", @"/Views/Admin/CompanyListing.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0d6bd66a948813bdfc09794c8b8e3a2f8caf788", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_CompanyListing : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<E4S.Models.Organisation>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateOrganizationDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("tooltip"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("View Details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\CompanyListing.cshtml"
  
ViewData["Title"]="Company Listing" ;
Layout="~/Views/Shared/_LayoutWragbyAdmin.cshtml" ;

#line default
#line hidden
            BeginContext(146, 2087, true);
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
                    <div class=""row"">
                        <div class=""col-md-12"">
                            <div class=""col-md-6 pull-left"">
                                <h4 class=""card-title"">Company Listing</h4>
                            </div>
                        </div>
                    </div>



                </div>
                <div class=""card-body body-card"">
                    <div class=""row"">
                        <div class=""col-lg-12"">
                            <div class=""table-responsive"" style=""overflow:auto;"">
                                <table id=""datatable2"" class=""table t");
            WriteLiteral(@"able-striped"" cellspacing=""10"" width=""100%"">
                                    <thead>
                                        <tr>
                                            <th class=""text-center""><strong>S/N</strong></th>
                                            <th scope=""col""><strong>Organisation Name</strong></th>
                                            <th scope=""col"" class=""text-center""><strong>Users </strong></th>
                                            <th scope=""col"" class=""text-center""><strong>Total License </strong></th>
                                            <th scope=""col"" class=""text-center""><strong>Total Active License</strong></th>
                                            <th scope=""col"" class=""text-center""><strong>Status</strong></th>
                                            <th scope=""col"" class=""pull-left""><strong>Actions</strong></th>
                                        </tr>
                                    </thead>
                           ");
            WriteLiteral("         <tbody class=\"fontweight\">\r\n\r\n");
            EndContext();
#line 56 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\CompanyListing.cshtml"
                                          
                                            int i = 1;

                                            

#line default
#line hidden
#line 59 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\CompanyListing.cshtml"
                                             if (Model.Count() < 1)
                                            {

#line default
#line hidden
            BeginContext(2451, 326, true);
            WriteLiteral(@"                                                <tr>
                                                    <td></td>
                                                    <td>No Organisation to Display</td>
                                                    <td></td>

                                                </tr>
");
            EndContext();
#line 67 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\CompanyListing.cshtml"

                                            }

#line default
#line hidden
#line 70 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\CompanyListing.cshtml"
                                             foreach (var item in Model )
                                            {


#line default
#line hidden
            BeginContext(2952, 211, true);
            WriteLiteral("                                                <tr>\r\n                                                    <td scope=\"row\" class=\"table-font text-center\">\r\n                                                        ");
            EndContext();
            BeginContext(3164, 1, false);
#line 75 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\CompanyListing.cshtml"
                                                   Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(3165, 131, true);
            WriteLiteral("\r\n                                                    </td>\r\n\r\n                                                    <td scope=\"row\">");
            EndContext();
            BeginContext(3297, 21, false);
#line 78 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\CompanyListing.cshtml"
                                                               Write(item.OrganisationName);

#line default
#line hidden
            EndContext();
            BeginContext(3318, 95, true);
            WriteLiteral("</td>\r\n                                                    <td scope=\"row\" class=\"text-center\">");
            EndContext();
            BeginContext(3414, 18, false);
#line 79 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\CompanyListing.cshtml"
                                                                                   Write(item.NoOfEmployees);

#line default
#line hidden
            EndContext();
            BeginContext(3432, 467, true);
            WriteLiteral(@"</td>
                                                    <td scope=""row"" class=""text-center"">201</td>
                                                    <td scope=""row"" class=""text-center"">2</td>
                                                    <td scope=""row"" class=""text-center""> <button class=""btn btn-success"">Active</button></td>
                                                    <td class="""">
                                                        ");
            EndContext();
            BeginContext(3899, 194, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c8f62baf5434db9a5760dd895e1203c", async() => {
                BeginContext(4064, 25, true);
                WriteLiteral("<i class=\"fa fa-eye\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 84 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\CompanyListing.cshtml"
                                                                                                                           WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4093, 116, true);
            WriteLiteral("\r\n                                                    </td>\r\n                                                </tr>\r\n");
            EndContext();
#line 87 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\CompanyListing.cshtml"

                                                { i = i + 1; }
                                            }

#line default
#line hidden
            BeginContext(4365, 284, true);
            WriteLiteral(@"
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
            DefineSection("Scripts", async() => {
                BeginContext(4667, 3318, true);
                WriteLiteral(@"



    <script>
      $(document).ready(function () {

          $('#datatable2').DataTable({
              ""pagingType"": ""full_numbers"",
              dom: ""Bfrtip"",
              ""lengthMenu"": [
                  [10, 25, 50, -1],
                  [10, 25, 50, ""All""]
              ],


              buttons: [
                  'copy',
                  'excel',
                  'csv',
                  'pdf',
                  'print',
              ],


              responsive: true,
              language: {
                  search: ""_INPUT_"",
                  searchPlaceholder: ""Search records"",
              }

          });

          var table = $('#datatable2').DataTable();

          // Delete a record
          table.on('click', '.remove', function (e) {
              $tr = $(this).closest('tr');

                jobId = $(this).attr('JobId');
                jobTitle = $(this).attr('JobTitle');


              swal({
                  title: 'Are ");
                WriteLiteral(@"you sure?',
                  text: ""You are about to delete '"" + jobTitle + ""'"",
                  type: 'warning',
                  showCancelButton: true,
                  confirmButtonClass: 'btn btn-success',
                  cancelButtonClass: 'btn btn-danger',
                  confirmButtonText: 'Yes, delete it!',
                  buttonsStyling: false
              }).then(function () {

                  $.ajax({
                      type: ""POST"",
                      url: ""/Jobs/deleteJobTitle"",
                      data: JSON.stringify(jobId),
                      dataType: ""json"",
                      contentType: 'application/json; charset=utf-8',
                      headers: {
                          RequestVerificationToken:
                              $('input:hidden[name=""__RequestVerificationToken""]').val()
                      },
                      success: function (r) {

                          if (r.msg == ""Success"") {

                      ");
                WriteLiteral(@"        swal({
                                  title: 'Deleted!',
                                  text: 'Your file has been deleted.',
                                  type: 'success',
                                  confirmButtonClass: ""btn btn-success"",
                                  buttonsStyling: false
                              });


                          } else if (r.msg == ""Fail"") {

                              alert(r.msg);

                          } else if (r.msg == ""No Data"") {
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


                  table.row($tr).remove().draw();

              }).cat");
                WriteLiteral("ch(swal.noop);\r\n\r\n\r\n              e.preventDefault();\r\n          });\r\n\r\n          //Like record\r\n          table.on(\'click\', \'.like\', function () {\r\n              alert(\'You clicked on Like button\');\r\n          });\r\n      });\r\n    </script>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<E4S.Models.Organisation>> Html { get; private set; }
    }
}
#pragma warning restore 1591
