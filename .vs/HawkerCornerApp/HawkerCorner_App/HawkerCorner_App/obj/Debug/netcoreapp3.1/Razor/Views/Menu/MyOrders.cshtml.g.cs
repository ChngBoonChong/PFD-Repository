#pragma checksum "E:\1) Ngee Ann Poly\Year 2 Sem 2\Portfolio Development\Latest Repo\.vs\HawkerCornerApp\HawkerCorner_App\HawkerCorner_App\Views\Menu\MyOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bd76b7160f3271cd7f87327747fa1cbe99c166a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menu_MyOrders), @"mvc.1.0.view", @"/Views/Menu/MyOrders.cshtml")]
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
#line 1 "E:\1) Ngee Ann Poly\Year 2 Sem 2\Portfolio Development\Latest Repo\.vs\HawkerCornerApp\HawkerCorner_App\HawkerCorner_App\Views\_ViewImports.cshtml"
using HawkerCorner_App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\1) Ngee Ann Poly\Year 2 Sem 2\Portfolio Development\Latest Repo\.vs\HawkerCornerApp\HawkerCorner_App\HawkerCorner_App\Views\_ViewImports.cshtml"
using HawkerCorner_App.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\1) Ngee Ann Poly\Year 2 Sem 2\Portfolio Development\Latest Repo\.vs\HawkerCornerApp\HawkerCorner_App\HawkerCorner_App\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bd76b7160f3271cd7f87327747fa1cbe99c166a", @"/Views/Menu/MyOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bd382dbbb01f196531f9ba992bf45c36ce58bf6", @"/Views/_ViewImports.cshtml")]
    public class Views_Menu_MyOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HawkerCorner_App.Models.FoodOrder>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\1) Ngee Ann Poly\Year 2 Sem 2\Portfolio Development\Latest Repo\.vs\HawkerCornerApp\HawkerCorner_App\HawkerCorner_App\Views\Menu\MyOrders.cshtml"
  
    ViewData["Title"] = "MyOrders";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<h1 style=\"text-align: center; \"><span style=\"background-color: #FFFF00\">My Orders</span></h1>\r\n<br />\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th style=\"width: 7%; text-align: center;\">\r\n                ");
