#pragma checksum "C:\Users\User\Desktop\FAKULTET\OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Ayana\Views\Products\SearchResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f19b79635b65f760f4661f82109bc64a898cfd4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_SearchResult), @"mvc.1.0.view", @"/Views/Products/SearchResult.cshtml")]
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
#line 1 "C:\Users\User\Desktop\FAKULTET\OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Ayana\Views\_ViewImports.cshtml"
using Ayana;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\FAKULTET\OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Ayana\Views\_ViewImports.cshtml"
using Ayana.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f19b79635b65f760f4661f82109bc64a898cfd4", @"/Views/Products/SearchResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"173c1fb09878f2d54cb847bb1f18422e0ceac569", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Products_SearchResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Ayana.Models.Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("-webkit-text-fill-color:black;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\User\Desktop\FAKULTET\OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Ayana\Views\Products\SearchResult.cshtml"
  
    ViewData["Title"] = "SearchResult";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Desktop\FAKULTET\OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Ayana\Views\Products\SearchResult.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>We are sorry, we don\'t have anything that matches your search. Check your spelling and try again!</p>\r\n");
#nullable restore
#line 10 "C:\Users\User\Desktop\FAKULTET\OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Ayana\Views\Products\SearchResult.cshtml"
}else{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row text-center\" style=\"margin-bottom:100px;\">\r\n");
#nullable restore
#line 12 "C:\Users\User\Desktop\FAKULTET\OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Ayana\Views\Products\SearchResult.cshtml"
     foreach (Product p in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-sm-4\">\r\n            <div>\r\n                <img src=\"https://e0.pxfuel.com/wallpapers/996/249/desktop-wallpaper-earth-white-tulip-white-tulips.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 505, "\"", 511, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"200\" height=\"200\">\r\n                <p><strong>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f19b79635b65f760f4661f82109bc64a898cfd46105", async() => {
                WriteLiteral(" ");
#nullable restore
#line 17 "C:\Users\User\Desktop\FAKULTET\OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Ayana\Views\Products\SearchResult.cshtml"
                                                                                                                                                        Write(p.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 17 "C:\Users\User\Desktop\FAKULTET\OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Ayana\Views\Products\SearchResult.cshtml"
                                                                                           WriteLiteral(p.ProductID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</strong></p>\r\n                <p>BAM ");
#nullable restore
#line 18 "C:\Users\User\Desktop\FAKULTET\OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Ayana\Views\Products\SearchResult.cshtml"
                  Write(p.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(".00</p>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 21 "C:\Users\User\Desktop\FAKULTET\OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Ayana\Views\Products\SearchResult.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
#nullable restore
#line 23 "C:\Users\User\Desktop\FAKULTET\OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Ayana\Views\Products\SearchResult.cshtml"
      }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Ayana.Models.Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591