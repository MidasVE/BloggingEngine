#pragma checksum "D:\OneDrive\TM\IMD3\dotnet\BloggingEngine\Views\Blog\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b09689c3859a8db58424170c7c342ff54d69c3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Detail), @"mvc.1.0.view", @"/Views/Blog/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/Detail.cshtml", typeof(AspNetCore.Views_Blog_Detail))]
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
#line 1 "D:\OneDrive\TM\IMD3\dotnet\BloggingEngine\Views\_ViewImports.cshtml"
using BloggingEngine;

#line default
#line hidden
#line 2 "D:\OneDrive\TM\IMD3\dotnet\BloggingEngine\Views\_ViewImports.cshtml"
using BloggingEngine.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b09689c3859a8db58424170c7c342ff54d69c3f", @"/Views/Blog/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a401ff359e24fb29a951e4bcc0eb52919aca01b", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityFrameworkMvc.DataAccess.Post>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Comment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 27, true);
            WriteLiteral("\r\n<div>\r\n    <h2>\r\n        ");
            EndContext();
            BeginContext(71, 11, false);
#line 5 "D:\OneDrive\TM\IMD3\dotnet\BloggingEngine\Views\Blog\Detail.cshtml"
   Write(Model.title);

#line default
#line hidden
            EndContext();
            BeginContext(82, 20, true);
            WriteLiteral("\r\n    </h2>\r\n    <p>");
            EndContext();
            BeginContext(103, 13, false);
#line 7 "D:\OneDrive\TM\IMD3\dotnet\BloggingEngine\Views\Blog\Detail.cshtml"
  Write(Model.content);

#line default
#line hidden
            EndContext();
            BeginContext(116, 24, true);
            WriteLiteral("</p>\r\n    <i>written by ");
            EndContext();
            BeginContext(141, 12, false);
#line 8 "D:\OneDrive\TM\IMD3\dotnet\BloggingEngine\Views\Blog\Detail.cshtml"
             Write(Model.author);

#line default
#line hidden
            EndContext();
            BeginContext(153, 12, true);
            WriteLiteral(" - uploaded ");
            EndContext();
            BeginContext(166, 10, false);
#line 8 "D:\OneDrive\TM\IMD3\dotnet\BloggingEngine\Views\Blog\Detail.cshtml"
                                      Write(Model.date);

#line default
#line hidden
            EndContext();
            BeginContext(176, 25, true);
            WriteLiteral("</i>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(201, 228, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "035ccaa4f1b9488eb9f0c122e25fc3c1", async() => {
                BeginContext(264, 44, true);
                WriteLiteral("\r\n        <input name=\"postId\" type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 308, "", 324, 1);
#line 12 "D:\OneDrive\TM\IMD3\dotnet\BloggingEngine\Views\Blog\Detail.cshtml"
WriteAttributeValue("", 315, Model.id, 315, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(324, 98, true);
                WriteLiteral(" />\r\n        <input name=\"text\" type=\"text\">\r\n        <button type=\"submit\">comment</button>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(429, 53, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    <a href=\"/Blog\">back</a>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityFrameworkMvc.DataAccess.Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
