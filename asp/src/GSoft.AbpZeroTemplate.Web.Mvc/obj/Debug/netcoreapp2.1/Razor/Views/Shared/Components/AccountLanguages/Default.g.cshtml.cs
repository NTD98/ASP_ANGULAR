#pragma checksum "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Shared\Components\AccountLanguages\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a57c7e18899761ecc10df49fae1bb2f3296d4f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AccountLanguages_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AccountLanguages/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/AccountLanguages/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_AccountLanguages_Default))]
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
#line 1 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Shared\Components\AccountLanguages\Default.cshtml"
using System.Text.Encodings.Web;

#line default
#line hidden
#line 2 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Shared\Components\AccountLanguages\Default.cshtml"
using GSoft.AbpZeroTemplate.Web.Views.Shared.Components.AccountLanguages;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a57c7e18899761ecc10df49fae1bb2f3296d4f4", @"/Views/Shared/Components/AccountLanguages/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eef59065c4b39f709eb64b90c2355595a8a2772", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_AccountLanguages_Default : GSoft.AbpZeroTemplate.Web.Views.AbpZeroTemplateRazorPage<LanguageSelectionViewModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Shared\Components\AccountLanguages\Default.cshtml"
 if (Model.Languages.Count > 1)
{

#line default
#line hidden
            BeginContext(175, 39, true);
            WriteLiteral("    <div class=\"language-switch-area\">\n");
            EndContext();
#line 7 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Shared\Components\AccountLanguages\Default.cshtml"
         foreach (var languageInfo in Model.Languages)
        {

#line default
#line hidden
            BeginContext(279, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(291, 417, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7895993e48944fdd9cdf0050d180aab0", async() => {
                BeginContext(457, 22, true);
                WriteLiteral("\n                <span");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 479, "\"", 582, 2);
                WriteAttributeValue("", 487, "language-icon", 487, 13, true);
#line 10 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Shared\Components\AccountLanguages\Default.cshtml"
WriteAttributeValue(" ", 500, languageInfo.Name == Model.CurrentLanguage.Name ? "language-icon-current" : "", 501, 81, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 583, "\"", 616, 1);
#line 10 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Shared\Components\AccountLanguages\Default.cshtml"
WriteAttributeValue("", 591, languageInfo.DisplayName, 591, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(617, 3, true);
                WriteLiteral("><i");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 620, "\"", 646, 1);
#line 10 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Shared\Components\AccountLanguages\Default.cshtml"
WriteAttributeValue("", 628, languageInfo.Icon, 628, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("aria-label", " aria-label=\"", 647, "\"", 678, 1);
#line 10 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Shared\Components\AccountLanguages\Default.cshtml"
WriteAttributeValue("", 660, languageInfo.Icon, 660, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(679, 25, true);
                WriteLiteral("></i></span>\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 300, "~/AbpLocalization/ChangeCulture?cultureName=", 300, 44, true);
#line 9 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Shared\Components\AccountLanguages\Default.cshtml"
AddHtmlAttributeValue("", 344, languageInfo.Name, 344, 20, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 364, "&returnUrl=", 364, 11, true);
#line 9 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Shared\Components\AccountLanguages\Default.cshtml"
AddHtmlAttributeValue("", 375, UrlEncoder.Default.Encode(Context.Request.Path + Context.Request.QueryString), 375, 80, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(708, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 12 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Shared\Components\AccountLanguages\Default.cshtml"
        }

#line default
#line hidden
            BeginContext(719, 11, true);
            WriteLiteral("    </div>\n");
            EndContext();
#line 14 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Shared\Components\AccountLanguages\Default.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LanguageSelectionViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
