#pragma checksum "/Users/alexandre.costa/LI4/MentorMe/Views/Question/Question.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7852d2ac41fdbc22dff8b54ebcf8f2335d3f5ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Question_Question), @"mvc.1.0.view", @"/Views/Question/Question.cshtml")]
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
#line 1 "/Users/alexandre.costa/LI4/MentorMe/Views/_ViewImports.cshtml"
using MentorMe;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/alexandre.costa/LI4/MentorMe/Views/_ViewImports.cshtml"
using MentorMe.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7852d2ac41fdbc22dff8b54ebcf8f2335d3f5ef", @"/Views/Question/Question.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbab53756600d2da816218cdb97ce93e400b173e", @"/Views/_ViewImports.cshtml")]
    public class Views_Question_Question : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MentorMe.Models.Question>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-left:5px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Question", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateAnswer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Westwind.AspNetCore.Markdown.MarkdownTagHelper __Westwind_AspNetCore_Markdown_MarkdownTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/alexandre.costa/LI4/MentorMe/Views/Question/Question.cshtml"
  
    Layout = "~/Views/Shared/_MainLayout.cshtml";
    ViewData["Title"] = "EnterQuestion";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!DOCTYPE html>\n\n<html>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7852d2ac41fdbc22dff8b54ebcf8f2335d3f5ef5179", async() => {
                WriteLiteral("\n\n    <h4>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("markdown", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7852d2ac41fdbc22dff8b54ebcf8f2335d3f5ef5443", async() => {
#nullable restore
#line 14 "/Users/alexandre.costa/LI4/MentorMe/Views/Question/Question.cshtml"
             Write(ViewBag.Question.Title);

#line default
#line hidden
#nullable disable
                }
                );
                __Westwind_AspNetCore_Markdown_MarkdownTagHelper = CreateTagHelper<global::Westwind.AspNetCore.Markdown.MarkdownTagHelper>();
                __tagHelperExecutionContext.Add(__Westwind_AspNetCore_Markdown_MarkdownTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</h4>\n\n    <div class=\"list-group\">\n        <div class=\"col-md-4\">\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("markdown", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7852d2ac41fdbc22dff8b54ebcf8f2335d3f5ef6655", async() => {
#nullable restore
#line 18 "/Users/alexandre.costa/LI4/MentorMe/Views/Question/Question.cshtml"
                 Write(ViewBag.Question.Content);

#line default
#line hidden
#nullable disable
                }
                );
                __Westwind_AspNetCore_Markdown_MarkdownTagHelper = CreateTagHelper<global::Westwind.AspNetCore.Markdown.MarkdownTagHelper>();
                __tagHelperExecutionContext.Add(__Westwind_AspNetCore_Markdown_MarkdownTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("  \n        </div>\n\n");
#nullable restore
#line 21 "/Users/alexandre.costa/LI4/MentorMe/Views/Question/Question.cshtml"
         if (ViewBag.AnswersLength == 0)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <p style=\"font-size: small; color:grey;\">-No answers yet!</p>\n");
#nullable restore
#line 24 "/Users/alexandre.costa/LI4/MentorMe/Views/Question/Question.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"list-group\">\n");
#nullable restore
#line 28 "/Users/alexandre.costa/LI4/MentorMe/Views/Question/Question.cshtml"
                 foreach (Answer answer in ViewBag.Answers)
                {
                    if (answer.Valid)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <a style=\"background-color:aquamarine;margin-bottom:5px;\" onclick=\"return myFunction()\"");
                BeginWriteAttribute("href", " href=\'", 807, "\'", 888, 1);
