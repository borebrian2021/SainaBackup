#pragma checksum "D:\From Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Expiries.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "885738cc77f3872dda5f26c398a6091d4f18ca14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Expiries), @"mvc.1.0.view", @"/Views/Home/Expiries.cshtml")]
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
#line 1 "D:\From Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\_ViewImports.cshtml"
using SHOP_DECOMPILED;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\From Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\_ViewImports.cshtml"
using SHOP_DECOMPILED.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"885738cc77f3872dda5f26c398a6091d4f18ca14", @"/Views/Home/Expiries.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff92a7f7e8cb6131c6c835eb6e87017751546d98", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Expiries : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "dispose_single_stock", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/icons/users.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("sell"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add_expiry_details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/sell.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">
    <div class=""col-lg-6"">


        <div class=""image-flip"">
            <div class=""mainflip flip-0"">
                <div class=""frontside"">
                    <div class=""card w3-card side_custome"">
                        <div class=""card-body text-left"">
                            <div class=""row"">


                                <div class=""col-lg-12 col-12"">
                                    <h1 class=""card-title"">");
#nullable restore
#line 14 "D:\From Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Expiries.cshtml"
                                                      Write(ViewBag.count_all);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n");
            WriteLiteral(@"
                                </div>
                            </div>
                            <p class=""card-text"">Registered items </p>
                            <a class=""btn btn-white w3-card"">View details</a>

                        </div>
");
            WriteLiteral(@"
                    </div>
                </div>
            </div>

        </div>
    </div>  <div class=""col-lg-6"">


        <div class=""image-flip"">
            <div class=""mainflip flip-0"">
                <div class=""frontside"">
                    <div class=""card w3-card side_custome"">
                        <div class=""card-body text-left"">
                            <div class=""row"">

                                <div class=""col-lg-12 col-12"">
                                    <h1 class=""card-title"">");
#nullable restore
#line 44 "D:\From Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Expiries.cshtml"
                                                      Write(ViewBag.count_expired);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  </h1>
                                   

                                </div>
                            </div>




                            <p class=""card-text"">Expired items</p>
                            <a class=""btn btn-white w3-card"" data-toggle=""modal"" data-target=""#Expired_list"">View details</a>
                        </div>
                     

                    </div>
                </div>
            </div>

        </div>

    </div>
</div>
<br />
<div class=""card w3-card"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""row"">
                <div class=""col-lg-12"">


                    <div class=""form-inline d-flex justify-content-center md-form form-sm active-pink active-pink-2 mt-2 ml-3 w-100"">
                        <i class=""fa fa-search "" aria-hidden=""true"" style=""color:#68213A ""></i>
                        <input id=""exp_search"" class=""form-control form-control-sm ml-3 search_input mb-2"" type=""text"" placeholder=""Search""
                    ");
            WriteLiteral("           aria-label=\"Search\">\n                        &nbsp;\n");
            WriteLiteral(@"                        <button class=""btn btn-white btn-sm m-1  w3-card"" id=""expired_items""><i class=""fa fa-file-pdf-o"" aria-hidden=""true""></i>&nbsp;Download PDF</button><br />
                        <button class=""btn btn-white btn-sm m-1 w3-card""  data-dismiss=""modal"" data-toggle=""modal"" data-target=""#add_client""><i class=""fa fa-plus"" aria-hidden=""true""></i>&nbsp;Register item</button>

                    </div>
                </div>
               
                </div>
            </div>
    </div>
 <br />
 <br />

 <div class=""row"">
     <div class=""col-lg-12"">
         <table class=""table font_flex"" >
             <tr class=""bg-dark text-white"">
                 <th colspan=""4"">
                     Current  Date:<b>");
#nullable restore
#line 97 "D:\From Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Expiries.cshtml"
                                 Write(DateTime.Now.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b>



                 </th>
             </tr>
             </table>
             <table class=""table font_flex"" id=""expiries"">

                 <tr>
                     <th style=""border:none"">Item</th>

                     <th style=""border:none"">Expiry date</th>


                     <th style=""border:none"">Action</th>
                 </tr>


");
#nullable restore
#line 116 "D:\From Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Expiries.cshtml"
                  if (@ViewBag.expiry_details != null)
                 {
                     

#line default
#line hidden
#nullable disable
#nullable restore
#line 118 "D:\From Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Expiries.cshtml"
                      foreach (var item in @ViewBag.expiry_details)
                     {

                         int day;
                         int month;
                         int year;
                         int current_day;
                         int current_month;
                         int current_year;

                         current_day = int.Parse(DateTime.Now.ToString("dd"));
                         current_month = int.Parse(DateTime.Now.ToString("MM"));
                         current_year = int.Parse(DateTime.Now.ToString("yyyy"));

                         DateTime _date;
                         _date = DateTime.Parse(@item.Expiry_date);
                         day = int.Parse(_date.ToString("dd"));
                         month = int.Parse(_date.ToString("MM"));
                         year = int.Parse(_date.ToString("yyyy"));
                         DateTime start = new DateTime(current_year, current_month, current_day);
                         DateTime end = new DateTime(year, month, day);
                         int difference = (start - end).Days;



                         if (difference > 0)
                         {

#line default
#line hidden
#nullable disable
            WriteLiteral("                             <tr class=\"bg-danger text-white\">\n\n                                 <td class=\"border_none\" style=\"border-top: none\">");
#nullable restore
#line 147 "D:\From Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Expiries.cshtml"
                                                                             Write(item.Item_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n                                 <td class=\"border_none\" style=\"border-top:none\">");
#nullable restore
#line 149 "D:\From Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Expiries.cshtml"
                                                                            Write(item.Expiry_date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n\n\n                                 <td class=\"border_none\" style=\"border:none\">\n\n                                     <p hidden>Expired</p>\n                                     <button class=\"btn bg-white w3-card btn-sm m-0\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5953, "\"", 5983, 3);
            WriteAttributeValue("", 5963, "dispose(\'", 5963, 9, true);
#nullable restore
#line 156 "D:\From Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Expiries.cshtml"
WriteAttributeValue("", 5972, item.id, 5972, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5980, "\');", 5980, 3, true);
            EndWriteAttribute();
            WriteLiteral(">Dispose</button>\n                                 </td>\n                             </tr>\n");
#nullable restore
#line 159 "D:\From Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Expiries.cshtml"
                         }
                         else
                         {

#line default
#line hidden
#nullable disable
            WriteLiteral("                             <tr class=\"bg-light text-dark\">\n\n                                 <td class=\"border_none\" style=\"border-top: none\">");
#nullable restore
#line 164 "D:\From Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Expiries.cshtml"
                                                                             Write(item.Item_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n                                 <td class=\"border_none\" style=\"border-top:none\">");
#nullable restore
#line 166 "D:\From Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Expiries.cshtml"
                                                                            Write(item.Expiry_date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n\n\n                                 <td class=\"border_none\" style=\"border:none\">\n                                     <button class=\"btn bg-white w3-card btn-sm m-0\"");
            BeginWriteAttribute("title", " title=\"", 6595, "\"", 6618, 1);
#nullable restore
#line 171 "D:\From Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Expiries.cshtml"
WriteAttributeValue("", 6603, item.Item_name, 6603, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"popover\" data-placement=\"top\" data-content=\"Date stocked:");
#nullable restore
#line 171 "D:\From Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Expiries.cshtml"
                                                                                                                                                                              Write(item.Date_created);

#line default
#line hidden
#nullable disable
            WriteLiteral("                      Overdue:");
#nullable restore
#line 171 "D:\From Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Expiries.cshtml"
                                                                                                                                                                                                                              Write(difference);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Infor</button>\n                                     <button class=\"btn btn-danger w3-card btn-sm m-0\"");
            BeginWriteAttribute("onclick", " onclick=\"", 6852, "\"", 6884, 3);
            WriteAttributeValue("", 6862, "delete_exp(\'", 6862, 12, true);
#nullable restore
#line 172 "D:\From Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Expiries.cshtml"
WriteAttributeValue("", 6874, item.id, 6874, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6882, "\')", 6882, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-trash-o\" aria-hidden=\"true\"></i></button>\n\n                                     <p hidden>Active</p>\n\n\n                                 </td>\n                             </tr>\n");
#nullable restore
#line 179 "D:\From Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Expiries.cshtml"

                         }



                     }

#line default
#line hidden
#nullable disable
#nullable restore
#line 184 "D:\From Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Expiries.cshtml"
                      
                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("             </table>\n\n\n     </div>\n </div>\n\n\n</div>\n\n");
            WriteLiteral(@"<div class=""modal fade custome_modal_radius"" id=""delete_mod"">
    <div class=""modal-dialog"">
       <div class=""modal-content border-0 bg-transparent"" >

            <!-- Modal Header -->
            <div class=""alert alert-danger  p-2 bg-danger text-white border-0"">
                    <i class=""fa fa-shopping-cart"" aria-hidden=""true""></i><br /><p id=""title""></p>  <br />

                <p id=""body"">

                </p>
               
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "885738cc77f3872dda5f26c398a6091d4f18ca1418631", async() => {
                WriteLiteral(@"
                        <table class=""table"">
                            <input name=""id"" id=""delete_id"" type=""text"" hidden />       
                            <tr>
                                <td style=""border:0""class=""text-left"">
                                    <button type=""submit"" class=""btn btn-sm bg-white w3-card "">Proceed</button>

                                </td>
                                <td style=""border:0""class=""text-right"">
                                    <a class=""btn btn-sm bg-white w3-card mr-5"" data-dismiss=""modal"">Cancel</a>

                                </td>
                            </tr>
                        </table>


                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
            </div>



         <div class=""modal fade custome_modal_radius"" id=""add_client"">
    <div class=""modal-dialog"">
        <div class=""modal-content border-0"">

            <!-- Modal Header -->
");
            WriteLiteral("\n            <!-- Modal body -->\n            <div class=\"modal-header  p-2  \" style=\"z-index:1020\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "885738cc77f3872dda5f26c398a6091d4f18ca1421214", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("&nbsp;<b>REGISTER AN ITEM</b>\n            </div>\n            <div class=\"modal-body\">\n\n              \n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "885738cc77f3872dda5f26c398a6091d4f18ca1422457", async() => {
                WriteLiteral("\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "885738cc77f3872dda5f26c398a6091d4f18ca1422742", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 252 "D:\From Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Expiries.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            <div class=""group"">
                                <input name=""item_name"" class=""custome_input"" type=""text"" required=""required"" />
                                <span class=""highlight""></span>
                                <span class=""bar""></span>
                                <label>Item name</label>
                            </div>
                            <div class=""group"">
                                <input name=""Expiry_date"" class=""custome_input""  type=""date"" required=""required"" />
                                <span class=""highlight""></span>
                                <span class=""bar""></span>
                                <label>Epiry date</label>
                            </div>
                          <div class=""form-group"">
                                <input type=""submit"" value=""Register"" class=""btn btn-primary"" />
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
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
        </div>
   
<div class=""modal fade custome_modal_radius"" id=""Expired_list"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <!-- Modal Header -->
            <div class=""modal-header  p-2  "" style=""z-index:1020"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "885738cc77f3872dda5f26c398a6091d4f18ca1426974", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"&nbsp;<b>ALL EXPIRED ITEMS</b>
            </div>
            <div class=""modal-body  p-2 w3-card"" style=""z-index:1020"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <div class=""row"">
                            <div class=""col-lg-12"">


                                <div class=""form-inline d-flex justify-content-center md-form form-sm active-pink active-pink-2 mt-2 ml-3 w-100"">
                                    <i class=""fa fa-search "" aria-hidden=""true"" style=""color:#68213A ""></i>
                                    <input id=""search_expired_table"" class=""form-control form-control-sm ml-3 search_input mb-2"" type=""text"" placeholder=""Search""
                                           aria-label=""Search"">
                                    &nbsp;
");
            WriteLiteral(@"                                    <button class=""btn btn-primary btn-sm"" id=""expired_only""><i class=""fa fa-file-pdf-o"" aria-hidden=""true""></i>&nbsp;PDF</button>

                                </div>

                            </div>

                        </div>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <div class=""row"">
                            <div class=""col-lg-12"">
                                <table class=""table font_flex"" id=""expired_itesm_list_table"">
                                    <tr>
                                        <th style=""border:none"">Item</th>

                                        <th style=""border:none"">Expiry date</th>


                                        <th style=""border:none"">Action</th>
                                    </tr>

");
#nullable restore
#line 319 "D:\From Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Expiries.cshtml"
                                     if (@ViewBag.expired_list != null)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 321 "D:\From Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Expiries.cshtml"
                                         foreach (var item in @ViewBag.expired_list)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr class=\"bg-light text-dark\">\n\n                                                <td class=\"border_none\" style=\"border-top: none\">");
#nullable restore
#line 325 "D:\From Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Expiries.cshtml"
                                                                                            Write(item.Item_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n                                                <td class=\"border_none\" style=\"border-top:none\">");
#nullable restore
#line 327 "D:\From Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Expiries.cshtml"
                                                                                           Write(item.Expiry_date);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>



                                                <td class=""border_none"" style=""border:none"">

                                                    <p hidden>Expired</p>
                                                    <button class=""btn bg-white w3-card btn-sm m-0""");
            BeginWriteAttribute("onclick", " onclick=\"", 13430, "\"", 13460, 3);
            WriteAttributeValue("", 13440, "dispose(\'", 13440, 9, true);
#nullable restore
#line 334 "D:\From Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Expiries.cshtml"
WriteAttributeValue("", 13449, item.id, 13449, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 13457, "\');", 13457, 3, true);
            EndWriteAttribute();
            WriteLiteral(">Dispose</button>\n                                                </td>\n                                            </tr>\n");
#nullable restore
#line 337 "D:\From Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Expiries.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 337 "D:\From Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Expiries.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </table>\n\n\n                            </div>\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n");
            DefineSection("exp", async() => {
                WriteLiteral(@"

    <script type=""text/javascript"">
        $(""#expired_items"").click(function () {
            //$(""#to_pf_table"").tableHTMLExport({
            //    type: 'pdf',
            //    orientation: 'p'
            //});
            var date = $(""#search_restock"").val();
            $(""#sales_made_on"").text(date);
            //var img = new Image()
            var doc = new jsPDF();
            //img.src = 'wwwroot/images/logo2.png'
            //doc.addImage(img, 'png', 10, 78, 12, 15)
            var htmlstring = '';
            var tempVarToCheckPageHeight = 0;
            var pageHeight = 0;
            //pageHeight = doc.internal.pageSize.height;
            //specialElementHandlers = {
            //        // element with id of ""bypass"" - jQuery style selector
            //        '#bypassme': function(element, renderer) {
            //        // true = ""handled elsewhere, bypass text extraction""
            //        return true
            //    }
            //};
            //margins = {
        ");
                WriteLiteral(@"    //        top: 10,
            //    bottom: 10,
            //    left: 10,
            //    right: 10,
            //    width: 100
            //};
            var y = 20;
            doc.setLineWidth(2);
            //doc.text(200, y = y + 30, ""TOTAL MARKS OF STUDENTS"");
            doc.autoTable({
                html: '#expiries',
            });
            doc.save('ITEMS_EXPIRIES_DETAILS');






        });
      
     
        $(document).ready(function () {
            $('[data-toggle=""popover""]').popover();  
         
            var msg = '");
#nullable restore
#line 401 "D:\From Desktop\ALL DESKTOP FOLDERS\PROJECTS\SHOP_DECOMPILED-master\SHOP_DECOMPILED-master\Views\Home\Expiries.cshtml"
                  Write(TempData["popup"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"'

            if (msg == ""1"") {
                $(""danger"").show();
                $(""success"").hide();

                $('#positive_results').modal('show');
                setTimeout(function () {
                    $('#positive_results').modal('hide');
                }, 3000);

            }
            else if (msg == ""2"") {
                $(""danger"").show();
                $(""success"").hide();
                $('#negative_results').modal('show');
                setTimeout(function () {
                    $('#negative_results').modal('hide');
                }, 3000);
            }
            else if (msg == ""5"") {

                $(""#add_new_item_to_system"").modal('show');
            }
            else if (msg == ""4"") {

                $(""#filtered_sold"").modal('show');
            }
            else {

            }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
