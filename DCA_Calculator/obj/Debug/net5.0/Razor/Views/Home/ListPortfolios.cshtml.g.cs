#pragma checksum "G:\ASP_féléves\DCA_Calculator\DCA_Calculator\Views\Home\ListPortfolios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68ae7bfb75bc657f222b838a038f6884da69e30f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ListPortfolios), @"mvc.1.0.view", @"/Views/Home/ListPortfolios.cshtml")]
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
#nullable restore
#line 1 "G:\ASP_féléves\DCA_Calculator\DCA_Calculator\Views\_ViewImports.cshtml"
using DCA_Calculator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\ASP_féléves\DCA_Calculator\DCA_Calculator\Views\_ViewImports.cshtml"
using DCA_Calculator.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68ae7bfb75bc657f222b838a038f6884da69e30f", @"/Views/Home/ListPortfolios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3d20c729895cc469123c2a4d1bab35c23776933", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ListPortfolios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DCA_Calculator.Models.Portfolio>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\ASP_féléves\DCA_Calculator\DCA_Calculator\Views\Home\ListPortfolios.cshtml"
  
    ViewData["Title"] = "ListPortfolios";
    int i = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 9 "G:\ASP_féléves\DCA_Calculator\DCA_Calculator\Views\Home\ListPortfolios.cshtml"
 if (Model == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>Nothing to show!</h4>\r\n");
#nullable restore
#line 12 "G:\ASP_féléves\DCA_Calculator\DCA_Calculator\Views\Home\ListPortfolios.cshtml"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "G:\ASP_féléves\DCA_Calculator\DCA_Calculator\Views\Home\ListPortfolios.cshtml"
     foreach (var portfolio in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <button class=\"accordion accordion-radius\">");
#nullable restore
#line 17 "G:\ASP_féléves\DCA_Calculator\DCA_Calculator\Views\Home\ListPortfolios.cshtml"
                                              Write(Html.DisplayFor(p => portfolio.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n        <div class=\"panel panel-center\">\r\n            <div class=\"container\">\r\n                <div class=\"row\">\r\n                    <div class=\"col\">\r\n");
#nullable restore
#line 22 "G:\ASP_féléves\DCA_Calculator\DCA_Calculator\Views\Home\ListPortfolios.cshtml"
                         if (portfolio.Bags.Count() == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>There aren\'t any bag added yet.</p>\r\n");
#nullable restore
#line 25 "G:\ASP_féléves\DCA_Calculator\DCA_Calculator\Views\Home\ListPortfolios.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <table class=""table"">
                                <thead>
                                    <tr class=""table-primary"">
                                        <th scope=""col"">#</th>
                                        <th scope=""col"">Name of bag</th>
                                        <th scope=""col"">Coin</th>
                                        <th scope=""col"">FIAT</th>
                                        <th scope=""col"">Details</th>
                                        <th scope=""col"">Current value of bag</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 40 "G:\ASP_féléves\DCA_Calculator\DCA_Calculator\Views\Home\ListPortfolios.cshtml"
                                     foreach (var item in portfolio.Bags)
                                    {
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr class=\"table-info\">\r\n                                            <th scope=\"row\">");
#nullable restore
#line 44 "G:\ASP_féléves\DCA_Calculator\DCA_Calculator\Views\Home\ListPortfolios.cshtml"
                                                        Write(i++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 46 "G:\ASP_féléves\DCA_Calculator\DCA_Calculator\Views\Home\ListPortfolios.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 49 "G:\ASP_féléves\DCA_Calculator\DCA_Calculator\Views\Home\ListPortfolios.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.CryptoCoin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 52 "G:\ASP_féléves\DCA_Calculator\DCA_Calculator\Views\Home\ListPortfolios.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.FIAT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 55 "G:\ASP_féléves\DCA_Calculator\DCA_Calculator\Views\Home\ListPortfolios.cshtml"
                                           Write(Html.ActionLink("Show details", "ShowBag", new { uid = item.BagId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </td>
                                            <td>
                                                5213213
                                            </td>
                                        </tr>
");
#nullable restore
#line 61 "G:\ASP_féléves\DCA_Calculator\DCA_Calculator\Views\Home\ListPortfolios.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n");
#nullable restore
#line 64 "G:\ASP_féléves\DCA_Calculator\DCA_Calculator\Views\Home\ListPortfolios.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <div class=\"col\">\r\n                        ");
#nullable restore
#line 67 "G:\ASP_féléves\DCA_Calculator\DCA_Calculator\Views\Home\ListPortfolios.cshtml"
                   Write(Html.ActionLink("Add bag(s) to this portfolio", "ListBags"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                        ");
#nullable restore
#line 68 "G:\ASP_féléves\DCA_Calculator\DCA_Calculator\Views\Home\ListPortfolios.cshtml"
                   Write(Html.ActionLink("Delete portfolio", "DeletePortfolio", new { uid = portfolio.PortfolioId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                        ");
#nullable restore
#line 69 "G:\ASP_féléves\DCA_Calculator\DCA_Calculator\Views\Home\ListPortfolios.cshtml"
                   Write(Html.ActionLink("Edit portfolio", "EditPortfolio", new { uid = portfolio.PortfolioId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 74 "G:\ASP_féléves\DCA_Calculator\DCA_Calculator\Views\Home\ListPortfolios.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "G:\ASP_féléves\DCA_Calculator\DCA_Calculator\Views\Home\ListPortfolios.cshtml"
     
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DCA_Calculator.Models.Portfolio>> Html { get; private set; }
    }
}
#pragma warning restore 1591
