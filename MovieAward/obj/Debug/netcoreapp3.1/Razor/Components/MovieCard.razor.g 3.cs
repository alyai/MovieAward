#pragma checksum "/Users/omega/Documents/GitHub/MovieAward/MovieAward/Components/MovieCard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad7cc0625b96fe01d660b988c050a1dfea214124"
// <auto-generated/>
#pragma warning disable 1591
namespace MovieAward.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/omega/Documents/GitHub/MovieAward/MovieAward/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/omega/Documents/GitHub/MovieAward/MovieAward/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/omega/Documents/GitHub/MovieAward/MovieAward/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/omega/Documents/GitHub/MovieAward/MovieAward/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/omega/Documents/GitHub/MovieAward/MovieAward/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/omega/Documents/GitHub/MovieAward/MovieAward/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/omega/Documents/GitHub/MovieAward/MovieAward/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/omega/Documents/GitHub/MovieAward/MovieAward/_Imports.razor"
using MovieAward;

#line default
#line hidden
#nullable disable
    public partial class MovieCard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "a");
            __builder.AddAttribute(1, "class", "card");
            __builder.AddAttribute(2, "href", "/Detail?id=" + (
#nullable restore
#line 1 "/Users/omega/Documents/GitHub/MovieAward/MovieAward/Components/MovieCard.razor"
                                  Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(3, "\n        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card");
            __builder.AddAttribute(6, "style", "width: 10rem;");
            __builder.AddMarkupContent(7, "\n                ");
            __builder.OpenElement(8, "h5");
            __builder.AddMarkupContent(9, "\n                    ");
            __builder.AddContent(10, 
#nullable restore
#line 4 "/Users/omega/Documents/GitHub/MovieAward/MovieAward/Components/MovieCard.razor"
                     Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(11, "\n");
#nullable restore
#line 5 "/Users/omega/Documents/GitHub/MovieAward/MovieAward/Components/MovieCard.razor"
                     if (Saved)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "                        ");
            __builder.OpenElement(13, "i");
            __builder.AddAttribute(14, "class", "fas fa-award saved");
            __builder.AddAttribute(15, "title", 
#nullable restore
#line 7 "/Users/omega/Documents/GitHub/MovieAward/MovieAward/Components/MovieCard.razor"
                                                               Saved ? "Unsave" : "Save"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n");
#nullable restore
#line 8 "/Users/omega/Documents/GitHub/MovieAward/MovieAward/Components/MovieCard.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n                ");
            __builder.OpenElement(19, "p");
            __builder.AddContent(20, 
#nullable restore
#line 10 "/Users/omega/Documents/GitHub/MovieAward/MovieAward/Components/MovieCard.razor"
                    Year

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n                ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "row h-200");
            __builder.AddMarkupContent(24, "\n                    ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "col d-flex align-items-center");
            __builder.AddMarkupContent(27, "\n                        ");
            __builder.OpenElement(28, "img");
            __builder.AddAttribute(29, "class", "card-img-top");
            __builder.AddAttribute(30, "src", 
#nullable restore
#line 13 "/Users/omega/Documents/GitHub/MovieAward/MovieAward/Components/MovieCard.razor"
                                                        Poster

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(31, "height", "200");
            __builder.AddAttribute(32, "width", "100");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "/Users/omega/Documents/GitHub/MovieAward/MovieAward/Components/MovieCard.razor"
      
    [Parameter]
    public string Id { get; set; }

    [Parameter]
    public string Title { get; set; }

    [Parameter]
    public string Year { get; set; }

    [Parameter]
    public string Poster { get; set; }

    [Parameter]
    public bool Saved { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591