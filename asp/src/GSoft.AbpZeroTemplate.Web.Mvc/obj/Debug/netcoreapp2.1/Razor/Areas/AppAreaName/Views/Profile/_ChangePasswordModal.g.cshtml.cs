#pragma checksum "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Profile\_ChangePasswordModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "743b51e22a66ab771d03affb63aaba444b144a71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AppAreaName_Views_Profile__ChangePasswordModal), @"mvc.1.0.view", @"/Areas/AppAreaName/Views/Profile/_ChangePasswordModal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AppAreaName/Views/Profile/_ChangePasswordModal.cshtml", typeof(AspNetCore.Areas_AppAreaName_Views_Profile__ChangePasswordModal))]
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
#line 1 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Profile\_ChangePasswordModal.cshtml"
using GSoft.AbpZeroTemplate.Web.Areas.AppAreaName.Models.Common.Modals;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"743b51e22a66ab771d03affb63aaba444b144a71", @"/Areas/AppAreaName/Views/Profile/_ChangePasswordModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eef59065c4b39f709eb64b90c2355595a8a2772", @"/Areas/AppAreaName/Views/_ViewImports.cshtml")]
    public class Areas_AppAreaName_Views_Profile__ChangePasswordModal : GSoft.AbpZeroTemplate.Web.Views.AbpZeroTemplateRazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("ChangePasswordModalForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("m-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(73, 122, false);
#line 2 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Profile\_ChangePasswordModal.cshtml"
Write(Html.Partial("~/Areas/AppAreaName/Views/Common/Modals/_ModalHeader.cshtml", new ModalHeaderViewModel(L("ChangePassword"))));

#line default
#line hidden
            EndContext();
            BeginContext(195, 31, true);
            WriteLiteral("\n\n<div class=\"modal-body\">\n    ");
            EndContext();
            BeginContext(226, 1109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8331fa7bacfb450ea9640dabd6995729", async() => {
                BeginContext(278, 75, true);
                WriteLiteral("\n        <div class=\"form-group\">\n            <label for=\"CurrentPassword\">");
                EndContext();
                BeginContext(354, 20, false);
#line 7 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Profile\_ChangePasswordModal.cshtml"
                                    Write(L("CurrentPassword"));

#line default
#line hidden
                EndContext();
                BeginContext(374, 136, true);
                WriteLiteral("</label>\n            <input id=\"CurrentPassword\" type=\"password\" autocomplete=\"off\" name=\"CurrentPassword\" class=\"form-control\" required");
                EndContext();
                BeginWriteAttribute("maxlength", " maxlength=\"", 510, "\"", 592, 1);
#line 8 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Profile\_ChangePasswordModal.cshtml"
WriteAttributeValue("", 522, GSoft.AbpZeroTemplate.Authorization.Users.User.MaxPlainPasswordLength, 522, 70, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(593, 41, true);
                WriteLiteral(">\n            <span class=\"m-form__help\">");
                EndContext();
                BeginContext(635, 155, false);
#line 9 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Profile\_ChangePasswordModal.cshtml"
                                  Write(Html.Raw(L("PasswordChangeDontRememberMessage", "<a href=\"" + Url.Action("ForgotPassword", "Account", new {area = ""}) + "\">" + L("ClickHere") + "</a>")));

#line default
#line hidden
                EndContext();
                BeginContext(790, 93, true);
                WriteLiteral("</span>\n        </div>\n        <div class=\"form-group\">\n            <label for=\"NewPassword\">");
                EndContext();
                BeginContext(884, 16, false);
#line 12 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Profile\_ChangePasswordModal.cshtml"
                                Write(L("NewPassword"));

#line default
#line hidden
                EndContext();
                BeginContext(900, 221, true);
                WriteLiteral("</label>\n            <input id=\"NewPassword\" type=\"password\" autocomplete=\"off\" name=\"NewPassword\" class=\"form-control\" required>\n        </div>\n        <div class=\"form-group\">\n            <label for=\"NewPasswordRepeat\">");
                EndContext();
                BeginContext(1122, 22, false);
#line 16 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Profile\_ChangePasswordModal.cshtml"
                                      Write(L("NewPasswordRepeat"));

#line default
#line hidden
                EndContext();
                BeginContext(1144, 184, true);
                WriteLiteral("</label>\n            <input id=\"NewPasswordRepeat\" type=\"password\" autocomplete=\"off\" name=\"NewPasswordRepeat\" class=\"form-control\" required equalto=\"#NewPassword\">\n        </div>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1335, 9, true);
            WriteLiteral("\n</div>\n\n");
            EndContext();
            BeginContext(1345, 92, false);
#line 22 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Profile\_ChangePasswordModal.cshtml"
Write(Html.Partial("~/Areas/AppAreaName/Views/Common/Modals/_ModalFooterWithSaveAndCancel.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(1437, 1, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
