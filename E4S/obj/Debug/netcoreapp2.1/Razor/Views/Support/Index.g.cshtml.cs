#pragma checksum "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Support\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0ae21fee509a6cbf5532979deee5838e268c15d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Support_Index), @"mvc.1.0.view", @"/Views/Support/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Support/Index.cshtml", typeof(AspNetCore.Views_Support_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0ae21fee509a6cbf5532979deee5838e268c15d", @"/Views/Support/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0d6bd66a948813bdfc09794c8b8e3a2f8caf788", @"/Views/_ViewImports.cshtml")]
    public class Views_Support_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<E4S.Models.WragbyAdmin.Ticket>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Low", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Medium", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "High", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Urgent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewTicket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-icon btn-sm  btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString(" View Details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("tooltip"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-placement", new global::Microsoft.AspNetCore.Html.HtmlString("top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Support\Index.cshtml"
  
    ViewData["Title"] = "Support";
    Layout = "~/Views/Shared/_LayoutNew.cshtml";

#line default
#line hidden
            BeginContext(146, 855, true);
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

    .button-custom {
        width: 100px;
    }
</style>

<div class=""content"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""card"">
                <div class=""card-header body-card"">
                    <div class=""row"">
                        <div class=""col-md-10"">
                            <div class=""card-title"">
                                <h4 class=""card-title"">Support</h4>
                            </div>
                        </div>
                    </div>

                            <div class=""col-md-2 pull-right"">
                                <div class=""row"">
");
            EndContext();
            BeginContext(1148, 125, true);
            WriteLiteral("                                    <button class=\"btn btn-info pull-right\" data-toggle=\"modal\" data-target=\"#noticeModal\">\r\n");
            EndContext();
            BeginContext(1410, 1329, true);
            WriteLiteral(@"                                        <span class=""btn-label"">
                                            <i class=""now-ui-icons travel_info""></i>
                                        </span>
                                        Create Ticket
                                    </button>
                                </div>


                            </div>
                       
                   
                </div>

                <!-- notice modal -->
                <div class=""modal fade"" id=""noticeModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
                    <div class=""modal-dialog modal-notice"">
                        <div class=""modal-content"">
                            <div class=""modal-header"">
                                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">
                                    <i class=""now-ui-icons ui-1_simple-remove""></i>
                            ");
            WriteLiteral(@"    </button>
                                <h5 class=""modal-title"" id=""myModalLabel"">Enter New Ticket Details</h5>
                            </div>
                            <div class=""modal-body"">
                                <div class=""instruction"">
                                    ");
            EndContext();
            BeginContext(2739, 5149, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7631f0b229248708f70c44b6e610a34", async() => {
                BeginContext(2745, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
                BeginContext(3332, 1639, true);
                WriteLiteral(@"                                        <div class=""row"">
                                            <div class=""col-md-12"">
                                                <div class=""form-group"">
                                                    <label>Title</label>
                                                    <input type=""text"" class=""form-control"" placeholder=""Enter Title"" id=""Title"" required>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""row"">
                                            <div class=""col-md-12"">
                                                <div class=""form-group"">
                                                    <label>Description</label>
                                                    <textarea class=""form-control"" placeholder=""Enter Description"" id=""Description"" required></textarea>
                ");
                WriteLiteral(@"                                </div>
                                            </div>
                                        </div>



                                        <div class=""row"">
                                            <div class=""col-md-12"">
                                                <div class=""form-group"">
                                                    <label>Severity</label>
                                                    <select class=""form-control"" placeholder=""Serial Number"" id=""Severity"" required>
                                                        ");
                EndContext();
                BeginContext(4971, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5edf70534cf4e528b48684a7bebbf52", async() => {
                    BeginContext(4988, 25, true);
                    WriteLiteral(" --- Select Severity --- ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5022, 58, true);
                WriteLiteral("\r\n                                                        ");
                EndContext();
                BeginContext(5080, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7426587f23c842ef9192e1095abb8ae1", async() => {
                    BeginContext(5100, 13, true);
                    WriteLiteral(" --- Low --- ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5122, 58, true);
                WriteLiteral("\r\n                                                        ");
                EndContext();
                BeginContext(5180, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbd3d68d621041cbb53da8fb28ba3f54", async() => {
                    BeginContext(5203, 16, true);
                    WriteLiteral(" --- Medium --- ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5228, 58, true);
                WriteLiteral("\r\n                                                        ");
                EndContext();
                BeginContext(5286, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4289a97511d40dd95a1084ddc0bc22d", async() => {
                    BeginContext(5307, 14, true);
                    WriteLiteral(" --- High --- ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5330, 58, true);
                WriteLiteral("\r\n                                                        ");
                EndContext();
                BeginContext(5388, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e204f42316864eeabbbbeefd3ffb71c5", async() => {
                    BeginContext(5411, 16, true);
                    WriteLiteral(" --- Urgent --- ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5436, 223, true);
                WriteLiteral("\r\n                                                    </select>\r\n                                                </div>\r\n                                            </div>\r\n                                        </div>\r\n\r\n");
                EndContext();
                BeginContext(6802, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(7394, 487, true);
                WriteLiteral(@"


                                        <hr />
                                        <div class=""card-footer "">
                                            <button type=""submit"" class=""btn btn-fill btn-primary btn-round"" id=""SubmitNewTicket"">Submit</button>
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
            BeginContext(7888, 78, true);
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n");
            EndContext();
            BeginContext(8222, 1278, true);
            WriteLiteral(@"                        </div>
                    </div>
                </div>
                <!-- end notice modal -->









                <div class=""card-body body-card"">
                    <div class=""row"">
                        <div class=""col-lg-12"">
                            <div class=""table-responsive"" style=""overflow:auto;"">
                                <table id=""datatable2"" class=""table table-striped"">
                                    <thead>
                                        <tr>
                                            <th><strong>Title</strong></th>
                                            <th><strong>Date</strong></th>
                                            <th><strong>TicketID</strong></th>
                                            <th><strong>Description</strong></th>
                                            <th><strong>Severity Level</strong></th>
                                            <th><strong>Status</strong></th>
 ");
            WriteLiteral("                                           <th class=\"pull-right\"><strong>Actions</strong></th>\r\n                                        </tr>\r\n                                    </thead>\r\n                                    <tbody class=\"fontweight\">\r\n");
            EndContext();
#line 179 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Support\Index.cshtml"
                                          
                                            //int i = 1;


                                            

#line default
#line hidden
#line 183 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Support\Index.cshtml"
                                             foreach (var item in Model)
                                            {





#line default
#line hidden
            BeginContext(9735, 129, true);
            WriteLiteral("                                                <tr>\r\n                                                    <td class=\"table-font\">");
            EndContext();
            BeginContext(9865, 10, false);
#line 190 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Support\Index.cshtml"
                                                                      Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(9875, 63, true);
            WriteLiteral("</td>\r\n                                                    <td>");
            EndContext();
            BeginContext(9939, 27, false);
#line 191 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Support\Index.cshtml"
                                                   Write(item.DateCreated.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(9966, 63, true);
            WriteLiteral("</td>\r\n                                                    <td>");
            EndContext();
            BeginContext(10030, 14, false);
#line 192 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Support\Index.cshtml"
                                                   Write(item.SupportId);

#line default
#line hidden
            EndContext();
            BeginContext(10044, 63, true);
            WriteLiteral("</td>\r\n                                                    <td>");
            EndContext();
            BeginContext(10108, 16, false);
#line 193 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Support\Index.cshtml"
                                                   Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(10124, 63, true);
            WriteLiteral("</td>\r\n                                                    <td>");
            EndContext();
            BeginContext(10188, 13, false);
#line 194 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Support\Index.cshtml"
                                                   Write(item.Severity);

#line default
#line hidden
            EndContext();
            BeginContext(10201, 63, true);
            WriteLiteral("</td>\r\n                                                    <td>");
            EndContext();
            BeginContext(10265, 11, false);
#line 195 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Support\Index.cshtml"
                                                   Write(item.Status);

#line default
#line hidden
            EndContext();
            BeginContext(10276, 145, true);
            WriteLiteral("</td>\r\n\r\n\r\n                                                    <td class=\"text-center\">\r\n                                                        ");
            EndContext();
            BeginContext(10421, 183, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ea5e0b04039433a8b0c805be49a0b31", async() => {
                BeginContext(10575, 25, true);
                WriteLiteral("<i class=\"fa fa-eye\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 199 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Support\Index.cshtml"
                                                                                     WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(10604, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(10690, 114, true);
            WriteLiteral("                                                    </td>\r\n                                                </tr>\r\n");
            EndContext();
#line 203 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Support\Index.cshtml"



                                            }

#line default
#line hidden
            BeginContext(10900, 278, true);
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
                BeginContext(11196, 5413, true);
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

                userId = $(this).attr('UserId');
                userName = $(this).attr('UserName');


    ");
                WriteLiteral(@"            swal({
                    title: 'Are you sure?',
                    text: ""You are about to delete '"" + userName + ""'"",
                    type: 'warning',
                    showCancelButton: true,
                    confirmButtonClass: 'btn btn-success',
                    cancelButtonClass: 'btn btn-danger',
                    confirmButtonText: 'Yes, delete it!',
                    buttonsStyling: false
                }).then(function () {

                    $.ajax({
                        type: ""POST"",
                        url: ""/Jobs/deleteUser"",
                        data: JSON.stringify(userId),
                        dataType: ""json"",
                        contentType: 'application/json; charset=utf-8',
                        headers: {
                            RequestVerificationToken:
                                $('input:hidden[name=""__RequestVerificationToken""]').val()
                        },
                        success: function");
                WriteLiteral(@" (r) {

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
                            alert(r.msg);");
                WriteLiteral(@"
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


        $(document).ready(function () {


            $(""#SubmitNewTicket"").click(function (event) {

                event.preventDefault();

                var Ticket = {
                    //SupportID: $(""#SupportID"").val(),
                    Title: $(""#Title"").val(),
                    Description: $(""#Description"").val(),
                    Severity: $(""#Severity"").val(),
                    //Status: $(""#Status"").val(),
                    //ImageUrl: $(""#ImageUrl"").val(),

                };


                // console.log(Items);
                cons");
                WriteLiteral(@"ole.log(Ticket);
                console.log(typeof (JSON.stringify(Ticket)));

                $.ajax({
                    type: ""POST"",
                    url: ""/Support/NewTicket"",
                    data: JSON.stringify(Ticket),
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
    ");
                WriteLiteral(@"                    //alert(r.msg);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<E4S.Models.WragbyAdmin.Ticket>> Html { get; private set; }
    }
}
#pragma warning restore 1591
