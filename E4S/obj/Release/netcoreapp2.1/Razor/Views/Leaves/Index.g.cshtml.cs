#pragma checksum "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Leaves\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b34838548e62473220f7265a9210482e3cebce19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Leaves_Index), @"mvc.1.0.view", @"/Views/Leaves/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Leaves/Index.cshtml", typeof(AspNetCore.Views_Leaves_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b34838548e62473220f7265a9210482e3cebce19", @"/Views/Leaves/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0d6bd66a948813bdfc09794c8b8e3a2f8caf788", @"/Views/_ViewImports.cshtml")]
    public class Views_Leaves_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<E4S.Models.HumanResource.Leave>>
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
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Leaves\Index.cshtml"
  
  ViewData["Title"] = "Leaves";
  Layout = "~/Views/Shared/_LayoutHumanResouces.cshtml";

#line default
#line hidden
            BeginContext(152, 27, true);
            WriteLiteral("\r\n<div class=\"content\">\r\n  ");
            EndContext();
            BeginContext(180, 79, false);
#line 9 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Leaves\Index.cshtml"
Write(Html.Partial("~/Views/Manage/_StatusMessage.cshtml", ViewData["StatusMessage"]));

#line default
#line hidden
            EndContext();
            BeginContext(259, 243, true);
            WriteLiteral("\r\n  <div class=\"row\">\r\n    <!-- Column -->\r\n    <div class=\"container-fluid\">\r\n      <div class=\"content\">\r\n        <div class=\"row\">\r\n          <div class=\"col-md-12\">\r\n            <div class=\"card\">\r\n              <div class=\"card-header\">\r\n");
            EndContext();
            BeginContext(726, 810, true);
            WriteLiteral(@"                <!-- notice modal -->
                <div class=""modal fade"" id=""noticeModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
                  <div class=""modal-dialog modal-notice"">
                    <div class=""modal-content"">
                      <div class=""modal-header"">
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">
                          <i class=""now-ui-icons ui-1_simple-remove""></i>
                        </button>
                        <h5 class=""modal-title"" id=""myModalLabel"">Approve or Decline Leave Application</h5>
                      </div>
                      <div class=""modal-body"">
                        <div class=""instruction"">
                          ");
            EndContext();
            BeginContext(1536, 3446, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "facce88d5eef44b9bcb86c1ba4d86fb5", async() => {
                BeginContext(1542, 3247, true);
                WriteLiteral(@"
                            <input type=""hidden"" name=""Id"" id=""Id"" />
                            <div class=""row"">
                              <div class=""col-md-12"">
                                <div class=""form-group"">
                                  <label>Employee Name</label>
                                  <input type=""text"" class=""form-control"" placeholder=""Employee Name"" name=""modalEmployeeName"" id=""modalEmployeeName"" readonly>
                                </div>
                              </div>
                            </div>
                            <div class=""row"">
                              <div class=""col-md-12"">
                                <div class=""form-group"">
                                  <label>Leave</label>
                                  <input type=""text"" class=""form-control"" readonly placeholder=""Leave"" id=""Leave"" name=""Leave"" required>
                                </div>
                              </div>
                    ");
                WriteLiteral(@"        </div>
                            <div class=""row"">
                              <div class=""col-md-12"">
                                <div class=""form-group"">
                                  <label>Description</label>
                                  <input type=""text"" class=""form-control"" readonly placeholder=""Description"" id=""Description"" name=""Description"">
                                </div>
                              </div>
                            </div>
                            <div class=""row"">
                              <div class=""col-md-12"">
                                <div class=""form-group"">
                                  <label>Start Date</label>
                                  <input type=""text"" class=""form-control"" readonly name=""varstartDate"" id=""varstartDate"">
                                </div>
                              </div>
                            </div>
                            <div class=""row"">
                    ");
                WriteLiteral(@"          <div class=""col-md-12"">
                                <div class=""form-group"">
                                  <label>End Date</label>
                                  <input type=""text"" class=""form-control"" readonly name=""varendDate"" id=""varendDate"">
                                </div>
                              </div>
                            </div>
                            <div class=""row"">
                              <div class=""col-md-12"">
                                <div class=""form-group"">
                                  <label>HR Comment</label>
                                  <input type=""text"" class=""form-control"" required name=""varcomment"" id=""varcomment"">
                                </div>
                              </div>
                            </div>
                            <hr />
                            <div class=""card-footer "">
                              <button type=""submit"" class=""btn btn-fill btn-info btn-round"" i");
                WriteLiteral("d=\"btnApproveLeave\">Approve</button>\r\n                              <button type=\"submit\" class=\"btn btn-primary btn-primary btn-round\" id=\"btnDeclineLeave\">Decline</button>\r\n");
                EndContext();
                BeginContext(4913, 62, true);
                WriteLiteral("                            </div>\r\n                          ");
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
            BeginContext(4982, 34, true);
            WriteLiteral("\r\n                        </div>\r\n");
            EndContext();
            BeginContext(5162, 942, true);
            WriteLiteral(@"                      </div>
                    </div>
                  </div>
                </div>
                <!-- end notice modal -->


                <h4 class=""card-title"">List of Leave Application</h4>
              </div>
              <div class=""card-body"">
                <br />
                <table id=""datatable2"" class=""table table-striped table-bordered"" cellspacing=""0"" width=""100%"">
                  <thead>
                    <tr>
                      <th>Employee Name</th>
                      <th>Leave</th>
                      <th>Description</th>
                      <th>Start Date</th>
                      <th>End Date</th>
                      <th>Days</th>
                      <th>Approved Date</th>
                      <th>Status</th>
                      <th class=""disabled-sorting text-right"">Actions</th>
                    </tr>
                  </thead>
");
            EndContext();
            BeginContext(6611, 27, true);
            WriteLiteral("                  <tbody>\r\n");
            EndContext();
#line 130 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Leaves\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(6711, 56, true);
            WriteLiteral("                      <tr>\r\n                        <td>");
            EndContext();
            BeginContext(6768, 29, false);
#line 133 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Leaves\Index.cshtml"
                       Write(item.EmployeeDetail.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(6797, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(6799, 28, false);
#line 133 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Leaves\Index.cshtml"
                                                      Write(item.EmployeeDetail.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(6827, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(6863, 15, false);
#line 134 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Leaves\Index.cshtml"
                       Write(item.LeaveTitle);

#line default
#line hidden
            EndContext();
            BeginContext(6878, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(6914, 16, false);
#line 135 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Leaves\Index.cshtml"
                       Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(6930, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(6966, 40, false);
#line 136 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Leaves\Index.cshtml"
                       Write(item.StartDate.ToString("MMMM dd, yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(7006, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(7042, 38, false);
#line 137 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Leaves\Index.cshtml"
                       Write(item.EndDate.ToString("MMMM dd, yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(7080, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(7116, 19, false);
#line 138 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Leaves\Index.cshtml"
                       Write(item.CalculatedDays);

#line default
#line hidden
            EndContext();
            BeginContext(7135, 37, true);
            WriteLiteral("</td>\r\n                        <td>\r\n");
            EndContext();
#line 140 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Leaves\Index.cshtml"
                           if (item.Status == "Approved")
                          {
                            

#line default
#line hidden
            BeginContext(7289, 41, false);
#line 142 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Leaves\Index.cshtml"
                       Write(item.ApproveDate.ToString("MMM dd, yyyy"));

#line default
#line hidden
            EndContext();
#line 142 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Leaves\Index.cshtml"
                                                                      
                          }
                          else
                          {

#line default
#line hidden
            BeginContext(7422, 42, true);
            WriteLiteral("                            <p>-----</p>\r\n");
            EndContext();
#line 147 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Leaves\Index.cshtml"
                          }

#line default
#line hidden
            BeginContext(7493, 31, true);
            WriteLiteral("                        </td>\r\n");
            EndContext();
#line 149 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Leaves\Index.cshtml"
                         if (item.Status == "Pending")
                        {

#line default
#line hidden
            BeginContext(7607, 94, true);
            WriteLiteral("                          <td>\r\n                            <a class=\"btn btn-sm btn-warning\">");
            EndContext();
            BeginContext(7702, 11, false);
#line 152 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Leaves\Index.cshtml"
                                                         Write(item.Status);

#line default
#line hidden
            EndContext();
            BeginContext(7713, 301, true);
            WriteLiteral(@"</a>
                          </td>
                          <td class=""text-right"">
                            <span data-toggle=""modal"" data-target=""#noticeModal""><a href=""#"" class=""btn btn-round btn-warning btn-icon btn-sm "" title=""Click to Approve"" data-toggle=""tooltip"" data-placement=""top""");
            EndContext();
            BeginWriteAttribute("delLeaveId", " delLeaveId=\"", 8014, "\"", 8035, 1);
#line 155 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Leaves\Index.cshtml"
WriteAttributeValue("", 8027, item.Id, 8027, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("Select-EmployeeName", " Select-EmployeeName=\"", 8036, "\"", 8118, 2);
#line 155 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Leaves\Index.cshtml"
WriteAttributeValue("", 8058, item.EmployeeDetail.FirstName, 8058, 30, false);

#line default
#line hidden
#line 155 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Leaves\Index.cshtml"
WriteAttributeValue(" ", 8088, item.EmployeeDetail.LastName, 8089, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("Selected-Leave", " Selected-Leave=\"", 8119, "\"", 8152, 1);
#line 155 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Leaves\Index.cshtml"
WriteAttributeValue("", 8136, item.LeaveTitle, 8136, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("Selected-Description", " Selected-Description=\"", 8153, "\"", 8193, 1);
#line 155 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Leaves\Index.cshtml"
WriteAttributeValue("", 8176, item.Description, 8176, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("Selected-StartDate", " Selected-StartDate=\"", 8194, "\"", 8256, 1);
#line 155 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Leaves\Index.cshtml"
WriteAttributeValue("", 8215, item.StartDate.ToString("MMMM dd, yyyy"), 8215, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("Selected-EndDate", " Selected-EndDate=\"", 8257, "\"", 8315, 1);
#line 155 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Leaves\Index.cshtml"
WriteAttributeValue("", 8276, item.EndDate.ToString("MMMM dd, yyyy"), 8276, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8316, 58, true);
            WriteLiteral(" id=\"Approvebtn\"><i class=\"fa fa-edit\"></i></a></span>\r\n\r\n");
            EndContext();
            BeginContext(8900, 162, true);
            WriteLiteral("                            <a href=\"#\" class=\"btn btn-round btn-danger btn-icon btn-sm remove\" title=\"Click to Delete\" data-toggle=\"tooltip\" data-placement=\"top\"");
            EndContext();
            BeginWriteAttribute("LeaveId", " LeaveId=\"", 9062, "\"", 9080, 1);
#line 158 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Leaves\Index.cshtml"
WriteAttributeValue("", 9072, item.Id, 9072, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9081, 68, true);
            WriteLiteral("><i class=\"fas fa-times\"></i></a>\r\n                          </td>\r\n");
            EndContext();
#line 160 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Leaves\Index.cshtml"
                        }
                        else if (item.Status == "Approved")
                        {

#line default
#line hidden
            BeginContext(9264, 91, true);
            WriteLiteral("                          <td>\r\n                            <a class=\"btn btn-sm btn-info\">");
            EndContext();
            BeginContext(9356, 11, false);
#line 164 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Leaves\Index.cshtml"
                                                      Write(item.Status);

#line default
#line hidden
            EndContext();
            BeginContext(9367, 303, true);
            WriteLiteral(@"</a>
                          </td>
                          <td class=""text-right"">

                            <span data-toggle=""modal"" data-target=""#noticeModal""><a href=""#"" class=""btn btn-round btn-warning btn-icon btn-sm "" title=""Click to Approve"" data-toggle=""tooltip"" data-placement=""top""");
            EndContext();
            BeginWriteAttribute("delLeaveId", " delLeaveId=\"", 9670, "\"", 9691, 1);
#line 168 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Leaves\Index.cshtml"
WriteAttributeValue("", 9683, item.Id, 9683, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("Select-EmployeeName", " Select-EmployeeName=\"", 9692, "\"", 9774, 2);
#line 168 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Leaves\Index.cshtml"
WriteAttributeValue("", 9714, item.EmployeeDetail.FirstName, 9714, 30, false);

#line default
#line hidden
#line 168 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Leaves\Index.cshtml"
WriteAttributeValue(" ", 9744, item.EmployeeDetail.LastName, 9745, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("Selected-Leave", " Selected-Leave=\"", 9775, "\"", 9808, 1);
#line 168 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Leaves\Index.cshtml"
WriteAttributeValue("", 9792, item.LeaveTitle, 9792, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("Selected-Description", " Selected-Description=\"", 9809, "\"", 9849, 1);
#line 168 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Leaves\Index.cshtml"
WriteAttributeValue("", 9832, item.Description, 9832, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("Selected-StartDate", " Selected-StartDate=\"", 9850, "\"", 9912, 1);
#line 168 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Leaves\Index.cshtml"
WriteAttributeValue("", 9871, item.StartDate.ToString("MMMM dd, yyyy"), 9871, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("Selected-EndDate", " Selected-EndDate=\"", 9913, "\"", 9971, 1);
#line 168 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Leaves\Index.cshtml"
WriteAttributeValue("", 9932, item.EndDate.ToString("MMMM dd, yyyy"), 9932, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9972, 286, true);
            WriteLiteral(@" id=""Approvebtn""><i class=""fa fa-edit""></i></a></span>
                            <a href=""#"" class=""btn btn-round btn-danger btn-icon btn-sm remove"" title=""Click to Delete"" data-toggle=""tooltip"" data-placement=""top""><i class=""fas fa-times""></i></a>
                          </td>
");
            EndContext();
#line 171 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Leaves\Index.cshtml"
                        }
                        else if (item.Status == "Declined")
                        {

#line default
#line hidden
            BeginContext(10373, 93, true);
            WriteLiteral("                          <td>\r\n                            <a class=\"btn btn-sm btn-danger\">");
            EndContext();
            BeginContext(10467, 11, false);
#line 175 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Leaves\Index.cshtml"
                                                        Write(item.Status);

#line default
#line hidden
            EndContext();
            BeginContext(10478, 301, true);
            WriteLiteral(@"</a>
                          </td>
                          <td class=""text-right"">
                            <span data-toggle=""modal"" data-target=""#noticeModal""><a href=""#"" class=""btn btn-round btn-warning btn-icon btn-sm "" title=""Click to Approve"" data-toggle=""tooltip"" data-placement=""top""");
            EndContext();
            BeginWriteAttribute("delLeaveId", " delLeaveId=\"", 10779, "\"", 10800, 1);
#line 178 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Leaves\Index.cshtml"
WriteAttributeValue("", 10792, item.Id, 10792, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("Select-EmployeeName", " Select-EmployeeName=\"", 10801, "\"", 10883, 2);
#line 178 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Leaves\Index.cshtml"
WriteAttributeValue("", 10823, item.EmployeeDetail.FirstName, 10823, 30, false);

#line default
#line hidden
#line 178 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Leaves\Index.cshtml"
WriteAttributeValue(" ", 10853, item.EmployeeDetail.LastName, 10854, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("Selected-Leave", " Selected-Leave=\"", 10884, "\"", 10917, 1);
#line 178 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Leaves\Index.cshtml"
WriteAttributeValue("", 10901, item.LeaveTitle, 10901, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("Selected-Description", " Selected-Description=\"", 10918, "\"", 10958, 1);
#line 178 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Leaves\Index.cshtml"
WriteAttributeValue("", 10941, item.Description, 10941, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("Selected-StartDate", " Selected-StartDate=\"", 10959, "\"", 11021, 1);
#line 178 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Leaves\Index.cshtml"
WriteAttributeValue("", 10980, item.StartDate.ToString("MMMM dd, yyyy"), 10980, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("Selected-EndDate", " Selected-EndDate=\"", 11022, "\"", 11080, 1);
#line 178 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Leaves\Index.cshtml"
WriteAttributeValue("", 11041, item.EndDate.ToString("MMMM dd, yyyy"), 11041, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(11081, 286, true);
            WriteLiteral(@" id=""Approvebtn""><i class=""fa fa-edit""></i></a></span>
                            <a href=""#"" class=""btn btn-round btn-danger btn-icon btn-sm remove"" title=""Click to Delete"" data-toggle=""tooltip"" data-placement=""top""><i class=""fas fa-times""></i></a>
                          </td>
");
            EndContext();
#line 181 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Leaves\Index.cshtml"
                        }

                        

#line default
#line hidden
            BeginContext(12188, 29, true);
            WriteLiteral("                      </tr>\r\n");
            EndContext();
#line 188 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Leaves\Index.cshtml"

                    }

#line default
#line hidden
            BeginContext(12242, 314, true);
            WriteLiteral(@"
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
            DefineSection("Scripts", async() => {
                BeginContext(12574, 6929, true);
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

      // Edit record
      table.on('click', '.edit', function () {
        $tr = $(this).closest('tr');

        var data = table.row($tr).data();
        alert('You press on Row: ' + data[0] + ' ' + data[1] + ' ' + data[2] + '\'s row.');
      });

      // Delete a record
      table.on('click', '.remove', function (e) {
        $tr = $(this).closest('tr');

        leaveId = $(this).attr('LeaveId');
        employe");
                WriteLiteral(@"eDetailId = $(this).attr('employeeId');
        description = $(this).attr('Description');
        startDate = $(this).attr('StartDate');
        endDate = $(this).attr('EndDate');
        approvedDate = $(this).attr('ApprovedDate');
        comment = $(this).attr('Comment');


        swal({
          title: 'Are you sure?',
          text: ""You are about to delete '"" + employeeId + ""'"",
          type: 'warning',
          showCancelButton: true,
          confirmButtonClass: 'btn btn-success',
          cancelButtonClass: 'btn btn-danger',
          confirmButtonText: 'Yes, delete it!',
          buttonsStyling: false
        }).then(function () {

          $.ajax({
            type: ""POST"",
            url: ""/Leaves/deleteLeaves"",
            data: JSON.stringify(leaveId),
            dataType: ""json"",
            contentType: 'application/json; charset=utf-8',
            headers: {
              RequestVerificationToken:
                $('input:hidden[name=""__RequestVerifica");
                WriteLiteral(@"tionToken""]').val()
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
        alert(");
                WriteLiteral(@"'You clicked on Like button');
      });
    });
  </script>



  <script>
    var delLeaveId;

    $(document).delegate('#Approvebtn',
      'click',
      function (e) {

        delLeaveId = $(this).attr('delLeaveId');
        varemployeeName = $(this).attr('select-employeename');
        leave = $(this).attr('Selected-Leave');
        description = $(this).attr('Selected-Description');
        varstartDate = $(this).attr('Selected-StartDate');
        varendDate = $(this).attr('Selected-EndDate');

        console.log(varstartDate, varendDate);


        $('input[name=Id]').val(delLeaveId);
        $('input[name=modalEmployeeName]').val(varemployeeName);
        $('input[name=Leave]').val(leave);
        $('input[name=Description]').val(description);
        $('input[name=varstartDate]').val(varstartDate);
        $('input[name=varendDate]').val(varendDate);

      });

    $(document).ready(function () {

      $(""#btnApproveLeave"").click(function (event) {

        e");
                WriteLiteral(@"vent.preventDefault();

        var PostApproveLeave = {
          Id: $(""#Id"").val(),
          Comment: $(""#varcomment"").val(),
        };


        // console.log(Items);
        console.log(PostApproveLeave);

        $.ajax({
          type: ""POST"",
          url: ""/Leaves/ApproveLeave"",
          data: JSON.stringify(PostApproveLeave),
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

       ");
                WriteLiteral(@"   },
          error: function () {
            alert(r.msg);
          }
        });
      });

      $(""#btnDeclineLeave"").click(function (event) {

        event.preventDefault();

        var PostApproveLeave = {
          Id: $(""#Id"").val(),
          Comment: $(""#varcomment"").val(),
        };


        // console.log(Items);
        console.log(PostApproveLeave);

        $.ajax({
          type: ""POST"",
          url: ""/Leaves/DeclineLeave"",
          data: JSON.stringify(PostApproveLeave),
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
                WriteLiteral(@"       alert(r.msg);

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

    $(document).delegate('#btn-yes',
      'click',
      function (e) {
        var data = {
          accountId: delLeaveId
        };
        //$.ajax({
        //  url: '/controller/action',
        //  type: 'POST',
        //  data: data,
        //  success: function (returnvalue) {
        //    //what you want on success
        //  },
        //  error: function (error) {
        //    //what you want on error
        //  }
        //});
      });

  </script>


");
                EndContext();
            }
            );
            BeginContext(19506, 8, true);
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<E4S.Models.HumanResource.Leave>> Html { get; private set; }
    }
}
#pragma warning restore 1591
