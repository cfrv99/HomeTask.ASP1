#pragma checksum "C:\Users\Murad\source\repos\HomeTask.LibraryProject\HomeTask.LibraryProject\Views\Shared\Components\BestBooksAuthor\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1485eeca5138f99d4110c44f19d5a286b573189f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BestBooksAuthor_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BestBooksAuthor/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/BestBooksAuthor/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_BestBooksAuthor_Default))]
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
#line 1 "C:\Users\Murad\source\repos\HomeTask.LibraryProject\HomeTask.LibraryProject\Views\_ViewImports.cshtml"
using HomeTask.LibraryProject;

#line default
#line hidden
#line 2 "C:\Users\Murad\source\repos\HomeTask.LibraryProject\HomeTask.LibraryProject\Views\_ViewImports.cshtml"
using HomeTask.LibraryProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1485eeca5138f99d4110c44f19d5a286b573189f", @"/Views/Shared/Components/BestBooksAuthor/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c60de6d31820deb93ef49f2efbd0e387b1b3d9f0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_BestBooksAuthor_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AuthorBookCountViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 122, true);
            WriteLiteral("    <div class=\"card\" style=\"width: 18rem;\">\r\n        \r\n        <div class=\"card-body\">\r\n            <p class=\"card-text\">");
            EndContext();
            BeginContext(156, 16, false);
#line 5 "C:\Users\Murad\source\repos\HomeTask.LibraryProject\HomeTask.LibraryProject\Views\Shared\Components\BestBooksAuthor\Default.cshtml"
                            Write(Model.AuthorName);

#line default
#line hidden
            EndContext();
            BeginContext(172, 38, true);
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n\r\n\r\n");
            EndContext();
#line 10 "C:\Users\Murad\source\repos\HomeTask.LibraryProject\HomeTask.LibraryProject\Views\Shared\Components\BestBooksAuthor\Default.cshtml"
 foreach (var item in Model.Books)
{

#line default
#line hidden
            BeginContext(249, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(253, 9, false);
#line 12 "C:\Users\Murad\source\repos\HomeTask.LibraryProject\HomeTask.LibraryProject\Views\Shared\Components\BestBooksAuthor\Default.cshtml"
Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(262, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 13 "C:\Users\Murad\source\repos\HomeTask.LibraryProject\HomeTask.LibraryProject\Views\Shared\Components\BestBooksAuthor\Default.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AuthorBookCountViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
