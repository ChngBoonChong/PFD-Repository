#pragma checksum "C:\Users\User\OneDrive\School\4. PFD\PFD-Repository\.vs\HawkerCornerApp\HawkerCorner_App\HawkerCorner_App\Views\Menu\OrderAwait.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e874e31f29da23d2f6d63c3fb3f37642022cb7be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menu_OrderAwait), @"mvc.1.0.view", @"/Views/Menu/OrderAwait.cshtml")]
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
#line 1 "C:\Users\User\OneDrive\School\4. PFD\PFD-Repository\.vs\HawkerCornerApp\HawkerCorner_App\HawkerCorner_App\Views\_ViewImports.cshtml"
using HawkerCorner_App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\OneDrive\School\4. PFD\PFD-Repository\.vs\HawkerCornerApp\HawkerCorner_App\HawkerCorner_App\Views\_ViewImports.cshtml"
using HawkerCorner_App.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\OneDrive\School\4. PFD\PFD-Repository\.vs\HawkerCornerApp\HawkerCorner_App\HawkerCorner_App\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e874e31f29da23d2f6d63c3fb3f37642022cb7be", @"/Views/Menu/OrderAwait.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bd382dbbb01f196531f9ba992bf45c36ce58bf6", @"/Views/_ViewImports.cshtml")]
    public class Views_Menu_OrderAwait : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\User\OneDrive\School\4. PFD\PFD-Repository\.vs\HawkerCornerApp\HawkerCorner_App\HawkerCorner_App\Views\Menu\OrderAwait.cshtml"
  
    ViewData["Title"] = "OrderAwait";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .bg {
        position: absolute;
        height: 93%;
        width: 82%;
        right: 0%;
        flex-shrink: 0;
        min-width: 100%;
        min-height: 100%
    }

    .front {
        font-family: Montserrat;
        color: black;
    }
</style>





");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e874e31f29da23d2f6d63c3fb3f37642022cb7be4236", async() => {
                WriteLiteral("\r\n    <meta http-equiv=\"refresh\" content=\"10;url=https://localhost:44339/menu\" />\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e874e31f29da23d2f6d63c3fb3f37642022cb7be5289", async() => {
                WriteLiteral(@"
    <img style=""z-index:-5;"" class=""bg"" src=""/images/general bg.png"">
    <div class=""front"">
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <h1 style=""text-align:center""><span style=""background-color: #FFFF00"">Thank you for your order!</span></h1>
        <h3 style=""text-align:center"">
            Your Order will take a while as we are looking for a Deliverer for your order!
            Do browse our catalog while waiting. Thank you for staying with Hawker Corner!
        </h3>
        <br />
        <h4 style=""text-align:center"">
            Redirecting in 10 seconds...
        </h4>
    </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
