#pragma checksum "C:\Users\User\Desktop\mvc-homework-25.10.2022\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89d008cfce80a8af28921dc8f0f389f5188eddd4"
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
#line 1 "C:\Users\User\Desktop\mvc-homework-25.10.2022\Views\_ViewImports.cshtml"
using mvc_homework_25._10._2022;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\mvc-homework-25.10.2022\Views\_ViewImports.cshtml"
using mvc_homework_25._10._2022.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89d008cfce80a8af28921dc8f0f389f5188eddd4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70eb2c09a451ee59445219aa613515a8fb0e44c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<mvc_homework_25._10._2022.Models.HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/women.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/children.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/men.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image placeholder"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\Desktop\mvc-homework-25.10.2022\Views\Home\Index.cshtml"
  
    var products = Model.products;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""site-blocks-cover"" style=""background-image: url(images/hero_1.jpg);"" data-aos=""fade"">
    <div class=""container"">
        <div class=""row align-items-start align-items-md-center justify-content-end"">
            <div class=""col-md-5 text-center text-md-left pt-5 pt-md-0"">
                <h1 class=""mb-2"">Finding Your Perfect Shoes</h1>
                <div class=""intro-text text-center text-md-left"">
                    <p class=""mb-4"">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus at iaculis quam. Integer accumsan tincidunt fringilla. </p>
                    <p>
                        <a href=""#"" class=""btn btn-sm btn-primary"">Shop Now</a>
                    </p>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""site-section site-section-sm site-blocks-1"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6 col-lg-4 d-lg-flex mb-4 mb-lg-0 pl-4"" data-aos=""fade-up"" data-aos-delay="""">");
            WriteLiteral(@"
                <div class=""icon mr-4 align-self-start"">
                    <span class=""icon-truck""></span>
                </div>
                <div class=""text"">
                    <h2 class=""text-uppercase"">Free Shipping</h2>
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus at iaculis quam. Integer accumsan tincidunt fringilla.</p>
                </div>
            </div>
            <div class=""col-md-6 col-lg-4 d-lg-flex mb-4 mb-lg-0 pl-4"" data-aos=""fade-up"" data-aos-delay=""100"">
                <div class=""icon mr-4 align-self-start"">
                    <span class=""icon-refresh2""></span>
                </div>
                <div class=""text"">
                    <h2 class=""text-uppercase"">Free Returns</h2>
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus at iaculis quam. Integer accumsan tincidunt fringilla.</p>
                </div>
            </div>
            <div class=""col-md-6 col-lg-4");
            WriteLiteral(@" d-lg-flex mb-4 mb-lg-0 pl-4"" data-aos=""fade-up"" data-aos-delay=""200"">
                <div class=""icon mr-4 align-self-start"">
                    <span class=""icon-help""></span>
                </div>
                <div class=""text"">
                    <h2 class=""text-uppercase"">Customer Support</h2>
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus at iaculis quam. Integer accumsan tincidunt fringilla.</p>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""site-section site-blocks-2"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-sm-6 col-md-6 col-lg-4 mb-4 mb-lg-0"" data-aos=""fade"" data-aos-delay="""">
                <a class=""block-2-item"" href=""#"">
                    <figure class=""image"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "89d008cfce80a8af28921dc8f0f389f5188eddd48528", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </figure>
                    <div class=""text"">
                        <span class=""text-uppercase"">Collections</span>
                        <h3>Women</h3>
                    </div>
                </a>
            </div>
            <div class=""col-sm-6 col-md-6 col-lg-4 mb-5 mb-lg-0"" data-aos=""fade"" data-aos-delay=""100"">
                <a class=""block-2-item"" href=""#"">
                    <figure class=""image"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "89d008cfce80a8af28921dc8f0f389f5188eddd410217", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </figure>
                    <div class=""text"">
                        <span class=""text-uppercase"">Collections</span>
                        <h3>Children</h3>
                    </div>
                </a>
            </div>
            <div class=""col-sm-6 col-md-6 col-lg-4 mb-5 mb-lg-0"" data-aos=""fade"" data-aos-delay=""200"">
                <a class=""block-2-item"" href=""#"">
                    <figure class=""image"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "89d008cfce80a8af28921dc8f0f389f5188eddd411910", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </figure>
                    <div class=""text"">
                        <span class=""text-uppercase"">Collections</span>
                        <h3>Men</h3>
                    </div>
                </a>
            </div>
        </div>
    </div>
</div>

<div class=""site-section block-3 site-blocks-2 bg-light"">
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-md-7 site-section-heading text-center pt-4"">
                <h2>Featured Products</h2>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""nonloop-block-3 owl-carousel"">
");
#nullable restore
#line 107 "C:\Users\User\Desktop\mvc-homework-25.10.2022\Views\Home\Index.cshtml"
                     foreach (var product in products)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"item\">\r\n                            <div class=\"block-4 text-center\">\r\n                                <figure class=\"block-4-image\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "89d008cfce80a8af28921dc8f0f389f5188eddd414312", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5143, "~/images/", 5143, 9, true);
#nullable restore
#line 112 "C:\Users\User\Desktop\mvc-homework-25.10.2022\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 5152, product.image, 5152, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </figure>\r\n                                <div class=\"block-4-text p-4\">\r\n                                    <h3><a href=\"#\">");
#nullable restore
#line 115 "C:\Users\User\Desktop\mvc-homework-25.10.2022\Views\Home\Index.cshtml"
                                               Write(product.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                                    <p class=\"mb-0\">");
#nullable restore
#line 116 "C:\Users\User\Desktop\mvc-homework-25.10.2022\Views\Home\Index.cshtml"
                                               Write(product.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p class=\"text-primary font-weight-bold\">$");
#nullable restore
#line 117 "C:\Users\User\Desktop\mvc-homework-25.10.2022\Views\Home\Index.cshtml"
                                                                         Write(product.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 121 "C:\Users\User\Desktop\mvc-homework-25.10.2022\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
</div>

<div class=""site-section block-8"">
    <div class=""container"">
        <div class=""row justify-content-center  mb-5"">
            <div class=""col-md-7 site-section-heading text-center pt-4"">
                <h2>Big Sale!</h2>
            </div>
        </div>
        <div class=""row align-items-center"">
            <div class=""col-md-12 col-lg-7 mb-5"">
                <a href=""#""><img src=""images/blog_1.jpg"" alt=""Image placeholder"" class=""img-fluid rounded""></a>
            </div>
            <div class=""col-md-12 col-lg-5 text-center pl-md-5"">
                <h2><a href=""#"">50% less in all items</a></h2>
                <p class=""post-meta mb-4"">By <a href=""#"">Carl Smith</a> <span class=""block-8-sep"">&bullet;</span> September 3, 2018</p>
                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quisquam iste dolor accusantium facere corporis ipsum animi deleniti fugiat. Ex, veniam?</p>
       ");
            WriteLiteral("         <p><a href=\"#\" class=\"btn btn-primary btn-sm\">Shop Now</a></p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<mvc_homework_25._10._2022.Models.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
