#pragma checksum "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\CatAdoption\CatAdoption\Views\Breed\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c6293aae608297d32135e0e296564030dc87311"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Breed_Details), @"mvc.1.0.view", @"/Views/Breed/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c6293aae608297d32135e0e296564030dc87311", @"/Views/Breed/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec3043597338fa28041c6a696b34f7431d739c64", @"/Views/_ViewImports.cshtml")]
    public class Views_Breed_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\CatAdoption\CatAdoption\Views\Breed\Details.cshtml"
   var b = (BreedModel)ViewData["breed"]; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-sm-6\">\n    <div class=\"card\" style=\"width:40em\">\n        <div class=\"card-body\">\n            <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 178, "\"", 192, 1);
#nullable restore
#line 5 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\CatAdoption\CatAdoption\Views\Breed\Details.cshtml"
WriteAttributeValue("", 184, b.image, 184, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\n            <h5 class=\"card-title\">");
#nullable restore
#line 6 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\CatAdoption\CatAdoption\Views\Breed\Details.cshtml"
                              Write(b.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n            <h5 class=\"font-weight-bold\">overview:</h5>\n            <p class=\"card-text\"> ");
#nullable restore
#line 8 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\CatAdoption\CatAdoption\Views\Breed\Details.cshtml"
                             Write(b.overview);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <h5 class=\"font-weight-bold\">personality:</h5>\n            <p class=\"card-text align-content-center\">  ");
#nullable restore
#line 10 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\CatAdoption\CatAdoption\Views\Breed\Details.cshtml"
                                                   Write(b.personality);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <h5 class=\"font-weight-bold\">grooming:</h5>\n            <p class=\"card-text\">  ");
#nullable restore
#line 12 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\CatAdoption\CatAdoption\Views\Breed\Details.cshtml"
                              Write(b.grooming);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n        </div>\n    </div>\n</div>\n");
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
