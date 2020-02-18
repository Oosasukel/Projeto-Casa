#pragma checksum "C:\Users\ROGN\Downloads\GitHub\Projeto-Casa-De-Show-ASP.NET-Core\ProjetoCasaDeShow\Views\Evento\Evento.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88936395a7397e92dab7867a1c1fa4b8917b3f96"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Evento_Evento), @"mvc.1.0.view", @"/Views/Evento/Evento.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88936395a7397e92dab7867a1c1fa4b8917b3f96", @"/Views/Evento/Evento.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e305d52e0cfa1363f8285b807bf7deaf31eedc6", @"/Views/_ViewImports.cshtml")]
    public class Views_Evento_Evento : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Evento>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Pedido", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddItemCarrinho", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\ROGN\Downloads\GitHub\Projeto-Casa-De-Show-ASP.NET-Core\ProjetoCasaDeShow\Views\Evento\Evento.cshtml"
  
    
    var casaDeShowRepository = ViewBag.casaDeShowRepository;
    var historicoRepository = ViewBag.historicoRepository;

    var evento = Model;
    var casa = casaDeShowRepository.GetCasaPeloId(evento.CasaDeShowId);

    int ingressosDisponiveis = casa.Capacidade - historicoRepository.CalculaIngressosVendidosPeloEventoId(evento.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>");
#nullable restore
#line 12 "C:\Users\ROGN\Downloads\GitHub\Projeto-Casa-De-Show-ASP.NET-Core\ProjetoCasaDeShow\Views\Evento\Evento.cshtml"
Write(evento.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<h4>");
#nullable restore
#line 14 "C:\Users\ROGN\Downloads\GitHub\Projeto-Casa-De-Show-ASP.NET-Core\ProjetoCasaDeShow\Views\Evento\Evento.cshtml"
Write(casa.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n<h5>Ingressos</h5>\r\n<p>");
#nullable restore
#line 17 "C:\Users\ROGN\Downloads\GitHub\Projeto-Casa-De-Show-ASP.NET-Core\ProjetoCasaDeShow\Views\Evento\Evento.cshtml"
Write(ingressosDisponiveis);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 17 "C:\Users\ROGN\Downloads\GitHub\Projeto-Casa-De-Show-ASP.NET-Core\ProjetoCasaDeShow\Views\Evento\Evento.cshtml"
                    Write(casa.Capacidade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" disponíveis</p>\r\n<a>R$ ");
#nullable restore
#line 18 "C:\Users\ROGN\Downloads\GitHub\Projeto-Casa-De-Show-ASP.NET-Core\ProjetoCasaDeShow\Views\Evento\Evento.cshtml"
 Write(evento.Preco);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88936395a7397e92dab7867a1c1fa4b8917b3f965905", async() => {
                WriteLiteral("<button class=\"btn btn-success\">Adicionar ao carrinho</button>");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-eventoId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 19 "C:\Users\ROGN\Downloads\GitHub\Projeto-Casa-De-Show-ASP.NET-Core\ProjetoCasaDeShow\Views\Evento\Evento.cshtml"
                                                                WriteLiteral(evento.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["eventoId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-eventoId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["eventoId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Evento> Html { get; private set; }
    }
}
#pragma warning restore 1591
