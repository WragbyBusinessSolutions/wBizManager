#pragma checksum "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\AppraisalTemplate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e10ae3e3da3ccc04b2b89103aa5f3f190eb430d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EmployeeProfile_AppraisalTemplate), @"mvc.1.0.view", @"/Views/EmployeeProfile/AppraisalTemplate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/EmployeeProfile/AppraisalTemplate.cshtml", typeof(AspNetCore.Views_EmployeeProfile_AppraisalTemplate))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e10ae3e3da3ccc04b2b89103aa5f3f190eb430d4", @"/Views/EmployeeProfile/AppraisalTemplate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0d6bd66a948813bdfc09794c8b8e3a2f8caf788", @"/Views/_ViewImports.cshtml")]
    public class Views_EmployeeProfile_AppraisalTemplate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<E4S.ViewModel.AppraisalViewTemplateViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\AppraisalTemplate.cshtml"
  
  ViewData["Title"] = "Appraisal Template";
  Layout = "~/Views/Shared/_LayoutEmployee.cshtml";

#line default
#line hidden
            BeginContext(160, 193, true);
            WriteLiteral("\r\n<div class=\"content\">\r\n\r\n\r\n  <div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n      <div class=\"card \">\r\n        <div class=\"card-header \">\r\n          <h4 class=\"card-title\">Template Name: <b>");
            EndContext();
            BeginContext(354, 18, false);
#line 15 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\AppraisalTemplate.cshtml"
                                              Write(Model.TemplateName);

