#pragma checksum "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Profile\_ChangePictureModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9817dc4730a5526db4a85bf79de9bcfa58deb177"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AppAreaName_Views_Profile__ChangePictureModal), @"mvc.1.0.view", @"/Areas/AppAreaName/Views/Profile/_ChangePictureModal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AppAreaName/Views/Profile/_ChangePictureModal.cshtml", typeof(AspNetCore.Areas_AppAreaName_Views_Profile__ChangePictureModal))]
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
#line 1 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Profile\_ChangePictureModal.cshtml"
using GSoft.AbpZeroTemplate;

#line default
#line hidden
#line 2 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Profile\_ChangePictureModal.cshtml"
using GSoft.AbpZeroTemplate.Web.Areas.AppAreaName.Models.Common.Modals;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9817dc4730a5526db4a85bf79de9bcfa58deb177", @"/Areas/AppAreaName/Views/Profile/_ChangePictureModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eef59065c4b39f709eb64b90c2355595a8a2772", @"/Areas/AppAreaName/Views/_ViewImports.cshtml")]
    public class Areas_AppAreaName_Views_Profile__ChangePictureModal : GSoft.AbpZeroTemplate.Web.Views.AbpZeroTemplateRazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("ChangeProfilePictureModalForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(102, 128, false);
#line 3 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Profile\_ChangePictureModal.cshtml"
Write(Html.Partial("~/Areas/AppAreaName/Views/Common/Modals/_ModalHeader.cshtml", new ModalHeaderViewModel(L("ChangeProfilePicture"))));

#line default
#line hidden
            EndContext();
            BeginContext(230, 31, true);
            WriteLiteral("\n\n<div class=\"modal-body\">\n    ");
            EndContext();
            BeginContext(261, 368, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "743db08b9fc94d77bd9fbbb990927fb7", async() => {
                BeginContext(377, 136, true);
                WriteLiteral("\n        <div class=\"form-group\">\n            <input type=\"file\" name=\"ProfilePicture\" />\n            <span class=\"help-block m-b-none\">");
                EndContext();
                BeginContext(514, 81, false);
#line 9 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Profile\_ChangePictureModal.cshtml"
                                         Write(L("ProfilePicture_Change_Info", AppConsts.MaxProfilPictureBytesUserFriendlyValue));

#line default
#line hidden
                EndContext();
                BeginContext(595, 27, true);
                WriteLiteral("</span>\n        </div>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 6 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Profile\_ChangePictureModal.cshtml"
AddHtmlAttributeValue("", 324, ApplicationPath + "Profile/UploadProfilePicture", 324, 51, false);

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
            BeginContext(629, 54, true);
            WriteLiteral("\n    <img id=\"ProfilePictureResize\" src=\"\" />\n</div>\n\n");
            EndContext();
            BeginContext(684, 92, false);
#line 15 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Profile\_ChangePictureModal.cshtml"
Write(Html.Partial("~/Areas/AppAreaName/Views/Common/Modals/_ModalFooterWithSaveAndCancel.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(776, 1, true);
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
