#pragma checksum "C:\Users\krist\Desktop\ConManApp\Views\Skladistar\AddVozilo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c20a69677fb055265c6ce4c345733e6fac54b8c"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c20a69677fb055265c6ce4c345733e6fac54b8c", @"/Views/Skladistar/AddVozilo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b61a6947239c377993bfc1166ee1ff5a575f8c6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Skladistar_AddVozilo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConManApp.EnModels.Vozilo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "file", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\krist\Desktop\ConManApp\Views\Skladistar\AddVozilo.cshtml"
  
    ViewData["Title"] = "AddVozilo";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>AddVozilo</h2>\n\n");
#nullable restore
#line 8 "C:\Users\krist\Desktop\ConManApp\Views\Skladistar\AddVozilo.cshtml"
 using (Html.BeginForm("AddVozilo", "Skladistar",new {username=ViewBag.Username,v=@Model }))
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\krist\Desktop\ConManApp\Views\Skladistar\AddVozilo.cshtml"
Write(Html.TextBoxFor(m => m.NazivProizvodjaca, new { @placeholder = "Unesite naziv proizvodjaca:" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n");
#nullable restore
#line 12 "C:\Users\krist\Desktop\ConManApp\Views\Skladistar\AddVozilo.cshtml"
Write(Html.TextBoxFor(m => m.Model, new { @placeholder = "Unesite model :" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n");
#nullable restore
#line 13 "C:\Users\krist\Desktop\ConManApp\Views\Skladistar\AddVozilo.cshtml"
Write(Html.TextBoxFor(m => m.GodinaProizvodnje, new { @placeholder = "Unesite godinu proizvodnje:" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\krist\Desktop\ConManApp\Views\Skladistar\AddVozilo.cshtml"
Write(Html.DropDownListFor(m => m.TipVozilaId, ViewBag.Tip as SelectList, "--Tip vozila--"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <a href=\"/Skladistar/AddTipVozilo\">...</a><br />\n    <label>Slika</label><br />\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8c20a69677fb055265c6ce4c345733e6fac54b8c4987", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 17 "C:\Users\krist\Desktop\ConManApp\Views\Skladistar\AddVozilo.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SlikaVozila);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("<br />\n");
            WriteLiteral("    <input type=\"submit\" value=\"Sacuvaj\" /><br />\n");
#nullable restore
#line 20 "C:\Users\krist\Desktop\ConManApp\Views\Skladistar\AddVozilo.cshtml"
                                                                               

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConManApp.EnModels.Vozilo> Html { get; private set; }
    }
}
#pragma warning restore 1591
