#pragma checksum "C:\Users\tonin\OneDrive\Desktop\provjera\Mono-Project\ProjectMonoMVC\Views\VehicleModel\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04cf3fca276b873229263aa9c2be62de32629ab6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_VehicleModel_Delete), @"mvc.1.0.view", @"/Views/VehicleModel/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/VehicleModel/Delete.cshtml", typeof(AspNetCore.Views_VehicleModel_Delete))]
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
#line 1 "C:\Users\tonin\OneDrive\Desktop\provjera\Mono-Project\ProjectMonoMVC\Views\_ViewImports.cshtml"
using ProjectMonoMVC;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04cf3fca276b873229263aa9c2be62de32629ab6", @"/Views/VehicleModel/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"072c77f3b3746dae5b75b9fb72746493ac644bf9", @"/Views/_ViewImports.cshtml")]
    public class Views_VehicleModel_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectMonoMVC.ViewModels.VehicleModelView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("DeleteConfirmed"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\tonin\OneDrive\Desktop\provjera\Mono-Project\ProjectMonoMVC\Views\VehicleModel\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(89, 104, true);
            WriteLiteral("\n<h2>Are you sure that you want to delete this Model:</h2>\n<dl class=\"dl-horizontal\">\n\n    <dt>\n        ");
            EndContext();
            BeginContext(194, 52, false);
#line 10 "C:\Users\tonin\OneDrive\Desktop\provjera\Mono-Project\ProjectMonoMVC\Views\VehicleModel\Delete.cshtml"
   Write(Html.DisplayNameFor(model => model.VehicleMake.Name));

#line default
#line hidden
            EndContext();
            BeginContext(246, 28, true);
            WriteLiteral("\n    </dt>\n    <dd>\n        ");
            EndContext();
            BeginContext(275, 48, false);
#line 13 "C:\Users\tonin\OneDrive\Desktop\provjera\Mono-Project\ProjectMonoMVC\Views\VehicleModel\Delete.cshtml"
   Write(Html.DisplayFor(model => model.VehicleMake.Name));

#line default
#line hidden
            EndContext();
            BeginContext(323, 29, true);
            WriteLiteral("\n    </dd>\n\n    <dt>\n        ");
            EndContext();
            BeginContext(353, 45, false);
#line 17 "C:\Users\tonin\OneDrive\Desktop\provjera\Mono-Project\ProjectMonoMVC\Views\VehicleModel\Delete.cshtml"
   Write(Html.DisplayNameFor(model => model.ModelName));

#line default
#line hidden
            EndContext();
            BeginContext(398, 28, true);
            WriteLiteral("\n    </dt>\n    <dd>\n        ");
            EndContext();
            BeginContext(427, 41, false);
#line 20 "C:\Users\tonin\OneDrive\Desktop\provjera\Mono-Project\ProjectMonoMVC\Views\VehicleModel\Delete.cshtml"
   Write(Html.DisplayFor(model => model.ModelName));

#line default
#line hidden
            EndContext();
            BeginContext(468, 29, true);
            WriteLiteral("\n    </dd>\n\n    <dt>\n        ");
            EndContext();
            BeginContext(498, 40, false);
#line 24 "C:\Users\tonin\OneDrive\Desktop\provjera\Mono-Project\ProjectMonoMVC\Views\VehicleModel\Delete.cshtml"
   Write(Html.DisplayNameFor(model => model.Abrv));

#line default
#line hidden
            EndContext();
            BeginContext(538, 28, true);
            WriteLiteral("\n    </dt>\n    <dd>\n        ");
            EndContext();
            BeginContext(567, 36, false);
#line 27 "C:\Users\tonin\OneDrive\Desktop\provjera\Mono-Project\ProjectMonoMVC\Views\VehicleModel\Delete.cshtml"
   Write(Html.DisplayFor(model => model.Abrv));

#line default
#line hidden
            EndContext();
            BeginContext(603, 17, true);
            WriteLiteral("\n    </dd>\n</dl>\n");
            EndContext();
            BeginContext(620, 354, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d738f6617be4d3fadaf0f6ca0649fd7", async() => {
                BeginContext(689, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(695, 23, false);
#line 31 "C:\Users\tonin\OneDrive\Desktop\provjera\Mono-Project\ProjectMonoMVC\Views\VehicleModel\Delete.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(718, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(723, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f36aba15271e4405bc4cfe98a903ae77", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 32 "C:\Users\tonin\OneDrive\Desktop\provjera\Mono-Project\ProjectMonoMVC\Views\VehicleModel\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(759, 140, true);
                WriteLiteral("\n    <div class=\"box-footer\">\n        <div>\n            <button type=\"submit\" class=\"btn btn-info pull-right\">Delete</button> |\n            ");
                EndContext();
                BeginContext(900, 40, false);
#line 36 "C:\Users\tonin\OneDrive\Desktop\provjera\Mono-Project\ProjectMonoMVC\Views\VehicleModel\Delete.cshtml"
       Write(Html.ActionLink("Back To List", "Index"));

#line default
#line hidden
                EndContext();
                BeginContext(940, 27, true);
                WriteLiteral("\n        </div>\n    </div>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(974, 1, true);
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectMonoMVC.ViewModels.VehicleModelView> Html { get; private set; }
    }
}
#pragma warning restore 1591
