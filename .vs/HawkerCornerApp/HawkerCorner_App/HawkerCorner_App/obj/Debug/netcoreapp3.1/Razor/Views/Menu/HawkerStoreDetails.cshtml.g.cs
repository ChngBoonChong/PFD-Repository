#pragma checksum "E:\1) Ngee Ann Poly\Year 2 Sem 2\Portfolio Development\Repo\PFD\HawkerCornerApp\HawkerCorner_App\HawkerCorner_App\Views\Menu\HawkerStoreDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c477339198a27601ffeec48ea37995af50f61bf8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menu_HawkerStoreDetails), @"mvc.1.0.view", @"/Views/Menu/HawkerStoreDetails.cshtml")]
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
#line 1 "E:\1) Ngee Ann Poly\Year 2 Sem 2\Portfolio Development\Repo\PFD\HawkerCornerApp\HawkerCorner_App\HawkerCorner_App\Views\_ViewImports.cshtml"
using HawkerCorner_App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\1) Ngee Ann Poly\Year 2 Sem 2\Portfolio Development\Repo\PFD\HawkerCornerApp\HawkerCorner_App\HawkerCorner_App\Views\_ViewImports.cshtml"
using HawkerCorner_App.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\1) Ngee Ann Poly\Year 2 Sem 2\Portfolio Development\Repo\PFD\HawkerCornerApp\HawkerCorner_App\HawkerCorner_App\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c477339198a27601ffeec48ea37995af50f61bf8", @"/Views/Menu/HawkerStoreDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bd382dbbb01f196531f9ba992bf45c36ce58bf6", @"/Views/_ViewImports.cshtml")]
    public class Views_Menu_HawkerStoreDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HawkerCorner_App.Models.HawkerStoreDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\1) Ngee Ann Poly\Year 2 Sem 2\Portfolio Development\Repo\PFD\HawkerCornerApp\HawkerCorner_App\HawkerCorner_App\Views\Menu\HawkerStoreDetails.cshtml"
  
    ViewData["Title"] = "HawkerStoreDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>HawkerStoreDetails</h1>\r\n\r\n<div>\r\n    <h4>HawkerStoreDetailsViewModel</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "E:\1) Ngee Ann Poly\Year 2 Sem 2\Portfolio Development\Repo\PFD\HawkerCornerApp\HawkerCorner_App\HawkerCorner_App\Views\Menu\HawkerStoreDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.CentreID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "E:\1) Ngee Ann Poly\Year 2 Sem 2\Portfolio Development\Repo\PFD\HawkerCornerApp\HawkerCorner_App\HawkerCorner_App\Views\Menu\HawkerStoreDetails.cshtml"
       Write(Html.DisplayFor(model => model.CentreID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "E:\1) Ngee Ann Poly\Year 2 Sem 2\Portfolio Development\Repo\PFD\HawkerCornerApp\HawkerCorner_App\HawkerCorner_App\Views\Menu\HawkerStoreDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.CentreName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "E:\1) Ngee Ann Poly\Year 2 Sem 2\Portfolio Development\Repo\PFD\HawkerCornerApp\HawkerCorner_App\HawkerCorner_App\Views\Menu\HawkerStoreDetails.cshtml"
       Write(Html.DisplayFor(model => model.CentreName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "E:\1) Ngee Ann Poly\Year 2 Sem 2\Portfolio Development\Repo\PFD\HawkerCornerApp\HawkerCorner_App\HawkerCorner_App\Views\Menu\HawkerStoreDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "E:\1) Ngee Ann Poly\Year 2 Sem 2\Portfolio Development\Repo\PFD\HawkerCornerApp\HawkerCorner_App\HawkerCorner_App\Views\Menu\HawkerStoreDetails.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "E:\1) Ngee Ann Poly\Year 2 Sem 2\Portfolio Development\Repo\PFD\HawkerCornerApp\HawkerCorner_App\HawkerCorner_App\Views\Menu\HawkerStoreDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.StoreID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "E:\1) Ngee Ann Poly\Year 2 Sem 2\Portfolio Development\Repo\PFD\HawkerCornerApp\HawkerCorner_App\HawkerCorner_App\Views\Menu\HawkerStoreDetails.cshtml"
       Write(Html.DisplayFor(model => model.StoreID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "E:\1) Ngee Ann Poly\Year 2 Sem 2\Portfolio Development\Repo\PFD\HawkerCornerApp\HawkerCorner_App\HawkerCorner_App\Views\Menu\HawkerStoreDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.AVGRating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "E:\1) Ngee Ann Poly\Year 2 Sem 2\Portfolio Development\Repo\PFD\HawkerCornerApp\HawkerCorner_App\HawkerCorner_App\Views\Menu\HawkerStoreDetails.cshtml"
       Write(Html.DisplayFor(model => model.AVGRating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "E:\1) Ngee Ann Poly\Year 2 Sem 2\Portfolio Development\Repo\PFD\HawkerCornerApp\HawkerCorner_App\HawkerCorner_App\Views\Menu\HawkerStoreDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.StoreName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "E:\1) Ngee Ann Poly\Year 2 Sem 2\Portfolio Development\Repo\PFD\HawkerCornerApp\HawkerCorner_App\HawkerCorner_App\Views\Menu\HawkerStoreDetails.cshtml"
       Write(Html.DisplayFor(model => model.StoreName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n");
            WriteLiteral("    </dl>\r\n");
            WriteLiteral("</div>\r\n<div>\r\n    ");
#nullable restore
#line 58 "E:\1) Ngee Ann Poly\Year 2 Sem 2\Portfolio Development\Repo\PFD\HawkerCornerApp\HawkerCorner_App\HawkerCorner_App\Views\Menu\HawkerStoreDetails.cshtml"
Write(Html.ActionLink("Order", "StartOrder", new { Model.StoreID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c477339198a27601ffeec48ea37995af50f61bf89493", async() => {
                WriteLiteral("Back to Store Listings");
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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HawkerCorner_App.Models.HawkerStoreDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
