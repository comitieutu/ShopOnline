#pragma checksum "C:\Users\User\source\repos\BookLib\BookStore\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2af8e0121de619dfb104fbd970e81aaa91f304a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Details.cshtml", typeof(AspNetCore.Views_Product_Details))]
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
#line 1 "C:\Users\User\source\repos\BookLib\BookStore\Views\_ViewImports.cshtml"
using BookStore.Controllers;

#line default
#line hidden
#line 2 "C:\Users\User\source\repos\BookLib\BookStore\Views\_ViewImports.cshtml"
using BookStore.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\User\source\repos\BookLib\BookStore\Views\_ViewImports.cshtml"
using BookStore.Data;

#line default
#line hidden
#line 4 "C:\Users\User\source\repos\BookLib\BookStore\Views\_ViewImports.cshtml"
using BookStore.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2af8e0121de619dfb104fbd970e81aaa91f304a6", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e00bc9c17310c5da204e7272d2ee4c56da5d9ea9", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\User\source\repos\BookLib\BookStore\Views\Product\Details.cshtml"
  
    ViewBag.Title = "Detail";

#line default
#line hidden
            BeginContext(38, 21092, true);
            WriteLiteral(@"
<!--content-->
<div class=""content"">
    <!--single-->
    <div class=""single-wl3"">
        <div class=""container"">
            <div class=""single-grids"">
                <div class=""col-md-9 single-grid"">
                    <div clas=""single-top"">
                        <div class=""single-left"">
                            <div class=""flexslider"">
                                <ul class=""slides"">
                                    <li data-thumb=""images/si.jpg"">
                                        <div class=""thumb-image""> <img src=""images/si.jpg"" data-imagezoom=""true"" class=""img-responsive""> </div>
                                    </li>
                                    <li data-thumb=""images/si1.jpg"">
                                        <div class=""thumb-image""> <img src=""images/si1.jpg"" data-imagezoom=""true"" class=""img-responsive""> </div>
                                    </li>
                                    <li data-thumb=""images/si2.jpg"">
                    ");
            WriteLiteral(@"                    <div class=""thumb-image""> <img src=""images/si2.jpg"" data-imagezoom=""true"" class=""img-responsive""> </div>
                                    </li>
                                </ul>
                            </div>
                        </div>
                        <div class=""single-right simpleCart_shelfItem"">
                            <h4>Sed do eiusmod tempor</h4>
                            <div class=""block"">
                                <div class=""starbox small ghosting""> </div>
                            </div>
                            <p class=""price item_price"">$ 14.00</p>
                            <div class=""description"">
                                <p><span>Quick Overview : </span> In cursus faucibus tortor eu vestibulum. Ut eget turpis ac justo porta varius. Donec vel felis ante, ac vehicula ipsum. Quisque sed diam metus. Quisque eget leo sit amet erat varius rutrum vitae dapibus lectus. Vivamus et sapien ante. Suspendisse potenti. Fusce i");
            WriteLiteral(@"n tellus est, ac consequat.</p>
                            </div>
                            <div class=""color-quality"">
                                <h6>Quality :</h6>
                                <div class=""quantity"">
                                    <div class=""quantity-select"">
                                        <div class=""entry value-minus1"">&nbsp;</div>
                                        <div class=""entry value1""><span>1</span></div>
                                        <div class=""entry value-plus1 active"">&nbsp;</div>
                                    </div>
                                </div>
                                <!--quantity-->
                                <script>
													$('.value-plus1').on('click', function(){
														var divUpd = $(this).parent().find('.value1'), newVal = parseInt(divUpd.text(), 10)+1;
														divUpd.text(newVal);
													});

													$('.value-minus1').on('click', function(){
											");
            WriteLiteral(@"			var divUpd = $(this).parent().find('.value1'), newVal = parseInt(divUpd.text(), 10)-1;
														if(newVal>=1) divUpd.text(newVal);
													});
                                </script>
                                <!--quantity-->
                            </div>
                            <div class=""women"">
                                <span class=""size"">XL / XXL / S </span>
                                <a href=""#"" data-text=""Add To Cart"" class=""my-cart-b item_add"">Add To Cart</a>
                            </div>
                            <div class=""social-icon"">
                                <a href=""#""><i class=""icon""></i></a>
                                <a href=""#""><i class=""icon1""></i></a>
                                <a href=""#""><i class=""icon2""></i></a>
                                <a href=""#""><i class=""icon3""></i></a>
                            </div>
                        </div>
                        <div class=""clearfix""> </div>
      ");
            WriteLiteral(@"              </div>
                </div>
                <div class=""col-md-3 single-grid1"">
                    <h3>Recent Products</h3>
                    <div class=""recent-grids"">
                        <div class=""recent-left"">
                            <a href=""single.html""><img class=""img-responsive "" src=""images/r.jpg"" alt=""""></a>
                        </div>
                        <div class=""recent-right"">
                            <h6 class=""best2""><a href=""single.html"">Lorem ipsum dolor </a></h6>
                            <div class=""block"">
                                <div class=""starbox small ghosting""> </div>
                            </div>
                            <span class="" price-in1""> $ 29.00</span>
                        </div>
                        <div class=""clearfix""> </div>
                    </div>
                    <div class=""recent-grids"">
                        <div class=""recent-left"">
                            <a href=""singl");
            WriteLiteral(@"e.html""><img class=""img-responsive "" src=""images/r1.jpg"" alt=""""></a>
                        </div>
                        <div class=""recent-right"">
                            <h6 class=""best2""><a href=""single.html"">Duis aute irure </a></h6>
                            <div class=""block"">
                                <div class=""starbox small ghosting""> </div>
                            </div>
                            <span class="" price-in1""> $ 19.00</span>
                        </div>
                        <div class=""clearfix""> </div>
                    </div>
                    <div class=""recent-grids"">
                        <div class=""recent-left"">
                            <a href=""single.html""><img class=""img-responsive "" src=""images/r2.jpg"" alt=""""></a>
                        </div>
                        <div class=""recent-right"">
                            <h6 class=""best2""><a href=""single.html"">Lorem ipsum dolor </a></h6>
                            <div cla");
            WriteLiteral(@"ss=""block"">
                                <div class=""starbox small ghosting""> </div>
                            </div>
                            <span class="" price-in1""> $ 19.00</span>
                        </div>
                        <div class=""clearfix""> </div>
                    </div>
                    <div class=""recent-grids"">
                        <div class=""recent-left"">
                            <a href=""single.html""><img class=""img-responsive "" src=""images/r3.jpg"" alt=""""></a>
                        </div>
                        <div class=""recent-right"">
                            <h6 class=""best2""><a href=""single.html"">Ut enim ad minim </a></h6>
                            <div class=""block"">
                                <div class=""starbox small ghosting""> </div>
                            </div>
                            <span class="" price-in1"">$ 45.00</span>
                        </div>
                        <div class=""clearfix""> </div>
    ");
            WriteLiteral(@"                </div>
                </div>
                <div class=""clearfix""> </div>
            </div>
            <!--Product Description-->
            <div class=""product-w3agile"">
                <h3 class=""tittle1"">Product Description</h3>
                <div class=""product-grids"">
                    <div class=""col-md-4 product-grid"">
                        <div id=""owl-demo"" class=""owl-carousel"">
                            <div class=""item"">
                                <div class=""recent-grids"">
                                    <div class=""recent-left"">
                                        <a href=""single.html""><img class=""img-responsive "" src=""images/r.jpg"" alt=""""></a>
                                    </div>
                                    <div class=""recent-right"">
                                        <h6 class=""best2""><a href=""single.html"">Lorem ipsum dolor </a></h6>
                                        <div class=""block"">
                        ");
            WriteLiteral(@"                    <div class=""starbox small ghosting""> </div>
                                        </div>
                                        <span class="" price-in1""> $ 29.00</span>
                                    </div>
                                    <div class=""clearfix""> </div>
                                </div>
                                <div class=""recent-grids"">
                                    <div class=""recent-left"">
                                        <a href=""single.html""><img class=""img-responsive "" src=""images/r1.jpg"" alt=""""></a>
                                    </div>
                                    <div class=""recent-right"">
                                        <h6 class=""best2""><a href=""single.html"">Duis aute irure </a></h6>
                                        <div class=""block"">
                                            <div class=""starbox small ghosting""> </div>
                                        </div>
                  ");
            WriteLiteral(@"                      <span class="" price-in1""> $ 19.00</span>
                                    </div>
                                    <div class=""clearfix""> </div>
                                </div>
                                <div class=""recent-grids"">
                                    <div class=""recent-left"">
                                        <a href=""single.html""><img class=""img-responsive "" src=""images/r2.jpg"" alt=""""></a>
                                    </div>
                                    <div class=""recent-right"">
                                        <h6 class=""best2""><a href=""single.html"">Lorem ipsum dolor </a></h6>
                                        <div class=""block"">
                                            <div class=""starbox small ghosting""> </div>
                                        </div>
                                        <span class="" price-in1""> $ 19.00</span>
                                    </div>
                     ");
            WriteLiteral(@"               <div class=""clearfix""> </div>
                                </div>
                                <div class=""recent-grids"">
                                    <div class=""recent-left"">
                                        <a href=""single.html""><img class=""img-responsive "" src=""images/r3.jpg"" alt=""""></a>
                                    </div>
                                    <div class=""recent-right"">
                                        <h6 class=""best2""><a href=""single.html"">Ut enim ad minim </a></h6>
                                        <div class=""block"">
                                            <div class=""starbox small ghosting""> </div>
                                        </div>
                                        <span class="" price-in1"">$ 45.00</span>
                                    </div>
                                    <div class=""clearfix""> </div>
                                </div>
                            </div>
         ");
            WriteLiteral(@"                   <div class=""item"">
                                <div class=""recent-grids"">
                                    <div class=""recent-left"">
                                        <a href=""single.html""><img class=""img-responsive "" src=""images/r4.jpg"" alt=""""></a>
                                    </div>
                                    <div class=""recent-right"">
                                        <h6 class=""best2""><a href=""single.html"">Lorem ipsum dolor </a></h6>
                                        <div class=""block"">
                                            <div class=""starbox small ghosting""> </div>
                                        </div>
                                        <span class="" price-in1""> $ 29.00</span>
                                    </div>
                                    <div class=""clearfix""> </div>
                                </div>
                                <div class=""recent-grids"">
                              ");
            WriteLiteral(@"      <div class=""recent-left"">
                                        <a href=""single.html""><img class=""img-responsive "" src=""images/r5.jpg"" alt=""""></a>
                                    </div>
                                    <div class=""recent-right"">
                                        <h6 class=""best2""><a href=""single.html"">Duis aute irure </a></h6>
                                        <div class=""block"">
                                            <div class=""starbox small ghosting""> </div>
                                        </div>
                                        <span class="" price-in1""> $ 19.00</span>
                                    </div>
                                    <div class=""clearfix""> </div>
                                </div>
                                <div class=""recent-grids"">
                                    <div class=""recent-left"">
                                        <a href=""single.html""><img class=""img-responsive "" src=""im");
            WriteLiteral(@"ages/r2.jpg"" alt=""""></a>
                                    </div>
                                    <div class=""recent-right"">
                                        <h6 class=""best2""><a href=""single.html"">Lorem ipsum dolor </a></h6>
                                        <div class=""block"">
                                            <div class=""starbox small ghosting""> </div>
                                        </div>
                                        <span class="" price-in1""> $ 19.00</span>
                                    </div>
                                    <div class=""clearfix""> </div>
                                </div>
                                <div class=""recent-grids"">
                                    <div class=""recent-left"">
                                        <a href=""single.html""><img class=""img-responsive "" src=""images/r3.jpg"" alt=""""></a>
                                    </div>
                                    <div class=""recent-righ");
            WriteLiteral(@"t"">
                                        <h6 class=""best2""><a href=""single.html"">Ut enim ad minim </a></h6>
                                        <div class=""block"">
                                            <div class=""starbox small ghosting""> </div>
                                        </div>
                                        <span class="" price-in1"">$ 45.00</span>
                                    </div>
                                    <div class=""clearfix""> </div>
                                </div>
                            </div>
                        </div>
                        <img class=""img-responsive "" src=""images/woo2.jpg"" alt="""">
                    </div>
                    <div class=""col-md-8 product-grid1"">
                        <div class=""tab-wl3"">
                            <div class=""bs-example bs-example-tabs"" role=""tabpanel"" data-example-id=""togglable-tabs"">
                                <ul id=""myTab"" class=""nav nav-tabs left-tab"" ");
            WriteLiteral(@"role=""tablist"">
                                    <li role=""presentation"" class=""active""><a href=""#home"" id=""home-tab"" role=""tab"" data-toggle=""tab"" aria-controls=""home"" aria-expanded=""true"">Description</a></li>
                                    <li role=""presentation""><a href=""#reviews"" role=""tab"" id=""reviews-tab"" data-toggle=""tab"" aria-controls=""reviews"">Reviews (1)</a></li>

                                </ul>
                                <div id=""myTabContent"" class=""tab-content"">
                                    <div role=""tabpanel"" class=""tab-pane fade in active"" id=""home"" aria-labelledby=""home-tab"">
                                        <div class=""descr"">
                                            <h4>Suspendisse laoreet, augue vel mattis </h4>
                                            <p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exe");
            WriteLiteral(@"rci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore te feugait nulla facilisi.</p>
                                            <p class=""quote"">Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore te feugait nulla facilisi.</p>
                                            <div class=""video"">
                                                <iframe src=""https://player.vimeo.com/video/22158502"" frameborder=""0"" webkitallowfullscr");
            WriteLiteral(@"een mozallowfullscreen allowfullscreen></iframe>
                                            </div>
                                            <ul>
                                                <li> Twin button front fastening</li>
                                                <li> Length:65cm</li>
                                                <li> Regular fit</li>
                                                <li> Notched lapels</li>
                                                <li> Internal pockets</li>
                                                <li> Centre-back vent </li>
                                                <li> Material : Outer: 40% Linen &amp; 40% Polyamide; Body Lining: 100% Cotton; Lining: 100% Acetate</li>
                                            </ul>
                                            <p class=""quote"">Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum ir");
            WriteLiteral(@"iure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore te feugait nulla facilisi.</p>

                                        </div>
                                    </div>
                                    <div role=""tabpanel"" class=""tab-pane fade"" id=""reviews"" aria-labelledby=""reviews-tab"">
                                        <div class=""descr"">
                                            <div class=""reviews-top"">
                                                <div class=""reviews-left"">
                                                    <img src=""images/men3.jpg"" alt="" "" class=""img-responsive"">
                                                </div>
                                                <div class=""reviews-right"">
                                                    <ul>
                                        ");
            WriteLiteral(@"                <li><a href=""#"">Admin</a></li>
                                                        <li><a href=""#""><i class=""glyphicon glyphicon-share"" aria-hidden=""true""></i>Reply</a></li>
                                                    </ul>
                                                    <p>Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit.</p>
                                                </div>
                                                <div class=""clearfix""></div>
                                            </div>
                                            <div class=""reviews-bottom"">
                                                <h4>Add Reviews</h4>
                                                <p>Your email address will not be published. Required fields are marked *</p>
                                                <p>Your Rating</p>
            ");
            WriteLiteral(@"                                    <div class=""block"">
                                                    <div class=""starbox small ghosting""><div class=""positioner""><div class=""stars""><div class=""ghost"" style=""width: 42.5px; display: none;""></div><div class=""colorbar"" style=""width: 42.5px;""></div><div class=""star_holder""><div class=""star star-0""></div><div class=""star star-1""></div><div class=""star star-2""></div><div class=""star star-3""></div><div class=""star star-4""></div></div></div></div></div>
                                                </div>
                                                ");
            EndContext();
            BeginContext(21130, 1556, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36cf603d899c473a90883146bed890ac", async() => {
                BeginContext(21161, 1518, true);
                WriteLiteral(@"
                                                    <label>Your Review </label>
                                                    <textarea type=""text"" Name=""Message"" onfocus=""this.value = '';"" onblur=""if (this.value == '') {this.value = 'Message...';}"" required="""">Message...</textarea>
                                                    <div class=""row"">
                                                        <div class=""col-md-6 row-grid"">
                                                            <label>Name</label>
                                                            <input type=""text"" value=""Name"" Name=""Name"" onfocus=""this.value = '';"" onblur=""if (this.value == '') {this.value = 'Name';}"" required="""">
                                                        </div>
                                                        <div class=""col-md-6 row-grid"">
                                                            <label>Email</label>
                                                       ");
                WriteLiteral(@"     <input type=""email"" value=""Email"" Name=""Email"" onfocus=""this.value = '';"" onblur=""if (this.value == '') {this.value = 'Email';}"" required="""">
                                                        </div>
                                                        <div class=""clearfix""></div>
                                                    </div>
                                                    <input type=""submit"" value=""SEND"">
                                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(22686, 7185, true);
            WriteLiteral(@"
                                            </div>
                                        </div>
                                    </div>
                                    <div role=""tabpanel"" class=""tab-pane fade"" id=""custom"" aria-labelledby=""custom-tab"">

                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""clearfix""> </div>
                </div>
            </div>
            <!--Product Description-->
        </div>
    </div>
    <!--single-->
    <div class=""new-arrivals-w3agile"">
        <div class=""container"">
            <h3 class=""tittle1"">Best Sellers</h3>
            <div class=""arrivals-grids"">
                <div class=""col-md-3 arrival-grid simpleCart_shelfItem"">
                    <div class=""grid-arr"">
                        <div class=""grid-arrival"">
                            <figure>
                  ");
            WriteLiteral(@"              <a href=""single.html"">
                                    <div class=""grid-img"">
                                        <img src=""images/p28.jpg"" class=""img-responsive"" alt="""">
                                    </div>
                                    <div class=""grid-img"">
                                        <img src=""images/p27.jpg"" class=""img-responsive"" alt="""">
                                    </div>
                                </a>
                            </figure>
                        </div>
                        <div class=""ribben"">
                            <p>NEW</p>
                        </div>
                        <div class=""ribben1"">
                            <p>SALE</p>
                        </div>
                        <div class=""block"">
                            <div class=""starbox small ghosting""> </div>
                        </div>
                        <div class=""women"">
                            <h6><a href=");
            WriteLiteral(@"""single.html"">Sed ut perspiciatis unde</a></h6>
                            <span class=""size"">XL / XXL / S </span>
                            <p><del>$100.00</del><em class=""item_price"">$70.00</em></p>
                            <a href=""#"" data-text=""Add To Cart"" class=""my-cart-b item_add"">Add To Cart</a>
                        </div>
                    </div>
                </div>
                <div class=""col-md-3 arrival-grid simpleCart_shelfItem"">
                    <div class=""grid-arr"">
                        <div class=""grid-arrival"">
                            <figure>
                                <a href=""single.html"">
                                    <div class=""grid-img"">
                                        <img src=""images/p30.jpg"" class=""img-responsive"" alt="""">
                                    </div>
                                    <div class=""grid-img"">
                                        <img src=""images/p29.jpg"" class=""img-responsive"" alt="""">
 ");
            WriteLiteral(@"                                   </div>
                                </a>
                            </figure>
                        </div>
                        <div class=""ribben2"">
                            <p>OUT OF STOCK</p>
                        </div>
                        <div class=""block"">
                            <div class=""starbox small ghosting""> </div>
                        </div>
                        <div class=""women"">
                            <h6><a href=""single.html"">Sed ut perspiciatis unde</a></h6>
                            <span class=""size"">XL / XXL / S </span>
                            <p><del>$100.00</del><em class=""item_price"">$70.00</em></p>
                            <a href=""#"" data-text=""Add To Cart"" class=""my-cart-b item_add"">Add To Cart</a>
                        </div>
                    </div>
                </div>
                <div class=""col-md-3 arrival-grid simpleCart_shelfItem"">
                    <div class=""grid");
            WriteLiteral(@"-arr"">
                        <div class=""grid-arrival"">
                            <figure>
                                <a href=""single.html"">
                                    <div class=""grid-img"">
                                        <img src=""images/s2.jpg"" class=""img-responsive"" alt="""">
                                    </div>
                                    <div class=""grid-img"">
                                        <img src=""images/s1.jpg"" class=""img-responsive"" alt="""">
                                    </div>
                                </a>
                            </figure>
                        </div>
                        <div class=""ribben1"">
                            <p>SALE</p>
                        </div>
                        <div class=""block"">
                            <div class=""starbox small ghosting""> </div>
                        </div>
                        <div class=""women"">
                            <h6><a href=""sin");
            WriteLiteral(@"gle.html"">Sed ut perspiciatis unde</a></h6>
                            <span class=""size"">XL / XXL / S </span>
                            <p><del>$100.00</del><em class=""item_price"">$70.00</em></p>
                            <a href=""#"" data-text=""Add To Cart"" class=""my-cart-b item_add"">Add To Cart</a>
                        </div>
                    </div>
                </div>
                <div class=""col-md-3 arrival-grid simpleCart_shelfItem"">
                    <div class=""grid-arr"">
                        <div class=""grid-arrival"">
                            <figure>
                                <a href=""single.html"">
                                    <div class=""grid-img"">
                                        <img src=""images/s4.jpg"" class=""img-responsive"" alt="""">
                                    </div>
                                    <div class=""grid-img"">
                                        <img src=""images/s3.jpg"" class=""img-responsive"" alt="""">
       ");
            WriteLiteral(@"                             </div>
                                </a>
                            </figure>
                        </div>
                        <div class=""ribben"">
                            <p>NEW</p>
                        </div>
                        <div class=""block"">
                            <div class=""starbox small ghosting""> </div>
                        </div>
                        <div class=""women"">
                            <h6><a href=""single.html"">Sed ut perspiciatis unde</a></h6>
                            <span class=""size"">XL / XXL / S </span>
                            <p><del>$100.00</del><em class=""item_price"">$70.00</em></p>
                            <a href=""#"" data-text=""Add To Cart"" class=""my-cart-b item_add"">Add To Cart</a>
                        </div>
                    </div>
                </div>
                <div class=""clearfix""></div>
            </div>
        </div>
    </div>
    <!--new-arrivals-->
</div>
            WriteLiteral("\n<!--content-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591