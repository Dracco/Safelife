#pragma checksum "D:\Dracco\Safelife\Web.SafeLife\WebSafeLife\Views\Prontuarios\Receita_Impressao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1e8230805bc7f234fd1a70e74454cd7165d288d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Prontuarios_Receita_Impressao), @"mvc.1.0.view", @"/Views/Prontuarios/Receita_Impressao.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Prontuarios/Receita_Impressao.cshtml", typeof(AspNetCore.Views_Prontuarios_Receita_Impressao))]
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
#line 1 "D:\Dracco\Safelife\Web.SafeLife\WebSafeLife\Views\_ViewImports.cshtml"
using WebSafeLife;

#line default
#line hidden
#line 2 "D:\Dracco\Safelife\Web.SafeLife\WebSafeLife\Views\_ViewImports.cshtml"
using SafeLifeLib.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1e8230805bc7f234fd1a70e74454cd7165d288d", @"/Views/Prontuarios/Receita_Impressao.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98b76eb30d6b79beb36de5b1740e50ad7bbc4401", @"/Views/_ViewImports.cshtml")]
    public class Views_Prontuarios_Receita_Impressao : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/logotipo-medico.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Logotipo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onload", new global::Microsoft.AspNetCore.Html.HtmlString("window.print();"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Dracco\Safelife\Web.SafeLife\WebSafeLife\Views\Prontuarios\Receita_Impressao.cshtml"
  
    ViewData["Title"] = "Receita";
    Layout = null;

#line default
#line hidden
            BeginContext(63, 27, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(90, 1247, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8476ca62e78c4602a62950d3b3740bcf", async() => {
                BeginContext(96, 1234, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <title>SafeLife Saúde | Receita</title>
    <!-- Tell the browser to be responsive to screen width -->
    <meta content=""width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no"" name=""viewport"">
    <!-- Bootstrap 3.3.7 -->
    <link rel=""stylesheet"" href=""/lib/bootstrap/dist/css/bootstrap.min.css"">
    <!-- Font Awesome -->
    <link rel=""stylesheet"" href=""/lib/font-awesome/css/font-awesome.min.css"">
    <!-- Ionicons -->
    <link rel=""stylesheet"" href=""/lib/Ionicons/css/ionicons.min.css"">
    <!-- Theme style -->
    <link rel=""stylesheet"" href=""/css/AdminLTE.css"">
    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
    <script src=""https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js""></script>
    <script src=""https://oss.maxcdn.com/respond/1.4.2");
                WriteLiteral("/respond.min.js\"></script>\r\n    <![endif]-->\r\n    <!-- Google Font -->\r\n    <link rel=\"stylesheet\" href=\"https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,600,700,300italic,400italic,600italic\">\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1337, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1339, 3787, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "871e40ae1644436bb459dc49dd3473ef", async() => {
                BeginContext(1370, 269, true);
                WriteLiteral(@"
    <div class=""wrapper"">
        <!-- Main content -->
        <section class=""invoice"">
            <!-- title row -->
            <div class=""row"">
                <div class=""col-xs-22"">
                    <h2 class=""page-header"">
                        ");
                EndContext();
                BeginContext(1639, 78, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e91040bf8f454ac2a753f722a48175d6", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1717, 3402, true);
                WriteLiteral(@" Dr. Jonathan Burke Jr. -
                        Oftalmologista - CRM 00001 MG
                        <small class=""pull-right"">12/12/2019 17:30</small>
                    </h2>
                </div>
                <!-- /.col -->
            </div>
            <!-- info row -->
            <div class=""row invoice-info"">
                <div class=""col-sm-12 invoice-col"">
                    Paciente
                    <address>
                        <strong>Anderson Duarte</strong><br>
                        CPF 123.456.789-00<br>
                        End.: Rua Um, 2<br>
                        Tel: (31) 9999-9999<br>
                        E-mail: email@dominio.com.br
                    </address>
                </div>
            </div>
            <!-- /.row -->
            <div class=""row pad"">
                <div class=""col-xs-10"">
                    <b>Captopril 12.5</b>, comprimido (30un) Medley<br />
                    Tomar um comprimido via oral a cada 8 hor");
                WriteLiteral(@"as - uso contínuo
                </div>
                <div class=""col-xs-2"">
                    Qtd 1
                </div>
            </div>
            <div class=""row pad"">
                <div class=""col-xs-10"">
                    <b>Ablok 12.5</b>, comprimido (30un) Medley<br />
                    Tomar um comprimido via oral a cada 8 horas - uso contínuo
                </div>
                <div class=""col-xs-2"">
                    Qtd 1
                </div>
            </div>
            <div class=""row pad"">
                <div class=""col-xs-10"">
                    <b>Antak  12.5</b>, comprimido (30un) Medley<br />
                    Tomar um comprimido via oral a cada 1 hora
                </div>
                <div class=""col-xs-2"">
                    Qtd 1
                </div>
            </div>
            <div class=""row pad"">
                <div class=""col-xs-10"">
                    <b>Dipirona  12.5</b>, comprimido (30un)<br />
                 ");
                WriteLiteral(@"   Tomar um comprimido via oral em caso de mau estar.
                </div>
                <div class=""col-xs-2"">
                    Qtd 1
                </div>
            </div>
            <div class=""row pad"">
                <div class=""col-xs-10"">
                    <b>Dipirona  12.5</b>, comprimido (30un)<br />
                    Tomar um comprimido via oral em caso de mau estar.
                </div>
                <div class=""col-xs-2"">
                    Qtd 1
                </div>
            </div>
            <div class=""row pad"">
                <div class=""col-xs-12 text-center"">
                    ____________________________________________<br />
                    Dr. Jonathan Burke Jr<br />
                    Oftalmologista - CRM 00001 MG
                </div>
            </div>
        </section>
        <footer class=""main-footer"">
            <!-- To the right -->
            <div class=""pull-right hidden-xs"">
                Powered by <a href=""ht");
                WriteLiteral(@"tps://drac.co?ref=web.safelifesaude"">Dracco</a>
            </div>
            <!-- Default to the left -->
            <strong>Copyright © 2019 <a href=""https://safelifesaude.com.br"">SafeLife Saúde</a>.</strong> Todos os direitos reservados.
        </footer>
        <!-- /.content -->
    </div>
    <!-- ./wrapper -->
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5126, 9, true);
            WriteLiteral("\r\n</html>");
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
