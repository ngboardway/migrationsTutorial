#pragma checksum "C:\Users\nboardwa\source\ContosoUniversity\ContosoUniversity\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a01b1bc1754478ae931daa2a8034a1f91f6bd353"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "C:\Users\nboardwa\source\ContosoUniversity\ContosoUniversity\Views\_ViewImports.cshtml"
using ContosoUniversity;

#line default
#line hidden
#line 2 "C:\Users\nboardwa\source\ContosoUniversity\ContosoUniversity\Views\_ViewImports.cshtml"
using ContosoUniversity.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a01b1bc1754478ae931daa2a8034a1f91f6bd353", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c8c63dad9db0b17e31c66667dec1a52add46bdf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ContosoUniversity.Models.SchoolViewModels.EnrollmentDateGroup>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(83, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\nboardwa\source\ContosoUniversity\ContosoUniversity\Views\Home\About.cshtml"
  
    ViewData["Title"] = "Student Body Statistics";

#line default
#line hidden
            BeginContext(144, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(149, 17, false);
#line 6 "C:\Users\nboardwa\source\ContosoUniversity\ContosoUniversity\Views\Home\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(166, 100, true);
            WriteLiteral("</h2>\r\n<table>\r\n    <tr>\r\n        <th>Enrollment Date</th>\r\n        <th>Students</th>\r\n    </tr>\r\n\r\n");
            EndContext();
#line 13 "C:\Users\nboardwa\source\ContosoUniversity\ContosoUniversity\Views\Home\About.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(307, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(338, 49, false);
#line 16 "C:\Users\nboardwa\source\ContosoUniversity\ContosoUniversity\Views\Home\About.cshtml"
           Write(Html.DisplayFor(modelItem => item.EnrollmentDate));

#line default
#line hidden
            EndContext();
            BeginContext(387, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(411, 17, false);
#line 17 "C:\Users\nboardwa\source\ContosoUniversity\ContosoUniversity\Views\Home\About.cshtml"
           Write(item.StudentCount);

#line default
#line hidden
            EndContext();
            BeginContext(428, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 19 "C:\Users\nboardwa\source\ContosoUniversity\ContosoUniversity\Views\Home\About.cshtml"

    }

#line default
#line hidden
            BeginContext(459, 12, true);
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ContosoUniversity.Models.SchoolViewModels.EnrollmentDateGroup>> Html { get; private set; }
    }
}
#pragma warning restore 1591
