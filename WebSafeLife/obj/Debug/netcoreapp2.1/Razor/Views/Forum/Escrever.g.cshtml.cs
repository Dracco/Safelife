#pragma checksum "D:\Dracco\Safelife\Web.SafeLife\WebSafeLife\Views\Forum\Escrever.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63810a56749d317ad9a0504396afd6c8f6af1123"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Forum_Escrever), @"mvc.1.0.view", @"/Views/Forum/Escrever.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Forum/Escrever.cshtml", typeof(AspNetCore.Views_Forum_Escrever))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63810a56749d317ad9a0504396afd6c8f6af1123", @"/Views/Forum/Escrever.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98b76eb30d6b79beb36de5b1740e50ad7bbc4401", @"/Views/_ViewImports.cshtml")]
    public class Views_Forum_Escrever : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Dracco\Safelife\Web.SafeLife\WebSafeLife\Views\Forum\Escrever.cshtml"
  
    ViewData["Title"] = "Nova Discussão";

#line default
#line hidden
            BeginContext(50, 5408, true);
            WriteLiteral(@"

<!-- Main content -->
<section class=""content"">
    <div class=""row"">
        <div class=""col-md-3"">
            <a href=""./"" class=""btn btn-primary btn-block margin-bottom"">Voltar para o Fórum</a>
            <div class=""box box-solid"">
                <div class=""box-header with-border"">
                    <h3 class=""box-title"">Temas</h3>
                    <div class=""box-tools"">
                        <button type=""button"" class=""btn btn-box-tool"" data-widget=""collapse"">
                            <i class=""fa fa-minus""></i>
                        </button>
                    </div>
                </div>
                <div class=""box-body no-padding"">
                    <ul class=""nav nav-pills nav-stacked"">
                        <li class=""active""><a href=""#""><i class=""fa fa-apple""></i> Alimentação Saudável<span class=""label label-primary pull-right"">12</span></a></li>
                        <li><a href=""#""><i class=""fa fa-bathtub""></i> Cuidados Pessoais<span class=""labe");
            WriteLiteral(@"l label-primary pull-right"">20</span></a></li>
                        <li><a href=""#""><i class=""fa fa-balance-scale""></i> Equilíbio Emocional<span class=""label label-primary pull-right"">7</span></a></li>
                        <li><a href=""#""><i class=""fa fa-heart""></i> Exercícios<span class=""label label-primary pull-right"">3</span></a></li>
                        <li><a href=""#""><i class=""fa fa-venus-mars""></i> Sexualidade<span class=""label label-primary pull-right"">1</span></a></li>
                    </ul>
                </div>
                <!-- /.box-body -->
            </div>
            <!-- /. box -->
         
        </div>
        <!-- /.col -->
        <div class=""col-md-9"">
            <div class=""box box-primary"">
                <div class=""box-header with-border"">
                    <h3 class=""box-title"">Escreva sobre o tema</h3>
                </div>
                <!-- /.box-header -->
                <div class=""box-body"">
                    
                ");
            WriteLiteral(@"    <div class=""form-group"">
                        <input class=""form-control"" placeholder=""Assunto: "">
                    </div>
                    <div class=""form-group"">
                        <textarea id=""compose-textarea"" class=""form-control"" style=""height: 300px"">
                        <h1><u>Heading Of Message</u></h1>
                        <h4>Subheading</h4>
                        <p>But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain
                        was born and I will give you a complete account of the system, and expound the actual teachings
                        of the great explorer of the truth, the master-builder of human happiness. No one rejects,
                        dislikes, or avoids pleasure itself, because it is pleasure, but because those who do not know
                        how to pursue pleasure rationally encounter consequences that are extremely painful. Nor again
                        is there anyo");
            WriteLiteral(@"ne who loves or pursues or desires to obtain pain of itself, because it is pain,
                        but because occasionally circumstances occur in which toil and pain can procure him some great
                        pleasure. To take a trivial example, which of us ever undertakes laborious physical exercise,
                        except to obtain some advantage from it? But who has any right to find fault with a man who
                        chooses to enjoy a pleasure that has no annoying consequences, or one who avoids a pain that
                        produces no resultant pleasure? On the other hand, we denounce with righteous indignation and
                        dislike men who are so beguiled and demoralized by the charms of pleasure of the moment, so
                        blinded by desire, that they cannot foresee</p>
                        <ul>
                        <li>List item one</li>
                        <li>List item two</li>
                        <li>List ");
            WriteLiteral(@"item three</li>
                        <li>List item four</li>
                      </ul>
                        <p>Thank you,</p>
                        <p>John Doe</p>
                    </textarea>
                    </div>
                    <div class=""form-group"">
                        <div class=""btn btn-default btn-file"">
                            <i class=""fa fa-paperclip""></i> Anexo
                            <input type=""file"" name=""attachment"">
                        </div>
                        <p class=""help-block"">Max. 32MB</p>
                    </div>
                </div>
                <!-- /.box-body -->
                <div class=""box-footer"">
                    <div class=""pull-right"">
                        <button type=""button"" class=""btn btn-default""><i class=""fa fa-pencil""></i> Salvar Rascunho</button>
                        <button type=""submit"" class=""btn btn-primary""><i class=""fa fa-send""></i> Publicar</button>
                    </div>
 ");
            WriteLiteral(@"                   <button type=""reset"" class=""btn btn-default""><i class=""fa fa-times""></i> Descartar</button>
                </div>
                <!-- /.box-footer -->
            </div>
            <!-- /. box -->
        </div>
        <!-- /.col -->
    </div>
</section>
");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5475, 1925, true);
                WriteLiteral(@"
    <!-- iCheck -->
    <script src=""../../plugins/iCheck/icheck.min.js""></script>
    <script>
        $(function () {
            //Enable iCheck plugin for checkboxes
            //iCheck for checkbox and radio inputs
            $('.mailbox-messages input[type=""checkbox""]').iCheck({
                checkboxClass: 'icheckbox_flat-blue',
                radioClass: 'iradio_flat-blue'
            });

            //Enable check and uncheck all functionality
            $("".checkbox-toggle"").click(function () {
                var clicks = $(this).data('clicks');
                if (clicks) {
                    //Uncheck all checkboxes
                    $("".mailbox-messages input[type='checkbox']"").iCheck(""uncheck"");
                    $("".fa"", this).removeClass(""fa-check-square-o"").addClass('fa-square-o');
                } else {
                    //Check all checkboxes
                    $("".mailbox-messages input[type='checkbox']"").iCheck(""check"");
                    $("".fa""");
                WriteLiteral(@", this).removeClass(""fa-square-o"").addClass('fa-check-square-o');
                }
                $(this).data(""clicks"", !clicks);
            });

            //Handle starring for glyphicon and font awesome
            $("".mailbox-star"").click(function (e) {
                e.preventDefault();
                //detect type
                var $this = $(this).find(""a > i"");
                var glyph = $this.hasClass(""glyphicon"");
                var fa = $this.hasClass(""fa"");

                //Switch states
                if (glyph) {
                    $this.toggleClass(""glyphicon-star"");
                    $this.toggleClass(""glyphicon-star-empty"");
                }

                if (fa) {
                    $this.toggleClass(""fa-star"");
                    $this.toggleClass(""fa-star-o"");
                }
            });
        });
    </script>

");
                EndContext();
            }
            );
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
