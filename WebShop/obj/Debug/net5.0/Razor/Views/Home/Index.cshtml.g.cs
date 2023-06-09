#pragma checksum "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c54df53088aa6a5740a9cdf0db6f4108be70bf7"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c54df53088aa6a5740a9cdf0db6f4108be70bf7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3df3320de4c2e3d10181e18c8e069dc52a6b106", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebShop.ModelViews.HomeViewVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/product-sale.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/icon/calendar.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    List<Product> allProduct = ViewBag.AllProducts;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Begin Slider Area -->

    <!-- Main Slider -->
<!-- Slider Area End Here -->
<!-- Hero Section Begin -->
<section class=""hero"">
    <div class=""hero__slider owl-carousel"">
        <div class=""hero__items set-bg"" data-setbg=""assets/img/hero/hero-1.jpg"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-xl-5 col-lg-7 col-md-8"">
                        <div class=""hero__text"">
                            <h6>Summer Collection</h6>
                            <h2>Fall - Winter Collections 2030</h2>
                            <p>
                                A specialist label creating luxury essentials. Ethically crafted with an unwavering
                                commitment to exceptional quality.
                            </p>
                            <a href=""#"" class=""primary-btn"">Shop now <span class=""arrow_right""></span></a>
                            <div class=""hero__social"">
                              ");
            WriteLiteral(@"  <a href=""#""><i class=""fa fa-facebook""></i></a>
                                <a href=""#""><i class=""fa fa-twitter""></i></a>
                                <a href=""#""><i class=""fa fa-pinterest""></i></a>
                                <a href=""#""><i class=""fa fa-instagram""></i></a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""hero__items set-bg"" data-setbg=""assets/img/hero/hero-2.jpg"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-xl-5 col-lg-7 col-md-8"">
                        <div class=""hero__text"">
                            <h6>Summer Collection</h6>
                            <h2>Fall - Winter Collections 2030</h2>
                            <p>
                                A specialist label creating luxury essentials. Ethically crafted with an unwavering
                                comm");
            WriteLiteral(@"itment to exceptional quality.
                            </p>
                            <a href=""#"" class=""primary-btn"">Shop now <span class=""arrow_right""></span></a>
                            <div class=""hero__social"">
                                <a href=""#""><i class=""fa fa-facebook""></i></a>
                                <a href=""#""><i class=""fa fa-twitter""></i></a>
                                <a href=""#""><i class=""fa fa-pinterest""></i></a>
                                <a href=""#""><i class=""fa fa-instagram""></i></a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Hero Section End -->
<!-- Banner Section Begin -->
<section class=""banner spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-7 offset-lg-4"">
                <div class=""banner__item"">
                    <div class=""banner__item__pic"">
   ");
            WriteLiteral("                     <img src=\"assets/img/banner/banner-1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 3270, "\"", 3276, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""banner__item__text"">
                        <h2>Clothing Collections 2030</h2>
                        <a href=""#"">Shop now</a>
                    </div>
                </div>
            </div>
            <div class=""col-lg-5"">
                <div class=""banner__item banner__item--middle"">
                    <div class=""banner__item__pic"">
                        <img src=""assets/img/banner/banner-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3763, "\"", 3769, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""banner__item__text"">
                        <h2>Accessories</h2>
                        <a href=""#"">Shop now</a>
                    </div>
                </div>
            </div>
            <div class=""col-lg-7"">
                <div class=""banner__item banner__item--last"">
                    <div class=""banner__item__pic"">
                        <img src=""assets/img/banner/banner-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4240, "\"", 4246, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""banner__item__text"">
                        <h2>Shoes Spring 2030</h2>
                        <a href=""#"">Shop now</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Banner Section End -->
<!-- Begin Shipping Area -->
<!-- Shipping Area End Here -->
<!-- Begin Product Area -->
<div class=""product-area section-space-top-100"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <ul class=""filter__controls"">
                    <li class=""active"" data-filter=""*"">Tất cả sản phẩm</li>
");
#nullable restore
#line 113 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\Home\Index.cshtml"
                      foreach (var item in Model.Products)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li><a");
            BeginWriteAttribute("href", " href=\"", 5047, "\"", 5077, 2);
            WriteAttributeValue("", 5054, "/", 5054, 1, true);
#nullable restore
#line 115 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\Home\Index.cshtml"
WriteAttributeValue("", 5055, item.category.CatName, 5055, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color: black\">");
#nullable restore
#line 115 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\Home\Index.cshtml"
                                                                              Write(item.category.CatName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 116 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\Home\Index.cshtml"
                   
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n                <div class=\"tab-content\" id=\"myTabContent\">\r\n                    <div class=\"tab-pane fade show active\" id=\"all-items\" role=\"tabpanel\" aria-labelledby=\"all-items-tab\">\r\n                       ");
#nullable restore
#line 121 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\Home\Index.cshtml"
                  Write(await Html.PartialAsync("ListProduct", allProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n\r\n");
#nullable restore
#line 124 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\Home\Index.cshtml"
                     foreach (var item in Model.Products)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"tab-pane fade\"");
            BeginWriteAttribute("id", " id=\"", 5623, "\"", 5648, 1);
#nullable restore
#line 126 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\Home\Index.cshtml"
WriteAttributeValue("", 5628, item.category.Alias, 5628, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"tabpanel\" aria-labelledby=\"fresh-fruits-tab\">\r\n                            ");
#nullable restore
#line 127 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\Home\Index.cshtml"
                       Write(await Html.PartialAsync("ListProduct", item.lsProducts));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 129 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                </div>
            </div>
        </div>
    </div>
</div>
<!-- Product Area End Here -->
<!-- Begin Product Area -->
<!-- Begin Banner Area -->
<!-- Banner Area End Here -->
<!-- Begin Product Area -->
<!-- Product Area End Here -->
<!-- Categories Section Begin -->
<section class=""categories spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-3"">
                <div class=""categories__text"">
                    <h2>Clothings Hot <br /> <span>Shoe Collection</span> <br /> Accessories</h2>
                </div>
            </div>
            <div class=""col-lg-4"">
                <div class=""categories__hot__deal"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8c54df53088aa6a5740a9cdf0db6f4108be70bf713358", async() => {
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
                    <div class=""hot__deal__sticker"">
                        <span>Sale Off</span>
                        <h5>$29.99</h5>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 offset-lg-1"">
                <div class=""categories__deal__countdown"">
                    <span>Deal Of The Week</span>
                    <h2>Multi-pocket Chest Bag Black</h2>
                    <div class=""categories__deal__countdown__timer"" id=""countdown"">
                        <div class=""cd-item"">
                            <span>3</span>
                            <p>Days</p>
                        </div>
                        <div class=""cd-item"">
                            <span>1</span>
                            <p>Hours</p>
                        </div>
                        <div class=""cd-item"">
                            <span>50</span>
                            <p>Minutes</p>
                        </div>
         ");
            WriteLiteral(@"               <div class=""cd-item"">
                            <span>18</span>
                            <p>Seconds</p>
                        </div>
                    </div>
                    <a href=""#"" class=""primary-btn"">Shop now</a>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Categories Section End -->
<!-- Instagram Section Begin -->
<section class=""instagram spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-8"">
                <div class=""instagram__pic"">
                    <div class=""instagram__pic__item set-bg"" data-setbg=""assets/img/instagram/instagram-1.jpg""></div>
                    <div class=""instagram__pic__item set-bg"" data-setbg=""assets/img/instagram/instagram-2.jpg""></div>
                    <div class=""instagram__pic__item set-bg"" data-setbg=""assets/img/instagram/instagram-3.jpg""></div>
                    <div class=""instagram__pic__item set-bg"" data-setbg=""assets/img/instagr");
            WriteLiteral(@"am/instagram-4.jpg""></div>
                    <div class=""instagram__pic__item set-bg"" data-setbg=""assets/img/instagram/instagram-5.jpg""></div>
                    <div class=""instagram__pic__item set-bg"" data-setbg=""assets/img/instagram/instagram-6.jpg""></div>
                </div>
            </div>
            <div class=""col-lg-4"">
                <div class=""instagram__text"">
                    <h2>Instagram</h2>
                    <p>
                        Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut
                        labore et dolore magna aliqua.
                    </p>
                    <h3>#Male_Fashion</h3>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Instagram Section End -->
<!-- Latest Blog Section Begin -->
<section class=""latest spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""section-title"">
 ");
            WriteLiteral("                   <span>Latest News</span>\r\n                    <h2>Fashion New Trends</h2>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n\r\n");
#nullable restore
#line 231 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\Home\Index.cshtml"
             foreach (var item in Model.TinTucs)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4 col-md-6 col-sm-6\">\r\n                <div class=\"blog__item\">\r\n                    <div class=\"blog__item__pic set-bg\" data-setbg=\"assets/img/blog/blog-1.jpg\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8c54df53088aa6a5740a9cdf0db6f4108be70bf718309", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 10170, "~/images/news/", 10170, 14, true);
#nullable restore
#line 236 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 10184, item.Thumb, 10184, 11, false);

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
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"blog__item__text\">\r\n                        <span>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8c54df53088aa6a5740a9cdf0db6f4108be70bf719905", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" 16 February 2020</span>\r\n                        <h5>");
#nullable restore
#line 240 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\Home\Index.cshtml"
                       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <a href=\"#\">Read More</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 245 "D:\.Net\MVC5\QuanAo\WebsiteThoiTrang\WebShop\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("           \r\n            \r\n\r\n\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- Latest Blog Section End -->\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $("".product-name"").each(function (i) {
                var len = $(this).text().trim().length;
                if (len > 35) {
                    $(this).text($(this).text().substr(0, 35) + '...');
                }
            });
        });
    </script>

");
            }
            );
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebShop.ModelViews.HomeViewVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
