#pragma checksum "C:\Users\47425337800\Documents\cshtml\Hamburgueria_Tarde\Views\Cadastro\cadastro1\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94cefa9dfcc26ba90f9d693f9be78acbea176610"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cadastro_cadastro1_Index), @"mvc.1.0.view", @"/Views/Cadastro/cadastro1/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cadastro/cadastro1/Index.cshtml", typeof(AspNetCore.Views_Cadastro_cadastro1_Index))]
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
#line 1 "C:\Users\47425337800\Documents\cshtml\Hamburgueria_Tarde\Views\_ViewImports.cshtml"
using Hamburgueria_Tarde;

#line default
#line hidden
#line 2 "C:\Users\47425337800\Documents\cshtml\Hamburgueria_Tarde\Views\_ViewImports.cshtml"
using Hamburgueria_Tarde.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94cefa9dfcc26ba90f9d693f9be78acbea176610", @"/Views/Cadastro/cadastro1/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ac6d330bca7c38ed999777249472e97826d572d", @"/Views/_ViewImports.cshtml")]
    public class Views_Cadastro_cadastro1_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Hamburgueria_Tarde.ViewModels.PedidoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Pedido/RegistrarPedido"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 10, true);
            WriteLiteral("<header>\r\n");
            EndContext();
#line 3 "C:\Users\47425337800\Documents\cshtml\Hamburgueria_Tarde\Views\Cadastro\cadastro1\Index.cshtml"
      
        Html.RenderPartial("_HeaderNavBar");
    

#line default
#line hidden
            BeginContext(125, 33, true);
            WriteLiteral("</header>\r\n\r\n<main>\r\n        <h2>");
            EndContext();
            BeginContext(159, 8, false);
#line 9 "C:\Users\47425337800\Documents\cshtml\Hamburgueria_Tarde\Views\Cadastro\cadastro1\Index.cshtml"
       Write(ViewData);

#line default
#line hidden
            EndContext();
            BeginContext(167, 28, true);
            WriteLiteral(" [\"NomeView\"]</h2>\r\n        ");
            EndContext();
            BeginContext(195, 1571, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a852cfd6ac40420c963931411a2f42e4", async() => {
                BeginContext(247, 1512, true);
                WriteLiteral(@"
            <div>
                <label for=""nome"">Nome Completo</label>
                <br />
                <input id=""nome"" type=""text"" maxlength=""20"" minlength=""3"" name=""nome"" />
            </div>

            <div>
                <label for=""endereco"">Endereço</label>
                <br />
                <input id=""endereco"" type=""text"" maxlength=""20"" minlength=""3"" name=""endereco"" />
            </div>

            <div>
                <label for=""telefone"">Telefone para contato</label>
                <br />
                <input id=""telefone"" type=""text"" name=""telefone""/>
            </div>

            <div>
                <label for=""email"">E-mail</label>
                <br />
                <input id=""email"" type=""email"" name=""email""/>
            </div>
            <div>
                <label for=""data-nascimento"">Data de nascimento</label>
                <br />
                <input id=""data-nascimento"" type=""date"" name=""data-nascimento""/>
            </");
                WriteLiteral(@"div>
            <div>
                <label for=""senha"">senha</label>
                <br />
                <input id=""senha"" type=""password"" name=""senha""/>
            </div>
            <div>
                <label for=""confirmar-senha"">Confirme sua senha</label>
                <br />
                <input id=""confirmar-senha"" type=""password"" name=""confirmar-senha""/>
            </div>


            
            <input type=""submit"" value=""Cadastrar"" />
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1766, 15, true);
            WriteLiteral("\r\n\r\n    </main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hamburgueria_Tarde.ViewModels.PedidoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
