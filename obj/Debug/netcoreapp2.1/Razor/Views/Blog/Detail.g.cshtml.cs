#pragma checksum "D:\OneDrive\TM\IMD3\dotnet\BloggingEngine\Views\Blog\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f42303878c38b972f89a8692214df4c16c533bc1"
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
#line 2 "D:\OneDrive\TM\IMD3\dotnet\BloggingEngine\Views\Blog\Detail.cshtml"
using EntityFrameworkMvc.DataAccess;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f42303878c38b972f89a8692214df4c16c533bc1", @"/Views/Blog/Detail.cshtml")]
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
            BeginContext(81, 39, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <h2>\r\n        ");
            EndContext();
            BeginContext(121, 11, false);
#line 6 "D:\OneDrive\TM\IMD3\dotnet\BloggingEngine\Views\Blog\Detail.cshtml"
   Write(Model.title);

#line default
#line hidden
            EndContext();
            BeginContext(132, 49, true);
            WriteLiteral("\r\n    </h2>\r\n    <p style=\"white-space:pre-wrap\">");
            EndContext();
            BeginContext(182, 24, false);
#line 8 "D:\OneDrive\TM\IMD3\dotnet\BloggingEngine\Views\Blog\Detail.cshtml"
                               Write(Html.Raw(@Model.content));

#line default
#line hidden
            EndContext();
            BeginContext(206, 24, true);
            WriteLiteral("</p>\r\n    <i>written by ");
            EndContext();
            BeginContext(231, 12, false);
#line 9 "D:\OneDrive\TM\IMD3\dotnet\BloggingEngine\Views\Blog\Detail.cshtml"
             Write(Model.author);

#line default
#line hidden
            EndContext();
            BeginContext(243, 12, true);
            WriteLiteral(" - uploaded ");
            EndContext();
            BeginContext(256, 10, false);
#line 9 "D:\OneDrive\TM\IMD3\dotnet\BloggingEngine\Views\Blog\Detail.cshtml"
                                      Write(Model.date);

#line default
#line hidden
            EndContext();
            BeginContext(266, 25, true);
            WriteLiteral("</i>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(291, 240, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99e5b4b3a4ba43e5abefbc1d93f098d8", async() => {
                BeginContext(354, 44, true);
                WriteLiteral("\r\n        <input name=\"postId\" type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 398, "", 414, 1);
#line 13 "D:\OneDrive\TM\IMD3\dotnet\BloggingEngine\Views\Blog\Detail.cshtml"
WriteAttributeValue("", 405, Model.id, 405, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(414, 110, true);
                WriteLiteral(" />\r\n        <input name=\"text\" type=\"text\">\r\n        <button class=\"btn\" type=\"submit\">comment</button>\r\n    ");
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
            BeginContext(531, 49, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    <ul class=\"list-unstyled\">\r\n");
            EndContext();
#line 20 "D:\OneDrive\TM\IMD3\dotnet\BloggingEngine\Views\Blog\Detail.cshtml"
     foreach(Comment comment in @Model.Comments) {

#line default
#line hidden
            BeginContext(632, 38, true);
            WriteLiteral("        <li class=\"comment mt-1 mb-1\">");
            EndContext();
            BeginContext(671, 12, false);
#line 21 "D:\OneDrive\TM\IMD3\dotnet\BloggingEngine\Views\Blog\Detail.cshtml"
                                 Write(comment.text);

#line default
#line hidden
            EndContext();
            BeginContext(683, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 22 "D:\OneDrive\TM\IMD3\dotnet\BloggingEngine\Views\Blog\Detail.cshtml"
    }

#line default
#line hidden
            BeginContext(697, 62, true);
            WriteLiteral("    </ul>\r\n</div>\r\n<div>\r\n    <a href=\"/Blog\">back</a>\r\n</div>");
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
