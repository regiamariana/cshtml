#pragma checksum "c:\Users\47425337800\Documents\cshtml\CHEGAAAAAAAAAAAA\cshtml\okagorachega\Views\Cliente\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "731df9dd3777bd2463429a2ea3e52956ae0caf3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Login), @"mvc.1.0.view", @"/Views/Cliente/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cliente/Login.cshtml", typeof(AspNetCore.Views_Cliente_Login))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"731df9dd3777bd2463429a2ea3e52956ae0caf3b", @"/Views/Cliente/Login.cshtml")]
    public class Views_Cliente_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "c:\Users\47425337800\Documents\cshtml\CHEGAAAAAAAAAAAA\cshtml\okagorachega\Views\Cliente\Login.cshtml"
  
    Layout="_Layout";
    

#line default
#line hidden
            BeginContext(36, 69, true);
            WriteLiteral("<header>\r\n        <!-- <partial name=\"_HeaderNavBar\"></partial> -->\r\n");
            EndContext();
#line 7 "c:\Users\47425337800\Documents\cshtml\CHEGAAAAAAAAAAAA\cshtml\okagorachega\Views\Cliente\Login.cshtml"
          
            Html.RenderPartial("_HeaderNavBar", ViewData["User"]);
        

#line default
#line hidden
            BeginContext(196, 85, true);
            WriteLiteral("    </header>\r\n<main id=\"login\">\r\n        <h2>Login</h2>\r\n        <form method=\"POST\"");
            EndContext();
            BeginWriteAttribute("action", " action=\'", 281, "\'", 321, 1);
#line 13 "c:\Users\47425337800\Documents\cshtml\CHEGAAAAAAAAAAAA\cshtml\okagorachega\Views\Cliente\Login.cshtml"
WriteAttributeValue("", 290, Url.Action("Login", "Cliente"), 290, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(322, 558, true);
            WriteLiteral(@">
            <div>
                <label for=""email"">E-mail</label>
                <br />
                <input id=""email"" type=""email"" maxlength=""20"" minlength=""3"" name=""email"" />
            </div>

            <div>
                <label for=""senha"">Senha</label>
                <br />
                <input id=""senha"" type=""password"" maxlength=""20"" minlength=""3"" name=""senha"" />
            </div>
            
            <input type=""submit"" value=""Acessar minha conta"" />

            <div id=""link-cadastro"">
                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 880, "\'", 919, 1);
#line 29 "c:\Users\47425337800\Documents\cshtml\CHEGAAAAAAAAAAAA\cshtml\okagorachega\Views\Cliente\Login.cshtml"
WriteAttributeValue("", 887, Url.Action("Index", "Cadastro"), 887, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(920, 78, true);
            WriteLiteral(">Quero me cadastrar!</a>\r\n            </div>\r\n\r\n        </form>\r\n\r\n    </main>");
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