#nullable restore
#line 13 "E:\1) Ngee Ann Poly\Year 2 Sem 2\Portfolio Development\Latest Repo\.vs\HawkerCornerApp\HawkerCorner_App\HawkerCorner_App\Views\Menu\MyOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th style=\"width: 7%; text-align: center;\">\r\n                ");
#nullable restore
#line 16 "E:\1) Ngee Ann Poly\Year 2 Sem 2\Portfolio Development\Latest Repo\.vs\HawkerCornerApp\HawkerCorner_App\HawkerCorner_App\Views\Menu\MyOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.UserID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th style=\"width: 10%; text-align: center;\">\r\n                ");
#nullable restore
#line 19 "E:\1) Ngee Ann Poly\Year 2 Sem 2\Portfolio Development\Latest Repo\.vs\HawkerCornerApp\HawkerCorner_App\HawkerCorner_App\Views\Menu\MyOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.DelivererID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th style=\"width: 7%; text-align: center;\">\r\n                ");
#nullable restore
#line 22 "E:\1) Ngee Ann Poly\Year 2 Sem 2\Portfolio Development\Latest Repo\.vs\HawkerCornerApp\HawkerCorner_App\HawkerCorner_App\Views\Menu\MyOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.StoreID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th style=\"width: 30%; text-align: left;\">\r\n                ");
#nullable restore
#line 25 "E:\1) Ngee Ann Poly\Year 2 Sem 2\Portfolio Development\Latest Repo\.vs\HawkerCornerApp\HawkerCorner_App\HawkerCorner_App\Views\Menu\MyOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th style=\"width: 20%; text-align: left;\">\r\n                ");
#nullable restore
#line 28 "E:\1) Ngee Ann Poly\Year 2 Sem 2\Portfolio Development\Latest Repo\.vs\HawkerCornerApp\HawkerCorner_App\HawkerCorner_App\Views\Menu\MyOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderList));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th style=\"width: 15%; text-align: left;\">\r\n                ");
#nullable restore
#line 31 "E:\1) Ngee Ann Poly\Year 2 Sem 2\Portfolio Development\Latest Repo\.vs\HawkerCornerApp\HawkerCorner_App\HawkerCorner_App\Views\Menu\MyOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th style=\"width: 15%; text-align: center;\">\r\n                ");
#nullable restore
#line 34 "E:\1) Ngee Ann Poly\Year 2 Sem 2\Portfolio Development\Latest Repo\.vs\HawkerCornerApp\HawkerCorner_App\HawkerCorner_App\Views\Menu\MyOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderConfirm));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th style=\"width: 15%; text-align: center;\">\r\n                ");
#nullable restore
#line 37 "E:\1) Ngee Ann Poly\Year 2 Sem 2\Portfolio Development\Latest Repo\.vs\HawkerCornerApp\HawkerCorner_App\HawkerCorner_App\Views\Menu\MyOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderComplete));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 43 "E:\1) Ngee Ann Poly\Year 2 Sem 2\Portfolio Development\Latest Repo\.vs\HawkerCornerApp\HawkerCorner_App\HawkerCorner_App\Views\Menu\MyOrders.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 47 "E:\1) Ngee Ann Poly\Year 2 Sem 2\Portfolio Development\Latest Repo\.vs\HawkerCornerApp\HawkerCorner_App\HawkerCorner_App\Views\Menu\MyOrders.cshtml"
               Write(Html.DisplayFor(modelItem => item.OrderID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 50 "E:\1) Ngee Ann Poly\Year 2 Sem 2\Portfolio Development\Latest Repo\.vs\HawkerCornerApp\HawkerCorner_App\HawkerCorner_App\Views\Menu\MyOrders.cshtml"
               Write(Html.DisplayFor(modelItem => item.UserID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 53 "E:\1) Ngee Ann Poly\Year 2 Sem 2\Portfolio Development\Latest Repo\.vs\HawkerCornerApp\HawkerCorner_App\HawkerCorner_App\Views\Menu\MyOrders.cshtml"
               Write(Html.DisplayFor(modelItem => item.DelivererID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 56 "E:\1) Ngee Ann Poly\Year 2 Sem 2\Portfolio Development\Latest Repo\.vs\HawkerCornerApp\HawkerCorner_App\HawkerCorner_App\Views\Menu\MyOrders.cshtml"
               Write(Html.DisplayFor(modelItem => item.StoreID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 59 "E:\1) Ngee Ann Poly\Year 2 Sem 2\Portfolio Development\Latest Repo\.vs\HawkerCornerApp\HawkerCorner_App\HawkerCorner_App\Views\Menu\MyOrders.cshtml"
               Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 62 "E:\1) Ngee Ann Poly\Year 2 Sem 2\Portfolio Development\Latest Repo\.vs\HawkerCornerApp\HawkerCorner_App\HawkerCorner_App\Views\Menu\MyOrders.cshtml"
               Write(Html.DisplayFor(modelItem => item.OrderList));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 65 "E:\1) Ngee Ann Poly\Year 2 Sem 2\Portfolio Development\Latest Repo\.vs\HawkerCornerApp\HawkerCorner_App\HawkerCorner_App\Views\Menu\MyOrders.cshtml"
               Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 68 "E:\1) Ngee Ann Poly\Year 2 Sem 2\Portfolio Development\Latest Repo\.vs\HawkerCornerApp\HawkerCorner_App\HawkerCorner_App\Views\Menu\MyOrders.cshtml"
               Write(Html.DisplayFor(modelItem => item.OrderConfirm));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 71 "E:\1) Ngee Ann Poly\Year 2 Sem 2\Portfolio Development\Latest Repo\.vs\HawkerCornerApp\HawkerCorner_App\HawkerCorner_App\Views\Menu\MyOrders.cshtml"
               Write(Html.DisplayFor(modelItem => item.OrderComplete));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 74 "E:\1) Ngee Ann Poly\Year 2 Sem 2\Portfolio Development\Latest Repo\.vs\HawkerCornerApp\HawkerCorner_App\HawkerCorner_App\Views\Menu\MyOrders.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HawkerCorner_App.Models.FoodOrder>> Html { get; private set; }
    }
}
#pragma warning restore 1591
