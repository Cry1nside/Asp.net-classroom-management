#pragma checksum "D:\Thanh_Hung\LTCSDL\TaiBaiGiangLen\QuanLyLop\testqll\testqll\Pages\Admin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "459e455b89069f24091a27584bec1f17212d3f3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(testqll.Pages.Pages_Admin), @"mvc.1.0.razor-page", @"/Pages/Admin.cshtml")]
namespace testqll.Pages
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
#line 1 "D:\Thanh_Hung\LTCSDL\TaiBaiGiangLen\QuanLyLop\testqll\testqll\Pages\_ViewImports.cshtml"
using testqll;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Thanh_Hung\LTCSDL\TaiBaiGiangLen\QuanLyLop\testqll\testqll\Pages\Admin.cshtml"
using QLL.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Thanh_Hung\LTCSDL\TaiBaiGiangLen\QuanLyLop\testqll\testqll\Pages\Admin.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Thanh_Hung\LTCSDL\TaiBaiGiangLen\QuanLyLop\testqll\testqll\Pages\Admin.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Thanh_Hung\LTCSDL\TaiBaiGiangLen\QuanLyLop\testqll\testqll\Pages\Admin.cshtml"
using Microsoft.AspNetCore.Antiforgery;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"459e455b89069f24091a27584bec1f17212d3f3c", @"/Pages/Admin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f603635730e0b9d9481a2739a97b83f9b692d31", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/avatar.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Avatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: #222d32; height: 35px; margin: 0px 10px; "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Pages/Shared/_Menu_admin.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\Thanh_Hung\LTCSDL\TaiBaiGiangLen\QuanLyLop\testqll\testqll\Pages\Admin.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\Thanh_Hung\LTCSDL\TaiBaiGiangLen\QuanLyLop\testqll\testqll\Pages\Admin.cshtml"
  
    ViewData["Title"] = "Quản lý admin";

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Thanh_Hung\LTCSDL\TaiBaiGiangLen\QuanLyLop\testqll\testqll\Pages\Admin.cshtml"
  
    var token = antiforgery.GetAndStoreTokens(HttpContext).RequestToken;

#line default
#line hidden
#nullable disable
            WriteLiteral("<script type=\"text/javascript\">\r\n    var dataAd = ");
