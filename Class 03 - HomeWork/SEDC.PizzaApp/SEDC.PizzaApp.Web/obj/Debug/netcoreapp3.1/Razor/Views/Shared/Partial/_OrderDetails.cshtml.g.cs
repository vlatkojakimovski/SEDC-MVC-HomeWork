#pragma checksum "C:\Users\Jakimovski\Desktop\Programming Staff\SEAVUS Academu .NET Developer\MVC\MVC HomeWork\Class 03 - HomeWork\SEDC.PizzaApp\SEDC.PizzaApp.Web\Views\Shared\Partial\_OrderDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6298c4f9893d67c0b4d1b3bb432e62e103593a6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Partial__OrderDetails), @"mvc.1.0.view", @"/Views/Shared/Partial/_OrderDetails.cshtml")]
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
#line 1 "C:\Users\Jakimovski\Desktop\Programming Staff\SEAVUS Academu .NET Developer\MVC\MVC HomeWork\Class 03 - HomeWork\SEDC.PizzaApp\SEDC.PizzaApp.Web\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jakimovski\Desktop\Programming Staff\SEAVUS Academu .NET Developer\MVC\MVC HomeWork\Class 03 - HomeWork\SEDC.PizzaApp\SEDC.PizzaApp.Web\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6298c4f9893d67c0b4d1b3bb432e62e103593a6b", @"/Views/Shared/Partial/_OrderDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"731fa6b6e3c434427b4dc202e8a894ac8774225c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Partial__OrderDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        <p>Id: ");
#nullable restore
#line 6 "C:\Users\Jakimovski\Desktop\Programming Staff\SEAVUS Academu .NET Developer\MVC\MVC HomeWork\Class 03 - HomeWork\SEDC.PizzaApp\SEDC.PizzaApp.Web\Views\Shared\Partial\_OrderDetails.cshtml"
          Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Payment method: ");
#nullable restore
#line 7 "C:\Users\Jakimovski\Desktop\Programming Staff\SEAVUS Academu .NET Developer\MVC\MVC HomeWork\Class 03 - HomeWork\SEDC.PizzaApp\SEDC.PizzaApp.Web\Views\Shared\Partial\_OrderDetails.cshtml"
                      Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</p>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
