#pragma checksum "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\Checkout\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e6637d15a051c8e7db4e8d1f3b22773ffeb62c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Checkout_Index), @"mvc.1.0.view", @"/Views/Checkout/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e6637d15a051c8e7db4e8d1f3b22773ffeb62c6", @"/Views/Checkout/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3df3320de4c2e3d10181e18c8e069dc52a6b106", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Checkout_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebShop.ModelViews.MuaHangVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/slider/bg/slide2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Họ và tên"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Số điện thoại"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Địa chỉ nhận hàng"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\Checkout\Index.cshtml"
  
    ViewData["Title"] = "Mua hàng";
    Layout = "~/Views/Shared/_Layout.cshtml";
    List<WebShop.ModelViews.CartItem> Carts = ViewBag.GioHang;

#line default
#line hidden
#nullable disable
            WriteLiteral("<main class=\"main-content\">\r\n    <div class=\"breadcrumb-area breadcrumb-height\" >\r\n        <div class=\"container h-100\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9e6637d15a051c8e7db4e8d1f3b22773ffeb62c67033", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <div class=""row h-100"">
                <div class=""col-lg-12"">
                    
                </div>
            </div>
        </div>
    </div>
    <div class=""checkout-area section-space-y-axis-100"">
        <div class=""container"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e6637d15a051c8e7db4e8d1f3b22773ffeb62c68345", async() => {
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9e6637d15a051c8e7db4e8d1f3b22773ffeb62c68619", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#nullable restore
#line 22 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\Checkout\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CustomerId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                <div class=""row"">
                    <div class=""col-lg-6 col-12"">

                        <div class=""checkbox-form"">
                            <h3>Thông tin đơn hàng</h3>
                            <div class=""row"">

                                <div class=""col-md-12"">
                                    <div class=""checkout-form-list"">
                                        <label>Họ và tên</label>
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9e6637d15a051c8e7db4e8d1f3b22773ffeb62c610913", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 33 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\Checkout\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FullName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""col-md-12"">
                                    <div class=""checkout-form-list"">
                                        <label>Số điện thoại <span class=""required"">*</span></label>
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9e6637d15a051c8e7db4e8d1f3b22773ffeb62c613143", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 39 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\Checkout\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Phone);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""col-md-12"">
                                    <div class=""checkout-form-list"">
                                        <label>Địa chỉ nhận hàng <span class=""required"">*</span></label>
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9e6637d15a051c8e7db4e8d1f3b22773ffeb62c615374", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 45 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\Checkout\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Address);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n");
                WriteLiteral(@"

                            </div>

                        </div>

                    </div>
                    <div class=""col-lg-6 col-12"">
                        <div class=""your-order"">
                            <h3>Thông tin đơn hàng</h3>
                            <div class=""your-order-table table-responsive"">
                                <table class=""table"">
                                    <thead>
                                        <tr>
                                            <th class=""cart-product-name"">Sản phẩm</th>
                                            <th class=""cart-product-total"">Thành tiền</th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
#nullable restore
#line 91 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\Checkout\Index.cshtml"
                                         if (Carts.Count() > 0)
                                        {
                                            foreach (var item in Carts)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <tr class=\"cart_item\">\r\n                                                    <td class=\"cart-product-name\">\r\n                                                        ");
#nullable restore
#line 97 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\Checkout\Index.cshtml"
                                                   Write(item.product.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("<strong class=\"product-quantity\">\r\n                                                            × ");
#nullable restore
#line 98 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\Checkout\Index.cshtml"
                                                         Write(item.amount);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                        </strong>\r\n                                                    </td>\r\n                                                    <td class=\"cart-product-total\"><span class=\"amount\">");
#nullable restore
#line 101 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\Checkout\Index.cshtml"
                                                                                                   Write(item.TotalMoney.ToString("#,##0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" VNĐ</span></td>\r\n                                                </tr>\r\n");
#nullable restore
#line 103 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\Checkout\Index.cshtml"
                                            }
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                                    </tbody>
                                    <tfoot>

                                        <tr class=""order-total"">
                                            <th>Tổng đơn hàng</th>
                                            <td><strong><span class=""amount"">");
#nullable restore
#line 112 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\Checkout\Index.cshtml"
                                                                        Write(Carts.Sum(x => x.TotalMoney).ToString("#,##0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@" VNĐ</span></strong></td>
                                        </tr>
                                    </tfoot>
                                </table>
                            </div>
                            <div class=""payment-method"">
                                <div class=""payment-accordion"">
                                    <div id=""accordion"">
                                        <div class=""card"">
                                            <div class=""card-header"" id=""#payment-1"">
                                                <h5 class=""panel-title"">
                                                    <a href=""javascript:void(0)""");
                BeginWriteAttribute("class", " class=\"", 6893, "\"", 6901, 0);
                EndWriteAttribute();
                WriteLiteral(@" data-bs-toggle=""collapse"" data-bs-target=""#collapseOne"" aria-expanded=""true"">
                                                        Thanh toán khi giao hàng (COD)
                                                    </a>
                                                </h5>
                                            </div>
                                            <div id=""collapseOne"" class=""collapse show"" data-bs-parent=""#accordion"">
                                                <div class=""card-body"">
                                                    <p>
                                                        Khách hàng sẽ thanh toán khi nhận hàng
                                                    </p>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""card"">
                                            <div class=""card-header"" id=""");
                WriteLiteral(@"#payment-2"">
                                                <h5 class=""panel-title"">
                                                    <a href=""javascript:void(0)"" class=""collapsed"" data-bs-toggle=""collapse"" data-bs-target=""#collapseTwo"" aria-expanded=""false"">
                                                        Chuyển khoản qua ngân hàng
                                                    </a>
                                                </h5>
                                            </div>
                                            <div id=""collapseTwo"" class=""collapse"" data-bs-parent=""#accordion"">
                                                <div class=""card-body"">
                                                    <p>
                                                        Thông tin tài khoản ngân hàng
                                                    </p>
                                                </div>
                                            </div>
            ");
                WriteLiteral(@"                            </div>
                                        <div class=""card"">
                                            <div class=""card-header"" id=""#payment-3"">
                                                <h5 class=""panel-title"">
                                                    <a href=""javascript:void(0)"" class=""collapsed"" data-bs-toggle=""collapse"" data-bs-target=""#collapseThree"" aria-expanded=""false"">
                                                        Thanh toán qua Momo
                                                    </a>
                                                </h5>
                                            </div>
                                            <div id=""collapseThree"" class=""collapse"" data-bs-parent=""#accordion"">
                                                <div class=""card-body"">
                                                    <p>
                                                        Thông tin Momo
                           ");
                WriteLiteral(@"                         </p>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""order-button-payment"">
                                        <input value=""Xác nhận"" type=""submit"">
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</main>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@" 
    <script>
        $(document).ready(function () {
            $('select').niceSelect();
            $(function () {
                $(""#TinhThanh"").change(function () {
                    var locationid = $('#TinhThanh').val();
                    $.ajax({
                        url: '/Location/QuanHuyenList',
                        type: ""GET"",
                        dataType: ""JSON"",
                        data: {
                            LocationId: locationid
                        },
                        success: function (QuanHuyens) {
                            $(""#QuanHuyen"").empty();
                            $(""#PhuongXa"").empty();
                            var strPhuongXa = '<option value="""" disabled selected>Phường / Xã</option>';
                            $(""#PhuongXa"").append(strPhuongXa);
                            var strQuanHuyen = '<option value="""" disabled selected>Quận/Huyện</option>';
                            $(""#QuanHuyen"").append(strQuanHu");
                WriteLiteral(@"yen);
                            $.each(QuanHuyens, function (i, item) {
                                var option = '<option value =""' + item.locationId + '"">' + item.nameWithType + '</option>';
                                $(""#QuanHuyen"").append(option);
                            });
                            $('select').niceSelect('update');
                        }
                    });
                });

                $(""#QuanHuyen"").change(function () {
                    var locationid = $('#QuanHuyen').val();
                    $.ajax({
                        url: '/Location/PhuongXaList',
                        type: ""GET"",
                        dataType: ""JSON"",
                        data: { LocationId: locationid },
                        success: function (PhuongXaList) {
                            $(""#PhuongXa"").empty();
                            var readonly = '<option value="""" disabled selected>Phường / Xã</option>';
                            $(");
                WriteLiteral(@"""#PhuongXa"").append(readonly);
                            $.each(PhuongXaList, function (i, item) {
                                var option = '<option value =""' + item.locationId + '"">' + item.nameWithType + '</option>';
                                $(""#PhuongXa"").append(option);
                            });
                            $('select').niceSelect('update');
                        }
                    });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebShop.ModelViews.MuaHangVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
