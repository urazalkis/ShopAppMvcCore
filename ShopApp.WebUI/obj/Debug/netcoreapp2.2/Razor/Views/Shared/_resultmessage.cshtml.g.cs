#pragma checksum "D:\Projects\WEB\Alkislareticaret\ShopApp\ShopApp.WebUI\Views\Shared\_resultmessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04868f8af09798ba3f4ae7194826e79681fea3ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__resultmessage), @"mvc.1.0.view", @"/Views/Shared/_resultmessage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_resultmessage.cshtml", typeof(AspNetCore.Views_Shared__resultmessage))]
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
#line 1 "D:\Projects\WEB\Alkislareticaret\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.Entities;

#line default
#line hidden
#line 2 "D:\Projects\WEB\Alkislareticaret\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.WebUI.Extensions;

#line default
#line hidden
#line 3 "D:\Projects\WEB\Alkislareticaret\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.WebUI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04868f8af09798ba3f4ae7194826e79681fea3ba", @"/Views/Shared/_resultmessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"055a2c7e4e53beb949480bf5d57e7dcd1052d407", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__resultmessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ResultMessage>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(21, 59, true);
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"col-md-12\">\n        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 80, "\"", 110, 3);
            WriteAttributeValue("", 88, "alert", 88, 5, true);
            WriteAttributeValue(" ", 93, "alert-", 94, 7, true);
#line 5 "D:\Projects\WEB\Alkislareticaret\ShopApp\ShopApp.WebUI\Views\Shared\_resultmessage.cshtml"
WriteAttributeValue("", 100, Model.Css, 100, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(111, 38, true);
            WriteLiteral(">\n            <h4 class=\"alert-title\">");
            EndContext();
            BeginContext(150, 11, false);
#line 6 "D:\Projects\WEB\Alkislareticaret\ShopApp\ShopApp.WebUI\Views\Shared\_resultmessage.cshtml"
                               Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(161, 21, true);
            WriteLiteral("</h4>\n            <p>");
            EndContext();
            BeginContext(183, 13, false);
#line 7 "D:\Projects\WEB\Alkislareticaret\ShopApp\ShopApp.WebUI\Views\Shared\_resultmessage.cshtml"
          Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(196, 38, true);
            WriteLiteral("</p>\n        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ResultMessage> Html { get; private set; }
    }
}
#pragma warning restore 1591
