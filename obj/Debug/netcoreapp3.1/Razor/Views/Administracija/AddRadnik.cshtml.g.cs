#pragma checksum "C:\Users\krist\Desktop\Keebree\Views\Administracija\AddRadnik.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "608c52269978493da748a58274352ee0d1f83628"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administracija_AddRadnik), @"mvc.1.0.view", @"/Views/Administracija/AddRadnik.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"608c52269978493da748a58274352ee0d1f83628", @"/Views/Administracija/AddRadnik.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b61a6947239c377993bfc1166ee1ff5a575f8c6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Administracija_AddRadnik : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConManApp.EnModels.Radnik>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\krist\Desktop\Keebree\Views\Administracija\AddRadnik.cshtml"
  
    ViewData["Title"] = "AddRadnik";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>AddRadnik</h2>\n<style>\n    .error\n    {\n\n        color:red;\n    }\n</style>\n");
#nullable restore
#line 14 "C:\Users\krist\Desktop\Keebree\Views\Administracija\AddRadnik.cshtml"
 using (Html.BeginForm("AddRadnik", "Administracija", FormMethod.Post))
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\krist\Desktop\Keebree\Views\Administracija\AddRadnik.cshtml"
Write(Html.TextBoxFor(m => m.Ime, new { @placeholder = "Ime" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\krist\Desktop\Keebree\Views\Administracija\AddRadnik.cshtml"
Write(Html.ValidationMessageFor(m=>m.Ime,"Unesite ime",new {@class="error" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n");
#nullable restore
#line 19 "C:\Users\krist\Desktop\Keebree\Views\Administracija\AddRadnik.cshtml"
Write(Html.TextBoxFor(m => m.Prezime, new { @placeholder = "Prezime" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n");
#nullable restore
#line 20 "C:\Users\krist\Desktop\Keebree\Views\Administracija\AddRadnik.cshtml"
Write(Html.TextBoxFor(m => m.username, new { @placeholder = "Username" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n");
#nullable restore
#line 21 "C:\Users\krist\Desktop\Keebree\Views\Administracija\AddRadnik.cshtml"
Write(Html.TextBoxFor(m => m.password, new { @placeholder = "password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n");
#nullable restore
#line 22 "C:\Users\krist\Desktop\Keebree\Views\Administracija\AddRadnik.cshtml"
Write(Html.TextBoxFor(m => m.KontaktBroj, new { @placeholder = "Broj format xxx/xxx-xxx(x)" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n");
#nullable restore
#line 23 "C:\Users\krist\Desktop\Keebree\Views\Administracija\AddRadnik.cshtml"
Write(Html.TextBoxFor(m => m.info, new { @placeholder = "Dodatne info" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" value=\"Sacuvaj\">\n");
#nullable restore
#line 26 "C:\Users\krist\Desktop\Keebree\Views\Administracija\AddRadnik.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConManApp.EnModels.Radnik> Html { get; private set; }
    }
}
#pragma warning restore 1591
