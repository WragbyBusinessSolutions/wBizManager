#pragma checksum "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Invoice\Index22.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99eacaa85891b9a49628a058c7ead6dfd65f5f90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Invoice_Index22), @"mvc.1.0.view", @"/Views/Invoice/Index22.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Invoice/Index22.cshtml", typeof(AspNetCore.Views_Invoice_Index22))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99eacaa85891b9a49628a058c7ead6dfd65f5f90", @"/Views/Invoice/Index22.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0d6bd66a948813bdfc09794c8b8e3a2f8caf788", @"/Views/_ViewImports.cshtml")]
    public class Views_Invoice_Index22 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Invoice\Index22.cshtml"
  
  ViewData["Title"] = "Invoice";
  Layout = "~/Views/Shared/_LayoutHumanResouces.cshtml";

#line default
#line hidden
            BeginContext(101, 274, true);
            WriteLiteral(@"

<div class=""content"">


  <div class=""row"">
    <!-- Column -->

    <div class=""container-fluid"">
      <div class=""content"">
        <div class=""row"">
          <div class=""col-md-12"">
            <div class=""card"">
              <div class=""card-header"">
");
            EndContext();
            BeginContext(632, 603, true);
            WriteLiteral(@"

                <div class=""row"">
                  <div class=""col-md-3"">
                    <div class=""card-body text-left"">
                      <h4>Invoice</h4>
                    </div>
                  </div>
                  <div class=""col-md-3 ml-auto"">
                    <div class=""card-body text-right"">
                      <label class=""col-sm-6 col-form-label""><h6>Invoice No.</h6></label>
                      <div class=""form-group"">
                        <input type=""text"" class=""form-control"" placeholder=""#04271-5"" disabled>
                      </div>
");
            EndContext();
            BeginContext(1371, 159, true);
            WriteLiteral("\r\n                    </div>\r\n                  </div>\r\n                </div>\r\n\r\n                <div class=\"row\">\r\n                  <div class=\"col-md-3\">\r\n");
            EndContext();
            BeginContext(1574, 96, true);
            WriteLiteral("                    <div class=\"card-body text-left\">\r\n                      <b>Billed To:</b>\r\n");
            EndContext();
            BeginContext(1707, 223, true);
            WriteLiteral("\r\n                      <b>C & I Leasing</b><br />\r\n                      <p>5, Okoya Thomas Close,</p>\r\n                      <p>Surulere, Lagos</p>\r\n                      <abbr title=\"Phone\">P:</abbr>(0803) 573-3902\r\n\r\n\r\n");
            EndContext();
            BeginContext(1968, 28, true);
            WriteLiteral("                    </div>\r\n");
            EndContext();
            BeginContext(2028, 1360, true);
            WriteLiteral(@"                  </div>
                  <div class=""col-md-3 ml-auto"">
                    <div class=""card-body text-right"">
                      <b>Shipped To:</b>
                      <b>Flutterwave, Inc.</b>
                      <p>24, Oju Ologbon Str.</p>
                      <p>Victoria Island, Lagos</p>
                      <abbr title=""Phone"">P:</abbr>(0803) 726-1372

                    </div>
                  </div>
                </div>


                <div class=""row"">
                  <div class=""col-md-3 ml-auto"">
                    <div class=""card-body text-right"">
                      <div class=""form-group"">
                        <p>Invoice Date : <i class=""fa fa-calendar""></i></p><input type=""date"" class=""form-control"" placeholder="".col-md-3"">
                      </div>
                    </div>
                  </div>






                </div>



                <div class=""row"">


                  <div class=""col-md-3 ml-auto"">
");
            WriteLiteral(@"                    <div class=""card-body text-right"">
                      <div class=""form-group"">
                        <p>Due Date : <i class=""fa fa-calendar""></i></p><input type=""date"" class=""form-control"" placeholder="".col-md-3"">
                      </div>
                    </div>
                  </div>





");
            EndContext();
            BeginContext(3931, 262, true);
            WriteLiteral(@"              </div>

              <div class=""col-md-3"">
                <div class=""card-body text-left"">
                  <div class=""form-group"">
                    <p>To:</p>
                    <select class=""form-control"">
                      ");
            EndContext();
            BeginContext(4193, 26, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03afaaadc6ce4bbeb27f4edffd0d1f0e", async() => {
                BeginContext(4201, 9, true);
                WriteLiteral("Mr. Emeka");
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
            BeginContext(4219, 716, true);
            WriteLiteral(@"

                    </select>
                  </div>
                </div>
              </div>

              <div class=""row"">
                <div class=""col-sm-3"">
                  <div class=""card-body text-center"">
                  </div>
                </div>
                <div class=""col-sm-6"">
                  <div class=""card-body text-center"">
                <input @*asp-for=""InvoiceTitle""*@ class=""form-control text-center"" placeholder=""INVOICE TITLE"" />
                  </div>
                </div>
                <div class=""col-sm-3"">
                  <div class=""card-body text-center"">
                  </div>
                </div>
              </div>

");
            EndContext();
            BeginContext(5134, 4082, true);
            WriteLiteral(@"


              </div>
              <div class=""card-body"">
                <br />
                <div class=""table-responsive"">
                  <table class=""table"">
                    <thead class="" text-primary"">
                    <th class=""text-center"">
                      Item/Service
                    </th>
                    <th class=""text-center"">
                      Description
                    </th>
                    <th class=""text-center"">
                      Quantity
                    </th>
                    <th class=""text-center"">
                      Unit Cost
                    </th>
                    <th class=""text-center"">
                      Total
                    </th>
                    <th class=""text-center"">
                      +/-
                    </th>

                    </thead>
                    <tbody>
                      <tr>
                        <td>
                          <input hidden type");
            WriteLiteral(@"=""text"" id=""addEstimateId"" name=""bdate"" class=""form-control"" @*value=""@Model.EstimateId""*@>
                          <input type=""text"" id=""addItem"" name=""bdate"" onChange=""changecat(this.value);"" class=""form-control"" placeholder=""Item/Service"">
                        </td>
                        <td>
                          <input type=""text"" id=""addDescription"" name=""bdate"" class=""form-control"" placeholder=""Description"">
                        </td>
                        <td>
                          <input type=""number"" id=""addQuantity"" name=""bdate"" class=""form-control text-right"" placeholder=""0"">
                        </td>
                        <td @*class=""text-right""*@>
                          <input type=""number"" id=""addUnitCost"" name=""bdate"" class=""form-control text-right"" placeholder=""0.00"">
                        </td>
                        <td @*class=""text-right""*@>
                          <input disabled type=""number"" id=""addAmount"" name=""bdate"" class=""form-contro");
            WriteLiteral(@"l text-right"" placeholder=""0"">
                        </td>
                        <td @*class=""text-right""*@>
                          <button id=""clickb"" name=""clickb"" class=""btn btn-sm btn-success"">+</button>
                        </td>
                      </tr>

                      <tr>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td class=""text-right""><b>Sub Total:</b></td>
                        <td>₦0.00</td>
                      </tr>

                      <tr>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td class=""text-right""><b>VAT(5%):</b></td>
                        <td>₦0.00</td>
                      </tr>

                      <tr>
                        <td></td>
                        <td></td>
                        <td");
            WriteLiteral(@"></td>
                        <td></td>
                        <td class=""text-right""><h5>Total:</h5></td>
                        <td><h5>₦0.00</h5></td>
                      </tr>

                      <tr>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td class=""text-right""><button class=""btn btn-danger"" type=""submit""> Done  </button></td>
                        <td><button id=""print"" class=""btn btn-default btn-outline"" type=""button""> <span><i class=""fa fa-print""></i> Save</span> </button></td>
                      </tr>

                    </tbody>
                  </table>
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
