// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "c:\Users\rngei\Desktop\SportsStore\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "c:\Users\rngei\Desktop\SportsStore\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "c:\Users\rngei\Desktop\SportsStore\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "c:\Users\rngei\Desktop\SportsStore\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "c:\Users\rngei\Desktop\SportsStore\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "c:\Users\rngei\Desktop\SportsStore\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#line 7 "c:\Users\rngei\Desktop\SportsStore\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 9 "c:\Users\rngei\Desktop\SportsStore\BlazorApp\Pages\Counter.razor"
       
    int currentCount = 0;

    void IncrementCount() {
        currentCount++;
        System.Console.WriteLine("Counter: " + currentCount);
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
