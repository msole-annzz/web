#pragma checksum "C:\Users\OUT-Dutova2-OA\source\repos\MyApi\MyApi\Views\MyItems\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c295de9d3b69eb3e2d86e207e8df63636747aec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MyItems_Index), @"mvc.1.0.view", @"/Views/MyItems/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c295de9d3b69eb3e2d86e207e8df63636747aec", @"/Views/MyItems/Index.cshtml")]
    public class Views_MyItems_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MyApi.Models.MyItem>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\OUT-Dutova2-OA\source\repos\MyApi\MyApi\Views\MyItems\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\OUT-Dutova2-OA\source\repos\MyApi\MyApi\Views\MyItems\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\OUT-Dutova2-OA\source\repos\MyApi\MyApi\Views\MyItems\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsComplete));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\OUT-Dutova2-OA\source\repos\MyApi\MyApi\Views\MyItems\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Secret));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "C:\Users\OUT-Dutova2-OA\source\repos\MyApi\MyApi\Views\MyItems\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\OUT-Dutova2-OA\source\repos\MyApi\MyApi\Views\MyItems\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\OUT-Dutova2-OA\source\repos\MyApi\MyApi\Views\MyItems\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IsComplete));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\OUT-Dutova2-OA\source\repos\MyApi\MyApi\Views\MyItems\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Secret));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 962, "\"", 985, 1);
#nullable restore
#line 40 "C:\Users\OUT-Dutova2-OA\source\repos\MyApi\MyApi\Views\MyItems\Index.cshtml"
WriteAttributeValue("", 977, item.Id, 977, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1038, "\"", 1061, 1);
#nullable restore
#line 41 "C:\Users\OUT-Dutova2-OA\source\repos\MyApi\MyApi\Views\MyItems\Index.cshtml"
WriteAttributeValue("", 1053, item.Id, 1053, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1116, "\"", 1139, 1);
#nullable restore
#line 42 "C:\Users\OUT-Dutova2-OA\source\repos\MyApi\MyApi\Views\MyItems\Index.cshtml"
WriteAttributeValue("", 1131, item.Id, 1131, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 45 "C:\Users\OUT-Dutova2-OA\source\repos\MyApi\MyApi\Views\MyItems\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MyApi.Models.MyItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591