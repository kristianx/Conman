#pragma checksum "C:\Users\krist\Desktop\Keebree\Views\Radnik\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44c025af4efd0dd9e11ba21b067903614e5e95df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Radnik_Index), @"mvc.1.0.view", @"/Views/Radnik/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44c025af4efd0dd9e11ba21b067903614e5e95df", @"/Views/Radnik/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b61a6947239c377993bfc1166ee1ff5a575f8c6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Radnik_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConManApp.Models.RadnikIndexVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-none d-sm-inline-block form-inline mr-auto ml-md-3 my-2 my-md-0 mw-100 navbar-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline mr-auto w-100 navbar-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\krist\Desktop\Keebree\Views\Radnik\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44c025af4efd0dd9e11ba21b067903614e5e95df4289", async() => {
                WriteLiteral(@"
    <!--
    <nav class=""navbar navbar-expand navbar-light bg-white topbar mb-4 static-top shadow"">
        <!-- Sidebar Toggle (Topbar)
    <button id=""sidebarToggleTop"" class=""btn btn-link d-md-none rounded-circle mr-3"">
        <i class=""fa fa-bars""></i>
    </button>


    <a style=""margin-right:0px;width:auto;margin-left:90%"" href=""/Poslovodja/Logout"" class=""btn btn-danger"">Log out, ");
#nullable restore
#line 15 "C:\Users\krist\Desktop\Keebree\Views\Radnik\Index.cshtml"
                                                                                                                Write(Model.Username);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</a>

    </nav>
    <a style=""margin-right:0px;width:auto;margin-left:90%"" href=""/Radnik/ViewMyProfile"" class=""btn btn-primary btn-group"">Moj profil</a>
    -->

    <nav class=""navbar navbar-expand navbar-light bg-white topbar mb-4 static-top shadow"">

        <!-- Sidebar Toggle (Topbar) -->
        <button id=""sidebarToggleTop"" class=""btn btn-link d-md-none rounded-circle mr-3"">
            <i class=""fa fa-bars""></i>
        </button>

        <!-- Topbar Search -->
        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44c025af4efd0dd9e11ba21b067903614e5e95df5757", async() => {
                    WriteLiteral(@"
            <div class=""input-group"">
                <input type=""text"" class=""form-control bg-light border-0 small"" placeholder=""Search for..."" aria-label=""Search"" aria-describedby=""basic-addon2"">
                <div class=""input-group-append"">
                    <button class=""btn btn-primary"" type=""button"">
                        <i class=""fas fa-search fa-sm""></i>
                    </button>
                </div>
            </div>
        ");
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
                WriteLiteral(@"

        <!-- Topbar Navbar -->
        <ul class=""navbar-nav ml-auto"">

            <!-- Nav Item - Search Dropdown (Visible Only XS) -->
            <li class=""nav-item dropdown no-arrow d-sm-none"">
                <a class=""nav-link dropdown-toggle"" href=""#"" id=""searchDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                    <i class=""fas fa-search fa-fw""></i>
                </a>
                <!-- Dropdown - Messages -->
                <div class=""dropdown-menu dropdown-menu-right p-3 shadow animated--grow-in"" aria-labelledby=""searchDropdown"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44c025af4efd0dd9e11ba21b067903614e5e95df8265", async() => {
                    WriteLiteral(@"
                        <div class=""input-group"">
                            <input type=""text"" class=""form-control bg-light border-0 small"" placeholder=""Search for..."" aria-label=""Search"" aria-describedby=""basic-addon2"">
                            <div class=""input-group-append"">
                                <button class=""btn btn-primary"" type=""button"">
                                    <i class=""fas fa-search fa-sm""></i>
                                </button>
                            </div>
                        </div>
                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </div>
            </li>

            <!-- Nav Item - Alerts -->
            <li class=""nav-item dropdown no-arrow mx-1"">
                <a class=""nav-link dropdown-toggle"" href=""#"" id=""alertsDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                    <i class=""fas fa-bell fa-fw""></i>
                    <!-- Counter - Alerts -->
                    <span class=""badge badge-danger badge-counter"">3+</span>
                </a>
                <!-- Dropdown - Alerts -->
                <div class=""dropdown-list dropdown-menu dropdown-menu-right shadow animated--grow-in"" aria-labelledby=""alertsDropdown"">
                    <h6 class=""dropdown-header"">
                        Alerts Center
                    </h6>
                    <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                        <div class=""mr-3"">
                            <div class=""icon-circle bg-primary"">
                                <i class=""fa");
                WriteLiteral(@"s fa-file-alt text-white""></i>
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
                            <div class=""small text-gray-500"">December 7, 2019</div>
                            $290.29 has been deposited into your account!
                        </div>
                    </a>
                    <a class=""dropdown-item d-flex align-items-center"" href");
                WriteLiteral(@"=""#"">
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
                <a class=""nav-link dropdown-toggle"" href=""#"" id=""messagesDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                    <i class=""fas fa-envelope fa-fw""></i>
                   ");
                WriteLiteral(@" <!-- Counter - Messages -->
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
                BeginWriteAttribute("alt", " alt=\"", 6540, "\"", 6546, 0);
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
                BeginWriteAttribute("alt", " alt=\"", 7242, "\"", 7248, 0);
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
                BeginWriteAttribute("alt", " alt=\"", 7910, "\"", 7916, 0);
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
                BeginWriteAttribute("alt", " alt=\"", 8609, "\"", 8615, 0);
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
                    <span class=""mr-2 d-none d-lg-inline text-gray-600 small"" s");
                WriteLiteral("tyle=\"text-transform: capitalize;\">");
#nullable restore
#line 173 "C:\Users\krist\Desktop\Keebree\Views\Radnik\Index.cshtml"
                                                                                                             Write(Model.Username);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                    <img class=""img-profile rounded-circle"" src=""https://source.unsplash.com/QAB-WJcbgJk/60x60"">
                </a>
                <!-- Dropdown - User Information -->
                <div class=""dropdown-menu dropdown-menu-right shadow animated--grow-in"" aria-labelledby=""userDropdown"">
                    <a class=""dropdown-item"" href=""/Radnik/ViewMyProfile"">
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
                    <a class=""dropdown-it");
                WriteLiteral(@"em"" href=""/Radnik/Logout"">
                        <i class=""fas fa-sign-out-alt fa-sm fa-fw mr-2 text-gray-400""></i>
                        Logout
                    </a>
                </div>
            </li>

        </ul>

    </nav>

    <div class=""container-fluid"">
        <div class=""card shadow mb-4"">
            <div class=""card-header py-3"">
                <h6 class=""m-0 font-weight-bold text-primary"">Aktivna zaduzenja opreme</h6>
            </div>
            <div class=""card-body"">
                <div class=""table-responsive"">
                    <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                        <thead>
                            <tr>
                                <th>Naziv opreme</th>
                                <th>Svrha iznajmljivanja</th>
                                <th>Naziv skladista </th>
                                <th>Od</th>
                                <th>Do </th>
                                <th>Akcija");
                WriteLiteral("</th>\n                            </tr>\n                        </thead>\n\n                        <tbody>\n");
#nullable restore
#line 222 "C:\Users\krist\Desktop\Keebree\Views\Radnik\Index.cshtml"
                             foreach (var x in Model.OpremaIznajmljena)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\n                    <td>");
#nullable restore
#line 225 "C:\Users\krist\Desktop\Keebree\Views\Radnik\Index.cshtml"
                   Write(x.OpremaNaziv);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                    <th>");
#nullable restore
#line 226 "C:\Users\krist\Desktop\Keebree\Views\Radnik\Index.cshtml"
                   Write(x.SvrhaIznajmljivanja);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\n                    <th>");
#nullable restore
#line 227 "C:\Users\krist\Desktop\Keebree\Views\Radnik\Index.cshtml"
                   Write(x.NazivSkladista);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\n                    <th>");
#nullable restore
#line 228 "C:\Users\krist\Desktop\Keebree\Views\Radnik\Index.cshtml"
                   Write(x.DatumIznajmljivanja);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\n                    <th>");
#nullable restore
#line 229 "C:\Users\krist\Desktop\Keebree\Views\Radnik\Index.cshtml"
                   Write(x.DatumKrajaIznajmljivanja);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </th>\n                    <th><a");
                BeginWriteAttribute("href", " href=\"", 12246, "\"", 12305, 2);
                WriteAttributeValue("", 12253, "/Radnik/VratiOpremu?radnikopremaid=", 12253, 35, true);
#nullable restore
#line 230 "C:\Users\krist\Desktop\Keebree\Views\Radnik\Index.cshtml"
WriteAttributeValue("", 12288, x.RadnikOpremaID, 12288, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Vrati</a></th>\n                </tr>\n");
#nullable restore
#line 232 "C:\Users\krist\Desktop\Keebree\Views\Radnik\Index.cshtml"
}

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </tbody>

                    </table>
                    <a href=""/Radnik/PregledRaspoloziveOpreme"" class=""btn btn-primary"">Pregled raspolozive opreme</a>
                </div>
            </div>
        </div>
    </div>


    <div class=""container-fluid"">
        <div class=""card shadow mb-4"">
            <div class=""card-header py-3"">
                <h6 class=""m-0 font-weight-bold text-primary"">Aktivna zaduzenja vozila</h6>
            </div>
            <div class=""card-body"">
                <div class=""table-responsive"">
                    <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                        <thead>
                            <tr>
                                <th>Naziv vozila</th>
                                <th>Godina proizvodnje</th>
                                <th>Svrha iznajmljivanja</th>
                                <th>Naziv skladista </th>
                                <th>Od</th>
                  ");
                WriteLiteral("              <th>Do </th>\n                                <th>Akcija</th>\n                            </tr>\n                        </thead>\n\n                        <tbody>\n");
#nullable restore
#line 265 "C:\Users\krist\Desktop\Keebree\Views\Radnik\Index.cshtml"
                             foreach (var x in Model.VozilaIznajmljena)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 268 "C:\Users\krist\Desktop\Keebree\Views\Radnik\Index.cshtml"
                           Write(x.NazivVozila);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 269 "C:\Users\krist\Desktop\Keebree\Views\Radnik\Index.cshtml"
                           Write(x.GodinaProizvodnje);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                            <th>");
#nullable restore
#line 270 "C:\Users\krist\Desktop\Keebree\Views\Radnik\Index.cshtml"
                           Write(x.SvrhaIznajmljivanja);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\n                            <th>");
#nullable restore
#line 271 "C:\Users\krist\Desktop\Keebree\Views\Radnik\Index.cshtml"
                           Write(x.NazivSkladista);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\n                            <th>");
#nullable restore
#line 272 "C:\Users\krist\Desktop\Keebree\Views\Radnik\Index.cshtml"
                           Write(x.DatumIznajmljivanja);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\n                            <th>");
#nullable restore
#line 273 "C:\Users\krist\Desktop\Keebree\Views\Radnik\Index.cshtml"
                           Write(x.DatumKrajaIznajmljivanja);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </th>\n                            <th><a");
                BeginWriteAttribute("href", " href=\"", 14061, "\"", 14116, 2);
                WriteAttributeValue("", 14068, "/Radnik/VratiVozilo?narudzbaid=", 14068, 31, true);
#nullable restore
#line 274 "C:\Users\krist\Desktop\Keebree\Views\Radnik\Index.cshtml"
WriteAttributeValue("", 14099, x.RadnikVoziloID, 14099, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Vrati</a></th>\n                        </tr>");
#nullable restore
#line 275 "C:\Users\krist\Desktop\Keebree\Views\Radnik\Index.cshtml"
                             }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </tbody>

                    </table>
                    <a href=""/Radnik/PregledRaspolozivihVozila"" class=""btn btn-primary"">Pregled raspolozivih vozila</a>
                </div>
            </div>
        </div>
    </div>


    <!-------------------------------------------------------------------------------------

            <label>Aktivna zaduzenja opreme:</label>
            <table class=""table table-bordered"">
                <tr>
                    <th>Naziv opreme</th>
                    <th>Svrha iznajmljivanja</th>
                    <th>Naziv skladista </th>
                    <th>Od</th>
                    <th>Do </th>
                    <th>Akcija</th>
                </tr>
");
#nullable restore
#line 299 "C:\Users\krist\Desktop\Keebree\Views\Radnik\Index.cshtml"
                 foreach (var x in Model.OpremaIznajmljena)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("    <tr>\n        <td>");
#nullable restore
#line 302 "C:\Users\krist\Desktop\Keebree\Views\Radnik\Index.cshtml"
       Write(x.OpremaNaziv);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n        <th>");
#nullable restore
#line 303 "C:\Users\krist\Desktop\Keebree\Views\Radnik\Index.cshtml"
       Write(x.SvrhaIznajmljivanja);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\n        <th>");
#nullable restore
#line 304 "C:\Users\krist\Desktop\Keebree\Views\Radnik\Index.cshtml"
       Write(x.NazivSkladista);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\n        <th>");
#nullable restore
#line 305 "C:\Users\krist\Desktop\Keebree\Views\Radnik\Index.cshtml"
       Write(x.DatumIznajmljivanja);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\n        <th>");
#nullable restore
#line 306 "C:\Users\krist\Desktop\Keebree\Views\Radnik\Index.cshtml"
       Write(x.DatumKrajaIznajmljivanja);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </th>\n        <th><a");
                BeginWriteAttribute("href", " href=\"", 15189, "\"", 15248, 2);
                WriteAttributeValue("", 15196, "/Radnik/VratiOpremu?radnikopremaid=", 15196, 35, true);
#nullable restore
#line 307 "C:\Users\krist\Desktop\Keebree\Views\Radnik\Index.cshtml"
WriteAttributeValue("", 15231, x.RadnikOpremaID, 15231, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Vrati</a></th>\n    </tr>\n");
#nullable restore
#line 309 "C:\Users\krist\Desktop\Keebree\Views\Radnik\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            </table>
            <a class=""btn btn-primary btn-block"" href=""/Radnik/PregledRaspoloziveOpreme"">Pregled raspolozive opreme</a>
            <br />







            <label>Aktivna zaduzenja vozila:</label>
            <table class=""table table-bordered"">
                <tr>
                    <th>Naziv vozila</th>
                    <th>Godina proizvodnje</th>
                    <th>Svrha iznajmljivanja</th>
                    <th>Naziv skladista </th>
                    <th>Od</th>
                    <th>Do </th>
                    <th>Akcija</th>
                </tr>
");
#nullable restore
#line 331 "C:\Users\krist\Desktop\Keebree\Views\Radnik\Index.cshtml"
                 foreach (var x in Model.VozilaIznajmljena)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("    <tr>\n        <td>");
#nullable restore
#line 334 "C:\Users\krist\Desktop\Keebree\Views\Radnik\Index.cshtml"
       Write(x.NazivVozila);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n        <td>");
#nullable restore
#line 335 "C:\Users\krist\Desktop\Keebree\Views\Radnik\Index.cshtml"
       Write(x.GodinaProizvodnje);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n        <th>");
#nullable restore
#line 336 "C:\Users\krist\Desktop\Keebree\Views\Radnik\Index.cshtml"
       Write(x.SvrhaIznajmljivanja);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\n        <th>");
#nullable restore
#line 337 "C:\Users\krist\Desktop\Keebree\Views\Radnik\Index.cshtml"
       Write(x.NazivSkladista);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\n        <th>");
#nullable restore
#line 338 "C:\Users\krist\Desktop\Keebree\Views\Radnik\Index.cshtml"
       Write(x.DatumIznajmljivanja);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\n        <th>");
#nullable restore
#line 339 "C:\Users\krist\Desktop\Keebree\Views\Radnik\Index.cshtml"
       Write(x.DatumKrajaIznajmljivanja);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </th>\n        <th><a");
                BeginWriteAttribute("href", " href=\"", 16212, "\"", 16267, 2);
                WriteAttributeValue("", 16219, "/Radnik/VratiVozilo?narudzbaid=", 16219, 31, true);
#nullable restore
#line 340 "C:\Users\krist\Desktop\Keebree\Views\Radnik\Index.cshtml"
WriteAttributeValue("", 16250, x.RadnikVoziloID, 16250, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Vrati</a></th>\n    </tr>\n");
#nullable restore
#line 342 "C:\Users\krist\Desktop\Keebree\Views\Radnik\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </table>\n            <a class=\"btn btn-primary btn-block\" href=\"/Radnik/PregledRaspolozivihVozila\">Pregled raspolozivih vozila</a>\n            <br />\n            <br />\n            <br />\n\n\n\n                -->\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConManApp.Models.RadnikIndexVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
