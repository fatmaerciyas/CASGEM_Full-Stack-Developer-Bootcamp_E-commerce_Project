#pragma checksum "C:\Users\fatma\source\repos\CasgemCoreProject\Pizzapan.PresentationLayer\Views\Discount\DiscountCodeList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76af42e98358bbcb8640fb553afe6d12567f992d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Discount_DiscountCodeList), @"mvc.1.0.view", @"/Views/Discount/DiscountCodeList.cshtml")]
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
#line 1 "C:\Users\fatma\source\repos\CasgemCoreProject\Pizzapan.PresentationLayer\Views\_ViewImports.cshtml"
using Pizzapan.PresentationLayer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fatma\source\repos\CasgemCoreProject\Pizzapan.PresentationLayer\Views\_ViewImports.cshtml"
using Pizzapan.PresentationLayer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\fatma\source\repos\CasgemCoreProject\Pizzapan.PresentationLayer\Views\_ViewImports.cshtml"
using Pizzapan.EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76af42e98358bbcb8640fb553afe6d12567f992d", @"/Views/Discount/DiscountCodeList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c97a275bb53c7928b1511a78a75d5523dc495de6", @"/Views/_ViewImports.cshtml")]
    public class Views_Discount_DiscountCodeList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Discount>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\fatma\source\repos\CasgemCoreProject\Pizzapan.PresentationLayer\Views\Discount\DiscountCodeList.cshtml"
  
    ViewData["Title"] = "DiscountCodeList";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>İndirim Kodu Listesi</h1>\r\n\r\n<table class=\"table table-hover\">\r\n    <tr>\r\n        <th>İndirim Kodu</th>\r\n        <th>Kullanım Hakkı</th>\r\n        <th>Son Kullanma Tarihi</th>\r\n    </tr>\r\n");
#nullable restore
#line 15 "C:\Users\fatma\source\repos\CasgemCoreProject\Pizzapan.PresentationLayer\Views\Discount\DiscountCodeList.cshtml"
     foreach (var item in Model)
    {
        if (item.Final_Date < DateTime.Now)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr style=\"background-color: lightcoral\">\r\n                <td>");
#nullable restore
#line 20 "C:\Users\fatma\source\repos\CasgemCoreProject\Pizzapan.PresentationLayer\Views\Discount\DiscountCodeList.cshtml"
               Write(item.DiscountCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\fatma\source\repos\CasgemCoreProject\Pizzapan.PresentationLayer\Views\Discount\DiscountCodeList.cshtml"
               Write(item.DiscountCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\fatma\source\repos\CasgemCoreProject\Pizzapan.PresentationLayer\Views\Discount\DiscountCodeList.cshtml"
                Write(((DateTime)item.Final_Date).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 24 "C:\Users\fatma\source\repos\CasgemCoreProject\Pizzapan.PresentationLayer\Views\Discount\DiscountCodeList.cshtml"

        }

        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr style=\"background-color: cadetblue\">\r\n                <td>");
#nullable restore
#line 30 "C:\Users\fatma\source\repos\CasgemCoreProject\Pizzapan.PresentationLayer\Views\Discount\DiscountCodeList.cshtml"
               Write(item.DiscountCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\fatma\source\repos\CasgemCoreProject\Pizzapan.PresentationLayer\Views\Discount\DiscountCodeList.cshtml"
               Write(item.DiscountCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\fatma\source\repos\CasgemCoreProject\Pizzapan.PresentationLayer\Views\Discount\DiscountCodeList.cshtml"
                Write(((DateTime)item.Final_Date).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 34 "C:\Users\fatma\source\repos\CasgemCoreProject\Pizzapan.PresentationLayer\Views\Discount\DiscountCodeList.cshtml"

        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Discount>> Html { get; private set; }
    }
}
#pragma warning restore 1591