#line default
#line hidden
            EndContext();
            BeginContext(372, 21, true);
            WriteLiteral("</b></h4>\r\n          ");
            EndContext();
            BeginContext(393, 29, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "55ea42abe2bc42c0a88cb6d4c92389b9", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 16 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\AppraisalTemplate.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(422, 62, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"card-body \">\r\n          ");
            EndContext();
            BeginContext(484, 6337, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c7ff447832040ebb85e2a345491ecc1", async() => {
                BeginContext(514, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(2707, 774, true);
                WriteLiteral(@"
            <div class=""col-md-9"">
              <h4 class=""card-title"">Rating Categories</h4>
              <p><b>5. Exceptional Performance: </b> Outstanding performance that far exceeds goals in all performance elements </p>
              <p><b>4. Exceeds Expectations: </b>Performance that consistently goes beyond meeting goals </p>
              <p><b>3. Fully Meets Expectations: </b> Commendable performance that meets goals </p>
              <p><b>2. Partially Meets Expectations: </b> Inconsistent aspects of performance requiring improvement to meet some goals </p>
              <p><b>1. Does Not Meet Expectations: </b> Goals unmet, skills not demonstrated, drastic improvement needed </p>
              <p><b>0. Not Applicable</b></p>
              ");
                EndContext();
                BeginContext(3481, 35, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a86c8ad105624927ae5b8b2888944cc3", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 79 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\AppraisalTemplate.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.AppTemId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3516, 138, true);
                WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"col-md-12\">\r\n              <div class=\"card\">\r\n                <div class=\"card-header\">\r\n");
                EndContext();
                BeginContext(3736, 1029, true);
                WriteLiteral(@"                </div>

                <div class=""col-md-12"">
                  <div class=""card-body"">
                    <div class=""table-responsive"" style=""overflow: auto;"">

                      <table class=""table"">
                        <thead>
                          <tr>


                            <th rowspan=""2""><strong>ITEMS</strong> </th>

                            <th colspan=""5"" style=""text-align: center;""><strong>RATINGS</strong></th>



                          </tr>
                          <tr>


                            <th style=""text-align:right;"">1</th>
                            <th style=""text-align:right;"">2</th>
                            <th style=""text-align:right;"">3</th>
                            <th style=""text-align:right;"">4</th>
                            <th style=""text-align:right;"">5</th>

                          </tr>
                        </thead>



                        <tbody>
                        <tbody");
                WriteLiteral(">\r\n\r\n");
                EndContext();
#line 121 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\AppraisalTemplate.cshtml"
                           foreach (var item in Model.AppCat)
                          {



#line default
#line hidden
                BeginContext(4861, 123, true);
                WriteLiteral("                            <tr style=\"background-color: #e2e2e2;\">\r\n                              <td rowspan=\"2\"><strong>");
                EndContext();
                BeginContext(4985, 57, false);
#line 126 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\AppraisalTemplate.cshtml"
                                                 Write(item.AppraisalTemplateCategory.AppraisalCategory.Category);

#line default
#line hidden
                EndContext();
                BeginContext(5042, 2, true);
                WriteLiteral(" (");
                EndContext();
                BeginContext(5045, 37, false);
#line 126 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\AppraisalTemplate.cshtml"
                                                                                                             Write(item.AppraisalTemplateCategory.Weight);

#line default
#line hidden
                EndContext();
                BeginContext(5082, 528, true);
                WriteLiteral(@"%)</strong></td>
                            </tr>
                            <tr style=""background-color: #e2e2e2;"">
                              <td style=""text-align:right;""><p style=""visibility: hidden;"">1</p></td>
                              <td style=""text-align:right;""></td>
                              <td style=""text-align:right;""></td>
                              <td style=""text-align:right;""></td>
                              <td style=""text-align:right;""></td>
                            </tr>
");
                EndContext();
#line 135 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\AppraisalTemplate.cshtml"
                             foreach (var kpiitem in item.AppraisalCategoryEdit.AppraisalKPIs)
                            {

#line default
#line hidden
                BeginContext(5737, 84, true);
                WriteLiteral("                              <tr>\r\n                                <td rowspan=\"2\">");
                EndContext();
                BeginContext(5822, 11, false);
#line 138 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\AppraisalTemplate.cshtml"
                                           Write(kpiitem.KPI);

#line default
#line hidden
                EndContext();
                BeginContext(5833, 165, true);
                WriteLiteral("</td>\r\n                              </tr>\r\n                              <tr>\r\n\r\n\r\n                                <td style=\"text-align:right;\"><input type=\"radio\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 5998, "\"", 6016, 1);
#line 143 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\AppraisalTemplate.cshtml"
WriteAttributeValue("", 6005, kpiitem.Id, 6005, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6017, 99, true);
                WriteLiteral(" value=\"1\"></td>\r\n                                <td style=\"text-align:right;\"><input type=\"radio\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 6116, "\"", 6134, 1);
#line 144 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\AppraisalTemplate.cshtml"
WriteAttributeValue("", 6123, kpiitem.Id, 6123, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6135, 99, true);
                WriteLiteral(" value=\"2\"></td>\r\n                                <td style=\"text-align:right;\"><input type=\"radio\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 6234, "\"", 6252, 1);
#line 145 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\AppraisalTemplate.cshtml"
WriteAttributeValue("", 6241, kpiitem.Id, 6241, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6253, 99, true);
                WriteLiteral(" value=\"3\"></td>\r\n                                <td style=\"text-align:right;\"><input type=\"radio\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 6352, "\"", 6370, 1);
#line 146 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\AppraisalTemplate.cshtml"
WriteAttributeValue("", 6359, kpiitem.Id, 6359, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6371, 99, true);
                WriteLiteral(" value=\"4\"></td>\r\n                                <td style=\"text-align:right;\"><input type=\"radio\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 6470, "\"", 6488, 1);
#line 147 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\AppraisalTemplate.cshtml"
WriteAttributeValue("", 6477, kpiitem.Id, 6477, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6489, 57, true);
                WriteLiteral(" value=\"5\" /></td>\r\n                              </tr>\r\n");
                EndContext();
#line 149 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\AppraisalTemplate.cshtml"

                            }

#line default
#line hidden
#line 150 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\AppraisalTemplate.cshtml"
                             
                          }

#line default
#line hidden
                BeginContext(6608, 206, true);
                WriteLiteral("\r\n                        </tbody>\r\n\r\n                      </table>\r\n\r\n                    </div>\r\n                  </div>\r\n                </div>\r\n\r\n              </div>\r\n            </div>\r\n\r\n          ");
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
            BeginContext(6821, 1084, true);
            WriteLiteral(@"

        </div>
      </div>
    </div>


    <div class=""col-md-12"">

      <div class=""card "">
        <div class=""card-header "">
          <h4 class=""card-title"">Part Two : Summary Review Of Employee Performance</h4><br />
          <p>
            Supervisor describes employee’s major assignments and accomplishments, key strengths, <br /> any
            performance shortfalls, and other performance elements that characterize the employee’s <br /> performance during the review period.
            Please include examples or supporting information below.
          </p>
        </div>
        <div class=""card-body "">

          <div class=""form-group row"">
            <div class=""col-sm-12"">
              <div class=""input-group"">
                <div class=""input-group-prepend""></div>
                <textarea name=""empReview"" id=""empReview"" class=""form-control"" cols=""4"" rows=""6"" placeholder=""Enter Review Of Employee Perfrormance""></textarea>
              </div>
            </div");
            WriteLiteral(">\r\n          </div>\r\n\r\n          <br />\r\n\r\n          <div>\r\n");
            EndContext();
            BeginContext(7990, 254, true);
            WriteLiteral("\r\n\r\n            <button id=\"btnFinish\" type=\"button\" name=\"btnfinish\" class=\"btn btn-info pull-right\">Finish</button>\r\n            <button id=\"btncheck\" type=\"button\" name=\"btncheck\" class=\"btn btn-danger pull-right\">Save</button>\r\n\r\n          </div>\r\n\r\n");
            EndContext();
            BeginContext(8333, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(9839, 56, true);
            WriteLiteral("\r\n\r\n        </div>\r\n      </div>\r\n\r\n    </div>\r\n\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(12915, 30, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n  </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(12963, 71, true);
                WriteLiteral("\r\n\r\n  <script>\r\n  $(document).ready(function () {\r\n\r\n    var radios = [");
                EndContext();
#line 375 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\AppraisalTemplate.cshtml"
                   foreach (var item in Model.kpiId)
    {

#line default
#line hidden
                BeginContext(13077, 6, true);
                WriteLiteral("      ");
                EndContext();
                BeginContext(13085, 1, true);
                WriteLiteral("\"");
                EndContext();
                BeginContext(13087, 4, false);
#line 377 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\AppraisalTemplate.cshtml"
    Write(item);

#line default
#line hidden
                EndContext();
                BeginContext(13091, 4, true);
                WriteLiteral("\",\r\n");
                EndContext();
#line 378 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\EmployeeProfile\AppraisalTemplate.cshtml"
      }

#line default
#line hidden
                BeginContext(13102, 4320, true);
                WriteLiteral(@"];

    $(""#btncheck"").click(function (event) {

      var result = [];

      for (i = 0; i < radios.length; i++) {

        var eachrd = radios[i];
        var rbtn = document.getElementsByName(eachrd);
        var kpi = {
          KPIId: eachrd,
          KPIResult: ""0""
        }

        for (c = 0; c < rbtn.length; c++) {
          if (rbtn[c].checked) {
            kpi.KPIResult = rbtn[c].value;
          }



        }
        console.log(kpi);
        result.push(kpi);
        
      }

      var AppraisalResponse = {
        KPIs: result,
        EmpReview: $(""#empReview"").val(),
        AppraisalId: $(""#AppTemId"").val()
      }
      
      console.log(AppraisalResponse);

                  $.ajax({
              type: ""POST"",
              url: ""/EmployeeProfile/EmpAppResult"",
              data: JSON.stringify(AppraisalResponse),
              dataType: ""json"",
              contentType: 'application/json; charset=utf-8',
              headers: {
       ");
                WriteLiteral(@"         RequestVerificationToken:
                  $('input:hidden[name=""__RequestVerificationToken""]').val()
              },
              success: function (r) {

                if (r.msg == ""Success"") {

                          	swal({
                title: ""Success!"",
                text: ""Appraisal Saved!"",
                buttonsStyling: false,
                confirmButtonClass: ""btn btn-success"",
            type: ""success""
          }).then(function () {

            window.location.replace(""/EmployeeProfile/Performance"");

          }).catch(swal.noop);

                } else if (r.msg == ""Fail"") {

                  alert(r.msg);

                } else if (r.msg == ""No Data"") {
                  alert(r.msg);

                } else if (r.msg == ""Exceed"") {
                  alert(""Not Added. Total KPIs exceeds 100."");
                }
                //alert(r.msg);
                // window.location.reload();

              },
              error: funct");
                WriteLiteral(@"ion () {
                alert(r.msg);
              }
            });





    });

    $(""#btnFinish"").click(function (event) {

      var result = [];

      for (i = 0; i < radios.length; i++) {

        var eachrd = radios[i];
        var rbtn = document.getElementsByName(eachrd);
        var kpi = {
          KPIId: eachrd,
          KPIResult: ""0""
        }

        for (c = 0; c < rbtn.length; c++) {
          if (rbtn[c].checked) {
            kpi.KPIResult = rbtn[c].value;
          }



        }
        console.log(kpi);
        result.push(kpi);
        
      }

      var AppraisalResponse = {
        KPIs: result,
        EmpReview: $(""#empReview"").val(),
        AppraisalId: $(""#AppTemId"").val()
      }
      
      console.log(AppraisalResponse);

                  $.ajax({
              type: ""POST"",
              url: ""/EmployeeProfile/FinishAppResult"",
              data: JSON.stringify(AppraisalResponse),
              dataType: ""json"",
  ");
                WriteLiteral(@"            contentType: 'application/json; charset=utf-8',
              headers: {
                RequestVerificationToken:
                  $('input:hidden[name=""__RequestVerificationToken""]').val()
              },
              success: function (r) {

                if (r.msg == ""Success"") {

                          	swal({
                title: ""Success!"",
                text: ""Appraisal Submitted!"",
                buttonsStyling: false,
                confirmButtonClass: ""btn btn-success"",
            type: ""success""
          }).then(function () {

            window.location.replace(""/EmployeeProfile/Performance"");

          }).catch(swal.noop);



                } else if (r.msg == ""Fail"") {

                  alert(r.msg);

                } else if (r.msg == ""No Data"") {
                  alert(r.msg);

                } else if (r.msg == ""Exceed"") {
                  alert(""Not Added. Total KPIs exceeds 100."");
                }
                //alert");
                WriteLiteral("(r.msg);\r\n                // window.location.reload();\r\n\r\n              },\r\n              error: function () {\r\n                alert(r.msg);\r\n              }\r\n            });\r\n\r\n\r\n\r\n\r\n\r\n    });\r\n\r\n  });\r\n\r\n\r\n\r\n  </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<E4S.ViewModel.AppraisalViewTemplateViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
