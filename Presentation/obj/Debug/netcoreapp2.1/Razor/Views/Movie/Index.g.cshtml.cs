#pragma checksum "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Movie\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "509419bbb4f1d57f29fe1de344167a1c5b83b4b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Index), @"mvc.1.0.view", @"/Views/Movie/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movie/Index.cshtml", typeof(AspNetCore.Views_Movie_Index))]
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
#line 1 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\_ViewImports.cshtml"
using IngressoLayer;

#line default
#line hidden
#line 2 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\_ViewImports.cshtml"
using IngressoLayer.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"509419bbb4f1d57f29fe1de344167a1c5b83b4b9", @"/Views/Movie/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"163c7385053c820ac3f01146052d94696eba49c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ServiceLayer.DTO.ListMovieModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail-movie"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/image-movie.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Movie\Index.cshtml"
  
    ViewData["Title"] = "Filmes";

#line default
#line hidden
            BeginContext(97, 117, true);
            WriteLiteral("\r\n<h2 class=\"text-center\">Filmes</h2>\r\n\r\n<p>\r\n    <span class=\"badge badge-pill badge-primary float-right\">\r\n        ");
            EndContext();
            BeginContext(214, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6b00d965ebe4167a530da9d0967bb68", async() => {
                BeginContext(237, 15, true);
                WriteLiteral("Adicionar Filme");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(256, 21, true);
            WriteLiteral("\r\n    </span>\r\n</p>\r\n");
            EndContext();
#line 14 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Movie\Index.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
            BeginContext(305, 456, true);
            WriteLiteral(@"    <table class=""table"">
        <thead>
            <tr>
                <th>
                    Capa do filme
                </th>
                <th>
                    Filme
                </th>
                <th>
                    Preço
                </th>
                <th>
                    Ano de Lançamento
                </th>
                <th>Acões</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 35 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Movie\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(818, 48, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n");
            EndContext();
#line 39 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Movie\Index.cshtml"
                         if (!String.IsNullOrEmpty(item.Image))
                        {

#line default
#line hidden
            BeginContext(958, 60, true);
            WriteLiteral("                            <img class=\"img-thumbnail-movie\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1018, "\"", 1045, 1);
#line 41 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Movie\Index.cshtml"
WriteAttributeValue("", 1024, Html.Raw(item.Image), 1024, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1046, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 42 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Movie\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1135, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(1163, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ce7886dc87b94f0091632f579172f525", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1229, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 46 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Movie\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(1258, 77, true);
            WriteLiteral("                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1336, 39, false);
#line 49 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Movie\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1375, 82, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        R$ ");
            EndContext();
            BeginContext(1458, 40, false);
#line 52 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Movie\Index.cshtml"
                      Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1498, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1578, 46, false);
#line 55 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Movie\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ReleaseYear));

#line default
#line hidden
            EndContext();
            BeginContext(1624, 154, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <span class=\"badge badge-pill badge-warning\">\r\n                            ");
            EndContext();
            BeginContext(1779, 55, false);
#line 59 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Movie\Index.cshtml"
                       Write(Html.ActionLink("Editar", "Edit", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1834, 163, true);
            WriteLiteral("\r\n                        </span>\r\n                        &nbsp;\r\n                        <span class=\"badge badge-pill badge-info\">\r\n                            ");
            EndContext();
            BeginContext(1998, 60, false);
#line 63 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Movie\Index.cshtml"
                       Write(Html.ActionLink("Detalhes", "Details", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(2058, 165, true);
            WriteLiteral("\r\n                        </span>\r\n                        &nbsp;\r\n                        <span class=\"badge badge-pill badge-danger\">\r\n                            ");
            EndContext();
            BeginContext(2224, 58, false);
#line 67 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Movie\Index.cshtml"
                       Write(Html.ActionLink("Remover", "Delete", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(2282, 85, true);
            WriteLiteral("\r\n                        </span>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 71 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Movie\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2382, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 74 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Movie\Index.cshtml"
}
else {

#line default
#line hidden
            BeginContext(2425, 42, true);
            WriteLiteral("        <h3>Nenhum filme cadastrado</h3>\r\n");
            EndContext();
#line 77 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Movie\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ServiceLayer.DTO.ListMovieModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
