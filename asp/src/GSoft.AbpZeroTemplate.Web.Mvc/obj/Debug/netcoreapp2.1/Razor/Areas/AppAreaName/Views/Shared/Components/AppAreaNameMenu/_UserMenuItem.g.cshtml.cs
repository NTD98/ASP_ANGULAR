#pragma checksum "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Shared\Components\AppAreaNameMenu\_UserMenuItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4f89c11df868a683f22054d4f6bd66dec500b35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AppAreaName_Views_Shared_Components_AppAreaNameMenu__UserMenuItem), @"mvc.1.0.view", @"/Areas/AppAreaName/Views/Shared/Components/AppAreaNameMenu/_UserMenuItem.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AppAreaName/Views/Shared/Components/AppAreaNameMenu/_UserMenuItem.cshtml", typeof(AspNetCore.Areas_AppAreaName_Views_Shared_Components_AppAreaNameMenu__UserMenuItem))]
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
#line 1 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Shared\Components\AppAreaNameMenu\_UserMenuItem.cshtml"
using Abp.Collections.Extensions;

#line default
#line hidden
#line 2 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Shared\Components\AppAreaNameMenu\_UserMenuItem.cshtml"
using GSoft.AbpZeroTemplate.Web.Areas.AppAreaName.Views.Shared.Components.AppAreaNameSideBar;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4f89c11df868a683f22054d4f6bd66dec500b35", @"/Areas/AppAreaName/Views/Shared/Components/AppAreaNameMenu/_UserMenuItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eef59065c4b39f709eb64b90c2355595a8a2772", @"/Areas/AppAreaName/Views/_ViewImports.cshtml")]
    public class Areas_AppAreaName_Views_Shared_Components_AppAreaNameMenu__UserMenuItem : GSoft.AbpZeroTemplate.Web.Views.AbpZeroTemplateRazorPage<UserMenuItemViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(157, 4, true);
            WriteLiteral("\n<li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 161, "\"", 426, 4);
            WriteAttributeValue("", 169, "m-menu__item", 169, 12, true);
            WriteAttributeValue(" ", 181, "m-menu__item--submenu", 182, 22, true);
#line 5 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Shared\Components\AppAreaNameMenu\_UserMenuItem.cshtml"
WriteAttributeValue(" ", 203, Model.MenuItem.IsMenuActive(Model.CurrentPageName) ? "m-menu__item--active" : "", 204, 83, false);

