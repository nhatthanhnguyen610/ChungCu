#pragma checksum "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\TypeTicket\_Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bc85615de36acf566db18c52ca8f47fa8b4054b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TypeTicket__Index), @"mvc.1.0.view", @"/Views/TypeTicket/_Index.cshtml")]
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
#line 1 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\_ViewImports.cshtml"
using DemoApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\_ViewImports.cshtml"
using DemoApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\TypeTicket\_Index.cshtml"
using Microsoft.AspNetCore.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\TypeTicket\_Index.cshtml"
using Tour.Admin;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bc85615de36acf566db18c52ca8f47fa8b4054b", @"/Views/TypeTicket/_Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3da9fae43ccf361385e7b7b609456b65034ebb9", @"/Views/_ViewImports.cshtml")]
    public class Views_TypeTicket__Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tour.Admin.Models.TypeTicketVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- /.card-header -->
<div class=""card-body"">
    <div class=""table-responsive"" style=""grid-auto-columns:auto"">
        <table class=""table table-bordered table-striped table-hover"">
            <thead class=""thead-light"">
                <tr>
                    <th>TT</th>
                    <th>Type</th>
                    <th>Price</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 17 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\TypeTicket\_Index.cshtml"
                 if (Model.ListTTicket != null && Model.ListTTicket.Count > 0)
                {
                    var stt = 0;
                    foreach (var item in Model.ListTTicket)
                    {
                        stt += 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 24 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\TypeTicket\_Index.cshtml"
                           Write(stt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <!--Col 1-->\r\n                            <td>\r\n                                ");
#nullable restore
#line 27 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\TypeTicket\_Index.cshtml"
                           Write(item.type);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <!-- col 2-->\r\n                            <td>\r\n                                ");
#nullable restore
#line 31 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\TypeTicket\_Index.cshtml"
                           Write(item.price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </td>
                            <!-- col 5-->
                            <td class=""text-center"" style=""18%"">
                                <button type=""button""
                                        class=""btn btn-radius-left btn-info br2 btn-xs fs12 m1 btn-popup-size""
                                        data-toggle=""modalMenu""
                                        data-target=""#RoleModalAction""
                                        data-width=""1000""
                                        data-height=""600""
                                        data-url=""");
#nullable restore
#line 41 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\TypeTicket\_Index.cshtml"
                                             Write(Url.Action("_Update", "TypeTicket",new {  TTicketID = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                                    <span class='fa fa-edit'></span>Cập nhật
                                </button>

                                <a href=""javascript:void(0);""
                                   data-message-confirm=""Bạn có chắc muốn xóa""");
            BeginWriteAttribute("action", "\r\n                                   action=\"", 2098, "\"", 2207, 1);
#nullable restore
#line 47 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\TypeTicket\_Index.cshtml"
WriteAttributeValue("", 2143, Url.Action("_Delete", "TypeTicket",new { TTicketID = item.Id }), 2143, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                   data-id=\"");
#nullable restore
#line 48 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\TypeTicket\_Index.cshtml"
                                       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""
                                   class=""btn btn-sm btn-danger btn-radius-right btn-delete btnDelete"">
                                    <span class=""fa fa-trash""></span>Xóa
                                </a><br />
                            </td>
                        </tr>
");
#nullable restore
#line 54 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\TypeTicket\_Index.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n<!-- /.card-body -->\r\n<div class=\"card-footer clearfix\">\r\n");
#nullable restore
#line 63 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\TypeTicket\_Index.cshtml"
     if (Model.ListTTicket != null && Model.ListTTicket.Count > 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\TypeTicket\_Index.cshtml"
   Write(HtmlPageHelper.Paging(this.Url, @Model.ListTTicket[0].totalRows, "_Index", "TypeTicket", "divListDetail",
        new RouteValueDictionary() {
            { "p", Model.p },
            { "keyWord",Model.keyWord}
         }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\TypeTicket\_Index.cshtml"
           
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tour.Admin.Models.TypeTicketVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
