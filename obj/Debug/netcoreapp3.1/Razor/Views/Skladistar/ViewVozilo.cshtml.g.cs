#pragma checksum "C:\Users\krist\Desktop\ConManApp\Views\Skladistar\ViewVozilo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8608df59fd94a42d8564d2c8c80dec6461a7327"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Skladistar_ViewVozilo), @"mvc.1.0.view", @"/Views/Skladistar/ViewVozilo.cshtml")]
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
#line 1 "C:\Users\krist\Desktop\ConManApp\Views\_ViewImports.cshtml"
using ConManApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\krist\Desktop\ConManApp\Views\_ViewImports.cshtml"
using ConManApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8608df59fd94a42d8564d2c8c80dec6461a7327", @"/Views/Skladistar/ViewVozilo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b61a6947239c377993bfc1166ee1ff5a575f8c6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Skladistar_ViewVozilo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConManApp.Models.VoziloViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\krist\Desktop\ConManApp\Views\Skladistar\ViewVozilo.cshtml"
  
    ViewData["Title"] = "ViewVozilo";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<style>\n    .naslovi {\n        background-color: deepskyblue;\n    }\n</style>\n");
#nullable restore
#line 11 "C:\Users\krist\Desktop\ConManApp\Views\Skladistar\ViewVozilo.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\n    <p class=\"naslovi\">Vozilo ID:</p>\n    <p>");
#nullable restore
#line 15 "C:\Users\krist\Desktop\ConManApp\Views\Skladistar\ViewVozilo.cshtml"
  Write(Model.voziloID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p><br />\n    <p class=\"naslovi\">Naziv proizvodjaca:</p>\n    <p>");
#nullable restore
#line 17 "C:\Users\krist\Desktop\ConManApp\Views\Skladistar\ViewVozilo.cshtml"
  Write(Model.ProizvodjacNaziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p><br />\n    <p class=\"naslovi\">Model:</p>\n    <p>");
#nullable restore
#line 19 "C:\Users\krist\Desktop\ConManApp\Views\Skladistar\ViewVozilo.cshtml"
  Write(Model.ModdelNaziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p><br />\n    <p class=\"naslovi\">Tip vozila:</p>\n    <p>");
#nullable restore
#line 21 "C:\Users\krist\Desktop\ConManApp\Views\Skladistar\ViewVozilo.cshtml"
  Write(Model.tipvozila);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p><br />\n    <p class=\"naslovi\">Naziv skladista:</p>\n    <p>");
#nullable restore
#line 23 "C:\Users\krist\Desktop\ConManApp\Views\Skladistar\ViewVozilo.cshtml"
  Write(Model.nazivskladista);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p><br />\n    <p class=\"naslovi\">Adresa:</p>\n    <p>");
#nullable restore
#line 25 "C:\Users\krist\Desktop\ConManApp\Views\Skladistar\ViewVozilo.cshtml"
  Write(Model.adresaskladista);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p><br />\n    <p class=\"naslovi\">Grad:</p>\n    <p>");
#nullable restore
#line 27 "C:\Users\krist\Desktop\ConManApp\Views\Skladistar\ViewVozilo.cshtml"
  Write(Model.NazivGrada);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p><br />\n\n\n\n\n</div>\n");
#nullable restore
#line 33 "C:\Users\krist\Desktop\ConManApp\Views\Skladistar\ViewVozilo.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Trazeno vozilo ne postoji.</p>\n");
#nullable restore
#line 37 "C:\Users\krist\Desktop\ConManApp\Views\Skladistar\ViewVozilo.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConManApp.Models.VoziloViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
