#pragma checksum "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Languages\_EditTextModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb0236fb2d359251f9bc085019c088d6770dd8fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AppAreaName_Views_Languages__EditTextModal), @"mvc.1.0.view", @"/Areas/AppAreaName/Views/Languages/_EditTextModal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AppAreaName/Views/Languages/_EditTextModal.cshtml", typeof(AspNetCore.Areas_AppAreaName_Views_Languages__EditTextModal))]
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
#line 1 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Languages\_EditTextModal.cshtml"
using Abp.Extensions;

#line default
#line hidden
#line 2 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Languages\_EditTextModal.cshtml"
using GSoft.AbpZeroTemplate.Web.Areas.AppAreaName.Models.Common.Modals;

#line default
#line hidden
#line 3 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Languages\_EditTextModal.cshtml"
using GSoft.AbpZeroTemplate.Web.Areas.AppAreaName.Models.Languages;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb0236fb2d359251f9bc085019c088d6770dd8fd", @"/Areas/AppAreaName/Views/Languages/_EditTextModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eef59065c4b39f709eb64b90c2355595a8a2772", @"/Areas/AppAreaName/Views/_ViewImports.cshtml")]
    public class Areas_AppAreaName_Views_Languages__EditTextModal : GSoft.AbpZeroTemplate.Web.Views.AbpZeroTemplateRazorPage<EditTextModalViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("EditLanguageTextForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(192, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(194, 117, false);
#line 6 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Languages\_EditTextModal.cshtml"
Write(Html.Partial("~/Areas/AppAreaName/Views/Common/Modals/_ModalHeader.cshtml", new ModalHeaderViewModel(@L("EditText"))));

#line default
#line hidden
            EndContext();
            BeginContext(311, 31, true);
            WriteLiteral("\n\n<div class=\"modal-body\">\n    ");
            EndContext();
            BeginContext(342, 998, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc8e1db138da436c8dd53373b6cfff98", async() => {
                BeginContext(423, 48, true);
                WriteLiteral("\n\n        <input type=\"hidden\" name=\"SourceName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 471, "\"", 496, 1);
#line 11 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Languages\_EditTextModal.cshtml"
WriteAttributeValue("", 479, Model.SourceName, 479, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(497, 52, true);
                WriteLiteral(" />\n        <input type=\"hidden\" name=\"LanguageName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 549, "\"", 583, 1);
#line 12 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Languages\_EditTextModal.cshtml"
WriteAttributeValue("", 557, Model.TargetLanguage.Name, 557, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(584, 43, true);
                WriteLiteral(" />\n        <input type=\"hidden\" name=\"Key\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 627, "\"", 645, 1);
#line 13 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Languages\_EditTextModal.cshtml"
WriteAttributeValue("", 635, Model.Key, 635, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(646, 89, true);
                WriteLiteral(" />\n\n        <div class=\"form-group\">\n            <label for=\"BaseLanguageDisplayName\"><i");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 735, "\"", 767, 1);
#line 16 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Languages\_EditTextModal.cshtml"
WriteAttributeValue("", 743, Model.BaseLanguage.Icon, 743, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(768, 6, true);
                WriteLiteral("></i> ");
                EndContext();
                BeginContext(775, 30, false);
#line 16 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Languages\_EditTextModal.cshtml"
                                                                                     Write(Model.BaseLanguage.DisplayName);

#line default
#line hidden
                EndContext();
                BeginContext(805, 107, true);
                WriteLiteral(" </label>\n            <textarea id=\"BaseLanguageDisplayName\" readonly class=\"form-control edited\" rows=\"4\">");
                EndContext();
                BeginContext(913, 14, false);
#line 17 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Languages\_EditTextModal.cshtml"
                                                                                            Write(Model.BaseText);

#line default
#line hidden
                EndContext();
                BeginContext(927, 114, true);
                WriteLiteral("</textarea>\n        </div>\n\n        <div class=\"form-group\">\n            <label for=\"TargetLanguageDisplayName\"><i");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 1041, "\"", 1075, 1);
#line 21 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Languages\_EditTextModal.cshtml"
WriteAttributeValue("", 1049, Model.TargetLanguage.Icon, 1049, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1076, 6, true);
                WriteLiteral("></i> ");
                EndContext();
                BeginContext(1083, 32, false);
#line 21 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Languages\_EditTextModal.cshtml"
                                                                                         Write(Model.TargetLanguage.DisplayName);

#line default
#line hidden
                EndContext();
                BeginContext(1115, 86, true);
                WriteLiteral(" </label>\n            <textarea id=\"TargetLanguageDisplayName\" name=\"Value\" auto-focus");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 1201, "\"", 1273, 2);
                WriteAttributeValue("", 1209, "form-control", 1209, 12, true);
#line 22 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Languages\_EditTextModal.cshtml"
WriteAttributeValue(" ", 1221, Model.TargetText.IsNullOrEmpty() ? "" : "edited", 1222, 51, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1274, 10, true);
                WriteLiteral(" rows=\"4\">");
                EndContext();
                BeginContext(1285, 16, false);
#line 22 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Languages\_EditTextModal.cshtml"
                                                                                                                                                          Write(Model.TargetText);

#line default
#line hidden
                EndContext();
                BeginContext(1301, 32, true);
                WriteLiteral("</textarea>\n        </div>\n\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1340, 9, true);
            WriteLiteral("\n</div>\n\n");
            EndContext();
            BeginContext(1350, 92, false);
#line 28 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Languages\_EditTextModal.cshtml"
Write(Html.Partial("~/Areas/AppAreaName/Views/Common/Modals/_ModalFooterWithSaveAndCancel.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(1442, 1, true);
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EditTextModalViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