#nullable restore
#line 32 "/Users/alexandre.costa/LI4/MentorMe/Views/Question/Question.cshtml"
WriteAttributeValue("", 814, Url.Action("MarkAsValidAnswer", "Question", new { id = answer.AnswerID }), 814, 74, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"list-group-item list-group-item-action list-group-item-primary\"><p>");
#nullable restore
#line 32 "/Users/alexandre.costa/LI4/MentorMe/Views/Question/Question.cshtml"
                                                                                                                                                                                                                                                                       Write(answer.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("markdown", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7852d2ac41fdbc22dff8b54ebcf8f2335d3f5ef9744", async() => {
#nullable restore
#line 32 "/Users/alexandre.costa/LI4/MentorMe/Views/Question/Question.cshtml"
                                                                                                                                                                                                                                                                                                     Write(answer.Content);

#line default
#line hidden
#nullable disable
                }
                );
                __Westwind_AspNetCore_Markdown_MarkdownTagHelper = CreateTagHelper<global::Westwind.AspNetCore.Markdown.MarkdownTagHelper>();
                __tagHelperExecutionContext.Add(__Westwind_AspNetCore_Markdown_MarkdownTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</a>\n");
#nullable restore
#line 33 "/Users/alexandre.costa/LI4/MentorMe/Views/Question/Question.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <a style=\"margin-bottom:5px;\" onclick=\"return myFunction()\"");
                BeginWriteAttribute("href", " href=\'", 1177, "\'", 1258, 1);
#nullable restore
#line 36 "/Users/alexandre.costa/LI4/MentorMe/Views/Question/Question.cshtml"
WriteAttributeValue("", 1184, Url.Action("MarkAsValidAnswer", "Question", new { id = answer.AnswerID }), 1184, 74, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"list-group-item list-group-item-action list-group-item-primary\"><p>");
#nullable restore
#line 36 "/Users/alexandre.costa/LI4/MentorMe/Views/Question/Question.cshtml"
                                                                                                                                                                                                                                           Write(answer.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("markdown", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7852d2ac41fdbc22dff8b54ebcf8f2335d3f5ef12409", async() => {
#nullable restore
#line 36 "/Users/alexandre.costa/LI4/MentorMe/Views/Question/Question.cshtml"
                                                                                                                                                                                                                                                                         Write(answer.Content);

#line default
#line hidden
#nullable disable
                }
                );
                __Westwind_AspNetCore_Markdown_MarkdownTagHelper = CreateTagHelper<global::Westwind.AspNetCore.Markdown.MarkdownTagHelper>();
                __tagHelperExecutionContext.Add(__Westwind_AspNetCore_Markdown_MarkdownTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</a>\n");
#nullable restore
#line 37 "/Users/alexandre.costa/LI4/MentorMe/Views/Question/Question.cshtml"
                        }

                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </div>\n");
#nullable restore
#line 42 "/Users/alexandre.costa/LI4/MentorMe/Views/Question/Question.cshtml"

        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div>\n            <a class=\"btn btn-outline-warning\"");
                BeginWriteAttribute("onclick", " onclick=\"", 1531, "\"", 1614, 3);
                WriteAttributeValue("", 1541, "location.href=\'", 1541, 15, true);
#nullable restore
#line 45 "/Users/alexandre.costa/LI4/MentorMe/Views/Question/Question.cshtml"
WriteAttributeValue("", 1556, Url.Action("EnterRoom", "Room",new {id=@ViewBag.RoomID}), 1556, 57, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1613, "\'", 1613, 1, true);
                EndWriteAttribute();
                WriteLiteral(">Go back</a>\n        </div>\n\n        <p>\n            <span style=\"font-size: x-large; color: lightslategray;\"> ");
#nullable restore
#line 49 "/Users/alexandre.costa/LI4/MentorMe/Views/Question/Question.cshtml"
                                                                 Write(ViewBag.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </span>\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7852d2ac41fdbc22dff8b54ebcf8f2335d3f5ef15233", async() => {
                    WriteLiteral("New answer");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        </p>\n    </div>\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>\n\n<script>\n    function myFunction() {\n\n        var x = confirm(\"Press OK to mark this answer as valid.\");\n        if (x)\n            return true;\n        else\n            return false;\n    }\n\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MentorMe.Models.Question> Html { get; private set; }
    }
}
#pragma warning restore 1591
