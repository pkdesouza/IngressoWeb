#pragma checksum "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Movie\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc735a9c2754ccfe94cd16ad71cff9eba41b1369"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Details), @"mvc.1.0.view", @"/Views/Movie/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movie/Details.cshtml", typeof(AspNetCore.Views_Movie_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc735a9c2754ccfe94cd16ad71cff9eba41b1369", @"/Views/Movie/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"163c7385053c820ac3f01146052d94696eba49c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ServiceLayer.DTO.DetailsMovieModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/image-movie.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Movie\Details.cshtml"
  
    ViewData["Title"] = "Detalhes do filme";

#line default
#line hidden
            BeginContext(98, 101, true);
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        <h4>Detalhes do filme</h4>\r\n        <hr />\r\n\r\n");
            EndContext();
#line 11 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Movie\Details.cshtml"
         if (!String.IsNullOrEmpty(Model.Image))
        {

#line default
#line hidden
            BeginContext(260, 38, true);
            WriteLiteral("            <img class=\"img-thumbnail\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 298, "\"", 326, 1);
#line 13 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Movie\Details.cshtml"
WriteAttributeValue("", 304, Html.Raw(Model.Image), 304, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(327, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 14 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Movie\Details.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(368, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(380, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "657c3f417b4c4ac986ce8208dc1013a0", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(439, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 18 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Movie\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(452, 130, true);
            WriteLiteral("        <dl class=\"dl-horizontal\">\r\n            <dt>\r\n                Filme\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(583, 36, false);
#line 24 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Movie\Details.cshtml"
           Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(619, 138, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                Sinopse\r\n            </dt>\r\n            <dd class=\"text-justify\">\r\n                ");
            EndContext();
            BeginContext(758, 40, false);
#line 30 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Movie\Details.cshtml"
           Write(Html.DisplayFor(model => model.Synopsis));

#line default
#line hidden
            EndContext();
            BeginContext(798, 126, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                Idade indicativa\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(925, 41, false);
#line 36 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Movie\Details.cshtml"
           Write(Html.DisplayFor(model => model.AgeRating));

#line default
#line hidden
            EndContext();
            BeginContext(966, 115, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                Preço\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1082, 37, false);
#line 42 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Movie\Details.cshtml"
           Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1119, 127, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                Ano de Lançamento\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1247, 43, false);
#line 48 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Movie\Details.cshtml"
           Write(Html.DisplayFor(model => model.ReleaseYear));

#line default
#line hidden
            EndContext();
            BeginContext(1290, 126, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                Data do Registro\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1417, 48, false);
#line 54 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Movie\Details.cshtml"
           Write(Html.DisplayFor(model => model.RegistrationDate));

#line default
#line hidden
            EndContext();
            BeginContext(1465, 136, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                Data da última modificação\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1602, 52, false);
#line 60 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Movie\Details.cshtml"
           Write(Html.DisplayFor(model => model.LastModificationDate));

#line default
#line hidden
            EndContext();
            BeginContext(1654, 76, true);
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n    <div class=\"col-md-6\">\r\n");
            EndContext();
#line 65 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Movie\Details.cshtml"
         if (!String.IsNullOrEmpty(Model.Trailer))
        {


#line default
#line hidden
            BeginContext(1795, 44, true);
            WriteLiteral("            <iframe width=\"560\" height=\"315\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1839, "\"", 1869, 1);
#line 68 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Movie\Details.cshtml"
WriteAttributeValue("", 1845, Html.Raw(Model.Trailer), 1845, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1870, 145, true);
            WriteLiteral("\r\n                    frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n");
            EndContext();
#line 70 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Movie\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(2026, 87, true);
            WriteLiteral("    </div>\r\n</div>\r\n<div>\r\n    <span class=\"badge badge-pill badge-warning \">\r\n        ");
            EndContext();
            BeginContext(2114, 87, false);
#line 75 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Movie\Details.cshtml"
   Write(Html.ActionLink("Editar", "Edit", new { id = Model.Id }, new { @class = "text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(2201, 19, true);
            WriteLiteral("\r\n    </span>\r\n    ");
            EndContext();
            BeginContext(2220, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "661a73513862459486b1fb8a677bf71a", async() => {
                BeginContext(2242, 27, true);
                WriteLiteral("Voltar para lista de filmes");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2273, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceLayer.DTO.DetailsMovieModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
