#pragma checksum "C:\Users\fatma\source\repos\CASGEM_Full-Stack-Developer-Bootcamp_E-commerce_Project\CasgemCoreProject\Pizzapan.PresentationLayer\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9608765862d403900344c9873709435521ba025f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
#line 1 "C:\Users\fatma\source\repos\CASGEM_Full-Stack-Developer-Bootcamp_E-commerce_Project\CasgemCoreProject\Pizzapan.PresentationLayer\Views\_ViewImports.cshtml"
using Pizzapan.PresentationLayer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fatma\source\repos\CASGEM_Full-Stack-Developer-Bootcamp_E-commerce_Project\CasgemCoreProject\Pizzapan.PresentationLayer\Views\_ViewImports.cshtml"
using Pizzapan.PresentationLayer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\fatma\source\repos\CASGEM_Full-Stack-Developer-Bootcamp_E-commerce_Project\CasgemCoreProject\Pizzapan.PresentationLayer\Views\_ViewImports.cshtml"
using Pizzapan.EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9608765862d403900344c9873709435521ba025f", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c97a275bb53c7928b1511a78a75d5523dc495de6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Contact>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\fatma\source\repos\CASGEM_Full-Stack-Developer-Bootcamp_E-commerce_Project\CasgemCoreProject\Pizzapan.PresentationLayer\Views\Contact\Index.cshtml"
   
   ViewData["Title"] = "Index";
   Layout = "~/Views/Shared/_AdminLayout.cshtml";
   int count = 0; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Gelen Mesajlar</h1>\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Gönderen</th>\r\n        <th>Konu</th>\r\n        <th>Tarih</th>\r\n        <th>Mesajı Sil</th>\r\n        <th>Mesajı Gör</th>\r\n    </tr>\r\n");
#nullable restore
#line 19 "C:\Users\fatma\source\repos\CASGEM_Full-Stack-Developer-Bootcamp_E-commerce_Project\CasgemCoreProject\Pizzapan.PresentationLayer\Views\Contact\Index.cshtml"
     foreach (var item in Model)
    {
        count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 23 "C:\Users\fatma\source\repos\CASGEM_Full-Stack-Developer-Bootcamp_E-commerce_Project\CasgemCoreProject\Pizzapan.PresentationLayer\Views\Contact\Index.cshtml"
   Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 24 "C:\Users\fatma\source\repos\CASGEM_Full-Stack-Developer-Bootcamp_E-commerce_Project\CasgemCoreProject\Pizzapan.PresentationLayer\Views\Contact\Index.cshtml"
   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 25 "C:\Users\fatma\source\repos\CASGEM_Full-Stack-Developer-Bootcamp_E-commerce_Project\CasgemCoreProject\Pizzapan.PresentationLayer\Views\Contact\Index.cshtml"
   Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 26 "C:\Users\fatma\source\repos\CASGEM_Full-Stack-Developer-Bootcamp_E-commerce_Project\CasgemCoreProject\Pizzapan.PresentationLayer\Views\Contact\Index.cshtml"
    Write(((DateTime)item.SendDateMessage).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 597, "\"", 642, 2);
            WriteAttributeValue("", 604, "/Contact/DeleteContact/", 604, 23, true);
#nullable restore
#line 27 "C:\Users\fatma\source\repos\CASGEM_Full-Stack-Developer-Bootcamp_E-commerce_Project\CasgemCoreProject\Pizzapan.PresentationLayer\Views\Contact\Index.cshtml"
WriteAttributeValue("", 627, item.ContactID, 627, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Mesajı Sil</a></td>\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 706, "\"", 759, 2);
            WriteAttributeValue("", 713, "/Contact/MessageDetailsContact/", 713, 31, true);
#nullable restore
#line 28 "C:\Users\fatma\source\repos\CASGEM_Full-Stack-Developer-Bootcamp_E-commerce_Project\CasgemCoreProject\Pizzapan.PresentationLayer\Views\Contact\Index.cshtml"
WriteAttributeValue("", 744, item.ContactID, 744, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Mesajı Gör</a></td>\r\n</tr>");
#nullable restore
#line 29 "C:\Users\fatma\source\repos\CASGEM_Full-Stack-Developer-Bootcamp_E-commerce_Project\CasgemCoreProject\Pizzapan.PresentationLayer\Views\Contact\Index.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</table>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Contact>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
