#pragma checksum "C:\Users\USUARIO\Downloads\AA\Views\Admin\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f6869e4b903ca8e8b1dc068c3d3bcff4fd8f728"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Listar), @"mvc.1.0.view", @"/Views/Admin/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Listar.cshtml", typeof(AspNetCore.Views_Admin_Listar))]
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
#line 1 "C:\Users\USUARIO\Downloads\AA\Views\_ViewImports.cshtml"
using AA;

#line default
#line hidden
#line 2 "C:\Users\USUARIO\Downloads\AA\Views\_ViewImports.cshtml"
using AA.Models;

#line default
#line hidden
#line 3 "C:\Users\USUARIO\Downloads\AA\Views\_ViewImports.cshtml"
using AA.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f6869e4b903ca8e8b1dc068c3d3bcff4fd8f728", @"/Views/Admin/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2a3e99d851038fb25615aa56bb0310e72aea49b", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Mascota>>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(21, 469, true);
            WriteLiteral(@"
<div class=""container "">
    <h1></h1>
    <h1 class = ""text-center alert alert-success"">Listado de mascotas</h1>
    <table class=""table"">
        <tr class =""thead-dark"">
            <th scope=""col"">Id</th>
            <th scope=""col"">Nombre</th>
            <th scope=""col"">Foto</th>
            <th scope=""col"">Peso</th>
            <th scope=""col"">Codigo mascota</th>
            <th scope=""col"">Edad</th>
            <th scope=""col"">Opciones</th>
        </tr>

");
            EndContext();
#line 17 "C:\Users\USUARIO\Downloads\AA\Views\Admin\Listar.cshtml"
         foreach(var m in Model) {

#line default
#line hidden
            BeginContext(525, 58, true);
            WriteLiteral("            <tr class=\"thead-light\">\n                <td >");
            EndContext();
            BeginContext(584, 4, false);
#line 19 "C:\Users\USUARIO\Downloads\AA\Views\Admin\Listar.cshtml"
                Write(m.Id);

#line default
#line hidden
            EndContext();
            BeginContext(588, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(615, 15, false);
#line 20 "C:\Users\USUARIO\Downloads\AA\Views\Admin\Listar.cshtml"
               Write(m.NombreMascota);

#line default
#line hidden
            EndContext();
            BeginContext(630, 30, true);
            WriteLiteral("</td>\n                <td><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 660, "\"", 673, 1);
#line 21 "C:\Users\USUARIO\Downloads\AA\Views\Admin\Listar.cshtml"
WriteAttributeValue("", 666, m.Foto, 666, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(674, 39, true);
            WriteLiteral(" width=\"100\"></td>\n                <td>");
            EndContext();
            BeginContext(714, 6, false);
#line 22 "C:\Users\USUARIO\Downloads\AA\Views\Admin\Listar.cshtml"
               Write(m.Peso);

#line default
#line hidden
            EndContext();
            BeginContext(720, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(747, 15, false);
#line 23 "C:\Users\USUARIO\Downloads\AA\Views\Admin\Listar.cshtml"
               Write(m.CodigoMascota);

#line default
#line hidden
            EndContext();
            BeginContext(762, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(789, 6, false);
#line 24 "C:\Users\USUARIO\Downloads\AA\Views\Admin\Listar.cshtml"
               Write(m.Edad);

#line default
#line hidden
            EndContext();
            BeginContext(795, 47, true);
            WriteLiteral("</td>\n                <td>\n                    ");
            EndContext();
            BeginContext(842, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f6869e4b903ca8e8b1dc068c3d3bcff4fd8f7286105", async() => {
                BeginContext(877, 10, true);
                WriteLiteral("Actualizar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 851, "~/admin/actualizar/", 851, 19, true);
#line 26 "C:\Users\USUARIO\Downloads\AA\Views\Admin\Listar.cshtml"
AddHtmlAttributeValue("", 870, m.Id, 870, 5, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(891, 24, true);
            WriteLiteral(" | \n                    ");
            EndContext();
            BeginContext(915, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f6869e4b903ca8e8b1dc068c3d3bcff4fd8f7287809", async() => {
                BeginContext(946, 6, true);
                WriteLiteral("Borrar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 924, "~/admin/borrar/", 924, 15, true);
#line 27 "C:\Users\USUARIO\Downloads\AA\Views\Admin\Listar.cshtml"
AddHtmlAttributeValue("", 939, m.Id, 939, 5, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(956, 41, true);
            WriteLiteral("\n                </td>\n            </tr>\n");
            EndContext();
#line 30 "C:\Users\USUARIO\Downloads\AA\Views\Admin\Listar.cshtml"
        }

#line default
#line hidden
            BeginContext(1007, 29, true);
            WriteLiteral("        \n\n    </table>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Mascota>> Html { get; private set; }
    }
}
#pragma warning restore 1591
