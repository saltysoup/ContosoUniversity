#pragma checksum "C:\Users\ikwak\Code\dotnet\ContosoUniversity\ContosoUniversity\Views\Course\UpdateCourseCredits.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a66f1bf9c950f9934ab888dfd4864dc26a4d266e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_UpdateCourseCredits), @"mvc.1.0.view", @"/Views/Course/UpdateCourseCredits.cshtml")]
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
#line 1 "C:\Users\ikwak\Code\dotnet\ContosoUniversity\ContosoUniversity\Views\_ViewImports.cshtml"
using ContosoUniversity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a66f1bf9c950f9934ab888dfd4864dc26a4d266e", @"/Views/Course/UpdateCourseCredits.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0517e8f1158838f564b35006cc7a435c10838e54", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_UpdateCourseCredits : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContosoUniversity.Models.Course>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ikwak\Code\dotnet\ContosoUniversity\ContosoUniversity\Views\Course\UpdateCourseCredits.cshtml"
  
    ViewBag.Title = "UpdateCourseCredits";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Update Course Credits</h2>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\ikwak\Code\dotnet\ContosoUniversity\ContosoUniversity\Views\Course\UpdateCourseCredits.cshtml"
 if (ViewBag.RowsAffected == null)
{
    using (Html.BeginForm())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>\r\n            Enter a number to multiply every course\'s credits by: ");
#nullable restore
#line 14 "C:\Users\ikwak\Code\dotnet\ContosoUniversity\ContosoUniversity\Views\Course\UpdateCourseCredits.cshtml"
                                                             Write(Html.TextBox("multiplier"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n        <p>\r\n            <input type=\"submit\" value=\"Update\" />\r\n        </p>\r\n");
#nullable restore
#line 19 "C:\Users\ikwak\Code\dotnet\ContosoUniversity\ContosoUniversity\Views\Course\UpdateCourseCredits.cshtml"
    }
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\ikwak\Code\dotnet\ContosoUniversity\ContosoUniversity\Views\Course\UpdateCourseCredits.cshtml"
 if (ViewBag.RowsAffected != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        Number of rows updated: ");
#nullable restore
#line 24 "C:\Users\ikwak\Code\dotnet\ContosoUniversity\ContosoUniversity\Views\Course\UpdateCourseCredits.cshtml"
                           Write(ViewBag.RowsAffected);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n");
#nullable restore
#line 26 "C:\Users\ikwak\Code\dotnet\ContosoUniversity\ContosoUniversity\Views\Course\UpdateCourseCredits.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    ");
#nullable restore
#line 28 "C:\Users\ikwak\Code\dotnet\ContosoUniversity\ContosoUniversity\Views\Course\UpdateCourseCredits.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContosoUniversity.Models.Course> Html { get; private set; }
    }
}
#pragma warning restore 1591
