#pragma checksum "C:\Users\hanse\Documents\2022PrimerCiclo\EstructuraDeDatos\Lab\Lab04\Lab4-Hans-Sempe-1083920\Lab4-Hans-Sempe-1083920\Views\Home\MostrarColaPacientes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "423209f11025662240f418c7dda60f641df3636f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MostrarColaPacientes), @"mvc.1.0.view", @"/Views/Home/MostrarColaPacientes.cshtml")]
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
#line 1 "C:\Users\hanse\Documents\2022PrimerCiclo\EstructuraDeDatos\Lab\Lab04\Lab4-Hans-Sempe-1083920\Lab4-Hans-Sempe-1083920\Views\_ViewImports.cshtml"
using Lab4_Hans_Sempe_1083920;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hanse\Documents\2022PrimerCiclo\EstructuraDeDatos\Lab\Lab04\Lab4-Hans-Sempe-1083920\Lab4-Hans-Sempe-1083920\Views\_ViewImports.cshtml"
using Lab4_Hans_Sempe_1083920.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"423209f11025662240f418c7dda60f641df3636f", @"/Views/Home/MostrarColaPacientes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4db9f568e9f33057798a4ecea2d0460b5e5114ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MostrarColaPacientes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab4_Hans_Sempe_1083920.Models.Pacientes>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button text-white btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MostrarColaPacientes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-borrar", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\hanse\Documents\2022PrimerCiclo\EstructuraDeDatos\Lab\Lab04\Lab4-Hans-Sempe-1083920\Lab4-Hans-Sempe-1083920\Views\Home\MostrarColaPacientes.cshtml"
  
    ViewData["Title"] = "MostrarColaPacientes";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4""><u>Cola de espera</u></h1>
    <br />
    <H3>
        Lista de pacientes en espera, ordenada segun el nivel de prioridad que se halla registrado con el paciente
    </H3>
    <H6>
        (El nivel de prioridad de cada paciente se calcula segun criterios propios del hospital)
    </H6>
</div>

<hr />

<table class=""table"">
    <thead>
        <tr>
            <th>Nivel-Prioridad</th>
            <th>Nombre</th>
            <th>Apellido</th>
            <th>Fecha de Nacimiento</th>
            <th>Sexo</th>
            <th>Especialidad</th>
            <th>Metodo de Ingreso</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 34 "C:\Users\hanse\Documents\2022PrimerCiclo\EstructuraDeDatos\Lab\Lab04\Lab4-Hans-Sempe-1083920\Lab4-Hans-Sempe-1083920\Views\Home\MostrarColaPacientes.cshtml"
         foreach (var item in ViewData["Pacientes"] as List<HEAP.TreeStructure.HEAPNode<int, Pacientes>>)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 37 "C:\Users\hanse\Documents\2022PrimerCiclo\EstructuraDeDatos\Lab\Lab04\Lab4-Hans-Sempe-1083920\Lab4-Hans-Sempe-1083920\Views\Home\MostrarColaPacientes.cshtml"
               Write(item.Prioridad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 38 "C:\Users\hanse\Documents\2022PrimerCiclo\EstructuraDeDatos\Lab\Lab04\Lab4-Hans-Sempe-1083920\Lab4-Hans-Sempe-1083920\Views\Home\MostrarColaPacientes.cshtml"
               Write(item.Valor.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 39 "C:\Users\hanse\Documents\2022PrimerCiclo\EstructuraDeDatos\Lab\Lab04\Lab4-Hans-Sempe-1083920\Lab4-Hans-Sempe-1083920\Views\Home\MostrarColaPacientes.cshtml"
               Write(item.Valor.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 40 "C:\Users\hanse\Documents\2022PrimerCiclo\EstructuraDeDatos\Lab\Lab04\Lab4-Hans-Sempe-1083920\Lab4-Hans-Sempe-1083920\Views\Home\MostrarColaPacientes.cshtml"
               Write(item.Valor.Fnacimiento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 41 "C:\Users\hanse\Documents\2022PrimerCiclo\EstructuraDeDatos\Lab\Lab04\Lab4-Hans-Sempe-1083920\Lab4-Hans-Sempe-1083920\Views\Home\MostrarColaPacientes.cshtml"
               Write(item.Valor.Sexo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 42 "C:\Users\hanse\Documents\2022PrimerCiclo\EstructuraDeDatos\Lab\Lab04\Lab4-Hans-Sempe-1083920\Lab4-Hans-Sempe-1083920\Views\Home\MostrarColaPacientes.cshtml"
               Write(item.Valor.Especialidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 43 "C:\Users\hanse\Documents\2022PrimerCiclo\EstructuraDeDatos\Lab\Lab04\Lab4-Hans-Sempe-1083920\Lab4-Hans-Sempe-1083920\Views\Home\MostrarColaPacientes.cshtml"
               Write(item.Valor.Ingreso);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td></td>\r\n            </tr>\r\n");
#nullable restore
#line 46 "C:\Users\hanse\Documents\2022PrimerCiclo\EstructuraDeDatos\Lab\Lab04\Lab4-Hans-Sempe-1083920\Lab4-Hans-Sempe-1083920\Views\Home\MostrarColaPacientes.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n\r\n\r\n<div class=\"text-center\">\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "423209f11025662240f418c7dda60f641df3636f8629", async() => {
                WriteLiteral("Actualizar cola de espera");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-borrar", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["borrar"] = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab4_Hans_Sempe_1083920.Models.Pacientes> Html { get; private set; }
    }
}
#pragma warning restore 1591