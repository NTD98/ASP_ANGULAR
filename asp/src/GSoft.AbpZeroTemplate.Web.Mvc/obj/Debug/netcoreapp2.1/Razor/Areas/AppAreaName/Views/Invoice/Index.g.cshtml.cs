#pragma checksum "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Invoice\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03e18927661f5f742d0aa5f64cc1d7af276a2114"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AppAreaName_Views_Invoice_Index), @"mvc.1.0.view", @"/Areas/AppAreaName/Views/Invoice/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AppAreaName/Views/Invoice/Index.cshtml", typeof(AspNetCore.Areas_AppAreaName_Views_Invoice_Index))]
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
#line 1 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\_ViewImports.cshtml"
using Abp.Localization;

#line default
#line hidden
#line 1 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Invoice\Index.cshtml"
using GSoft.AbpZeroTemplate.Web.Areas.AppAreaName.Models.Accounting;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03e18927661f5f742d0aa5f64cc1d7af276a2114", @"/Areas/AppAreaName/Views/Invoice/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eef59065c4b39f709eb64b90c2355595a8a2772", @"/Areas/AppAreaName/Views/_ViewImports.cshtml")]
    public class Areas_AppAreaName_Views_Invoice_Index : GSoft.AbpZeroTemplate.Web.Views.AbpZeroTemplateRazorPage<InvoiceViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(93, 255, true);
            WriteLiteral("\n<div class=\"m-content\">\n    <div class=\"m-portlet\">\n        <div class=\"m-portlet__body m-portlet__body--no-padding\">\n\n            <div class=\"m-invoice-1\">\n                <div class=\"m-invoice__wrapper\">\n                    <div class=\"m-invoice__head\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 348, "\"", 420, 4);
            WriteAttributeValue("", 356, "background-image:", 356, 17, true);
            WriteAttributeValue(" ", 373, "url(", 374, 5, true);
#line 10 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Invoice\Index.cshtml"
WriteAttributeValue("", 378, ApplicationPath, 378, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 396, "Common/Images/bg-6.jpg);", 396, 24, true);
            EndWriteAttribute();
            BeginContext(421, 235, true);
            WriteLiteral(">\n                        <div class=\"m-invoice__container m-invoice__container--centered\">\n                            <div class=\"m-invoice__logo\">\n                                <a href=\"#\">\n                                    <h1>");
            EndContext();
            BeginContext(657, 12, false);
#line 14 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Invoice\Index.cshtml"
                                   Write(L("Invoice"));

#line default
#line hidden
            EndContext();
            BeginContext(669, 128, true);
            WriteLiteral("</h1>\n                                </a>\n                                <a href=\"#\">\n                                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 797, "\"", 843, 2);
#line 17 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Invoice\Index.cshtml"
WriteAttributeValue("", 803, ApplicationPath, 803, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 821, "Common/Images/logo.png", 821, 22, true);
            EndWriteAttribute();
            BeginContext(844, 165, true);
            WriteLiteral(">\n                                </a>\n                            </div>\n                            <span class=\"m-invoice__desc\">\n                                ");
            EndContext();
            BeginContext(1010, 27, false);
#line 21 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Invoice\Index.cshtml"
                           Write(Model.Invoice.HostLegalName);

