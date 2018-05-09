#pragma checksum "C:\Users\leode\Source\Workspaces\TempLittleBook\LittleBook\Views\Todo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67fb6e14298023eb23d6d183e20d010b87b10a90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Todo_Index), @"mvc.1.0.view", @"/Views/Todo/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Todo/Index.cshtml", typeof(AspNetCore.Views_Todo_Index))]
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
#line 1 "C:\Users\leode\Source\Workspaces\TempLittleBook\LittleBook\Views\_ViewImports.cshtml"
using LittleBook;

#line default
#line hidden
#line 2 "C:\Users\leode\Source\Workspaces\TempLittleBook\LittleBook\Views\_ViewImports.cshtml"
using LittleBook.Models;

#line default
#line hidden
#line 2 "C:\Users\leode\Source\Workspaces\TempLittleBook\LittleBook\Views\Todo\Index.cshtml"
using Humanizer;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67fb6e14298023eb23d6d183e20d010b87b10a90", @"/Views/Todo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08db4ee5ee0933164de52268b0fb565da053c650", @"/Views/_ViewImports.cshtml")]
    public class Views_Todo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TodoViewModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\leode\Source\Workspaces\TempLittleBook\LittleBook\Views\Todo\Index.cshtml"
  
    ViewData["Title"] = "Manage your todo list";

#line default
#line hidden
            BeginContext(101, 77, true);
            WriteLiteral("<div class=\"panel panel-defailt todo-panel\">\r\n    <div class=\"panel-heading\">");
            EndContext();
            BeginContext(179, 17, false);
#line 8 "C:\Users\leode\Source\Workspaces\TempLittleBook\LittleBook\Views\Todo\Index.cshtml"
                          Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(196, 215, true);
            WriteLiteral("</div>\r\n    <table class=\"table table-hover\">\r\n        <thead>\r\n            <tr>\r\n                <td>&#x2714;</td>\r\n                <td>Item</td>\r\n                <td>Due</td>\r\n            </tr>\r\n        </thead>\r\n");
            EndContext();
#line 17 "C:\Users\leode\Source\Workspaces\TempLittleBook\LittleBook\Views\Todo\Index.cshtml"
         foreach (var item in Model.Items)
        {

#line default
#line hidden
            BeginContext(466, 82, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 548, "\"", 563, 1);
#line 21 "C:\Users\leode\Source\Workspaces\TempLittleBook\LittleBook\Views\Todo\Index.cshtml"
WriteAttributeValue("", 555, item.Id, 555, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(564, 82, true);
            WriteLiteral(" value=\"true\" class=\"done-checkbox\"/>\r\n                </td>\r\n                <td>");
            EndContext();
            BeginContext(647, 10, false);
#line 23 "C:\Users\leode\Source\Workspaces\TempLittleBook\LittleBook\Views\Todo\Index.cshtml"
               Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(657, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(685, 21, false);
#line 24 "C:\Users\leode\Source\Workspaces\TempLittleBook\LittleBook\Views\Todo\Index.cshtml"
               Write(item.DueAt.Humanize());

#line default
#line hidden
            EndContext();
            BeginContext(706, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 26 "C:\Users\leode\Source\Workspaces\TempLittleBook\LittleBook\Views\Todo\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(743, 68, true);
            WriteLiteral("    </table>\r\n    <div class=\"panel-footer add-item-form\">\r\n        ");
            EndContext();
            BeginContext(811, 263, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbfe979ce2994d52b981d4c1471360bf", async() => {
                BeginContext(817, 250, true);
                WriteLiteral("\r\n            <div id=\"add-item-error\" class=\"text-danger\"></div>\r\n            <label for=\"add-item-title\">Add a new item</label>\r\n            <input id=\"add-item-title\"/>\r\n            <button type=\"button\" id=\"add-item-button\">Add</button>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1074, 20, true);
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TodoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591