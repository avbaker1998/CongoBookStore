#pragma checksum "C:\Users\Allessandra\source\repos\Assign5-Books\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ea437e09d1a3351400ec5823b161fcbee849598"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Allessandra\source\repos\Assign5-Books\Views\_ViewImports.cshtml"
using Assign5_Books;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Allessandra\source\repos\Assign5-Books\Views\_ViewImports.cshtml"
using Assign5_Books.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Allessandra\source\repos\Assign5-Books\Views\_ViewImports.cshtml"
using Assign5_Books.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ea437e09d1a3351400ec5823b161fcbee849598", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40e493b20fdb16cc64ebedc41aec1916cbc221cc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class", "btn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-normal", "btn-outline-dark", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-selected", "btn-white", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-group pull-right m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Assign5_Books.Infrastructure.PageLinkTagHelper __Assign5_Books_Infrastructure_PageLinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Allessandra\source\repos\Assign5-Books\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"<!--IQueryable<BookModel>-->


<!--COMMENTS FOR BOOTSTRAP
    I used many new bootstrap and css commands but here are a few
    1. align-items-start/align-items-end
    2. my-auto
    3. text-right/text-left
    -->


<div style=""border: 7px double #BF8724;"">
    <header style=""        text-align: center;
        color: #000033;
        font-family: 'Lato', sans-serif;
        "">
        <h1>Welcome to Congo</h1>
        <h3>Online Bookstore of Professor Hiltons Favorite Books</h3>
    </header>
</div>
<br />
<br />

<!--The purpose of tag helpers is to build html on the fly dynamically-->

");
#nullable restore
#line 31 "C:\Users\Allessandra\source\repos\Assign5-Books\Views\Home\Index.cshtml"
 foreach (var x in Model.Books)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- iterate through the database and print out the books-->\r\n");
            WriteLiteral("    <div class=\"row\" style=\"background-color: aliceblue;\r\n        border-bottom: 2px inset #BF8724;\r\n\" >\r\n        <div class=\"col-md-4 row-height text-right align-items-start my-auto\">\r\n            <span><b>Book Title: ");
#nullable restore
#line 39 "C:\Users\Allessandra\source\repos\Assign5-Books\Views\Home\Index.cshtml"
                            Write(x.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></span>\r\n        </div>\r\n        <div class=\"col-md-4 row-height text-center\">\r\n            <p>ISBN: ");
#nullable restore
#line 42 "C:\Users\Allessandra\source\repos\Assign5-Books\Views\Home\Index.cshtml"
                Write(x.ISBN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>Author: ");
#nullable restore
#line 43 "C:\Users\Allessandra\source\repos\Assign5-Books\Views\Home\Index.cshtml"
                  Write(x.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>Publisher: ");
#nullable restore
#line 44 "C:\Users\Allessandra\source\repos\Assign5-Books\Views\Home\Index.cshtml"
                     Write(x.Publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>Category: ");
#nullable restore
#line 45 "C:\Users\Allessandra\source\repos\Assign5-Books\Views\Home\Index.cshtml"
                    Write(x.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>Number of Pages: ");
#nullable restore
#line 46 "C:\Users\Allessandra\source\repos\Assign5-Books\Views\Home\Index.cshtml"
                           Write(x.PageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"col-md-4 row-height text-left align-items-end my-auto\">\r\n            Price: $");
#nullable restore
#line 49 "C:\Users\Allessandra\source\repos\Assign5-Books\Views\Home\Index.cshtml"
               Write(x.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 52 "C:\Users\Allessandra\source\repos\Assign5-Books\Views\Home\Index.cshtml"


    
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ea437e09d1a3351400ec5823b161fcbee8495988382", async() => {
            }
            );
            __Assign5_Books_Infrastructure_PageLinkTagHelper = CreateTagHelper<global::Assign5_Books.Infrastructure.PageLinkTagHelper>();
            __tagHelperExecutionContext.Add(__Assign5_Books_Infrastructure_PageLinkTagHelper);
#nullable restore
#line 56 "C:\Users\Allessandra\source\repos\Assign5-Books\Views\Home\Index.cshtml"
__Assign5_Books_Infrastructure_PageLinkTagHelper.PageModel = Model.PagingInfo;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-model", __Assign5_Books_Infrastructure_PageLinkTagHelper.PageModel, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Assign5_Books_Infrastructure_PageLinkTagHelper.PageAction = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 56 "C:\Users\Allessandra\source\repos\Assign5-Books\Views\Home\Index.cshtml"
__Assign5_Books_Infrastructure_PageLinkTagHelper.PageClassesEnabled = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-classes-enabled", __Assign5_Books_Infrastructure_PageLinkTagHelper.PageClassesEnabled, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Assign5_Books_Infrastructure_PageLinkTagHelper.PageClass = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Assign5_Books_Infrastructure_PageLinkTagHelper.PageClassNormal = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Assign5_Books_Infrastructure_PageLinkTagHelper.PageClassSelected = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
