#pragma checksum "C:\Users\pc\Desktop\DOTNET CORE MVC 3 Tier Architecture Code First Project\corekatmanUI\Views\PartialViews\View.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "c721d476972e9524ecb9654d780e32b9e00454ab4cbf951f27477e35e94f8d40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PartialViews_View), @"mvc.1.0.view", @"/Views/PartialViews/View.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\pc\Desktop\DOTNET CORE MVC 3 Tier Architecture Code First Project\corekatmanUI\Views\_ViewImports.cshtml"
using corekatmanUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pc\Desktop\DOTNET CORE MVC 3 Tier Architecture Code First Project\corekatmanUI\Views\_ViewImports.cshtml"
using corekatmanUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"c721d476972e9524ecb9654d780e32b9e00454ab4cbf951f27477e35e94f8d40", @"/Views/PartialViews/View.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"417567219d5e06f58e0125cda2c772dfb782c8b6e8cdbe462f0a60ca39f21df8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_PartialViews_View : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""border-end bg-white"" id=""sidebar-wrapper"">
    <div class=""sidebar-heading border-bottom bg-light"">Admin Page</div>
    <div class=""list-group list-group-flush"">
        <a class=""list-group-item list-group-item-action list-group-item-light p-3""");
            BeginWriteAttribute("href", " href=\"", 260, "\"", 298, 1);
#nullable restore
#line 4 "C:\Users\pc\Desktop\DOTNET CORE MVC 3 Tier Architecture Code First Project\corekatmanUI\Views\PartialViews\View.cshtml"
WriteAttributeValue("", 267, Url.Action("Index","Personel"), 267, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Personels</a>\r\n        <a class=\"list-group-item list-group-item-action list-group-item-light p-3\"");
            BeginWriteAttribute("href", " href=\"", 398, "\"", 435, 1);
#nullable restore
#line 5 "C:\Users\pc\Desktop\DOTNET CORE MVC 3 Tier Architecture Code First Project\corekatmanUI\Views\PartialViews\View.cshtml"
WriteAttributeValue("", 405, Url.Action("Index","Project"), 405, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Projects</a>\r\n        <a class=\"list-group-item list-group-item-action list-group-item-light p-3\"");
            BeginWriteAttribute("href", " href=\"", 534, "\"", 569, 1);
#nullable restore
#line 6 "C:\Users\pc\Desktop\DOTNET CORE MVC 3 Tier Architecture Code First Project\corekatmanUI\Views\PartialViews\View.cshtml"
WriteAttributeValue("", 541, Url.Action("Index","Taskk"), 541, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Tasks</a>\r\n        <a class=\"list-group-item list-group-item-action list-group-item-light p-3\"");
            BeginWriteAttribute("href", " href=\"", 665, "\"", 701, 1);
#nullable restore
#line 7 "C:\Users\pc\Desktop\DOTNET CORE MVC 3 Tier Architecture Code First Project\corekatmanUI\Views\PartialViews\View.cshtml"
WriteAttributeValue("", 672, Url.Action("Index","Titles"), 672, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Titles</a>\r\n        <a class=\"list-group-item list-group-item-action list-group-item-light p-3\"");
            BeginWriteAttribute("href", " href=\"", 798, "\"", 832, 1);
#nullable restore
#line 8 "C:\Users\pc\Desktop\DOTNET CORE MVC 3 Tier Architecture Code First Project\corekatmanUI\Views\PartialViews\View.cshtml"
WriteAttributeValue("", 805, Url.Action("Index","Unit"), 805, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Units</a>\r\n        <a class=\"list-group-item list-group-item-action list-group-item-light p-3\"");
            BeginWriteAttribute("href", " href=\"", 928, "\"", 961, 1);
#nullable restore
#line 9 "C:\Users\pc\Desktop\DOTNET CORE MVC 3 Tier Architecture Code First Project\corekatmanUI\Views\PartialViews\View.cshtml"
WriteAttributeValue("", 935, Url.Action("Index","Kid"), 935, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Kids</a>\r\n        <a class=\"list-group-item list-group-item-action list-group-item-light p-3\"");
            BeginWriteAttribute("href", " href=\"", 1056, "\"", 1093, 1);
#nullable restore
#line 10 "C:\Users\pc\Desktop\DOTNET CORE MVC 3 Tier Architecture Code First Project\corekatmanUI\Views\PartialViews\View.cshtml"
WriteAttributeValue("", 1063, Url.Action("Reports","Admin"), 1063, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Report Page</a>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
