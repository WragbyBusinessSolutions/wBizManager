#pragma checksum "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\UpdateOrganizationDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7b31f34226a570815c0727feceee8355240e5e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_UpdateOrganizationDetails), @"mvc.1.0.view", @"/Views/Admin/UpdateOrganizationDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/UpdateOrganizationDetails.cshtml", typeof(AspNetCore.Views_Admin_UpdateOrganizationDetails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7b31f34226a570815c0727feceee8355240e5e4", @"/Views/Admin/UpdateOrganizationDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0d6bd66a948813bdfc09794c8b8e3a2f8caf788", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_UpdateOrganizationDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BizManager.ViewModel.ViewOrganisationDetails>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateOrganizationDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("tooltip"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("View Details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\UpdateOrganizationDetails.cshtml"
  
    ViewData["Title"] = "Update Organization Details";
    Layout = "~/Views/Shared/_LayoutWragbyAdmin.cshtml";

#line default
#line hidden
            BeginContext(177, 1075, true);
            WriteLiteral(@"



<div class=""content"">
    <div class=""col-md-10 "">
        <!--      Wizard container -->
        <div class=""wizard-container"">
            <div class=""card "">

                <!--        You can switch "" data-color=""primary"" ""  with one of the next bright colors: ""green"", ""orange"", ""red"", ""blue""       -->
                <div class=""card-header text-center"" data-background-color=""orange"">
                    <h3 class=""card-title"">
                    </h3>
                    <h5 class=""description"">Update Organization Information</h5>

                    <input hidden />
                </div>
                <div class=""card-body"">
                    <div class=""tab-content"">
                        <div class=""col-md-12"">

                            <div class=""card-body "">
                                <div class=""row"">
                                    <div class=""col-md-3"" style=""background-color:white"">
                                        <div class=""col-sm-1");
            WriteLiteral("2\">\r\n\r\n                                            ");
            EndContext();
            BeginContext(1252, 1261, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5642e3e2a792475bad75d32fc16da199", async() => {
                BeginContext(1272, 376, true);
                WriteLiteral(@"
                                                <h5 class=""description"">Organisation Logo</h5>

                                                <div class=""fileinput fileinput-new text-center"" data-provides=""fileinput"">
                                                    <div class=""fileinput-new thumbnail"">
                                                        <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1648, "\"", 1682, 1);
#line 39 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\UpdateOrganizationDetails.cshtml"
WriteAttributeValue("", 1654, Model.Organisation.ImageUrl, 1654, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1683, 823, true);
                WriteLiteral(@" id=""imageUploadForm"" name=""image"" multiple=""multiple"" alt=""..."">
                                                    </div>

                                                    <div>

                                                        <a href=""#pablo"" class=""btn btn-danger btn-round fileinput-exists"" data-dismiss=""fileinput""><i class=""fa fa-times""></i> Remove</a>
                                                    </div>
                                                    <div class=""form-group"">
                                                        <button type=""submit"" class=""btn btn-success btn-md fileinput-exists"">Upload</button>
                                                    </div>

                                                </div>

                                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2513, 2140, true);
            WriteLiteral(@"


                                        </div>
                                        <ul class=""nav nav-pills nav-pills-primary flex-column"" role=""tablist"">
                                            <li class=""nav-item"">
                                                <a class=""nav-link active"" data-toggle=""tab"" href=""#link4"" role=""tablist"">
                                                    Organisations
                                                </a>
                                            </li>
                                            <li class=""nav-item"">
                                                <a class=""nav-link"" data-toggle=""tab"" href=""#link5"" role=""tablist"">
                                                    Users
                                                </a>
                                            </li>
                                            <li class=""nav-item"">
                                                <a class=""nav-link"" data-toggle");
            WriteLiteral(@"=""tab"" href=""#link6"" role=""tablist"">
                                                    Options
                                                </a>
                                            </li>


                                        </ul>

                                    </div>
                                    <div class=""col-md-8"">
                                        <div class=""tab-content"">
                                            <div class=""tab-pane active"" id=""link4"">

                                                <div class=""row justify-content-center"">
                                                    <h5 class=""info-text""> Update organization basic information (with validation)</h5>
                                                    <div class=""col-sm-8"">
                                                        <label class=""col-md-9 col-form-label"">Registration No</label>
                                                        <div class=""input-group form-");
            WriteLiteral("control-lg\">\r\n                                                            <input type=\"text\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4653, "\"", 4695, 1);
#line 86 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\UpdateOrganizationDetails.cshtml"
WriteAttributeValue("", 4661, Model.Organisation.RegistrationNo, 4661, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4696, 432, true);
            WriteLiteral(@" readonly class=""form-control"" placeholder=""E.g 123454 (required)"">
                                                        </div>
                                                        <label class=""col-md-9 col-form-label"">Organisation Name</label>
                                                        <div class=""input-group form-control-lg"">
                                                            <input type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 5128, "\"", 5172, 1);
#line 90 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\UpdateOrganizationDetails.cshtml"
WriteAttributeValue("", 5136, Model.Organisation.OrganisationName, 5136, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5173, 453, true);
            WriteLiteral(@" readonly placeholder=""Wragby Business Solutions (required)"" class=""form-control"" />
                                                        </div>
                                                        <label class=""col-md-9 col-form-label"">Phone Number</label>
                                                        <div class=""input-group form-control-lg"">
                                                            <input type=""text"" readonly");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 5626, "\"", 5665, 1);
#line 94 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\UpdateOrganizationDetails.cshtml"
WriteAttributeValue("", 5634, Model.Organisation.PhoneNumber, 5634, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5666, 423, true);
            WriteLiteral(@" placeholder=""08137422773 (required)"" class=""form-control"" />
                                                        </div>
                                                        <label class=""col-md-9 col-form-label"">Email</label>
                                                        <div class=""input-group form-control-lg"">
                                                            <input type=""text"" readonly");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 6089, "\"", 6122, 1);
#line 98 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\UpdateOrganizationDetails.cshtml"
WriteAttributeValue("", 6097, Model.Organisation.Email, 6097, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6123, 443, true);
            WriteLiteral(@" placeholder=""Eadewuyi@wragbysolutions.com (required)"" class=""form-control"" />
                                                        </div>
                                                        <label class=""col-md-9 col-form-label"">Zip Code</label>
                                                        <div class=""input-group form-control-lg"">
                                                            <input type=""text"" readonly");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 6566, "\"", 6601, 1);
#line 102 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\UpdateOrganizationDetails.cshtml"
WriteAttributeValue("", 6574, Model.Organisation.ZipCode, 6574, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6602, 419, true);
            WriteLiteral(@" placeholder=""100242 (required)"" class=""form-control"" />
                                                        </div>
                                                        <label class=""col-md-9 col-form-label"">Tax ID</label>
                                                        <div class=""input-group form-control-lg"">
                                                            <input type=""text"" readonly");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 7021, "\"", 7054, 1);
#line 106 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\UpdateOrganizationDetails.cshtml"
WriteAttributeValue("", 7029, Model.Organisation.TaxId, 7029, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7055, 431, true);
            WriteLiteral(@" placeholder=""F002E (required)"" class=""form-control"" />
                                                        </div>
                                                        <label class=""col-md-9 col-form-label"">Organisation Prefix</label>
                                                        <div class=""input-group form-control-lg"">
                                                            <input type=""text"" readonly");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 7486, "\"", 7532, 1);
#line 110 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\UpdateOrganizationDetails.cshtml"
WriteAttributeValue("", 7494, Model.Organisation.OrganisationPrefix, 7494, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7533, 417, true);
            WriteLiteral(@" placeholder=""WBS (required)"" class=""form-control"" />
                                                        </div>
                                                        <label class=""col-md-9 col-form-label"">Address</label>
                                                        <div class=""input-group form-control-lg"">
                                                            <input type=""text"" readonly");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 7950, "\"", 7985, 1);
#line 114 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\UpdateOrganizationDetails.cshtml"
WriteAttributeValue("", 7958, Model.Organisation.Address, 7958, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7986, 125, true);
            WriteLiteral(" placeholder=\"Last Name (required)\" class=\"form-control\" />\r\n                                                        </div>\r\n");
            EndContext();
            BeginContext(9389, 2008, true);
            WriteLiteral(@"                                                        <div class=""form-group"">
                                                            <a class=""btn btn-fill btn-success"" style=""color: #fff;"">Activate</a>
                                                            <a class=""btn btn-fill btn-primary"" style=""color: #fff;"">Deactivate</a>

                                                        </div>
                                                    </div>
                                                </div>

                                            </div>
                                            <div class=""tab-pane"" id=""link5"">

                                                <div class=""table-responsive col-md-12"" style=""overflow:auto;"">
                                                    <table id=""datatable2"" class=""table table-striped"" cellspacing=""10"" width=""100%"">
                                                        <thead>
                                                ");
            WriteLiteral(@"            <tr>
                                                                <th class=""text-center""><strong>S/N</strong></th>
                                                                <th scope=""col""><strong>User Name</strong></th>
                                                                <th scope=""col"" class=""text-center""><strong>Role </strong></th>
                                                                <th scope=""col"" class=""text-center""><strong>Email  </strong></th>
                                                                <th scope=""col"" class=""text-center""><strong>Status</strong></th>
                                                                <th scope=""col"" class=""text-center""><strong>Actions</strong></th>
                                                            </tr>
                                                        </thead>
                                                        <tbody class=""fontweight"">
");
            EndContext();
#line 154 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\UpdateOrganizationDetails.cshtml"
                                                              
                                                                int i = 1;

                                                                

#line default
#line hidden
#line 157 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\UpdateOrganizationDetails.cshtml"
                                                                 if (Model.applicationUsers.Count() < 1)
                                                                {

#line default
#line hidden
            BeginContext(11712, 426, true);
            WriteLiteral(@"                                                                    <tr>
                                                                        <td></td>
                                                                        <td>No Organisation to Display</td>
                                                                        <td></td>

                                                                    </tr>
");
            EndContext();
#line 165 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\UpdateOrganizationDetails.cshtml"

                                                                }

#line default
#line hidden
#line 168 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\UpdateOrganizationDetails.cshtml"
                                                                 foreach (var item in Model.applicationUsers)
                                                                {


#line default
#line hidden
            BeginContext(12389, 271, true);
            WriteLiteral(@"                                                                    <tr>
                                                                        <td scope=""row"" class=""table-font text-center"">
                                                                            ");
            EndContext();
            BeginContext(12661, 1, false);
#line 173 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\UpdateOrganizationDetails.cshtml"
                                                                       Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(12662, 171, true);
            WriteLiteral("\r\n                                                                        </td>\r\n\r\n                                                                        <td scope=\"row\">");
            EndContext();
            BeginContext(12834, 4, false);
#line 176 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\UpdateOrganizationDetails.cshtml"
                                                                                   Write(item);

#line default
#line hidden
            EndContext();
            BeginContext(12838, 115, true);
            WriteLiteral("</td>\r\n                                                                        <td scope=\"row\" class=\"text-center\">");
            EndContext();
            BeginContext(12954, 14, false);
#line 177 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\UpdateOrganizationDetails.cshtml"
                                                                                                       Write(item.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(12968, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(12970, 15, false);
#line 177 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\UpdateOrganizationDetails.cshtml"
                                                                                                                       Write(item.MiddleName);

#line default
#line hidden
            EndContext();
            BeginContext(12985, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(12987, 13, false);
#line 177 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\UpdateOrganizationDetails.cshtml"
                                                                                                                                        Write(item.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(13000, 115, true);
            WriteLiteral("</td>\r\n                                                                        <td scope=\"row\" class=\"text-center\">");
            EndContext();
            BeginContext(13116, 13, false);
#line 178 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\UpdateOrganizationDetails.cshtml"
                                                                                                       Write(item.UserRole);

#line default
#line hidden
            EndContext();
            BeginContext(13129, 115, true);
            WriteLiteral("</td>\r\n                                                                        <td scope=\"row\" class=\"text-center\">");
            EndContext();
            BeginContext(13245, 10, false);
#line 179 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\UpdateOrganizationDetails.cshtml"
                                                                                                       Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(13255, 333, true);
            WriteLiteral(@"</td>
                                                                        <td scope=""row"" class=""text-center""> <button class=""btn btn-success"">Active</button></td>
                                                                        <td class="""">
                                                                            ");
            EndContext();
            BeginContext(13588, 170, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b96566d9d1c048d086b79a8ef4bad01d", async() => {
                BeginContext(13729, 25, true);
                WriteLiteral("<i class=\"fa fa-eye\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(13758, 156, true);
            WriteLiteral("\r\n                                                                        </td>\r\n                                                                    </tr>\r\n");
            EndContext();
#line 185 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\UpdateOrganizationDetails.cshtml"

                                                                    { i = i + 1; }
                                                                }

#line default
#line hidden
            BeginContext(14130, 687, true);
            WriteLiteral(@"

                                                        </tbody>
                                                    </table>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""tab-pane"" id=""link6"">
                                            
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
            BeginContext(14842, 79, true);
            WriteLiteral("        </div>\r\n    </div>\r\n    <!-- wizard container -->\r\n</div>\r\n    \r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(14939, 3472, true);
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


  ");
                WriteLiteral(@"              swal({
                    title: 'Are you sure?',
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
                        success: fun");
                WriteLiteral(@"ction (r) {

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
                            alert(r.");
                WriteLiteral(@"msg);
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
            BeginContext(18414, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BizManager.ViewModel.ViewOrganisationDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
