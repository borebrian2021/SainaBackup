#pragma checksum "C:\Users\AMBIENT\Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Filter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f99d6669a116872993dcb5b0bdb2744fc251efdc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Filter), @"mvc.1.0.view", @"/Views/Home/Filter.cshtml")]
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
#line 1 "C:\Users\AMBIENT\Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\_ViewImports.cshtml"
using SHOP_DECOMPILED;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AMBIENT\Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\_ViewImports.cshtml"
using SHOP_DECOMPILED.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f99d6669a116872993dcb5b0bdb2744fc251efdc", @"/Views/Home/Filter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff92a7f7e8cb6131c6c835eb6e87017751546d98", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Filter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Filter", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""card w3-card bg-white"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""row"">
                <div class=""col-lg-12"">


                    <div class=""form-inline d-flex justify-content-center md-form form-sm active-pink active-pink-2 mt-2 ml-3 w-100"">
                        <i class=""fa fa-search "" aria-hidden=""true"" style=""color:#68213A ""></i>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f99d6669a116872993dcb5b0bdb2744fc251efdc4437", async() => {
                WriteLiteral(@"
                            <input id=""search_sold_items12"" name=""date"" required type=""date"" class=""form-control form-control-sm ml-3 search_input mb-2"" placeholder=""Search""
                                   aria-label=""Search"">
                            &nbsp;
                            <button class=""btn bg-white w3-card  btn-sm"" type=""submit""><i class=""fa fa-search"" aria-hidden=""true""></i>&nbsp;Search</button>

                            <a class=""btn bg-white w3-card btn-sm "" id=""filtered_sold_to_pdf""><i class=""fa fa-file-pdf-o"" aria-hidden=""true""></i>&nbsp;PDF</a>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </div>\n\n                </div>\n            </div>\n\n\n\n        </div>\n\n    </div>\n    <div class=\"row mt-1 p-2\">\n        <table class=\"table font_flex\" id=\"sold_items_1233\">\n");
#nullable restore
#line 31 "C:\Users\AMBIENT\Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Filter.cshtml"
             if (@ViewBag.message != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <th colspan=\"6\" style=\"border: none\" class=\"text-center\">\n                        <div class=\"alert alert-primary w3-card\">\n                           \n                            <h6>  &nbsp;");
#nullable restore
#line 37 "C:\Users\AMBIENT\Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Filter.cshtml"
                                   Write(ViewBag.message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n                            <p></p>\n                        </div>\n                    </th>\n                </tr>\n");
#nullable restore
#line 42 "C:\Users\AMBIENT\Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Filter.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td style=\"border:none\">Date:</td>\n                <td style=\"border:none\" colspan=\"3\">");
#nullable restore
#line 45 "C:\Users\AMBIENT\Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Filter.cshtml"
                                               Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>

            </tr>
            <tr>
               
                <th class=""border_none"" style=""border:none"">Brand</th>
                <th class=""border_none"" style=""border:none"">Sold</th>
                <th class=""border_none"" style=""border:none"">Price</th>
                <th class=""border_none"" style=""border:none"">Total</th>
                <th class=""border_none"" style=""border:none"">Profit</th>

            </tr>

");
#nullable restore
#line 58 "C:\Users\AMBIENT\Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Filter.cshtml"
             if (@ViewBag.JoinList_general_third == null)
            {

                

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\AMBIENT\Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Filter.cshtml"
                 if (@ViewBag.JoinList12 != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\AMBIENT\Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Filter.cshtml"
                     foreach (var item in @ViewBag.JoinList12)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                           \n                            <td class=\"border_none\" style=\"border-top: none\">");
#nullable restore
#line 67 "C:\Users\AMBIENT\Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Filter.cshtml"
                                                                        Write(item.Item_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n                            <td class=\"brand_totals\" style=\"border-top:none\">");
#nullable restore
#line 69 "C:\Users\AMBIENT\Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Filter.cshtml"
                                                                        Write(item.quantity_sold);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td class=\"brand_totals\" style=\"border-top:none\">");
#nullable restore
#line 70 "C:\Users\AMBIENT\Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Filter.cshtml"
                                                                        Write(item.Item_price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td class=\"sub_totals_mod2\" id=\"total_per_brand_sold_0\" style=\"border:none\">");
#nullable restore
#line 71 "C:\Users\AMBIENT\Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Filter.cshtml"
                                                                                                   Write(item.Total_cash_made);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 72 "C:\Users\AMBIENT\Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Filter.cshtml"
                              
                                float profit = item.Total_cash_made - item.Total_Cost_cash;
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\"sub_totals_cost_price\" id=\"total_per_brand_sold_0_f\" style=\"border:none\"><span class=\"badge badge-success\">");
#nullable restore
#line 75 "C:\Users\AMBIENT\Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Filter.cshtml"
                                                                                                                                             Write(profit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\n\n                        </tr>\n");
#nullable restore
#line 78 "C:\Users\AMBIENT\Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Filter.cshtml"

                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "C:\Users\AMBIENT\Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Filter.cshtml"
                     

                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "C:\Users\AMBIENT\Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Filter.cshtml"
                 
            }
            else
            {

                

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\AMBIENT\Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Filter.cshtml"
                 foreach (var item in @ViewBag.JoinList_general_third)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                       \n                        <td class=\"border_none\" style=\"border-top: none\">");
