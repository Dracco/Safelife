#pragma checksum "D:\Dracco\Safelife\Web.SafeLife\WebSafeLife\Views\Historicos\PressaoArterial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88218b3ce341a7f3c51a54aa7a06261a746b4561"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Historicos_PressaoArterial), @"mvc.1.0.view", @"/Views/Historicos/PressaoArterial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Historicos/PressaoArterial.cshtml", typeof(AspNetCore.Views_Historicos_PressaoArterial))]
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
using WebSafeLife.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88218b3ce341a7f3c51a54aa7a06261a746b4561", @"/Views/Historicos/PressaoArterial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"883bb44f4da27a1ef35808282134df6714057043", @"/Views/_ViewImports.cshtml")]
    public class Views_Historicos_PressaoArterial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Dracco\Safelife\Web.SafeLife\WebSafeLife\Views\Historicos\PressaoArterial.cshtml"
  
    ViewData["Title"] = "Pressão Arterial";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(101, 6596, true);
            WriteLiteral(@"

<section class=""content"">
    <!-- Small boxes (Stat box) -->
    <div class=""row"">
        <div class=""col-md-5"">
            <!-- /.box -->
            <div class=""box"">

                <!-- /.box-header -->
                <div class=""box-body"">
                    <table id=""example1"" class=""table table-bordered table-striped"">
                        <thead>
                            <tr>
                                <th>Data da aferição</th>
                                <th>Sistólica</th>
                                <th>Diastólica</th>
                                <th>Ações</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>12/12/2019</td>
                                <td>12</td>
                                <td>8</td>
                                <td>
                                    <div class=""btn-group"">
                   ");
            WriteLiteral(@"                     <button type=""button"" class=""btn btn-default""><i class=""fa fa-edit""></i></button>
                                        <button type=""button"" class=""btn btn-default""><i class=""fa fa-trash-o""></i></button>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td>12/12/2019</td>
                                <td>12</td>
                                <td>8</td>
                                <td>
                                    <div class=""btn-group"">
                                        <button type=""button"" class=""btn btn-default""><i class=""fa fa-edit""></i></button>
                                        <button type=""button"" class=""btn btn-default""><i class=""fa fa-trash-o""></i></button>
                                    </div>
                                </td>
                            </tr>
                            <tr>
");
            WriteLiteral(@"                                <td>12/12/2019</td>
                                <td>12</td>
                                <td>8</td>
                                <td>
                                    <div class=""btn-group"">
                                        <button type=""button"" class=""btn btn-default""><i class=""fa fa-edit""></i></button>
                                        <button type=""button"" class=""btn btn-default""><i class=""fa fa-trash-o""></i></button>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td>12/12/2019</td>
                                <td>12</td>
                                <td>8</td>
                                <td>
                                    <div class=""btn-group"">
                                        <button type=""button"" class=""btn btn-default""><i class=""fa fa-edit""></i></button>
                  ");
            WriteLiteral(@"                      <button type=""button"" class=""btn btn-default""><i class=""fa fa-trash-o""></i></button>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td>12/12/2019</td>
                                <td>12</td>
                                <td>8</td>
                                <td>
                                    <div class=""btn-group"">
                                        <button type=""button"" class=""btn btn-default""><i class=""fa fa-edit""></i></button>
                                        <button type=""button"" class=""btn btn-default""><i class=""fa fa-trash-o""></i></button>
                                    </div>
                                </td>
                            </tr>
                        </tbody>
                       
                    </table>
                </div>
                <!-- /.box-body -->
      ");
            WriteLiteral(@"          <div class=""box-footer"">
                    <div>
                        <button type=""submit"" class=""btn btn-success pull-right"" data-toggle=""modal"" data-target=""#modal-default"">Adicionar nova aferição</button>
                    </div>
                </div>
            </div>


        </div>
        <div class=""col-md-7"">
            <!-- LINE CHART -->
            <div class=""box box-info"">
                <div class=""box-body chart-responsive"">
                    <div class=""chart"" id=""revenue-chart"" style=""height: 300px;""></div>
                </div>
                <!-- /.box-body -->
            </div>
        </div>


    </div>
</section>

<!--modal-dialog-->
<div class=""modal fade"" id=""modal-default"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span");
            WriteLiteral(@">
                </button>
                <h4 class=""modal-title"">Aferição de Pressão Arterial</h4>
            </div>
            <div class=""modal-body"">
                <div class=""row"">
                    <div class=""col-xs-4"">
                        <label>Data</label>
                        <div class=""input-group"">
                            <div class=""input-group-addon"">
                                <i class=""fa fa-calendar""></i>
                            </div>
                            <input type=""text"" class=""form-control"" data-inputmask=""'alias': 'dd/mm/yyyy'"" data-mask="""" >
                        </div>
                    </div>
                    <div class=""col-xs-4"">
                        <label>Sistólica</label>
                        <input type=""text"" class=""form-control"">
                    </div>
                    <div class=""col-xs-4"">
                        <label>Diastólica</label>
                        <input type=""text"" class=""form-cont");
            WriteLiteral(@"rol"">
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
            DefineSection("Scripts", async() => {
                BeginContext(6714, 1484, true);
                WriteLiteral(@"
    <script src=""/lib/datatables.net/js/jquery.dataTables.min.js""></script>
    <script src=""/lib/datatables.net-bs/js/dataTables.bootstrap.min.js""></script>
    <script>
        $(function () {
            $('#example1').DataTable({
                'paging': true,
                'lengthChange': false,
                'searching': false,
                'ordering': false,
                'info': false,
                'autoWidth': false
            })
        })
    </script>


    <script src=""/lib/raphael/raphael.min.js""></script>

    <script src=""/lib/morris.js/morris.min.js""></script>

    <script>
        $(function () {
            ""use strict"";

     // AREA CHART
    var area = new Morris.Area({
      element: 'revenue-chart',
      resize: true,
      data: [
        {y: '2011 Q1', item1: 12, item2: 8},
        {y: '2011 Q2', item1: 13, item2: 8},
        {y: '2011 Q3', item1: 13, item2: 9},
        {y: '2011 Q4', item1: 14, item2: 10},
        {y: '2012 Q1', item");
                WriteLiteral(@"1: 14, item2: 8},
        {y: '2012 Q2', item1: 12, item2: 11},
        {y: '2012 Q3', item1: 13, item2: 10},
        {y: '2012 Q4', item1: 15, item2: 8},
        {y: '2013 Q1', item1: 15, item2: 10},
        {y: '2013 Q2', item1: 14, item2: 8}
      ],
      xkey: 'y',
      ykeys: ['item1', 'item2'],
      labels: ['Sistolica', 'Diastolica'],
      lineColors: ['#a0d0e0', '#3c8dbc'],
      hideHover: 'auto'
    });


        });</script>
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
