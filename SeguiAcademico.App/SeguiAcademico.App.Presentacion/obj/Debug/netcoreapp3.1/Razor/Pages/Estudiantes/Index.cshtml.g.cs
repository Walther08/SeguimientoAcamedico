#pragma checksum "C:\Seguimiento\SeguiAcademico.App\SeguiAcademico.App.Presentacion\Pages\Estudiantes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e540da2cda6da4d080510a75ce0a1ed6bbc7f63a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SeguiAcademico.App.Presentacion.Pages.Estudiantes.Pages_Estudiantes_Index), @"mvc.1.0.razor-page", @"/Pages/Estudiantes/Index.cshtml")]
namespace SeguiAcademico.App.Presentacion.Pages.Estudiantes
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
#line 1 "C:\Seguimiento\SeguiAcademico.App\SeguiAcademico.App.Presentacion\Pages\_ViewImports.cshtml"
using SeguiAcademico.App.Presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e540da2cda6da4d080510a75ce0a1ed6bbc7f63a", @"/Pages/Estudiantes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81b3b4cc343a2ae0346d70e499c0c861565808ff", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Estudiantes_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Crear", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Lista de los estudiantes actuales</h1> <br>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e540da2cda6da4d080510a75ce0a1ed6bbc7f63a3736", async() => {
                WriteLiteral("+Nuevo Estudiante");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" <br>

<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">Nombre</th>
            <th scope=""col"">Apellidos</th>
            <th scope=""col"">Número de telefono</th>
            <th scope=""col"">Genero</th>
            <th scope=""col"">Curso</th>
            <th scope=""col"">Dirección</th>
            <th scope=""col"">Latitud</th>
            <th scope=""col"">Longitud</th>
            <th scope=""col"">Ciudad</th>
            <th scope=""col"">Fecha nacimiento</th>
            <th scope=""col"">Materias inscritas</th>
        </tr>
    </thead>

");
#nullable restore
#line 26 "C:\Seguimiento\SeguiAcademico.App\SeguiAcademico.App.Presentacion\Pages\Estudiantes\Index.cshtml"
     foreach (var i in Model.estudiante)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 29 "C:\Seguimiento\SeguiAcademico.App\SeguiAcademico.App.Presentacion\Pages\Estudiantes\Index.cshtml"
           Write(i.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Seguimiento\SeguiAcademico.App\SeguiAcademico.App.Presentacion\Pages\Estudiantes\Index.cshtml"
           Write(i.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Seguimiento\SeguiAcademico.App\SeguiAcademico.App.Presentacion\Pages\Estudiantes\Index.cshtml"
           Write(i.NumeroTelefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "C:\Seguimiento\SeguiAcademico.App\SeguiAcademico.App.Presentacion\Pages\Estudiantes\Index.cshtml"
           Write(i.Genero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "C:\Seguimiento\SeguiAcademico.App\SeguiAcademico.App.Presentacion\Pages\Estudiantes\Index.cshtml"
           Write(i.Curso);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "C:\Seguimiento\SeguiAcademico.App\SeguiAcademico.App.Presentacion\Pages\Estudiantes\Index.cshtml"
           Write(i.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 35 "C:\Seguimiento\SeguiAcademico.App\SeguiAcademico.App.Presentacion\Pages\Estudiantes\Index.cshtml"
           Write(i.Latitud);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 36 "C:\Seguimiento\SeguiAcademico.App\SeguiAcademico.App.Presentacion\Pages\Estudiantes\Index.cshtml"
           Write(i.Longitud);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 37 "C:\Seguimiento\SeguiAcademico.App\SeguiAcademico.App.Presentacion\Pages\Estudiantes\Index.cshtml"
           Write(i.Ciudad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 38 "C:\Seguimiento\SeguiAcademico.App\SeguiAcademico.App.Presentacion\Pages\Estudiantes\Index.cshtml"
           Write(i.FechaNacimiento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 39 "C:\Seguimiento\SeguiAcademico.App\SeguiAcademico.App.Presentacion\Pages\Estudiantes\Index.cshtml"
           Write(i.MateriasInscritas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 41 "C:\Seguimiento\SeguiAcademico.App\SeguiAcademico.App.Presentacion\Pages\Estudiantes\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SeguiAcademico.App.Presentacion.Pages.Estudiantes.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SeguiAcademico.App.Presentacion.Pages.Estudiantes.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SeguiAcademico.App.Presentacion.Pages.Estudiantes.IndexModel>)PageContext?.ViewData;
        public SeguiAcademico.App.Presentacion.Pages.Estudiantes.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
