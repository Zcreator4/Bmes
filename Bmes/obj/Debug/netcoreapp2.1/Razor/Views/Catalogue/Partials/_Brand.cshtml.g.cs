#pragma checksum "C:\Users\Zander\Desktop\Fall\Bmes\Bmes\Views\Catalogue\Partials\_Brand.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e048781cc693a43c55b515dce970ffeb24fdb9c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalogue_Partials__Brand), @"mvc.1.0.view", @"/Views/Catalogue/Partials/_Brand.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Catalogue/Partials/_Brand.cshtml", typeof(AspNetCore.Views_Catalogue_Partials__Brand))]
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
#line 1 "C:\Users\Zander\Desktop\Fall\Bmes\Bmes\Views\_ViewImports.cshtml"
using Bmes;

#line default
#line hidden
#line 2 "C:\Users\Zander\Desktop\Fall\Bmes\Bmes\Views\_ViewImports.cshtml"
using Bmes.Models;

#line default
#line hidden
#line 3 "C:\Users\Zander\Desktop\Fall\Bmes\Bmes\Views\_ViewImports.cshtml"
using Bmes.ViewModels;

#line default
#line hidden
#line 4 "C:\Users\Zander\Desktop\Fall\Bmes\Bmes\Views\_ViewImports.cshtml"
using Bmes.ViewModels.Catalogue;

#line default
#line hidden
#line 5 "C:\Users\Zander\Desktop\Fall\Bmes\Bmes\Views\_ViewImports.cshtml"
using Bmes.Models.Products;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e048781cc693a43c55b515dce970ffeb24fdb9c4", @"/Views/Catalogue/Partials/_Brand.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fde50f815c04e9a0b6dfb61088fca7bc9a90b791", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalogue_Partials__Brand : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Brand>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 41, true);
            WriteLiteral("\n<h5 class=\"brand__heading\">Brands</h5>\n\n");
            EndContext();
#line 5 "C:\Users\Zander\Desktop\Fall\Bmes\Bmes\Views\Catalogue\Partials\_Brand.cshtml"
 foreach (var brand in Model)
{

#line default
#line hidden
            BeginContext(99, 36, true);
            WriteLiteral("  <div class=\"brand__list-wrapper\">\n");
            EndContext();
#line 8 "C:\Users\Zander\Desktop\Fall\Bmes\Bmes\Views\Catalogue\Partials\_Brand.cshtml"
     if (brand.Slug == (string)ViewData["SelectedBrand"])
    {

#line default
#line hidden
            BeginContext(199, 8, true);
            WriteLiteral("      <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 207, "\"", 267, 5);
            WriteAttributeValue("", 214, "/catalogue/", 214, 11, true);
#line 10 "C:\Users\Zander\Desktop\Fall\Bmes\Bmes\Views\Catalogue\Partials\_Brand.cshtml"
WriteAttributeValue("", 225, ViewData["SelectedCategory"], 225, 29, false);

#line default
#line hidden
            WriteAttributeValue("", 254, "/", 254, 1, true);
#line 10 "C:\Users\Zander\Desktop\Fall\Bmes\Bmes\Views\Catalogue\Partials\_Brand.cshtml"
WriteAttributeValue("", 255, brand.Slug, 255, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 266, "/", 266, 1, true);
            EndWriteAttribute();
            BeginContext(268, 25, true);
            WriteLiteral(" class=\"brand__selected\">");
            EndContext();
            BeginContext(294, 10, false);
#line 10 "C:\Users\Zander\Desktop\Fall\Bmes\Bmes\Views\Catalogue\Partials\_Brand.cshtml"
                                                                                         Write(brand.Name);

#line default
#line hidden
            EndContext();
            BeginContext(304, 5, true);
            WriteLiteral("</a>\n");
            EndContext();
#line 11 "C:\Users\Zander\Desktop\Fall\Bmes\Bmes\Views\Catalogue\Partials\_Brand.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(330, 8, true);
            WriteLiteral("      <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 338, "\"", 398, 5);
            WriteAttributeValue("", 345, "/catalogue/", 345, 11, true);
#line 14 "C:\Users\Zander\Desktop\Fall\Bmes\Bmes\Views\Catalogue\Partials\_Brand.cshtml"
WriteAttributeValue("", 356, ViewData["SelectedCategory"], 356, 29, false);

#line default
#line hidden
            WriteAttributeValue("", 385, "/", 385, 1, true);
#line 14 "C:\Users\Zander\Desktop\Fall\Bmes\Bmes\Views\Catalogue\Partials\_Brand.cshtml"
WriteAttributeValue("", 386, brand.Slug, 386, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 397, "/", 397, 1, true);
            EndWriteAttribute();
            BeginContext(399, 29, true);
            WriteLiteral(" class=\"brand__not-selected\">");
            EndContext();
            BeginContext(429, 10, false);
#line 14 "C:\Users\Zander\Desktop\Fall\Bmes\Bmes\Views\Catalogue\Partials\_Brand.cshtml"
                                                                                             Write(brand.Name);

#line default
#line hidden
            EndContext();
            BeginContext(439, 5, true);
            WriteLiteral("</a>\n");
            EndContext();
#line 15 "C:\Users\Zander\Desktop\Fall\Bmes\Bmes\Views\Catalogue\Partials\_Brand.cshtml"
    }

#line default
#line hidden
            BeginContext(450, 9, true);
            WriteLiteral("  </div>\n");
            EndContext();
#line 17 "C:\Users\Zander\Desktop\Fall\Bmes\Bmes\Views\Catalogue\Partials\_Brand.cshtml"
}

#line default
#line hidden
            BeginContext(461, 2, true);
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Brand>> Html { get; private set; }
    }
}
#pragma warning restore 1591
