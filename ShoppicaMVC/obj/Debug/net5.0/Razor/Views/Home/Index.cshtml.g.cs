#pragma checksum "C:\Users\snaim\Desktop\Shoppica\ShoppicaMVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f04776d224220fc21256c7b7bf7574b7dfcd5d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f04776d224220fc21256c7b7bf7574b7dfcd5d1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b67d3489dcefdd8a6dd759edf02854ce14b9f4c5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery/jquery.slides.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/shoppica.products_slide.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\snaim\Desktop\Shoppica\ShoppicaMVC\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- ********************** -->\r\n<!--     I N T R O          -->\r\n<!-- ********************** -->\r\n<div id=\"intro\">\r\n    <div id=\"intro_wrap\">\r\n\r\n        ");
#nullable restore
#line 11 "C:\Users\snaim\Desktop\Shoppica\ShoppicaMVC\Views\Home\Index.cshtml"
   Write(await Component.InvokeAsync("SliderVC"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f04776d224220fc21256c7b7bf7574b7dfcd5d14818", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f04776d224220fc21256c7b7bf7574b7dfcd5d15940", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<!-- end of intro -->
<!-- ********************** -->
<!--      C O N T E N T     -->
<!-- ********************** -->
<div id=""content"" class=""container_12"">

    <div id=""welcome"" class=""grid_12"">
        <h2>Shoppica Store'a Hoşgeldiniz</h2>
        <p>
            <a");
            BeginWriteAttribute("href", " href=\"", 701, "\"", 708, 0);
            EndWriteAttribute();
            WriteLiteral(@">Shoppica</a> şık bir premium OpenCart temasıdır (şu anda desteklenen sürümler 1.4.9.3/1.4.9.4'tür). Temiz ve modern tasarım, her tür çevrimiçi mağaza için temayı kullanmanıza olanak tanır: giysi, aksesuar, hediyelik eşya, elektronik, mobilya, sağlık ve kozmetik mağazası vb.
        </p>
        <p>
            Ana özelliklerden biri, her kategori için farklı türde slayt gösterileri seçmektir, böylece mağazanızın her bölümünü kişiselleştirebilirsiniz. Shoppica, size temayı ürününüze veya hizmetinize kolayca uyarlama gücü vererek, ürün listeleme boyutunu, sütun konumunu ve düzen türünü özelleştirmenize olanak tanır. Renk teması aracıyla sitenin öğelerini değiştirebilir, mağazanızı benzersiz hale getirebilir ve kalabalığın arasından sıyrılabilirsiniz.
        </p>
    </div>

    <div class=""clear""></div>

    <div id=""special_home"" class=""grid_12"">
        <h2 class=""s_title_1""><span class=""s_main_color"">İndirimli</span> Ürünler</h2>
        <div class=""clear""></div>
        <div class=""s_listing s");
            WriteLiteral("_grid_view clearfix\">\r\n\r\n\r\n            ");
#nullable restore
#line 41 "C:\Users\snaim\Desktop\Shoppica\ShoppicaMVC\Views\Home\Index.cshtml"
       Write(await Component.InvokeAsync("SpecialVC"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"




            <div class=""clear""></div>
        </div>
    </div>

    <div id=""banners_1"">
        <div class=""grid_3"">
            <a href=""http://themeforest.net/item/shoppica-premium-open-cart-theme/235470?ref=ThemeBurn"" target=""_blank"">
                <img src=""images/dummy/banner_4.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2122, "\"", 2128, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </a>\r\n        </div>\r\n        <div class=\"grid_3\">\r\n            <a href=\"http://themeforest.net/item/shoppica-premium-open-cart-theme/235470?ref=ThemeBurn\" target=\"_blank\">\r\n                <img src=\"images/dummy/banner_1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 2372, "\"", 2378, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </a>\r\n        </div>\r\n        <div class=\"grid_3\">\r\n            <a href=\"http://themeforest.net/item/shoppica-premium-open-cart-theme/235470?ref=ThemeBurn\" target=\"_blank\">\r\n                <img src=\"images/dummy/banner_2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 2622, "\"", 2628, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </a>\r\n        </div>\r\n        <div class=\"grid_3\">\r\n            <a href=\"http://themeforest.net/item/shoppica-premium-open-cart-theme/235470?ref=ThemeBurn\" target=\"_blank\">\r\n                <img src=\"images/dummy/banner_3.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 2872, "\"", 2878, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
            </a>
        </div>
        <div class=""clear""></div>
    </div>

    <div id=""latest_home"" class=""grid_12"">
        <h2 class=""s_title_1""><span class=""s_main_color"">Son Eklenen</span> Ürünler</h2>
        <div class=""clear""></div>
        <div class=""s_listing s_grid_view clearfix"">

            ");
#nullable restore
#line 79 "C:\Users\snaim\Desktop\Shoppica\ShoppicaMVC\Views\Home\Index.cshtml"
       Write(await Component.InvokeAsync("LastVC"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            <div class=\"clear\"></div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n<!-- end of content -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591