#pragma checksum "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Consent\_ScopeListItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "829ea3acc3ee5d0515d5aae6c3caa43cb69077bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Consent__ScopeListItem), @"mvc.1.0.view", @"/Views/Consent/_ScopeListItem.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Consent/_ScopeListItem.cshtml", typeof(AspNetCore.Views_Consent__ScopeListItem))]
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
#line 1 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\_ViewImports.cshtml"
using Abp.Localization;

#line default
#line hidden
#line 1 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Consent\_ScopeListItem.cshtml"
using GSoft.AbpZeroTemplate.Web.Models.Consent;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"829ea3acc3ee5d0515d5aae6c3caa43cb69077bb", @"/Views/Consent/_ScopeListItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eef59065c4b39f709eb64b90c2355595a8a2772", @"/Views/_ViewImports.cshtml")]
    public class Views_Consent__ScopeListItem : GSoft.AbpZeroTemplate.Web.Views.AbpZeroTemplateRazorPage<ScopeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(70, 109, true);
            WriteLiteral("<li class=\"list-group-item\">\n    <label>\n        <input type=\"checkbox\"\n               name=\"ScopesConsented\"");
            EndContext();
            BeginWriteAttribute("id", "\n               id=\"", 179, "\"", 217, 2);
            WriteAttributeValue("", 199, "scopes_", 199, 7, true);
#line 7 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Consent\_ScopeListItem.cshtml"
WriteAttributeValue("", 206, Model.Name, 206, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("value", "\n               value=\"", 218, "\"", 252, 1);
#line 8 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Consent\_ScopeListItem.cshtml"
WriteAttributeValue("", 241, Model.Name, 241, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("checked", "\n               checked=\"", 253, "\"", 292, 1);
#line 9 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Consent\_ScopeListItem.cshtml"
WriteAttributeValue("", 278, Model.Checked, 278, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("disabled", "\n               disabled=\"", 293, "\"", 334, 1);
#line 10 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Consent\_ScopeListItem.cshtml"
WriteAttributeValue("", 319, Model.Required, 319, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(335, 5, true);
            WriteLiteral(" />\n\n");
            EndContext();
#line 12 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Consent\_ScopeListItem.cshtml"
         if (Model.Required)
        {

#line default
#line hidden
            BeginContext(379, 74, true);
            WriteLiteral("            <input type=\"hidden\"\n                   name=\"ScopesConsented\"");
            EndContext();
            BeginWriteAttribute("value", "\n                   value=\"", 453, "\"", 491, 1);
#line 16 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Consent\_ScopeListItem.cshtml"
WriteAttributeValue("", 480, Model.Name, 480, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(492, 4, true);
            WriteLiteral(" />\n");
            EndContext();
#line 17 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Consent\_ScopeListItem.cshtml"
        }

#line default
#line hidden
            BeginContext(506, 23, true);
            WriteLiteral("\n        <strong>&nbsp;");
            EndContext();
            BeginContext(530, 20, false);
#line 19 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Consent\_ScopeListItem.cshtml"
                 Write(L(Model.DisplayName));

#line default
#line hidden
            EndContext();
            BeginContext(550, 11, true);
            WriteLiteral("</strong>\n\n");
            EndContext();
#line 21 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Consent\_ScopeListItem.cshtml"
         if (Model.Emphasize)
        {

#line default
#line hidden
            BeginContext(601, 71, true);
            WriteLiteral("            <span class=\"glyphicon glyphicon-exclamation-sign\"></span>\n");
            EndContext();
#line 24 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Consent\_ScopeListItem.cshtml"
        }

#line default
#line hidden
            BeginContext(682, 15, true);
            WriteLiteral("\n    </label>\n\n");
            EndContext();
#line 28 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Consent\_ScopeListItem.cshtml"
     if (Model.Required)
    {

#line default
#line hidden
            BeginContext(728, 19, true);
            WriteLiteral("        <span><em>(");
            EndContext();
            BeginContext(748, 13, false);
#line 30 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Consent\_ScopeListItem.cshtml"
              Write(L("Required"));

#line default
#line hidden
            EndContext();
            BeginContext(761, 14, true);
            WriteLiteral(")</em></span>\n");
            EndContext();
#line 31 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Consent\_ScopeListItem.cshtml"
    }

#line default
#line hidden
            BeginContext(781, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 33 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Consent\_ScopeListItem.cshtml"
     if (Model.Description != null)
    {

#line default
#line hidden
            BeginContext(824, 32, true);
            WriteLiteral("        <div>\n            <label");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 856, "\"", 880, 2);
            WriteAttributeValue("", 862, "scopes_", 862, 7, true);
#line 36 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Consent\_ScopeListItem.cshtml"
WriteAttributeValue("", 869, Model.Name, 869, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(881, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(883, 20, false);
#line 36 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Consent\_ScopeListItem.cshtml"
                                       Write(L(Model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(903, 24, true);
            WriteLiteral("</label>\n        </div>\n");
            EndContext();
#line 38 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Consent\_ScopeListItem.cshtml"
    }

#line default
#line hidden
            BeginContext(933, 5, true);
            WriteLiteral("</li>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ScopeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
