#pragma checksum "C:\Users\krist\Desktop\Keebree\Views\Skladistar\ViewMyProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72d0ca6e2fec0aabba609919d4b39d19c0c49a58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Skladistar_ViewMyProfile), @"mvc.1.0.view", @"/Views/Skladistar/ViewMyProfile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72d0ca6e2fec0aabba609919d4b39d19c0c49a58", @"/Views/Skladistar/ViewMyProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b61a6947239c377993bfc1166ee1ff5a575f8c6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Skladistar_ViewMyProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConManApp.EnModels.Skladistar>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-signin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\krist\Desktop\Keebree\Views\Skladistar\ViewMyProfile.cshtml"
   ViewData["Title"] = "ViewMyProfile"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<nav class=""navbar navbar-expand navbar-light bg-white topbar mb-4 static-top shadow"">

    <!-- Sidebar Toggle (Topbar) -->
    <button id=""sidebarToggleTop"" class=""btn btn-link d-md-none rounded-circle mr-3"">
        <i class=""fa fa-bars""></i>
    </button>

    <a class=""fa fa-arrow-left back-arrow"" aria-hidden=""true"" href=""/Skladistar/Index""></a>

    <!-- Topbar Navbar -->
    <ul class=""navbar-nav ml-auto"">



        <!-- Nav Item - Alerts -->
        <li class=""nav-item dropdown no-arrow mx-1"">
            <a class=""nav-link dropdown-toggle"" href=""#"" id=""alertsDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                <i class=""fas fa-bell fa-fw""></i>
                <!-- Counter - Alerts -->
                <span class=""badge badge-danger badge-counter"">3+</span>
            </a>
            <!-- Dropdown - Alerts -->
            <div class=""dropdown-list dropdown-menu dropdown-menu-right shadow animated--grow-in"" aria-labelledby=""alertsDropdown"">
   ");
            WriteLiteral(@"             <h6 class=""dropdown-header"">
                    Alerts Center
                </h6>
                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                    <div class=""mr-3"">
                        <div class=""icon-circle bg-primary"">
                            <i class=""fas fa-file-alt text-white""></i>
                        </div>
                    </div>
                    <div>
                        <div class=""small text-gray-500"">December 12, 2019</div>
                        <span class=""font-weight-bold"">A new monthly report is ready to download!</span>
                    </div>
                </a>
                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                    <div class=""mr-3"">
                        <div class=""icon-circle bg-success"">
                            <i class=""fas fa-donate text-white""></i>
                        </div>
                    </div>
                    <div>
                        <div c");
            WriteLiteral(@"lass=""small text-gray-500"">December 7, 2019</div>
                        $290.29 has been deposited into your account!
                    </div>
                </a>
                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                    <div class=""mr-3"">
                        <div class=""icon-circle bg-warning"">
                            <i class=""fas fa-exclamation-triangle text-white""></i>
                        </div>
                    </div>
                    <div>
                        <div class=""small text-gray-500"">December 2, 2019</div>
                        Spending Alert: We've noticed unusually high spending for your account.
                    </div>
                </a>
                <a class=""dropdown-item text-center small text-gray-500"" href=""#"">Show All Alerts</a>
            </div>
        </li>

        <!-- Nav Item - Messages -->
        <li class=""nav-item dropdown no-arrow mx-1"">
            <a class=""nav-link dropdown-toggle"" href=""#"" id=""m");
            WriteLiteral(@"essagesDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                <i class=""fas fa-envelope fa-fw""></i>
                <!-- Counter - Messages -->
                <span class=""badge badge-danger badge-counter"">7</span>
            </a>
            <!-- Dropdown - Messages -->
            <div class=""dropdown-list dropdown-menu dropdown-menu-right shadow animated--grow-in"" aria-labelledby=""messagesDropdown"">
                <h6 class=""dropdown-header"">
                    Message Center
                </h6>
                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                    <div class=""dropdown-list-image mr-3"">
                        <img class=""rounded-circle"" src=""https://source.unsplash.com/fn_BT9fwg_E/60x60""");
            BeginWriteAttribute("alt", " alt=\"", 4970, "\"", 4976, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""status-indicator bg-success""></div>
                    </div>
                    <div class=""font-weight-bold"">
                        <div class=""text-truncate"">Hi there! I am wondering if you can help me with a problem I've been having.</div>
                        <div class=""small text-gray-500"">Emily Fowler · 58m</div>
                    </div>
                </a>
                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                    <div class=""dropdown-list-image mr-3"">
                        <img class=""rounded-circle"" src=""https://source.unsplash.com/AU4VPcFN4LE/60x60""");
            BeginWriteAttribute("alt", " alt=\"", 5632, "\"", 5638, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""status-indicator""></div>
                    </div>
                    <div>
                        <div class=""text-truncate"">I have the photos that you ordered last month, how would you like them sent to you?</div>
                        <div class=""small text-gray-500"">Jae Chun · 1d</div>
                    </div>
                </a>
                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                    <div class=""dropdown-list-image mr-3"">
                        <img class=""rounded-circle"" src=""https://source.unsplash.com/CS2uCrpNzJY/60x60""");
            BeginWriteAttribute("alt", " alt=\"", 6260, "\"", 6266, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""status-indicator bg-warning""></div>
                    </div>
                    <div>
                        <div class=""text-truncate"">Last month's report looks great, I am very happy with the progress so far, keep up the good work!</div>
                        <div class=""small text-gray-500"">Morgan Alvarez · 2d</div>
                    </div>
                </a>
                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                    <div class=""dropdown-list-image mr-3"">
                        <img class=""rounded-circle"" src=""https://source.unsplash.com/Mv9hjnEUHR4/60x60""");
            BeginWriteAttribute("alt", " alt=\"", 6919, "\"", 6925, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""status-indicator bg-success""></div>
                    </div>
                    <div>
                        <div class=""text-truncate"">Am I a good boy? The reason I ask is because someone told me that people say this to all dogs, even if they aren't good...</div>
                        <div class=""small text-gray-500"">Chicken the Dog · 2w</div>
                    </div>
                </a>
                <a class=""dropdown-item text-center small text-gray-500"" href=""#"">Read More Messages</a>
            </div>
        </li>

        <div class=""topbar-divider d-none d-sm-block""></div>

        <!-- Nav Item - User Information -->
        <li class=""nav-item dropdown no-arrow"">
            <a class=""nav-link dropdown-toggle"" href=""#"" id=""userDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                <span class=""mr-2 d-none d-lg-inline text-gray-600 small"">");
#nullable restore
#line 165 "C:\Users\krist\Desktop\Keebree\Views\Skladistar\ViewMyProfile.cshtml"
                                                                     Write(Model.Ime);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                <img class=""img-profile rounded-circle"" src=""https://source.unsplash.com/QAB-WJcbgJk/60x60"">
            </a>
            <!-- Dropdown - User Information -->
            <div class=""dropdown-menu dropdown-menu-right shadow animated--grow-in"" aria-labelledby=""userDropdown"">
                <a class=""dropdown-item"" href=""/Poslovodja/ViewMyProfile"">
                    <i class=""fas fa-user fa-sm fa-fw mr-2 text-gray-400""></i>
                    Profile
                </a>
                <a class=""dropdown-item"" href=""#"">
                    <i class=""fas fa-cogs fa-sm fa-fw mr-2 text-gray-400""></i>
                    Settings
                </a>
                <a class=""dropdown-item"" href=""#"">
                    <i class=""fas fa-list fa-sm fa-fw mr-2 text-gray-400""></i>
                    Activity Log
                </a>
                <div class=""dropdown-divider""></div>
                <a class=""dropdown-item"" href=""/Poslovodja/Logout"" data-toggle=""modal"" data-target=""#logo");
            WriteLiteral(@"utModal"">
                    <i class=""fas fa-sign-out-alt fa-sm fa-fw mr-2 text-gray-400""></i>
                    Logout
                </a>
            </div>
        </li>

    </ul>

</nav>
<!-- End of Topbar

    <a class=""fa fa-arrow-left"" aria-hidden=""true"" href=""/Poslovodja/Index1""></a>
<br />

-->



<div class=""container"">
    <div class=""card shadow mb-4"">
        <div class=""card-header py-3"">
            <h6 class=""m-0 font-weight-bold text-primary"">Korisnički podaci</h6>
        </div>
        <div class=""card-body"">
            <div class=""table-responsive"">
");
#nullable restore
#line 209 "C:\Users\krist\Desktop\Keebree\Views\Skladistar\ViewMyProfile.cshtml"
                 if (Model != null)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-bordered\">\n\n        <tr>\n            <th>\n                Ime:\n            </th>\n            <td>\n                ");
#nullable restore
#line 219 "C:\Users\krist\Desktop\Keebree\Views\Skladistar\ViewMyProfile.cshtml"
           Write(Model.Ime);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n        </tr>\n        <tr>\n            <th>\n                Prezime:\n            </th>\n            <td>\n                ");
#nullable restore
#line 227 "C:\Users\krist\Desktop\Keebree\Views\Skladistar\ViewMyProfile.cshtml"
           Write(Model.Prezime);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n        </tr>\n        <tr>\n            <th>\n                Korisnicko ime:\n            </th>\n            <td>\n                ");
#nullable restore
#line 235 "C:\Users\krist\Desktop\Keebree\Views\Skladistar\ViewMyProfile.cshtml"
           Write(Model.username);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n        </tr>\n        <tr>\n            <th>\n                Password:\n            </th>\n            <td>\n                ");
#nullable restore
#line 243 "C:\Users\krist\Desktop\Keebree\Views\Skladistar\ViewMyProfile.cshtml"
           Write(Model.password);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n        </tr>\n        <tr>\n            <th>\n                Kontakt broj:\n            </th>\n            <td>\n                ");
#nullable restore
#line 251 "C:\Users\krist\Desktop\Keebree\Views\Skladistar\ViewMyProfile.cshtml"
           Write(Model.KontaktBroj);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n        </tr>\n        <tr>\n            <th>\n                Adresa Skladista:\n            </th>\n            <td>\n                ");
#nullable restore
#line 259 "C:\Users\krist\Desktop\Keebree\Views\Skladistar\ViewMyProfile.cshtml"
           Write(ViewBag.AdresaSkladista);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n        </tr>\n    </table> ");
#nullable restore
#line 262 "C:\Users\krist\Desktop\Keebree\Views\Skladistar\ViewMyProfile.cshtml"
             }
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<h5>There is nothing to show here...</h5>");
#nullable restore
#line 265 "C:\Users\krist\Desktop\Keebree\Views\Skladistar\ViewMyProfile.cshtml"
                                         }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n\n    <div class=\"card shadow mb-4\">\n        <div class=\"card-header py-3\">\n            <h6 class=\"m-0 font-weight-bold text-primary\">2FA Autentifikacija</h6>\n            <div class=\"float-right fa-switch\">\n");
#nullable restore
#line 275 "C:\Users\krist\Desktop\Keebree\Views\Skladistar\ViewMyProfile.cshtml"
                 if (Model.TwoFaAuth)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a href=\"#\" class=\"btn btn-danger fa-button\" data-toggle=\"modal\" data-target=\"#iskljucimodal\">Iskljuci</a> ");
#nullable restore
#line 277 "C:\Users\krist\Desktop\Keebree\Views\Skladistar\ViewMyProfile.cshtml"
                                                                                                                               }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a href=\"#\" class=\"btn btn-primary fa-button\" data-toggle=\"modal\" data-target=\"#qrcodemodal\">Ukljuci</a>\n");
#nullable restore
#line 281 "C:\Users\krist\Desktop\Keebree\Views\Skladistar\ViewMyProfile.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n        <!--\n        <div class=\"card-body\">\n");
#nullable restore
#line 287 "C:\Users\krist\Desktop\Keebree\Views\Skladistar\ViewMyProfile.cshtml"
             if (@Model.TwoFaAuth == true)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\n\n                <div class=\"col-md-6 text-center\">\n                    <h6 class=\"2fa-h6\">Skenirajte QR Kod</h6>\n                    <img class=\"barode\"");
            BeginWriteAttribute("src", " src=\"", 11555, "\"", 11585, 1);
