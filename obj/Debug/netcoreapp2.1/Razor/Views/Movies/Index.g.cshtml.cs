#pragma checksum "C:\Users\daraXi\source\repos\MoviesDbMVC\MoviesDbMVC\Views\Movies\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c850516f0cdf63073b2367dedad6673ae9b8583"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Index), @"mvc.1.0.view", @"/Views/Movies/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movies/Index.cshtml", typeof(AspNetCore.Views_Movies_Index))]
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
#line 1 "C:\Users\daraXi\source\repos\MoviesDbMVC\MoviesDbMVC\Views\_ViewImports.cshtml"
using MoviesDbMVC;

#line default
#line hidden
#line 2 "C:\Users\daraXi\source\repos\MoviesDbMVC\MoviesDbMVC\Views\_ViewImports.cshtml"
using MoviesDbMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c850516f0cdf63073b2367dedad6673ae9b8583", @"/Views/Movies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6494eeebd54f52a3229fc5d5205b8039a613068f", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MoviesDbMVC.Models.Movie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\daraXi\source\repos\MoviesDbMVC\MoviesDbMVC\Views\Movies\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(89, 36, true);
            WriteLiteral("\r\n<div class=\"row card-container\">\r\n");
            EndContext();
#line 8 "C:\Users\daraXi\source\repos\MoviesDbMVC\MoviesDbMVC\Views\Movies\Index.cshtml"
     foreach (var movie in Model)
    {
        

#line default
#line hidden
            BeginContext(176, 68, false);
#line 10 "C:\Users\daraXi\source\repos\MoviesDbMVC\MoviesDbMVC\Views\Movies\Index.cshtml"
   Write(await Html.PartialAsync("~/Views/Partials/_cardMovie.cshtml", movie));

#line default
#line hidden
            EndContext();
#line 10 "C:\Users\daraXi\source\repos\MoviesDbMVC\MoviesDbMVC\Views\Movies\Index.cshtml"
                                                                             
    }

#line default
#line hidden
            BeginContext(253, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MoviesDbMVC.Models.Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
