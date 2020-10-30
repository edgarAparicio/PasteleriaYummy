#pragma checksum "C:\Users\edgar\Google Drive\Applications Development\Git\PasteleriaYummy\PasteleriaYummy\Views\CarritoCompras\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98b0b5cf8bc851f5c59413c354fb121ccf1f42e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CarritoCompras_Index), @"mvc.1.0.view", @"/Views/CarritoCompras/Index.cshtml")]
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
#line 1 "C:\Users\edgar\Google Drive\Applications Development\Git\PasteleriaYummy\PasteleriaYummy\Views\_ViewImports.cshtml"
using EdgarAparicio.PastelesYummy.Business.Entity.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\edgar\Google Drive\Applications Development\Git\PasteleriaYummy\PasteleriaYummy\Views\_ViewImports.cshtml"
using EdgarAparicio.PastelesYummy.Business.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98b0b5cf8bc851f5c59413c354fb121ccf1f42e5", @"/Views/CarritoCompras/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e69c1c02a6d069bd7149068307114aeeaa44ddd", @"/Views/_ViewImports.cshtml")]
    public class Views_CarritoCompras_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PasteleriaYummy.ViewModels.CarritoComprasViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h2>Tu carrito de compras</h2>
<h4>Aqui tienes tus deliciosos pasteles en tu carrito de compras</h4>

<table class=""table table-bordered table-striped"">
    <thead>
        <tr>
            <th>Cantidad seleccionada</th>
            <th>Pastel</th>
            <th class=""text-right"">Precio</th>
            <th class=""text-right"">Subtotal</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 16 "C:\Users\edgar\Google Drive\Applications Development\Git\PasteleriaYummy\PasteleriaYummy\Views\CarritoCompras\Index.cshtml"
         foreach (var linea in Model.DataCarritoCompras.ListaArticulosCarritoCompras)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td class=\"text-center\">");
#nullable restore
#line 19 "C:\Users\edgar\Google Drive\Applications Development\Git\PasteleriaYummy\PasteleriaYummy\Views\CarritoCompras\Index.cshtml"
                                   Write(linea.Cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-left\">");
#nullable restore
#line 20 "C:\Users\edgar\Google Drive\Applications Development\Git\PasteleriaYummy\PasteleriaYummy\Views\CarritoCompras\Index.cshtml"
                                 Write(linea.Pastel.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-right\">");
#nullable restore
#line 21 "C:\Users\edgar\Google Drive\Applications Development\Git\PasteleriaYummy\PasteleriaYummy\Views\CarritoCompras\Index.cshtml"
                                  Write(linea.Pastel.Precio.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-right\">\r\n                    ");
#nullable restore
#line 23 "C:\Users\edgar\Google Drive\Applications Development\Git\PasteleriaYummy\PasteleriaYummy\Views\CarritoCompras\Index.cshtml"
                Write((linea.Cantidad * linea.Pastel.Precio).ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 26 "C:\Users\edgar\Google Drive\Applications Development\Git\PasteleriaYummy\PasteleriaYummy\Views\CarritoCompras\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n    <tfoot>\r\n        <tr>\r\n            <td colspan=\"3\" class=\"text-right\">Total:</td>\r\n            <td class=\"text-right\">\r\n                ");
#nullable restore
#line 32 "C:\Users\edgar\Google Drive\Applications Development\Git\PasteleriaYummy\PasteleriaYummy\Views\CarritoCompras\Index.cshtml"
           Write(Model.TotalCarritoCompras.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n    </tfoot>\r\n\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PasteleriaYummy.ViewModels.CarritoComprasViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591