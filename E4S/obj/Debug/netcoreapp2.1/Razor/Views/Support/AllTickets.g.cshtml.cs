#pragma checksum "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Support\AllTickets.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cecf322ecf92ea5fdecb783278446ca38c34d11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Support_AllTickets), @"mvc.1.0.view", @"/Views/Support/AllTickets.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Support/AllTickets.cshtml", typeof(AspNetCore.Views_Support_AllTickets))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cecf322ecf92ea5fdecb783278446ca38c34d11", @"/Views/Support/AllTickets.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0d6bd66a948813bdfc09794c8b8e3a2f8caf788", @"/Views/_ViewImports.cshtml")]
    public class Views_Support_AllTickets : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<E4S.Models.WragbyAdmin.Ticket>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AdminViewTicket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Support", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-icon btn-sm  btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString(" View Details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("tooltip"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-placement", new global::Microsoft.AspNetCore.Html.HtmlString("top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(51, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Support\AllTickets.cshtml"
  
    ViewData["Title"] = "All Tickets";
    Layout = "~/Views/Shared/_LayoutWragbyAdmin.cshtml";

#line default
#line hidden
            BeginContext(160, 1878, true);
            WriteLiteral(@"

<style>
    .body-card {
        margin-left: 2%;
        margin-right: 2%;
        margin-top: 1%;
        margin-bottom: 2%;
    }
</style>

<div class=""content"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""card"">
                <div class=""card-header body-card"">
                    <div class=""row"">
                        <div class=""col-md-12"">
                            <div class=""col-md-6 pull-left"">
                                <h4 class=""card-title"">Support</h4>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""card-body body-card"">
                    <div class=""row"">
                        <div class=""col-lg-12"">
                            <div class=""table-responsive"" style=""overflow:auto;"">
                                <table id=""datatable2"" class=""table table-striped"">
                                    <thead>
             ");
            WriteLiteral(@"                           <tr>

                                            <th><strong>Support ID</strong></th>
                                            <th><strong>Date</strong></th>
                                            <th><strong> Organisation</strong></th>
                                            <th><strong> Title</strong></th>
                                            <th><strong> Description</strong></th>
                                            <th><strong> Severity Level</strong></th>
                                            <th><strong> Status </strong></th>
                                            <th class=""disabled-sorting ""><strong> Action</strong></th>

                                        </tr>
                                    </thead>
                                    <tbody>

");
            EndContext();
#line 53 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Support\AllTickets.cshtml"
                                         foreach (var item in Model)
                                        {

#line default
#line hidden
            BeginContext(2151, 102, true);
            WriteLiteral("                                            <tr>\r\n                                                <td>");
            EndContext();
            BeginContext(2254, 14, false);
#line 56 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Support\AllTickets.cshtml"
                                               Write(item.SupportId);

#line default
#line hidden
            EndContext();
            BeginContext(2268, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(2328, 41, false);
#line 57 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Support\AllTickets.cshtml"
                                               Write(item.DateCreated.ToString("dd, MMM, yyy"));

#line default
#line hidden
            EndContext();
            BeginContext(2369, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(2429, 34, false);
#line 58 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Support\AllTickets.cshtml"
                                               Write(item.Organisation.OrganisationName);

#line default
#line hidden
            EndContext();
            BeginContext(2463, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(2523, 10, false);
#line 59 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Support\AllTickets.cshtml"
                                               Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2533, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(2593, 16, false);
#line 60 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Support\AllTickets.cshtml"
                                               Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(2609, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(2669, 13, false);
#line 61 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Support\AllTickets.cshtml"
                                               Write(item.Severity);

#line default
#line hidden
            EndContext();
            BeginContext(2682, 59, true);
            WriteLiteral("</td>\r\n                                                <th>");
            EndContext();
            BeginContext(2742, 11, false);
#line 62 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Support\AllTickets.cshtml"
                                               Write(item.Status);

#line default
#line hidden
            EndContext();
            BeginContext(2753, 113, true);
            WriteLiteral("</th>\r\n                                                <td>\r\n                                                    ");
            EndContext();
            BeginContext(2866, 225, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e2125116ba64dce99e346d33701b299", async() => {
                BeginContext(3062, 25, true);
                WriteLiteral("<i class=\"fa fa-eye\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 64 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Support\AllTickets.cshtml"
                                                                                                               WriteLiteral(item.OrganisationId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
            BeginContext(3091, 311, true);
            WriteLiteral(@"
                                                    <a href=""#"" class=""btn btn-danger btn-icon btn-sm remove "" title=""Delete"" data-toggle=""tooltip"" data-placement=""top""><i class=""fas fa-times""></i></a>
                                                </td>
                                            </tr>
");
            EndContext();
#line 68 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Support\AllTickets.cshtml"
                                        }

#line default
#line hidden
            BeginContext(3445, 272, true);
            WriteLiteral(@"                                    </tbody>
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
                BeginContext(3735, 2623, true);
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


        swal({
          title: 'Are you sure?',
          text: ""You are about to delete '"" + userName + ""'"",
          type: 'warning',
          showCancelButton: true,
          confirmButtonClass: 'btn btn-success'");
                WriteLiteral(@",
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

              } else if (r.msg == ""No Dat");
                WriteLiteral(@"a"") {
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
