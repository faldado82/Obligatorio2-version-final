#pragma checksum "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 2\P2\OBLIGATORIO 2 P2\version final\Obligatorio2 version final\Obligatorio2\Views\Actividad\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6c5617234ef5c973b0dd7afbf5047e5dac37558"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Actividad_Index), @"mvc.1.0.view", @"/Views/Actividad/Index.cshtml")]
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
#line 1 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 2\P2\OBLIGATORIO 2 P2\version final\Obligatorio2 version final\Obligatorio2\Views\Actividad\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6c5617234ef5c973b0dd7afbf5047e5dac37558", @"/Views/Actividad/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87e36970f455aae1bee373d97230b042ea67aa2f", @"/Views/_ViewImports.cshtml")]
    public class Views_Actividad_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ObligatorioP2.Actividad>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("container-fluid bg-dark text-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 2\P2\OBLIGATORIO 2 P2\version final\Obligatorio2 version final\Obligatorio2\Views\Actividad\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6c5617234ef5c973b0dd7afbf5047e5dac375584244", async() => {
                WriteLiteral(@"
    <h1>Lista de Actividades</h1>


    <table class=""table table-striped text-light"">
        <thead class=""text-center"">
            <tr>
                <th>
                    NOMBRE
                </th>
                <th>
                    FECHA Y HORA
                </th>
                <th>
                    CATEGORIA DE EDAD
                </th>
                <th>
                    LIKES
                </th>
                <th>
                    PRECIO
                </th>
");
#nullable restore
#line 29 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 2\P2\OBLIGATORIO 2 P2\version final\Obligatorio2 version final\Obligatorio2\Views\Actividad\Index.cshtml"
                 if (Context.Session.GetString("logueadoNombreUsuario") != null)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <th>\r\n                    </th>\r\n");
#nullable restore
#line 33 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 2\P2\OBLIGATORIO 2 P2\version final\Obligatorio2 version final\Obligatorio2\Views\Actividad\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 37 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 2\P2\OBLIGATORIO 2 P2\version final\Obligatorio2 version final\Obligatorio2\Views\Actividad\Index.cshtml"
             foreach (var item in ViewBag.actividadesList)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 41 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 2\P2\OBLIGATORIO 2 P2\version final\Obligatorio2 version final\Obligatorio2\Views\Actividad\Index.cshtml"
               Write(item.Nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 44 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 2\P2\OBLIGATORIO 2 P2\version final\Obligatorio2 version final\Obligatorio2\Views\Actividad\Index.cshtml"
               Write(item.FechaHora);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 47 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 2\P2\OBLIGATORIO 2 P2\version final\Obligatorio2 version final\Obligatorio2\Views\Actividad\Index.cshtml"
               Write(item.EdadMinima);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 50 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 2\P2\OBLIGATORIO 2 P2\version final\Obligatorio2 version final\Obligatorio2\Views\Actividad\Index.cshtml"
               Write(item.CantidadMeGusta);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    $ ");
#nullable restore
#line 53 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 2\P2\OBLIGATORIO 2 P2\version final\Obligatorio2 version final\Obligatorio2\Views\Actividad\Index.cshtml"
                 Write(item.precioFinal());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n");
#nullable restore
#line 55 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 2\P2\OBLIGATORIO 2 P2\version final\Obligatorio2 version final\Obligatorio2\Views\Actividad\Index.cshtml"
                 if (Context.Session.GetString("logueadoRol") == "Cliente")
                {                  

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td>\r\n                        ");
#nullable restore
#line 58 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 2\P2\OBLIGATORIO 2 P2\version final\Obligatorio2 version final\Obligatorio2\Views\Actividad\Index.cshtml"
                   Write(Html.ActionLink("Me gusta", "MeGusta", new { id = item.IdActividad }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" -\r\n                        ");
#nullable restore
#line 59 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 2\P2\OBLIGATORIO 2 P2\version final\Obligatorio2 version final\Obligatorio2\Views\Actividad\Index.cshtml"
                   Write(Html.ActionLink("Comprar", "CompraUsuario", "Compra", new { id = item.IdActividad }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" \r\n                    </td>\r\n");
#nullable restore
#line 61 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 2\P2\OBLIGATORIO 2 P2\version final\Obligatorio2 version final\Obligatorio2\Views\Actividad\Index.cshtml"
                }           

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tr>\r\n");
#nullable restore
#line 63 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 2\P2\OBLIGATORIO 2 P2\version final\Obligatorio2 version final\Obligatorio2\Views\Actividad\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ObligatorioP2.Actividad>> Html { get; private set; }
    }
}
#pragma warning restore 1591
