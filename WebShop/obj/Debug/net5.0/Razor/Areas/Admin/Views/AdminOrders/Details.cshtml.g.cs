#pragma checksum "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Areas\Admin\Views\AdminOrders\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba4bad09afc9c8c6abf35c009b487c33da704d5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminOrders_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminOrders/Details.cshtml")]
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
#line 1 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Areas\Admin\Views\_ViewImports.cshtml"
using WebShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Areas\Admin\Views\_ViewImports.cshtml"
using WebShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba4bad09afc9c8c6abf35c009b487c33da704d5e", @"/Areas/Admin/Views/AdminOrders/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ab36eb20ee5fe358bbb48f5f3c54abcde02ada9", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_AdminOrders_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebShop.Models.Order>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("breadcrumb-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminOrders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Areas\Admin\Views\AdminOrders\Details.cshtml"
  
    ViewData["Title"] = "Thông tin đơn hàng";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";
    List<OrderDetail> orderDetails = ViewBag.ChiTiet;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"



<!-- Content Wrapper START -->
<div class=""main-content"">
    <div class=""page-header"">
        <h2 class=""header-title"">Chi tiết đơn hàng</h2>
        <div class=""header-sub-title"">
            <nav class=""breadcrumb breadcrumb-dash"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba4bad09afc9c8c6abf35c009b487c33da704d5e5444", async() => {
                WriteLiteral("<i class=\"anticon anticon-home m-r-5\"></i>Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba4bad09afc9c8c6abf35c009b487c33da704d5e7146", async() => {
                WriteLiteral("Danh sách đơn hàng");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

            </nav>
        </div>
    </div>
    <div class=""container"">
        <div class=""card"">
            <div class=""card-body"">
                <div id=""invoice"" class=""p-h-30"">
                    <div class=""m-t-15 lh-2"">
                        <div class=""inline-block"">
                            <img class=""img-fluid"" src=""assets/images/logo/logo.png""");
            BeginWriteAttribute("alt", " alt=\"", 1119, "\"", 1125, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <address class=""p-l-10"">
                                <span class=""font-weight-semibold text-dark"">SHOP</span><br>
                                <span>Địa chỉ: Hoàng Mai -Hà Nội</span><br>

                                <abbr class=""text-dark"" title=""Phone"">Phone:</abbr>
                                <span>(123) 456-7890</span>
                            </address>
                        </div>
                        <div class=""float-right"">
                            <h2>Chi tiết đơn hàng</h2>
                        </div>
                    </div>
                    <div class=""row m-t-20 lh-2"">
                        <div class=""col-sm-9"">
                            <h3 class=""p-l-10 m-t-10"">Khách hàng:</h3>
                            <address class=""p-l-10 m-t-10"">
                                <span class=""font-weight-semibold text-dark"">");
#nullable restore
#line 48 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Areas\Admin\Views\AdminOrders\Details.cshtml"
                                                                        Write(Model.Customer.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br>\r\n                                <span>Địa chỉ: ");
#nullable restore
#line 49 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Areas\Admin\Views\AdminOrders\Details.cshtml"
                                          Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br>\r\n                                <span>Phone: ");
#nullable restore
#line 50 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Areas\Admin\Views\AdminOrders\Details.cshtml"
                                        Write(Model.Customer.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </address>
                        </div>
                        <div class=""col-sm-3"">
                            <div class=""m-t-80"">
                                <div class=""text-dark text-uppercase d-inline-block"">
                                    <span class=""font-weight-semibold text-dark"">Mã đơn hàng :</span>
                                </div>
                                <div class=""float-right"">");
#nullable restore
#line 58 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Areas\Admin\Views\AdminOrders\Details.cshtml"
                                                    Write(Model.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                            </div>
                            <div class=""text-dark text-uppercase d-inline-block"">
                                <span class=""font-weight-semibold text-dark"">Ngày mua :</span>
                            </div>
                            <div class=""float-right"">");
#nullable restore
#line 63 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Areas\Admin\Views\AdminOrders\Details.cshtml"
                                                Write(Model.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                        </div>
                    </div>
                    <div class=""m-t-20"">
                        <div class=""table-responsive"">
                            <table class=""table"">
                                <thead>
                                    <tr>
                                        <th>STT</th>
                                        <th>ID</th>
                                        <th>Số lượng</th>
                                        <th>Đơn giá</th>
                                        <th>Tổng tiền</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 79 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Areas\Admin\Views\AdminOrders\Details.cshtml"
                                     if (orderDetails != null && orderDetails.Count() > 0)
                                    {
                                        int i = 1;
                                        foreach (var item in orderDetails)
                                        {
                                            string url = "/";

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <th>");
#nullable restore
#line 86 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Areas\Admin\Views\AdminOrders\Details.cshtml"
                                               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                                <td><a href=\"#\">");
#nullable restore
#line 87 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Areas\Admin\Views\AdminOrders\Details.cshtml"
                                                           Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                                <td>");
#nullable restore
#line 88 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Areas\Admin\Views\AdminOrders\Details.cshtml"
                                               Write(item.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 89 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Areas\Admin\Views\AdminOrders\Details.cshtml"
                                               Write(item.Price.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VND</td>\r\n                                              <td>");
#nullable restore
#line 90 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Areas\Admin\Views\AdminOrders\Details.cshtml"
                                              Write(item.Amount * item.Price.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("VND</td>\r\n\r\n                                            </tr>\r\n");
#nullable restore
#line 93 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Areas\Admin\Views\AdminOrders\Details.cshtml"
                                            i++;
                                        }
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </tbody>
                            </table>
                        </div>
                        <div class=""row m-t-30 lh-1-8"">
                            <div class=""col-sm-12"">
                                <div class=""float-right text-right"">

                                    <h3><span class=""font-weight-semibold text-dark"">Tổng tiền :</span>");
#nullable restore
#line 104 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Areas\Admin\Views\AdminOrders\Details.cshtml"
                                                                                                  Write(Model.TotalMoney.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" VND</h3>
                                </div>
                            </div>
                        </div>
                        <div class=""row m-t-30 lh-2"">
                            <div class=""col-sm-12"">
                                <div class=""border-bottom p-v-20"">
                                    <p class=""text-opacity""><small>In exceptional circumstances, Financial Services can provide an urgent manually processed special cheque. Note, however, that urgent special cheques should be requested only on an emergency basis as manually produced cheques involve duplication of effort and considerable staff resources. Requests need to be supported by a letter explaining the circumstances to justify the special cheque payment.</small></p>
                                </div>
                            </div>
                        </div>
                        <div class=""row m-v-20"">
                            <div class=""col-sm-6"">
                                <img cla");
            WriteLiteral("ss=\"img-fluid text-opacity m-t-5\" width=\"100\" src=\"assets/images/logo/logo.png\"");
            BeginWriteAttribute("alt", " alt=\"", 6301, "\"", 6307, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""col-sm-6 text-right"">
                                <small><span class=""font-weight-semibold text-dark"">Phone:</span> (123) 456-7890</small>
                                <br>
                                <small>support@themenate.com</small>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Content Wrapper END -->
<!-- Footer START -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebShop.Models.Order> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
