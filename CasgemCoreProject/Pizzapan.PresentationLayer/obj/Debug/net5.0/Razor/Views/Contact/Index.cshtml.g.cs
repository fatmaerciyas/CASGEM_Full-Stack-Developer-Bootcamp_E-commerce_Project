#pragma checksum "C:\Users\fatma\source\repos\CasgemCoreProject\Pizzapan.PresentationLayer\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56a47251c50f277f92c18d6978fe12838e0acbd7"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56a47251c50f277f92c18d6978fe12838e0acbd7", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c97a275bb53c7928b1511a78a75d5523dc495de6", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Contact>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\fatma\source\repos\CasgemCoreProject\Pizzapan.PresentationLayer\Views\Contact\Index.cshtml"
   
   ViewData["Title"] = "Index";
   Layout = "~/Views/Shared/_AdminLayout.cshtml";
   int count = 0; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Gelen Mesajlar</h1>\n\n<table class=\"table table-bordered\">\n    <tr>\n        <th>#</th>\n        <th>Gönderen</th>\n        <th>Konu</th>\n        <th>Tarih</th>\n        <th>Mesajı Sil</th>\n        <th>Mesajı Gör</th>\n    </tr>\n");
#nullable restore
#line 19 "C:\Users\fatma\source\repos\CasgemCoreProject\Pizzapan.PresentationLayer\Views\Contact\Index.cshtml"
     foreach (var item in Model)
    {
        count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>");
#nullable restore
#line 23 "C:\Users\fatma\source\repos\CasgemCoreProject\Pizzapan.PresentationLayer\Views\Contact\Index.cshtml"
   Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 24 "C:\Users\fatma\source\repos\CasgemCoreProject\Pizzapan.PresentationLayer\Views\Contact\Index.cshtml"
   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 25 "C:\Users\fatma\source\repos\CasgemCoreProject\Pizzapan.PresentationLayer\Views\Contact\Index.cshtml"
   Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 26 "C:\Users\fatma\source\repos\CasgemCoreProject\Pizzapan.PresentationLayer\Views\Contact\Index.cshtml"
    Write(((DateTime)item.SendDateMessage).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 571, "\"", 616, 2);
            WriteAttributeValue("", 578, "/Contact/DeleteContact/", 578, 23, true);
#nullable restore
#line 27 "C:\Users\fatma\source\repos\CasgemCoreProject\Pizzapan.PresentationLayer\Views\Contact\Index.cshtml"
WriteAttributeValue("", 601, item.ContactID, 601, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Mesajı Sil</a></td>\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 679, "\"", 732, 2);
            WriteAttributeValue("", 686, "/Contact/MessageDetailsContact/", 686, 31, true);
#nullable restore
#line 28 "C:\Users\fatma\source\repos\CasgemCoreProject\Pizzapan.PresentationLayer\Views\Contact\Index.cshtml"
WriteAttributeValue("", 717, item.ContactID, 717, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Mesajı Gör</a></td>\n</tr>");
#nullable restore
#line 29 "C:\Users\fatma\source\repos\CasgemCoreProject\Pizzapan.PresentationLayer\Views\Contact\Index.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Contact>> Html { get; private set; }
    }
}
#pragma warning restore 1591
