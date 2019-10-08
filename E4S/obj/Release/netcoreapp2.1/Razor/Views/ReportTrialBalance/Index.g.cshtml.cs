#pragma checksum "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\ReportTrialBalance\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f267737a302e8535fb9a50e8198e56def281c291"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ReportTrialBalance_Index), @"mvc.1.0.view", @"/Views/ReportTrialBalance/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ReportTrialBalance/Index.cshtml", typeof(AspNetCore.Views_ReportTrialBalance_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f267737a302e8535fb9a50e8198e56def281c291", @"/Views/ReportTrialBalance/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0d6bd66a948813bdfc09794c8b8e3a2f8caf788", @"/Views/_ViewImports.cshtml")]
    public class Views_ReportTrialBalance_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\ReportTrialBalance\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutAccountInventory.cshtml";

#line default
#line hidden
            BeginContext(106, 8313, true);
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

    .textspace {
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
                            <h4>Trail Balances</h4>");
            WriteLiteral(@"
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
                                Export Data
                            </button>
                            <div class=""dropdown-menu"">
                                <a class=""dropdown-item"" href=""#"">Copy</a>
                                <a class=""dropdown-item"" href=""#"">CSV</a>
                                <a class=""dropdown-item"" href=""#"">Excel</a>
                                <a class=""dropdown-item"" href=""#"">PDF</a>
                            ");
            WriteLiteral(@"    <a class=""dropdown-item"" href=""#"">Print</a>

                            </div>
                        </div>



                        <h4 class=""card-title""></h4>
                    </div>
                    <div class=""card-body body-card"">

                        <div class=""row"">

                            <div class=""col-md-4"">

                                <h4 class=""pull-right"">As of:</h4>

                            </div>

                            <div class=""col-md-4"">
                                <label> Date</label>
                                <input type=""date"" class=""form-control"" />
                            </div>





                            <div class=""col-md-4"">
                                <input type=""submit"" value=""Update Report"" class=""button-pad btn btn-info"" />

                            </div>

                        </div>
                        <hr />
                        
                        <div cla");
            WriteLiteral(@"ss=""table-responsive-sm"">
                            <table class=""table table-hover"">

                                <thead>
                                    <tr>
                                        <th><strong>ACCOUNT</strong></th>
                                        <th style=""text-align:right;""><strong>DEBIT</strong></th>
                                        <th style=""text-align:right;""><strong>CREDIT</strong></th>
                                    </tr>
                                </thead>
                                <tbody class=""fontweight"">

                                    <tr>
                                        <td class=""table-font""><strong>Assets</strong></td>
                                        <td style=""text-align:right;""></td>
                                        <td style=""text-align:right;""></td>
                                       
                                    </tr>


                                    <tr>
         ");
            WriteLiteral(@"                               <td><strong>Total Assets</strong></td>
                                        <td style=""text-align:right;"">NGN0.00</td>
                                        <td style=""text-align:right;"">NGN0.00</td>
                                        
                                    </tr>
                                </tbody>

                                <thead>
                                    <tr>
                                        <th><strong>Liabilities</strong></th>
                                        <th style=""text-align:right;""></th>
                                    </tr>
                                </thead>
                                <tbody class=""fontweight"">

                                    <tr>
                                        <td><strong>Total Liabilities</strong></td>
                                        <td style=""text-align:right;"">NGN0.00</td>
                                        <td style=""text-ali");
            WriteLiteral(@"gn:right;"">NGN0.00</td>


                                    </tr>
                                </tbody>

                                <thead>
                                    <tr>
                                        <th><strong>Equity</strong></th>
                                        <th style=""text-align:right;""></th>
                                    </tr>
                                </thead>
                                <tbody class=""fontweight"">
                                    <tr>
                                        <td class=""table-font""><strong>Total Equity</strong></td>
                                        <td style=""text-align:right;"">NGN0.00</td>
                                        <td style=""text-align:right;"">NGN0.00</td>
                                    </tr>

                                </tbody>

                                <thead>
                                    <tr>
                                        <th><str");
            WriteLiteral(@"ong>Income</strong></th>
                                        <th></th>
                                        <th style=""text-align:right;""></th>


                                    </tr>

                                </thead>
                                <tbody>

                                    <tr>
                                        <td><strong>Total Income</strong></td>
                                        <td style=""text-align:right;"">NGN0.00</td>
                                        <td style=""text-align:right;"">NGN0.00</td>


                                    </tr>
                                </tbody>
                                <thead>
                                    <tr>
                                        <th><strong>Expenses</strong></th>
                                        <th></th>
                                        <th style=""text-align:right;""></th>
                                    </tr>

                         ");
            WriteLiteral(@"       </thead>
                                <tbody>

                                    <tr>
                                        <td><strong>Total Expenses</strong></td>
                                        <td style=""text-align:right;"">NGN0.00</td>
                                        <td style=""text-align:right;"">NGN0.00</td>

                                    </tr>
                                </tbody>
                                <tfoot>
                                    <tr>
                                        <td><strong>Total for all account</strong> <p></p></td>
                                        
                                        <td style=""text-align:right;"">NGN0.00</td>
                                        <td style=""text-align:right;"">NGN0.00</td>
                                       


                                    </tr>
                                </tfoot>
                            </table>
                        </d");
            WriteLiteral("iv>\r\n\r\n\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n");
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
