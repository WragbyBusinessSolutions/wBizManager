#pragma checksum "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Jobs\JobTitle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d555592700abb3632f478c10c317b8949e050fb5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Jobs_JobTitle), @"mvc.1.0.view", @"/Views/Jobs/JobTitle.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Jobs/JobTitle.cshtml", typeof(AspNetCore.Views_Jobs_JobTitle))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d555592700abb3632f478c10c317b8949e050fb5", @"/Views/Jobs/JobTitle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0d6bd66a948813bdfc09794c8b8e3a2f8caf788", @"/Views/_ViewImports.cshtml")]
    public class Views_Jobs_JobTitle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<E4S.Models.HumanResource.JobTitle>>
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
#line 2 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Jobs\JobTitle.cshtml"
  
  ViewData["Title"] = "Job Title";
  Layout = "~/Views/Shared/_LayoutHumanResouces.cshtml";

#line default
#line hidden
            BeginContext(156, 1111, true);
            WriteLiteral(@"

<div class=""content"">
  <div class=""row"">
    <div class=""col-md-12"">
      <div class=""card"">
        <div class=""card-header"">
          <button class=""btn btn-info"" data-toggle=""modal"" data-target=""#noticeModal"">
            Add Job Title
          </button>
          <!-- notice modal -->
          <div class=""modal fade"" id=""noticeModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
            <div class=""modal-dialog modal-notice"">
              <div class=""modal-content"">
                <div class=""modal-header"">
                  <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">
                    <i class=""now-ui-icons ui-1_simple-remove""></i>
                  </button>
                  <h5 class=""modal-title"" id=""myModalLabel"">Enter New Job Title</h5>
                </div>
                <div id=""loading-overlay"">
                  <div class=""loading-icon""></div>
                </div>

                <div");
            WriteLiteral(" class=\"modal-body\">\r\n                  <div class=\"instruction\">\r\n                    ");
            EndContext();
            BeginContext(1267, 1696, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6b6dce8125542c8b9aeb714f34c6055", async() => {
                BeginContext(1273, 413, true);
                WriteLiteral(@"
                      <div class=""row"">
                        <div class=""col-md-12"">
                          <div class=""form-group"">
                            <label>Job Title</label>
                            <input type=""text"" class=""form-control"" placeholder=""Job Title"" id=""JobTitle"" required>
                          </div>
                        </div>
                      </div>

");
                EndContext();
                BeginContext(2577, 379, true);
                WriteLiteral(@"


                      <hr />
                      <div class=""card-footer "">
                        <button type=""submit"" class=""btn btn-fill btn-primary btn-round"" id=""SubmitNewJobTitle"">Submit</button>
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
            BeginContext(2963, 28, true);
            WriteLiteral("\r\n                  </div>\r\n");
            EndContext();
            BeginContext(3131, 959, true);
            WriteLiteral(@"                </div>
              </div>
            </div>
          </div>
          <!-- end notice modal -->
          <!-- notice Edit modal -->
          <div class=""modal fade"" id=""noticeModal1"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
            <div class=""modal-dialog modal-notice"">
              <div class=""modal-content"">
                <div class=""modal-header"">
                  <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">
                    <i class=""now-ui-icons ui-1_simple-remove""></i>
                  </button>
                  <h5 class=""modal-title"" id=""myModalLabel"">Edit Job Title</h5>
                </div>
                <div id=""loading-overlay"">
                  <div class=""loading-icon""></div>
                </div>

                <div class=""modal-body"">
                  <div class=""instruction"">
                    ");
            EndContext();
            BeginContext(4090, 1832, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ab4ec80ae214bdeadad66bcdfed5e41", async() => {
                BeginContext(4096, 554, true);
                WriteLiteral(@"
                      <div class=""row"">
                        <div class=""col-md-12"">
                          <div class=""form-group"">
                            <label>Job Title</label>
                            <input type=""text"" class=""form-control"" placeholder=""Job Title"" id=""eJobTitle"" name=""eJobTitle"" required>
                            <input type=""hidden"" class=""form-control"" placeholder=""deptid"" id=""ejobsTid"" name=""ejobsTid"">
                          </div>
                        </div>
                      </div>

");
                EndContext();
                BeginContext(5541, 374, true);
                WriteLiteral(@"


                      <hr />
                      <div class=""card-footer "">
                        <button type=""submit"" class=""btn btn-fill btn-primary btn-round"" id=""editJobTitle"">Submit</button>
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
            BeginContext(5922, 28, true);
            WriteLiteral("\r\n                  </div>\r\n");
            EndContext();
            BeginContext(6090, 121, true);
            WriteLiteral("                </div>\r\n              </div>\r\n            </div>\r\n          </div>\r\n          <!-- end notice modal -->\r\n");
            EndContext();
            BeginContext(6300, 590, true);
            WriteLiteral(@"        </div>

        <div class=""card-body"">
          <div class=""table"" >
            <table id=""datatable2"" class=""table table-striped"" cellspacing=""10"" width=""100%"">
              <thead class=""text-primary"">
                <tr>
                  <th class=""text-center"">
                    #
                  </th>
                  <th>
                    Job Title
                  </th>
                  <th class=""text-center"">
                    Actions
                  </th>

                </tr>
              </thead>

              <tbody>

");
            EndContext();
#line 156 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Jobs\JobTitle.cshtml"
                  
                  int i = 1;

                  

#line default
#line hidden
#line 159 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Jobs\JobTitle.cshtml"
                   if (Model.Count() < 1)
                  {

#line default
#line hidden
            BeginContext(7006, 194, true);
            WriteLiteral("                    <tr>\r\n                      <td></td>\r\n                      <td>No Data to Display</td>\r\n                      <td></td>\r\n                      \r\n                    </tr>\r\n");
            EndContext();
#line 167 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Jobs\JobTitle.cshtml"

                  }

#line default
#line hidden
#line 170 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Jobs\JobTitle.cshtml"
                   foreach (var item in Model)
                  {


#line default
#line hidden
            BeginContext(7296, 98, true);
            WriteLiteral("                    <tr>\r\n                      <td class=\"text-center\">\r\n                        ");
            EndContext();
            BeginContext(7395, 1, false);
#line 175 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Jobs\JobTitle.cshtml"
                   Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(7396, 85, true);
            WriteLiteral("\r\n                      </td>\r\n\r\n                      <td>\r\n                        ");
            EndContext();
            BeginContext(7482, 17, false);
#line 179 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Jobs\JobTitle.cshtml"
                   Write(item.JobTitleName);

#line default
#line hidden
            EndContext();
            BeginContext(7499, 304, true);
            WriteLiteral(@"
                      </td>

                      <td class=""text-center"" >
                        <span data-toggle=""modal"" data-target=""#noticeModal1""><a href=""#"" class=""btn btn-round btn-warning btn-icon btn-sm edit"" title=""Click to Edit"" data-toggle=""tooltip"" data-placement=""top"" id=""Editbtn""");
            EndContext();
            BeginWriteAttribute("TitleId", " TitleId=\"", 7803, "\"", 7821, 1);
#line 183 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Jobs\JobTitle.cshtml"
WriteAttributeValue("", 7813, item.Id, 7813, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("Selected-JobTitle", " Selected-JobTitle=\"", 7822, "\"", 7860, 1);
#line 183 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Jobs\JobTitle.cshtml"
WriteAttributeValue("", 7842, item.JobTitleName, 7842, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7861, 198, true);
            WriteLiteral("><i class=\"fa fa-edit\"></i></a></span>\r\n                        <a href=\"#\" class=\"btn btn-round btn-danger btn-icon btn-sm remove\" title=\"Click to Delete\" data-toggle=\"tooltip\" data-placement=\"top\"");
            EndContext();
            BeginWriteAttribute("JobId", "  JobId=\"", 8059, "\"", 8076, 1);
#line 184 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Jobs\JobTitle.cshtml"
WriteAttributeValue("", 8068, item.Id, 8068, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("JobTitle", " JobTitle=\"", 8077, "\"", 8106, 1);
#line 184 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Jobs\JobTitle.cshtml"
WriteAttributeValue("", 8088, item.JobTitleName, 8088, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8107, 91, true);
            WriteLiteral("><i class=\"fas fa-times\"></i></a>\r\n                      </td>\r\n                    </tr>\r\n");
            EndContext();
#line 187 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Jobs\JobTitle.cshtml"

                    { i = i + 1; }
                  }

#line default
#line hidden
            BeginContext(8276, 136, true);
            WriteLiteral("\r\n              </tbody>\r\n            </table>\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n\r\n  </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(8430, 6448, true);
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
                  titl");
                WriteLiteral(@"e: 'Are you sure?',
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
                WriteLiteral(@"                swal({
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

            ");
                WriteLiteral(@"  }).catch(swal.noop);


              e.preventDefault();
          });

          //Like record
          table.on('click', '.like', function () {
              alert('You clicked on Like button');
          });
      });
  </script>



  <script type=""text/javascript"">


    $(""#SubmitNewJobTitle"").click(function (event) {

      event.preventDefault();

      $(""#loading-overlay"").show();

      var JobTitle = {
        JobTitle: $(""#JobTitle"").val(),
        Description: $(""#Description"").val(),
        Note: $(""#Note"").val(),
      };


      // console.log(Items);
      console.log(JobTitle);

      $.ajax({
        type: ""POST"",
        url: ""/Jobs/postNewJobTitle"",
        data: JSON.stringify(JobTitle),
        dataType: ""json"",
        contentType: 'application/json; charset=utf-8',
        headers: {
          RequestVerificationToken:
            $('input:hidden[name=""__RequestVerificationToken""]').val()
        },
        success: function (r) {

   ");
                WriteLiteral(@"       if (r.msg == ""Success"") {
            $(""#loading-overlay"").hide();
            demo.showSwal('success-message');

          } else if (r.msg == ""Fail"") {
            $(""#loading-overlay"").hide();
            alert(r.msg);

          } else if (r.msg == ""No Data"") {
            $(""#loading-overlay"").hide();
            alert(r.msg);

          } else {
            $(""#loading-overlay"").hide();
            alert(r.msg);
          }
          //alert(r.msg);
          // window.location.reload();

        },
        error: function () {
          $(""#loading-overlay"").hide();
          alert(r.msg);
        }
      });
    });
    //});

    //Code for pulling the Records on the Table
    var eTitleId;

    $(document).delegate('#Editbtn', 'click', function (e) {

      eTitleId = $(this).attr('TitleId');
      jobTitle = $(this).attr('Selected-JobTitle');

      //console.log(description, department);

      $('input[name=ejobsTid]').val(eTitleId);
      $('input[n");
                WriteLiteral(@"ame=eJobTitle]').val(jobTitle);

    });

    //End of the code

    $(document).ready(function () {

      $(""#editJobTitle"").click(function (event) {

        event.preventDefault();

        var PostJobTitle = {
          AId: $(""#ejobsTid"").val(),
          JobTitle: $(""#eJobTitle"").val(),

        };


        // console.log(Items);
        console.log(PostJobTitle);

        $.ajax({
          type: ""POST"",
          url: ""/Jobs/editJobTitle"",
          data: JSON.stringify(PostJobTitle),
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

            } else if (r.msg == ""No Data"") {
          ");
                WriteLiteral(@"    alert(r.msg);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<E4S.Models.HumanResource.JobTitle>> Html { get; private set; }
    }
}
#pragma warning restore 1591
