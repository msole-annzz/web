#pragma checksum "C:\Users\OUT-Dutova2-OA\source\repos\MyApi\MyApi\Views\MyItems\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3dddf2546db11e4ffdc1109c372067b16d416a59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MyItems_Details), @"mvc.1.0.view", @"/Views/MyItems/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dddf2546db11e4ffdc1109c372067b16d416a59", @"/Views/MyItems/Details.cshtml")]
    public class Views_MyItems_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyApi.Models.MyItem>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\OUT-Dutova2-OA\source\repos\MyApi\MyApi\Views\MyItems\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>MyItem</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\OUT-Dutova2-OA\source\repos\MyApi\MyApi\Views\MyItems\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\OUT-Dutova2-OA\source\repos\MyApi\MyApi\Views\MyItems\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\OUT-Dutova2-OA\source\repos\MyApi\MyApi\Views\MyItems\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsComplete));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\OUT-Dutova2-OA\source\repos\MyApi\MyApi\Views\MyItems\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsComplete));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\OUT-Dutova2-OA\source\repos\MyApi\MyApi\Views\MyItems\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Secret));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\OUT-Dutova2-OA\source\repos\MyApi\MyApi\Views\MyItems\Details.cshtml"
       Write(Html.DisplayFor(model => model.Secret));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 832, "\"", 856, 1);
#nullable restore
#line 34 "C:\Users\OUT-Dutova2-OA\source\repos\MyApi\MyApi\Views\MyItems\Details.cshtml"
WriteAttributeValue("", 847, Model.Id, 847, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApi.Models.MyItem> Html { get; private set; }
    }
}
#pragma warning restore 1591