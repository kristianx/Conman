#pragma checksum "C:\Users\krist\Desktop\Keebree\Views\Vlasnik\AddPodaci.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9cec5a3999259fcbeab4861cfc9ff2df678d6d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vlasnik_AddPodaci), @"mvc.1.0.view", @"/Views/Vlasnik/AddPodaci.cshtml")]
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
#line 1 "C:\Users\krist\Desktop\Keebree\Views\_ViewImports.cshtml"
using ConManApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\krist\Desktop\Keebree\Views\_ViewImports.cshtml"
using ConManApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9cec5a3999259fcbeab4861cfc9ff2df678d6d5", @"/Views/Vlasnik/AddPodaci.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b61a6947239c377993bfc1166ee1ff5a575f8c6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Vlasnik_AddPodaci : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConManApp.EnModels.Vlasnik>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\krist\Desktop\Keebree\Views\Vlasnik\AddPodaci.cshtml"
  
    ViewData["Title"] = "AddPodaci";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Register as Vlasnik:</h2>\n\n");
#nullable restore
#line 8 "C:\Users\krist\Desktop\Keebree\Views\Vlasnik\AddPodaci.cshtml"
 using ((Html.BeginForm("AddPodaci", "Vlasnik", FormMethod.Post)))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\krist\Desktop\Keebree\Views\Vlasnik\AddPodaci.cshtml"
Write(Html.TextBoxFor(m => m.Ime, new { @placeholder = "Ime" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\krist\Desktop\Keebree\Views\Vlasnik\AddPodaci.cshtml"
Write(Html.TextBoxFor(m => m.Prezime, new { @placeholder = "Prezime" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n");
#nullable restore
#line 13 "C:\Users\krist\Desktop\Keebree\Views\Vlasnik\AddPodaci.cshtml"
Write(Html.TextBoxFor(m => m.username, new { @placeholder = "Username" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n");
#nullable restore
#line 14 "C:\Users\krist\Desktop\Keebree\Views\Vlasnik\AddPodaci.cshtml"
Write(Html.TextBoxFor(m => m.password, new { @placeholder = "password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n    <input type=\"submit\" value=\"Sacuvaj\">\n");
#nullable restore
#line 16 "C:\Users\krist\Desktop\Keebree\Views\Vlasnik\AddPodaci.cshtml"


}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<a href=\"/Vlasnik/AddDrzava\">Dalje</a>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConManApp.EnModels.Vlasnik> Html { get; private set; }
    }
}
#pragma warning restore 1591
