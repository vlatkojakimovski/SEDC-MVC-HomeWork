#pragma checksum "C:\Users\Jakimovski\Desktop\Programming Staff\SEAVUS Academu .NET Developer\MVC\SEDC MVC HomeWork\Class_03\SEDC.PizzaApp\SEDC.PizzaApp.Web\Views\Pizza\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f635ab7aa932cf0e4bb4c175809d0f42087bf1b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pizza_Index), @"mvc.1.0.view", @"/Views/Pizza/Index.cshtml")]
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
#line 1 "C:\Users\Jakimovski\Desktop\Programming Staff\SEAVUS Academu .NET Developer\MVC\SEDC MVC HomeWork\Class_03\SEDC.PizzaApp\SEDC.PizzaApp.Web\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jakimovski\Desktop\Programming Staff\SEAVUS Academu .NET Developer\MVC\SEDC MVC HomeWork\Class_03\SEDC.PizzaApp\SEDC.PizzaApp.Web\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f635ab7aa932cf0e4bb4c175809d0f42087bf1b3", @"/Views/Pizza/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"731fa6b6e3c434427b4dc202e8a894ac8774225c", @"/Views/_ViewImports.cshtml")]
    public class Views_Pizza_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SEDC.PizzaApp.Web.Models.ViewModels.PizzaDetailsViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h3 class=\"text-center\">");
#nullable restore
#line 3 "C:\Users\Jakimovski\Desktop\Programming Staff\SEAVUS Academu .NET Developer\MVC\SEDC MVC HomeWork\Class_03\SEDC.PizzaApp\SEDC.PizzaApp.Web\Views\Pizza\Index.cshtml"
                   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 19 "C:\Users\Jakimovski\Desktop\Programming Staff\SEAVUS Academu .NET Developer\MVC\SEDC MVC HomeWork\Class_03\SEDC.PizzaApp\SEDC.PizzaApp.Web\Views\Pizza\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row container font-weight-bold \">\r\n\r\n        <div class=\"col-md-12 border text-left border-info text-left\"> ");
#nullable restore
#line 23 "C:\Users\Jakimovski\Desktop\Programming Staff\SEAVUS Academu .NET Developer\MVC\SEDC MVC HomeWork\Class_03\SEDC.PizzaApp\SEDC.PizzaApp.Web\Views\Pizza\Index.cshtml"
                                                                  Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n            <div class=\"col-md-1 border text-left border-info\">Name: </div>\r\n            <div class=\"col-md-11 text-left border\"> ");
#nullable restore
#line 26 "C:\Users\Jakimovski\Desktop\Programming Staff\SEAVUS Academu .NET Developer\MVC\SEDC MVC HomeWork\Class_03\SEDC.PizzaApp\SEDC.PizzaApp.Web\Views\Pizza\Index.cshtml"
                                                Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 26 "C:\Users\Jakimovski\Desktop\Programming Staff\SEAVUS Academu .NET Developer\MVC\SEDC MVC HomeWork\Class_03\SEDC.PizzaApp\SEDC.PizzaApp.Web\Views\Pizza\Index.cshtml"
                                                         Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"col-md-1 border text-left border-info\">Size: </div>\r\n            <div class=\"col-md-11 text-left border\"> ");
#nullable restore
#line 28 "C:\Users\Jakimovski\Desktop\Programming Staff\SEAVUS Academu .NET Developer\MVC\SEDC MVC HomeWork\Class_03\SEDC.PizzaApp\SEDC.PizzaApp.Web\Views\Pizza\Index.cshtml"
                                                Write(item.PizzaSize);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"col-md-1 border text-left border-info\">Price: </div>\r\n            <div class=\"col-md-11 text-left border\"> $");
#nullable restore
#line 30 "C:\Users\Jakimovski\Desktop\Programming Staff\SEAVUS Academu .NET Developer\MVC\SEDC MVC HomeWork\Class_03\SEDC.PizzaApp\SEDC.PizzaApp.Web\Views\Pizza\Index.cshtml"
                                                 Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    \r\n\r\n    </div>\r\n");
#nullable restore
#line 34 "C:\Users\Jakimovski\Desktop\Programming Staff\SEAVUS Academu .NET Developer\MVC\SEDC MVC HomeWork\Class_03\SEDC.PizzaApp\SEDC.PizzaApp.Web\Views\Pizza\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SEDC.PizzaApp.Web.Models.ViewModels.PizzaDetailsViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
