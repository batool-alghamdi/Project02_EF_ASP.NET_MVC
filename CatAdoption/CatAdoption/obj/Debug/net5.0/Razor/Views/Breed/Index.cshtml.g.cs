#pragma checksum "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\CatAdoption\CatAdoption\Views\Breed\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a1065d4411d6168ffaf471452ae12992d90dce9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Breed_Index), @"mvc.1.0.view", @"/Views/Breed/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a1065d4411d6168ffaf471452ae12992d90dce9", @"/Views/Breed/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec3043597338fa28041c6a696b34f7431d739c64", @"/Views/_ViewImports.cshtml")]
    public class Views_Breed_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\CatAdoption\CatAdoption\Views\Breed\Index.cshtml"
   var breed = (List<BreedModel>)ViewData["Breeds"]; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"container ml-5 pl-5\">\n    <div class=\"row\">\n");
#nullable restore
#line 5 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\CatAdoption\CatAdoption\Views\Breed\Index.cshtml"
 foreach (var b in breed)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card bg-light box-shadow mr-5 mt-2\" style=\"width: 18rem;\">\n        <div class=\"card-body\">\n            <img class=\"card-img-top \"");
            BeginWriteAttribute("src", " src=\"", 285, "\"", 299, 1);
#nullable restore
#line 9 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\CatAdoption\CatAdoption\Views\Breed\Index.cshtml"
WriteAttributeValue("", 291, b.image, 291, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\n            <h5 class=\"card-title\">");
#nullable restore
#line 10 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\CatAdoption\CatAdoption\Views\Breed\Index.cshtml"
                              Write(b.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n            <p class=\"card-text\"> ");
#nullable restore
#line 11 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\CatAdoption\CatAdoption\Views\Breed\Index.cshtml"
                             Write(b.overview);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <a");
            BeginWriteAttribute("href", " href=\"", 435, "\"", 462, 2);
            WriteAttributeValue("", 442, "/Breed/Details/", 442, 15, true);
#nullable restore
#line 12 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\CatAdoption\CatAdoption\Views\Breed\Index.cshtml"
WriteAttributeValue("", 457, b.id, 457, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button type=\"button\" class=\"btn btn-info\">More Info</button></a>\n        </div>\n    </div>\n");
#nullable restore
#line 15 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\CatAdoption\CatAdoption\Views\Breed\Index.cshtml"
 }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>");
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
