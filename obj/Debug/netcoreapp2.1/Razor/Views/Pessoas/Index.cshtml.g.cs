#pragma checksum "C:\Users\letic\OneDrive\Área de Trabalho\Nova pasta (2)\PROJETOSDAFACUL\NovoPIM8-20230318T203741Z-001\NovoPIM8\PIMOITO\PIMOITO\Views\Pessoas\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "790881d512e929fbc8fa46fa4deea03eae68141e789adfde346dc08cd86ec442"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pessoas_Index), @"mvc.1.0.view", @"/Views/Pessoas/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pessoas/Index.cshtml", typeof(AspNetCore.Views_Pessoas_Index))]
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
#line 1 "C:\Users\letic\OneDrive\Área de Trabalho\Nova pasta (2)\PROJETOSDAFACUL\NovoPIM8-20230318T203741Z-001\NovoPIM8\PIMOITO\PIMOITO\Views\_ViewImports.cshtml"
using PIMOITO;

#line default
#line hidden
#line 2 "C:\Users\letic\OneDrive\Área de Trabalho\Nova pasta (2)\PROJETOSDAFACUL\NovoPIM8-20230318T203741Z-001\NovoPIM8\PIMOITO\PIMOITO\Views\_ViewImports.cshtml"
using PIMOITO.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"790881d512e929fbc8fa46fa4deea03eae68141e789adfde346dc08cd86ec442", @"/Views/Pessoas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"9e82f9b735e29b143e33025d2e2fbe5e1d85faec03326de8ef181935968c4c07", @"/Views/_ViewImports.cshtml")]
    public class Views_Pessoas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PIMOITO.Models.Pessoa>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\letic\OneDrive\Área de Trabalho\Nova pasta (2)\PROJETOSDAFACUL\NovoPIM8-20230318T203741Z-001\NovoPIM8\PIMOITO\PIMOITO\Views\Pessoas\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(86, 16, true);
            WriteLiteral("<br/>\r\n<p>\r\n    ");
            EndContext();
            BeginContext(102, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "790881d512e929fbc8fa46fa4deea03eae68141e789adfde346dc08cd86ec4426243", async() => {
                BeginContext(149, 26, true);
                WriteLiteral("Cadasdrar novo Agendamento");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(179, 211, true);
            WriteLiteral("\r\n</p>\r\n<br />\r\n<h1 class=\"display-4\">Listagem de Agendamento</h1>\r\n<br />\r\n<br />\r\n<table class=\"table table-striped table-hover\">\r\n    <thead>\r\n        <tr class=\"success\">\r\n            <th >\r\n                ");
            EndContext();
            BeginContext(391, 40, false);
#line 18 "C:\Users\letic\OneDrive\Área de Trabalho\Nova pasta (2)\PROJETOSDAFACUL\NovoPIM8-20230318T203741Z-001\NovoPIM8\PIMOITO\PIMOITO\Views\Pessoas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(431, 56, true);
            WriteLiteral("\r\n            </th>\r\n            <th >\r\n                ");
            EndContext();
            BeginContext(488, 39, false);
#line 21 "C:\Users\letic\OneDrive\Área de Trabalho\Nova pasta (2)\PROJETOSDAFACUL\NovoPIM8-20230318T203741Z-001\NovoPIM8\PIMOITO\PIMOITO\Views\Pessoas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cpf));

#line default
#line hidden
            EndContext();
            BeginContext(527, 56, true);
            WriteLiteral("\r\n            </th>\r\n            <th >\r\n                ");
            EndContext();
            BeginContext(584, 44, false);
#line 24 "C:\Users\letic\OneDrive\Área de Trabalho\Nova pasta (2)\PROJETOSDAFACUL\NovoPIM8-20230318T203741Z-001\NovoPIM8\PIMOITO\PIMOITO\Views\Pessoas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Endereco));

#line default
#line hidden
            EndContext();
            BeginContext(628, 56, true);
            WriteLiteral("\r\n            </th>\r\n            <th >\r\n                ");
            EndContext();
            BeginContext(685, 45, false);
#line 27 "C:\Users\letic\OneDrive\Área de Trabalho\Nova pasta (2)\PROJETOSDAFACUL\NovoPIM8-20230318T203741Z-001\NovoPIM8\PIMOITO\PIMOITO\Views\Pessoas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Telefones));

#line default
#line hidden
            EndContext();
            BeginContext(730, 99, true);
            WriteLiteral("\r\n            </th>\r\n            <th ></th>            \r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 33 "C:\Users\letic\OneDrive\Área de Trabalho\Nova pasta (2)\PROJETOSDAFACUL\NovoPIM8-20230318T203741Z-001\NovoPIM8\PIMOITO\PIMOITO\Views\Pessoas\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(878, 61, true);
            WriteLiteral("            <tr>\r\n                <td >\r\n                    ");
            EndContext();
            BeginContext(940, 39, false);
#line 37 "C:\Users\letic\OneDrive\Área de Trabalho\Nova pasta (2)\PROJETOSDAFACUL\NovoPIM8-20230318T203741Z-001\NovoPIM8\PIMOITO\PIMOITO\Views\Pessoas\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(979, 68, true);
            WriteLiteral("\r\n                </td>\r\n                <td >\r\n                    ");
            EndContext();
            BeginContext(1048, 38, false);
#line 40 "C:\Users\letic\OneDrive\Área de Trabalho\Nova pasta (2)\PROJETOSDAFACUL\NovoPIM8-20230318T203741Z-001\NovoPIM8\PIMOITO\PIMOITO\Views\Pessoas\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Cpf));

#line default
#line hidden
            EndContext();
            BeginContext(1086, 68, true);
            WriteLiteral("\r\n                </td>\r\n                <td >\r\n                    ");
            EndContext();
            BeginContext(1155, 43, false);
#line 43 "C:\Users\letic\OneDrive\Área de Trabalho\Nova pasta (2)\PROJETOSDAFACUL\NovoPIM8-20230318T203741Z-001\NovoPIM8\PIMOITO\PIMOITO\Views\Pessoas\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Endereco));

#line default
#line hidden
            EndContext();
            BeginContext(1198, 68, true);
            WriteLiteral("\r\n                </td>\r\n                <td >\r\n                    ");
            EndContext();
            BeginContext(1267, 44, false);
#line 46 "C:\Users\letic\OneDrive\Área de Trabalho\Nova pasta (2)\PROJETOSDAFACUL\NovoPIM8-20230318T203741Z-001\NovoPIM8\PIMOITO\PIMOITO\Views\Pessoas\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Telefones));

#line default
#line hidden
            EndContext();
            BeginContext(1311, 68, true);
            WriteLiteral("\r\n                </td>\r\n                <td >\r\n                    ");
            EndContext();
            BeginContext(1379, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "790881d512e929fbc8fa46fa4deea03eae68141e789adfde346dc08cd86ec44212438", async() => {
                BeginContext(1462, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 49 "C:\Users\letic\OneDrive\Área de Trabalho\Nova pasta (2)\PROJETOSDAFACUL\NovoPIM8-20230318T203741Z-001\NovoPIM8\PIMOITO\PIMOITO\Views\Pessoas\Index.cshtml"
                                                                                 WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1472, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1494, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "790881d512e929fbc8fa46fa4deea03eae68141e789adfde346dc08cd86ec44215094", async() => {
                BeginContext(1578, 7, true);
                WriteLiteral("Deletar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 50 "C:\Users\letic\OneDrive\Área de Trabalho\Nova pasta (2)\PROJETOSDAFACUL\NovoPIM8-20230318T203741Z-001\NovoPIM8\PIMOITO\PIMOITO\Views\Pessoas\Index.cshtml"
                                                                                  WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1589, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 53 "C:\Users\letic\OneDrive\Área de Trabalho\Nova pasta (2)\PROJETOSDAFACUL\NovoPIM8-20230318T203741Z-001\NovoPIM8\PIMOITO\PIMOITO\Views\Pessoas\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1644, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PIMOITO.Models.Pessoa>> Html { get; private set; }
    }
}
#pragma warning restore 1591
