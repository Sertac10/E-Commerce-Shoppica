#pragma checksum "C:\Users\snaim\Desktop\Shoppica\ShoppicaMVC\Views\Shared\Components\FooterVC\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73233fef67de154a8e0ad3afd68b33182e152be5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_FooterVC_Default), @"mvc.1.0.view", @"/Views/Shared/Components/FooterVC/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73233fef67de154a8e0ad3afd68b33182e152be5", @"/Views/Shared/Components/FooterVC/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b67d3489dcefdd8a6dd759edf02854ce14b9f4c5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_FooterVC_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ShoppicaMVC.ViewModels.CategoryVM>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\snaim\Desktop\Shoppica\ShoppicaMVC\Views\Shared\Components\FooterVC\Default.cshtml"
 for (int i = 0; i < 6; i++)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"grid_2\">\r\n        <h2>");
#nullable restore
#line 7 "C:\Users\snaim\Desktop\Shoppica\ShoppicaMVC\Views\Shared\Components\FooterVC\Default.cshtml"
       Write(Model.ToList()[i].CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <ul class=\"s_list_1\">\r\n");
#nullable restore
#line 9 "C:\Users\snaim\Desktop\Shoppica\ShoppicaMVC\Views\Shared\Components\FooterVC\Default.cshtml"
             foreach (var altItem in Model.ToList()[i].InverseTop)

            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><a");
            BeginWriteAttribute("href", " href=\"", 306, "\"", 313, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 12 "C:\Users\snaim\Desktop\Shoppica\ShoppicaMVC\Views\Shared\Components\FooterVC\Default.cshtml"
                          Write(altItem.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 13 "C:\Users\snaim\Desktop\Shoppica\ShoppicaMVC\Views\Shared\Components\FooterVC\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </ul>\r\n    </div>\r\n");
#nullable restore
#line 17 "C:\Users\snaim\Desktop\Shoppica\ShoppicaMVC\Views\Shared\Components\FooterVC\Default.cshtml"
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
