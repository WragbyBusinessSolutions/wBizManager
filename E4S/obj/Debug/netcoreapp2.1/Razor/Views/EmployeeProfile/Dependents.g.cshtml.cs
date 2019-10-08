#pragma checksum "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\Dependents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06dd9c40e77f7f3c6d3d069bb31a029d81bfe42c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EmployeeProfile_Dependents), @"mvc.1.0.view", @"/Views/EmployeeProfile/Dependents.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/EmployeeProfile/Dependents.cshtml", typeof(AspNetCore.Views_EmployeeProfile_Dependents))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06dd9c40e77f7f3c6d3d069bb31a029d81bfe42c", @"/Views/EmployeeProfile/Dependents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0d6bd66a948813bdfc09794c8b8e3a2f8caf788", @"/Views/_ViewImports.cshtml")]
    public class Views_EmployeeProfile_Dependents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<E4S.Models.HumanResource.Dependant>>
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
#line 3 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\Dependents.cshtml"
  
  ViewData["Title"] = "Dependents";

  Layout = "~/Views/Shared/_LayoutEmployee.cshtml";

#line default
#line hidden
            BeginContext(157, 279, true);
            WriteLiteral(@"
<div class=""content"">
  <div class=""card"">
    <div class=""card-header text-center"" data-background-color=""orange"">
      <h3 class=""card-title"">
        Dependents
      </h3>
      <h5 class=""description"">
        Fill information correctly.
      </h5>
    </div>
");
            EndContext();
            BeginContext(488, 1354, true);
            WriteLiteral(@"
    <div class=""row"">
      <div class=""col-md-12"">
        <div class=""card "">

            <div class=""card-body "">

                <!-- Start of the Emergency Contact tabs-->


                <div class=""card-header"">
                    <div class=""justify-content-end align-items-center "">
                        <button class=""btn  btn-info"" data-toggle=""modal"" data-target=""#noticeModal"">Create New</button>
                    </div>
                </div>
                <!-- notice modal -->
                <div class=""modal fade"" id=""noticeModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
                    <div class=""modal-dialog modal-notice"">
                        <div class=""modal-content"">
                            <div class=""modal-header"">
                                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">
                                    <i class=""now-ui-icons ui-1_simple-remove""></i>");
            WriteLiteral(@"
                                </button>
                                <h5 class=""modal-title"" id=""myModalLabel"">Enter New Dependents</h5>
                            </div>
                            <div class=""modal-body"">
                                <div class=""instruction"">
                                    ");
            EndContext();
            BeginContext(1842, 2277, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f59391f34324270aa080360c94e798d", async() => {
                BeginContext(1848, 2264, true);
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
                                                    <input id=""Relationship"" name=""Relationship"" type=""text"" class=""form-control"" placeholder=""Relationship"" requi");
                WriteLiteral(@"red>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""row"">
                                            <div class=""col-md-12"">
                                                <div class=""form-group"">
                                                    <label>Address</label>
                                                    <input id=""Address"" name=""Address"" type=""text"" class=""form-control"" placeholder=""Address"" required>
                                                </div>
                                            </div>
                                        </div>

                                        <hr />
                                        <div class=""card-footer "">
                                            <button type=""button"" class=""btn btn-fill btn-primary btn-round"" id=""submitDependent"" >Add Dependent</button>
  ");
                WriteLiteral("                                          <button type=\"button\" class=\"btn btn-info btn-round\" data-dismiss=\"modal\">Close</button>\r\n                                        </div>\r\n                                    ");
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
            BeginContext(4119, 1081, true);
            WriteLiteral(@"
                                </div>
                            </div>
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
                                <h5 class=""modal-title"" id=""myModalLabel"">Enter New Dependents</h5>
                            </div>
                            <div class=""modal-body"">
                                <div c");
            WriteLiteral("lass=\"instruction\">\r\n                                    ");
            EndContext();
            BeginContext(5200, 2429, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74558078e002483dbca8b9a94445f573", async() => {
                BeginContext(5206, 2416, true);
                WriteLiteral(@"
                                        <div class=""row"">
                                            <div class=""col-md-12"">
                                                <div class=""form-group"">
                                                    <label>Name</label>
                                                    <input id=""eName"" name=""eName"" type=""text"" class=""form-control"" placeholder=""Name"" required>
                                                    <input id=""edependt"" name=""edependt"" type=""hidden"" class=""form-control"" placeholder=""Name"" required>
                                                </div>
                                            </div>
                                        </div>

                                        <div class=""row"">
                                            <div class=""col-md-12"">
                                                <div class=""form-group"">
                                                    <label>Relationship</label>
      ");
                WriteLiteral(@"                                              <input id=""eRelationship"" name=""eRelationship"" type=""text"" class=""form-control"" placeholder=""Relationship"" required>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""row"">
                                            <div class=""col-md-12"">
                                                <div class=""form-group"">
                                                    <label>Address</label>
                                                    <input id=""eAddress"" name=""eAddress"" type=""text"" class=""form-control"" placeholder=""Address"" required>
                                                </div>
                                            </div>
                                        </div>

                                        <hr />
                                        <div class=""card-footer """);
                WriteLiteral(@">
                                            <button type=""button"" class=""btn btn-fill btn-primary btn-round"" id=""editDependents"" >Submit</button>
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
            BeginContext(7629, 753, true);
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- end notice modal -->
                <div class=""card-body"">
                    <br />
                    <table id=""datatable2"" class=""table table-striped "" cellspacing=""10"" width=""100%"">
                        <thead>
                            <tr>
                                <th> Name</th>
                                <th>Relationship</th>
                                <th>Address</th>
                                <th class=""disabled-sorting text-right"">Actions</th>
                            </tr>
                        </thead>
");
            EndContext();
            BeginContext(8685, 35, true);
            WriteLiteral("                        <tbody>\r\n\r\n");
            EndContext();
#line 159 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\Dependents.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(8809, 78, true);
            WriteLiteral("                                <tr>\r\n                                    <td>");
            EndContext();
            BeginContext(8888, 9, false);
#line 162 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\Dependents.cshtml"
                                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(8897, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(8945, 17, false);
#line 163 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\Dependents.cshtml"
                                   Write(item.Relationship);

#line default
#line hidden
            EndContext();
            BeginContext(8962, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(9010, 12, false);
#line 164 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\Dependents.cshtml"
                                   Write(item.Address);

#line default
#line hidden
            EndContext();
            BeginContext(9022, 304, true);
            WriteLiteral(@"</td>
                                    <td class=""text-right"">
                                      <span data-toggle=""modal"" data-target=""#noticeModal1""><a href=""#"" class=""btn btn-round btn-warning btn-icon btn-sm edit"" data-toggle=""tooltip"" data-placement=""top"" title=""Click to Edit"" id=""Editbtn""");
            EndContext();
            BeginWriteAttribute("DependentsId", " DependentsId=\"", 9326, "\"", 9349, 1);
#line 166 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\Dependents.cshtml"
WriteAttributeValue("", 9341, item.Id, 9341, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("Selected-Name", " Selected-Name=\"", 9350, "\"", 9376, 1);
#line 166 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\Dependents.cshtml"
WriteAttributeValue("", 9366, item.Name, 9366, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("Selected-Relationship", " Selected-Relationship=\"", 9377, "\"", 9419, 1);
#line 166 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\Dependents.cshtml"
WriteAttributeValue("", 9401, item.Relationship, 9401, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("Selected-Address", " Selected-Address=\"", 9420, "\"", 9452, 1);
#line 166 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\Dependents.cshtml"
WriteAttributeValue("", 9439, item.Address, 9439, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9453, 156, true);
            WriteLiteral("><i class=\"far fa-calendar-alt\"></i></a></span>\r\n                                        <a href=\"#\" class=\"btn btn-round btn-danger btn-icon btn-sm remove\"");
            EndContext();
            BeginWriteAttribute("DependentId", " DependentId=\"", 9609, "\"", 9631, 1);
#line 167 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\Dependents.cshtml"
WriteAttributeValue("", 9623, item.Id, 9623, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("DependentName", " DependentName=\"", 9632, "\"", 9658, 1);
#line 167 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\Dependents.cshtml"
WriteAttributeValue("", 9648, item.Name, 9648, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9659, 148, true);
            WriteLiteral(" title=\"Click to Delete\" data-toggle=\"tooltip\" data-placement=\"top\"><i class=\"fas fa-times\"></i></a>\r\n</td>\r\n                                </tr>\r\n");
            EndContext();
#line 170 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\Dependents.cshtml"

                            }

#line default
#line hidden
            BeginContext(9840, 235, true);
            WriteLiteral("\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n                <!-- the End of Emergency Contact Tabs-->\r\n            </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n  </div>\r\n</div>\r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(10093, 7001, true);
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

        dependentId = $(this).attr('DependentId');
        dependentName = $(this).attr('DependentName');


        swal({
          title: 'Are you sure?',
          text: ""You are about to delete '"" + dependentName + ""'"",
          type: 'warning',
          showCancelButton: true,
          confirmButto");
                WriteLiteral(@"nClass: 'btn btn-success',
          cancelButtonClass: 'btn btn-danger',
          confirmButtonText: 'Yes, delete it!',
          buttonsStyling: false
        }).then(function () {

          $.ajax({
            type: ""POST"",
            url: ""/EmployeeProfile/deleteDependent"",
            data: JSON.stringify(dependentId),
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

                alert(r.msg)");
                WriteLiteral(@";

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

        }).catch(swal.noop);


        e.preventDefault();
      });

      //Like record
      table.on('click', '.like', function () {
        alert('You clicked on Like button');
      });
    });
  </script>


  <script type=""text/javascript"">

    //$(document).ready(function() {
    //$('.form-group input').keyup(function() {

    //    var empty = false;
    //    $('.form-group input').each(function() {
    //        if ($(this).val().length == 0) {
    //            empty = true;
    //        }
    //    });

    //    if (empty) {
    //        $('.card-footer button').attr('disabled', ");
                WriteLiteral(@"'disabled');
    //    } else {
    //        $('.card-footer button').removeAttr('disabled');
    //    }
    //});
    //});



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

              demo.showSwal('succ");
                WriteLiteral(@"ess-message');

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
      });


    });


      //Code for pulling the Records on the Table  
        var eDependt;

         $(document).delegate('#Editbtn',
        'click',
        function (e) {

            eDependt = $(this).attr('DependentsId');
            name = $(this).attr('Selected-Name');
            relationship = $(this).attr('Selected-Relationship');
            address = $(this).attr('Selected-Address');
            
            //console.log(description, department);


            $('input[name=edependt]').val(eDependt);
            $('input[name=eName]').val(name);
            $('input[");
                WriteLiteral(@"name=eRelationship]').val(relationship);
            $('input[name=eAddress]').val(address);
            
        });

        //End of the code

      // Edit your post 

         $(document).ready(function () {

            $(""#editDependents"").click(function (event) {

                event.preventDefault();

                var PostEditDependents = { 
                    AId: $(""#edependt"").val(),
                    Name: $(""#eName"").val(),
                    Relationship: $(""#eRelationship"").val(),
                    Address: $(""#eAddress"").val(),
                };


                // console.log(Items);
                console.log(PostEditDependents);

                $.ajax({
                  type: ""POST"",
                  url: ""/EmployeeProfile/editDependents"",
                  data: JSON.stringify(PostEditDependents),
                  dataType: ""json"",
                  contentType: 'application/json; charset=utf-8',
                  headers: {
             ");
                WriteLiteral(@"         RequestVerificationToken:
                      $('input:hidden[name=""__RequestVerificationToken""]').val()
                  },
                  success: function (r) {

                    if (r.msg == ""Success"") {

                      demo.showSwal('success-message');

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
