#pragma checksum "/Users/volkan/RiderProjects/AspCoreWebApp/AspCoreWebApp/Views/Departman/DepartmanGetir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2259e3d9e80ec6e28f9e9b7c834edf5bb0797124"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Departman_DepartmanGetir), @"mvc.1.0.view", @"/Views/Departman/DepartmanGetir.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/volkan/RiderProjects/AspCoreWebApp/AspCoreWebApp/Views/_ViewImports.cshtml"
using AspCoreWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/volkan/RiderProjects/AspCoreWebApp/AspCoreWebApp/Views/_ViewImports.cshtml"
using AspCoreWebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/volkan/RiderProjects/AspCoreWebApp/AspCoreWebApp/Views/_ViewImports.cshtml"
using NonFactors.Mvc.Grid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/volkan/RiderProjects/AspCoreWebApp/AspCoreWebApp/Views/_ViewImports.cshtml"
using System;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2259e3d9e80ec6e28f9e9b7c834edf5bb0797124", @"/Views/Departman/DepartmanGetir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91a360e7e91e19e60f55a16b5ea011ab302fbe2d", @"/Views/_ViewImports.cshtml")]
    public class Views_Departman_DepartmanGetir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AspCoreWebApp.Entities.Models.Departman>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/volkan/RiderProjects/AspCoreWebApp/AspCoreWebApp/Views/Departman/DepartmanGetir.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_KategoriLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""content-wrapper"">
    <section class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1>Departman G??ncelleme</h1>
                </div>
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item""><a href=""#"">Anasayfa</a></li>
                        <li class=""breadcrumb-item active"">Kategoriler</li>
                    </ol>
                </div>
            </div>
        </div>
        <!--  /.container-fluid-->
    </section>
    <section class=""content"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""card"">


                        <div class=""card-body"">
");
#nullable restore
#line 32 "/Users/volkan/RiderProjects/AspCoreWebApp/AspCoreWebApp/Views/Departman/DepartmanGetir.cshtml"
                             using (Html.BeginForm("DepartmanGuncelle", "Departman", FormMethod.Post))
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"form-group\">\n                                    ");
#nullable restore
#line 36 "/Users/volkan/RiderProjects/AspCoreWebApp/AspCoreWebApp/Views/Departman/DepartmanGetir.cshtml"
                               Write(Html.Label("Departman Ad??"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    ");
#nullable restore
#line 37 "/Users/volkan/RiderProjects/AspCoreWebApp/AspCoreWebApp/Views/Departman/DepartmanGetir.cshtml"
                               Write(Html.TextBoxFor(x => x.DepartmanAd, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    ");
#nullable restore
#line 38 "/Users/volkan/RiderProjects/AspCoreWebApp/AspCoreWebApp/Views/Departman/DepartmanGetir.cshtml"
                               Write(Html.HiddenFor(x => x.DepartmanID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </div>\n                                <button class=\"btn btn-warning\">G??ncelle</button>\n");
#nullable restore
#line 41 "/Users/volkan/RiderProjects/AspCoreWebApp/AspCoreWebApp/Views/Departman/DepartmanGetir.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>

                        <!--   /.card-body-->
                    </div>
                    <!--  /.card-->
                </div>
                <!--  /.col-->
            </div>
            <!--  /.row-->
        </div>
        <!-- /.container-fluid -->
    </section>



</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AspCoreWebApp.Entities.Models.Departman> Html { get; private set; }
    }
}
#pragma warning restore 1591
