#pragma checksum "C:\Users\ROGN\Downloads\GitHub\Projeto-Casa-De-Show-ASP.NET-Core\ProjetoCasaDeShow\Views\CasaDeShow\Casa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2eef753b6d1162f2e78e854483f62600d8f3abc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CasaDeShow_Casa), @"mvc.1.0.view", @"/Views/CasaDeShow/Casa.cshtml")]
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
#line 1 "C:\Users\ROGN\Downloads\GitHub\Projeto-Casa-De-Show-ASP.NET-Core\ProjetoCasaDeShow\Views\_ViewImports.cshtml"
using ProjetoCasaDeShow;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ROGN\Downloads\GitHub\Projeto-Casa-De-Show-ASP.NET-Core\ProjetoCasaDeShow\Views\_ViewImports.cshtml"
using ProjetoCasaDeShow.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ROGN\Downloads\GitHub\Projeto-Casa-De-Show-ASP.NET-Core\ProjetoCasaDeShow\Views\_ViewImports.cshtml"
using ProjetoCasaDeShow.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2eef753b6d1162f2e78e854483f62600d8f3abc", @"/Views/CasaDeShow/Casa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e305d52e0cfa1363f8285b807bf7deaf31eedc6", @"/Views/_ViewImports.cshtml")]
    public class Views_CasaDeShow_Casa : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CasaDeShow>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Evento", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Evento", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\ROGN\Downloads\GitHub\Projeto-Casa-De-Show-ASP.NET-Core\ProjetoCasaDeShow\Views\CasaDeShow\Casa.cshtml"
  
    var casa = Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ROGN\Downloads\GitHub\Projeto-Casa-De-Show-ASP.NET-Core\ProjetoCasaDeShow\Views\CasaDeShow\Casa.cshtml"
 if(casa.PathImage == null){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <img width=\"300px\" src=\"/Arquivos/Images/default.png\">\r\n");
#nullable restore
#line 7 "C:\Users\ROGN\Downloads\GitHub\Projeto-Casa-De-Show-ASP.NET-Core\ProjetoCasaDeShow\Views\CasaDeShow\Casa.cshtml"
}
else{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <img width=\"300px\"");
            BeginWriteAttribute("src", " src=\"", 171, "\"", 192, 1);
#nullable restore
#line 9 "C:\Users\ROGN\Downloads\GitHub\Projeto-Casa-De-Show-ASP.NET-Core\ProjetoCasaDeShow\Views\CasaDeShow\Casa.cshtml"
WriteAttributeValue("", 177, casa.PathImage, 177, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 10 "C:\Users\ROGN\Downloads\GitHub\Projeto-Casa-De-Show-ASP.NET-Core\ProjetoCasaDeShow\Views\CasaDeShow\Casa.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 12 "C:\Users\ROGN\Downloads\GitHub\Projeto-Casa-De-Show-ASP.NET-Core\ProjetoCasaDeShow\Views\CasaDeShow\Casa.cshtml"
Write(casa.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h5>");
#nullable restore
#line 13 "C:\Users\ROGN\Downloads\GitHub\Projeto-Casa-De-Show-ASP.NET-Core\ProjetoCasaDeShow\Views\CasaDeShow\Casa.cshtml"
Write(casa.Endereco);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n<h5>Capacidade: ");
#nullable restore
#line 14 "C:\Users\ROGN\Downloads\GitHub\Projeto-Casa-De-Show-ASP.NET-Core\ProjetoCasaDeShow\Views\CasaDeShow\Casa.cshtml"
           Write(casa.Capacidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n<h3>Eventos</h3>\r\n\r\n");
#nullable restore
#line 18 "C:\Users\ROGN\Downloads\GitHub\Projeto-Casa-De-Show-ASP.NET-Core\ProjetoCasaDeShow\Views\CasaDeShow\Casa.cshtml"
  
    var historicoRepository = ViewBag.historicoRepository;

    var eventos = Model.Eventos;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n");
#nullable restore
#line 24 "C:\Users\ROGN\Downloads\GitHub\Projeto-Casa-De-Show-ASP.NET-Core\ProjetoCasaDeShow\Views\CasaDeShow\Casa.cshtml"
     foreach (var evento in eventos)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table class=\"tabela\">\r\n            <tr>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2eef753b6d1162f2e78e854483f62600d8f3abc6947", async() => {
#nullable restore
#line 29 "C:\Users\ROGN\Downloads\GitHub\Projeto-Casa-De-Show-ASP.NET-Core\ProjetoCasaDeShow\Views\CasaDeShow\Casa.cshtml"
                                                                                        Write(evento.Nome);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\ROGN\Downloads\GitHub\Projeto-Casa-De-Show-ASP.NET-Core\ProjetoCasaDeShow\Views\CasaDeShow\Casa.cshtml"
                                                                     WriteLiteral(evento.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 32 "C:\Users\ROGN\Downloads\GitHub\Projeto-Casa-De-Show-ASP.NET-Core\ProjetoCasaDeShow\Views\CasaDeShow\Casa.cshtml"
               Write(evento.Data);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 35 "C:\Users\ROGN\Downloads\GitHub\Projeto-Casa-De-Show-ASP.NET-Core\ProjetoCasaDeShow\Views\CasaDeShow\Casa.cshtml"
               Write(evento.Preco);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 38 "C:\Users\ROGN\Downloads\GitHub\Projeto-Casa-De-Show-ASP.NET-Core\ProjetoCasaDeShow\Views\CasaDeShow\Casa.cshtml"
               Write(evento.Genero);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 41 "C:\Users\ROGN\Downloads\GitHub\Projeto-Casa-De-Show-ASP.NET-Core\ProjetoCasaDeShow\Views\CasaDeShow\Casa.cshtml"
                      
                        var quantidadeVendida = historicoRepository.CalculaIngressosVendidosPeloEventoId(evento.Id);
                        int ingressosDisponiveis = casa.Capacidade - quantidadeVendida;
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
#nullable restore
#line 45 "C:\Users\ROGN\Downloads\GitHub\Projeto-Casa-De-Show-ASP.NET-Core\ProjetoCasaDeShow\Views\CasaDeShow\Casa.cshtml"
               Write(ingressosDisponiveis);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ingressos disponíveis.\r\n                </td>\r\n            </tr>\r\n        </table>\r\n");
#nullable restore
#line 49 "C:\Users\ROGN\Downloads\GitHub\Projeto-Casa-De-Show-ASP.NET-Core\ProjetoCasaDeShow\Views\CasaDeShow\Casa.cshtml"
        
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CasaDeShow> Html { get; private set; }
    }
}
#pragma warning restore 1591
