#pragma checksum "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmptyView\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97449a6c592c7f340986cf6903c47d35e8931d91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EmptyView_Index), @"mvc.1.0.view", @"/Views/EmptyView/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/EmptyView/Index.cshtml", typeof(AspNetCore.Views_EmptyView_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97449a6c592c7f340986cf6903c47d35e8931d91", @"/Views/EmptyView/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0d6bd66a948813bdfc09794c8b8e3a2f8caf788", @"/Views/_ViewImports.cshtml")]
    public class Views_EmptyView_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("print"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-outline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "InvoiceDone", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "Model.Id", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmptyView\Index.cshtml"
  
    ViewData["Title"] = "Index";
     Layout = "~/Views/Shared/_LayoutAccountInventoryEmpty.cshtml";

#line default
#line hidden
            BeginContext(112, 13512, true);
            WriteLiteral(@"
<style>
    .invoice-body {
        margin-top: 40px;
        padding-left: 40px;
        padding-right: 40px;
    }
    .printinvoice{
        margin-top: 100px;
    }
    .info-body {
        padding-left: 20px;
        padding-right: 20px;
    }

    .display {
        padding-left: 10px;
    }

    .quoteno {
        height: 20px !important;
    }

    .invoice-card {
        margin-left: 3%;
        margin-right: 3%;
    }

    .hidden-info {
        visibility: hidden;
    }

    .total-section {
        margin-top: 40px;
    }

    .customer-button {
        width: 200px;
        height: 120px;
        border-radius: 6px;
        background-color: #fff;
    }

    .adddcustomer {
        margin-left: 2px;
        margin-right: 2px;
    }

    .table-item {
        font-size: 12px;
    }

    .ui-autocomplete {
        position: absolute;
        top: 100%;
        left: 0;
        z-index: 1000;
        float: left;
        display: none;
    ");
            WriteLiteral(@"    min-width: 160px;
        _width: 160px;
        padding: 4px 0;
        margin: 2px 0 0 0;
        list-style: none;
        background-color: #ffffff;
        border-color: #ccc;
        border-color: rgba(0, 0, 0, 0.2);
        border-style: solid;
        border-width: 1px;
        -webkit-border-radius: 5px;
        -moz-border-radius: 5px;
        border-radius: 5px;
        -webkit-box-shadow: 0 5px 10px rgba(0, 0, 0, 0.2);
        -moz-box-shadow: 0 5px 10px rgba(0, 0, 0, 0.2);
        box-shadow: 0 5px 10px rgba(0, 0, 0, 0.2);
        -webkit-background-clip: padding-box;
        -moz-background-clip: padding;
        background-clip: padding-box;
        *border-right-width: 2px;
        *border-bottom-width: 2px;
    }

    .ui-menu-item > a.ui-corner-all {
        display: block;
        padding: 3px 15px;
        clear: both;
        font-weight: normal;
        line-height: 18px;
        color: #555555;
        white-space: nowrap;
    }

    &.ui-state-hover");
            WriteLiteral(@", &.ui-state-active {
        color: #ffffff;
        text-decoration: none;
        background-color: #0088cc;
        border-radius: 0px;
        -webkit-border-radius: 0px;
        -moz-border-radius: 0px;
        background-image: none;
    }
</style>


<div class=""content printinvoice"">
    <div class=""row"">
        <div class=""col-md-1"">

        </div>
        <div class=""col-md-10"">
            <div class=""card invoice-card"">

                <div class=""card-header"">

                    <div class=""row invoice-card"">
                        <h5>Invoice No:</h5>

                        <div class="""">

                            <div class=""col-md-12"">
                                <label type=""number"" class=""form-control"">
                                    Model.InvoiceNo
                                </label>
                                <input hidden />
                            </div>

                        </div>
                    </div>

    ");
            WriteLiteral(@"                <hr />

                    <div class=""row info-body"">
                        <div class=""col-md-12"">
                            <div class=""col-md-4 pull-right"">
                                <h5 class=""text-right"">
                                    <b class=""text-danger spanlabel"">
                                        Model.Organisation.OrganisationName
                                    </b>
                                </h5>

                                <p class=""text-right"">
                                    Model.Organisation.Address
                                    <br />Model.Organisation.City
                                    <br />Model.Organisation.State
                                    <br />Model.Organisation.Country
                                </p>
                            </div>

                        </div>
                    </div>
                    <br />

                    <div>
                        <div cl");
            WriteLiteral(@"ass=""col-md-12"">
                            <div class=""pull-right text-right col-md-2"">
                                <p>
                                    <b>Invoice Date:</b>
                                    <input "" type=""date"" class=""form-control"" />
                                </p>
                            </div>

                        </div>

                    </div>




                    <div class=""card-body"">
                        <div class=""row invoice-card"">

                            <!-- Modal -->
                            <div class=""modal fade"" id=""exampleModalLong"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLongTitle"" aria-hidden=""true"">
                                <div class=""modal-dialog"" role=""document"">
                                    <div class=""modal-content"">
                                        <div class=""modal-header"">
                                            <h5 class=""modal-title"" id=""exampleModalLongTi");
            WriteLiteral(@"tle"">Add New Customer</h5>
                                            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                                <span aria-hidden=""true"">&times;</span>
                                            </button>
                                        </div>

                                        <div class=""modal-body"">
                                            <form>
                                                <label class=""pull-left"">Customer name</label>
                                                <input type=""text"" class=""form-control"" />
                                                <br />
                                                <label class=""pull-left"">Email Address</label>
                                                <input type=""text"" class=""form-control"" />
                                                <br />
                                                <label class=""pull-left"">P");
            WriteLiteral(@"hone Number</label>
                                                <input type=""number"" class=""form-control"" />
                                                <br />
                                            </form>

                                        </div>
                                        <div class=""modal-footer"">
                                            <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                                            <button type=""button"" class=""btn btn-info"">Add Customer</button>
                                        </div>
                                    </div>
                                </div>
                            </div>

                        </div>


                    </div>

                    <br />


                    <div class=""row"">
                        <div class=""col-md-12"">
                            <div class=""col-md-4"">


                               ");
            WriteLiteral(@"
                                    <button class=""btn btn-light"" data-toggle=""modal"" data-target=""#exampleModalLong"">+ Add Customer</button> <input id=""autoCustomer"" name=""autoCustomer"" type=""text"" class=""form-control"" placeholder=""Search Customer"">
                                    <textarea id=""cusAddress"" name=""cusAddress"" class=""form-control""></textarea>

                                
                                <input id=""cusId"" hidden />
                            </div>

                        </div>


                    </div>


                    <div class=""row"">
                        <div class=""col-md-12 invoice-body"">
                            <div class=""table-responsive-sm"" style=""overflow:auto;"">
                                <table class=""table"">
                                    <thead>
                                        <tr>
                                            <th class=""table-item""><strong>Item</strong></th>
                         ");
            WriteLiteral(@"                   <th><strong>Description</strong></th>
                                            <th class=""text-right""><strong>Quantity</strong></th>
                                            <th class=""text-right""><strong>Unit Cost</strong></th>
                                            <th class=""text-right""><strong>Total Cost</strong></th>
                                            <th>+/-</th>

                                        </tr>
                                    </thead>
                                    <tbody>

                                       
                                            <tr>

                                                <td>
                                                    <p type=""text"">
                                                        item.ProductService.ProductServiceName
                                                    </p>
                                                </td>
                                         ");
            WriteLiteral(@"       <td>
                                                    <p type=""text"">
                                                        item.ProductService.Description
                                                    </p>
                                                </td>
                                                <td class=""text-right"">
                                                    <p type=""text"">
                                                        item.Quantity
                                                    </p>
                                                </td>
                                                <td class=""text-right"">
                                                    <p type=""text"">
                                                        item.UnitCost.ToString(""N2"")
                                                    </p>
                                                </td>
                                                <td class=""text-right"">
");
            WriteLiteral(@"                                                    <p type=""text"">
                                                        item.TotalCost.ToString(""N2"")
                                                    </p>
                                                </td>
                                                <td>
                                                    <button class=""btn btn-sm btn-danger"">-</button>
                                                </td>

                                            </tr>

                                        

                                        <tr>
                                            <td>
                                                <input id=""proItemId"" name=""proItemId"" hidden />
                                                <input id=""proItem"" name=""proItem"" type=""text"" class=""form-control"" placeholder=""Item/Service"">
                                            </td>
                                            <td>
     ");
            WriteLiteral(@"                                           <input id=""proDes"" name=""proDes"" type=""text"" class=""form-control"" placeholder=""Description"">
                                            </td>
                                            <td class=""text-right"">
                                                <input id=""proQuantity"" name=""proQuantity"" type=""number"" class=""form-control text-right"" placeholder=""0"">
                                            </td>
                                            <td class=""text-right"">
                                                <input id=""proCostPrice"" name=""proCostPrice"" type=""number"" class=""form-control text-right"" placeholder=""0.00"">
                                            </td>
                                            <td class=""text-right"">
                                                <input id=""proTotal"" name=""proTotal"" type=""number"" class=""form-control text-right"" placeholder=""0"" />
                                            </td>
          ");
            WriteLiteral(@"                                  <td>
                                                <button id=""addItem"" class=""btn btn-sm btn-success"">+</button>
                                            </td>

                                        </tr>

                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-12 total-section invoice-body"">
                        <div class=""pull-right text-right"">
                            <h4>Sub - Total:  ₦ Model.SubTotal.ToString(""N2"")</h4>
                            <p>
                                <input class=""check"" checked disabled type=""checkbox"" /> vat (5%) :  ₦Model.Tax.ToString(""N2"")
                            </p>
                            <hr>
                            <h3>
                                <b>Total :</b> ₦ Model.Total.ToString(""N2"")
                            <");
            WriteLiteral("/h3>\r\n                        </div>\r\n                        <div class=\"clearfix\"></div>\r\n                        <hr>\r\n                        <div class=\"text-right\">\r\n                            ");
            EndContext();
            BeginContext(13624, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbcd93110ba547afbb734c019fac745b", async() => {
                BeginContext(13690, 46, true);
                WriteLiteral(" <span><i class=\"fa fa-save\"></i> Save</span> ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(13740, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(13770, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f348e5ca70f14ea2bbe9719bd7534dfe", async() => {
                BeginContext(13846, 7, true);
                WriteLiteral(" Done  ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(13857, 200, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"col-md-1\">\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
