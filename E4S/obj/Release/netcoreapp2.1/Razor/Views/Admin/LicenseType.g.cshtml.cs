#pragma checksum "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\LicenseType.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ee3f76da9cd0822ffbaed4cfb798afaad6f0155"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_LicenseType), @"mvc.1.0.view", @"/Views/Admin/LicenseType.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/LicenseType.cshtml", typeof(AspNetCore.Views_Admin_LicenseType))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ee3f76da9cd0822ffbaed4cfb798afaad6f0155", @"/Views/Admin/LicenseType.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0d6bd66a948813bdfc09794c8b8e3a2f8caf788", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_LicenseType : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BizManager.Models.WragbyAdmin.LicenseType>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewLicense", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info pull-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\LicenseType.cshtml"
  
    ViewData["Title"] = "License Type";
    Layout = "~/Views/Shared/_LayoutWragbyAdmin.cshtml";

#line default
#line hidden
            BeginContext(171, 2291, true);
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

    .formdiv {
        margin-bottom: 12px;
    }
    }
</style>

<div class=""content"">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card"">

                <div class=""card-header body-card"">
                    <div class=""row"">
                        <div class=""col-md-12"">
                            <div class=""col-md-6 pull-left"">
                                <h4 class=""card-title"">License Type Name</h4>
                            </div>
                            <div class=""col-md-6 pull-right"">

                                <button class=""btn btn-success btn-md pull-right btn-responsive"" data-toggle=""modal"" data-target=""#exampleModalLong"">

                                    <span");
            WriteLiteral(@" class=""btn-label"">
                                        <i class=""now-ui-icons ui-1_simple-add""></i>
                                    </span>

                                    New License Type

                                </button>

                                <!-- Modal -->
                                <div class=""modal fade"" id=""exampleModalLong"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLongTitle"" aria-hidden=""true"">
                                    <div class=""modal-dialog"" role=""document"">
                                        <div class=""modal-content"">
                                            <div class=""modal-header"">
                                                <h5 class=""modal-title"" id=""exampleModalLongTitle"">Add New License Type</h5>
                                                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                                    <span aria-hidden=""true"">&tim");
            WriteLiteral("es;</span>\r\n                                                </button>\r\n                                            </div>\r\n\r\n                                            <div class=\"modal-body\">\r\n                                                ");
            EndContext();
            BeginContext(2462, 1302, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe8da37e523c47fdbec4bef12d3d035b", async() => {
                BeginContext(2492, 1265, true);
                WriteLiteral(@"
                                                    <div class=""col-md-12 formdiv"">
                                                        <label>License Type Name</label>

                                                        <input type=""text"" class=""form-control"" placeholder="" License Type Name "" id=""LicenseTypeName"" name=""LicenseTypeName"" required>

                                                    </div>

                                                    <div class=""col-md-12 formdiv"">
                                                        <label>No of Admins</label>
                                                        <input type=""number"" class=""form-control"" placeholder=""E.g 20"" id=""NoOfAdmin"" name=""NoOfAdmin"" required>

                                                    </div>
                                                    <div class=""col-md-12 formdiv"">
                                                        <label>No of Users</label>
                                 ");
                WriteLiteral("                       <input type=\"number\" class=\"form-control\" placeholder=\"E.g 20\" id=\"NoOfUsers\" name=\"NoOfUsers\" required>\r\n\r\n                                                    </div>\r\n\r\n                                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3764, 1861, true);
            WriteLiteral(@"

                                            </div>
                                            <div class=""modal-footer"">
                                                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                                                <button type=""button"" class=""btn btn-info"" id=""AddLicenceType"" name=""AddLicenceType"">Generate</button>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                            </div>
                        </div>
                    </div>
                </div>

                <div class=""card-body body-card"">
                    <div class=""row"">
                        <div class=""col-lg-12"">
                            <div class=""table-responsive"" style=""overflow:auto;"">
                                <table id=""datatable compact"" class=""table table-");
            WriteLiteral(@"hover"">
                                    <thead>
                                        <tr>

                                            <th><strong>Date Created</strong></th>
                                            <th><strong>License Type Name</strong></th>
                                            <th class=""text-center""><strong>No of Users</strong></th>

                                            <th class=""text-center""><strong>No of Admins</strong></th>
                                            <th class=""text-center""><strong>Ststus</strong></th>
                                            <th class=""pull-right""><strong>Actions</strong></th>
                                        </tr>
                                    </thead>
                                    <tbody class=""fontweight"">
");
            EndContext();
#line 120 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\LicenseType.cshtml"
                                         foreach (var item in Model)
                                        {


#line default
#line hidden
            BeginContext(5740, 104, true);
            WriteLiteral("                                            <tr>\r\n\r\n                                                <td>");
            EndContext();
            BeginContext(5845, 16, false);
#line 125 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\LicenseType.cshtml"
                                               Write(item.DateCreated);

#line default
#line hidden
            EndContext();
            BeginContext(5861, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(5921, 20, false);
#line 126 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\LicenseType.cshtml"
                                               Write(item.LicenseTypeName);

#line default
#line hidden
            EndContext();
            BeginContext(5941, 80, true);
            WriteLiteral(" </td>\r\n                                                <td class=\"text-center\">");
            EndContext();
            BeginContext(6022, 14, false);
#line 127 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\LicenseType.cshtml"
                                                                   Write(item.NoOfUsers);

#line default
#line hidden
            EndContext();
            BeginContext(6036, 79, true);
            WriteLiteral("</td>\r\n                                                <td class=\"text-center\">");
            EndContext();
            BeginContext(6116, 14, false);
#line 128 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\LicenseType.cshtml"
                                                                   Write(item.NoOfAdmin);

#line default
#line hidden
            EndContext();
            BeginContext(6130, 79, true);
            WriteLiteral("</td>\r\n                                                <td class=\"text-center\">");
            EndContext();
            BeginContext(6210, 11, false);
#line 129 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\LicenseType.cshtml"
                                                                   Write(item.Status);

#line default
#line hidden
            EndContext();
            BeginContext(6221, 122, true);
            WriteLiteral("</td>\r\n                                                <td class=\"\">\r\n                                                    ");
            EndContext();
            BeginContext(6343, 155, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9683826c80740b6956d6f8847d04a19", async() => {
                BeginContext(6469, 25, true);
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
            BeginContext(6498, 110, true);
            WriteLiteral("\r\n                                                </td>\r\n\r\n                                            </tr>\r\n");
            EndContext();
#line 135 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\LicenseType.cshtml"
                                        }

#line default
#line hidden
            BeginContext(6651, 290, true);
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
                BeginContext(6959, 1914, true);
                WriteLiteral(@"

    <script type=""text/javascript"">
        
        $(document).ready(function () {

         $(""#AddLicenceType"").click(function (event) {

          event.preventDefault();

              //$(""#loading-overlay"").show();
          var NewLicenceType = {
                LicenseTypeName: $(""#LicenseTypeName"").val(),
                NoOfAdmin: $(""#NoOfAdmin"").val(),
                NoOfUsers: $(""#NoOfUsers"").val(),
           };


          console.log(NewLicenceType);

          $.ajax({
            type: ""POST"",
            url: ""/Admin/CreateLicenceType"",
            data: JSON.stringify(NewLicenceType),
            dataType: ""json"",
            contentType: 'application/json; charset=utf-8',
            headers: {
              RequestVerificationToken:
                $('input:hidden[name=""__RequestVerificationToken""]').val()
            },
            success: function (r) {

              if (r.msg == ""Success"") {

        	    swal({
                    title: ""Succ");
                WriteLiteral(@"ess!"",
                    text: ""Licence Type Added!"",
                    buttonsStyling: false,
                    confirmButtonClass: ""btn btn-success"",
                type: ""success""
              }).then(function () {
                window.location.reload();
              }).catch(swal.noop);

              } else if (r.msg == ""Fail"") {
                $(""#loading-overlay"").hide();
                alert(r.msg);

              } else if (r.msg == ""No Data"") {
                $(""#loading-overlay"").hide();
                alert(r.msg);

              } else {
                $(""#loading-overlay"").hide();
                alert(r.msg);
              }

            },
            error: function () {
              $(""#loading-overlay"").hide();
              alert(r.msg);
            }
          });
        });

    })
   

    </script>


");
                EndContext();
            }
            );
            BeginContext(8876, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BizManager.Models.WragbyAdmin.LicenseType>> Html { get; private set; }
    }
}
#pragma warning restore 1591