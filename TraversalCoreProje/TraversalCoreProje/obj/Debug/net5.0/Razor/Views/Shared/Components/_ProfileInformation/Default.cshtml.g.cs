#pragma checksum "C:\Users\FURKAN BAYRAM\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_ProfileInformation\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2919e81a85fae07bad0780831ba080abbe9b4d45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__ProfileInformation_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_ProfileInformation/Default.cshtml")]
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
#line 1 "C:\Users\FURKAN BAYRAM\source\repos\TraversalCoreProje\TraversalCoreProje\Views\_ViewImports.cshtml"
using TraversalCoreProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\FURKAN BAYRAM\source\repos\TraversalCoreProje\TraversalCoreProje\Views\_ViewImports.cshtml"
using TraversalCoreProje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\FURKAN BAYRAM\source\repos\TraversalCoreProje\TraversalCoreProje\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2919e81a85fae07bad0780831ba080abbe9b4d45", @"/Views/Shared/Components/_ProfileInformation/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a51958c9bf37a05153a1f850f6d853d08112d134", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components__ProfileInformation_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""col-12 col-xl-4"">
    <div class=""card h-100"">
        <div class=""card-header pb-0 p-3"">
            <div class=""row"">
                <div class=""col-md-8 d-flex align-items-center"">
                    <h6 class=""mb-0"">Profil Bilgileri</h6>
                </div>
                <div class=""col-md-4 text-end"">
                    <a href=""/Member/Profile/Index/"">
                        <i class=""fas fa-user-edit text-secondary text-sm"" data-bs-toggle=""tooltip"" data-bs-placement=""top"" title=""Edit Profile""></i>
                    </a>
                </div>
            </div>
        </div>
        <div class=""card-body p-3"">
            <p class=""text-sm"">
             SporDay rezervasyon paneline hoşgeldiniz,sol tarafta bulunanmenüler üzerinden geçmiş rezervasyonlarınızı aktif rezervasyonlarınızı,onaylanmayan rezervasyonlarınız ve iletişim bilgilerini görebilirsiniz.
            </p>
            <hr class=""horizontal gray-light my-4"">
            <ul class=""list-group"">
  ");
            WriteLiteral("              <li class=\"list-group-item border-0 ps-0 pt-0 text-sm\"><strong class=\"text-dark\">Ad Soyad:</strong> &nbsp; ");
#nullable restore
#line 21 "C:\Users\FURKAN BAYRAM\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_ProfileInformation\Default.cshtml"
                                                                                                                      Write(ViewBag.MemberName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"list-group-item border-0 ps-0 text-sm\"><strong class=\"text-dark\">Telefon:</strong> &nbsp;  ");
#nullable restore
#line 22 "C:\Users\FURKAN BAYRAM\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_ProfileInformation\Default.cshtml"
                                                                                                                 Write(ViewBag.memberPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"list-group-item border-0 ps-0 text-sm\"><strong class=\"text-dark\">Mail:</strong> &nbsp;  ");
#nullable restore
#line 23 "C:\Users\FURKAN BAYRAM\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_ProfileInformation\Default.cshtml"
                                                                                                              Write(ViewBag.memberMail);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                <li class=""list-group-item border-0 ps-0 text-sm""><strong class=""text-dark"">Konum:</strong> &nbsp; Türkiye</li>
                <li class=""list-group-item border-0 ps-0 pb-0"">
                    <strong class=""text-dark text-sm"">Sosyal Medya:</strong> &nbsp;
                    <a class=""btn btn-facebook btn-simple mb-0 ps-1 pe-2 py-0"" href=""javascript:;"">
                        <i class=""fab fa-facebook fa-lg""></i>
                    </a>
                    <a class=""btn btn-twitter btn-simple mb-0 ps-1 pe-2 py-0"" href=""javascript:;"">
                        <i class=""fab fa-twitter fa-lg""></i>
                    </a>
                    <a class=""btn btn-instagram btn-simple mb-0 ps-1 pe-2 py-0"" href=""javascript:;"">
                        <i class=""fab fa-instagram fa-lg""></i>
                    </a>
                </li>
            </ul>
        </div>
    </div>
</div>");
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
