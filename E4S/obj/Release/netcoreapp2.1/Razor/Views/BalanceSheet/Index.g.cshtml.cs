#pragma checksum "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\BalanceSheet\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce333a51cc4066496ae994e805b59f2c1663ff8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BalanceSheet_Index), @"mvc.1.0.view", @"/Views/BalanceSheet/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BalanceSheet/Index.cshtml", typeof(AspNetCore.Views_BalanceSheet_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce333a51cc4066496ae994e805b59f2c1663ff8f", @"/Views/BalanceSheet/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0d6bd66a948813bdfc09794c8b8e3a2f8caf788", @"/Views/_ViewImports.cshtml")]
    public class Views_BalanceSheet_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\BalanceSheet\Index.cshtml"
  
    ViewData["Title"] = "Balance Sheet";
    Layout = "~/Views/Shared/_LayoutAccountInventory.cshtml";

#line default
#line hidden
            BeginContext(114, 1732, true);
            WriteLiteral(@"

<style>
    .body-card {
        margin-left: 2%;
        margin-right: 2%;
        margin-top: 1%;
        margin-bottom: 2%;
    }

    .table-font {
        font-weight: 500;
    }

    .iconstyle {
        font-size: 25px;
        margin-top: 20px;
    }

    .picture {
        background: fixed;
    }

        .picture:hover {
            border-radius: 7px;
            box-shadow: 0 0 11px rgba(33,33,33,.2);
            padding: 10px;
        }

    .button-pad {
        margin-top: 20px;
    }

    .space {
        margin-top: 70px;
        margin-bottom: 40px;
    }
    .textspace{
        padding-top:;
        padding-left: 50px;
    }
</style>

<div class=""content"">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card card-stats card-raised"">
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col-md-4"">
                            <h4>Balance Sheet</h4>
  ");
            WriteLiteral(@"                      </div>

                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card card-stats card-raised"">
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col-md-3 textspace"">
                            <h4 class=""pull-right""> As of:</h4>
                        </div>
                        <div class=""col-md-3"">

                            <label class="""">Quarter</label>
                            <select class=""form-control"" style=""text-align: center;"">
                                ");
            EndContext();
            BeginContext(1846, 21, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1290400fd2c49d08f19fe7d6de4efc4", async() => {
                BeginContext(1854, 4, true);
                WriteLiteral("Full");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1867, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(1901, 19, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7577c165ad5e4adc8615b9f84f64127a", async() => {
                BeginContext(1909, 2, true);
                WriteLiteral("Q1");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1920, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(1954, 19, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5df304cb7d943a3bc68fd4e4d003469", async() => {
                BeginContext(1962, 2, true);
                WriteLiteral("Q2");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1973, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(2007, 19, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c253ff024f41451b87992330234f71fd", async() => {
                BeginContext(2015, 2, true);
                WriteLiteral("Q3");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2026, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(2060, 19, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b5da546b0654502a2445c4fcd39e994", async() => {
                BeginContext(2068, 2, true);
                WriteLiteral("Q4");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2079, 8401, true);
            WriteLiteral(@"
                            </select>

                        </div>


                        <div class=""col-md-3"">
                            <label>Date</label>
                            <input type=""date"" class=""form-control"" />
                        </div>

                        <div class=""col-md-3"">
                            <input type=""submit"" value=""Update Report"" class=""button-pad btn btn-info"" />

                        </div>



                        <div class=""col-md-3 space"">
                            <h6 style=""text-align:center;"">Cash and Bank</h6>
                            <h4 style=""text-align:center;"">₦ 0 <span class=""pull-right"">+</span></h4>
                        </div>
                        <div class=""col-md-3 space"">
                            <h6 style=""text-align:center;"">To be received</h6>
                            <h4 style=""text-align:center;"">₦ 0 <span class=""pull-right"">-</span></h4>
                        </div>

        ");
            WriteLiteral(@"                <div class=""col-md-3 space"">
                            <h6 style=""text-align:center;"">To be paid out</h6>
                            <h4 style=""text-align:center;"">₦ 0 <span class=""pull-right"">=</span> </h4>
                        </div>

                        <div class=""col-md-3 space"">
                            <h6 style=""text-align:center;""></h6>
                            <h4 style=""text-align:center;"">₦ 0</h4>

                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class=""content"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""card"">
                    <div class=""card-header body-card"">
                        <div class=""btn-group pull-right"">
                            <button type=""button"" class=""btn btn-success btn-round dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                       ");
            WriteLiteral(@"         Export Data
                            </button>
                            <div class=""dropdown-menu"">
                                <a class=""dropdown-item"" href=""#"">Copy</a>
                                <a class=""dropdown-item"" href=""#"">CSV</a>
                                <a class=""dropdown-item"" href=""#"">Excel</a>
                                <a class=""dropdown-item"" href=""#"">PDF</a>
                                <a class=""dropdown-item"" href=""#"">Print</a>

                            </div>
                        </div>



                        <h4 class=""card-title""></h4>
                    </div>
                    <div class=""card-body body-card"">

                        <div class=""table-responsive-sm"">
                            <table class=""table table-hover"">
                                <thead>
                                    <tr>
                                        <th><strong>Account</strong></th>
                               ");
            WriteLiteral(@"         <th style=""text-align:right;""><strong>July 23, 2019</strong></th>


                                    </tr>
                                </thead>
                                <tbody class=""fontweight"">

                                    <tr>
                                        <td class=""table-font""><strong>Assets</strong></td>
                                        <td style=""text-align:right;""></td>


                                    </tr>

                                    <tr>
                                        <td class=""table-font"">Cash and Bank</td>
                                        <td style=""text-align:right;""></td>


                                    </tr>

                                    <tr>
                                        <td>Total Cash and Bank</td>
                                        <td style=""text-align:right;"">#0.00</td>

                                    </tr>
                                    <tr>
    ");
            WriteLiteral(@"                                    <td>Other Current Assets</td>
                                        <td style=""text-align:right;""></td>

                                    </tr>

                                    <tr>
                                        <td>Total Other Current Assets</td>
                                        <td style=""text-align:right;"">#0.00</td>

                                    </tr>


                                    <tr>
                                        <td>Long-Term Assets</td>
                                        <td style=""text-align:right;""></td>

                                    </tr>
                                    <tr>
                                        <td>Total Long-Term Assets</td>
                                        <td style=""text-align:right;"">#0.00</td>

                                    </tr>
                                    <tr>
                                        <td><strong>Total Assets</st");
            WriteLiteral(@"rong></td>
                                        <td style=""text-align:right;"">#0.00</td>


                                    </tr>
                                </tbody>

                                <thead>
                                    <tr>
                                        <th><strong>Liability</strong></th>
                                        <th style=""text-align:right;""></th>


                                    </tr>
                                </thead>
                                <tbody class=""fontweight"">
                                    <tr>
                                        <td class=""table-font"">Current Liability</td>
                                        <td style=""text-align:right;""></td>


                                    </tr>
                                    <tr>
                                        <td>Total Current Liability</td>
                                        <td style=""text-align:right;"">#0.00</td>

");
            WriteLiteral(@"
                                    </tr>
                                    <tr>
                                        <td>Long-term Liability</td>
                                        <td style=""text-align:right;""></td>


                                    </tr>
                                    <tr>
                                        <td>Total Long-term Liability</td>
                                        <td style=""text-align:right;"">#0.00</td>


                                    </tr>
                                    <tr>
                                        <td><strong>Total Liability</strong></td>
                                        <td style=""text-align:right;"">#0.00</td>


                                    </tr>
                                </tbody>
                                
                                <thead>
                                    <tr>
                                        <th><strong>Equity</strong></th>
         ");
            WriteLiteral(@"                               <th style=""text-align:right;""></th>


                                    </tr>
                                </thead>
                                <tbody class=""fontweight"">
                                    <tr>
                                        <td class=""table-font"">Retained Earning</td>
                                        <td style=""text-align:right;""></td>


                                    </tr>
                                    <tr>
                                        <td>Total Retained Earning</td>
                                        <td style=""text-align:right;"">#0.00</td>


                                    </tr>
                                    <tr>
                                        <td><strong>Total Equity</strong></td>
                                        <td style=""text-align:right;"">#00.00</td>


                                    </tr>
                                    

                   ");
            WriteLiteral("             </tbody>\r\n\r\n                            </table>\r\n                        </div>\r\n\r\n\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>");
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
