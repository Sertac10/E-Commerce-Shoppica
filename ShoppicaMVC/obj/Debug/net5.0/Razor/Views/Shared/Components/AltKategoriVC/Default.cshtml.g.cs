#pragma checksum "C:\Users\snaim\Desktop\Shoppica\ShoppicaMVC\Views\Shared\Components\AltKategoriVC\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f16b606cbe6ba509a050b3cef0f39e6ec3b36ca4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AltKategoriVC_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AltKategoriVC/Default.cshtml")]
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
#line 1 "C:\Users\snaim\Desktop\Shoppica\ShoppicaMVC\Views\_ViewImports.cshtml"
using ShoppicaMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\snaim\Desktop\Shoppica\ShoppicaMVC\Views\_ViewImports.cshtml"
using ShoppicaMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f16b606cbe6ba509a050b3cef0f39e6ec3b36ca4", @"/Views/Shared/Components/AltKategoriVC/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b67d3489dcefdd8a6dd759edf02854ce14b9f4c5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_AltKategoriVC_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ShoppicaMVC.ViewModels.CategoryVM>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/category_100x100.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-bottom: 3px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\snaim\Desktop\Shoppica\ShoppicaMVC\Views\Shared\Components\AltKategoriVC\Default.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"s_subcategory\">\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 135, "\"", 170, 2);
            WriteAttributeValue("", 142, "/product/getProduct/", 142, 20, true);
#nullable restore
#line 7 "C:\Users\snaim\Desktop\Shoppica\ShoppicaMVC\Views\Shared\Components\AltKategoriVC\Default.cshtml"
WriteAttributeValue("", 162, item.Id, 162, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f16b606cbe6ba509a050b3cef0f39e6ec3b36ca44760", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 7 "C:\Users\snaim\Desktop\Shoppica\ShoppicaMVC\Views\Shared\Components\AltKategoriVC\Default.cshtml"
AddHtmlAttributeValue("", 220, item.CategoryName, 220, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 7 "C:\Users\snaim\Desktop\Shoppica\ShoppicaMVC\Views\Shared\Components\AltKategoriVC\Default.cshtml"
AddHtmlAttributeValue("", 245, item.CategoryName, 245, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 311, "\"", 346, 2);
            WriteAttributeValue("", 318, "/product/getProduct/", 318, 20, true);
#nullable restore
#line 8 "C:\Users\snaim\Desktop\Shoppica\ShoppicaMVC\Views\Shared\Components\AltKategoriVC\Default.cshtml"
WriteAttributeValue("", 338, item.Id, 338, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 8 "C:\Users\snaim\Desktop\Shoppica\ShoppicaMVC\Views\Shared\Components\AltKategoriVC\Default.cshtml"
                                          Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n    </div>\r\n");
#nullable restore
#line 10 "C:\Users\snaim\Desktop\Shoppica\ShoppicaMVC\Views\Shared\Components\AltKategoriVC\Default.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ShoppicaMVC.ViewModels.CategoryVM>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
