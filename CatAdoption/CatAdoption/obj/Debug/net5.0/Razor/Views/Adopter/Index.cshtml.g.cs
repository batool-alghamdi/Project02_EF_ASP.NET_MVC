#pragma checksum "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\CatAdoption\CatAdoption\Views\Adopter\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc9a15adac488b434cb1386d523051c7818ee1fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Adopter_Index), @"mvc.1.0.view", @"/Views/Adopter/Index.cshtml")]
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
#line 1 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\CatAdoption\CatAdoption\Views\_ViewImports.cshtml"
using CatAdoption;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\CatAdoption\CatAdoption\Views\_ViewImports.cshtml"
using CatAdoption.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc9a15adac488b434cb1386d523051c7818ee1fb", @"/Views/Adopter/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec3043597338fa28041c6a696b34f7431d739c64", @"/Views/_ViewImports.cshtml")]
    public class Views_Adopter_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\CatAdoption\CatAdoption\Views\Adopter\Index.cshtml"
   
    var a = (AdopterModel)ViewData["Adopter"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-sm-6\">\r\n\r\n    <div id=\"card\" class=\"card bg-light box-shadow mr-5 mt-2\" style=\"width: 18rem;\">\r\n        <div class=\"card-body\">\r\n            <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 240, "\"", 254, 1);
#nullable restore
#line 9 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\CatAdoption\CatAdoption\Views\Adopter\Index.cshtml"
WriteAttributeValue("", 246, a.image, 246, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n            <h5 class=\"card-title\">Adopter: ");
#nullable restore
#line 10 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\CatAdoption\CatAdoption\Views\Adopter\Index.cshtml"
                                       Write(a.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <h5 class=\"font-weight-bold\">Details:</h5>\r\n            <p class=\"card-text\"> phone: ");
#nullable restore
#line 12 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\CatAdoption\CatAdoption\Views\Adopter\Index.cshtml"
                                    Write(a.phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"card-text align-content-center\">  age: ");
#nullable restore
#line 13 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\CatAdoption\CatAdoption\Views\Adopter\Index.cshtml"
                                                        Write(a.age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"card-text\">  gender: ");
#nullable restore
#line 14 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\CatAdoption\CatAdoption\Views\Adopter\Index.cshtml"
                                      Write(a.gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"card-text\">  email: ");
#nullable restore
#line 15 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\CatAdoption\CatAdoption\Views\Adopter\Index.cshtml"
                                     Write(a.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
