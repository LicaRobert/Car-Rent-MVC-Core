#pragma checksum "C:\Users\spr_a_000\source\repos\CarRentWebApp\CarRentWebApp\Views\Customers\CustomersByCount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0483127f048ac6c63b0d59947fdde2e534f175f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_CustomersByCount), @"mvc.1.0.view", @"/Views/Customers/CustomersByCount.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customers/CustomersByCount.cshtml", typeof(AspNetCore.Views_Customers_CustomersByCount))]
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
#line 1 "C:\Users\spr_a_000\source\repos\CarRentWebApp\CarRentWebApp\Views\_ViewImports.cshtml"
using CarRentWebApp;

#line default
#line hidden
#line 2 "C:\Users\spr_a_000\source\repos\CarRentWebApp\CarRentWebApp\Views\_ViewImports.cshtml"
using CarRentWebApp.Models;

#line default
#line hidden
#line 3 "C:\Users\spr_a_000\source\repos\CarRentWebApp\CarRentWebApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0483127f048ac6c63b0d59947fdde2e534f175f4", @"/Views/Customers/CustomersByCount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e6158bdac5cd9f5be9d4522af298cbf8c1b6a44", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers_CustomersByCount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CarRentWebApp.Models.CustomersCount>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap-theme.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(108, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(110, 516, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "122abc2d25474d79a4f8fb9133f2b92c", async() => {
                BeginContext(116, 410, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width,
        initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <link rel=""stylesheet""
          href=""https://use.fontawesome.com/releases/v5.6.3/css/all.css"" integrity=""
        sha384-UHRtZLI+pbxtHCWp1t77Bi1L4ZtiqrqD80Kn4Z8NTSRyMA2Fd33n5dQ8lWUE00s/""
          crossorigin=""anonymous"">
    ");
                EndContext();
                BeginContext(526, 91, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2acd16f2ad6c4b90967b8ca184ec5bb9", async() => {
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
                EndContext();
                BeginContext(617, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(626, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(630, 2603, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fccaf5f8570747729401e684561ecf3c", async() => {
                BeginContext(636, 1702, true);
                WriteLiteral(@"
    <nav class=""navbar navbar-inverse navbar-fixed-top"">
        <div class=""container"">

            <div class=""navbar-header"">
                <h4 class=""fas fa-car text-primary"" id=""carRentIcon""></h4><span class=""text-primary""> Car Rent </span>
                <button type=""button"" class=""navbar-toggle"" data-toggle=""collapse"" data-target="".navbar-collapse"">
                    <span class=""sr-only"">Toggle navigation</span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                </button>
            </div>
            <div class=""navbar-collapse collapse"">
                <ul class=""nav navbar-nav"">
                    <li><a href=""/Home/Index"">Home</a></li>
                    <li><a href=""/CarRents/Index"">Car Rents</a></li>
                    <li>
                        <a href=""#"" class=""btn active"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""true""><span c");
                WriteLiteral(@"lass=""nav-label"">Rent Reports</span><span class=""caret""></span></a>
                        <ul class=""dropdown-menu"">
                            <li><a href=""/CarRents/CarRentsByCount"" class=""btn"">Cars rents</a></li>
                            <li><a href=""/Customers/CustomersByCount"" class=""btn"">Costumers rents</a></li>
                        </ul>
                    <li><a href=""/Customers/Index"">Clients</a></li>
                    <li><a href=""/ListAvailableCars/Index"" class=""btn"">List of Available cars</a></li>
                    <li><a href=""/Home/About"">About</a></li>
                    <li><a href=""/MailSender/Index"" class=""btn"">Contact</a></li>
");
                EndContext();
#line 43 "C:\Users\spr_a_000\source\repos\CarRentWebApp\CarRentWebApp\Views\Customers\CustomersByCount.cshtml"
                     if (this.User.IsInRole("Administrator"))
                    {

#line default
#line hidden
                BeginContext(2424, 92, true);
                WriteLiteral("                        <li><a href=\"/Administration/ListRoles\" class=\"btn\">Roles</a></li>\r\n");
                EndContext();
#line 46 "C:\Users\spr_a_000\source\repos\CarRentWebApp\CarRentWebApp\Views\Customers\CustomersByCount.cshtml"
                    }

#line default
#line hidden
                BeginContext(2539, 81, true);
                WriteLiteral("                </ul>\r\n                <ul class=\"nav navbar-nav navbar-right\">\r\n");
                EndContext();
#line 49 "C:\Users\spr_a_000\source\repos\CarRentWebApp\CarRentWebApp\Views\Customers\CustomersByCount.cshtml"
                     if (signInManager.IsSignedIn(User))
                    {

#line default
#line hidden
                BeginContext(2701, 75, true);
                WriteLiteral("                        <li class=\"nav-item\">\r\n                            ");
                EndContext();
                BeginContext(2776, 321, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ca288cbaa104545ab2cb11c117ecab1", async() => {
                    BeginContext(2841, 157, true);
                    WriteLiteral("\r\n                                <button type=\"submit\" class=\"nav-link btn btn-link py-0\" style=\"height:10px;\">\r\n                                    Logout ");
                    EndContext();
                    BeginContext(2999, 18, false);
#line 54 "C:\Users\spr_a_000\source\repos\CarRentWebApp\CarRentWebApp\Views\Customers\CustomersByCount.cshtml"
                                      Write(User.Identity.Name);

#line default
#line hidden
                    EndContext();
                    BeginContext(3017, 73, true);
                    WriteLiteral("\r\n                                </button>\r\n                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3097, 33, true);
                WriteLiteral("\r\n                        </li>\r\n");
                EndContext();
#line 58 "C:\Users\spr_a_000\source\repos\CarRentWebApp\CarRentWebApp\Views\Customers\CustomersByCount.cshtml"
                    }

#line default
#line hidden
                BeginContext(3153, 73, true);
                WriteLiteral("                </ul>\r\n            </div>\r\n        </div>\r\n    </nav>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3233, 133, true);
            WriteLiteral("\r\n\r\n<h2>The list with costumers rents.</h2>\r\n\r\n<table class=\"table\">\r\n\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(3367, 40, false);
#line 73 "C:\Users\spr_a_000\source\repos\CarRentWebApp\CarRentWebApp\Views\Customers\CustomersByCount.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(3407, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(3463, 41, false);
#line 76 "C:\Users\spr_a_000\source\repos\CarRentWebApp\CarRentWebApp\Views\Customers\CustomersByCount.cshtml"
           Write(Html.DisplayNameFor(model => model.Total));

#line default
#line hidden
            EndContext();
            BeginContext(3504, 88, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n\r\n    <tbody>\r\n");
            EndContext();
#line 83 "C:\Users\spr_a_000\source\repos\CarRentWebApp\CarRentWebApp\Views\Customers\CustomersByCount.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(3641, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3702, 39, false);
#line 87 "C:\Users\spr_a_000\source\repos\CarRentWebApp\CarRentWebApp\Views\Customers\CustomersByCount.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(3741, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3809, 40, false);
#line 90 "C:\Users\spr_a_000\source\repos\CarRentWebApp\CarRentWebApp\Views\Customers\CustomersByCount.cshtml"
               Write(Html.DisplayFor(modelItem => item.Total));

#line default
#line hidden
            EndContext();
            BeginContext(3849, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 93 "C:\Users\spr_a_000\source\repos\CarRentWebApp\CarRentWebApp\Views\Customers\CustomersByCount.cshtml"
        }

#line default
#line hidden
            BeginContext(3904, 26, true);
            WriteLiteral("    </tbody>\r\n\r\n</table>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> signInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CarRentWebApp.Models.CustomersCount>> Html { get; private set; }
    }
}
#pragma warning restore 1591