#line default
#line hidden
            EndContext();
            BeginContext(1037, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 22 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Invoice\Index.cshtml"
                                 foreach (var line in Model.Invoice.HostAddress)
                                {

#line default
#line hidden
            BeginContext(1153, 42, true);
            WriteLiteral("                                    <br />");
            EndContext();
            BeginContext(1196, 4, false);
#line 24 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Invoice\Index.cshtml"
                                     Write(line);

#line default
#line hidden
            EndContext();
#line 24 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Invoice\Index.cshtml"
                                               
                                }

#line default
#line hidden
            BeginContext(1235, 227, true);
            WriteLiteral("                            </span>\n                            <div class=\"m-invoice__items\">\n                                <div class=\"m-invoice__item\">\n                                    <span class=\"m-invoice__subtitle\">");
            EndContext();
            BeginContext(1463, 9, false);
#line 29 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Invoice\Index.cshtml"
                                                                 Write(L("Date"));

#line default
#line hidden
            EndContext();
            BeginContext(1472, 74, true);
            WriteLiteral("</span>\n                                    <span class=\"m-invoice__text\">");
            EndContext();
            BeginContext(1547, 48, false);
#line 30 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Invoice\Index.cshtml"
                                                             Write(Model.Invoice.InvoiceDate.ToString("yyyy-MM-dd"));

#line default
#line hidden
            EndContext();
            BeginContext(1595, 179, true);
            WriteLiteral("</span>\n                                </div>\n                                <div class=\"m-invoice__item\">\n                                    <span class=\"m-invoice__subtitle\">");
            EndContext();
            BeginContext(1775, 12, false);
#line 33 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Invoice\Index.cshtml"
                                                                 Write(L("Invoice"));

#line default
#line hidden
            EndContext();
            BeginContext(1787, 75, true);
            WriteLiteral("</span>\n                                    <span class=\"m-invoice__text\">#");
            EndContext();
            BeginContext(1863, 23, false);
#line 34 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Invoice\Index.cshtml"
                                                              Write(Model.Invoice.InvoiceNo);

#line default
#line hidden
            EndContext();
            BeginContext(1886, 179, true);
            WriteLiteral("</span>\n                                </div>\n                                <div class=\"m-invoice__item\">\n                                    <span class=\"m-invoice__subtitle\">");
            EndContext();
            BeginContext(2066, 14, false);
#line 37 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Invoice\Index.cshtml"
                                                                 Write(L("InvoiceTo"));

#line default
#line hidden
            EndContext();
            BeginContext(2080, 115, true);
            WriteLiteral("</span>\n                                    <span class=\"m-invoice__text\">\n                                        ");
            EndContext();
            BeginContext(2196, 29, false);
#line 39 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Invoice\Index.cshtml"
                                   Write(Model.Invoice.TenantLegalName);

#line default
#line hidden
            EndContext();
            BeginContext(2225, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 40 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Invoice\Index.cshtml"
                                         foreach (var line in Model.Invoice.TenantAddress)
                                        {

#line default
#line hidden
            BeginContext(2359, 50, true);
            WriteLiteral("                                            <br />");
            EndContext();
            BeginContext(2410, 4, false);
#line 42 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Invoice\Index.cshtml"
                                             Write(line);

#line default
#line hidden
            EndContext();
#line 42 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Invoice\Index.cshtml"
                                                       
                                        }

#line default
#line hidden
            BeginContext(2457, 46, true);
            WriteLiteral("                                        <br />");
            EndContext();
            BeginContext(2504, 14, false);
#line 44 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Invoice\Index.cshtml"
                                         Write(L("Tax/VatNo"));

#line default
#line hidden
            EndContext();
            BeginContext(2518, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(2521, 25, false);
#line 44 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Invoice\Index.cshtml"
                                                          Write(Model.Invoice.TenantTaxNo);

#line default
#line hidden
            EndContext();
            BeginContext(2546, 555, true);
            WriteLiteral(@"
                                    </span>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""m-invoice__body m-invoice__body--centered"">
                        <div class=""table-responsive"">
                            <table class=""table"">
                                <thead>
                                    <tr>
                                        <th style=""width: 50px;"">#</th>
                                        <th>");
            EndContext();
            BeginContext(3102, 12, false);
#line 56 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Invoice\Index.cshtml"
                                       Write(L("Edition"));

#line default
#line hidden
            EndContext();
            BeginContext(3114, 72, true);
            WriteLiteral("</th>\n                                        <th style=\"width: 100px;\">");
            EndContext();
            BeginContext(3187, 11, false);
#line 57 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Invoice\Index.cshtml"
                                                             Write(L("Amount"));

#line default
#line hidden
            EndContext();
            BeginContext(3198, 265, true);
            WriteLiteral(@"</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>1</td>
                                        <td>");
            EndContext();
            BeginContext(3464, 32, false);
#line 63 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Invoice\Index.cshtml"
                                       Write(Model.Invoice.EditionDisplayName);

#line default
#line hidden
            EndContext();
            BeginContext(3496, 52, true);
            WriteLiteral(" </td>\n                                        <td>$");
            EndContext();
            BeginContext(3549, 20, false);
#line 64 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Invoice\Index.cshtml"
                                        Write(Model.Invoice.Amount);

#line default
#line hidden
            EndContext();
            BeginContext(3569, 526, true);
            WriteLiteral(@" </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                    <div class=""m-invoice__footer"">
                        <div class=""m-invoice__container m-invoice__container--centered"">
                            <div class=""m-invoice__content"">
                                <button type=""button"" class=""btn btn-primary d-print-none print-btn"" onclick=""javascript:window.print();"">");
            EndContext();
            BeginContext(4096, 10, false);
#line 73 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Invoice\Index.cshtml"
                                                                                                                                     Write(L("Print"));

#line default
#line hidden
            EndContext();
            BeginContext(4106, 144, true);
            WriteLiteral("</button>\n                            </div>\n                            <div class=\"m-invoice__content\">\n                                <span>");
            EndContext();
            BeginContext(4251, 10, false);
#line 76 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Invoice\Index.cshtml"
                                 Write(L("Total"));

#line default
#line hidden
            EndContext();
            BeginContext(4261, 72, true);
            WriteLiteral("</span>\n                                <span class=\"m-invoice__price\">$");
            EndContext();
            BeginContext(4334, 35, false);
#line 77 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Invoice\Index.cshtml"
                                                           Write(Model.Invoice.Amount.ToString("N2"));

#line default
#line hidden
            EndContext();
            BeginContext(4369, 221, true);
            WriteLiteral("</span>\n                                <span></span>\n                            </div>\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InvoiceViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
