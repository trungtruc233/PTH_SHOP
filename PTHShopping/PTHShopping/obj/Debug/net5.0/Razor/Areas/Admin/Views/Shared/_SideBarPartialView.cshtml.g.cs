#pragma checksum "E:\_dotNetCoreMVC\PTHShopping\PTHShopping\Areas\Admin\Views\Shared\_SideBarPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "223a01c1a8abf1e02f1a04124891d9f3f597cdc9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__SideBarPartialView), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_SideBarPartialView.cshtml")]
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
#line 1 "E:\_dotNetCoreMVC\PTHShopping\PTHShopping\Areas\Admin\Views\_ViewImports.cshtml"
using PTHShopping;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\_dotNetCoreMVC\PTHShopping\PTHShopping\Areas\Admin\Views\_ViewImports.cshtml"
using PTHShopping.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"223a01c1a8abf1e02f1a04124891d9f3f597cdc9", @"/Areas/Admin/Views/Shared/_SideBarPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98bc40aeb7f02c4ad2dfab2f91ee5096ea0c5ddb", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__SideBarPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Adminassets/images/faces/face1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("profile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n<nav class=\"sidebar sidebar-offcanvas\" id=\"sidebar\">\r\n    <ul class=\"nav\">\r\n        <li class=\"nav-item nav-profile\">\r\n            <a href=\"#\" class=\"nav-link\">\r\n                <div class=\"nav-profile-image\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "223a01c1a8abf1e02f1a04124891d9f3f597cdc94203", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <span class=""login-status online""></span>
                    <!--change to offline or busy as needed-->
                </div>
                <div class=""nav-profile-text d-flex flex-column"">
                    <span class=""font-weight-bold mb-2"">Admin Hậu</span>
                    <span class=""text-secondary text-small"">Project Manager</span>
                </div>
                <i class=""mdi mdi-bookmark-check text-success nav-profile-badge""></i>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""index.html"">
                <span class=""menu-title"">Dashboard</span>
                <i class=""mdi mdi-home menu-icon""></i>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" data-toggle=""collapse"" href=""#ui-basic"" aria-expanded=""false"" aria-controls=""ui-basic"">
                <span class=""menu-title"">Quản lý đơn hàng </span>
                <i class=""menu-arrow""></i>
        ");
            WriteLiteral(@"        <i class=""mdi mdi-crosshairs-gps menu-icon""></i>
            </a>
            <div class=""collapse"" id=""ui-basic"">
                <ul class=""nav flex-column sub-menu"">
                    <li class=""nav-item""> <a class=""nav-link"" href=""pages/ui-features/buttons.html"">Buttons</a></li>
                    <li class=""nav-item""> <a class=""nav-link"" href=""pages/ui-features/typography.html"">Typography</a></li>
                </ul>
            </div>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""pages/icons/mdi.html"">
                <span class=""menu-title"">Quản lý sản phẩm</span>
                <i class=""mdi mdi-contacts menu-icon""></i>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""pages/forms/basic_elements.html"">
                <span class=""menu-title"">Quản lý Khách hàng</span>
                <i class=""mdi mdi-format-list-bulleted menu-icon""></i>
            </a>
        </li>
        <li cl");
            WriteLiteral(@"ass=""nav-item"">
            <a class=""nav-link"" href=""pages/charts/chartjs.html"">
                <span class=""menu-title"">Quản lý thống kê</span>
                <i class=""mdi mdi-chart-bar menu-icon""></i>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""pages/tables/basic-table.html"">
                <span class=""menu-title"">Quản lý hệ thống</span>
                <i class=""mdi mdi-table-large menu-icon""></i>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" data-toggle=""collapse"" href=""#general-pages"" aria-expanded=""false"" aria-controls=""general-pages"">
                <span class=""menu-title"">Sample Pages</span>
                <i class=""menu-arrow""></i>
                <i class=""mdi mdi-medical-bag menu-icon""></i>
            </a>
            <div class=""collapse"" id=""general-pages"">
                <ul class=""nav flex-column sub-menu"">
                    <li class=""nav-item""> <a class=""nav-l");
            WriteLiteral(@"ink"" href=""pages/samples/blank-page.html""> Blank Page </a></li>
                    <li class=""nav-item""> <a class=""nav-link"" href=""pages/samples/login.html""> Login </a></li>
                    <li class=""nav-item""> <a class=""nav-link"" href=""pages/samples/register.html""> Register </a></li>
                    <li class=""nav-item""> <a class=""nav-link"" href=""pages/samples/error-404.html""> 404 </a></li>
                    <li class=""nav-item""> <a class=""nav-link"" href=""pages/samples/error-500.html""> 500 </a></li>
                </ul>
            </div>
        </li>
        <li class=""nav-item sidebar-actions"">
            <span class=""nav-link"">
                <div class=""border-bottom"">
                    <h6 class=""font-weight-normal mb-3"">Projects</h6>
                </div>
                <button class=""btn btn-block btn-lg btn-gradient-primary mt-4"">+ Add a project</button>
                <div class=""mt-4"">
                    <div class=""border-bottom"">
                        <p cl");
            WriteLiteral(@"ass=""text-secondary"">Categories</p>
                    </div>
                    <ul class=""gradient-bullet-list mt-4"">
                        <li>Free</li>
                        <li>Pro</li>
                    </ul>
                </div>
            </span>
        </li>
    </ul>
</nav>
");
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