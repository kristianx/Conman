#pragma checksum "C:\Users\krist\Desktop\Keebree\Views\Skladistar\AddVozilo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "870efb8fe20b8cd34ac3e8bce51a3c2fb4cb4c22"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Skladistar_AddVozilo), @"mvc.1.0.view", @"/Views/Skladistar/AddVozilo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"870efb8fe20b8cd34ac3e8bce51a3c2fb4cb4c22", @"/Views/Skladistar/AddVozilo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b61a6947239c377993bfc1166ee1ff5a575f8c6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Skladistar_AddVozilo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConManApp.EnModels.Vozilo>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\krist\Desktop\Keebree\Views\Skladistar\AddVozilo.cshtml"
  
    ViewData["Title"] = "AddVozilo";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-md-4 offset-md-4 col-sm-12 form-wrapper\">\n    <h2>Dodaj novo vozilo</h2>\n\n");
#nullable restore
#line 8 "C:\Users\krist\Desktop\Keebree\Views\Skladistar\AddVozilo.cshtml"
     using (Html.BeginForm("AddVozilo", "Skladistar", FormMethod.Post,  new { enctype = "multipart/form-data", username = ViewBag.Username }))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\krist\Desktop\Keebree\Views\Skladistar\AddVozilo.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-group\">\n    <label>Naziv proizvodjaca</label><br />\n    ");
#nullable restore
#line 13 "C:\Users\krist\Desktop\Keebree\Views\Skladistar\AddVozilo.cshtml"
Write(Html.TextBoxFor(m => m.NazivProizvodjaca, new { @placeholder = "Unesite naziv proizvodjaca", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <br />\n</div>\n<div class=\"form-group \">\n    <label>Model vozila</label><br />\n    ");
#nullable restore
#line 18 "C:\Users\krist\Desktop\Keebree\Views\Skladistar\AddVozilo.cshtml"
Write(Html.TextBoxFor(m => m.Model, new { @placeholder = "Unesite model :", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <br />\n</div>\n<div class=\"form-group\">\n    <label>Godina proizvodnje</label><br />\n    ");
#nullable restore
#line 23 "C:\Users\krist\Desktop\Keebree\Views\Skladistar\AddVozilo.cshtml"
Write(Html.TextBoxFor(m => m.GodinaProizvodnje, new { @placeholder = "Unesite godinu proizvodnje:", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <br />\n</div>\n<div class=\"form-group\">\n    <label>Tip vozila</label><br />\n    ");
#nullable restore
#line 28 "C:\Users\krist\Desktop\Keebree\Views\Skladistar\AddVozilo.cshtml"
Write(Html.DropDownListFor(m => m.TipVozilaId, ViewBag.TipVozila as SelectList, "--Tip vozila--", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <a href=""/Skladistar/AddTipVozilo"" class=""form-control"">+Novi tip</a>
    <br />
</div>
        <div class=""form-group"">
            <label>Slikaa</label><br />
           
            <input type=""file"" name=""slika"" id=""slika"" class=""form-control"" style=""height: calc(1.5em + 0.75rem + 7px);""/>
            <br />
        </div>
        <div class=""form-row"">
            <input type=""submit"" value=""Sacuvaj"" class=""btn btn-success""/><br />
            <a href=""/Skladistar/Index"" class=""btn"">Otkazi</a>
        </div>
");
#nullable restore
#line 42 "C:\Users\krist\Desktop\Keebree\Views\Skladistar\AddVozilo.cshtml"
       }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

<style>
    .form-wrapper{
        margin-top:50px;
        
    }
        .form-wrapper h2 {
            margin-bottom: 20px;
            text-align: center;
        }
    .form-wrapper div{
        margin-bottom: 10px;
        line-height: 1;
    }
  
</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConManApp.EnModels.Vozilo> Html { get; private set; }
    }
}
#pragma warning restore 1591