#line default
#line hidden
#line 5 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Shared\Components\AppAreaNameMenu\_UserMenuItem.cshtml"
WriteAttributeValue(" ", 287, Model.MenuItem.IsMenuActive(Model.CurrentPageName) && Model.MenuItem.Items.Count > 0 ? "m-menu__item--expanded m-menu__item--open" : "", 288, 138, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(427, 32, true);
            WriteLiteral(" \n    aria-haspopup=\"true\" \n    ");
            EndContext();
            BeginContext(461, 35, false);
#line 7 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Shared\Components\AppAreaNameMenu\_UserMenuItem.cshtml"
Write(Model.RootLevel ? "" : " role=none");

#line default
#line hidden
            EndContext();
            BeginContext(497, 39, true);
            WriteLiteral("\n    data-menu-submenu-toggle=\"hover\">\n");
            EndContext();
#line 9 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Shared\Components\AppAreaNameMenu\_UserMenuItem.cshtml"
     if (Model.MenuItem.Items.IsNullOrEmpty())
    {
        if (string.IsNullOrEmpty(Model.MenuItem.Target))
        {
            Model.MenuItem.Target = "_self";
        }

#line default
#line hidden
            BeginContext(711, 10, true);
            WriteLiteral("        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 721, "\"", 773, 1);
#line 15 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Shared\Components\AppAreaNameMenu\_UserMenuItem.cshtml"
WriteAttributeValue("", 728, Model.MenuItem.CalculateUrl(ApplicationPath), 728, 45, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(774, 21, true);
            WriteLiteral(" class=\"m-menu__link\"");
            EndContext();
            BeginWriteAttribute("target", " target=\"", 795, "\"", 826, 1);
#line 15 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Shared\Components\AppAreaNameMenu\_UserMenuItem.cshtml"
WriteAttributeValue("", 804, Model.MenuItem.Target, 804, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(827, 92, true);
            WriteLiteral("\n           role=\"menuitem\"\n           aria-haspopup=\"true\"\n           aria-expanded=\"false\"");
            EndContext();
            BeginWriteAttribute("tabindex", "\n           tabindex=\"", 919, "\"", 979, 1);
#line 19 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Shared\Components\AppAreaNameMenu\_UserMenuItem.cshtml"
WriteAttributeValue("", 941, Model.MenuItemIndex==0 ? "0" : "-1", 941, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(980, 16, true);
            WriteLiteral(">\n            <i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 996, "\"", 1042, 2);
            WriteAttributeValue("", 1004, "m-menu__link-icon", 1004, 17, true);
#line 20 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Shared\Components\AppAreaNameMenu\_UserMenuItem.cshtml"
WriteAttributeValue(" ", 1021, Model.MenuItem.Icon, 1022, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1043, 87, true);
            WriteLiteral("></i>\n            <span class=\"m-menu__link-text\">\n                <span class=\"title\">");
            EndContext();
            BeginContext(1131, 26, false);
#line 22 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Shared\Components\AppAreaNameMenu\_UserMenuItem.cshtml"
                               Write(Model.MenuItem.DisplayName);

#line default
#line hidden
            EndContext();
            BeginContext(1157, 41, true);
            WriteLiteral("</span>\n            </span>\n        </a>\n");
            EndContext();
#line 25 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Shared\Components\AppAreaNameMenu\_UserMenuItem.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(1219, 147, true);
            WriteLiteral("        <a href=\"#\" class=\"m-menu__link m-menu__toggle\"\n           role=\"menuitem\"\n           aria-haspopup=\"true\"\n           aria-expanded=\"false\"");
            EndContext();
            BeginWriteAttribute("tabindex", "\n           tabindex=\"", 1366, "\"", 1426, 1);
#line 32 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Shared\Components\AppAreaNameMenu\_UserMenuItem.cshtml"
WriteAttributeValue("", 1388, Model.MenuItemIndex==0 ? "0" : "-1", 1388, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1427, 16, true);
            WriteLiteral(">\n            <i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1443, "\"", 1489, 2);
            WriteAttributeValue("", 1451, "m-menu__link-icon", 1451, 17, true);
#line 33 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Shared\Components\AppAreaNameMenu\_UserMenuItem.cshtml"
WriteAttributeValue(" ", 1468, Model.MenuItem.Icon, 1469, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1490, 87, true);
            WriteLiteral("></i>\n            <span class=\"m-menu__link-text\">\n                <span class=\"title\">");
            EndContext();
            BeginContext(1578, 26, false);
#line 35 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Shared\Components\AppAreaNameMenu\_UserMenuItem.cshtml"
                               Write(Model.MenuItem.DisplayName);

#line default
#line hidden
            EndContext();
            BeginContext(1604, 141, true);
            WriteLiteral("</span>\n            </span>\n            <i class=\"m-menu__ver-arrow la la-angle-right\"></i>\n        </a>\n        <nav class=\"m-menu__submenu\"");
            EndContext();
            BeginWriteAttribute("aria-label", " aria-label=\"", 1745, "\"", 1785, 1);
#line 39 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Shared\Components\AppAreaNameMenu\_UserMenuItem.cshtml"
WriteAttributeValue("", 1758, Model.MenuItem.DisplayName, 1758, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1786, 116, true);
            WriteLiteral(">\n            <span class=\"m-menu__arrow\"></span>\n            <ul class=\"m-menu__subnav\"\n                role=\"menu\"");
            EndContext();
            BeginWriteAttribute("aria-label", "\n                aria-label=\"", 1902, "\"", 1958, 1);
#line 43 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Shared\Components\AppAreaNameMenu\_UserMenuItem.cshtml"
WriteAttributeValue("", 1931, Model.MenuItem.DisplayName, 1931, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1959, 2, true);
            WriteLiteral(">\n");
            EndContext();
#line 44 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Shared\Components\AppAreaNameMenu\_UserMenuItem.cshtml"
                 for (var i = 0; i < Model.MenuItem.Items.Count; i++)
                {
                    var childMenuItem = Model.MenuItem.Items[i];
                    if (!childMenuItem.IsVisible)
                    {
                        continue;
                    }
                    

#line default
#line hidden
            BeginContext(2263, 345, false);
#line 51 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Shared\Components\AppAreaNameMenu\_UserMenuItem.cshtml"
               Write(Html.Partial("Components/AppAreaNameMenu/_UserMenuItem", new UserMenuItemViewModel
                       {
                           MenuItem = childMenuItem,
                           MenuItemIndex = i,
                           CurrentPageName = Model.CurrentPageName,
                           RootLevel = false
                       }));

#line default
#line hidden
            EndContext();
#line 57 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Shared\Components\AppAreaNameMenu\_UserMenuItem.cshtml"
                         
                }

#line default
#line hidden
            BeginContext(2627, 33, true);
            WriteLiteral("            </ul>\n        </nav>\n");
            EndContext();
#line 61 "D:\ASP ANGULAR\asp\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Shared\Components\AppAreaNameMenu\_UserMenuItem.cshtml"
    }

#line default
#line hidden
            BeginContext(2666, 6, true);
            WriteLiteral("</li>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserMenuItemViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