#nullable restore
#line 293 "C:\Users\krist\Desktop\Keebree\Views\Skladistar\ViewMyProfile.cshtml"
WriteAttributeValue("", 11561, ViewBag.BarcodeImageUrl, 11561, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n                </div>\n                <div class=\"col-md-6 text-center\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72d0ca6e2fec0aabba609919d4b39d19c0c49a5818644", async() => {
                WriteLiteral(@"
                        <div class=""form-label-group"">
                            <input type=""text"" id=""2fakod"" name=""2fakod"" class=""form-control"" placeholder=""2FA Verifikacijski kod"" required autofocus>
                            <label for=""2fakod"">2FA Verifikacijski kod</label>
                        </div>
                        <input class=""btn btn-lg login-button btn-block text-uppercase"" value=""Verificiraj"" type=""button""");
                BeginWriteAttribute("onclick", " onclick=\"", 12148, "\"", 12158, 0);
                EndWriteAttribute();
                WriteLiteral(">\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n            </div>\n");
#nullable restore
#line 305 "C:\Users\krist\Desktop\Keebree\Views\Skladistar\ViewMyProfile.cshtml"

                 }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                 <p class=\"col-sm-12\">2FA Verifikacija Iskljucena</p>\n");
#nullable restore
#line 310 "C:\Users\krist\Desktop\Keebree\Views\Skladistar\ViewMyProfile.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>

        -->


    </div>

    <!-- QR Code Modal -->
    <div class=""modal fade"" id=""qrcodemodal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""qrcodemodal"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">2FA Verifikacija</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <div class=""text-center"">
                        <h5 class=""fa-h6"">1. Skenirajte QR Kod</h5>
                        <img class=""barode""");
            BeginWriteAttribute("src", " src=\"", 13193, "\"", 13223, 1);
#nullable restore
#line 331 "C:\Users\krist\Desktop\Keebree\Views\Skladistar\ViewMyProfile.cshtml"
WriteAttributeValue("", 13199, ViewBag.BarcodeImageUrl, 13199, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                        <h5 class=""fa-h5"">2. Unesite 2FA Kod</h5>
                        <input type=""text"" id=""2fakod"" name=""2fakod"" class=""form-control"" placeholder=""2FA Verifikacijski kod"" required autofocus>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    <button type=""button"" class=""btn btn-primary"" onclick=""TwoFaGo()"">Aktivacija</button>
                </div>
            </div>
        </div>
    </div>

    <!-- QR Code Modal -->
    <div class=""modal fade"" id=""iskljucimodal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""iskljucimodal"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Iskljucivanje 2FA Verifikacije</h5>
                    <button type=""button"" cl");
            WriteLiteral(@"ass=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <div class=""text-center"">
                        <h5 class=""fa-h5"">Unesite 2FA Kod</h5>
                        <input type=""text"" id=""2fakodisklj"" name=""2fakod"" class=""form-control"" placeholder=""2FA Verifikacijski kod"" required autofocus>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    <button type=""button"" class=""btn btn-danger"" onclick=""TwoFaIskljuci()"">Iskljuci</button>
                </div>
            </div>
        </div>
    </div>

</div>

<script>
    var TwoFaGo = function () {
        $.ajax(
            {
                type: ""POST"",
                url: ""/Skladistar/TwoFaVerifikacija"",
              ");
            WriteLiteral("  data: {\n                    twofakod: $(\'#2fakod\').val(),\n                    username: \"");
#nullable restore
#line 378 "C:\Users\krist\Desktop\Keebree\Views\Skladistar\ViewMyProfile.cshtml"
                          Write(Model.username);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                },
                //data: data,

                error: function (result) {
                    alert(""Dogodila se greska.Molimo pokusajte ponovno!"");
                },

                success: function (result) {
                    if (result.status == true) {
                        alert(""2FA Verifikacija aktivirana!"");
                        window.location.href = ""/Skladistar/ViewMyProfile"";
                    } else {
                        alert(""Unijeli ste pogresni kod. Molimo pokusajte ponovno!"");
                    }


                }

            });
    }
     var TwoFaIskljuci = function () {
        $.ajax(
            {
                type: ""POST"",
                url: ""/Skladistar/TwoFaVerifikacija"",
                data: {
                    twofakod: $('#2fakodisklj').val(),
                    username: """);
#nullable restore
#line 406 "C:\Users\krist\Desktop\Keebree\Views\Skladistar\ViewMyProfile.cshtml"
                          Write(Model.username);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                    iskljucivanje: true,
                },
                //data: data,

                error: function (result) {
                    alert(""Dogodila se greska.Molimo pokusajte ponovno!"");
                },

                success: function (result) {
                    if (result.status == true) {
                        alert(""2FA Verifikacija iskljucena!"");
                        window.location.href = ""/Skladistar/ViewMyProfile"";
                    } else {
                        alert(""Unijeli ste pogresni kod. Molimo pokusajte ponovno!"");
                    }


                }

            });
    }
</script>

<style>
    img.barode{
        max-width:300px;
    }

    .fa-switch {
        position: absolute;
        right: 10px;
        top: 6.5px;
    }
    .fa-h6{
        margin:5px auto 0px;
    }
    .fa-h5{
        margin-bottom: 25px;
    }
    .modal-backdrop {
        z-index: 4;
    }
  
</style>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConManApp.EnModels.Skladistar> Html { get; private set; }
    }
}
#pragma warning restore 1591
