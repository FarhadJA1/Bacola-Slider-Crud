#pragma checksum "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Bacola - Slider(Crud)\Bacola-MVC(Updated)\Views\Shared\Components\Header\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2f9a1d917b921b3034a031d1891567dfcf31870"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Header_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Header/Default.cshtml")]
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
#line 1 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Bacola - Slider(Crud)\Bacola-MVC(Updated)\Views\_ViewImports.cshtml"
using Bacola_MVC_Updated_;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Bacola - Slider(Crud)\Bacola-MVC(Updated)\Views\_ViewImports.cshtml"
using Bacola_MVC_Updated_.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Bacola - Slider(Crud)\Bacola-MVC(Updated)\Views\_ViewImports.cshtml"
using Bacola_MVC_Updated_.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2f9a1d917b921b3034a031d1891567dfcf31870", @"/Views/Shared/Components/Header/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1298365c1eacdb00b69ccaa240d5fe90460039ad", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Header_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dictionary<string, string>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<header>

    <section>
        <div class=""top-info"">
            <p>Due to the</p>
            <p class=""second-p"">COVID 19</p>
            <p>epidemic, orders may be processed with a slight delay</p>
        </div>
    </section>
    <section>
        <div class=""container"">
            <div class=""row top"">
                <div class=""col-md-4 col-sm-6 top-nav"">
                    <nav>
                        <ul>
                            <li><a href=""about.html"">About Us</a></li>
                            <li><a href=""login.html"">My Account</a></li>
                            <li><a");
            BeginWriteAttribute("href", " href=\"", 654, "\"", 661, 0);
            EndWriteAttribute();
            WriteLiteral(">Wishlist</a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 716, "\"", 723, 0);
            EndWriteAttribute();
            WriteLiteral(@">Order Tracking</a></li>
                        </ul>
                    </nav>
                </div>
                <div class=""row top-right col-md-8 col-sm-6"">
                    <div class=""col-md-5 col-sm-4 top-center-info"">
                        <i class=""fas fa-hand-paper""></i>
                        <span>100% Secure delivery without contacting the courier</span>
                    </div>
                    <div class=""col-md-3 col-sm-4 top-help"">
                        <span>Need help? Call Us:</span>
                        <a");
            BeginWriteAttribute("href", " href=\"", 1288, "\"", 1295, 0);
            EndWriteAttribute();
            WriteLiteral(@">+ 0020 500</a>
                    </div>
                    <div class=""col-md-4 sm-4 top-drops"">
                        <div class=""drop"">
                            <div class=""lang-drop"">
                                <button class=""drop-btn btn-left"">
                                    English
                                    <i class=""fa fa-caret-down""></i>
                                </button>
                                <div class=""drop-content-left d-none"">
                                    <a href=""#"">English</a>
                                    <a href=""#"">Spanish</a>
                                    <a href=""#"">German</a>
                                </div>
                            </div>
                            <div class=""money-drop"">
                                <button class=""drop-btn btn-right"">
                                    USD
                                    <i class=""fa fa-caret-down""></i>
                                <");
            WriteLiteral(@"/button>
                                <div class=""drop-content-right d-none"">
                                    <a href=""#"">USD</a>
                                    <a href=""#"">INR</a>
                                    <a href=""#"">GBT</a>
                                </div>
                            </div>
                        </div>

                    </div>
                </div>
            </div>
            <hr>
            <div class=""row"">
                <div class=""logo col-md-2 col-sm-2"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2f9a1d917b921b3034a031d1891567dfcf318708896", async() => {
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f2f9a1d917b921b3034a031d1891567dfcf318709175", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2959, "~/assets/img/", 2959, 13, true);
#nullable restore
#line 66 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Bacola - Slider(Crud)\Bacola-MVC(Updated)\Views\Shared\Components\Header\Default.cshtml"
AddHtmlAttributeValue("", 2972, Model["HeaderLogo"], 2972, 20, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        <span style=\"text-decoration:none\">Online Grocery Shopping Center</span>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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

                </div>
                <div class=""row select-location col-md-2 col-sm-2"">
                    <button type=""button"" class=""btn btn-light"" data-bs-toggle=""modal""
                            data-bs-target=""#exampleModal"">
                        <div class=""row"">
                            <div class=""col-10"">
                                <p class=""your-location-text"">Your Location</p>
                                <p class=""select-location-text"">Select a location</p>
                            </div>
                            <div class=""col-2"">
                                <i class=""fas fa-angle-down""></i>
                            </div>
                        </div>
                    </button>
                    <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel""
                         aria-hidden=""true"">
                        <div class=""modal-dialog modal-dialog-scrollable"">
                            <di");
            WriteLiteral(@"v class=""modal-content"">
                                <div class=""modal-header"">
                                    <p class=""modal-title"" id=""exampleModalLabel"">Choose your Delivery Location</p>
                                    <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal""
                                            aria-label=""Close""></button>

                                </div>

                                <p class=""modal-info"">
                                    Enter your address and we will specify the offer for your
                                    area.
                                </p>
                                <div class=""modal-body"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2f9a1d917b921b3034a031d1891567dfcf3187013954", async() => {
                WriteLiteral("\r\n                                        <input class=\"form-control me-2 search-area\" type=\"search\"\r\n                                               placeholder=\"Search your area\" aria-label=\"Search\">\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    <div class=\"select\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 5265, "\"", 5272, 0);
            EndWriteAttribute();
            WriteLiteral(">Choose your loaction</a>\r\n                                        <span>Clear All</span>\r\n                                    </div>\r\n                                    <div class=\"select\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 5508, "\"", 5515, 0);
            EndWriteAttribute();
            WriteLiteral(">Alabama</a>\r\n                                        <span>Min: $130</span>\r\n                                    </div>\r\n                                    <div class=\"select\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 5738, "\"", 5745, 0);
            EndWriteAttribute();
            WriteLiteral(">Alaska</a>\r\n                                        <span>$120</span>\r\n                                    </div>\r\n                                    <div class=\"select\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 5962, "\"", 5969, 0);
            EndWriteAttribute();
            WriteLiteral(">Arizona</a>\r\n                                        <span>$150</span>\r\n                                    </div>\r\n                                    <div class=\"select\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 6187, "\"", 6194, 0);
            EndWriteAttribute();
            WriteLiteral(">California</a>\r\n                                        <span>$110</span>\r\n                                    </div>\r\n                                    <div class=\"select\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 6415, "\"", 6422, 0);
            EndWriteAttribute();
            WriteLiteral(">Colorado</a>\r\n                                        <span>$140</span>\r\n                                    </div>\r\n                                    <div class=\"select\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 6641, "\"", 6648, 0);
            EndWriteAttribute();
            WriteLiteral(">Florida</a>\r\n                                        <span>$160</span>\r\n                                    </div>\r\n                                    <div class=\"select\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 6866, "\"", 6873, 0);
            EndWriteAttribute();
            WriteLiteral(">Georgia</a>\r\n                                        <span>$120</span>\r\n                                    </div>\r\n                                    <div class=\"select\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 7091, "\"", 7098, 0);
            EndWriteAttribute();
            WriteLiteral(">Kansas</a>\r\n                                        <span>$170</span>\r\n                                    </div>\r\n                                    <div class=\"select\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 7315, "\"", 7322, 0);
            EndWriteAttribute();
            WriteLiteral(">Minessota</a>\r\n                                        <span>$120</span>\r\n                                    </div>\r\n                                    <div class=\"select\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 7542, "\"", 7549, 0);
            EndWriteAttribute();
            WriteLiteral(">New York</a>\r\n                                        <span>$110</span>\r\n                                    </div>\r\n                                    <div class=\"select\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 7768, "\"", 7775, 0);
            EndWriteAttribute();
            WriteLiteral(@">Wasgington</a>
                                        <span>$130</span>
                                    </div>

                                </div>

                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-5 search"">
                    <input class=""form-control mr-sm-2"" type=""search"" placeholder=""Search for products""
                           aria-label=""Search"">
                    <i class=""fas fa-search""></i>
                </div>
                <div class=""row col-md-3 col-sm-3"">
                    <div class=""col-3 account"">
                        <i class=""fas fa-user-circle""></i>
                    </div>
                    <div class=""col-3 total-price"">
                        <span>$0.00</span>
                    </div>
                    <div class=""col-3 cart"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2f9a1d917b921b3034a031d1891567dfcf3187020791", async() => {
                WriteLiteral("\r\n                            <i class=\"fas fa-shopping-basket\"></i><sup><span>0</span></sup>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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

                    </div>
                </div>

            </div>
            <div class=""A row mt-3"">
                <div class=""dropdown categories col-md-3"">
                    <div class=""btn-group"">
                        <button class=""btn btn-secondary btn-lg dropdown-toggle"" type=""button"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                            <i class=""fas fa-bars""></i> All categories <span>TOTAL 63 PRODUCTS</span>
                        </button>
                        ");
#nullable restore
#line 186 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Bacola - Slider(Crud)\Bacola-MVC(Updated)\Views\Shared\Components\Header\Default.cshtml"
                   Write(await Component.InvokeAsync("Category"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""col-md-8 nav-buttons"">
                    <ul>
                        <li>
                            <button id=""home-btn"" type=""button"" class=""btn btn-light"">
                                <a href=""index.html"">HOME</a>
                                <i class=""fa fa-caret-down""></i>
                            </button>
                        </li>
                        <li>
                            <button id=""shop-btn"" type=""button"" class=""btn btn-light"">
                                <a href=""shop.html"">SHOP</a>
                                <i class=""fa fa-caret-down""></i>
                            </button>
                        </li>
                        <li>
                            <button type=""button"" class=""btn btn-light"">
                                <i class=""fas fa-fish""></i>MEATS &
                                SEAFOOD
                            </button>
       ");
            WriteLiteral(@"                 </li>
                        <li>
                            <button type=""button"" class=""btn btn-light"">
                                <i class=""fas fa-bread-slice""></i>BAKERY
                            </button>
                        </li>
                        <li>
                            <button type=""button"" class=""btn btn-light"">
                                <i class=""fas fa-mug-hot""></i>BEVERAGES
                            </button>
                        </li>
                        <li><button type=""button"" class=""btn btn-light""><a href=""blog.html"">BLOG</a></button></li>
                        <li>
                            <button type=""button"" class=""btn btn-light""><a href=""contact.html"">CONTACT</a></button>
                        </li>

                    </ul>

                </div>

            </div>
            <div class=""home-shop"">
                <div class=""row"">
                    <div class=""home-nav"">
                  ");
            WriteLiteral("      <ul>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 11547, "\"", 11554, 0);
            EndWriteAttribute();
            WriteLiteral(">HOME 1</a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 11607, "\"", 11614, 0);
            EndWriteAttribute();
            WriteLiteral(">HOME 2</a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 11667, "\"", 11674, 0);
            EndWriteAttribute();
            WriteLiteral(">HOME 3</a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 11727, "\"", 11734, 0);
            EndWriteAttribute();
            WriteLiteral(@">HOME 4</a></li>
                        </ul>
                    </div>
                    <div class=""shop-nav col-12"">
                        <ul>
                            <span>Shop List</span>
                            <li>Shop Default</li>
                            <li>Shop Right Sidebar</li>
                            <li>Shop Wide</li>
                            <li>List Left Sidebar</li>
                            <li>Load More Button</li>
                            <li>Infinite Scrolling</li>
                        </ul>
                        <ul>
                            <span>Product Detail</span>
                            <li>Product Detail</li>
                            <li>Product Variable</li>
                            <li>Product Grouped</li>
                            <li>Product External</li>
                            <li>Product Downloadable</li>
                            <li>Product With Video</li>
                        </ul>
        ");
            WriteLiteral(@"                <ul>
                            <span>Product Types</span>
                            <li>Single Type 1</li>
                            <li>Single Type 2</li>
                            <li>Single Type 3</li>
                            <li>Single Type 4</li>
                            <li>Thumbnails Left</li>
                            <li>Zoom Image</li>
                        </ul>
                        <ul>
                            <span>Shop Pages</span>
                            <li>Cart</li>
                            <li>Checkout</li>
                            <li>My Account</li>
                            <li>Wishlist</li>
                            <li>Order Tracking</li>
                            <li>Order on Whatsapp</li>
                        </ul>
                        <ul>
                            <span>Shop Layouts</span>
                            <li>Two Columns</li>
                            <li>Three Columns</li>
        ");
            WriteLiteral(@"                    <li>Three Columns Wide</li>
                            <li>Four Columns</li>
                            <li>Four Columns Wide</li>
                            <li>Five Columns Wide</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>

        </div>
    </section>

</header>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dictionary<string, string>> Html { get; private set; }
    }
}
#pragma warning restore 1591