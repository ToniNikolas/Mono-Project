#pragma checksum "C:\Users\tonin\OneDrive\Desktop\provjera\Mono-Project-master\ProjectMonoMVC\Views\VehicleModel\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7246e5fdd09d05dedbe4848bd16b3edd265c5472"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_VehicleModel_Details), @"mvc.1.0.view", @"/Views/VehicleModel/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/VehicleModel/Details.cshtml", typeof(AspNetCore.Views_VehicleModel_Details))]
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
#line 1 "C:\Users\tonin\OneDrive\Desktop\provjera\Mono-Project-master\ProjectMonoMVC\Views\_ViewImports.cshtml"
using ProjectMonoMVC;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7246e5fdd09d05dedbe4848bd16b3edd265c5472", @"/Views/VehicleModel/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"072c77f3b3746dae5b75b9fb72746493ac644bf9", @"/Views/_ViewImports.cshtml")]
    public class Views_VehicleModel_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectMonoMVC.ViewModels.VehicleModelView>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\tonin\OneDrive\Desktop\provjera\Mono-Project-master\ProjectMonoMVC\Views\VehicleModel\Details.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
            BeginContext(89, 62, true);
            WriteLiteral("\n<h2>Details</h2>\n<dl class=\"dl-horizontal\">\n    <dt>\n        ");
            EndContext();
            BeginContext(152, 52, false);
#line 9 "C:\Users\tonin\OneDrive\Desktop\provjera\Mono-Project-master\ProjectMonoMVC\Views\VehicleModel\Details.cshtml"
   Write(Html.DisplayNameFor(model => model.VehicleMake.Name));

#line default
#line hidden
            EndContext();
            BeginContext(204, 28, true);
            WriteLiteral("\n    </dt>\n    <dd>\n        ");
            EndContext();
            BeginContext(233, 48, false);
#line 12 "C:\Users\tonin\OneDrive\Desktop\provjera\Mono-Project-master\ProjectMonoMVC\Views\VehicleModel\Details.cshtml"
   Write(Html.DisplayFor(model => model.VehicleMake.Name));

#line default
#line hidden
            EndContext();
            BeginContext(281, 29, true);
            WriteLiteral("\n    </dd>\n\n    <dt>\n        ");
            EndContext();
            BeginContext(311, 45, false);
#line 16 "C:\Users\tonin\OneDrive\Desktop\provjera\Mono-Project-master\ProjectMonoMVC\Views\VehicleModel\Details.cshtml"
   Write(Html.DisplayNameFor(model => model.ModelName));

#line default
#line hidden
            EndContext();
            BeginContext(356, 28, true);
            WriteLiteral("\n    </dt>\n    <dd>\n        ");
            EndContext();
            BeginContext(385, 41, false);
#line 19 "C:\Users\tonin\OneDrive\Desktop\provjera\Mono-Project-master\ProjectMonoMVC\Views\VehicleModel\Details.cshtml"
   Write(Html.DisplayFor(model => model.ModelName));

#line default
#line hidden
            EndContext();
            BeginContext(426, 29, true);
            WriteLiteral("\n    </dd>\n\n    <dt>\n        ");
            EndContext();
            BeginContext(456, 40, false);
#line 23 "C:\Users\tonin\OneDrive\Desktop\provjera\Mono-Project-master\ProjectMonoMVC\Views\VehicleModel\Details.cshtml"
   Write(Html.DisplayNameFor(model => model.Abrv));

#line default
#line hidden
            EndContext();
            BeginContext(496, 28, true);
            WriteLiteral("\n    </dt>\n    <dd>\n        ");
            EndContext();
            BeginContext(525, 36, false);
#line 26 "C:\Users\tonin\OneDrive\Desktop\provjera\Mono-Project-master\ProjectMonoMVC\Views\VehicleModel\Details.cshtml"
   Write(Html.DisplayFor(model => model.Abrv));

#line default
#line hidden
            EndContext();
            BeginContext(561, 21, true);
            WriteLiteral("\n    </dd>\n</dl>\n\n\n\n\n");
            EndContext();
            BeginContext(583, 40, false);
#line 33 "C:\Users\tonin\OneDrive\Desktop\provjera\Mono-Project-master\ProjectMonoMVC\Views\VehicleModel\Details.cshtml"
Write(Html.ActionLink("Back To List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(623, 3, true);
            WriteLiteral(" |\n");
            EndContext();
            BeginContext(627, 54, false);
#line 34 "C:\Users\tonin\OneDrive\Desktop\provjera\Mono-Project-master\ProjectMonoMVC\Views\VehicleModel\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(681, 1, true);
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