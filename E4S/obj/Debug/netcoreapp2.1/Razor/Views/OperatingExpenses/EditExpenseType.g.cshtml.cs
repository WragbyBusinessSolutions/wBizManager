#pragma checksum "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\OperatingExpenses\EditExpenseType.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "042839d2205b0f71cb9d35d059e502fac236b12d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OperatingExpenses_EditExpenseType), @"mvc.1.0.view", @"/Views/OperatingExpenses/EditExpenseType.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/OperatingExpenses/EditExpenseType.cshtml", typeof(AspNetCore.Views_OperatingExpenses_EditExpenseType))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"042839d2205b0f71cb9d35d059e502fac236b12d", @"/Views/OperatingExpenses/EditExpenseType.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0d6bd66a948813bdfc09794c8b8e3a2f8caf788", @"/Views/_ViewImports.cshtml")]
    public class Views_OperatingExpenses_EditExpenseType : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<E4S.Models.AccountInventory.Expense>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control col-sm-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("John Doe"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Johndoe@gmail.com"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditExpenseType", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\OperatingExpenses\EditExpenseType.cshtml"
  
    ViewData["Title"] = "Edit Expense Type";
    Layout = "~/Views/Shared/_LayoutAccountInventory.cshtml";

#line default
#line hidden
            BeginContext(162, 478, true);
            WriteLiteral(@"
<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.3.1/jquery.min.js""></script>

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


    .labeltext {
        padding-left: 20px;
        padding-right: 20px;
        color: #000 !important;
        text-align: right;
    }
</style>

<div class=""content"">
    ");
            EndContext();
            BeginContext(641, 79, false);
#line 32 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\OperatingExpenses\EditExpenseType.cshtml"
Write(Html.Partial("~/Views/Manage/_StatusMessage.cshtml", ViewData["StatusMessage"]));

#line default
#line hidden
            EndContext();
            BeginContext(720, 292, true);
            WriteLiteral(@"

    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card"">
                <div class=""card-header body-card"">
                    <h5>Edit Expense Type</h5>

                </div>

                <div class=""card-body body-card"">
                    ");
            EndContext();
            BeginContext(1012, 1454, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e00b135fc67346879364fd84375c98ec", async() => {
                BeginContext(1060, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(1086, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a068c48ad1de40549cec80aab4634c44", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 44 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\OperatingExpenses\EditExpenseType.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1122, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(1148, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2f24cd6fce3149d29c3cb695489accf3", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 45 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\OperatingExpenses\EditExpenseType.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.OrganisationId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1196, 168, true);
                WriteLiteral("\r\n\r\n                        <div class=\"form-inline\">\r\n                            <label class=\"labeltext col-sm-3\">Expense Type*</label>\r\n                            ");
                EndContext();
                BeginContext(1364, 105, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2be0041b4bfa4ce682289407380bd362", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 49 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\OperatingExpenses\EditExpenseType.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ExpenseType);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1469, 255, true);
                WriteLiteral("\r\n                        </div>\r\n                        <br />\r\n\r\n                        <div class=\"form-inline\">\r\n                            <label class=\"labeltext col-sm-3\" style=\"text-align:left;\">Description</label>\r\n                            ");
                EndContext();
                BeginContext(1724, 105, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e8922fe131ee43a28b196ebcd8f48983", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 55 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\OperatingExpenses\EditExpenseType.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Description);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1829, 97, true);
                WriteLiteral("\r\n\r\n                        </div>\r\n\r\n                        <br />\r\n                       \r\n\r\n");
                EndContext();
                BeginContext(1972, 10, true);
                WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
                EndContext();
                BeginContext(2018, 275, true);
                WriteLiteral(@"



                        <hr />
                        <div class=""form-inline"">
                            <label class=""labeltext col-sm-3""></label>
                            <input type=""submit"" value=""Save Changes"" class=""btn btn-info content-center"" />

");
                EndContext();
                BeginContext(2403, 56, true);
                WriteLiteral("                        </div>\r\n\r\n\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2466, 4250, true);
            WriteLiteral(@"
                </div>

            </div>
        </div>
    </div>
</div>

<script>
    $(document).ready(function () {
        //-------------------------------SELECT CASCADING-------------------------//
        var selectedCountry = selectedRegion = selectedCity = countryCode = """";
        // This is a demo API key for testing purposes. You should rather request your API key (free) from http://battuta.medunes.net/
        var BATTUTA_KEY = ""00000000000000000000000000000000"";
        // Populate country select box from battuta API
        url =
            ""https://geo-battuta.net/api/country/all/?key="" +
            BATTUTA_KEY +
            ""&callback=?"";
        // EXTRACT JSON DATA.
        $.getJSON(url, function (data) {
            $.each(data, function (index, value) {
                // APPEND OR INSERT DATA TO SELECT ELEMENT. Set the country code in the id section rather than in the value.
                $(""#country"").append(
                    '<option id=""' + value.co");
            WriteLiteral(@"de + '"" value=""' + value.code + '"">' + value.name + ""</option>""
                );
            });
        });
        // Country selected --> update region list .
        $(""#country"").change(function () {
            selectedCountry = this.options[this.selectedIndex].text;
            countryCode = $(this).children("":selected"").attr(""id"");
            url =
                ""https://geo-battuta.net/api/region/"" +
                countryCode +
                ""/all/?key="" +
                BATTUTA_KEY +
                ""&callback=?"";
            $.getJSON(url, function (data) {
                $(""#region option"").remove();
                $.each(data, function (index, value) {
                    // APPEND OR INSERT DATA TO SELECT ELEMENT.
                    $(""#region"").append(
                        '<option value=""' + value.region + '"">' + value.region + ""</option>""
                    );
                });
            });
        });
        // Region selected --> updated city l");
            WriteLiteral(@"ist
        $(""#region"").on(""change"", function () {
            selectedRegion = this.options[this.selectedIndex].text;
            // Populate country select box from battuta API
            region = $(""#region"").val();
            url =
                ""https://geo-battuta.net/api/city/"" +
                countryCode +
                ""/search/?region="" +
                region +
                ""&key="" +
                BATTUTA_KEY +
                ""&callback=?"";
            $.getJSON(url, function (data) {
                $(""#city option"").remove();
                $.each(data, function (index, value) {
                    // APPEND OR INSERT DATA TO SELECT ELEMENT.
                    $(""#city"").append(
                        '<option value=""' + value.city + '"">' + value.city + ""</option>""
                    );
                });
            });
        });
        // city selected --> update location string
        $(""#city"").on(""change"", function () {
            selectedCi");
            WriteLiteral(@"ty = this.options[this.selectedIndex].text;
            $(""#location"").html(
                ""Locatation: Country: "" +
                selectedCountry +
                "", Region: "" +
                selectedRegion +
                "", City: "" +
                selectedCity
            );
        });

    });
    // process form
    function processForm() {
        var username = password = country = region = city = '';
        username = $('#username').val();
        password = $('#password').val();
        country = $('#country').val();
        region = $('#region').val();
        city = $('#city').val();
        if (username != '' && password != '' && country != '' && region != '' && city != '') {
            $(""#location"").html(
                ""Username: "" + username +
                "" /Password: "" + password +
                "" /Locatation: Country: "" +
                country +
                "", Region: "" +
                region +
                "", City: "" +
           ");
            WriteLiteral("     city\r\n            );\r\n        } else {\r\n            $(\"#location\").html(\'Complete Form 1st\');\r\n            return false;\r\n        }\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<E4S.Models.AccountInventory.Expense> Html { get; private set; }
    }
}
#pragma warning restore 1591
