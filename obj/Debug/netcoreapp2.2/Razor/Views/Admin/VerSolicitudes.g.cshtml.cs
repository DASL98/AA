#pragma checksum "C:\Users\USUARIO\Downloads\AA\Views\Admin\VerSolicitudes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9428e33a587752de0e487c090b070cbd83b97a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_VerSolicitudes), @"mvc.1.0.view", @"/Views/Admin/VerSolicitudes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/VerSolicitudes.cshtml", typeof(AspNetCore.Views_Admin_VerSolicitudes))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9428e33a587752de0e487c090b070cbd83b97a2", @"/Views/Admin/VerSolicitudes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2a3e99d851038fb25615aa56bb0310e72aea49b", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_VerSolicitudes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "C:\Users\USUARIO\Downloads\AA\Views\Admin\VerSolicitudes.cshtml"
  
    var solicitud = (List<Solicitud>)ViewBag.solicitud;

#line default
#line hidden
            BeginContext(61, 407, true);
            WriteLiteral(@"<div class=""container"">
<div class=""text-center"">
    <h1></h1>
    <h1 class=""display-4 alert alert-dark"" >Listado de solicitudes</h1>
<table class=""table table-dark"">
  <thead>
    <tr>
      <th scope=""col"">Id</th>
      <th scope=""col"">Nombres</th>
      <th scope=""col"">Correo electrónico</th>
      <th scope=""col"">Teléfono</th>
      <th scope=""col"">CodigoMascota</th>
    </tr>
  </thead>
  <tbody>
");
            EndContext();
#line 19 "C:\Users\USUARIO\Downloads\AA\Views\Admin\VerSolicitudes.cshtml"
     foreach(var s in solicitud)
    {

#line default
#line hidden
            BeginContext(507, 31, true);
            WriteLiteral("    <tr>\n      <th scope=\"row\">");
            EndContext();
            BeginContext(539, 4, false);
#line 22 "C:\Users\USUARIO\Downloads\AA\Views\Admin\VerSolicitudes.cshtml"
                 Write(s.id);

#line default
#line hidden
            EndContext();
            BeginContext(543, 16, true);
            WriteLiteral("</th>\n      <td>");
            EndContext();
            BeginContext(560, 8, false);
#line 23 "C:\Users\USUARIO\Downloads\AA\Views\Admin\VerSolicitudes.cshtml"
     Write(s.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(568, 14, true);
            WriteLiteral(" \n            ");
            EndContext();
            BeginContext(583, 17, false);
#line 24 "C:\Users\USUARIO\Downloads\AA\Views\Admin\VerSolicitudes.cshtml"
       Write(s.ApellidoPaterno);

#line default
#line hidden
            EndContext();
            BeginContext(600, 14, true);
            WriteLiteral(" \n            ");
            EndContext();
            BeginContext(615, 17, false);
#line 25 "C:\Users\USUARIO\Downloads\AA\Views\Admin\VerSolicitudes.cshtml"
       Write(s.ApellidoMaterno);

#line default
#line hidden
            EndContext();
            BeginContext(632, 17, true);
            WriteLiteral(" </td>\n      <td>");
            EndContext();
            BeginContext(650, 8, false);
#line 26 "C:\Users\USUARIO\Downloads\AA\Views\Admin\VerSolicitudes.cshtml"
     Write(s.Correo);

#line default
#line hidden
            EndContext();
            BeginContext(658, 18, true);
            WriteLiteral("  </td>\n      <td>");
            EndContext();
            BeginContext(677, 10, false);
#line 27 "C:\Users\USUARIO\Downloads\AA\Views\Admin\VerSolicitudes.cshtml"
     Write(s.Telefono);

#line default
#line hidden
            EndContext();
            BeginContext(687, 17, true);
            WriteLiteral(" </td>\n      <td>");
            EndContext();
            BeginContext(705, 9, false);
#line 28 "C:\Users\USUARIO\Downloads\AA\Views\Admin\VerSolicitudes.cshtml"
     Write(s.CodigoM);

#line default
#line hidden
            EndContext();
            BeginContext(714, 45, true);
            WriteLiteral("</td>\n                  <td>\n                ");
            EndContext();
            BeginContext(759, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9428e33a587752de0e487c090b070cbd83b97a26442", async() => {
                BeginContext(799, 6, true);
                WriteLiteral("Borrar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 768, "~/admin/borrarsolicitud/", 768, 24, true);
#line 30 "C:\Users\USUARIO\Downloads\AA\Views\Admin\VerSolicitudes.cshtml"
AddHtmlAttributeValue("", 792, s.id, 792, 5, false);

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
            BeginContext(809, 29, true);
            WriteLiteral("\n            </td>\n    </tr>\n");
            EndContext();
#line 33 "C:\Users\USUARIO\Downloads\AA\Views\Admin\VerSolicitudes.cshtml"
    }

#line default
#line hidden
            BeginContext(844, 34, true);
            WriteLiteral("  </tbody>\n</table>\n\n</div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