#nullable restore
#line 91 "C:\Users\AMBIENT\Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Filter.cshtml"
                                                                    Write(item.Item_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td class=\"brand_totals\" style=\"border-top:none\">");
#nullable restore
#line 92 "C:\Users\AMBIENT\Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Filter.cshtml"
                                                                    Write(item.quantity_sold);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td class=\"brand_totals\" style=\"border-top:none\">");
#nullable restore
#line 93 "C:\Users\AMBIENT\Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Filter.cshtml"
                                                                    Write(item.Item_price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td class=\"sub_totals_mod2\" id=\"total_per_brand_sold_00\" style=\"border:none\">");
#nullable restore
#line 94 "C:\Users\AMBIENT\Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Filter.cshtml"
                                                                                                Write(item.Total_cash_made);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 95 "C:\Users\AMBIENT\Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Filter.cshtml"
                          
                            float profit2 = item.Total_cash_made - item.Total_Cost_cash;
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td id=\"total_per_brand_sold_0_f1\" style=\"border:none\"><span class=\"badge badge-success sub_totals_cost_price_f\">");
#nullable restore
#line 98 "C:\Users\AMBIENT\Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Filter.cshtml"
                                                                                                                                    Write(profit2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\n\n                    </tr>\n");
#nullable restore
#line 101 "C:\Users\AMBIENT\Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Filter.cshtml"

                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 102 "C:\Users\AMBIENT\Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Filter.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "C:\Users\AMBIENT\Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Filter.cshtml"
             if (@ViewBag.JoinList_general_third != null)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <tr>
                    <td class=""text-left"" colspan=""3"" style=""border:none;""><b>TOTAL CASH MADE</b></td>
                    <td style=""border:none;"" colspan=""3"" class=""border_none text-right"">Ksh.<h3><b id=""total12_""></b></h3></td>
                </tr>
                <tr>
                    <td class=""text-left"" colspan=""3"" style=""border:none;""><b>TOTAL PROFIT</b></td>

                    <td style=""border:none;"" colspan=""3"" class=""border_none text-right"">Ksh.<h3><b id=""total12_F""></b></h3></td>
                </tr>
");
#nullable restore
#line 120 "C:\Users\AMBIENT\Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Filter.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\n\n\n    </div>\n</div>\n");
            DefineSection("debt2", async() => {
                WriteLiteral(@"

    <script type=""text/javascript"">
        $(document).ready(function () {
            var sum = 0;

            $("".sub_totals_cost_price_f"").each(function () {

                sum += parseFloat($(this).text());
            });

            $('#total12_F').text(sum);


            calc_total_mod2();
            calc_total_mod3();

        });
        function calc_total_mod2() {
            var sum = 0;
            $("".sub_totals_mod2"").each(function () {
                sum += parseFloat($(this).text());
            });
            $('#total123').text(sum);


        }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591