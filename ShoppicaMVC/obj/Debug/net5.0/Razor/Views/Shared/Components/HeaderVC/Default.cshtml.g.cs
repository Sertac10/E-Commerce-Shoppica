#pragma checksum "C:\Users\snaim\Desktop\Shoppica\ShoppicaMVC\Views\Shared\Components\HeaderVC\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2054dbf813a9715b597c7324ff6dddca70367075"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_HeaderVC_Default), @"mvc.1.0.view", @"/Views/Shared/Components/HeaderVC/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2054dbf813a9715b597c7324ff6dddca70367075", @"/Views/Shared/Components/HeaderVC/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b67d3489dcefdd8a6dd759edf02854ce14b9f4c5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_HeaderVC_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ShoppicaMVC.ViewModels.CategoryVM>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\snaim\Desktop\Shoppica\ShoppicaMVC\Views\Shared\Components\HeaderVC\Default.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 112, "\"", 147, 2);
            WriteAttributeValue("", 119, "/product/getProduct/", 119, 20, true);
#nullable restore
#line 7 "C:\Users\snaim\Desktop\Shoppica\ShoppicaMVC\Views\Shared\Components\HeaderVC\Default.cshtml"
WriteAttributeValue("", 139, item.Id, 139, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 7 "C:\Users\snaim\Desktop\Shoppica\ShoppicaMVC\Views\Shared\Components\HeaderVC\Default.cshtml"
                                          Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        <div class=\"s_submenu\">\r\n            <h3>");
#nullable restore
#line 9 "C:\Users\snaim\Desktop\Shoppica\ShoppicaMVC\Views\Shared\Components\HeaderVC\Default.cshtml"
           Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Alt Kategori</h3>\r\n            <ul class=\"s_list_1 clearfix\">\r\n");
#nullable restore
#line 11 "C:\Users\snaim\Desktop\Shoppica\ShoppicaMVC\Views\Shared\Components\HeaderVC\Default.cshtml"
                 foreach (var altItem in item.InverseTop)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li><a");
            BeginWriteAttribute("href", " href=\"", 408, "\"", 446, 2);
            WriteAttributeValue("", 415, "/product/getProduct/", 415, 20, true);
#nullable restore
#line 13 "C:\Users\snaim\Desktop\Shoppica\ShoppicaMVC\Views\Shared\Components\HeaderVC\Default.cshtml"
WriteAttributeValue("", 435, altItem.Id, 435, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 13 "C:\Users\snaim\Desktop\Shoppica\ShoppicaMVC\Views\Shared\Components\HeaderVC\Default.cshtml"
                                                             Write(altItem.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 14 "C:\Users\snaim\Desktop\Shoppica\ShoppicaMVC\Views\Shared\Components\HeaderVC\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </ul>\r\n            <span class=\"clear border_eee\"></span>\r\n\r\n        </div>\r\n    </li>\r\n");
#nullable restore
#line 21 "C:\Users\snaim\Desktop\Shoppica\ShoppicaMVC\Views\Shared\Components\HeaderVC\Default.cshtml"
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
