#pragma checksum "C:\Users\Studente\Desktop\C_Exercise\C#\MyBank\Program\Pages\Bonifico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3a4e715c7b368c7fa9ed84b93fdcfc820db1ef6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyBank.Pages.Pages_Bonifico), @"mvc.1.0.razor-page", @"/Pages/Bonifico.cshtml")]
namespace MyBank.Pages
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
#line 1 "C:\Users\Studente\Desktop\C_Exercise\C#\MyBank\Program\Pages\_ViewImports.cshtml"
using MyBank;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3a4e715c7b368c7fa9ed84b93fdcfc820db1ef6", @"/Pages/Bonifico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ff3d72701c3dd563708cbecb3740d9e8e2a8f33", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Bonifico : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/logo.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Studente\Desktop\C_Exercise\C#\MyBank\Program\Pages\Bonifico.cshtml"
  
    ViewData["Title"] = "Bonifico";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!--Intestazione-->\r\n<div class=\"container\" id=\"intestazione\">\r\n    <div class=\"row justify-content-center\">\r\n\r\n        <!--Colonna sinistra-->\r\n        <div class=\"col-3\">\r\n            <h1>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a3a4e715c7b368c7fa9ed84b93fdcfc820db1ef64333", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</h1><br>
        </div>

        <!--Colonna centrale-->
        <div class=""col-6"">
            <h1>Bonifico</h1>
            <nav class=""navbar navbar-expand-lg navbar-light bg-light"" id=""NavbarMain"">
                <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
                    <ul class=""navbar-nav mr-auto"">
                        <li class=""nav-item active"">
                            <a class=""nav-link"" href=""/LoginPage"">MyHome<span class=""sr-only"">(current)</span></a>
                        </li>
                        <li class=""nav-item dropdown"">
                            <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                MyConto
                            </a>
                            <div class=""dropdown-menu"" aria-labelledby=""navbarDropdown"">
                                <a class=""dropdown-item"" href=""/Movimenti"">Movi");
            WriteLiteral(@"menti</a>
                                <a class=""dropdown-item"" href=""/Bilancio"">Bilancio</a>
                                <a class=""dropdown-item"" href=""/IBAN"">IBAN</a>
                            </div>
                        </li>
                        <li class=""nav-item dropdown"">
                            <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                MyPagamenti
                            </a>
                            <div class=""dropdown-menu"" aria-labelledby=""navbarDropdown"">
                                <a class=""dropdown-item"" href=""/Bollettino"">Bollettino</a>
                                <a class=""dropdown-item"" href=""/Bonifico"">Bonifico</a>
                                <a class=""dropdown-item"" href=""/Ricarica"">Ricarica</a>
                            </div>
                        </li>
                        <li class=""nav-item");
            WriteLiteral(@" dropdown"">
                            <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                MyProfilo
                            </a>
                            <div class=""dropdown-menu"" aria-labelledby=""navbarDropdown"">
                                <a class=""dropdown-item"" href=""/Carta"">Carta</a>
                                <a class=""dropdown-item"" href=""/Documenti"">Documenti</a>
                                <a class=""dropdown-item"" href=""/Contattaci"">Contattaci</a>
                            </div>
                        </li>
                    </ul>
                </div>
            </nav>
        </div>

        <!--Colonna destra-->
        <div class=""col-3"">

        </div>

    </div>
</div>

<!--Centrale-->
<div class=""container"" id=""centrale"">
    <div class=""row justify-content-center"">

        <!--Colonna sinistra-->
        <d");
            WriteLiteral("iv class=\"col-3\">\r\n\r\n        </div>\r\n\r\n        <!--Colonna centrale-->\r\n        <div class=\"col-6\">\r\n\r\n        </div>\r\n\r\n        <!--Colonna destra-->\r\n        <div class=\"col-3\">\r\n\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyBank.Pages.BonificoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyBank.Pages.BonificoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyBank.Pages.BonificoModel>)PageContext?.ViewData;
        public MyBank.Pages.BonificoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