#nullable restore
#line 16 "D:\Thanh_Hung\LTCSDL\TaiBaiGiangLen\QuanLyLop\testqll\testqll\Pages\Admin.cshtml"
            Write(Html.Raw(JsonSerializer.Serialize(Model.lstAd)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    var dataAd1 = ");
#nullable restore
#line 17 "D:\Thanh_Hung\LTCSDL\TaiBaiGiangLen\QuanLyLop\testqll\testqll\Pages\Admin.cshtml"
             Write(Html.Raw(JsonSerializer.Serialize(Model.lstAd1)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    var curPage = 1;\r\n    var totPage = ");
#nullable restore
#line 19 "D:\Thanh_Hung\LTCSDL\TaiBaiGiangLen\QuanLyLop\testqll\testqll\Pages\Admin.cshtml"
             Write(Html.Raw(Model.TotalPage));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n</script>\r\n");
            DefineSection("menu_nav", async() => {
                WriteLiteral("\r\n    <li>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "459e455b89069f24091a27584bec1f17212d3f3c10628", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </li>\r\n    <li class=\"nav-item d-flex align-items-center\" style=\"font-weight: 500;\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "459e455b89069f24091a27584bec1f17212d3f3c12083", async() => {
                    WriteLiteral("\r\n            ");
#nullable restore
#line 28 "D:\Thanh_Hung\LTCSDL\TaiBaiGiangLen\QuanLyLop\testqll\testqll\Pages\Admin.cshtml"
       Write(Model.busAd.GetById(HttpContext.Session.GetString("user_id")).TenAdmin);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </li>\r\n    <li class=\"nav-item d-flex align-items-center\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "459e455b89069f24091a27584bec1f17212d3f3c13984", async() => {
                    WriteLiteral("Đăng xuất");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </li>\r\n\r\n");
            }
            );
            DefineSection("menu", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "459e455b89069f24091a27584bec1f17212d3f3c15639", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("<div>\r\n    <h1 class=\"display-4 text-center\">Danh sách Admin</h1>\r\n    <br />\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "459e455b89069f24091a27584bec1f17212d3f3c16965", async() => {
                WriteLiteral("\r\n        <div class=\"row\">\r\n            <div class=\"col-2 form-group\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "459e455b89069f24091a27584bec1f17212d3f3c17319", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 46 "D:\Thanh_Hung\LTCSDL\TaiBaiGiangLen\QuanLyLop\testqll\testqll\Pages\Admin.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.maAd);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "459e455b89069f24091a27584bec1f17212d3f3c18824", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
#nullable restore
#line 47 "D:\Thanh_Hung\LTCSDL\TaiBaiGiangLen\QuanLyLop\testqll\testqll\Pages\Admin.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.maAd);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n            <div class=\"col-3 form-group\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "459e455b89069f24091a27584bec1f17212d3f3c20697", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 50 "D:\Thanh_Hung\LTCSDL\TaiBaiGiangLen\QuanLyLop\testqll\testqll\Pages\Admin.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.tenAd);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "459e455b89069f24091a27584bec1f17212d3f3c22203", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
#nullable restore
#line 51 "D:\Thanh_Hung\LTCSDL\TaiBaiGiangLen\QuanLyLop\testqll\testqll\Pages\Admin.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.tenAd);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </div>
            <div style=""margin-block: auto; margin-left: auto;"" class=""col-2 form-group"">
                <br />
                <input type=""submit"" class=""btn btn-primary"" value=""Tìm kiếm"" />
            </div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <button style="" margin: 10px 0px;"" type=""button"" onclick=""openModalAd(null);"" class=""btn btn-outline-primary btn-sm"">Thêm admin</button>

    <table id=""tableAd"" class=""table table-striped"">
        <tr>
            <th>Mã Admin</th>
            <th>Tên Admin</th>
            <th>Giới tính</th>
            <th>Ngày sinh</th>
            <th>Đia chỉ</th>
            <th>SĐT</th>
            <th>Email</th>
            <th>Action</th>
        </tr>
");
#nullable restore
#line 72 "D:\Thanh_Hung\LTCSDL\TaiBaiGiangLen\QuanLyLop\testqll\testqll\Pages\Admin.cshtml"
         if (Model.lstAd1.Count != 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tbody id=\"tbodyDT\">\r\n");
#nullable restore
#line 75 "D:\Thanh_Hung\LTCSDL\TaiBaiGiangLen\QuanLyLop\testqll\testqll\Pages\Admin.cshtml"
                 foreach (AdminDTO ad in Model.lstAd1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr");
            BeginWriteAttribute("id", " id=\"", 2756, "\"", 2777, 2);
            WriteAttributeValue("", 2761, "trAd_", 2761, 5, true);
#nullable restore
#line 77 "D:\Thanh_Hung\LTCSDL\TaiBaiGiangLen\QuanLyLop\testqll\testqll\Pages\Admin.cshtml"
WriteAttributeValue("", 2766, ad.MaAdmin, 2766, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <td>");
#nullable restore
#line 78 "D:\Thanh_Hung\LTCSDL\TaiBaiGiangLen\QuanLyLop\testqll\testqll\Pages\Admin.cshtml"
                       Write(ad.MaAdmin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 79 "D:\Thanh_Hung\LTCSDL\TaiBaiGiangLen\QuanLyLop\testqll\testqll\Pages\Admin.cshtml"
                       Write(ad.TenAdmin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 80 "D:\Thanh_Hung\LTCSDL\TaiBaiGiangLen\QuanLyLop\testqll\testqll\Pages\Admin.cshtml"
                       Write(ad.GioiTinh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 81 "D:\Thanh_Hung\LTCSDL\TaiBaiGiangLen\QuanLyLop\testqll\testqll\Pages\Admin.cshtml"
                       Write(ad.NgaySinh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 82 "D:\Thanh_Hung\LTCSDL\TaiBaiGiangLen\QuanLyLop\testqll\testqll\Pages\Admin.cshtml"
                       Write(ad.DiaChi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 83 "D:\Thanh_Hung\LTCSDL\TaiBaiGiangLen\QuanLyLop\testqll\testqll\Pages\Admin.cshtml"
                       Write(ad.Sdt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 84 "D:\Thanh_Hung\LTCSDL\TaiBaiGiangLen\QuanLyLop\testqll\testqll\Pages\Admin.cshtml"
                       Write(ad.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3178, "\"", 3215, 3);
            WriteAttributeValue("", 3188, "openModalAd(\'", 3188, 13, true);
#nullable restore
#line 86 "D:\Thanh_Hung\LTCSDL\TaiBaiGiangLen\QuanLyLop\testqll\testqll\Pages\Admin.cshtml"
WriteAttributeValue("", 3201, ad.MaAdmin, 3201, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3212, "\');", 3212, 3, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary btn-sm\">Sửa</button>\r\n                            <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3319, "\"", 3353, 3);
            WriteAttributeValue("", 3329, "deleteAd(\'", 3329, 10, true);
#nullable restore
#line 87 "D:\Thanh_Hung\LTCSDL\TaiBaiGiangLen\QuanLyLop\testqll\testqll\Pages\Admin.cshtml"
WriteAttributeValue("", 3339, ad.MaAdmin, 3339, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3350, "\');", 3350, 3, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger btn-sm\">xoá</button>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 90 "D:\Thanh_Hung\LTCSDL\TaiBaiGiangLen\QuanLyLop\testqll\testqll\Pages\Admin.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n");
#nullable restore
#line 93 "D:\Thanh_Hung\LTCSDL\TaiBaiGiangLen\QuanLyLop\testqll\testqll\Pages\Admin.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </table>
    <nav aria-label=""Page navigation example"">
        <ul class=""pagination"">
            <li class=""page-item""><a class=""page-link"" href=""javascript:void(0);"" onclick=""goPre('Admin')"">Previous</a></li>
            <li class=""page-item""><a class=""page-link"" href=""javascript:void(0);""><span id=""spanCurrentPage"">1</span></a></li>
            <li class=""page-item""><a class=""page-link"" href=""javascript:void(0);"" onclick=""goNext('Admin')"">Next</a></li>
        </ul>
    </nav>
</div>
<div id=""DivModalAd"" class=""modal"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Sửa admin: <span id=""MaAd""></span></h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" onclick=""closeModal()"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            WriteLiteral(@"<div class=""modal-body"">
                <div class=""form-group"">
                    <label for=""txtMaAd"">Mã admin</label>
                    <input type=""text"" class=""form-control"" id=""txtMaAd"" aria-describedby=""MaAdHelp"" placeholder=""Mã admin: ad..."">
                    <small id=""MaAdHelp"" class=""form-text text-muted"">Không được bỏ trống, 5 kí tự.</small>
                </div>
                <div class=""form-group"">
                    <label for=""txtTenAd"">Tên admin</label>
                    <input type=""text"" class=""form-control"" id=""txtTenAd"" aria-describedby=""TenAdHelp"" placeholder=""Tên admin"">
                    <small id=""TenAdHelp"" class=""form-text text-muted"">Không được bỏ trống.</small>
                </div>
                <div class=""form-group"">
                    <label for=""txtNS"">Ngày sinh</label>
                    <input type=""date"" class=""form-control"" id=""txtNS"" value=""2000-01-01""
                           aria-describedby=""PhongHocHelp"">
                    <s");
            WriteLiteral(@"mall id=""NSHelp"" class=""form-text text-muted"">Không được bỏ trống.</small>
                </div>
                <div class=""form-group"">
                    <label for=""selGT"">Giới tính</label>
                    <select class=""form-control"" id=""selGT"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "459e455b89069f24091a27584bec1f17212d3f3c33326", async() => {
                WriteLiteral("Nam");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "459e455b89069f24091a27584bec1f17212d3f3c34306", async() => {
                WriteLiteral("Nữ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </select>
                </div>
                <div class=""form-group"">
                    <label for=""txtDiaChi"">Địa chỉ</label>
                    <input type=""text"" class=""form-control"" id=""txtDiaChi"" aria-describedby=""DiaChiHelp"" placeholder=""Địa chỉ"">
                    <small id=""DiaChiHelp"" class=""form-text text-muted"">Không được bỏ trống.</small>
                </div>
                <div class=""form-group"">
                    <label for=""txtSDT"">Số điện thoại</label>
                    <input type=""text"" class=""form-control"" id=""txtSDT"" aria-describedby=""SDTlHelp"" placeholder=""Số điện thoại"">
                    <small id=""SDTHelp"" class=""form-text text-muted"">Không được bỏ trống.</small>
                </div>
                <div class=""form-group"">
                    <label for=""txtEmail"">Email</label>
                    <input type=""email"" class=""form-control"" id=""txtEmail"" aria-describedby=""DiaChiHelp"" placeholder=""Địa chỉ email"">
                  ");
            WriteLiteral(@"  <small id=""EmailHelp"" class=""form-text text-muted"">Không được bỏ trống.</small>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" onclick=""closeModal()"" data-dismiss=""modal"">Close</button>
                <button type=""button"" onclick=""saveAd()"" class=""btn btn-primary"">Save changes</button>
            </div>
        </div>
    </div>
</div>
<script id=""adTemplate"" type=""text/x-jquery-tmpl"">
    <tr id=""trHS_${maAdmin}"">
        <td>${maAdmin}</td>
        <td>${tenAdmin}</td>
        <td>${gioiTinh}</td>
        <td>${ngaySinh}</td>
        <td>${diaChi}</td>
        <td>${sdt}</td>
        <td>${email}</td>
        <td>
            <button type=""button"" onclick=""openModalAd('${maAdmin}');"" class=""btn btn-outline-primary btn-sm"">Sửa</button>
            <button type=""button"" onclick=""deleteAd('${maAdmin}');"" class=""btn btn-outline-danger btn-sm"">xoá</button>
        </td>
    </tr>
</scrip");
            WriteLiteral("t>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAntiforgery antiforgery { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuanLyLop2_ASP.NETCore.Pages.AdminModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QuanLyLop2_ASP.NETCore.Pages.AdminModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QuanLyLop2_ASP.NETCore.Pages.AdminModel>)PageContext?.ViewData;
        public QuanLyLop2_ASP.NETCore.Pages.AdminModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
