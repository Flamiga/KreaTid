#pragma checksum "C:\Users\John\EFIF\OneDrive - EFIF\Webdevelopment\KreaTid\kreaTid\Views\InspirationPage\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a711fb58f01f1eb5f3bb8a426fb237af99f64783"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_InspirationPage_Index), @"mvc.1.0.view", @"/Views/InspirationPage/Index.cshtml")]
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
#line 1 "C:\Users\John\EFIF\OneDrive - EFIF\Webdevelopment\KreaTid\kreaTid\Views\InspirationPage\Index.cshtml"
using kreaTid.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a711fb58f01f1eb5f3bb8a426fb237af99f64783", @"/Views/InspirationPage/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d28acaf2ebed72b6cc848a3813530b6315c9311", @"/Views/_ViewImports.cshtml")]
    public class Views_InspirationPage_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<kreaTid.Models.BlogPost>>
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
#nullable restore
#line 3 "C:\Users\John\EFIF\OneDrive - EFIF\Webdevelopment\KreaTid\kreaTid\Views\InspirationPage\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a711fb58f01f1eb5f3bb8a426fb237af99f647833584", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a711fb58f01f1eb5f3bb8a426fb237af99f647834643", async() => {
                WriteLiteral("\r\n\r\n\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 21 "C:\Users\John\EFIF\OneDrive - EFIF\Webdevelopment\KreaTid\kreaTid\Views\InspirationPage\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.BlogPostTitle));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 24 "C:\Users\John\EFIF\OneDrive - EFIF\Webdevelopment\KreaTid\kreaTid\Views\InspirationPage\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.BlogPostDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 27 "C:\Users\John\EFIF\OneDrive - EFIF\Webdevelopment\KreaTid\kreaTid\Views\InspirationPage\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.BlogPostContent));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </th>
                <th>
                    <b>Images</b>
                </th>
                <th>
                    <b>Comments</b>
                </th>
                <th></th>
            </tr>
        </thead>

        <tbody>
");
#nullable restore
#line 40 "C:\Users\John\EFIF\OneDrive - EFIF\Webdevelopment\KreaTid\kreaTid\Views\InspirationPage\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 44 "C:\Users\John\EFIF\OneDrive - EFIF\Webdevelopment\KreaTid\kreaTid\Views\InspirationPage\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.BlogPostTitle));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 47 "C:\Users\John\EFIF\OneDrive - EFIF\Webdevelopment\KreaTid\kreaTid\Views\InspirationPage\Index.cshtml"
                   Write(item.BlogPostDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 50 "C:\Users\John\EFIF\OneDrive - EFIF\Webdevelopment\KreaTid\kreaTid\Views\InspirationPage\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.BlogPostContent));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <div>\r\n");
#nullable restore
#line 54 "C:\Users\John\EFIF\OneDrive - EFIF\Webdevelopment\KreaTid\kreaTid\Views\InspirationPage\Index.cshtml"
                             foreach (BlogPostImg BPI in item.BlogPostImgs)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <p>");
#nullable restore
#line 56 "C:\Users\John\EFIF\OneDrive - EFIF\Webdevelopment\KreaTid\kreaTid\Views\InspirationPage\Index.cshtml"
                              Write(await Html.PartialAsync("_BlogPostImg", BPI));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 57 "C:\Users\John\EFIF\OneDrive - EFIF\Webdevelopment\KreaTid\kreaTid\Views\InspirationPage\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </td>\r\n                    <td>\r\n                        <div>\r\n");
#nullable restore
#line 63 "C:\Users\John\EFIF\OneDrive - EFIF\Webdevelopment\KreaTid\kreaTid\Views\InspirationPage\Index.cshtml"
                             foreach (BlogPostComment Bc in item.BlogPostComments)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <p>");
#nullable restore
#line 65 "C:\Users\John\EFIF\OneDrive - EFIF\Webdevelopment\KreaTid\kreaTid\Views\InspirationPage\Index.cshtml"
                              Write(await Html.PartialAsync("_BlogPostComment", Bc));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 66 "C:\Users\John\EFIF\OneDrive - EFIF\Webdevelopment\KreaTid\kreaTid\Views\InspirationPage\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 72 "C:\Users\John\EFIF\OneDrive - EFIF\Webdevelopment\KreaTid\kreaTid\Views\InspirationPage\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<kreaTid.Models.BlogPost>> Html { get; private set; }
    }
}
#pragma warning restore 1591
