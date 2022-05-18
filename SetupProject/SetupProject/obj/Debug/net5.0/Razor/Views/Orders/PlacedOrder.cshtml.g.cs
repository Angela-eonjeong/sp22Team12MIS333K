#pragma checksum "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/Orders/PlacedOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b014d6eef48ff77beeee753ff73a7bcc1e210cf4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SetupProject.Views.Orders.Views_Orders_PlacedOrder), @"mvc.1.0.view", @"/Views/Orders/PlacedOrder.cshtml")]
namespace SetupProject.Views.Orders
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b014d6eef48ff77beeee753ff73a7bcc1e210cf4", @"/Views/Orders/PlacedOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b83fecce159d15d8c541e247ac1c86be82e1daf3", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_PlacedOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SetupProject.Models.Order>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/Orders/PlacedOrder.cshtml"
  
    ViewData["Title"] = "Congratulations!";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<h2>Congratulations! Your order has been placed!</h2>


<!-- Order Detail Summary -->
<div>
    <h4>Books Ordered</h4>
    <table class=""table table-sm table-hover table-striped"">
        <thead>
            <tr>
                <th>Book Name</th>
                <th>Book Price</th>
                <th>Quantity</th>
                <th>Extended Price</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 23 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/Orders/PlacedOrder.cshtml"
             foreach (OrderDetail rd in Model.OrderDetails)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>");
#nullable restore
#line 26 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/Orders/PlacedOrder.cshtml"
                   Write(Html.DisplayFor(modelItem => rd.Book.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 27 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/Orders/PlacedOrder.cshtml"
                   Write(Html.DisplayFor(modelItem => rd.BookPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 28 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/Orders/PlacedOrder.cshtml"
                   Write(Html.DisplayFor(modelItem => rd.BookQuantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 29 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/Orders/PlacedOrder.cshtml"
                   Write(Html.DisplayFor(modelItem => rd.SumPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n");
#nullable restore
#line 31 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/Orders/PlacedOrder.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
</div>
<br />


<!-- Order Summary -->
<div>
    <table class=""table table-sm table-bordered"" style=""width:30%"">
        <tr>
            <th colspan=""2"" style=""text-align:center"">Completed Order Summary</th>
        </tr>
        <tr>
            <td>Order Subtotal</td>
            <td>");
#nullable restore
#line 47 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/Orders/PlacedOrder.cshtml"
           Write(Html.DisplayFor(r => r.OrderSubtotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>Shipping Cost</td>\n            <td>");
#nullable restore
#line 51 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/Orders/PlacedOrder.cshtml"
           Write(Html.DisplayFor(r => r.ShippingCost));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>Order Total</td>\n            <td>");
#nullable restore
#line 55 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/Orders/PlacedOrder.cshtml"
           Write(Html.DisplayFor(r => r.OrderTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n    </table>\n</div>\n\n<div>\n    <p>\n        Based on your last purchase, we have some books you might like:\n        <br />\n        ");
#nullable restore
#line 64 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/Orders/PlacedOrder.cshtml"
   Write(Html.ActionLink("Recommended Books", "Recommend", "RecommendBooks", new { id = Model.OrderID }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    </p>\n\n\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SetupProject.Models.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
