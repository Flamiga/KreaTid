#pragma checksum "C:\Users\John\EFIF\OneDrive - EFIF\Webdevelopment\KreaTid\kreaTid\Views\TestIna\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec970ce1345762c2b6a2543cbe61e6d980d8a638"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TestIna_Index), @"mvc.1.0.view", @"/Views/TestIna/Index.cshtml")]
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
#line 2 "C:\Users\John\EFIF\OneDrive - EFIF\Webdevelopment\KreaTid\kreaTid\Views\TestIna\Index.cshtml"
using kreaTid.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec970ce1345762c2b6a2543cbe61e6d980d8a638", @"/Views/TestIna/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d28acaf2ebed72b6cc848a3813530b6315c9311", @"/Views/_ViewImports.cshtml")]
    public class Views_TestIna_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<kreaTid.Models.Product>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\John\EFIF\OneDrive - EFIF\Webdevelopment\KreaTid\kreaTid\Views\TestIna\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec970ce1345762c2b6a2543cbe61e6d980d8a6383597", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Index</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec970ce1345762c2b6a2543cbe61e6d980d8a6384656", async() => {
                WriteLiteral("\r\n\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 24 "C:\Users\John\EFIF\OneDrive - EFIF\Webdevelopment\KreaTid\kreaTid\Views\TestIna\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 27 "C:\Users\John\EFIF\OneDrive - EFIF\Webdevelopment\KreaTid\kreaTid\Views\TestIna\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.ProductPrice));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 30 "C:\Users\John\EFIF\OneDrive - EFIF\Webdevelopment\KreaTid\kreaTid\Views\TestIna\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.ProductDescription));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 33 "C:\Users\John\EFIF\OneDrive - EFIF\Webdevelopment\KreaTid\kreaTid\Views\TestIna\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    <b>Comments</b> \r\n                </th>\r\n                <th>\r\n                    <b>Images</b>\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n\r\n        <tbody>\r\n");
#nullable restore
#line 45 "C:\Users\John\EFIF\OneDrive - EFIF\Webdevelopment\KreaTid\kreaTid\Views\TestIna\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 49 "C:\Users\John\EFIF\OneDrive - EFIF\Webdevelopment\KreaTid\kreaTid\Views\TestIna\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 52 "C:\Users\John\EFIF\OneDrive - EFIF\Webdevelopment\KreaTid\kreaTid\Views\TestIna\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductPrice));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 55 "C:\Users\John\EFIF\OneDrive - EFIF\Webdevelopment\KreaTid\kreaTid\Views\TestIna\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductDescription));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 58 "C:\Users\John\EFIF\OneDrive - EFIF\Webdevelopment\KreaTid\kreaTid\Views\TestIna\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Category.CategoryName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <div>\r\n");
#nullable restore
#line 62 "C:\Users\John\EFIF\OneDrive - EFIF\Webdevelopment\KreaTid\kreaTid\Views\TestIna\Index.cshtml"
                         foreach (ProductComment pc in item.ProductComments)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <p>");
#nullable restore
#line 64 "C:\Users\John\EFIF\OneDrive - EFIF\Webdevelopment\KreaTid\kreaTid\Views\TestIna\Index.cshtml"
                          Write(await Html.PartialAsync("_ProductComment", pc));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 65 "C:\Users\John\EFIF\OneDrive - EFIF\Webdevelopment\KreaTid\kreaTid\Views\TestIna\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </td>\r\n                <td>\r\n                    <div>\r\n");
#nullable restore
#line 71 "C:\Users\John\EFIF\OneDrive - EFIF\Webdevelopment\KreaTid\kreaTid\Views\TestIna\Index.cshtml"
                         foreach (ProductImg pc in item.ProductImgs)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <p>");
#nullable restore
#line 73 "C:\Users\John\EFIF\OneDrive - EFIF\Webdevelopment\KreaTid\kreaTid\Views\TestIna\Index.cshtml"
                          Write(await Html.PartialAsync("_ProductImg", pc));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 74 "C:\Users\John\EFIF\OneDrive - EFIF\Webdevelopment\KreaTid\kreaTid\Views\TestIna\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 79 "C:\Users\John\EFIF\OneDrive - EFIF\Webdevelopment\KreaTid\kreaTid\Views\TestIna\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n\r\n\r\n    </table>\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<kreaTid.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591