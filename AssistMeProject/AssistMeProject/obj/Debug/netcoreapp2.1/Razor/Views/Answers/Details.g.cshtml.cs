#pragma checksum "D:\projects\visualStudio\AssistMe\AssistMeProject\AssistMeProject\Views\Answers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fc94eb9e6f715404f18271b08ac2aecd5cf9fd3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Answers_Details), @"mvc.1.0.view", @"/Views/Answers/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Answers/Details.cshtml", typeof(AspNetCore.Views_Answers_Details))]
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
#line 1 "D:\projects\visualStudio\AssistMe\AssistMeProject\AssistMeProject\Views\_ViewImports.cshtml"
using AssistMeProject;

#line default
#line hidden
#line 2 "D:\projects\visualStudio\AssistMe\AssistMeProject\AssistMeProject\Views\_ViewImports.cshtml"
using AssistMeProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fc94eb9e6f715404f18271b08ac2aecd5cf9fd3", @"/Views/Answers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7e9000fdfbf39452f2df6e36ab8c5a2875360c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Answers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AssistMeProject.Models.Answer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Comments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\projects\visualStudio\AssistMe\AssistMeProject\AssistMeProject\Views\Answers\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(83, 751, true);
            WriteLiteral(@"

<h4>Answer</h4>


<li class=""comment"">
    <div class=""comment-body comment-body-answered clearfix"">
        <div class=""avatar""><img alt="""" src=""http://placehold.it/60x60/FFF/444""></div>
        <div class=""comment-text"">
            <div class=""author clearfix"">
                <div class=""comment-author""><a href=""#"">admin</a></div>
                <div class=""comment-vote"">
                    <ul class=""question-vote"">
                        <li><a href=""#"" class=""question-vote-up"" title=""Like""></a></li>
                    </ul>
                </div>
                <span class=""question-vote-result"">+1</span>
                <div class=""comment-meta"">
                    <div class=""date""><i class=""icon-time""></i>");
            EndContext();
            BeginContext(835, 28, false);
#line 24 "D:\projects\visualStudio\AssistMe\AssistMeProject\AssistMeProject\Views\Answers\Details.cshtml"
                                                          Write(Html.DisplayFor(m => m.Date));

#line default
#line hidden
            EndContext();
            BeginContext(863, 190, true);
            WriteLiteral("</div>\r\n                </div>\r\n                <a class=\"comment-reply\" href=\"#\"><i class=\"icon-reply\"></i>Reply</a>\r\n            </div>\r\n            <div class=\"text\">\r\n                <p>");
            EndContext();
            BeginContext(1054, 35, false);
#line 29 "D:\projects\visualStudio\AssistMe\AssistMeProject\AssistMeProject\Views\Answers\Details.cshtml"
              Write(Html.DisplayFor(m => m.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1089, 38, true);
            WriteLiteral("</p>\r\n                <p>Answered to: ");
            EndContext();
            BeginContext(1128, 38, false);
#line 30 "D:\projects\visualStudio\AssistMe\AssistMeProject\AssistMeProject\Views\Answers\Details.cshtml"
                           Write(Html.DisplayFor(m => m.Question.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1166, 183, true);
            WriteLiteral("</p>\r\n\r\n            </div>\r\n            <div class=\"question-answered question-answered-done\"><i class=\"icon-ok\"></i>Best Answer</div>\r\n        </div>\r\n    </div>\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(1349, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fc94eb9e6f715404f18271b08ac2aecd5cf9fd36554", async() => {
                BeginContext(1429, 18, true);
                WriteLiteral("Agregar Comentario");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-AnswerId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 37 "D:\projects\visualStudio\AssistMe\AssistMeProject\AssistMeProject\Views\Answers\Details.cshtml"
                                                                 WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["AnswerId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-AnswerId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["AnswerId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1451, 139, true);
            WriteLiteral("\r\n        <!--|\r\n        <a asp-action=\"Index\">Back to List</a> -->\r\n    </div>\r\n\r\n</li>\r\n\r\n\r\n<div id=\"commentlist\">\r\n\r\n   \r\n\r\n</div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1607, 91, true);
                WriteLiteral("\r\n\r\n\r\n\r\n    <script>\r\n        $(function () {\r\n            $.ajax({\r\n                url: \"");
                EndContext();
                BeginContext(1699, 56, false);
#line 59 "D:\projects\visualStudio\AssistMe\AssistMeProject\AssistMeProject\Views\Answers\Details.cshtml"
                 Write(Url.Content("~/Comments/CommentList?AnswerId="+Model.Id));

#line default
#line hidden
                EndContext();
                BeginContext(1755, 212, true);
                WriteLiteral("\"\r\n            }).done(function (data) {\r\n                $(\'#commentlist\').html(data);\r\n            }).fail(function () {\r\n                alert(\"error\");\r\n            });\r\n        }\r\n        );\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(1970, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AssistMeProject.Models.Answer> Html { get; private set; }
    }
}
#pragma warning restore 1591
