#pragma checksum "C:\Users\krist\Desktop\ConManApp\Views\Administracija\ViewPoslovodja.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e4f78a1b165453b2a88af01c0a0e6e78f1e5d22"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administracija_ViewPoslovodja), @"mvc.1.0.view", @"/Views/Administracija/ViewPoslovodja.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e4f78a1b165453b2a88af01c0a0e6e78f1e5d22", @"/Views/Administracija/ViewPoslovodja.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b61a6947239c377993bfc1166ee1ff5a575f8c6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Administracija_ViewPoslovodja : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConManApp.EnModels.Poslovodja>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\krist\Desktop\ConManApp\Views\Administracija\ViewPoslovodja.cshtml"
  
    ViewData["Title"] = "ViewPoslovodja";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\n    .ispisposlovodja {\n        background-color: ghostwhite;\n    }\n\n    .naslovi {\n        background-color: red;\n    }\n\n    #podaci {\n        background-color: whitesmoke;\n    }\n</style>\n<h2>ViewPoslovodja</h2>\n");
#nullable restore
#line 19 "C:\Users\krist\Desktop\ConManApp\Views\Administracija\ViewPoslovodja.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"ispisposlovodja\">\n    <p class=\"naslovi\">Ime:</p>\n    <p id=\"podaci\">");
#nullable restore
#line 23 "C:\Users\krist\Desktop\ConManApp\Views\Administracija\ViewPoslovodja.cshtml"
              Write(Model.Ime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p><br />\n    <p class=\"naslovi\">Prezime:</p>\n    <p id=\"podaci\">");
#nullable restore
#line 25 "C:\Users\krist\Desktop\ConManApp\Views\Administracija\ViewPoslovodja.cshtml"
              Write(Model.Prezime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p><br />\n    <p class=\"naslovi\">Username:</p>\n    <p id=\"podaci\">");
#nullable restore
#line 27 "C:\Users\krist\Desktop\ConManApp\Views\Administracija\ViewPoslovodja.cshtml"
              Write(Model.username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p><br />\n    <p class=\"naslovi\">Password:</p>\n    <p id=\"podaci\">");
#nullable restore
#line 29 "C:\Users\krist\Desktop\ConManApp\Views\Administracija\ViewPoslovodja.cshtml"
              Write(Model.password);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p><br />\n    <p class=\"naslovi\">Kontakt broj:</p>\n    <p id=\"podaci\">");
#nullable restore
#line 31 "C:\Users\krist\Desktop\ConManApp\Views\Administracija\ViewPoslovodja.cshtml"
              Write(Model.KontaktBroj);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p><br />\n    <p class=\"naslovi\">Info:</p>\n    <p id=\"podaci\">");
#nullable restore
#line 33 "C:\Users\krist\Desktop\ConManApp\Views\Administracija\ViewPoslovodja.cshtml"
              Write(Model.OpisIskustva);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n</div>\n");
#nullable restore
#line 35 "C:\Users\krist\Desktop\ConManApp\Views\Administracija\ViewPoslovodja.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\"Trazeni poslovodja ne postoji.\"</p>\n");
#nullable restore
#line 39 "C:\Users\krist\Desktop\ConManApp\Views\Administracija\ViewPoslovodja.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConManApp.EnModels.Poslovodja> Html { get; private set; }
    }
}
#pragma warning restore 1591
