#pragma checksum "C:\Users\Remakker\Downloads\Dandara-main\Dandara\Views\Home\sobresite.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1a01aecc207c688faa5db81c08593f98515f421"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_sobresite), @"mvc.1.0.razor-page", @"/Views/Home/sobresite.cshtml")]
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
#line 1 "C:\Users\Remakker\Downloads\Dandara-main\Dandara\Views\_ViewImports.cshtml"
using Dandara;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Remakker\Downloads\Dandara-main\Dandara\Views\_ViewImports.cshtml"
using Dandara.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1a01aecc207c688faa5db81c08593f98515f421", @"/Views/Home/sobresite.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c4786a37cb02ea573f5435c979ce33581ae4967", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_sobresite : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!doctype html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1a01aecc207c688faa5db81c08593f98515f4213238", async() => {
                WriteLiteral("\n    <meta charset=\"utf-8\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 220, "\"", 230, 0);
                EndWriteAttribute();
                WriteLiteral(@">
    <meta name=""author"" content=""Mark Otto, Jacob Thornton, and Bootstrap contributors"">
    <meta name=""generator"" content=""Hugo 0.84.0"">
    <title>Heroes · Bootstrap v5.0</title>
    <link href=""./images/favicon.ico"" rel=""icon"">


    <!-- Bootstrap-->
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"" crossorigin=""anonymous"">




    <!-- Custom styles for this template -->
    <link href=""./css/indexblog.css"" rel=""stylesheet"">
    <link href=""./css/fazemosblog.css"" rel=""stylesheet"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1a01aecc207c688faa5db81c08593f98515f4215157", async() => {
                WriteLiteral(@"

    <div class=""header"">
        <!-- navegador-->
        <nav class=""navbar shadow-sm bg-white rounded navbar-expand-lg navbar-light"">

            <div class=""container-fluid"">

                <a class=""navbar-brand"" href=""#"">
                    <img src=""./images/logo.svg""");
                BeginWriteAttribute("alt", " alt=\"", 1160, "\"", 1166, 0);
                EndWriteAttribute();
                WriteLiteral(@" width=""90"" height=""72"">
                </a>

                <button class=""navbar-toggler mx-5 navbar-dark bg-primary"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <span class=""navbar-toggler-icon""></span>
                </button>

                <div class=""container text-center"" style=""margin-left: 10px;margin-right: 10px;"">
                </div>

                <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
                    <ul class=""navbar-nav me-auto mb-2 mb-lg-0"">

                        <li class=""nav-item mx-1 "">
                            <a class=""nav-link active"" aria-current=""page"" href=""indexsite.html"">Home</a>
                        </li>
                        <li class=""nav-item mx-1 "">
                            <a class=""nav-link"" href=""sobresite"">Sobre</a>
                        </li>
                       ");
                WriteLiteral(@" <li class=""nav-item mx-1 "">
                            <a class=""nav-link"" href=""contatosite>Contato</a>
                        </li>
                        <li class=""nav-item mx-1 "">
                            <a class=""nav-link"" href=""Indexblog"">Blog</a>
                        </li>
                        <li class=""nav-item mx-1 "">
                            <a class=""nav-link"" href=""Index"">Dandara</a>
                        </li>

                    </ul>

                </div>

            </div>
    </div>
    </nav>
    </div>
    <main>

        <div class=""container text-center py-4"" style=""margin-top: 100px;"">
        </div>

        <div class=""bg-dark text-secondary px-4 py-5 text-center"">
            <div class=""py-5"">
                <h1 class=""display-5 fw-bold text-white"">Economia Solidária</h1>
                <div class=""col-lg-6 mx-auto"">
                    <p class=""fs-5 mb-4"">O presente trabalho é paltado na economia solidária onde o projeto irá disponibilizar uma tabela com ");
                WriteLiteral(@"todos os gastos e irá captar os valores para cobrir os custos por meio de empresas parceiras, usuários e comerciantes </p>
                </div>
            </div>
        </div>

        <!-- icones ----------------------------------------------------------------------------->
        <svg xmlns=""http://www.w3.org/2000/svg"" style=""display: none;"">
            <symbol id=""bootstrap"" viewBox=""0 0 118 94"">
                <title>Bootstrap</title>
                <path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M24.509 0c-6.733 0-11.715 5.893-11.492 12.284.214 6.14-.064 14.092-2.066 20.577C8.943 39.365 5.547 43.485 0 44.014v5.972c5.547.529 8.943 4.649 10.951 11.153 2.002 6.485 2.28 14.437 2.066 20.577C12.794 88.106 17.776 94 24.51 94H93.5c6.733 0 11.714-5.893 11.491-12.284-.214-6.14.064-14.092 2.066-20.577 2.009-6.504 5.396-10.624 10.943-11.153v-5.972c-5.547-.529-8.934-4.649-10.943-11.153-2.002-6.484-2.28-14.437-2.066-20.577C105.214 5.894 100.233 0 93.5 0H24.508zM80 57.863C80 66.663 73.436 72 62.543 72H44a2 2 0");
                WriteLiteral(@" 01-2-2V24a2 2 0 012-2h18.437c9.083 0 15.044 4.92 15.044 12.474 0 5.302-4.01 10.049-9.119 10.88v.277C75.317 46.394 80 51.21 80 57.863zM60.521 28.34H49.948v14.934h8.905c6.884 0 10.68-2.772 10.68-7.727 0-4.643-3.264-7.207-9.012-7.207zM49.948 49.2v16.458H60.91c7.167 0 10.964-2.876 10.964-8.281 0-5.406-3.903-8.178-11.425-8.178H49.948z""></path>
            </symbol>
            <symbol id=""home"" viewBox=""0 0 16 16"">
                <path d=""M8.354 1.146a.5.5 0 0 0-.708 0l-6 6A.5.5 0 0 0 1.5 7.5v7a.5.5 0 0 0 .5.5h4.5a.5.5 0 0 0 .5-.5v-4h2v4a.5.5 0 0 0 .5.5H14a.5.5 0 0 0 .5-.5v-7a.5.5 0 0 0-.146-.354L13 5.793V2.5a.5.5 0 0 0-.5-.5h-1a.5.5 0 0 0-.5.5v1.293L8.354 1.146zM2.5 14V7.707l5.5-5.5 5.5 5.5V14H10v-4a.5.5 0 0 0-.5-.5h-3a.5.5 0 0 0-.5.5v4H2.5z"" />
            </symbol>
            <symbol id=""speedometer2"" viewBox=""0 0 16 16"">
                <path d=""M8 4a.5.5 0 0 1 .5.5V6a.5.5 0 0 1-1 0V4.5A.5.5 0 0 1 8 4zM3.732 5.732a.5.5 0 0 1 .707 0l.915.914a.5.5 0 1 1-.708.708l-.914-.915a.5.5 0 0 1 0-.707zM2 10a.5.5 0 0 1 .");
                WriteLiteral(@"5-.5h1.586a.5.5 0 0 1 0 1H2.5A.5.5 0 0 1 2 10zm9.5 0a.5.5 0 0 1 .5-.5h1.5a.5.5 0 0 1 0 1H12a.5.5 0 0 1-.5-.5zm.754-4.246a.389.389 0 0 0-.527-.02L7.547 9.31a.91.91 0 1 0 1.302 1.258l3.434-4.297a.389.389 0 0 0-.029-.518z"" />
                <path fill-rule=""evenodd"" d=""M0 10a8 8 0 1 1 15.547 2.661c-.442 1.253-1.845 1.602-2.932 1.25C11.309 13.488 9.475 13 8 13c-1.474 0-3.31.488-4.615.911-1.087.352-2.49.003-2.932-1.25A7.988 7.988 0 0 1 0 10zm8-7a7 7 0 0 0-6.603 9.329c.203.575.923.876 1.68.63C4.397 12.533 6.358 12 8 12s3.604.532 4.923.96c.757.245 1.477-.056 1.68-.631A7 7 0 0 0 8 3z"" />
            </symbol>
            <symbol id=""table"" viewBox=""0 0 16 16"">
                <path d=""M0 2a2 2 0 0 1 2-2h12a2 2 0 0 1 2 2v12a2 2 0 0 1-2 2H2a2 2 0 0 1-2-2V2zm15 2h-4v3h4V4zm0 4h-4v3h4V8zm0 4h-4v3h3a1 1 0 0 0 1-1v-2zm-5 3v-3H6v3h4zm-5 0v-3H1v2a1 1 0 0 0 1 1h3zm-4-4h4V8H1v3zm0-4h4V4H1v3zm5-3v3h4V4H6zm4 4H6v3h4V8z"" />
            </symbol>
            <symbol id=""people-circle"" viewBox=""0 0 16 16"">
                <path d=");
                WriteLiteral(@"""M11 6a3 3 0 1 1-6 0 3 3 0 0 1 6 0z"" />
                <path fill-rule=""evenodd"" d=""M0 8a8 8 0 1 1 16 0A8 8 0 0 1 0 8zm8-7a7 7 0 0 0-5.468 11.37C3.242 11.226 4.805 10 8 10s4.757 1.225 5.468 2.37A7 7 0 0 0 8 1z"" />
            </symbol>
            <symbol id=""grid"" viewBox=""0 0 16 16"">
                <path d=""M1 2.5A1.5 1.5 0 0 1 2.5 1h3A1.5 1.5 0 0 1 7 2.5v3A1.5 1.5 0 0 1 5.5 7h-3A1.5 1.5 0 0 1 1 5.5v-3zM2.5 2a.5.5 0 0 0-.5.5v3a.5.5 0 0 0 .5.5h3a.5.5 0 0 0 .5-.5v-3a.5.5 0 0 0-.5-.5h-3zm6.5.5A1.5 1.5 0 0 1 10.5 1h3A1.5 1.5 0 0 1 15 2.5v3A1.5 1.5 0 0 1 13.5 7h-3A1.5 1.5 0 0 1 9 5.5v-3zm1.5-.5a.5.5 0 0 0-.5.5v3a.5.5 0 0 0 .5.5h3a.5.5 0 0 0 .5-.5v-3a.5.5 0 0 0-.5-.5h-3zM1 10.5A1.5 1.5 0 0 1 2.5 9h3A1.5 1.5 0 0 1 7 10.5v3A1.5 1.5 0 0 1 5.5 15h-3A1.5 1.5 0 0 1 1 13.5v-3zm1.5-.5a.5.5 0 0 0-.5.5v3a.5.5 0 0 0 .5.5h3a.5.5 0 0 0 .5-.5v-3a.5.5 0 0 0-.5-.5h-3zm6.5.5A1.5 1.5 0 0 1 10.5 9h3a1.5 1.5 0 0 1 1.5 1.5v3a1.5 1.5 0 0 1-1.5 1.5h-3A1.5 1.5 0 0 1 9 13.5v-3zm1.5-.5a.5.5 0 0 0-.5.5v3a.5.5 0 0 0 .5.5h3a.5.5 0 0 0 .5-.");
                WriteLiteral(@"5v-3a.5.5 0 0 0-.5-.5h-3z"" />
            </symbol>
            <symbol id=""collection"" viewBox=""0 0 16 16"">
                <path d=""M2.5 3.5a.5.5 0 0 1 0-1h11a.5.5 0 0 1 0 1h-11zm2-2a.5.5 0 0 1 0-1h7a.5.5 0 0 1 0 1h-7zM0 13a1.5 1.5 0 0 0 1.5 1.5h13A1.5 1.5 0 0 0 16 13V6a1.5 1.5 0 0 0-1.5-1.5h-13A1.5 1.5 0 0 0 0 6v7zm1.5.5A.5.5 0 0 1 1 13V6a.5.5 0 0 1 .5-.5h13a.5.5 0 0 1 .5.5v7a.5.5 0 0 1-.5.5h-13z"" />
            </symbol>
            <symbol id=""calendar3"" viewBox=""0 0 16 16"">
                <path d=""M14 0H2a2 2 0 0 0-2 2v12a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V2a2 2 0 0 0-2-2zM1 3.857C1 3.384 1.448 3 2 3h12c.552 0 1 .384 1 .857v10.286c0 .473-.448.857-1 .857H2c-.552 0-1-.384-1-.857V3.857z"" />
                <path d=""M6.5 7a1 1 0 1 0 0-2 1 1 0 0 0 0 2zm3 0a1 1 0 1 0 0-2 1 1 0 0 0 0 2zm3 0a1 1 0 1 0 0-2 1 1 0 0 0 0 2zm-9 3a1 1 0 1 0 0-2 1 1 0 0 0 0 2zm3 0a1 1 0 1 0 0-2 1 1 0 0 0 0 2zm3 0a1 1 0 1 0 0-2 1 1 0 0 0 0 2zm3 0a1 1 0 1 0 0-2 1 1 0 0 0 0 2zm-9 3a1 1 0 1 0 0-2 1 1 0 0 0 0 2zm3 0a1 1 0 1 0 0-2 1 1 0 0 0 0 ");
                WriteLiteral(@"2zm3 0a1 1 0 1 0 0-2 1 1 0 0 0 0 2z"" />
            </symbol>
            <symbol id=""chat-quote-fill"" viewBox=""0 0 16 16"">
                <path d=""M16 8c0 3.866-3.582 7-8 7a9.06 9.06 0 0 1-2.347-.306c-.584.296-1.925.864-4.181 1.234-.2.032-.352-.176-.273-.362.354-.836.674-1.95.77-2.966C.744 11.37 0 9.76 0 8c0-3.866 3.582-7 8-7s8 3.134 8 7zM7.194 6.766a1.688 1.688 0 0 0-.227-.272 1.467 1.467 0 0 0-.469-.324l-.008-.004A1.785 1.785 0 0 0 5.734 6C4.776 6 4 6.746 4 7.667c0 .92.776 1.666 1.734 1.666.343 0 .662-.095.931-.26-.137.389-.39.804-.81 1.22a.405.405 0 0 0 .011.59c.173.16.447.155.614-.01 1.334-1.329 1.37-2.758.941-3.706a2.461 2.461 0 0 0-.227-.4zM11 9.073c-.136.389-.39.804-.81 1.22a.405.405 0 0 0 .012.59c.172.16.446.155.613-.01 1.334-1.329 1.37-2.758.942-3.706a2.466 2.466 0 0 0-.228-.4 1.686 1.686 0 0 0-.227-.273 1.466 1.466 0 0 0-.469-.324l-.008-.004A1.785 1.785 0 0 0 10.07 6c-.957 0-1.734.746-1.734 1.667 0 .92.777 1.666 1.734 1.666.343 0 .662-.095.931-.26z"" />
            </symbol>
            <symbol id=");
                WriteLiteral(@"""cpu-fill"" viewBox=""0 0 16 16"">
                <path d=""M6.5 6a.5.5 0 0 0-.5.5v3a.5.5 0 0 0 .5.5h3a.5.5 0 0 0 .5-.5v-3a.5.5 0 0 0-.5-.5h-3z"" />
                <path d=""M5.5.5a.5.5 0 0 0-1 0V2A2.5 2.5 0 0 0 2 4.5H.5a.5.5 0 0 0 0 1H2v1H.5a.5.5 0 0 0 0 1H2v1H.5a.5.5 0 0 0 0 1H2v1H.5a.5.5 0 0 0 0 1H2A2.5 2.5 0 0 0 4.5 14v1.5a.5.5 0 0 0 1 0V14h1v1.5a.5.5 0 0 0 1 0V14h1v1.5a.5.5 0 0 0 1 0V14h1v1.5a.5.5 0 0 0 1 0V14a2.5 2.5 0 0 0 2.5-2.5h1.5a.5.5 0 0 0 0-1H14v-1h1.5a.5.5 0 0 0 0-1H14v-1h1.5a.5.5 0 0 0 0-1H14v-1h1.5a.5.5 0 0 0 0-1H14A2.5 2.5 0 0 0 11.5 2V.5a.5.5 0 0 0-1 0V2h-1V.5a.5.5 0 0 0-1 0V2h-1V.5a.5.5 0 0 0-1 0V2h-1V.5zm1 4.5h3A1.5 1.5 0 0 1 11 6.5v3A1.5 1.5 0 0 1 9.5 11h-3A1.5 1.5 0 0 1 5 9.5v-3A1.5 1.5 0 0 1 6.5 5z"" />
            </symbol>
            <symbol id=""gear-fill"" viewBox=""0 0 16 16"">
                <path d=""M9.405 1.05c-.413-1.4-2.397-1.4-2.81 0l-.1.34a1.464 1.464 0 0 1-2.105.872l-.31-.17c-1.283-.698-2.686.705-1.987 1.987l.169.311c.446.82.023 1.841-.872 2.105l-.34.1c-1.4.413-1.4 2.397 0 2.81l.3");
                WriteLiteral(@"4.1a1.464 1.464 0 0 1 .872 2.105l-.17.31c-.698 1.283.705 2.686 1.987 1.987l.311-.169a1.464 1.464 0 0 1 2.105.872l.1.34c.413 1.4 2.397 1.4 2.81 0l.1-.34a1.464 1.464 0 0 1 2.105-.872l.31.17c1.283.698 2.686-.705 1.987-1.987l-.169-.311a1.464 1.464 0 0 1 .872-2.105l.34-.1c1.4-.413 1.4-2.397 0-2.81l-.34-.1a1.464 1.464 0 0 1-.872-2.105l.17-.31c.698-1.283-.705-2.686-1.987-1.987l-.311.169a1.464 1.464 0 0 1-2.105-.872l-.1-.34zM8 10.93a2.929 2.929 0 1 1 0-5.86 2.929 2.929 0 0 1 0 5.858z"" />
            </symbol>
            <symbol id=""speedometer"" viewBox=""0 0 16 16"">
                <path d=""M8 2a.5.5 0 0 1 .5.5V4a.5.5 0 0 1-1 0V2.5A.5.5 0 0 1 8 2zM3.732 3.732a.5.5 0 0 1 .707 0l.915.914a.5.5 0 1 1-.708.708l-.914-.915a.5.5 0 0 1 0-.707zM2 8a.5.5 0 0 1 .5-.5h1.586a.5.5 0 0 1 0 1H2.5A.5.5 0 0 1 2 8zm9.5 0a.5.5 0 0 1 .5-.5h1.5a.5.5 0 0 1 0 1H12a.5.5 0 0 1-.5-.5zm.754-4.246a.389.389 0 0 0-.527-.02L7.547 7.31A.91.91 0 1 0 8.85 8.569l3.434-4.297a.389.389 0 0 0-.029-.518z"" />
                <path fill-rule=""evenodd"" d=""M6.66");
                WriteLiteral(@"4 15.889A8 8 0 1 1 9.336.11a8 8 0 0 1-2.672 15.78zm-4.665-4.283A11.945 11.945 0 0 1 8 10c2.186 0 4.236.585 6.001 1.606a7 7 0 1 0-12.002 0z"" />
            </symbol>
            <symbol id=""toggles2"" viewBox=""0 0 16 16"">
                <path d=""M9.465 10H12a2 2 0 1 1 0 4H9.465c.34-.588.535-1.271.535-2 0-.729-.195-1.412-.535-2z"" />
                <path d=""M6 15a3 3 0 1 0 0-6 3 3 0 0 0 0 6zm0 1a4 4 0 1 1 0-8 4 4 0 0 1 0 8zm.535-10a3.975 3.975 0 0 1-.409-1H4a1 1 0 0 1 0-2h2.126c.091-.355.23-.69.41-1H4a2 2 0 1 0 0 4h2.535z"" />
                <path d=""M14 4a4 4 0 1 1-8 0 4 4 0 0 1 8 0z"" />
            </symbol>
            <symbol id=""tools"" viewBox=""0 0 16 16"">
                <path d=""M1 0L0 1l2.2 3.081a1 1 0 0 0 .815.419h.07a1 1 0 0 1 .708.293l2.675 2.675-2.617 2.654A3.003 3.003 0 0 0 0 13a3 3 0 1 0 5.878-.851l2.654-2.617.968.968-.305.914a1 1 0 0 0 .242 1.023l3.356 3.356a1 1 0 0 0 1.414 0l1.586-1.586a1 1 0 0 0 0-1.414l-3.356-3.356a1 1 0 0 0-1.023-.242L10.5 9.5l-.96-.96 2.68-2.643A3.005 3.005 0 0 0 16 3c0-.269");
                WriteLiteral(@"-.035-.53-.102-.777l-2.14 2.141L12 4l-.364-1.757L13.777.102a3 3 0 0 0-3.675 3.68L7.462 6.46 4.793 3.793a1 1 0 0 1-.293-.707v-.071a1 1 0 0 0-.419-.814L1 0zm9.646 10.646a.5.5 0 0 1 .708 0l3 3a.5.5 0 0 1-.708.708l-3-3a.5.5 0 0 1 0-.708zM3 11l.471.242.529.026.287.445.445.287.026.529L5 13l-.242.471-.026.529-.445.287-.287.445-.529.026L3 15l-.471-.242L2 14.732l-.287-.445L1.268 14l-.026-.529L1 13l.242-.471.026-.529.445-.287.287-.445.529-.026L3 11z"" />
            </symbol>
            <symbol id=""chevron-right"" viewBox=""0 0 16 16"">
                <path fill-rule=""evenodd"" d=""M4.646 1.646a.5.5 0 0 1 .708 0l6 6a.5.5 0 0 1 0 .708l-6 6a.5.5 0 0 1-.708-.708L10.293 8 4.646 2.354a.5.5 0 0 1 0-.708z"" />
            </symbol>
            <symbol id=""geo-fill"" viewBox=""0 0 16 16"">
                <path fill-rule=""evenodd"" d=""M4 4a4 4 0 1 1 4.5 3.969V13.5a.5.5 0 0 1-1 0V7.97A4 4 0 0 1 4 3.999zm2.493 8.574a.5.5 0 0 1-.411.575c-.712.118-1.28.295-1.655.493a1.319 1.319 0 0 0-.37.265.301.301 0 0 0-.057.09V14l.002.008a.147.147 0 0 0");
                WriteLiteral(@" .016.033.617.617 0 0 0 .145.15c.165.13.435.27.813.395.751.25 1.82.414 3.024.414s2.273-.163 3.024-.414c.378-.126.648-.265.813-.395a.619.619 0 0 0 .146-.15.148.148 0 0 0 .015-.033L12 14v-.004a.301.301 0 0 0-.057-.09 1.318 1.318 0 0 0-.37-.264c-.376-.198-.943-.375-1.655-.493a.5.5 0 1 1 .164-.986c.77.127 1.452.328 1.957.594C12.5 13 13 13.4 13 14c0 .426-.26.752-.544.977-.29.228-.68.413-1.116.558-.878.293-2.059.465-3.34.465-1.281 0-2.462-.172-3.34-.465-.436-.145-.826-.33-1.116-.558C3.26 14.752 3 14.426 3 14c0-.599.5-1 .961-1.243.505-.266 1.187-.467 1.957-.594a.5.5 0 0 1 .575.411z"" />
            </symbol>
        </svg>


        <div class=""container px-4 py-5"" id=""icon-grid"">
            <h2 class=""pb-2 border-bottom"">Custos</h2>

            <div class=""row row-cols-1 row-cols-sm-2 row-cols-md-3 row-cols-lg-4 g-4 py-5"">
                <div class=""col d-flex align-items-start"">
                    <svg class=""bi text-muted flex-shrink-0 me-3"" width=""1.75em"" height=""1.75em""><use xlink:href=""#tools"" /></svg>
    ");
                WriteLiteral(@"                <div>
                        <h4 class=""fw-bold mb-0"">Hospedagem</h4>
                        <p>Custos de Hospedagem</p>
                    </div>
                </div>
                <div class=""col d-flex align-items-start"">
                    <svg class=""bi text-muted flex-shrink-0 me-3"" width=""1.75em"" height=""1.75em""><use xlink:href=""#tools"" /></svg>
                    <div>
                        <h4 class=""fw-bold mb-0"">Pessoal Especializado</h4>
                        <p>Salário</p>
                    </div>
                </div>
                <div class=""col d-flex align-items-start"">
                    <svg class=""bi text-muted flex-shrink-0 me-3"" width=""1.75em"" height=""1.75em""><use xlink:href=""#tools"" /></svg>
                    <div>
                        <h4 class=""fw-bold mb-0"">Investimentos Físiscos</h4>
                        <p>Paragraph of text beneath the heading to explain the heading.</p>
                    </div>
                </div>
                <d");
                WriteLiteral(@"iv class=""col d-flex align-items-start"">
                    <svg class=""bi text-muted flex-shrink-0 me-3"" width=""1.75em"" height=""1.75em""><use xlink:href=""#tools"" /></svg>
                    <div>
                        <h4 class=""fw-bold mb-0"">Investimentos em Software</h4>
                        <p>Paragraph of text beneath the heading to explain the heading.</p>
                    </div>
                </div>

            </div>
        </div>


        <!-- Missão visão e valores-->
        <div id=""caixademarketing"" class=""container marketing"">

            <!-- Three columns of text below the carousel -->
            <div class=""row"">


                <div class=""col-lg-4"">
                    <img src=""./images/missao.png""");
                BeginWriteAttribute("alt", " alt=\"", 16248, "\"", 16254, 0);
                EndWriteAttribute();
                WriteLiteral(@" width=""140"" height=""140"">


                    <h2>Missão</h2>
                    <p>Oferecer soluções práticas e inovadoras para o comercio local, possuindo produtos para decoração vestuario e serviços, de alto padrão de qualidade, preço justo, e com excelencia no atendimento. Proporcionar a inclusão, bem estar e o desenvolvimento do comercio local e o empreendedorismo. Gerar lucro com que garanta a sustentabilidade do negocio para pequenos e medios produtores, e conviver de forma harmoniosa com a sociedade..</p>

                </div><!-- /.col-lg-4 -->

                <div class=""col-lg-4"">
                    <img src=""./images/visao.png""");
                BeginWriteAttribute("alt", " alt=\"", 16910, "\"", 16916, 0);
                EndWriteAttribute();
                WriteLiteral(@" width=""140"" height=""140"">

                    <h2>Visão</h2>
                    <p>Reconhecimento de ser a pioneira, e o melhor portal para e-commerce de produtos afro.estar na mente dos consumidores como um portal para comercialização de produtos, que apresenta eficiencia, bom atendimento durante compra e pós-compra, ajudar a realizar sonhos e liberdade e empoderamento de pequenos e médios empreendedores.</p>

                </div><!-- /.col-lg-4 -->

                <div class=""col-lg-4"">
                    <img src=""./images/valores.png""");
                BeginWriteAttribute("alt", " alt=\"", 17468, "\"", 17474, 0);
                EndWriteAttribute();
                WriteLiteral(@" width=""140"" height=""140"">

                    <h2>Valores</h2>
                    <p>
                        Integridade: a relação estar baseada em honestidade e lealdade.</br>
                        Respeito: Participação de empreendedores para o sucesso do negocio.</br>
                        Empatia: fundamentado com que agir nas nossas relações internadas e externas.</br>
                        Empoderamento: dar voz e ouvidos à pessoas que não tenham possibilidade a vender seus produtos a canais maiores.
                    </p>

                </div><!-- /.col-lg-4 -->


            </div><!-- /.row -->
        </div>


        <div class=""container text-center"" style=""margin-top: 100px;"">
        </div>






    </main>




    <!-- Footer -->
    <footer class=""text-center text-lg-start text-white""
            style=""background-color: #795c34"">
        <!-- Grid container -->
        <div class=""container"">
            <!-- Section: Links -->
            <section");
                BeginWriteAttribute("class", " class=\"", 18470, "\"", 18478, 0);
                EndWriteAttribute();
                WriteLiteral(">\n                <!--Grid row-->\n                <div class=\"row\">\n                    <!-- Grid column -->\n                    <div class=\"col-md-3 col-lg-3 col-xl-3 mx-auto mt-3\">\n\n                        <img src=\"./images/logo.svg\"");
                BeginWriteAttribute("alt", " alt=\"", 18715, "\"", 18721, 0);
                EndWriteAttribute();
                WriteLiteral(@" width=""120"" height=""102"" style=""margin-bottom: 10px;"">

                    </div>
                    <!-- Grid column -->
                    <!-- Grid column -->

                    <hr class=""w-100 clearfix d-md-none"" />

                    <!-- Grid column -->
                    <div class=""col-md-3 col-lg-2 col-xl-2 mx-auto mt-3"">
                        <h6 class=""text-uppercase mb-4 font-weight-bold"">
                            links Úteis
                        </h6>
                        <p>
                            <a class=""text-white"" href=""Indexsite"">Home</a>
                        </p>
                        <p>
                            <a class=""text-white"" href=""sobresite"">Sobre</a>
                        </p>
                    </div>

                    <!-- Grid column -->
                    <hr class=""w-100 clearfix d-md-none"" />

                    <!-- Grid column -->
                    <div class=""col-md-4 col-lg-3 col-xl-3 mx-auto mt-3"">
                        <");
                WriteLiteral(@"h6 class=""text-uppercase mb-4 font-weight-bold"">Contato</h6>
                        <p><i class=""fas fa-home mr-3""></i> Bahia, Brasil</p>
                        <p><i class=""fas fa-envelope mr-3""></i> dandaraapreta@gmail.com</p>
                        <p><i class=""fas fa-phone mr-3""></i> + 00 000 000 00</p>
                        <p><i class=""fas fa-phone mr-3""></i> + 00 000 000 00</p>

                    </div>
                    <!-- Grid column -->
                </div>
                <!--Grid row-->
            </section>
            <!-- Section: Links -->

            <hr class=""my-3"">

            <!-- Section: Copyright -->
            <section class=""p-3 pt-0"">
                <div class=""row d-flex align-items-center"">
                    <!-- Grid column -->
                    <div class=""col-md-7 col-lg-8 text-center text-md-start"">
                        <!-- Copyright -->
                        <div class=""p-3"">
                            © 2021 Copyright:
                           ");
                WriteLiteral(@" <a class=""text-white"" href=""#"">Squad 38</a>
                        </div>
                        <!-- Copyright -->
                    </div>


                    <!-- Grid column -->
                </div>
            </section>
            <!-- Section: Copyright -->
        </div>
        <!-- Grid container -->
    </footer>

    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p"" crossorigin=""anonymous""></script>
");
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
            WriteLiteral("\n\n</html>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dandara.Views.Home.sobresiteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Dandara.Views.Home.sobresiteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Dandara.Views.Home.sobresiteModel>)PageContext?.ViewData;
        public Dandara.Views.Home.sobresiteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
