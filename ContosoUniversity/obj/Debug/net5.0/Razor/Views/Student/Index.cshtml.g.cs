#pragma checksum "C:\Users\ikwak\Code\dotnet\ContosoUniversity\ContosoUniversity\Views\Student\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51bdc59d60b533480c0f437e83859b745c1c05d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Index), @"mvc.1.0.view", @"/Views/Student/Index.cshtml")]
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
#nullable restore
#line 2 "C:\Users\ikwak\Code\dotnet\ContosoUniversity\ContosoUniversity\Views\Student\Index.cshtml"
using PagedList.Core.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51bdc59d60b533480c0f437e83859b745c1c05d8", @"/Views/Student/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0517e8f1158838f564b35006cc7a435c10838e54", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList.Core.IPagedList<ContosoUniversity.Models.Student>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/PagedList.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "51bdc59d60b533480c0f437e83859b745c1c05d84247", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "C:\Users\ikwak\Code\dotnet\ContosoUniversity\ContosoUniversity\Views\Student\Index.cshtml"
  
    ViewBag.Title = "Students";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Students</h2>\r\n\r\n<p>\r\n    ");
#nullable restore
#line 13 "C:\Users\ikwak\Code\dotnet\ContosoUniversity\ContosoUniversity\Views\Student\Index.cshtml"
Write(Html.ActionLink("Create New", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n");
#nullable restore
#line 15 "C:\Users\ikwak\Code\dotnet\ContosoUniversity\ContosoUniversity\Views\Student\Index.cshtml"
 using (Html.BeginForm("Index", "Student", FormMethod.Get))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n    Find by name: ");
#nullable restore
#line 18 "C:\Users\ikwak\Code\dotnet\ContosoUniversity\ContosoUniversity\Views\Student\Index.cshtml"
             Write(Html.TextBox("SearchString", ViewBag.CurrentFilter as string));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <input type=\"submit\" value=\"Search\" />\r\n</p>\r\n");
#nullable restore
#line 21 "C:\Users\ikwak\Code\dotnet\ContosoUniversity\ContosoUniversity\Views\Student\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 25 "C:\Users\ikwak\Code\dotnet\ContosoUniversity\ContosoUniversity\Views\Student\Index.cshtml"
       Write(Html.ActionLink("Last Name", "Index", new { sortOrder = ViewBag.NameSortParm, currentFilter = ViewBag.CurrentFilter }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            First Name\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 31 "C:\Users\ikwak\Code\dotnet\ContosoUniversity\ContosoUniversity\Views\Student\Index.cshtml"
       Write(Html.ActionLink("Enrollment Date", "Index", new { sortOrder = ViewBag.DateSortParm, currentFilter = ViewBag.CurrentFilter }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n\r\n\r\n");
#nullable restore
#line 37 "C:\Users\ikwak\Code\dotnet\ContosoUniversity\ContosoUniversity\Views\Student\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>\r\n            ");
#nullable restore
#line 41 "C:\Users\ikwak\Code\dotnet\ContosoUniversity\ContosoUniversity\Views\Student\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 44 "C:\Users\ikwak\Code\dotnet\ContosoUniversity\ContosoUniversity\Views\Student\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.FirstMidName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 47 "C:\Users\ikwak\Code\dotnet\ContosoUniversity\ContosoUniversity\Views\Student\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.EnrollmentDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 50 "C:\Users\ikwak\Code\dotnet\ContosoUniversity\ContosoUniversity\Views\Student\Index.cshtml"
       Write(Html.ActionLink("Edit", "Edit", new { id = item.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n            ");
#nullable restore
#line 51 "C:\Users\ikwak\Code\dotnet\ContosoUniversity\ContosoUniversity\Views\Student\Index.cshtml"
       Write(Html.ActionLink("Details", "Details", new { id = item.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n            ");
#nullable restore
#line 52 "C:\Users\ikwak\Code\dotnet\ContosoUniversity\ContosoUniversity\Views\Student\Index.cshtml"
       Write(Html.ActionLink("Delete", "Delete", new { id = item.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n");
#nullable restore
#line 55 "C:\Users\ikwak\Code\dotnet\ContosoUniversity\ContosoUniversity\Views\Student\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n<br />\r\nPage ");
#nullable restore
#line 59 "C:\Users\ikwak\Code\dotnet\ContosoUniversity\ContosoUniversity\Views\Student\Index.cshtml"
 Write(Model.PageCount < Model.PageNumber ? 0 : Model.PageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" of ");
#nullable restore
#line 59 "C:\Users\ikwak\Code\dotnet\ContosoUniversity\ContosoUniversity\Views\Student\Index.cshtml"
                                                                Write(Model.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<pager class=\"pager-container\"");
            BeginWriteAttribute("list", " list=\"", 1674, "\"", 1687, 1);
#nullable restore
#line 61 "C:\Users\ikwak\Code\dotnet\ContosoUniversity\ContosoUniversity\Views\Student\Index.cshtml"
WriteAttributeValue("", 1681, Model, 1681, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" asp-action=\"Index\" asp-controller=\"Student\" /> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList.Core.IPagedList<ContosoUniversity.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
