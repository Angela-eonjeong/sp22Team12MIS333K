#pragma checksum "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/ProcurementOrders/Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbf27a9f3e0e0303c34c24d0fb40b403fac0a146"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SetupProject.Views.ProcurementOrders.Views_ProcurementOrders_Search), @"mvc.1.0.view", @"/Views/ProcurementOrders/Search.cshtml")]
namespace SetupProject.Views.ProcurementOrders
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
#line 13 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/_ViewImports.cshtml"
using SetupProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbf27a9f3e0e0303c34c24d0fb40b403fac0a146", @"/Views/ProcurementOrders/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b83fecce159d15d8c541e247ac1c86be82e1daf3", @"/Views/_ViewImports.cshtml")]
    public class Views_ProcurementOrders_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SetupProject.Models.Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetailedSearch", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Books", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateManual", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/ProcurementOrders/Search.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Index</h1>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbf27a9f3e0e0303c34c24d0fb40b403fac0a1467341", async() => {
                WriteLiteral(" \n    <p class=\"form-group\"> \n        Search: <input name=\"SearchString\" class=\"form-control\"/><br/> \n        <button type=\"submit\" class=\"btn btn-primary\">Search</button> \n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbf27a9f3e0e0303c34c24d0fb40b403fac0a1467788", async() => {
                    WriteLiteral("Detailed Search");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" \n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbf27a9f3e0e0303c34c24d0fb40b403fac0a1469093", async() => {
                    WriteLiteral("Show All");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" \n    </p> \n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \n\n<p>Displaying ");
#nullable restore
#line 18 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/ProcurementOrders/Search.cshtml"
         Write(ViewBag.SelectedBooks);

#line default
#line hidden
#nullable disable
            WriteLiteral(" of ");
#nullable restore
#line 18 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/ProcurementOrders/Search.cshtml"
                                   Write(ViewBag.AllBooks);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Books </p>\n\n");
#nullable restore
#line 20 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/ProcurementOrders/Search.cshtml"
 if (User.Identity.IsAuthenticated && User.IsInRole("Admin"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbf27a9f3e0e0303c34c24d0fb40b403fac0a14613104", async() => {
                WriteLiteral("Add Book");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </p>  \n");
#nullable restore
#line 25 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/ProcurementOrders/Search.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 32 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/ProcurementOrders/Search.cshtml"
           Write(Html.DisplayNameFor(model => model.UniqueNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 35 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/ProcurementOrders/Search.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 38 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/ProcurementOrders/Search.cshtml"
           Write(Html.DisplayNameFor(model => model.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 41 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/ProcurementOrders/Search.cshtml"
           Write(Html.DisplayNameFor(model => model.Inventory));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            \n            <th>\n                ");
#nullable restore
#line 45 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/ProcurementOrders/Search.cshtml"
           Write(Html.DisplayNameFor(model => model.AverageRating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n\n       \n");
#nullable restore
#line 49 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/ProcurementOrders/Search.cshtml"
             if (User.Identity.IsAuthenticated && User.IsInRole("Admin"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("               <th>\n                ");
#nullable restore
#line 52 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/ProcurementOrders/Search.cshtml"
           Write(Html.DisplayNameFor(model => model.Cost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th> \n                <th>\n                ");
#nullable restore
#line 55 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/ProcurementOrders/Search.cshtml"
           Write(Html.DisplayNameFor(model => model.AvgProfitMargin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n");
#nullable restore
#line 57 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/ProcurementOrders/Search.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("          \n      \n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 64 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/ProcurementOrders/Search.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 67 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/ProcurementOrders/Search.cshtml"
           Write(Html.DisplayFor(modelItem => item.UniqueNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 70 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/ProcurementOrders/Search.cshtml"
           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 73 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/ProcurementOrders/Search.cshtml"
           Write(Html.DisplayFor(modelItem => item.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n");
#nullable restore
#line 76 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/ProcurementOrders/Search.cshtml"
                 if (item.Inventory > 0) {

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/ProcurementOrders/Search.cshtml"
                                     Write(ViewBag.InStock);

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/ProcurementOrders/Search.cshtml"
                                                          }

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/ProcurementOrders/Search.cshtml"
                 if (item.Inventory <= 0) {

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/ProcurementOrders/Search.cshtml"
                                      Write(ViewBag.OutofStock);

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/ProcurementOrders/Search.cshtml"
                                                              }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\n            \n            <td>\n                ");
#nullable restore
#line 81 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/ProcurementOrders/Search.cshtml"
           Write(Html.DisplayFor(modelItem => item.AverageRating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n            </td>\n           \n\n");
#nullable restore
#line 86 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/ProcurementOrders/Search.cshtml"
                if (User.Identity.IsAuthenticated && User.IsInRole("Admin"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("               <td>\n                ");
#nullable restore
#line 89 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/ProcurementOrders/Search.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>  \n                 <td>\n                ");
#nullable restore
#line 92 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/ProcurementOrders/Search.cshtml"
           Write(Html.DisplayFor(modelItem => item.AvgProfitMargin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n");
#nullable restore
#line 94 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/ProcurementOrders/Search.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n        \n            <td>\n\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbf27a9f3e0e0303c34c24d0fb40b403fac0a14624674", async() => {
                WriteLiteral("Order More");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 100 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/ProcurementOrders/Search.cshtml"
                                       WriteLiteral(item.BookID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbf27a9f3e0e0303c34c24d0fb40b403fac0a14626938", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 101 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/ProcurementOrders/Search.cshtml"
                                                          WriteLiteral(item.BookID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \n\n       \n\n        \n\n            </td>\n        </tr>\n");
#nullable restore
#line 109 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/ProcurementOrders/Search.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SetupProject.Models.Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
