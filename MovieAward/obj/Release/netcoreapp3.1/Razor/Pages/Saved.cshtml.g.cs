#pragma checksum "/Users/omega/Documents/GitHub/MovieAward/MovieAward/Pages/Saved.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5383504d8f302eb0b586db14a6f0972395e95496"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MovieAward.Pages.Pages_Saved), @"mvc.1.0.razor-page", @"/Pages/Saved.cshtml")]
namespace MovieAward.Pages
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
#line 1 "/Users/omega/Documents/GitHub/MovieAward/MovieAward/Pages/_ViewImports.cshtml"
using MovieAward;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/omega/Documents/GitHub/MovieAward/MovieAward/Pages/Saved.cshtml"
using MovieAward.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/omega/Documents/GitHub/MovieAward/MovieAward/Pages/Saved.cshtml"
using MovieAward.Components;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5383504d8f302eb0b586db14a6f0972395e95496", @"/Pages/Saved.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f57543ce2d243720e5b40130f63d7c2f3c78a92", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Saved : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ComponentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "/Users/omega/Documents/GitHub/MovieAward/MovieAward/Pages/Saved.cshtml"
  
    ViewData["Title"] = "Nominated Movies";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"results\" class=\"col\">\r\n    <div class=\"row d-flex justify-content-center\">\r\n        <h1>");
#nullable restore
#line 11 "/Users/omega/Documents/GitHub/MovieAward/MovieAward/Pages/Saved.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    </div>\r\n    <div class=\"row d-flex justify-content-center\">\r\n");
#nullable restore
#line 14 "/Users/omega/Documents/GitHub/MovieAward/MovieAward/Pages/Saved.cshtml"
         if(Model.Movies == null || Model.Movies.Count == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>No nominated movies found! </p><br>\r\n");
            WriteLiteral("            <p> To nominate a movie, search a title and give it an award.</p>\r\n");
#nullable restore
#line 19 "/Users/omega/Documents/GitHub/MovieAward/MovieAward/Pages/Saved.cshtml"
        } else {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "/Users/omega/Documents/GitHub/MovieAward/MovieAward/Pages/Saved.cshtml"
             foreach(MovieModel movie in Model.Movies)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("component", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5383504d8f302eb0b586db14a6f0972395e954964599", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ComponentTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper);
#nullable restore
#line 22 "/Users/omega/Documents/GitHub/MovieAward/MovieAward/Pages/Saved.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.ComponentType = typeof(MovieCard);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("type", __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.ComponentType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 23 "/Users/omega/Documents/GitHub/MovieAward/MovieAward/Pages/Saved.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.RenderMode = global::Microsoft.AspNetCore.Mvc.Rendering.RenderMode.ServerPrerendered;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("render-mode", __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.RenderMode, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.Parameters == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("param-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.ComponentTagHelper", "Parameters"));
            }
#nullable restore
#line 24 "/Users/omega/Documents/GitHub/MovieAward/MovieAward/Pages/Saved.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.Parameters["Id"] = movie.ImdbId;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("param-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.Parameters["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 25 "/Users/omega/Documents/GitHub/MovieAward/MovieAward/Pages/Saved.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.Parameters["Title"] = movie.Title;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("param-Title", __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.Parameters["Title"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 26 "/Users/omega/Documents/GitHub/MovieAward/MovieAward/Pages/Saved.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.Parameters["Year"] = movie.Year;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("param-Year", __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.Parameters["Year"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 27 "/Users/omega/Documents/GitHub/MovieAward/MovieAward/Pages/Saved.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.Parameters["Poster"] = movie.Poster;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("param-Poster", __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.Parameters["Poster"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 28 "/Users/omega/Documents/GitHub/MovieAward/MovieAward/Pages/Saved.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.Parameters["Saved"] = movie.Saved;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("param-Saved", __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.Parameters["Saved"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 30 "/Users/omega/Documents/GitHub/MovieAward/MovieAward/Pages/Saved.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "/Users/omega/Documents/GitHub/MovieAward/MovieAward/Pages/Saved.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieAward.Pages.SavedModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MovieAward.Pages.SavedModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MovieAward.Pages.SavedModel>)PageContext?.ViewData;
        public MovieAward.Pages.SavedModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
