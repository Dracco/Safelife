#pragma checksum "D:\Dracco\Safelife\Web.SafeLife\WebSafeLife\Views\Mapa\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "410ae1830140d0977835bdd949a0abb04690346e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mapa_Index), @"mvc.1.0.view", @"/Views/Mapa/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Mapa/Index.cshtml", typeof(AspNetCore.Views_Mapa_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"410ae1830140d0977835bdd949a0abb04690346e", @"/Views/Mapa/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"883bb44f4da27a1ef35808282134df6714057043", @"/Views/_ViewImports.cshtml")]
    public class Views_Mapa_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Dracco\Safelife\Web.SafeLife\WebSafeLife\Views\Mapa\Index.cshtml"
  
    ViewData["Title"] = "Mapa de Clínicas";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(101, 1197, true);
            WriteLiteral(@"


<!-- Main content -->
<section class=""content"">
    <div class=""row"">
        <!-- left column -->
        <div class=""col-md-12"">
            <!-- general form elements -->
            <div class=""box box-warning"">

                <!-- /.box-header -->
                <!-- form start -->
                <div class=""box-body"">
                    <div class=""form-group"">
                        <iframe width=""800"" height=""600"" src=""https://maps.google.com/maps?hl=en&amp;q=&amp;ie=UTF8&amp;t=&amp;z=10&amp;iwloc=B&amp;output=embed"" frameborder=""0"" scrolling=""no"" marginheight=""0"" marginwidth=""0""></iframe>
                        <style>
                            #gmap_canvas img {
                                max-width: none !important;
                                background: none !important
                            }
                        </style>
                    </div>

                </div>
                <!-- /.box-body -->

            </div>
            <");
            WriteLiteral("!-- /.box -->\r\n\r\n        </div>\r\n        <!--/.col (left) -->\r\n        <!-- /.row -->\r\n        <!-- /.content -->\r\n    </div>\r\n    <!-- /.content-wrapper -->\r\n</section>\r\n\r\n");
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
