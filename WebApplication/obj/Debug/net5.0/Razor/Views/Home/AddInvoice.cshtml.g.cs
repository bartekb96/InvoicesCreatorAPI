#pragma checksum "C:\Users\Bartek\source\repos\InvoicesCreator\WebApplication\Views\Home\AddInvoice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efa1980e345df448bcdb995867bd91d1f4408b75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AddInvoice), @"mvc.1.0.view", @"/Views/Home/AddInvoice.cshtml")]
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
#line 1 "C:\Users\Bartek\source\repos\InvoicesCreator\WebApplication\Views\_ViewImports.cshtml"
using WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bartek\source\repos\InvoicesCreator\WebApplication\Views\_ViewImports.cshtml"
using WebApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efa1980e345df448bcdb995867bd91d1f4408b75", @"/Views/Home/AddInvoice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa0ef8da47a84ffb33e8bc853509aa4fa5703a26", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AddInvoice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddInvoice", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Bartek\source\repos\InvoicesCreator\WebApplication\Views\Home\AddInvoice.cshtml"
  
    ViewData["Title"] = "Add Invoice";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script type=\"text/javascript\">\r\n\r\n    function AddRow() {\r\n\r\n        alert(\'You added the row\');\r\n\r\n    }\r\n\r\n</script>\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12\">\r\n            <br />\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efa1980e345df448bcdb995867bd91d1f4408b755143", async() => {
                WriteLiteral(@"
                <div class=""row"">
                    <div class=""col-md-6"">

                        <label class=""form-label"">Dane osobowe odbiorcy</label>

                        <div class=""form-group"">
                            <label for=""password"">Imię</label>
                            <input class=""form-control"" placeholder=""Imię odbiorcy"" type=""text"" name=""FirstName"" />
                        </div>

                        <div class=""form-group"">
                            <label for=""password"">Nazwisko</label>
                            <input class=""form-control"" placeholder=""Nazwisko odbiorcy"" type=""text"" name=""SecondName"" />
                        </div>

                        <div class=""form-group"">
                            <label for=""password"">Nazwisko</label>
                            <input class=""form-control"" placeholder=""Nazwisko odbiorcy"" type=""text"" name=""SecondName"" />
                        </div>

                        <div class=""form-grou");
                WriteLiteral(@"p"">
                            <label for=""password"">Nazwa Firmy</label>
                            <input class=""form-control"" placeholder=""Nazwa firmy"" type=""text"" name=""CompanyName"" />
                        </div>

                        <div class=""form-group"">
                            <label for=""password"">NIP</label>
                            <input class=""form-control"" placeholder=""Numer identyfikacji podatkowej"" type=""text"" name=""NIPNumber"" />
                        </div>

                        <div class=""form-group"">
                            <label for=""password"">E-mail</label>
                            <input class=""form-control"" placeholder=""Adres e-mail odbiorcy"" type=""text"" name=""Email"" />
                        </div>

                        <div class=""form-group"">
                            <label for=""password"">Telefon</label>
                            <input class=""form-control"" placeholder=""Numer telefonu odborcy"" type=""tel"" name=""PhoneNumber"" />
 ");
                WriteLiteral(@"                       </div>
                    </div>

                    <div class=""col-md-6"">
                        <label class=""form-label"">Dane adresowe odbiorcy</label>

                        <div class=""form-group"">
                            <label for=""password"">Ulica</label>
                            <input class=""form-control"" placeholder=""Nazwa ulicy"" type=""text"" name=""Street"" />
                        </div>

                        <div class=""form-group"">
                            <label for=""password"">Numer domu</label>
                            <input class=""form-control"" placeholder=""Numer domu"" type=""text"" name=""HouseNumber"" />
                        </div>

                        <div class=""form-group"">
                            <label for=""password"">Numer lokalu</label>
                            <input class=""form-control"" placeholder=""Numer lokalu"" type=""text"" name=""LocalNumber"" />
                        </div>

                        <div c");
                WriteLiteral(@"lass=""form-group"">
                            <label for=""password"">Kod pocztowy</label>
                            <input class=""form-control"" placeholder=""Kod pocztowy"" type=""text"" name=""PostCode"" />
                        </div>

                        <div class=""form-group"">
                            <label for=""password"">Miasto</label>
                            <input class=""form-control"" placeholder=""Miasto"" type=""text"" name=""City"" />
                        </div>

                        <div class=""form-group"">
                            <label for=""password"">Kraj</label>
                            <input class=""form-control"" placeholder=""Kraj"" type=""text"" name=""Country"" value=""Polska"" />
                        </div>
                    </div>

                    <div class=""col-md-12"">
                        <label class=""form-label"">Lista pozycji faktury</label>

                        <table class=""table table-bordered table-dark"">
                            <t");
                WriteLiteral(@"head>
                                <tr>
                                    <th scope=""col"" class=""col-md-1"">Lp.</th>
                                    <th scope=""col"" class=""col-md-2"">Nazwa</th>
                                    <th scope=""col"" class=""col-md-1"">Ilość</th>
                                    <th scope=""col"" class=""col-md-2"">Jednostka miary</th>
                                    <th scope=""col"" class=""col-md-2"">Wysokość podatku [%]</th>
                                    <th scope=""col"" class=""col-md-2"">Wartość Brutto [zł]</th>
                                    <th scope=""col"" class=""col-md-2"">Wartość Netto [zł]</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <th scope=""row"">1</th>
                                    <td><input class=""form-control"" placeholder=""Nazwa"" type=""text"" name=""ProductName"" /></td>
                      ");
                WriteLiteral(@"              <td><input class=""form-control"" placeholder=""Ilość"" type=""text"" name=""Amount"" /></td>
                                    <td>
                                        <select class=""form-control"">
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efa1980e345df448bcdb995867bd91d1f4408b7511178", async() => {
                    WriteLiteral("Doba hotelowa");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efa1980e345df448bcdb995867bd91d1f4408b7512244", async() => {
                    WriteLiteral("Szt");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efa1980e345df448bcdb995867bd91d1f4408b7513300", async() => {
                    WriteLiteral("Kg");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        </select>
                                    </td>
                                    <td><input class=""form-control"" placeholder=""Wysokość podatki"" type=""text"" name=""TaxRate"" /></td>
                                    <td><input class=""form-control"" placeholder=""Wartość Brutto"" type=""text"" name=""BruttoPrice"" /></td>
                                    <td><input class=""form-control"" placeholder=""Wartość Netto"" type=""text"" name=""NettoPrice"" /></td>
                                </tr>
                            </tbody>
                        </table>

                        <button class=""btn-dark"" onclick=""AddRow()"">Dodaj pozycję</button>
                    </div>


                    <div class=""col-md-12"">
                        <button type=""submit"" class=""btn-danger"">Utwórz fakturę</button>
                    </div>

                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
