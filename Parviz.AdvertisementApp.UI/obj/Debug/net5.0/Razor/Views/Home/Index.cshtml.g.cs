#pragma checksum "E:\Dersler\MVC\Parviz.AdvertisementApp\Parviz.AdvertisementApp.UI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbecc7c0a570a2b484b248a9d3afc96f103dec6e"
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
#line 2 "E:\Dersler\MVC\Parviz.AdvertisementApp\Parviz.AdvertisementApp.UI\Views\_ViewImports.cshtml"
using Parviz.AdvertisementApp.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Dersler\MVC\Parviz.AdvertisementApp\Parviz.AdvertisementApp.UI\Views\_ViewImports.cshtml"
using Parviz.AdvertisementApp.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbecc7c0a570a2b484b248a9d3afc96f103dec6e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66c51167584eb5d6c85e0ccfa1179c2db675667f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProvidedServiceListDto>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Dersler\MVC\Parviz.AdvertisementApp\Parviz.AdvertisementApp.UI\Views\Home\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<header class=""masthead text-center text-white"">
    <div class=""masthead-content"">
        <div class=""container px-5"">
            <h1 class=""masthead-heading mb-0"">Parviz Elanlar</h1>
            <h2 class=""masthead-subheading mb-0"">Pulsuz i?? elanlar??</h2>
            <a class=""btn btn-primary btn-xl rounded-pill mt-5"" href=""#scroll"">??trafl??</a>
        </div>
    </div>
    <div class=""bg-circle-1 bg-circle""></div>
    <div class=""bg-circle-2 bg-circle""></div>
    <div class=""bg-circle-3 bg-circle""></div>
    <div class=""bg-circle-4 bg-circle""></div>
</header>


");
#nullable restore
#line 22 "E:\Dersler\MVC\Parviz.AdvertisementApp\Parviz.AdvertisementApp.UI\Views\Home\Index.cshtml"
 for (int i = 0; i < Model?.Count; i++)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <section id=\"scroll\">\r\n        <div class=\"container px-5\">\r\n            <div class=\"row gx-5 align-items-center\">\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 845, "\"", 888, 3);
            WriteAttributeValue("", 853, "col-lg-6", 853, 8, true);
#nullable restore
#line 27 "E:\Dersler\MVC\Parviz.AdvertisementApp\Parviz.AdvertisementApp.UI\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 861, i%2==0?"order-lg-2":"", 862, 25, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 887, "", 888, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"p-5\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fbecc7c0a570a2b484b248a9d3afc96f103dec6e5728", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 972, "~/", 972, 2, true);
#nullable restore
#line 28 "E:\Dersler\MVC\Parviz.AdvertisementApp\Parviz.AdvertisementApp.UI\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 974, Model[i].ImagePath, 974, 19, false);

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
            WriteLiteral("</div>\r\n                </div>\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 1059, "\"", 1101, 2);
            WriteAttributeValue("", 1067, "col-lg-6", 1067, 8, true);
#nullable restore
#line 30 "E:\Dersler\MVC\Parviz.AdvertisementApp\Parviz.AdvertisementApp.UI\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 1075, i%2==0?"order-lg-1":"", 1076, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"p-5\">\r\n                        <h2 class=\"display-4\">");
#nullable restore
#line 32 "E:\Dersler\MVC\Parviz.AdvertisementApp\Parviz.AdvertisementApp.UI\Views\Home\Index.cshtml"
                                         Write(Model[i].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("...</h2>\r\n                        <p>");
#nullable restore
#line 33 "E:\Dersler\MVC\Parviz.AdvertisementApp\Parviz.AdvertisementApp.UI\Views\Home\Index.cshtml"
                      Write(Model[i].Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n");
#nullable restore
#line 39 "E:\Dersler\MVC\Parviz.AdvertisementApp\Parviz.AdvertisementApp.UI\Views\Home\Index.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProvidedServiceListDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
