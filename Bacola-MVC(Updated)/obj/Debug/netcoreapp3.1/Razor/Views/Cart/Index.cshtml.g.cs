#pragma checksum "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Bacola - Slider(Crud)\Bacola-MVC(Updated)\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3e251ebea02a1763a46fcad6424325edb1c9b7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3e251ebea02a1763a46fcad6424325edb1c9b7b", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1298365c1eacdb00b69ccaa240d5fe90460039ad", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Bacola - Slider(Crud)\Bacola-MVC(Updated)\Views\Cart\Index.cshtml"
  
    ViewData["Title"] = "Cart";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main>
    <section id=""root"">
        <div class=""root"">
            <div class=""container"">
                <a href=""index.html"">HOME</a>
                <i class=""fas fa-angle-right""></i>
                <span>MY ACCOUNT</span>
            </div>
        </div>
    </section>
    <section id=""cart-updated-message"">
        <div class=""cart-updated-message mt-3"">
            <div class=""container"">
                <p>Cart updated.</p>
            </div>

        </div>
    </section>
    <section id=""cart-page-content"">
        <div class=""cart-page-content"">
            <div class=""container"">
                <div class=""row mt-4"">
                    <div class=""col-8"">
                        <div class=""cart-page-table"">
                            <table>
                                <tr>
                                    <th></th>
                                    <th>Product</th>
                                    <th>Price</th>
                                 ");
            WriteLiteral("   <th>Quantity</th>\r\n                                    <th>Subtotal</th>\r\n                                </tr>\r\n                                <tr>\r\n                                    <td><img src=\"./assets/img/italian-meatballs.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1305, "\"", 1311, 0);
            EndWriteAttribute();
            WriteLiteral(@"></td>
                                    <td>All Natural Italian-Style Chicken Meatballs</td>
                                    <td>$7.25</td>
                                    <td>
                                        <button>
                                            <i class=""fas fa-minus""></i>
                                        </button>
                                        <span>1</span>
                                        <button>
                                            <i class=""fas fa-plus""></i>
                                        </button>
                                    </td>
                                    <td>$7.25</td>
                                    <td><i style=""cursor: pointer;"" class=""fas fa-times""></i></td>
                                </tr>
                                <tr>
                                    <td><img src=""./assets/img/boom-chicka.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2260, "\"", 2266, 0);
            EndWriteAttribute();
            WriteLiteral(@"></td>
                                    <td>Angie's Boomchickapop Sweet & Salty Kettle Corn</td>
                                    <td>$3.29</td>
                                    <td>
                                        <button class=""cart-page-minus-button"">
                                            <i class=""fas fa-minus""></i>
                                        </button>
                                        <span>1</span>
                                        <button class=""cart-page-minus-plus"">
                                            <i class=""fas fa-plus""></i>
                                        </button>
                                    </td>
                                    <td>$3.29</td>
                                    <td><i style=""cursor: pointer;"" class=""fas fa-times""></i></td>
                                </tr>
                            </table>
                        </div>
                        <div class=""coupon mt-4"">
        ");
            WriteLiteral(@"                    <div class=""row"">
                                <div class=""col-8"">
                                    <div class=""apply"">
                                        <input type=""text"" class=""form-control"" placeholder=""Coupon code""
                                               aria-label=""Username"" aria-describedby=""basic-addon1"">
                                        <button type=""button"" class=""btn btn-primary apply-btn"">
                                            Apply
                                            coupon
                                        </button>
                                    </div>

                                </div>
                                <div class=""col-4"">
                                    <div class=""update"">
                                        <button type=""button"" class=""btn btn-primary update-btn disabled"">
                                            Update
                                            cart
      ");
            WriteLiteral(@"                                  </button>
                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>
                    <div class=""col-4"">
                        <div class=""cart-totals"">
                            <h5>CART TOTALS</h5>
                            <hr>
                            <div class=""subtotal"">
                                <strong>Subtotal</strong>
                                <span>$21.08</span>
                            </div>
                            <div class=""shipping mt-4"">
                                <div class=""row "">
                                    <div class=""col-4"">
                                        <div class=""shipping-title"">
                                            <strong>Shipping</strong>
                                        </div>
                                    </div>
                      ");
            WriteLiteral(@"              <div class=""col-8"">
                                        <div class=""shipping-content"">
                                            <ul>
                                                <li>

                                                    <label class=""form-check-label"" for=""flexRadioDefault1"">
                                                        <span>Flat rate:</span>
                                                        <span style=""color: rgb(248, 62, 62);"">$5.00</span>
                                                    </label>
                                                    <input class=""form-check-input"" type=""radio""
                                                           name=""flexRadioDefault"" id=""flexRadioDefault1"">



                                                </li>
                                                <li>
                                                    <label class=""form-check-label"" for=""flexRadioDefault1"">
                  ");
            WriteLiteral(@"                                      <span>Free shipping</span>
                                                    </label>
                                                    <input class=""form-check-input"" type=""radio""
                                                           name=""flexRadioDefault"" id=""flexRadioDefault1"">

                                                </li>
                                                <li>
                                                    <label class=""form-check-label"" for=""flexRadioDefault1"">
                                                        <span>Local pickup</span>
                                                    </label>
                                                    <input class=""form-check-input"" type=""radio""
                                                           name=""flexRadioDefault"" id=""flexRadioDefault1"">

                                                </li>
                                                <li>
       ");
            WriteLiteral(@"                                             <label class=""form-check-label"" for=""flexRadioDefault1"">
                                                        <span>Shipping to</span>
                                                        <strong>AL.</strong>
                                                    </label>

                                                </li>
                                                <li class=""mt-4"">
                                                    <a");
            BeginWriteAttribute("href", " href=\"", 7890, "\"", 7897, 0);
            EndWriteAttribute();
            WriteLiteral(@">Change address</a>
                                                </li>
                                            </ul>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""car-page-total-price mt-3"">
                                <span>Total</span>
                                <strong>$26.08</strong>
                            </div>
                            <div class=""proceed"">
                                <div class=""row"">
                                    <button type=""button"" class=""btn btn-danger"">Proceed to checkout</button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</main>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591