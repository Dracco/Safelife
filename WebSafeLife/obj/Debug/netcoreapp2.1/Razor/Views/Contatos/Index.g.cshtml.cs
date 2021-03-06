#pragma checksum "D:\Dracco\Safelife\Web.SafeLife\WebSafeLife\Views\Contatos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9091b333e1dc53d69ea243d95373fe0b62b23ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contatos_Index), @"mvc.1.0.view", @"/Views/Contatos/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Contatos/Index.cshtml", typeof(AspNetCore.Views_Contatos_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9091b333e1dc53d69ea243d95373fe0b62b23ed", @"/Views/Contatos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98b76eb30d6b79beb36de5b1740e50ad7bbc4401", @"/Views/_ViewImports.cshtml")]
    public class Views_Contatos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebSafeLife.ViewModels.ContatosViewModel>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Dracco\Safelife\Web.SafeLife\WebSafeLife\Views\Contatos\Index.cshtml"
  
    ViewData["Title"] = "Contatos de Emergência";
    ViewData["Subtitle"] = "Sua família e amigos";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(208, 938, true);
            WriteLiteral(@"


<!-- Main content -->
<section class=""content"">
    <div class=""row"">
        <div class=""col-md-12"">
            <!-- Horizontal Form -->
            <div class=""box box-default"">
                <div class=""box-header with-border"">
                    <h3 class=""box-title"">Contatos</h3>
                </div>
                <!-- /.box-header -->
                <!-- form start -->
                <div class=""box-body"">
                    <table class=""table table-bordered"">
                        <thead>
                            <tr>
                                <th style=""width: 10px"">#</th>
                                <th>Nome</th>
                                <th>Relacionamento</th>
                                <th>Telefone</th>
                                <th>Ações</th>
                            </tr>
                        </thead>
                        <tbody>
");
            EndContext();
#line 34 "D:\Dracco\Safelife\Web.SafeLife\WebSafeLife\Views\Contatos\Index.cshtml"
                             foreach (var contato in Model.Contatos)
                            {

#line default
#line hidden
            BeginContext(1247, 78, true);
            WriteLiteral("                                <tr>\r\n                                    <td>");
            EndContext();
            BeginContext(1326, 10, false);
#line 37 "D:\Dracco\Safelife\Web.SafeLife\WebSafeLife\Views\Contatos\Index.cshtml"
                                   Write(contato.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1336, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1384, 12, false);
#line 38 "D:\Dracco\Safelife\Web.SafeLife\WebSafeLife\Views\Contatos\Index.cshtml"
                                   Write(contato.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1396, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1444, 22, false);
#line 39 "D:\Dracco\Safelife\Web.SafeLife\WebSafeLife\Views\Contatos\Index.cshtml"
                                   Write(contato.Relacionamento);

#line default
#line hidden
            EndContext();
            BeginContext(1466, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1514, 15, false);
#line 40 "D:\Dracco\Safelife\Web.SafeLife\WebSafeLife\Views\Contatos\Index.cshtml"
                                   Write(contato.Celular);

#line default
#line hidden
            EndContext();
            BeginContext(1529, 501, true);
            WriteLiteral(@"</td>
                                    <td>
                                        <div class=""btn-group"">
                                            <button type=""button"" class=""btn btn-default""><i class=""fa fa-edit""></i></button>
                                            <button type=""button"" class=""btn btn-default""><i class=""fa fa-trash-o""></i></button>
                                        </div>
                                    </td>
                                </tr>
");
            EndContext();
#line 48 "D:\Dracco\Safelife\Web.SafeLife\WebSafeLife\Views\Contatos\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(2061, 1373, true);
            WriteLiteral(@"
                        </tbody>
                    </table>
                </div>
                <!-- /.box-body -->
                <div class=""box-footer"">
                    <div>
                        <button type=""submit"" class=""btn btn-success pull-right"" data-toggle=""modal"" data-target=""#modal-default"">Adicionar</button>
                    </div>
                </div>
            </div>

        </div>
        <!--/.col (right) -->

    </div>


    <!-- /.row -->
</section>
<!-- /.content -->
<!--modal-dialog-->
<div class=""modal fade"" id=""modal-default"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
                <h4 class=""modal-title"">Contato</h4>
            </div>
            <div class=""modal-body"">
                <d");
            WriteLiteral(@"iv class=""form-group"">
                    <label>Nome</label>
                    <input type=""text""  class=""form-control"" placeholder=""Nome Completo"">
                </div>
                <div class=""form-group"">
                    <label>Relacionamento</label>
                    <select  class=""form-control"">
                        ");
            EndContext();
            BeginContext(3434, 24, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c3722f2636f48f7928be51f50bf0cb0", async() => {
                BeginContext(3442, 7, true);
                WriteLiteral("Escolha");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3458, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(3484, 26, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab62c7851ffb40b8aff18e169e6f8ae2", async() => {
                BeginContext(3492, 9, true);
                WriteLiteral("Esposo(a)");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3510, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(3536, 25, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b3096d14d25414db2c1ef3a438c5cad", async() => {
                BeginContext(3544, 8, true);
                WriteLiteral("Filho(a)");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3561, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(3587, 24, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "890725c2546c412284bd6c6e9903b85a", async() => {
                BeginContext(3595, 7, true);
                WriteLiteral("Pai/Mãe");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3611, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(3637, 23, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44fec19d16b042a08fbda8101d412ad8", async() => {
                BeginContext(3645, 6, true);
                WriteLiteral("Avô(ó)");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3660, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(3686, 25, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82a471f30f1749d0a65d2f963b277760", async() => {
                BeginContext(3694, 8, true);
                WriteLiteral("Irmão(ã)");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3711, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(3737, 28, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfe2d8b451eb48e8afc7104efb5971bf", async() => {
                BeginContext(3745, 11, true);
                WriteLiteral("Namorado(a)");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3765, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(3791, 23, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e4ec773d6994da386be2485fdea8454", async() => {
                BeginContext(3799, 6, true);
                WriteLiteral("Tio(a)");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3814, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(3840, 25, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c0cfec822da41a78f48a8a5c778adcd", async() => {
                BeginContext(3848, 8, true);
                WriteLiteral("Primo(a)");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3865, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(3891, 25, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b75227f818604355aef252ddd54cfdf6", async() => {
                BeginContext(3899, 8, true);
                WriteLiteral("Amigo(a)");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3916, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(3942, 23, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f150b1e32e97450da2328a74dd9ad44d", async() => {
                BeginContext(3950, 6, true);
                WriteLiteral("Outros");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3965, 2016, true);
            WriteLiteral(@"
                    </select>
                </div>
                <div class=""row form-group"">
                    <div class=""col-xs-6"">
                        <label>Celular</label>
                        <div class=""input-group"">
                            <div class=""input-group-addon"">
                                <i class=""fa fa-phone""></i>
                            </div>
                            <input type=""text"" class=""form-control"" data-inputmask=""&quot;mask&quot;: &quot;(99) 999-9999&quot;"" data-mask="""" id=""Celular"" name=""Celular"" value="""" placeholder=""(XX) X XXXX-XXXX"">
                        </div>
                    </div>
                    <div class=""col-xs-6"">
                        <label>Outro Telefone</label>
                        <div class=""input-group"">
                            <div class=""input-group-addon"">
                                <i class=""fa fa-phone""></i>
                            </div>
                            <input type=");
            WriteLiteral(@"""text"" class=""form-control"" data-inputmask=""&quot;mask&quot;: &quot;(99) 999-9999&quot;"" data-mask="""" id=""Celular"" name=""Celular"" value="""" placeholder=""(XX) X XXXX-XXXX"">
                        </div>
                    </div>
                </div>
                <div class=""form-group"">
                    <label>E-mail</label>
                    <div class=""input-group"">
                        <span class=""input-group-addon""><i class=""fa fa-envelope""></i></span>
                        <input  type=""email"" class=""form-control"">
                    </div>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-default pull-left"" data-dismiss=""modal"">Fechar</button>
                <button type=""button"" class=""btn btn-primary"" data-dismiss=""modal"">Salvar</button>
            </div>
        </div>
        <!-- /.modal-content -->
    </div>
    <!-- /.modal-dialog -->
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebSafeLife.ViewModels.ContatosViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
