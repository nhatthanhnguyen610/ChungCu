#pragma checksum "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\Flight\_Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "972fc7c98f6e8b20cc36ef3271d607ed548ee9d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flight__Create), @"mvc.1.0.view", @"/Views/Flight/_Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"972fc7c98f6e8b20cc36ef3271d607ed548ee9d2", @"/Views/Flight/_Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3da9fae43ccf361385e7b7b609456b65034ebb9", @"/Views/_ViewImports.cshtml")]
    public class Views_Flight__Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tour.Admin.Models.FlightViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\Flight\_Create.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    .error-valid {\r\n        color: red;\r\n    }\r\n</style>\r\n<div id=\"MenuModal\" class=\"modal fade\">\r\n    <div class=\"modal-dialog\">\r\n        <div class=\"modal-content\">\r\n");
#nullable restore
#line 13 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\Flight\_Create.cshtml"
             using (Html.BeginForm("_Create", "Flight", FormMethod.Post, new { id = "frmCreate" }))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\Flight\_Create.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\Flight\_Create.cshtml"
           Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\Flight\_Create.cshtml"
           Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col"">
                            <div class=""form-group"">
                                <label>Name<span style=""color:red"">*</span></label>
                                ");
#nullable restore
#line 23 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\Flight\_Create.cshtml"
                           Write(Html.TextBoxFor(m => m.name, new { @class = "form-control", @placeholder = "Name" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 24 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\Flight\_Create.cshtml"
                           Write(Html.ValidationMessageFor(m => m.name));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col"">
                            <div class=""form-group"">
                                <label>Description</label>
                                ");
#nullable restore
#line 32 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\Flight\_Create.cshtml"
                           Write(Html.TextAreaFor(m => m.description, new { @class = "form-control", @placeholder = "Description" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-sm-6"">
                            <div class=""form-group"">
                                <label>Ngày đi</label>
                                <div class=""input-group"">
                                    ");
#nullable restore
#line 41 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\Flight\_Create.cshtml"
                               Write(Html.TextBoxFor(m => m.date, "{0:dd/MM/yyyy}", new { @class = "form-control show-datepicker", @placeholder = "Ngày đi" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    <div class=""input-group-append"">
                                        <span class=""input-group-text"" style=""background-color: #fff;border-radius: 0 .25rem .25rem 0;""><i class=""fa fa-calendar""></i></span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-6"">
                            <div class=""form-group"">
                                <label>Duaration</label>
                                ");
#nullable restore
#line 51 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\Flight\_Create.cshtml"
                           Write(Html.TextBoxFor(m => m.duaration, new { @class = "form-control", @placeholder = "Duaration" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-sm-6"">
                            <div class=""form-group"">
                                <label>Tỉ giá</label>
                                <div class=""input-group"">
                                    ");
#nullable restore
#line 60 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\Flight\_Create.cshtml"
                               Write(Html.TextBoxFor(m => m.tigia, new { @class = "form-control", @placeholder = "Tỉ giá" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" id=""btnSubmit"" class=""btn btn-success btn-sm float-sm-right disableBtnSave""><span class=""fa fa-save""></span>Lưu</button>
                        <button type=""button"" class=""btn btn-danger btn btn-sm float-sm-right btn-popup-cancel"" id=""btnClose"" style=""margin-right:5px"" data-dismiss=""modal""><span class=""fa fa-times""></span>Thoát</button>
                    </div>
                </div>
");
#nullable restore
#line 70 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\Flight\_Create.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</div>
<script language=""javascript"">
    $('#frmCreate').validate({
        rules: {
            ""name"": {
                required: true
            },
        },
        messages: {
            ""name"": ""Vui lòng không để trống"",
        },
        errorPlacement: function (error, element) {
            error.addClass('error-valid');
            error.insertAfter(element);
            if (element.attr(""name"") == """") {
                error.insertAfter(""#"");
            }
        }
    })
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tour.Admin.Models.FlightViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591