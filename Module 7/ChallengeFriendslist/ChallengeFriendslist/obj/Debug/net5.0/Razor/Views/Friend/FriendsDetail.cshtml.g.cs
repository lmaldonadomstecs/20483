#pragma checksum "C:\Users\fmt_9\source\repos\ChallengeFriendslist\ChallengeFriendslist\Views\Friend\FriendsDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c95fe2791c61b54a67bb3b1ab4b48daf86f1ac41"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Friend_FriendsDetail), @"mvc.1.0.view", @"/Views/Friend/FriendsDetail.cshtml")]
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
#line 1 "C:\Users\fmt_9\source\repos\ChallengeFriendslist\ChallengeFriendslist\Views\_ViewImports.cshtml"
using ChallengeFriendslist;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fmt_9\source\repos\ChallengeFriendslist\ChallengeFriendslist\Views\_ViewImports.cshtml"
using ChallengeFriendslist.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c95fe2791c61b54a67bb3b1ab4b48daf86f1ac41", @"/Views/Friend/FriendsDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfc52e41b349758dffacb54c2ed02365b6214c45", @"/Views/_ViewImports.cshtml")]
    public class Views_Friend_FriendsDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Friend>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\fmt_9\source\repos\ChallengeFriendslist\ChallengeFriendslist\Views\Friend\FriendsDetail.cshtml"
  
    ViewData["Title"] = "FriendsDetail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>FriendsDetail</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c95fe2791c61b54a67bb3b1ab4b48daf86f1ac413773", async() => {
                WriteLiteral("< Go back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<table>
    <thead>
        <tr>
            <th>Id</th>
            <th>Name</th>
            <th>Place</th>
            <th>Age</th>
            <th>Occupation</th>
            <th>Favorite Sport</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>");
#nullable restore
#line 24 "C:\Users\fmt_9\source\repos\ChallengeFriendslist\ChallengeFriendslist\Views\Friend\FriendsDetail.cshtml"
           Write(Model.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\fmt_9\source\repos\ChallengeFriendslist\ChallengeFriendslist\Views\Friend\FriendsDetail.cshtml"
           Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\fmt_9\source\repos\ChallengeFriendslist\ChallengeFriendslist\Views\Friend\FriendsDetail.cshtml"
           Write(Model.place);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\fmt_9\source\repos\ChallengeFriendslist\ChallengeFriendslist\Views\Friend\FriendsDetail.cshtml"
           Write(Model.age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\fmt_9\source\repos\ChallengeFriendslist\ChallengeFriendslist\Views\Friend\FriendsDetail.cshtml"
           Write(Model.occupation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\fmt_9\source\repos\ChallengeFriendslist\ChallengeFriendslist\Views\Friend\FriendsDetail.cshtml"
           Write(Model.favoriteSport);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Friend> Html { get; private set; }
    }
}
#pragma warning restore 1591
