#pragma checksum "/Users/Guest/Desktop/circlesapp/Views/Circles/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cce6e1ca12b43c11c2c0dfc0199e6410f4099254"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Circles_Details), @"mvc.1.0.view", @"/Views/Circles/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Circles/Details.cshtml", typeof(AspNetCore.Views_Circles_Details))]
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
#line 1 "/Users/Guest/Desktop/circlesapp/Views/_ViewImports.cshtml"
using Circles_MVC;

#line default
#line hidden
#line 2 "/Users/Guest/Desktop/circlesapp/Views/_ViewImports.cshtml"
using Circles_MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cce6e1ca12b43c11c2c0dfc0199e6410f4099254", @"/Views/Circles/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d864beb897ca847bc7b874ccfd52d6af1fe42f5", @"/Views/_ViewImports.cshtml")]
    public class Views_Circles_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Circles_MVC.Models.Circle>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/circlesapp/Views/Circles/Details.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(29, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(63, 36, true);
            WriteLiteral("\n<h2 class=\"categoryTitle\">Circle - ");
            EndContext();
            BeginContext(100, 10, false);
#line 7 "/Users/Guest/Desktop/circlesapp/Views/Circles/Details.cshtml"
                              Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(110, 127, true);
            WriteLiteral("</h2>\n\n\n<div class=\"container-fluid userprofileContainer\">\n    <div class=\"row d-flex justify-content-around userprofilesRow\">\n");
            EndContext();
#line 12 "/Users/Guest/Desktop/circlesapp/Views/Circles/Details.cshtml"
 foreach (var join in Model.Userprofiles)
{

#line default
#line hidden
            BeginContext(281, 52, true);
            WriteLiteral("    <div class=\"userprofileCol col-md-2\">\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 333, "\"", 422, 1);
#line 15 "/Users/Guest/Desktop/circlesapp/Views/Circles/Details.cshtml"
WriteAttributeValue("", 340, Url.Action("Details", "Userprofiles", new { id = join.Userprofile.UserprofileId}), 340, 82, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(423, 123, true);
            WriteLiteral("><div class=\"entireuserButton\">\n            <div class=\"userprofilesCircle\">\n                <div class=\"userprofilesPhoto\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 546, "\"", 600, 4);
            WriteAttributeValue("", 554, "background-image:", 554, 17, true);
            WriteAttributeValue(" ", 571, "url(", 572, 5, true);
#line 17 "/Users/Guest/Desktop/circlesapp/Views/Circles/Details.cshtml"
WriteAttributeValue("", 576, join.Userprofile.Photo, 576, 23, false);

#line default
#line hidden
            WriteAttributeValue("", 599, ")", 599, 1, true);
            EndWriteAttribute();
            BeginContext(601, 52, true);
            WriteLiteral("></div>\n                <p class=\"userprofilesName\">");
            EndContext();
            BeginContext(654, 21, false);
#line 18 "/Users/Guest/Desktop/circlesapp/Views/Circles/Details.cshtml"
                                       Write(join.Userprofile.Name);

#line default
#line hidden
            EndContext();
            BeginContext(675, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 19 "/Users/Guest/Desktop/circlesapp/Views/Circles/Details.cshtml"
                               using (Html.BeginForm("RemoveUser", "Circles"))
        {
            

#line default
#line hidden
            BeginContext(782, 48, false);
#line 21 "/Users/Guest/Desktop/circlesapp/Views/Circles/Details.cshtml"
       Write(Html.Hidden("joinId", @join.CircleUserprofileId));

#line default
#line hidden
            EndContext();
            BeginContext(844, 40, false);
#line 22 "/Users/Guest/Desktop/circlesapp/Views/Circles/Details.cshtml"
       Write(Html.Hidden("circleId", @Model.CircleId));

#line default
#line hidden
            EndContext();
            BeginContext(885, 98, true);
            WriteLiteral("            <input type=\"submit\" value=\"-\" class=\"button-styling-solid btn-danger deleteButton\"/>\n");
            EndContext();
#line 24 "/Users/Guest/Desktop/circlesapp/Views/Circles/Details.cshtml"
        }

#line default
#line hidden
            BeginContext(993, 57, true);
            WriteLiteral("            </div>\n\n        </div></a>\n      \n    </div>\n");
            EndContext();
#line 30 "/Users/Guest/Desktop/circlesapp/Views/Circles/Details.cshtml"
}

#line default
#line hidden
            BeginContext(1052, 103, true);
            WriteLiteral("</div>\n\n<div id=\"loginCircle2\"></div>\n<div id=\"landingCircle2\"></div>\n<div id=\"landingCircle3\"></div>\n\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Circles_MVC.Models.Circle> Html { get; private set; }
    }
}
#pragma warning restore 1591
