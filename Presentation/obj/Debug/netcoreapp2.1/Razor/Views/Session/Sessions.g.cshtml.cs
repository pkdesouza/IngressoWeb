#pragma checksum "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Session\Sessions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c65dbd65beabccdeba781e6a8a7e3e187ad72e8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Session_Sessions), @"mvc.1.0.view", @"/Views/Session/Sessions.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Session/Sessions.cshtml", typeof(AspNetCore.Views_Session_Sessions))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c65dbd65beabccdeba781e6a8a7e3e187ad72e8a", @"/Views/Session/Sessions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"163c7385053c820ac3f01146052d94696eba49c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Session_Sessions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ServiceLayer.DTO.ListSessionModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Session\Sessions.cshtml"
  
    ViewData["Title"] = "Lista de Sessões";

#line default
#line hidden
            BeginContext(109, 490, true);
            WriteLiteral(@"
<h2 class=""text-center"">Lista de sessões</h2>

<table class=""table"">
    <thead>
        <tr>
            <th>
                Filme
            </th>
            <th>
                Sala
            </th>
            <th>
                Cinema
            </th>
            <th>
                Inicio da sessão
            </th>
            <th>
                Fim da sessão
            </th>
            <th>Ações</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 31 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Session\Sessions.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(631, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(680, 44, false);
#line 34 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Session\Sessions.cshtml"
           Write(Html.DisplayFor(modelItem => item.NameMovie));

#line default
#line hidden
            EndContext();
            BeginContext(724, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(780, 45, false);
#line 37 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Session\Sessions.cshtml"
           Write(Html.DisplayFor(modelItem => item.RoomNumber));

#line default
#line hidden
            EndContext();
            BeginContext(825, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(881, 51, false);
#line 40 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Session\Sessions.cshtml"
           Write(Html.DisplayFor(modelItem => item.NameMovieTheater));

#line default
#line hidden
            EndContext();
            BeginContext(932, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(988, 44, false);
#line 43 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Session\Sessions.cshtml"
           Write(Html.DisplayFor(modelItem => item.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(1032, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1088, 42, false);
#line 46 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Session\Sessions.cshtml"
           Write(Html.DisplayFor(modelItem => item.EndDate));

#line default
#line hidden
            EndContext();
            BeginContext(1130, 122, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <span class=\"badge badge-pill badge-warning\">\r\n                    ");
            EndContext();
            BeginContext(1253, 55, false);
#line 50 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Session\Sessions.cshtml"
               Write(Html.ActionLink("Editar", "Edit", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1308, 133, true);
            WriteLiteral("\r\n                </span>\r\n                &nbsp;\r\n                <span class=\"badge badge-pill badge-danger\">\r\n                    ");
            EndContext();
            BeginContext(1442, 58, false);
#line 54 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Session\Sessions.cshtml"
               Write(Html.ActionLink("Remover", "Delete", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1500, 61, true);
            WriteLiteral("\r\n                </span>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 58 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Session\Sessions.cshtml"
}

#line default
#line hidden
            BeginContext(1564, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ServiceLayer.DTO.ListSessionModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
