#pragma checksum "C:\Users\John\EFIF\OneDrive - EFIF\Webdevelopment\KreaTid\kreaTid\Views\Shared\_ProductImg.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be93a2748cb453aa6e285e354ac9c100d0935f9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ProductImg), @"mvc.1.0.view", @"/Views/Shared/_ProductImg.cshtml")]
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
#line 1 "C:\Users\John\EFIF\OneDrive - EFIF\Webdevelopment\KreaTid\kreaTid\Views\_ViewImports.cshtml"
using kreaTid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\John\EFIF\OneDrive - EFIF\Webdevelopment\KreaTid\kreaTid\Views\_ViewImports.cshtml"
using kreaTid.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be93a2748cb453aa6e285e354ac9c100d0935f9f", @"/Views/Shared/_ProductImg.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d28acaf2ebed72b6cc848a3813530b6315c9311", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ProductImg : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<kreaTid.Models.ProductImg>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<img");
            BeginWriteAttribute("src", " src=\"", 40, "\"", 70, 1);
#nullable restore
#line 3 "C:\Users\John\EFIF\OneDrive - EFIF\Webdevelopment\KreaTid\kreaTid\Views\Shared\_ProductImg.cshtml"
WriteAttributeValue("", 46, Model.ProductImgFileUrl, 46, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 71, "\"", 101, 1);
#nullable restore
#line 3 "C:\Users\John\EFIF\OneDrive - EFIF\Webdevelopment\KreaTid\kreaTid\Views\Shared\_ProductImg.cshtml"
WriteAttributeValue("", 77, Model.ProductImgAltText, 77, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n<p>");
#nullable restore
#line 4 "C:\Users\John\EFIF\OneDrive - EFIF\Webdevelopment\KreaTid\kreaTid\Views\Shared\_ProductImg.cshtml"
Write(Model.ProductImgType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<kreaTid.Models.ProductImg> Html { get; private set; }
    }
}
#pragma warning restore 1591