#pragma checksum "C:\Users\HelpDesk\Source\DevCard\DevCard\DevCard_MVC\Views\Home\Components\Projects\_Projects.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "509f06ab920184fd4dea293942e1c3d2206c22c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Components_Projects__Projects), @"mvc.1.0.view", @"/Views/Home/Components/Projects/_Projects.cshtml")]
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
#line 1 "C:\Users\HelpDesk\Source\DevCard\DevCard\DevCard_MVC\Views\_ViewImports.cshtml"
using DevCard_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HelpDesk\Source\DevCard\DevCard\DevCard_MVC\Views\_ViewImports.cshtml"
using DevCard_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"509f06ab920184fd4dea293942e1c3d2206c22c8", @"/Views/Home/Components/Projects/_Projects.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"520493a69a7d20751d0e9831363d66b394bf2f41", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Components_Projects__Projects : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Project>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<section class=\"featured-section p-3 p-lg-5\">\r\n    <div class=\"container\">\r\n        <h2 class=\"section-title font-weight-bold mb-5\">خاص ترین پروژه ها</h2>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 6 "C:\Users\HelpDesk\Source\DevCard\DevCard\DevCard_MVC\Views\Home\Components\Projects\_Projects.cshtml"
             foreach (var Projects in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-md-6 mb-5"">
                    <div class=""card project-card"">
                        <div class=""row no-gutters"">
                            <div class=""col-lg-4 card-img-holder"">
                                <img");
            BeginWriteAttribute("src", " src=\"", 529, "\"", 572, 2);
            WriteAttributeValue("", 535, "assets/images/project/", 535, 22, true);
#nullable restore
#line 12 "C:\Users\HelpDesk\Source\DevCard\DevCard\DevCard_MVC\Views\Home\Components\Projects\_Projects.cshtml"
WriteAttributeValue("", 557, Projects.Image, 557, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""card-img"" alt=""image"">
                            </div>
                            <div class=""col-lg-8"">
                                <div class=""card-body"">
                                    <h5 class=""card-title"">
                                        <a href=""project.html"" class=""theme-link"">
                                            ");
#nullable restore
#line 18 "C:\Users\HelpDesk\Source\DevCard\DevCard\DevCard_MVC\Views\Home\Components\Projects\_Projects.cshtml"
                                       Write(Projects.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </a>\r\n                                    </h5>\r\n                                    <p class=\"card-text\">\r\n                                        ");
#nullable restore
#line 22 "C:\Users\HelpDesk\Source\DevCard\DevCard\DevCard_MVC\Views\Home\Components\Projects\_Projects.cshtml"
                                   Write(Projects.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </p>\r\n                                    <p class=\"card-text\">\r\n                                        <small class=\"text-muted\">نام مشتری: ");
#nullable restore
#line 25 "C:\Users\HelpDesk\Source\DevCard\DevCard\DevCard_MVC\Views\Home\Components\Projects\_Projects.cshtml"
                                                                        Write(Projects.Client);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                    </p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 32 "C:\Users\HelpDesk\Source\DevCard\DevCard\DevCard_MVC\Views\Home\Components\Projects\_Projects.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Project>> Html { get; private set; }
    }
}
#pragma warning restore 1591
