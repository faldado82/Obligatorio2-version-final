#pragma checksum "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 2\P2\OBLIGATORIO 2 P2\version final\Obligatorio2 version final\Obligatorio2\Views\Compra\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96afdc6075843504387a41ba9ad9e62bfc5fb261"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Compra_Index), @"mvc.1.0.view", @"/Views/Compra/Index.cshtml")]
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
#line 1 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 2\P2\OBLIGATORIO 2 P2\version final\Obligatorio2 version final\Obligatorio2\Views\_ViewImports.cshtml"
using Obligatorio2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 2\P2\OBLIGATORIO 2 P2\version final\Obligatorio2 version final\Obligatorio2\Views\_ViewImports.cshtml"
using Obligatorio2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 2\P2\OBLIGATORIO 2 P2\version final\Obligatorio2 version final\Obligatorio2\Views\Compra\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96afdc6075843504387a41ba9ad9e62bfc5fb261", @"/Views/Compra/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87e36970f455aae1bee373d97230b042ea67aa2f", @"/Views/_ViewImports.cshtml")]
    public class Views_Compra_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ObligatorioP2.Compra>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Usuario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("container-fluid bg-dark text-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 2\P2\OBLIGATORIO 2 P2\version final\Obligatorio2 version final\Obligatorio2\Views\Compra\Index.cshtml"
  
    ViewData["Title"] = "Compras realizadas";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96afdc6075843504387a41ba9ad9e62bfc5fb2614971", async() => {
                WriteLiteral("\r\n    <h1>Historial de compras realizadas por ");
#nullable restore
#line 8 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 2\P2\OBLIGATORIO 2 P2\version final\Obligatorio2 version final\Obligatorio2\Views\Compra\Index.cshtml"
                                       Write(Context.Session.GetString("logueadoNombreUsuario"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h1>


    <table class=""table text-light"">
        <thead>
            <tr>
                <th>
                    NOMBRE ACTIVIDAD
                </th>
                <th>
                    CANTIDAD DE ENTRADAS
                </th>
                <th>
                    FECHA Y HORA DE LA COMPRA
                </th>
                <th>
                    FECHA Y HORA DE LA ACTIVIDAD
                </th>
                <th>
                    PRECIO TOTAL
                </th>
                <th>
                    ESTADO
                </th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 36 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 2\P2\OBLIGATORIO 2 P2\version final\Obligatorio2 version final\Obligatorio2\Views\Compra\Index.cshtml"
             foreach (var item in ViewBag.comprasList)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 40 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 2\P2\OBLIGATORIO 2 P2\version final\Obligatorio2 version final\Obligatorio2\Views\Compra\Index.cshtml"
               Write(item.Actividad.Nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 43 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 2\P2\OBLIGATORIO 2 P2\version final\Obligatorio2 version final\Obligatorio2\Views\Compra\Index.cshtml"
               Write(item.CantidadEntradas);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 46 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 2\P2\OBLIGATORIO 2 P2\version final\Obligatorio2 version final\Obligatorio2\Views\Compra\Index.cshtml"
               Write(item.FechaHoraCompra);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 49 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 2\P2\OBLIGATORIO 2 P2\version final\Obligatorio2 version final\Obligatorio2\Views\Compra\Index.cshtml"
               Write(item.Actividad.FechaHora);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    $ ");
#nullable restore
#line 52 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 2\P2\OBLIGATORIO 2 P2\version final\Obligatorio2 version final\Obligatorio2\Views\Compra\Index.cshtml"
                 Write(item.PrecioFinal);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 55 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 2\P2\OBLIGATORIO 2 P2\version final\Obligatorio2 version final\Obligatorio2\Views\Compra\Index.cshtml"
               Write(item.Estado);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 58 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 2\P2\OBLIGATORIO 2 P2\version final\Obligatorio2 version final\Obligatorio2\Views\Compra\Index.cshtml"
                     if(item.Estado == "Activa")
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 2\P2\OBLIGATORIO 2 P2\version final\Obligatorio2 version final\Obligatorio2\Views\Compra\Index.cshtml"
               Write(Html.ActionLink("Cancelar", "CancelarCompra", new { id = item.IdCompra }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 2\P2\OBLIGATORIO 2 P2\version final\Obligatorio2 version final\Obligatorio2\Views\Compra\Index.cshtml"
                                                                                              
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 64 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 2\P2\OBLIGATORIO 2 P2\version final\Obligatorio2 version final\Obligatorio2\Views\Compra\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n    <p>");
#nullable restore
#line 67 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 2\P2\OBLIGATORIO 2 P2\version final\Obligatorio2 version final\Obligatorio2\Views\Compra\Index.cshtml"
  Write(ViewBag.Cancelado);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p> <!-- Sin funcionar-->\r\n\r\n    <div class=\"mt-2\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96afdc6075843504387a41ba9ad9e62bfc5fb26110750", async() => {
                    WriteLiteral("Ir a Lista de Actividades");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ObligatorioP2.Compra>> Html { get; private set; }
    }
}
#pragma warning restore 1591
