#pragma checksum "D:\MSI_Quiz\QuizDiet\QuizDiet\QuizDiet\Views\Home\Quiz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51467460d223364328828e6f9837433a7cda59a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Quiz), @"mvc.1.0.view", @"/Views/Home/Quiz.cshtml")]
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
#line 1 "D:\MSI_Quiz\QuizDiet\QuizDiet\QuizDiet\Views\_ViewImports.cshtml"
using QuizDiet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MSI_Quiz\QuizDiet\QuizDiet\QuizDiet\Views\_ViewImports.cshtml"
using QuizDiet.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51467460d223364328828e6f9837433a7cda59a2", @"/Views/Home/Quiz.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba0a8df850309293256c460d52621234ba397326", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Quiz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuizDiet.Models.Data.ListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\MSI_Quiz\QuizDiet\QuizDiet\QuizDiet\Views\Home\Quiz.cshtml"
  
    ViewData["Title"] = "Quiz";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 8 "D:\MSI_Quiz\QuizDiet\QuizDiet\QuizDiet\Views\Home\Quiz.cshtml"
 if (Model != null)
{
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51467460d223364328828e6f9837433a7cda59a23893", async() => {
                WriteLiteral("\n");
#nullable restore
#line 12 "D:\MSI_Quiz\QuizDiet\QuizDiet\QuizDiet\Views\Home\Quiz.cshtml"
         foreach (var item in Model.Questions)
        {


#line default
#line hidden
#nullable disable
                WriteLiteral("            <h2>");
#nullable restore
#line 15 "D:\MSI_Quiz\QuizDiet\QuizDiet\QuizDiet\Views\Home\Quiz.cshtml"
           Write(Html.DisplayFor(modelItem => item.Questions));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\n            <br>\n");
#nullable restore
#line 17 "D:\MSI_Quiz\QuizDiet\QuizDiet\QuizDiet\Views\Home\Quiz.cshtml"
             foreach(var itemsAnswer in Model.Answers)
            {


#line default
#line hidden
#nullable disable
                WriteLiteral("                <input type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 381, "\"", 407, 1);
#nullable restore
#line 20 "D:\MSI_Quiz\QuizDiet\QuizDiet\QuizDiet\Views\Home\Quiz.cshtml"
WriteAttributeValue("", 386, itemsAnswer.IDAnswer, 386, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"answer\"");
                BeginWriteAttribute("value", " value=\"", 422, "\"", 449, 1);
#nullable restore
#line 20 "D:\MSI_Quiz\QuizDiet\QuizDiet\QuizDiet\Views\Home\Quiz.cshtml"
WriteAttributeValue("", 430, itemsAnswer.Points, 430, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                <label for=\"male\">");
#nullable restore
#line 21 "D:\MSI_Quiz\QuizDiet\QuizDiet\QuizDiet\Views\Home\Quiz.cshtml"
                             Write(Html.DisplayFor(modelItem => itemsAnswer.Answers));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n                <br />\n");
#nullable restore
#line 23 "D:\MSI_Quiz\QuizDiet\QuizDiet\QuizDiet\Views\Home\Quiz.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\MSI_Quiz\QuizDiet\QuizDiet\QuizDiet\Views\Home\Quiz.cshtml"
             
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n        <label for=\"firstName\">Your first name</label>\n        <a href=\"/home/quiz/2\"><input type=\"submit\" /></a>\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 30 "D:\MSI_Quiz\QuizDiet\QuizDiet\QuizDiet\Views\Home\Quiz.cshtml"

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a href=\"/home/quiz/2\">weqf</a>\n");
#nullable restore
#line 35 "D:\MSI_Quiz\QuizDiet\QuizDiet\QuizDiet\Views\Home\Quiz.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuizDiet.Models.Data.ListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
