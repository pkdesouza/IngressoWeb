#pragma checksum "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Room\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa3af9fe5a755a39dc2d6eff74cf1f404b995877"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Room_Index), @"mvc.1.0.view", @"/Views/Room/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Room/Index.cshtml", typeof(AspNetCore.Views_Room_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa3af9fe5a755a39dc2d6eff74cf1f404b995877", @"/Views/Room/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"163c7385053c820ac3f01146052d94696eba49c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Room_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ServiceLayer.DTO.ListMovieTheaterRoomModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(64, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Room\Index.cshtml"
  
    ViewData["Title"] = "Salas";

#line default
#line hidden
            BeginContext(107, 417, true);
            WriteLiteral(@"
<h2 class=""text-center"">Salas</h2>

<table class=""table"">
    <thead>
        <tr>
            <th>
                Cinema
            </th>
            <th>
                Cidade
            </th>
            <th>
                Estado
            </th>
            <th>
                Quantidade de salas
            </th>
            <th>Ações</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 28 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Room\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(556, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(605, 51, false);
#line 31 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Room\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NameMovieTheater));

#line default
#line hidden
            EndContext();
            BeginContext(656, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(712, 55, false);
#line 34 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Room\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CityNameMovieTheater));

#line default
#line hidden
            EndContext();
            BeginContext(767, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(823, 52, false);
#line 37 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Room\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.StateMovieTheater));

#line default
#line hidden
            EndContext();
            BeginContext(875, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(931, 48, false);
#line 40 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Room\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.QuantityRooms));

#line default
#line hidden
            EndContext();
            BeginContext(979, 122, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <span class=\"badge badge-pill badge-primary\">\r\n                    ");
            EndContext();
            BeginContext(1102, 77, false);
#line 44 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Room\Index.cshtml"
               Write(Html.ActionLink("Adicionar Sala", "Create", new { id = item.IdMovieTheater }));

#line default
#line hidden
            EndContext();
            BeginContext(1179, 132, true);
            WriteLiteral(" \r\n                </span>\r\n                &nbsp;\r\n                <span class=\"badge badge-pill badge-info\">\r\n                    ");
            EndContext();
            BeginContext(1312, 71, false);
#line 48 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Room\Index.cshtml"
               Write(Html.ActionLink("Ver Salas", "Rooms", new { id = item.IdMovieTheater }));

#line default
#line hidden
            EndContext();
            BeginContext(1383, 61, true);
            WriteLiteral("\r\n                </span>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 52 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Room\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1447, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ServiceLayer.DTO.ListMovieTheaterRoomModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591