#pragma checksum "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Quote\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31e378e0719ed4e3fc955305c27c5d3f17a85733"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Quote_Index), @"mvc.1.0.view", @"/Views/Quote/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Quote/Index.cshtml", typeof(AspNetCore.Views_Quote_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31e378e0719ed4e3fc955305c27c5d3f17a85733", @"/Views/Quote/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0d6bd66a948813bdfc09794c8b8e3a2f8caf788", @"/Views/_ViewImports.cshtml")]
    public class Views_Quote_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<E4S.ViewModel.AccountVM.QuoteListViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddQuote", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Quote", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-md  btn-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: #fff;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-icon btn-info btn-sm like"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("tooltip"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-placement", new global::Microsoft.AspNetCore.Html.HtmlString("top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("View/Update"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ConvertToInvoice", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-icon btn-sm remove"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Convert to Invoice"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(64, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Quote\Index.cshtml"
  
  ViewData["Title"] = "Quotes";
  Layout = "~/Views/Shared/_LayoutAccountInventory.cshtml";

#line default
#line hidden
            BeginContext(167, 209, true);
            WriteLiteral("<style>\r\n  .body-card {\r\n    margin-left: 2%;\r\n    margin-right: 2%;\r\n    margin-top: 1%;\r\n    margin-bottom: 2%;\r\n  }\r\n\r\n  .button-padding {\r\n    margin-right: 10px\r\n  }\r\n</style>\r\n\r\n<div class=\"content\">\r\n  ");
            EndContext();
            BeginContext(377, 79, false);
#line 21 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Quote\Index.cshtml"
Write(Html.Partial("~/Views/Manage/_StatusMessage.cshtml", ViewData["StatusMessage"]));

#line default
#line hidden
            EndContext();
            BeginContext(456, 974, true);
            WriteLiteral(@"

  <div class=""row"">
    <div class=""col-lg-12"">
      <div class=""card"">
        <div class=""card-header body-card"">
          <div class=""row"">
            <div class=""col-md-12"">
              <div class=""col-md-3 pull-left"">
                <h4 class=""card-title"">Quotes</h4>
              </div>

              <div class=""btn-group col-md-5 pull-right"">
                <a class=""btn btn-success dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"" style=""color: #fff;"">
                  Export Data
                </a>
                <div class=""dropdown-menu"">
                  <a class=""dropdown-item"" href=""#"">Copy</a>
                  <a class=""dropdown-item"" href=""#"">CSV</a>
                  <a class=""dropdown-item"" href=""#"">Excel</a>
                  <a class=""dropdown-item"" href=""#"">PDF</a>
                  <a class=""dropdown-item"" href=""#"">Print</a>

                </div>

                ");
            EndContext();
            BeginContext(1430, 302, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09cef12b041e44ef95b3af47659c3406", async() => {
                BeginContext(1543, 185, true);
                WriteLiteral("\r\n                  <span class=\"btn-label\">\r\n                    <i class=\"now-ui-icons travel_info\"></i>\r\n                  </span>\r\n\r\n                  Create New\r\n\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1732, 888, true);
            WriteLiteral(@"
              </div>

            </div>
          </div>



        </div>
        <div class=""card-body body-card"">
          <div class=""row"">
            <div class=""col-lg-12"">
              <div class=""table-responsive"" style=""overflow:auto;"">
                <table id=""datatable compact"" class=""table table-hover"">
                  <thead>
                    <tr>
                      <th scope=""col""><strong>Date </strong></th>
                      <th><strong>ID</strong></th>
                      <th scope=""col""><strong>Customer Name</strong></th>
                      <th class=""text-right"" scope=""col""><strong>Amount</strong></th>
                      <th class=""text-right"" scope=""col"" class=""disabled-sorting""><strong>Actions</strong></th>
                    </tr>
                  </thead>
                  <tbody class=""fontweight"">

");
            EndContext();
#line 78 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Quote\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(2693, 64, true);
            WriteLiteral("                    <tr>\r\n                      <td scope=\"row\">");
            EndContext();
            BeginContext(2758, 51, false);
#line 81 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Quote\Index.cshtml"
                                 Write(item.QuoteRecord.DateCreated.ToString("dd MMM, yy"));

#line default
#line hidden
            EndContext();
            BeginContext(2809, 64, true);
            WriteLiteral("</td>\r\n                      <td scope=\"row\" class=\"table-font\">");
            EndContext();
            BeginContext(2874, 24, false);
#line 82 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Quote\Index.cshtml"
                                                    Write(item.QuoteRecord.QuoteNo);

#line default
#line hidden
            EndContext();
            BeginContext(2898, 35, true);
            WriteLiteral("</td>\r\n                      <td>\r\n");
            EndContext();
#line 84 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Quote\Index.cshtml"
                         try
                        {
                          

#line default
#line hidden
            BeginContext(3017, 26, false);
#line 86 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Quote\Index.cshtml"
                     Write(item.Customer.CustomerName);

#line default
#line hidden
            EndContext();
#line 86 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Quote\Index.cshtml"
                                                     
                        }
                        catch
                        {

#line default
#line hidden
            BeginContext(3130, 38, true);
            WriteLiteral("                          <p>---</p>\r\n");
            EndContext();
#line 91 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Quote\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(3195, 86, true);
            WriteLiteral("                      </td>\r\n                      <td class=\"text-right\" scope=\"row\">");
            EndContext();
            BeginContext(3282, 37, false);
#line 93 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Quote\Index.cshtml"
                                                    Write(item.QuoteRecord.Total.ToString("N2"));

#line default
#line hidden
            EndContext();
            BeginContext(3319, 80, true);
            WriteLiteral("</td>\r\n\r\n                      <td class=\"text-right\">\r\n                        ");
            EndContext();
            BeginContext(3399, 196, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd796e1f049d45138a71cc5d252ad3e7", async() => {
                BeginContext(3565, 26, true);
                WriteLiteral("<i class=\"fas fa-eye\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 96 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Quote\Index.cshtml"
                             WriteLiteral(item.QuoteRecord.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3595, 211, true);
            WriteLiteral("\r\n                        <a href=\"#\" class=\"btn btn-success btn-icon btn-sm edit\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Send as Mail\"><i class=\"fas fa-paper-plane\"></i></a>\r\n                        ");
            EndContext();
            BeginContext(3806, 221, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46b87cedfed146d79881557806a77193", async() => {
                BeginContext(3992, 31, true);
                WriteLiteral("<i class=\"far fa-file-alt\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 98 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Quote\Index.cshtml"
                             WriteLiteral(item.QuoteRecord.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4027, 58, true);
            WriteLiteral("\r\n                      </td>\r\n                    </tr>\r\n");
            EndContext();
#line 101 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Quote\Index.cshtml"

                    }

#line default
#line hidden
            BeginContext(4110, 182, true);
            WriteLiteral("                  </tbody>\r\n                </table>\r\n              </div>\r\n            </div>\r\n\r\n          </div>\r\n\r\n        </div>\r\n      </div>\r\n\r\n    </div>\r\n  </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<E4S.ViewModel.AccountVM.QuoteListViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591