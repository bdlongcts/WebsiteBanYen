#pragma checksum "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\ShoppingCart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f43c6df50699bc07b318ad8cd2c01e1fdb7cc8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingCart_Index), @"mvc.1.0.view", @"/Views/ShoppingCart/Index.cshtml")]
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
#line 1 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\_ViewImports.cshtml"
using WebShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\_ViewImports.cshtml"
using WebShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f43c6df50699bc07b318ad8cd2c01e1fdb7cc8a", @"/Views/ShoppingCart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3df3320de4c2e3d10181e18c8e069dc52a6b106", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_ShoppingCart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebShop.ModelViews.CartItem>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\ShoppingCart\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main class=""main-content"">
    <!-- Breadcrumb Section Begin -->
    <section class=""breadcrumb-option"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""breadcrumb__text"">
                        <h4>Shopping Cart</h4>
                        <div class=""breadcrumb__links"">
                            <a href=""./index.html"">Home</a>
                            <a href=""./shop.html"">Shop</a>
                            <span>Shopping Cart</span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Breadcrumb Section End -->
    <!-- Shopping Cart Section Begin -->
    <section class=""shopping-cart spad"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-8"">
");
#nullable restore
#line 31 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\ShoppingCart\Index.cshtml"
                     if (Model != null && Model.Count() > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""shopping__cart__table"">
                            <table>
                                <thead>
                                    <tr>
                                        <th>Product</th>
                                        <th>Quantity</th>
                                        <th>Total</th>
                                        <th></th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 44 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\ShoppingCart\Index.cshtml"
                                     if (Model != null && Model.Count() > 0)
                                    {
                                        foreach (var item in Model)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <tr>
                                                <td class=""product__cart__item"">
                                                    <div class=""product__cart__item__pic"">
                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8f43c6df50699bc07b318ad8cd2c01e1fdb7cc8a6477", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2176, "~/images/products/", 2176, 18, true);
#nullable restore
#line 51 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\ShoppingCart\Index.cshtml"
AddHtmlAttributeValue("", 2194, item.product.Thumb, 2194, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 51 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\ShoppingCart\Index.cshtml"
AddHtmlAttributeValue("", 2220, item.product.Title, 2220, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                    </div>\r\n                                                    <div class=\"product__cart__item__text\">\r\n                                                        <h6><a href=\"javascript:void(0)\">");
#nullable restore
#line 54 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\ShoppingCart\Index.cshtml"
                                                                                    Write(item.product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h6>\r\n                                                        <h5><span class=\"amount\">");
#nullable restore
#line 55 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\ShoppingCart\Index.cshtml"
                                                                            Write(item.product.Price.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" VNĐ</span></h5>
                                                    </div>
                                                </td>
                                                <td class=""quantity__item"">
                                                    <div class=""quantity"">
                                                        <div class=""pro-qty-2"">
                                                            <input class=""cartQuantity cartItem"" data-mahh=""");
#nullable restore
#line 61 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\ShoppingCart\Index.cshtml"
                                                                                                       Write(item.product.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-dongia=\"");
#nullable restore
#line 61 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\ShoppingCart\Index.cshtml"
                                                                                                                                             Write(item.product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("value", " value=\"", 3178, "\"", 3198, 1);
#nullable restore
#line 61 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 3186, item.amount, 3186, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" min=\"1\"");
            BeginWriteAttribute("max", " max=\"", 3207, "\"", 3239, 1);
#nullable restore
#line 61 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 3213, item.product.UnitsInStock, 3213, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""number"">
                                                        </div>
                                                    </div>
                                                </td>
                                                <td class=""cart__price""><span class=""amount"">");
#nullable restore
#line 65 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\ShoppingCart\Index.cshtml"
                                                                                        Write(item.TotalMoney.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</span></td>\r\n                                                <td class=\"cart__close\"> <input type=\"button\" value=\"X\" class=\"removecart btn btn-primary\" data-mahh=\"");
#nullable restore
#line 66 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\ShoppingCart\Index.cshtml"
                                                                                                                                                 Write(item.product.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" /></td>\r\n                                            </tr>\r\n");
#nullable restore
#line 68 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\ShoppingCart\Index.cshtml"
                                        }
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n");
#nullable restore
#line 73 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\ShoppingCart\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Chưa có hàng hóa trong giỏ hàng</p>\r\n");
#nullable restore
#line 77 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\ShoppingCart\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""row"">
                        <div class=""col-lg-6 col-md-6 col-sm-6"">
                            <div class=""continue__btn"">
                                <a href=""shop.html"">Tiếp tục mua hàng</a>
                            </div>
                        </div>
                       
                    </div>
                </div>
                <div class=""col-lg-4"">
                    <div class=""cart__discount"">
                        <h6>Discount codes</h6>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f43c6df50699bc07b318ad8cd2c01e1fdb7cc8a14049", async() => {
                WriteLiteral("\r\n                            <input type=\"text\" placeholder=\"Coupon code\">\r\n                            <button type=\"submit\">Apply</button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"cart__total\">\r\n                        <h6>Thanh toán</h6>\r\n                        <ul>\r\n                            <li>Tổng <span>");
#nullable restore
#line 98 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\ShoppingCart\Index.cshtml"
                                      Write(Model.Sum(x => x.TotalMoney).ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</span></li>\r\n                        </ul>\r\n");
#nullable restore
#line 100 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\ShoppingCart\Index.cshtml"
                          if (User.Identity.IsAuthenticated)
                         {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a href=\"/checkout.html\" class=\"primary-btn\">Tiến hành thanh toán</a>\r\n");
#nullable restore
#line 103 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\ShoppingCart\Index.cshtml"
                         }
                         else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a href=\"/dang-nhap.html?returnUrl=/checkout.html\" class=\"primary-btn\">Tiến hành thanh toán</a>\r\n");
#nullable restore
#line 106 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\ShoppingCart\Index.cshtml"
                         }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n    <!-- Shopping Cart Section End -->\r\n</main>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(function () {
            function loadHeaderCart() {
                $(""#miniCart"").load(""/AjaxContent/HeaderCart"");
                $(""#numberCart"").load(""/AjaxContent/NumberCart"");
            }
            $("".removecart"").click(function () {
                var productid = $(this).attr(""data-mahh"");
                $.ajax({
                    url: ""api/cart/remove"",
                    type: ""POST"",
                    dataType: ""JSON"",
                    data: { productID: productid },
                    success: function (result) {
                        if (result.success) {
                            loadHeaderCart();//load lai gio
                            window.location = 'cart.html';
                            alert(""Xóa sản phâm thành công"");
                            
                        }
                    },
                    error: function (rs) {
                        alert(""Remove Cart Error!"");
                    }
    ");
                WriteLiteral(@"            });
            });
            $("".cartItem"").click(function () {
                var productid = $(this).attr(""data-mahh"");
                var soluong = parseInt($(this).val());
                console.log(soluong);
            $.ajax({
                url: ""api/cart/update"",
                type: ""POST"",
                dataType: ""JSON"",
                data: {
                    productID: productid,
                    amount: soluong
                },
                success: function (result) {
                    if (result.success) {
                        loadHeaderCart();//reload lai gio hang
                        window.location = 'cart.html';
                    }
                },
                error: function (rs) {
                    alert(""Cập nhật Cart error!"");
                }
            });
        });
            });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebShop.ModelViews.CartItem>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
