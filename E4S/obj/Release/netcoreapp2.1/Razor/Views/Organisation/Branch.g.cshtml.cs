#pragma checksum "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Organisation\Branch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bb73b6f7481b63f4d6172cf1f771e93ae3f2163"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Organisation_Branch), @"mvc.1.0.view", @"/Views/Organisation/Branch.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Organisation/Branch.cshtml", typeof(AspNetCore.Views_Organisation_Branch))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bb73b6f7481b63f4d6172cf1f771e93ae3f2163", @"/Views/Organisation/Branch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0d6bd66a948813bdfc09794c8b8e3a2f8caf788", @"/Views/_ViewImports.cshtml")]
    public class Views_Organisation_Branch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<E4S.Models.Branch>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "createbranch", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Organisation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Organisation\Branch.cshtml"
  
  ViewData["Title"] = "Branch";
      Layout = "_LayoutNew";


#line default
#line hidden
            BeginContext(113, 86, true);
            WriteLiteral("\r\n<style>\r\n  .body-pad {\r\n    padding: 2%;\r\n  }\r\n</style>\r\n\r\n<div class=\"content\">\r\n  ");
            EndContext();
            BeginContext(200, 79, false);
#line 16 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Organisation\Branch.cshtml"
Write(Html.Partial("~/Views/Manage/_StatusMessage.cshtml", ViewData["StatusMessage"]));

