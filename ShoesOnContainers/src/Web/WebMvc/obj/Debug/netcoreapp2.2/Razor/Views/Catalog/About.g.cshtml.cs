#pragma checksum "C:\Users\oguzh\Source\Repos\ShoeEShop\ShoesOnContainers\src\Web\WebMvc\Views\Catalog\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45f40d61526f9612beda63f85e78035e994b3c79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalog_About), @"mvc.1.0.view", @"/Views/Catalog/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Catalog/About.cshtml", typeof(AspNetCore.Views_Catalog_About))]
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
#line 1 "C:\Users\oguzh\Source\Repos\ShoeEShop\ShoesOnContainers\src\Web\WebMvc\Views\_ViewImports.cshtml"
using WebMvc;

#line default
#line hidden
#line 2 "C:\Users\oguzh\Source\Repos\ShoeEShop\ShoesOnContainers\src\Web\WebMvc\Views\_ViewImports.cshtml"
using WebMvc.Models;

#line default
#line hidden
#line 5 "C:\Users\oguzh\Source\Repos\ShoeEShop\ShoesOnContainers\src\Web\WebMvc\Views\Catalog\About.cshtml"
using Microsoft.AspNetCore.Authentication;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45f40d61526f9612beda63f85e78035e994b3c79", @"/Views/Catalog/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82dfb9e8d9c1e15d2e9f7b4d3cf193b2b540299a", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalog_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(164, 28, true);
            WriteLiteral("<h2>Access Token</h2>\n<dl>\r\n");
            EndContext();
#line 8 "C:\Users\oguzh\Source\Repos\ShoeEShop\ShoesOnContainers\src\Web\WebMvc\Views\Catalog\About.cshtml"
     foreach (var claim in User.Claims)
    {

#line default
#line hidden
            BeginContext(240, 12, true);
            WriteLiteral("        <dt>");
            EndContext();
            BeginContext(253, 10, false);
#line 10 "C:\Users\oguzh\Source\Repos\ShoeEShop\ShoesOnContainers\src\Web\WebMvc\Views\Catalog\About.cshtml"
       Write(claim.Type);

#line default
#line hidden
            EndContext();
            BeginContext(263, 19, true);
            WriteLiteral("</dt>\r\n        <dd>");
            EndContext();
            BeginContext(283, 11, false);
#line 11 "C:\Users\oguzh\Source\Repos\ShoeEShop\ShoesOnContainers\src\Web\WebMvc\Views\Catalog\About.cshtml"
       Write(claim.Value);

#line default
#line hidden
            EndContext();
            BeginContext(294, 7, true);
            WriteLiteral("</dd>\r\n");
            EndContext();
#line 12 "C:\Users\oguzh\Source\Repos\ShoeEShop\ShoesOnContainers\src\Web\WebMvc\Views\Catalog\About.cshtml"

    }

#line default
#line hidden
            BeginContext(310, 35, true);
            WriteLiteral("    <dt>access token</dt>\r\n    <dd>");
            EndContext();
            BeginContext(346, 59, false);
#line 15 "C:\Users\oguzh\Source\Repos\ShoeEShop\ShoesOnContainers\src\Web\WebMvc\Views\Catalog\About.cshtml"
   Write(await ViewContext.HttpContext.GetTokenAsync("access_token"));

#line default
#line hidden
            EndContext();
            BeginContext(405, 43, true);
            WriteLiteral("</dd>\r\n    <dt>refresh token</dt>\r\n    <dd>");
            EndContext();
            BeginContext(449, 60, false);
#line 17 "C:\Users\oguzh\Source\Repos\ShoeEShop\ShoesOnContainers\src\Web\WebMvc\Views\Catalog\About.cshtml"
   Write(await ViewContext.HttpContext.GetTokenAsync("refresh_token"));

#line default
#line hidden
            EndContext();
            BeginContext(509, 14, true);
            WriteLiteral("</dd>\r\n</dl>\r\n");
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
