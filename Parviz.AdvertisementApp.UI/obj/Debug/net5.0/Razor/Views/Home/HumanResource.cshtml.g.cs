#pragma checksum "E:\Dersler\MVC\Parviz.AdvertisementApp\Parviz.AdvertisementApp.UI\Views\Home\HumanResource.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c4ba61dc36699b8808612fbdd5014383fee9981"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_HumanResource), @"mvc.1.0.view", @"/Views/Home/HumanResource.cshtml")]
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
#line 2 "E:\Dersler\MVC\Parviz.AdvertisementApp\Parviz.AdvertisementApp.UI\Views\_ViewImports.cshtml"
using Parviz.AdvertisementApp.Dtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c4ba61dc36699b8808612fbdd5014383fee9981", @"/Views/Home/HumanResource.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eddca341ec840f0cb1a35a71b90b21a18cef1f8d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_HumanResource : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AdvertisementListDto>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Dersler\MVC\Parviz.AdvertisementApp\Parviz.AdvertisementApp.UI\Views\Home\HumanResource.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div style=""background: rgb(131,58,180);background: linear-gradient(90deg, rgba(131,58,180,1) 0%, rgba(253,29,29,1) 50%, rgba(252,176,69,1) 100%);"" class=""jumbotron jumbotron-fluid"">
    <div class=""container"">
        <br />
        <br />
        <br />
        <br />
        <h1 class=""display-4""><strong>İnsan Resursları</strong></h1>
        <p class=""lead"">Təqdim olunan vakansiyaları aktiv olaraq buradan izləyə bilərsiz.</p>
        <br />
    </div>
</div>
<br />
<div class=""row container-fluid"">
");
#nullable restore
#line 19 "E:\Dersler\MVC\Parviz.AdvertisementApp\Parviz.AdvertisementApp.UI\Views\Home\HumanResource.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-6 pb-3\">\r\n            <div class=\"card\">\r\n                <div class=\"card-header\">\r\n                    <h5 class=\"card-title\">");
#nullable restore
#line 24 "E:\Dersler\MVC\Parviz.AdvertisementApp\Parviz.AdvertisementApp.UI\Views\Home\HumanResource.cshtml"
                                      Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                </div>\r\n                <div class=\"card-body\">\r\n                    <p class=\"card-text\">");
#nullable restore
#line 27 "E:\Dersler\MVC\Parviz.AdvertisementApp\Parviz.AdvertisementApp.UI\Views\Home\HumanResource.cshtml"
                                    Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <a href=\"#\" class=\"btn btn-primary\">Müraciət et</a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 32 "E:\Dersler\MVC\Parviz.AdvertisementApp\Parviz.AdvertisementApp.UI\Views\Home\HumanResource.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<br />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AdvertisementListDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591