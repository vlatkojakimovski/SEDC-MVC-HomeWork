#pragma checksum "C:\Users\Jakimovski\Desktop\Programming Staff\SEAVUS Academu .NET Developer\MVC\SEDC MVC HomeWork\Class_03\SEDC.PizzaApp\SEDC.PizzaApp.Web\Views\Pizza\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffe25197ae597ab13c7b58544f017340de80e828"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pizza_Details), @"mvc.1.0.view", @"/Views/Pizza/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffe25197ae597ab13c7b58544f017340de80e828", @"/Views/Pizza/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"731fa6b6e3c434427b4dc202e8a894ac8774225c", @"/Views/_ViewImports.cshtml")]
    public class Views_Pizza_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2 class=\"text-body\">");
#nullable restore
#line 1 "C:\Users\Jakimovski\Desktop\Programming Staff\SEAVUS Academu .NET Developer\MVC\SEDC MVC HomeWork\Class_03\SEDC.PizzaApp\SEDC.PizzaApp.Web\Views\Pizza\Details.cshtml"
                 Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n\r\n\r\n\r\n\r\n<div class=\"row container \">\r\n\r\n    <div class=\"col-md-1 border text-left border-info\">Name: </div>\r\n    <div class=\"col-md-11 text-left border\"> ");
#nullable restore
#line 10 "C:\Users\Jakimovski\Desktop\Programming Staff\SEAVUS Academu .NET Developer\MVC\SEDC MVC HomeWork\Class_03\SEDC.PizzaApp\SEDC.PizzaApp.Web\Views\Pizza\Details.cshtml"
                                        Write(ViewBag.Pizza.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 10 "C:\Users\Jakimovski\Desktop\Programming Staff\SEAVUS Academu .NET Developer\MVC\SEDC MVC HomeWork\Class_03\SEDC.PizzaApp\SEDC.PizzaApp.Web\Views\Pizza\Details.cshtml"
                                                          Write(ViewBag.Pizza.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div class=\"col-md-1 border text-left border-info\">Size: </div>\r\n    <div class=\"col-md-11 text-left border\"> ");
#nullable restore
#line 12 "C:\Users\Jakimovski\Desktop\Programming Staff\SEAVUS Academu .NET Developer\MVC\SEDC MVC HomeWork\Class_03\SEDC.PizzaApp\SEDC.PizzaApp.Web\Views\Pizza\Details.cshtml"
                                        Write(ViewBag.Pizza.PizzaSize);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div class=\"col-md-1 border text-left border-info\">Price: </div>\r\n    <div class=\"col-md-11 text-left border\"> $");
#nullable restore
#line 14 "C:\Users\Jakimovski\Desktop\Programming Staff\SEAVUS Academu .NET Developer\MVC\SEDC MVC HomeWork\Class_03\SEDC.PizzaApp\SEDC.PizzaApp.Web\Views\Pizza\Details.cshtml"
                                         Write(ViewBag.Pizza.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591