#pragma checksum "D:\Dracco\Safelife\Web.SafeLife\WebSafeLife\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67cace81a356b6b2945672899da8e327a8b1d8b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67cace81a356b6b2945672899da8e327a8b1d8b1", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"883bb44f4da27a1ef35808282134df6714057043", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "/Views/Shared/_Header.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "/Views/Shared/_Menu.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hold-transition skin-green-light sidebar-mini"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(25, 2540, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88d3392b52884be296862d1d77a23751", async() => {
                BeginContext(31, 2527, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <title>SafeLife Saúde</title>
    <!-- Tell the browser to be responsive to screen width -->
    <meta content=""width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no"" name=""viewport"">
    <link rel=""stylesheet"" href=""/lib/bootstrap/dist/css/bootstrap.min.css"">
    <!-- Font Awesome -->
    <link rel=""stylesheet"" href=""/lib/font-awesome/css/font-awesome.min.css"">
    <!-- Ionicons -->
    <link rel=""stylesheet"" href=""/lib/Ionicons/css/ionicons.min.css"">
    <!-- Theme style -->
    <link rel=""stylesheet"" href=""/css/AdminLTE.css"">
    <!-- AdminLTE Skins. We have chosen the skin-blue for this starter
        page. However, you can choose any other skin. Make sure you
        apply the skin class to the body tag so the changes take effect. -->
    <link rel=""stylesheet"" href=""/css/skins/skin-green-light.css"">
    <!-- iCheck for checkboxes and radio inputs -->
    <link rel=""stylesheet"" hr");
                WriteLiteral(@"ef=""/plugins/iCheck/all.css"">

    <!-- Morris chart -->
    <link rel=""stylesheet"" href=""/lib/morris.js/morris.css"">
    <!-- jvectormap -->
    <link rel=""stylesheet"" href=""/lib/jvectormap/jquery-jvectormap.css"">
    <!-- Date Picker -->
    <link rel=""stylesheet"" href=""/lib/bootstrap-datepicker/dist/css/bootstrap-datepicker.min.css"">
    <!-- Daterange picker -->
    <link rel=""stylesheet"" href=""/lib/bootstrap-daterangepicker/daterangepicker.css"">
    <!-- bootstrap wysihtml5 - text editor -->
    <link rel=""stylesheet"" href=""/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.min.css"">
    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
    <script src=""https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js""></script>
    <script src=""https://oss.maxcdn.com/respond/1.4.2/respond.min.js""></script>
    <![endif]-->
    <!-- Google Font -->
    <link rel=""s");
                WriteLiteral(@"tylesheet"" href=""https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,600,700,300italic,400italic,600italic"">
    <style>

        .example-modal .modal {
            position: relative;
            top: auto;
            bottom: auto;
            right: auto;
            left: auto;
            display: block;
            z-index: 1;
        }

        .example-modal .modal {
            background: transparent !important;
        }
    </style>
");
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
            BeginContext(2565, 976, true);
            WriteLiteral(@"
<!--
BODY TAG OPTIONS:
=================
Apply one or more of the following classes to get the
desired effect
|---------------------------------------------------------|
| SKINS         | skin-blue                               |
|               | skin-black                              |
|               | skin-purple                             |
|               | skin-yellow                             |
|               | skin-red                                |
|               | skin-green                              |
|---------------------------------------------------------|
|LAYOUT OPTIONS | fixed                                   |
|               | layout-boxed                            |
|               | layout-top-nav                          |
|               | sidebar-collapse                        |
|               | sidebar-mini                            |
|---------------------------------------------------------|
-->
");
            EndContext();
            BeginContext(3541, 4015, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f50d64e6a2254c32b8490b485b2870e4", async() => {
                BeginContext(3601, 109, true);
                WriteLiteral("\r\n    <div class=\"wrapper\">\r\n        <!-- Main Header -->\r\n        <header class=\"main-header\">\r\n            ");
                EndContext();
                BeginContext(3710, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5fefb9101c184a7e90ab90f088dffc68", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3757, 287, true);
                WriteLiteral(@"

        </header>
        <!-- Left side column. contains the logo and sidebar -->
        <aside class=""main-sidebar"">
            <!-- sidebar: style can be found in sidebar.less -->
            <section class=""sidebar"">
                <!-- Sidebar Menu -->
                ");
                EndContext();
                BeginContext(4044, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b87b64a31dea4dbda0e175bb8d2f44bd", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4089, 352, true);
                WriteLiteral(@"
                <!-- /.sidebar-menu -->
            </section>
            <!-- /.sidebar -->
        </aside>
        <!-- Content Wrapper. Contains page content -->
        <div class=""content-wrapper"">
            <!-- Content Header (Page header) -->
            <section class=""content-header"">
                <h1>
                    ");
                EndContext();
                BeginContext(4442, 17, false);
#line 100 "D:\Dracco\Safelife\Web.SafeLife\WebSafeLife\Views\Shared\_Layout.cshtml"
               Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(4459, 29, true);
                WriteLiteral("\r\n                    <small>");
                EndContext();
                BeginContext(4489, 20, false);
#line 101 "D:\Dracco\Safelife\Web.SafeLife\WebSafeLife\Views\Shared\_Layout.cshtml"
                      Write(ViewData["Subtitle"]);

#line default
#line hidden
                EndContext();
                BeginContext(4509, 193, true);
                WriteLiteral("</small>\r\n                </h1>\r\n                <ol class=\"breadcrumb\">\r\n                    <li><a href=\"/\"><i class=\"fa fa-home\"></i> Início</a></li>\r\n                    <li class=\"active\">");
                EndContext();
                BeginContext(4703, 17, false);
#line 105 "D:\Dracco\Safelife\Web.SafeLife\WebSafeLife\Views\Shared\_Layout.cshtml"
                                  Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(4720, 100, true);
                WriteLiteral("</li>\r\n                </ol>\r\n            </section>\r\n            <!-- /.content -->\r\n\r\n            ");
                EndContext();
                BeginContext(4821, 12, false);
#line 110 "D:\Dracco\Safelife\Web.SafeLife\WebSafeLife\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(4833, 2672, true);
                WriteLiteral(@"
        </div>

        <!-- /.content-wrapper -->
        <!-- Main Footer -->
        <footer class=""main-footer"">
            <!-- To the right -->
            <div class=""pull-right hidden-xs"">
                Powered by <a href=""https://drac.co?ref=web.safelifesaude"">Dracco</a>
            </div>
            <!-- Default to the left -->
            <strong>Copyright &copy; 2019 <a href=""https://safelifesaude.com.br"">SafeLife Saúde</a>.</strong> Todos os direitos reservados.
        </footer>
    </div>
    <!-- ./wrapper -->
    <!-- REQUIRED JS SCRIPTS -->
    <!-- jQuery 3 -->
    <script src=""/lib/jquery/dist/jquery.min.js""></script>
    <!-- jQuery UI 1.11.4 -->
    <script src=""/lib/jquery-ui/jquery-ui.min.js""></script>
    <!-- Resolve conflict in jQuery UI tooltip with Bootstrap tooltip -->
    <script>
        $.widget.bridge('uibutton', $.ui.button);
    </script>
    <!-- Bootstrap 3.3.7 -->
    <script src=""/lib/bootstrap/dist/js/bootstrap.min.js""></script>
    <!-- ");
                WriteLiteral(@"Morris.js charts -->
    <script src=""/lib/raphael/raphael.min.js""></script>
    <script src=""/lib/morris.js/morris.min.js""></script>
    <!-- Sparkline -->
    <script src=""/lib/jquery-sparkline/dist/jquery.sparkline.min.js""></script>
    <!-- jvectormap -->
    <script src=""/plugins/jvectormap/jquery-jvectormap-1.2.2.min.js""></script>
    <script src=""/plugins/jvectormap/jquery-jvectormap-world-mill-en.js""></script>
    <!-- jQuery Knob Chart -->
    <script src=""/lib/jquery-knob/dist/jquery.knob.min.js""></script>
    <!-- daterangepicker -->
    <script src=""/lib/moment/min/moment.min.js""></script>
    <script src=""/lib/bootstrap-daterangepicker/daterangepicker.js""></script>
    <!-- datepicker -->
    <script src=""/lib/bootstrap-datepicker/dist/js/bootstrap-datepicker.min.js""></script>
    <!-- Bootstrap WYSIHTML5 -->
    <script src=""/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.all.min.js""></script>
    <!-- Slimscroll -->
    <script src=""/lib/jquery-slimscroll/jquery.slimscroll.m");
                WriteLiteral(@"in.js""></script>
    <!-- FastClick -->
    <script src=""/lib/fastclick/lib/fastclick.js""></script>
    <!-- AdminLTE App -->
    <script src=""/js/adminlte.min.js""></script>
    <!-- iCheck 1.0.1 -->
    <script src=""/plugins/iCheck/icheck.min.js""></script>
    <script>
        $(function () {
           
            //Flat red color scheme for iCheck
            $('input[type=""checkbox""].flat-green, input[type=""radio""].flat-green').iCheck({
                checkboxClass: 'icheckbox_flat-green',
                radioClass: 'iradio_flat-green'
            })
            
        })
    </script>
    ");
                EndContext();
                BeginContext(7506, 41, false);
#line 172 "D:\Dracco\Safelife\Web.SafeLife\WebSafeLife\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(7547, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7556, 9, true);
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
