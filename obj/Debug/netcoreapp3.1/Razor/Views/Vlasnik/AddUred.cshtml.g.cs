#pragma checksum "C:\Users\krist\Desktop\ConManApp\Views\Vlasnik\AddUred.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f12c1b723b3a61b0510bb5e6e5a41d3b70aab79d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vlasnik_AddUred), @"mvc.1.0.view", @"/Views/Vlasnik/AddUred.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f12c1b723b3a61b0510bb5e6e5a41d3b70aab79d", @"/Views/Vlasnik/AddUred.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b61a6947239c377993bfc1166ee1ff5a575f8c6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Vlasnik_AddUred : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConManApp.EnModels.Ured>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\krist\Desktop\ConManApp\Views\Vlasnik\AddUred.cshtml"
  
    ViewData["Title"] = "AddUred";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<script>\n\n\n</script>\n<style>\n\n    #tekst {\n        display: none;\n        color: red;\n    }\n\n    .plista:hover #tekst {\n        display: inline-block;\n    }\n</style>\n\n");
            WriteLiteral("\n<h2>AddUred</h2>\n");
#nullable restore
#line 56 "C:\Users\krist\Desktop\ConManApp\Views\Vlasnik\AddUred.cshtml"
 using (Html.BeginForm("AddUred", "Vlasnik", FormMethod.Post))
{

    

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Unesite adresu ureda:</p><br />\n");
#nullable restore
#line 61 "C:\Users\krist\Desktop\ConManApp\Views\Vlasnik\AddUred.cshtml"
   Write(Html.TextBoxFor(m => m.Adresa, new { @placeholder = "Adresa ureda" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n        <p>Grad:</p>\n");
#nullable restore
#line 63 "C:\Users\krist\Desktop\ConManApp\Views\Vlasnik\AddUred.cshtml"
   Write(Html.DropDownListFor(m => m.GradId, ViewBag.GradoviBag as SelectList, "Odaberi grad"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n        <input type=\"submit\" value=\"Sacuvaj\" />\n        <a href=\"/Vlasnik/AddAdministracija\">Dalje</a>\n");
#nullable restore
#line 66 "C:\Users\krist\Desktop\ConManApp\Views\Vlasnik\AddUred.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConManApp.EnModels.Ured> Html { get; private set; }
    }
}
#pragma warning restore 1591
