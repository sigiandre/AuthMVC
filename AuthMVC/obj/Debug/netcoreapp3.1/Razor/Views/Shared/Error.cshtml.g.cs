#pragma checksum "/Users/andrediaz/Desktop/Aplicacion Web/AuthMVC/AuthMVC/Views/Shared/Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef7cac86f1d45cef6aaa5a86c12e614b5165a51e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
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
#line 1 "/Users/andrediaz/Desktop/Aplicacion Web/AuthMVC/AuthMVC/Views/_ViewImports.cshtml"
using AuthMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/andrediaz/Desktop/Aplicacion Web/AuthMVC/AuthMVC/Views/_ViewImports.cshtml"
using AuthMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef7cac86f1d45cef6aaa5a86c12e614b5165a51e", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4296ab7d9b72ec08bb93caa94f8e59bbe46f831c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/andrediaz/Desktop/Aplicacion Web/AuthMVC/AuthMVC/Views/Shared/Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1 class=\"text-danger\">Error.</h1>\n<h2 class=\"text-danger\">Se produjo un error al procesar su solicitud.</h2>\n\n");
#nullable restore
#line 9 "/Users/andrediaz/Desktop/Aplicacion Web/AuthMVC/AuthMVC/Views/Shared/Error.cshtml"
 if (Model.ShowRequestId)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\n        <strong>Request ID:</strong> <code>");
#nullable restore
#line 12 "/Users/andrediaz/Desktop/Aplicacion Web/AuthMVC/AuthMVC/Views/Shared/Error.cshtml"
                                      Write(Model.RequestId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</code>\n    </p>\n");
#nullable restore
#line 14 "/Users/andrediaz/Desktop/Aplicacion Web/AuthMVC/AuthMVC/Views/Shared/Error.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h3>Modo de desarrollo</h3>
<p>
    Cambiando a <strong>Desarrollo</strong> El entorno mostrará información más detallada sobre el error que ocurrió.
</p>
<p>
    <strong>El entorno de desarrollo no debe habilitarse para las aplicaciones implementadas.</strong>
    Puede resultar en mostrar información confidencial de excepciones a los usuarios finales.
    Para la depuración local, habilite el <strong>Desarrollo</strong> entorno estableciendo el <strong>ASPNETCORE_ENVIRONMENT</strong> variable de entorno a <strong>Desarrollo</strong>
    y reiniciando la aplicación.
</p>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
