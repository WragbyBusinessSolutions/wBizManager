#pragma checksum "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Employees\UploadEmployeeCSV.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f1fe56b93e61150b074a75af0476fa4d06e5f4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_UploadEmployeeCSV), @"mvc.1.0.view", @"/Views/Employees/UploadEmployeeCSV.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employees/UploadEmployeeCSV.cshtml", typeof(AspNetCore.Views_Employees_UploadEmployeeCSV))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f1fe56b93e61150b074a75af0476fa4d06e5f4e", @"/Views/Employees/UploadEmployeeCSV.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0d6bd66a948813bdfc09794c8b8e3a2f8caf788", @"/Views/_ViewImports.cshtml")]
    public class Views_Employees_UploadEmployeeCSV : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<E4S.ViewModel.NewEmployeeImport>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-md btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/plugins/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Employees\UploadEmployeeCSV.cshtml"
  
    ViewData["Title"] = "Upload Employee CSV";
    Layout = "~/Views/Shared/_LayoutHumanResouces.cshtml";

#line default
#line hidden
            BeginContext(168, 314, true);
            WriteLiteral(@"

<div class=""content"">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card"">
                <div class=""card-header"">
                    <h4 class=""card-title"">Upload Employee CSV</h4>
                </div>
                <div class=""card-body"">

                    ");
            EndContext();
            BeginContext(482, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d6582d1099b43ab91138f3a5f062a5d", async() => {
                BeginContext(532, 13, true);
                WriteLiteral("Back to Index");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(549, 880, true);
            WriteLiteral(@"
                    <div class=""card-body"">

                        <table id=""datatable"" class=""table table-striped table-bordered"" cellspacing=""0"" width=""100%"">
                            <thead class=""text-primary"">

                            <th class=""text-center"">
                                #
                            </th>
                            <th>
                                Job Title
                            </th>
                            <th>
                                Description
                            </th>
                            <th>
                                Gender
                            </th>
                            <th>
                                Department
                            </th>

                            </thead>

                            <tbody>
");
            EndContext();
#line 42 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Employees\UploadEmployeeCSV.cshtml"
                                  
                                    int i = 1;

                                    

#line default
#line hidden
#line 45 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Employees\UploadEmployeeCSV.cshtml"
                                     if (Model.Count() < 1)
                                    {


#line default
#line hidden
            BeginContext(1617, 253, true);
            WriteLiteral("                                    <td></td>\r\n                                    <td></td>\r\n                                    <td>No Data to Display</td>\r\n                                    <td></td>\r\n                                    <td></td>\r\n");
            EndContext();
#line 53 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Employees\UploadEmployeeCSV.cshtml"

                                }

#line default
#line hidden
#line 56 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Employees\UploadEmployeeCSV.cshtml"
                                     foreach (var item in Model)
                                    {


#line default
#line hidden
            BeginContext(2016, 166, true);
            WriteLiteral("                                        <tr>\r\n\r\n                                            <td class=\"text-center\">\r\n                                                ");
            EndContext();
            BeginContext(2183, 1, false);
#line 62 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Employees\UploadEmployeeCSV.cshtml"
                                           Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(2184, 153, true);
            WriteLiteral("\r\n                                            </td>\r\n\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(2338, 14, false);
#line 66 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Employees\UploadEmployeeCSV.cshtml"
                                           Write(item.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(2352, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(2504, 18, false);
#line 69 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Employees\UploadEmployeeCSV.cshtml"
                                           Write(item.EmployeeEmail);

#line default
#line hidden
            EndContext();
            BeginContext(2522, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(2674, 11, false);
#line 72 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Employees\UploadEmployeeCSV.cshtml"
                                           Write(item.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(2685, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(2837, 15, false);
#line 75 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Employees\UploadEmployeeCSV.cshtml"
                                           Write(item.Department);

#line default
#line hidden
            EndContext();
            BeginContext(2852, 102, true);
            WriteLiteral("\r\n                                            </td>\r\n\r\n                                        </tr>\r\n");
            EndContext();
#line 79 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Employees\UploadEmployeeCSV.cshtml"

                                        { i = i + 1; }
                                    }

#line default
#line hidden
            BeginContext(3086, 1627, true);
            WriteLiteral(@"
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



    <script>
        $(document).ready(function () {
            $('#datatable').DataTable({
                ""pagingType"": ""full_numbers"",
                ""lengthMenu"": [
                    [10, 25, 50, -1],
                    [10, 25, 50, ""All""]
                ],
                responsive: true,
                language: {
                    search: ""_INPUT_"",
                    searchPlaceholder: ""Search records"",
                }

            });

            var table = $('#datatable').DataTable();

            // Edit record
            table.on('click', '.edit', function () {
                $tr = $(this).closest('tr'");
            WriteLiteral(@");

                var data = table.row($tr).data();
                alert('You press on Row: ' + data[0] + ' ' + data[1] + ' ' + data[2] + '\'s row.');
            });

            // Delete a record
            table.on('click', '.remove', function (e) {
                $tr = $(this).closest('tr');
                table.row($tr).remove().draw();
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
            DefineSection("Scripts", async() => {
                BeginContext(4735, 79, true);
                WriteLiteral("\r\n\r\n        <!--  DataTables.net Plugin, full documentation here  -->\r\n        ");
                EndContext();
                BeginContext(4814, 68, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6a33cbb1f69468c93dab2a8e2a63135", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4882, 2, true);
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<E4S.ViewModel.NewEmployeeImport>> Html { get; private set; }
    }
}
#pragma warning restore 1591