#line default
#line hidden
            EndContext();
            BeginContext(279, 254, true);
            WriteLiteral("\r\n\r\n  <div class=\"row\">\r\n    <!-- Column -->\r\n    <div class=\"container-fluid\">\r\n      <div class=\"content\">\r\n        <div class=\"row\">\r\n          <div class=\"col-md-12\">\r\n            <div class=\"card body-pad\">\r\n              <div class=\"card-header\">\r\n");
            EndContext();
            BeginContext(618, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(634, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa6c9d42e2b642758a53515f1a56352f", async() => {
                BeginContext(714, 10, true);
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
            BeginContext(728, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(758, 908, true);
            WriteLiteral(@"
                <h4 class=""card-title"">List of Branches</h4>
              </div>
              <div class=""card-body"">
                <br />


                <div class=""modal fade"" id=""noticeModal1"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
                  <div class=""modal-dialog modal-notice"">
                    <div class=""modal-content"">
                      <div class=""modal-header"">
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">
                          <i class=""now-ui-icons ui-1_simple-remove""></i>
                        </button>
                        <h5 class=""modal-title"" id=""myModalLabel"">Edit Branch Details</h5>
                      </div>
                      <div class=""modal-body"">
                        <div class=""instruction"">
                          ");
            EndContext();
            BeginContext(1666, 2827, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2cf9442e13cb45d6802fabdfdb6047ab", async() => {
                BeginContext(1686, 2800, true);
                WriteLiteral(@"
                            <input id=""ebranchid"" name=""ebranchid"" hidden />
                            <div class=""row"">
                              <div class=""col-md-12"">
                                <div class=""form-group"">
                                  <label>Name</label>
                                  <input type=""text"" class=""form-control"" placeholder=""Branch Name"" id=""branchName"" name=""branchName"" required>
                                </div>
                              </div>
                            </div>
                            <div class=""row"">
                              <div class=""col-md-12"">
                                <div class=""form-group"">
                                  <label>E-Mail</label>
                                  <input type=""text"" class=""form-control"" placeholder=""E-Mail"" id=""eMail"" name=""eMail"" required>
                                </div>
                              </div>
                            </div>
         ");
                WriteLiteral(@"                   <div class=""row"">
                              <div class=""col-md-12"">
                                <div class=""form-group"">
                                  <label>Phone</label>
                                  <input type=""text"" class=""form-control"" placeholder=""Phone"" id=""Phone"" name=""Phone"" required>
                                </div>
                              </div>
                            </div>
                            <div class=""row"">
                              <div class=""col-md-12"">
                                <div class=""form-group"">
                                  <label>City</label>
                                  <input type=""text"" class=""form-control"" placeholder=""City"" id=""City"" name=""City"" required>
                                </div>
                              </div>
                            </div>
                            <div class=""row"">
                              <div class=""col-md-12"">
                 ");
                WriteLiteral(@"               <div class=""form-group"">
                                  <label>Country</label>
                                  <input type=""text"" class=""form-control"" placeholder=""Country"" id=""Country"" name=""Country"" required>
                                </div>
                              </div>
                            </div>

                            <hr />
                            <div class=""card-footer "">
                              <button type=""submit"" class=""btn btn-fill btn-primary btn-round"" id=""editBranch"">Submit</button>
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4493, 64, true);
            WriteLiteral("\r\n                        </div>\r\n                      </div>\r\n");
            EndContext();
            BeginContext(4791, 752, true);
            WriteLiteral(@"                    </div>
                  </div>
                </div>



                <div class=""row"">
                  <div class=""col-12 col-sm-12 col-lg-12"">
                    <div class=""table-responsive"" style=""overflow:auto"">
                      <table id=""datatable2"" class=""table table-striped"">
                        <thead>
                          <tr>
                            <th>Name</th>
                            <th>E-mail</th>
                            <th>Phone</th>
                            <th>City</th>
                            <th class=""disabled-sorting text-right"">Actions</th>
                          </tr>
                        </thead>
                        <tbody>

");
            EndContext();
#line 122 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Organisation\Branch.cshtml"
                           foreach (var item in Model)
                          {

#line default
#line hidden
            BeginContext(5628, 68, true);
            WriteLiteral("                            <tr>\r\n                              <td>");
            EndContext();
            BeginContext(5697, 15, false);
#line 125 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Organisation\Branch.cshtml"
                             Write(item.BranchName);

#line default
#line hidden
            EndContext();
            BeginContext(5712, 41, true);
            WriteLiteral("</td>\r\n                              <td>");
            EndContext();
            BeginContext(5754, 10, false);
#line 126 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Organisation\Branch.cshtml"
                             Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(5764, 41, true);
            WriteLiteral("</td>\r\n                              <td>");
            EndContext();
            BeginContext(5806, 12, false);
#line 127 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Organisation\Branch.cshtml"
                             Write(item.PhoneNo);

#line default
#line hidden
            EndContext();
            BeginContext(5818, 41, true);
            WriteLiteral("</td>\r\n                              <td>");
            EndContext();
            BeginContext(5860, 9, false);
#line 128 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Organisation\Branch.cshtml"
                             Write(item.City);

#line default
#line hidden
            EndContext();
            BeginContext(5869, 295, true);
            WriteLiteral(@"</td>
                              <td class=""text-right"">
                                <span data-toggle=""modal"" data-target=""#noticeModal1""><a href=""#"" class=""btn btn-round btn-warning btn-icon btn-sm edit"" title=""Click to Edit"" data-toggle=""tooltip"" data-placement=""top"" id=""EditBranch""");
            EndContext();
            BeginWriteAttribute("BranchId", " BranchId=\"", 6164, "\"", 6183, 1);
#line 130 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Organisation\Branch.cshtml"
WriteAttributeValue("", 6175, item.Id, 6175, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("Selected-BranchName", " Selected-BranchName=\"", 6184, "\"", 6222, 1);
#line 130 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Organisation\Branch.cshtml"
WriteAttributeValue("", 6206, item.BranchName, 6206, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("Selected-eMail", " Selected-eMail=\"", 6223, "\"", 6251, 1);
#line 130 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Organisation\Branch.cshtml"
WriteAttributeValue("", 6240, item.Email, 6240, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("Selected-Phone", " Selected-Phone=\"", 6252, "\"", 6282, 1);
#line 130 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Organisation\Branch.cshtml"
WriteAttributeValue("", 6269, item.PhoneNo, 6269, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("Selected-City", " Selected-City=\"", 6283, "\"", 6309, 1);
#line 130 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Organisation\Branch.cshtml"
WriteAttributeValue("", 6299, item.City, 6299, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("Selected-Country", " Selected-Country=\"", 6310, "\"", 6342, 1);
#line 130 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Organisation\Branch.cshtml"
WriteAttributeValue("", 6329, item.Country, 6329, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6343, 84, true);
            WriteLiteral("><i class=\"far fa-edit\"></i></a></span>\r\n                                <a href=\"#\"");
            EndContext();
            BeginWriteAttribute("BranchId", " BranchId=\"", 6427, "\"", 6446, 1);
#line 131 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Organisation\Branch.cshtml"
WriteAttributeValue("", 6438, item.Id, 6438, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("BranchName", " BranchName=\"", 6447, "\"", 6476, 1);
#line 131 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Organisation\Branch.cshtml"
WriteAttributeValue("", 6460, item.BranchName, 6460, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6477, 158, true);
            WriteLiteral(" class=\"btn btn-round btn-danger btn-icon btn-sm remove\" title=\"Click to Delete\" data-toggle=\"tooltip\" data-placement=\"top\"><i class=\"fas fa-times\"></i></a>\r\n");
            EndContext();
            BeginContext(6975, 74, true);
            WriteLiteral("\r\n                              </td>\r\n                            </tr>\r\n");
            EndContext();
#line 136 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Organisation\Branch.cshtml"

                          }

#line default
#line hidden
            BeginContext(7080, 406, true);
            WriteLiteral(@"
                        </tbody>
                      </table>
                    </div>

                  </div>
                </div>

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
            DefineSection("Scripts", async() => {
                BeginContext(7504, 5476, true);
                WriteLiteral(@"

  <script>
    //Code for pulling the Records on the Table
      var aEditBranchId;

      $(document).delegate('#EditBranch',
        'click',
        function (e) {

          aEditBranchId = $(this).attr('BranchId');
          branchName = $(this).attr('Selected-BranchName');
          email = $(this).attr('Selected-eMail');
          phone = $(this).attr('Selected-Phone');
          city = $(this).attr('Selected-City');
          country = $(this).attr('Selected-Country');

          //console.log(description, department);


          $('input[name=ebranchid]').val(aEditBranchId);
          $('input[name=branchName]').val(branchName);
          $('input[name=eMail]').val(email);
          $('input[name=Phone]').val(phone);
          $('input[name=City]').val(city);
          $('input[name=Country]').val(country);

        });

      //End of the code


    //edit the branch
     $(document).ready(function () {

        $(""#editBranch"").click(function (event) {

     ");
                WriteLiteral(@"     event.preventDefault();

          var PostBranch = {
            AId: $(""#ebranchid"").val(),
            BranchName: $(""#branchName"").val(),
            Email: $(""#eMail"").val(),
            PhoneNo: $(""#Phone"").val(),
            City: $(""#City"").val(),
            Country: $(""#Country"").val(),

          };


          // console.log(Items);
          console.log(PostBranch);

          $.ajax({
            type: ""POST"",
            url: ""/Organisation/editBranch"",
            data: JSON.stringify(PostBranch),
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

              } ");
                WriteLiteral(@"else if (r.msg == ""No Data"") {
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













    //delete the branch
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

      //// Edit record
      //table.on('click', '");
                WriteLiteral(@".edit', function () {
      //  $tr = $(this).closest('tr');

      //  var data = table.row($tr).data();
      //  alert('You press on Row: ' + data[0] + ' ' + data[1] + ' ' + data[2] + '\'s row.');
      //});

      // Delete a record
      table.on('click', '.remove', function (e) {
        $tr = $(this).closest('tr');

        branchId = $(this).attr('BranchId');
        branchName = $(this).attr('BranchName');
        //eMail = $(this).attr('EMail');
        //phoneNo = $(this).attr('PhoneNo');
        //city = $(this).attr('city');



        swal({
          title: 'Are you sure?',
          text: ""You are about to delete '"" + branchName + ""'"",
          type: 'warning',
          showCancelButton: true,
          confirmButtonClass: 'btn btn-success',
          cancelButtonClass: 'btn btn-danger',
          confirmButtonText: 'Yes, delete it!',
          buttonsStyling: false
        }).then(function () {

          $.ajax({
            type: ""POST"",
            url: """);
                WriteLiteral(@"/Organisation/deleteBranch"",
            data: JSON.stringify(branchId),
            dataType: ""json"",
            contentType: 'application/json; charset=utf-8',
            headers: {
              RequestVerificationToken:
                $('input:hidden[name=""__RequestVerificationToken""]').val()
            },
            success: function (r) {

              if (r.msg == ""Success"") {

                swal({
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
            er");
                WriteLiteral(@"ror: function () {
              alert(r.msg);
            }
          });


          table.row($tr).remove().draw();

        }).catch(swal.noop);


        e.preventDefault();
      });

      //Like record
      table.on('click', '.like', function () {
        alert('You clicked on Like button');
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<E4S.Models.Branch>> Html { get; private set; }
    }
}
#pragma warning restore 1591