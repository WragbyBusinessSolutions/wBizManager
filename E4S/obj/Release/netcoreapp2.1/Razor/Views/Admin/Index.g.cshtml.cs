#pragma checksum "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b8a1a962ec7f0e322f987ad0ea92309496bd76a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Index.cshtml", typeof(AspNetCore.Views_Admin_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b8a1a962ec7f0e322f987ad0ea92309496bd76a", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0d6bd66a948813bdfc09794c8b8e3a2f8caf788", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Elijah\source\repos\wBizManager\E4S\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Wragby Admin";
    Layout = "~/Views/Shared/_LayoutWragbyAdmin.cshtml";

#line default
#line hidden
            BeginContext(108, 8185, true);
            WriteLiteral(@"

<style>

    .body-card {
        padding-left: 2%;
        padding-right: 2%;
        padding-top: 1%;
        padding-bottom: 2%;
    }
</style>



<div class=""content"">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card card-stats card-raised"">
                <div class=""card-body"">
                    <div class=""row"">

                        <div class=""col-md-4"">
                            <div class=""statistics"">
                                <div class=""info"">
                                    <div class=""icon icon-danger"">
                                        <i class=""now-ui-icons objects_support-17""></i>
                                    </div>
                                    <h3 class=""info-title"">353</h3>
                                    <h6 class=""stats-title"">Support Requests</h6>
                                </div>
                            </div>
                        </div>

                        <");
            WriteLiteral(@"div class=""col-md-4"">
                            <div class=""statistics"">
                                <div class=""info"">
                                    <div class=""icon icon-info"">
                                        <i class=""now-ui-icons users_single-02""></i>
                                    </div>
                                    <h3 class=""info-title"">562</h3>
                                    <h6 class=""stats-title"">Organisations</h6>
                                </div>
                            </div>
                        </div>

                        <div class=""col-md-4"">
                            <div class=""statistics"">
                                <div class=""info"">
                                    <div class=""icon icon-success"">
                                        <i class=""now-ui-icons shopping_tag-content""></i>
                                    </div>
                                    <h3 class=""info-title"">
                     ");
            WriteLiteral(@"                   3,521
                                    </h3>
                                    <h6 class=""stats-title"">Total Licenses</h6>
                                </div>
                            </div>
                        </div>


                    </div>
                </div>
            </div>
        </div>
    </div>


    <div class=""row"">
        <div class=""col-md-6"">
            <div class=""card body-card"">
                <div class=""card-header"">
                    <h4 class=""card-title"">Company Listing</h4>
                    <p class=""category"">List of organizations</p>
                </div>
                <div class=""card-body"">
                    <div class=""table"">
                        <table class=""table"">
                            <thead class="" text-primary"">
                                <tr>
                                    <th>
                                        Organisation Name
                                   ");
            WriteLiteral(@" </th>
                                    <th class=""text-center"">
                                        Total License
                                    </th>

                                    <th class=""pull-right"">
                                        Action
                                    </th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>
                                        Wragby Business Solutions
                                    </td>

                                    <td class=""text-center"">019</td>

                                    <td>
                                        <button class=""btn btn-primary pull-right"">View Details</button>
                                    </td>

                                </tr>
                                <tr>
                                    <td>
            ");
            WriteLiteral(@"                            Wragby Business Solutions
                                    </td>

                                    <td class=""text-center"">019</td>

                                    <td>
                                        <button class=""btn btn-primary pull-right"">View Details</button>
                                    </td>

                                </tr>

                                <tr>
                                    <td>
                                        Wragby Business Solutions
                                    </td>

                                    <td class=""text-center"">019</td>

                                    <td>
                                        <button class=""btn btn-primary pull-right"">View Details</button>
                                    </td>

                                </tr>
                            </tbody>
                        </table>
                        <div>
                   ");
            WriteLiteral(@"         <a href=""#"" class=""pull-right"">View more...</a>
                        </div>

                    </div>
                </div>
            </div>
        </div>

        <div class=""col-md-6"">
            <div class=""card body-card"">
                <div class=""card-header"">
                    <h4 class=""card-title"">Company Listing</h4>
                    <p class=""category"">List of organizations</p>
                </div>
                <div class=""card-body"">
                    <div class=""table"">
                        <table class=""table"">
                            <thead class="" text-primary"">
                                <tr>
                                    <th>
                                        Organisation Name
                                    </th>
                                    <th class=""text-center"">
                                        Total License
                                    </th>

                                    <");
            WriteLiteral(@"th class=""pull-right"">
                                        Action
                                    </th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>
                                        Wragby Business Solutions
                                    </td>

                                    <td class=""text-center"">019</td>

                                    <td>
                                        <button class=""btn btn-primary pull-right"">View Details</button>
                                    </td>

                                </tr>
                                <tr>
                                    <td>
                                        Wragby Business Solutions
                                    </td>

                                    <td class=""text-center"">019</td>

                                   ");
            WriteLiteral(@" <td>
                                        <button class=""btn btn-primary pull-right"">View Details</button>
                                    </td>

                                </tr>

                                <tr>
                                    <td>
                                        Wragby Business Solutions
                                    </td>

                                    <td class=""text-center"">019</td>

                                    <td>
                                        <button class=""btn btn-primary pull-right"">View Details</button>
                                    </td>

                                </tr>
                            </tbody>
                        </table>
                        <div>
                            <a href=""#"" class=""pull-right"">View more...</a>
                        </div>

                    </div>
                </div>
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
