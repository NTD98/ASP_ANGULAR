#pragma checksum "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Tenants\_CreateModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cea5f389dff312d20556c649b1731f50e7acb48a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AppAreaName_Views_Tenants__CreateModal), @"mvc.1.0.view", @"/Areas/AppAreaName/Views/Tenants/_CreateModal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AppAreaName/Views/Tenants/_CreateModal.cshtml", typeof(AspNetCore.Areas_AppAreaName_Views_Tenants__CreateModal))]
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
#line 1 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Tenants\_CreateModal.cshtml"
using Abp.Json;

#line default
#line hidden
#line 2 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Tenants\_CreateModal.cshtml"
using GSoft.AbpZeroTemplate.MultiTenancy;

#line default
#line hidden
#line 3 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Tenants\_CreateModal.cshtml"
using GSoft.AbpZeroTemplate.Web.Areas.AppAreaName.Models.Common.Modals;

#line default
#line hidden
#line 4 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Tenants\_CreateModal.cshtml"
using GSoft.AbpZeroTemplate.Web.Areas.AppAreaName.Models.Tenants;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cea5f389dff312d20556c649b1731f50e7acb48a", @"/Areas/AppAreaName/Views/Tenants/_CreateModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eef59065c4b39f709eb64b90c2355595a8a2772", @"/Areas/AppAreaName/Views/_ViewImports.cshtml")]
    public class Areas_AppAreaName_Views_Tenants__CreateModal : GSoft.AbpZeroTemplate.Web.Views.AbpZeroTemplateRazorPage<CreateTenantViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("TenantInformationsForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::GSoft.AbpZeroTemplate.Web.TagHelpers.AbpZeroTemplateScriptSrcTagHelper __GSoft_AbpZeroTemplate_Web_TagHelpers_AbpZeroTemplateScriptSrcTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(225, 130, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f827de6dd3034ba0af7c7b3c30370dd9", async() => {
                BeginContext(233, 40, true);
                WriteLiteral("\n    window.passwordComplexitySetting = ");
                EndContext();
                BeginContext(274, 70, false);
#line 7 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Tenants\_CreateModal.cshtml"
                                  Write(Html.Raw(Model.PasswordComplexitySetting.ToJsonString(indented: true)));

#line default
#line hidden
                EndContext();
                BeginContext(344, 2, true);
                WriteLiteral(";\n");
                EndContext();
            }
            );
            __GSoft_AbpZeroTemplate_Web_TagHelpers_AbpZeroTemplateScriptSrcTagHelper = CreateTagHelper<global::GSoft.AbpZeroTemplate.Web.TagHelpers.AbpZeroTemplateScriptSrcTagHelper>();
            __tagHelperExecutionContext.Add(__GSoft_AbpZeroTemplate_Web_TagHelpers_AbpZeroTemplateScriptSrcTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(355, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(357, 123, false);
#line 9 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Tenants\_CreateModal.cshtml"
Write(Html.Partial("~/Areas/AppAreaName/Views/Common/Modals/_ModalHeader.cshtml", new ModalHeaderViewModel(L("CreateNewTenant"))));

#line default
#line hidden
            EndContext();
            BeginContext(480, 31, true);
            WriteLiteral("\n\n<div class=\"modal-body\">\n    ");
            EndContext();
            BeginContext(511, 5005, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5129268125554818bf51a0c14ad5693c", async() => {
                BeginContext(547, 71, true);
                WriteLiteral("\n        <div class=\"form-group\">\n            <label for=\"TenancyName\">");
                EndContext();
                BeginContext(619, 16, false);
#line 14 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Tenants\_CreateModal.cshtml"
                                Write(L("TenancyName"));

#line default
#line hidden
                EndContext();
                BeginContext(635, 105, true);
                WriteLiteral("</label>\n            <input id=\"TenancyName\" class=\"form-control\" type=\"text\" name=\"TenancyName\" required");
                EndContext();
                BeginWriteAttribute("maxlength", " maxlength=\"", 740, "\"", 780, 1);
#line 15 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Tenants\_CreateModal.cshtml"
WriteAttributeValue("", 752, Tenant.MaxTenancyNameLength, 752, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("regex", " regex=\"", 781, "\"", 813, 1);
#line 15 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Tenants\_CreateModal.cshtml"
WriteAttributeValue("", 789, Tenant.TenancyNameRegex, 789, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(814, 89, true);
                WriteLiteral(">\n        </div>\n\n        <div class=\"form-group no-hint\">\n            <label for=\"Name\">");
                EndContext();
                BeginContext(904, 9, false);
#line 19 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Tenants\_CreateModal.cshtml"
                         Write(L("Name"));

#line default
#line hidden
                EndContext();
                BeginContext(913, 91, true);
                WriteLiteral("</label>\n            <input id=\"Name\" type=\"text\" name=\"Name\" class=\"form-control\" required");
                EndContext();
                BeginWriteAttribute("maxlength", " maxlength=\"", 1004, "\"", 1037, 1);
#line 20 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Tenants\_CreateModal.cshtml"
WriteAttributeValue("", 1016, Tenant.MaxNameLength, 1016, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1038, 227, true);
                WriteLiteral(">\n        </div>\n\n        <div class=\"m-checkbox-list\">\n            <label class=\"m-checkbox\">\n                <input id=\"CreateTenant_UseHostDb\" type=\"checkbox\" name=\"UseHostDb\" value=\"true\" checked=\"checked\">\n                ");
                EndContext();
                BeginContext(1266, 20, false);
#line 26 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Tenants\_CreateModal.cshtml"
           Write(L("UseHostDatabase"));

#line default
#line hidden
                EndContext();
                BeginContext(1286, 173, true);
                WriteLiteral("\n                <span></span>\n            </label>\n        </div>\n\n        <div class=\"form-group no-hint\" style=\"display: none\">\n            <label for=\"ConnectionString\">");
                EndContext();
                BeginContext(1460, 29, false);
#line 32 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Tenants\_CreateModal.cshtml"
                                     Write(L("DatabaseConnectionString"));

#line default
#line hidden
                EndContext();
                BeginContext(1489, 115, true);
                WriteLiteral("</label>\n            <input id=\"ConnectionString\" type=\"text\" name=\"ConnectionString\" class=\"form-control\" required");
                EndContext();
                BeginWriteAttribute("maxlength", " maxlength=\"", 1604, "\"", 1649, 1);
#line 33 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Tenants\_CreateModal.cshtml"
WriteAttributeValue("", 1616, Tenant.MaxConnectionStringLength, 1616, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1650, 94, true);
                WriteLiteral(">\n        </div>\n\n        <div class=\"form-group\">\n            <label for=\"AdminEmailAddress\">");
                EndContext();
                BeginContext(1745, 22, false);
#line 37 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Tenants\_CreateModal.cshtml"
                                      Write(L("AdminEmailAddress"));

#line default
#line hidden
                EndContext();
                BeginContext(1767, 118, true);
                WriteLiteral("</label>\n            <input id=\"AdminEmailAddress\" type=\"email\" name=\"AdminEmailAddress\" class=\"form-control\" required");
                EndContext();
                BeginWriteAttribute("maxlength", " maxlength=\"", 1885, "\"", 1966, 1);
#line 38 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Tenants\_CreateModal.cshtml"
WriteAttributeValue("", 1897, GSoft.AbpZeroTemplate.Authorization.Users.User.MaxEmailAddressLength, 1897, 69, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1967, 245, true);
                WriteLiteral(">\n        </div>\n\n        <div class=\"m-checkbox-list\">\n            <label class=\"m-checkbox\">\n                <input id=\"CreateTenant_SetRandomPassword\" type=\"checkbox\" name=\"SetRandomPassword\" value=\"true\" checked=\"checked\" />\n                ");
                EndContext();
                BeginContext(2213, 22, false);
#line 44 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Tenants\_CreateModal.cshtml"
           Write(L("SetRandomPassword"));

#line default
#line hidden
                EndContext();
                BeginContext(2235, 205, true);
                WriteLiteral("\n                <span></span>\n            </label>\n        </div>\n\n        <div class=\"form-group no-hint tenant-admin-password\" style=\"display: none\">\n            <label for=\"CreateTenant_AdminPassword\">");
                EndContext();
                BeginContext(2441, 13, false);
#line 50 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Tenants\_CreateModal.cshtml"
                                               Write(L("Password"));

#line default
#line hidden
                EndContext();
                BeginContext(2454, 117, true);
                WriteLiteral("</label>\n            <input id=\"CreateTenant_AdminPassword\" type=\"password\" name=\"AdminPassword\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("maxlength", " maxlength=\"", 2571, "\"", 2653, 1);
#line 51 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Tenants\_CreateModal.cshtml"
WriteAttributeValue("", 2583, GSoft.AbpZeroTemplate.Authorization.Users.User.MaxPlainPasswordLength, 2583, 70, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2654, 159, true);
                WriteLiteral(" autocomplete=\"off\">\n        </div>\n\n        <div class=\"form-group tenant-admin-password\" style=\"display: none\">\n            <label for=\"AdminPasswordRepeat\">");
                EndContext();
                BeginContext(2814, 19, false);
#line 55 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Tenants\_CreateModal.cshtml"
                                        Write(L("PasswordRepeat"));

#line default
#line hidden
                EndContext();
                BeginContext(2833, 116, true);
                WriteLiteral("</label>\n            <input id=\"AdminPasswordRepeat\" type=\"password\" name=\"AdminPasswordRepeat\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("maxlength", " maxlength=\"", 2949, "\"", 3031, 1);
#line 56 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Tenants\_CreateModal.cshtml"
WriteAttributeValue("", 2961, GSoft.AbpZeroTemplate.Authorization.Users.User.MaxPlainPasswordLength, 2961, 70, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3032, 151, true);
                WriteLiteral(" equalto=\"#CreateTenant_AdminPassword\" autocomplete=\"off\">\n        </div>\n\n        <div class=\"form-group no-hint\">\n            <label for=\"EditionId\">");
                EndContext();
                BeginContext(3184, 12, false);
#line 60 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Tenants\_CreateModal.cshtml"
                              Write(L("Edition"));

#line default
#line hidden
                EndContext();
                BeginContext(3196, 83, true);
                WriteLiteral("</label>\n            <select class=\"form-control\" id=\"EditionId\" name=\"EditionId\">\n");
                EndContext();
#line 62 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Tenants\_CreateModal.cshtml"
                 foreach (var edition in Model.EditionItems)
                {

#line default
#line hidden
                BeginContext(3358, 20, true);
                WriteLiteral("                    ");
                EndContext();
                BeginContext(3378, 90, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee9d020b2a6b419f84d8ee33a6af2803", async() => {
                    BeginContext(3440, 19, false);
#line 64 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Tenants\_CreateModal.cshtml"
                                                                            Write(edition.DisplayText);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 64 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Tenants\_CreateModal.cshtml"
                       WriteLiteral(edition.Value);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 64 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Tenants\_CreateModal.cshtml"
                                                           Write(edition.IsFree);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("data-isfree", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3468, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 65 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Tenants\_CreateModal.cshtml"
                }

#line default
#line hidden
                BeginContext(3487, 276, true);
                WriteLiteral(@"            </select>
        </div>

        <div class=""m-checkbox-list subscription-component"">
            <label for=""CreateTenant_IsUnlimited"" class=""m-checkbox"">
                <input id=""CreateTenant_IsUnlimited"" type=""checkbox"" name=""IsUnlimited"" />
                ");
                EndContext();
                BeginContext(3764, 30, false);
#line 72 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Tenants\_CreateModal.cshtml"
           Write(L("UnlimitedTimeSubscription"));

#line default
#line hidden
                EndContext();
                BeginContext(3794, 172, true);
                WriteLiteral("\n                <span></span>\n            </label>\n        </div>\n\n        <div class=\"form-group subscription-component\">\n            <label for=\"SubscriptionEndDateUtc\">");
                EndContext();
                BeginContext(3967, 27, false);
#line 78 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Tenants\_CreateModal.cshtml"
                                           Write(L("SubscriptionEndDateUtc"));

#line default
#line hidden
                EndContext();
                BeginContext(3994, 446, true);
                WriteLiteral(@"</label>
            <input id=""SubscriptionEndDateUtc"" type=""datetime"" name=""SubscriptionEndDateUtc"" class=""form-control date-time-picker"" required>
        </div>

        <div class=""m-checkbox-list subscription-component"">
            <label for=""CreateTenant_IsInTrialPeriod"" class=""m-checkbox"">
                <input id=""CreateTenant_IsInTrialPeriod"" class=""md-check"" type=""checkbox"" name=""IsInTrialPeriod"" value=""true"" />
                ");
                EndContext();
                BeginContext(4441, 20, false);
#line 85 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Tenants\_CreateModal.cshtml"
           Write(L("IsInTrialPeriod"));

#line default
#line hidden
                EndContext();
                BeginContext(4461, 372, true);
                WriteLiteral(@"
                <span></span>
            </label>
        </div>

        <div class=""m-checkbox-list"">
            <label for=""CreateTenant_ShouldChangePasswordOnNextLogin"" class=""m-checkbox"">
                <input id=""CreateTenant_ShouldChangePasswordOnNextLogin"" type=""checkbox"" name=""ShouldChangePasswordOnNextLogin"" value=""true"" checked=""checked"">
                ");
                EndContext();
                BeginContext(4834, 36, false);
#line 93 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Tenants\_CreateModal.cshtml"
           Write(L("ShouldChangePasswordOnNextLogin"));

#line default
#line hidden
                EndContext();
                BeginContext(4870, 282, true);
                WriteLiteral(@"
                <span></span>
            </label>
            <label for=""CreateTenant_SendActivationEmail"" class=""m-checkbox"">
                <input id=""CreateTenant_SendActivationEmail"" type=""checkbox"" name=""SendActivationEmail"" value=""true"" checked=""checked"">
                ");
                EndContext();
                BeginContext(5153, 24, false);
#line 98 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Tenants\_CreateModal.cshtml"
           Write(L("SendActivationEmail"));

#line default
#line hidden
                EndContext();
                BeginContext(5177, 249, true);
                WriteLiteral("\n                <span></span>\n            </label>\n            <label for=\"CreateTenant_IsActive\" class=\"m-checkbox\">\n                <input id=\"CreateTenant_IsActive\" type=\"checkbox\" name=\"IsActive\" value=\"true\" checked=\"checked\">\n                ");
                EndContext();
                BeginContext(5427, 11, false);
#line 103 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Tenants\_CreateModal.cshtml"
           Write(L("Active"));

#line default
#line hidden
                EndContext();
                BeginContext(5438, 71, true);
                WriteLiteral("\n                <span></span>\n            </label>\n        </div>\n    ");
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
            BeginContext(5516, 9, true);
            WriteLiteral("\n</div>\n\n");
            EndContext();
            BeginContext(5526, 92, false);
#line 110 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Tenants\_CreateModal.cshtml"
Write(Html.Partial("~/Areas/AppAreaName/Views/Common/Modals/_ModalFooterWithSaveAndCancel.cshtml"));

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CreateTenantViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
