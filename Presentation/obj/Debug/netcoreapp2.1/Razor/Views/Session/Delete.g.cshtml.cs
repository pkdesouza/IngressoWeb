#pragma checksum "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Session\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40453de9fae7e9882e9f6da4bc5ab40c30cce4cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Session_Delete), @"mvc.1.0.view", @"/Views/Session/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Session/Delete.cshtml", typeof(AspNetCore.Views_Session_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40453de9fae7e9882e9f6da4bc5ab40c30cce4cb", @"/Views/Session/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"163c7385053c820ac3f01146052d94696eba49c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Session_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ServiceLayer.DTO.DetailsSessionModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Session\Delete.cshtml"
  
    ViewData["Title"] = "Remover sessão";

#line default
#line hidden
            BeginContext(97, 196, true);
            WriteLiteral("\r\n<h3>Tem certezam que deseja remover essa sessão?</h3>\r\n<div>\r\n    <h4>Informações</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            Filme\r\n        </dt>\r\n        <dd>\r\n");
            EndContext();
#line 16 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Session\Delete.cshtml"
             foreach (var item in Model.ListMovies)
            {
                if(item.Id == Model.Movie){
                    

#line default
#line hidden
            BeginContext(427, 9, false);
#line 19 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Session\Delete.cshtml"
               Write(item.Name);

#line default
#line hidden
            EndContext();
#line 19 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Session\Delete.cshtml"
                              
                }
            }

#line default
#line hidden
            BeginContext(472, 76, true);
            WriteLiteral("        </dd>\r\n        <dt>\r\n            Sala\r\n        </dt>\r\n        <dd>\r\n");
            EndContext();
#line 27 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Session\Delete.cshtml"
             foreach (var item in Model.ListRooms)
            {
                if(item.Id == Model.Room){
                    

#line default
#line hidden
            BeginContext(680, 15, false);
#line 30 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Session\Delete.cshtml"
               Write(item.RoomNumber);

#line default
#line hidden
            EndContext();
#line 30 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Session\Delete.cshtml"
                                    
                }
            }

#line default
#line hidden
            BeginContext(731, 100, true);
            WriteLiteral("        </dd>\r\n        <dt>\r\n            Inicio da sessão\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(832, 41, false);
#line 38 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Session\Delete.cshtml"
       Write(Html.DisplayFor(model => model.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(873, 99, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Fim da sessão\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(973, 39, false);
#line 44 "C:\Users\HP PAVILION 14V062br\Desktop\ingresso backup\IngressoWeb\Presentation\Views\Session\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EndDate));

#line default
#line hidden
            EndContext();
            BeginContext(1012, 34, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    ");
            EndContext();
            BeginContext(1046, 176, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5667abec4e124fe3b8b9d24f6dd63bb9", async() => {
                BeginContext(1072, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Remover\" class=\"btn btn-danger\" /> \r\n        ");
                EndContext();
                BeginContext(1155, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "486d50e141cd4c399bb3ca80e62f7237", async() => {
                    BeginContext(1177, 28, true);
                    WriteLiteral("Voltar para lista de sessões");
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
                BeginContext(1209, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1222, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceLayer.DTO.DetailsSessionModel> Html { get; private set; }
    }
}
#pragma warning restore 1591