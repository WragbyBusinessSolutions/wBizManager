#pragma checksum "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\EmergencyContacts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76e8591fbfeac4139ee15be6d87691cb50d8ee24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EmployeeProfile_EmergencyContacts), @"mvc.1.0.view", @"/Views/EmployeeProfile/EmergencyContacts.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/EmployeeProfile/EmergencyContacts.cshtml", typeof(AspNetCore.Views_EmployeeProfile_EmergencyContacts))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76e8591fbfeac4139ee15be6d87691cb50d8ee24", @"/Views/EmployeeProfile/EmergencyContacts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0d6bd66a948813bdfc09794c8b8e3a2f8caf788", @"/Views/_ViewImports.cshtml")]
    public class Views_EmployeeProfile_EmergencyContacts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<E4S.Models.HumanResource.EmergencyContact>>
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
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\EmergencyContacts.cshtml"
  
  ViewData["Title"] = "Emergency Contacts";
  Layout = "~/Views/Shared/_LayoutEmployee.cshtml";


#line default
#line hidden
            BeginContext(172, 295, true);
            WriteLiteral(@"
<div class=""content"">
  <div class=""card"">
    <div class=""card-header text-center"" data-background-color=""orange"">
      <h3 class=""card-title"">
        Emergency Contact
      </h3>
      <h5 class=""description"">
        Information here are very important.
      </h5>
    </div>
");
            EndContext();
            BeginContext(519, 1274, true);
            WriteLiteral(@"
    <div class=""row"">
      <div class=""col-md-12"">
        <div class=""card "">

          <div class=""card-body "">

            <!-- Start of the Emergency Contact tabs-->

            <div class=""card-body"">
              <div class=""card-header"">
                <div class=""justify-content-end align-items-center "">
                  <button class=""btn btn-info"" data-toggle=""modal"" data-target=""#noticeModal"">Add New Contact</button>
                </div>
              </div>
              <!-- notice modal -->
              <div class=""modal fade"" id=""noticeModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
                <div class=""modal-dialog modal-notice"">
                  <div class=""modal-content"">
                    <div class=""modal-header"">
                      <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">
                        <i class=""now-ui-icons ui-1_simple-remove""></i>
                      </butt");
            WriteLiteral("on>\r\n                      <h5 class=\"modal-title\" id=\"myModalLabel\">Enter New Emergency Contact</h5>\r\n                    </div>\r\n                    <div class=\"modal-body\">\r\n                      <div class=\"instruction\">\r\n                        ");
            EndContext();
            BeginContext(1793, 2261, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec3e37a1fe834ca089265645bcc5179b", async() => {
                BeginContext(1799, 2068, true);
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
                                <input type=""text"" class=""form-control"" id=""Relationship"" name=""Relationship"" placeholder=""Home Relationship"" required>
                              </div>
                            </div>
                          </div>
                          <div class=""row"">
                            <div class=""col-md-12"">
       ");
                WriteLiteral(@"                       <div class=""form-group"">
                                <label>Home Telephone</label>
                                <input id=""HomeTelephone"" name=""HomeTelephone"" type=""text"" class=""form-control"" placeholder=""Home Telephone"" required>
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
                            <button type=""submit"" class=""btn btn-fill btn-primary btn-round"" id=""submitEmergenc");
                WriteLiteral("y\">Submit</button>\r\n");
                EndContext();
                BeginContext(3989, 58, true);
                WriteLiteral("                          </div>\r\n                        ");
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
            BeginContext(4054, 953, true);
            WriteLiteral(@"
                      </div>
                    </div>
                  </div>
                </div>
              </div>
              <!-- end notice modal -->
              <!-- notice modal -->
              <div class=""modal fade"" id=""noticeModal1"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
                <div class=""modal-dialog modal-notice"">
                  <div class=""modal-content"">
                    <div class=""modal-header"">
                      <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">
                        <i class=""now-ui-icons ui-1_simple-remove""></i>
                      </button>
                      <h5 class=""modal-title"" id=""myModalLabel""> Edit Emergency Contact Details</h5>
                    </div>
                    <div class=""modal-body"">
                      <div class=""instruction"">
                        ");
            EndContext();
            BeginContext(5007, 2387, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94f37c7b39634499ba2dd0888d35265f", async() => {
                BeginContext(5013, 2374, true);
                WriteLiteral(@"
                          <div class=""row"">
                            <div class=""col-md-12"">
                              <div class=""form-group"">
                                <label>Name</label>
                                <input id=""eName"" name=""eName"" type=""text"" class=""form-control"" placeholder=""Name"" required>
                                <input id=""eemergCon"" name=""eemergCon"" type=""hidden"" class=""form-control"" required>
                              </div>
                            </div>
                          </div>

                          <div class=""row"">
                            <div class=""col-md-12"">
                              <div class=""form-group"">
                                <label>Relationship</label>
                                <input type=""text"" class=""form-control"" id=""eRelationship"" name=""eRelationship"" placeholder=""Home Relationship"" required>
                              </div>
                            </div>
                  ");
                WriteLiteral(@"        </div>
                          <div class=""row"">
                            <div class=""col-md-12"">
                              <div class=""form-group"">
                                <label>Home Telephone</label>
                                <input id=""eHomeTelephone"" name=""eHomeTelephone"" type=""text"" class=""form-control"" placeholder=""Home Telephone"" required>
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
                          <div class=""ca");
                WriteLiteral(@"rd-footer "">
                            <button type=""submit"" class=""btn btn-fill btn-primary btn-round"" id=""editEmergencyContact"">Submit</button>
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
            BeginContext(7394, 690, true);
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
                      <th>Home Telephone</th>
                      <th>Address</th>
                      <th class=""disabled-sorting text-right"">Actions</th>
                    </tr>
                  </thead>
");
            EndContext();
            BeginContext(8458, 29, true);
            WriteLiteral("                  <tbody>\r\n\r\n");
            EndContext();
#line 177 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\EmergencyContacts.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(8560, 56, true);
            WriteLiteral("                      <tr>\r\n                        <td>");
            EndContext();
            BeginContext(8617, 9, false);
#line 180 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\EmergencyContacts.cshtml"
                       Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(8626, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(8662, 17, false);
#line 181 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\EmergencyContacts.cshtml"
                       Write(item.Relationship);

#line default
#line hidden
            EndContext();
            BeginContext(8679, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(8715, 18, false);
#line 182 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\EmergencyContacts.cshtml"
                       Write(item.HomeTelephone);

#line default
#line hidden
            EndContext();
            BeginContext(8733, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(8769, 12, false);
#line 183 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\EmergencyContacts.cshtml"
                       Write(item.Address);

#line default
#line hidden
            EndContext();
            BeginContext(8781, 258, true);
            WriteLiteral(@"</td>
                        <td class=""text-right"">
                          <span data-toggle=""modal"" data-target=""#noticeModal1""><a href=""#"" class=""btn btn-round btn-warning btn-icon btn-sm edit"" data-toggle=""tooltip"" data-placement=""top"" id=""Editbtn""");
            EndContext();
            BeginWriteAttribute("EmergencyContactId", " EmergencyContactId=\"", 9039, "\"", 9068, 1);
#line 185 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\EmergencyContacts.cshtml"
WriteAttributeValue("", 9060, item.Id, 9060, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("Selected-Name", " Selected-Name=\"", 9069, "\"", 9095, 1);
#line 185 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\EmergencyContacts.cshtml"
WriteAttributeValue("", 9085, item.Name, 9085, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("Selected-Relationship", " Selected-Relationship=\"", 9096, "\"", 9138, 1);
#line 185 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\EmergencyContacts.cshtml"
WriteAttributeValue("", 9120, item.Relationship, 9120, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("Selected-HomeTelephone", " Selected-HomeTelephone=\"", 9139, "\"", 9183, 1);
#line 185 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\EmergencyContacts.cshtml"
WriteAttributeValue("", 9164, item.HomeTelephone, 9164, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("Selected-Address", " Selected-Address=\"", 9184, "\"", 9216, 1);
#line 185 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\EmergencyContacts.cshtml"
WriteAttributeValue("", 9203, item.Address, 9203, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9217, 144, true);
            WriteLiteral("><i class=\"far fa-calendar-alt\"></i></a></span>\r\n                            <a href=\"#\" class=\"btn btn-round btn-danger btn-icon btn-sm remove\"");
            EndContext();
            BeginWriteAttribute("EmergencyContactId", " EmergencyContactId=\"", 9361, "\"", 9390, 1);
#line 186 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\EmergencyContacts.cshtml"
WriteAttributeValue("", 9382, item.Id, 9382, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("EmergencyContactName", " EmergencyContactName=\"", 9391, "\"", 9424, 1);
#line 186 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\EmergencyContacts.cshtml"
WriteAttributeValue("", 9414, item.Name, 9414, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9425, 162, true);
            WriteLiteral(" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Click to Delete\"><i class=\"fas fa-times\"></i></a>\r\n                        </td>\r\n                      </tr>\r\n");
            EndContext();
#line 189 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\EmergencyContacts.cshtml"

                    }

#line default
#line hidden
            BeginContext(9612, 235, true);
            WriteLiteral("\r\n                  </tbody>\r\n                </table>\r\n              </div>\r\n            </div>\r\n            <!-- the End of Emergency Contact Tabs-->\r\n\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n  </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(9865, 6951, true);
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

        emergencyContactId = $(this).attr('EmergencyContactId');
        emergencyContactName = $(this).attr('EmergencyContactName');




        swal({
          title: 'Are you sure?',
          text: ""You are about to delete '"" + emergencyContactName + ""'"",
          type: 'warning',
          showCa");
                WriteLiteral(@"ncelButton: true,
          confirmButtonClass: 'btn btn-success',
          cancelButtonClass: 'btn btn-danger',
          confirmButtonText: 'Yes, delete it!',
          buttonsStyling: false
        }).then(function () {

          $.ajax({
            type: ""POST"",
            url: ""/EmployeeProfile/deleteEmergencyContact"",
            data: JSON.stringify(emergencyContactId),
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


              } else");
                WriteLiteral(@" if (r.msg == ""Fail"") {

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
    //  $('.EmCon form-group input').keyup(function() {

    //      var empty = false;
    //      $('.EmCon form-group input').each(function() {
    //          if ($(this).val().length == 0) {
    //              empty = true;
    //          }
    //      });
");
                WriteLiteral(@"
    //      if (empty) {
    //          $('.card-footer button').attr('disabled', 'disabled');
    //      } else {
    //          $('.card-footer button').removeAttr('disabled');
    //      }
    //  });
    //});

    $(document).ready(function () {

      $(""#submitEmergency"").click(function (event) {

        event.preventDefault();

        var PostEmergencyContact = {
          Name: $(""#Name"").val(),
          Relationship: $(""#Relationship"").val(),
          HomeTelephone: $(""#HomeTelephone"").val(),
          Address: $(""#Address"").val(),
        };


        // console.log(Items);
        console.log(PostEmergencyContact);

        $.ajax({
          type: ""POST"",
          url: ""/EmployeeProfile/PostEmergencyContact"",
          data: JSON.stringify(PostEmergencyContact),
          dataType: ""json"",
          contentType: 'application/json; charset=utf-8',
          headers: {
            RequestVerificationToken:
              $('input:hidden[name=""__RequestVerif");
                WriteLiteral(@"icationToken""]').val()
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

    //Code for pulling the Records on the Table
    var eEmergCon;

    $(document).delegate('#Editbtn',
      'click',
      function (e) {

        eEmergCon = $(this).attr('EmergencyContactId');
        name = $(this).attr('Selected-Name');
        relationship = $(this).attr('Selected-Relationship');
        hometelephone = $(this).attr('Selected-HomeTelephone');
        address = $(this).attr('Selected-Address');

    ");
                WriteLiteral(@"    //console.log(description, department);


        $('input[name=eemergCon]').val(eEmergCon);
        $('input[name=eName]').val(name);
        $('input[name=eRelationship]').val(relationship);
        $('input[name=eHomeTelephone]').val(hometelephone);
        $('input[name=eAddress]').val(address);

      });

    //End of the code

    // Edit your post

    $(document).ready(function () {

      $(""#editEmergencyContact"").click(function (event) {

        event.preventDefault();

        var PostEditEmergencyContact = {
          AId: $(""#eemergCon"").val(),
          Name: $(""#eName"").val(),
          Relationship: $(""#eRelationship"").val(),
          HomeTelephone: $(""#eHomeTelephone"").val(),
          Address: $(""#eAddress"").val(),
        };


        // console.log(Items);
        console.log(PostEditEmergencyContact);

        $.ajax({
          type: ""POST"",
          url: ""/EmployeeProfile/editEmergencyContact"",
          data: JSON.stringify(PostEditEmergency");
                WriteLiteral(@"Contact),
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<E4S.Models.HumanResource.EmergencyContact>> Html { get; private set; }
    }
}
#pragma warning restore 1591
