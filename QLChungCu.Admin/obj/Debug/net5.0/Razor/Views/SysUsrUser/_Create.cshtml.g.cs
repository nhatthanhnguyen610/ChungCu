#pragma checksum "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysUsrUser\_Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "502e216cf0c9d616f1aea1dd567ac9975c90d954"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SysUsrUser__Create), @"mvc.1.0.view", @"/Views/SysUsrUser/_Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"502e216cf0c9d616f1aea1dd567ac9975c90d954", @"/Views/SysUsrUser/_Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3da9fae43ccf361385e7b7b609456b65034ebb9", @"/Views/_ViewImports.cshtml")]
    public class Views_SysUsrUser__Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tour.Admin.Models.SysUsrUserViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysUsrUser\_Create.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    .error-valid {\r\n        color: red;\r\n    }\r\n</style>\r\n<div id=\"RoleModalAction\" class=\"modal fade\">\r\n    <div class=\"modal-dialog\">\r\n        <div class=\"modal-content\">\r\n");
#nullable restore
#line 13 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysUsrUser\_Create.cshtml"
             using (Html.BeginForm("_Create", "SysUsrUser", FormMethod.Post, new { id = "frmCreate" }))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysUsrUser\_Create.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysUsrUser\_Create.cshtml"
           Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysUsrUser\_Create.cshtml"
           Write(Html.HiddenFor(m => m.userID));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""card-body"">
                    <div class=""row section"">
                        <div class=""col-md-8"">
                            <div class=""row"">
                                <div class=""col-sm-12"">
                                    <div class=""form-group"">
                                        <label>Họ và tên<span style=""color:red"">*</span></label>
                                        ");
#nullable restore
#line 25 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysUsrUser\_Create.cshtml"
                                   Write(Html.TextBoxFor(m => m.fullName, new { @class = "form-control", @placeholder = "Họ và tên" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 26 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysUsrUser\_Create.cshtml"
                                   Write(Html.ValidationMessageFor(m => m.fullName));

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
                                        <label>Ngày sinh</label>
                                        <div class=""input-group"">
                                            ");
#nullable restore
#line 35 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysUsrUser\_Create.cshtml"
                                       Write(Html.TextBoxFor(m => m.birthdayView, "{0:dd/MM/yyyy}", new { @class = "form-control show-datepicker", @placeholder = "Ngày sinh" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            <div class=""input-group-append"">
                                                <span class=""input-group-text"" style=""background-color: #fff;border-radius: 0 .25rem .25rem 0;""><i class=""fa fa-calendar""></i></span>
                                            </div>
                                            ");
#nullable restore
#line 39 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysUsrUser\_Create.cshtml"
                                       Write(Html.ValidationMessageFor(m => m.birthdayView));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-sm-6"">
                                    <div class=""form-group"">
                                        <label>Số điện thoại<span style=""color:red"">*</span></label>
                                        ");
#nullable restore
#line 46 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysUsrUser\_Create.cshtml"
                                   Write(Html.TextBoxFor(m => m.phone, new { @class = "form-control", @placeholder = "Số điện thoại" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 47 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysUsrUser\_Create.cshtml"
                                   Write(Html.ValidationMessageFor(m => m.phone));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-sm-12"">
                                    <div class=""form-group"">
                                        <label>Email<span style=""color:red"">*</span></label>
                                        ");
#nullable restore
#line 55 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysUsrUser\_Create.cshtml"
                                   Write(Html.TextBoxFor(m => m.email, new { @id = "email", @class = "form-control", @placeholder = "Email" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 56 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysUsrUser\_Create.cshtml"
                                   Write(Html.ValidationMessageFor(m => m.email));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-4"">
                            <div class=""row section"">
                                <div class=""col-md-1""></div>
                                <div class=""col-md-10"">
                                    <div class=""fileupload fileupload-new admin-form"" data-provides=""fileupload"">
                                        <div class=""fileupload-preview thumbnail mb5"" style=""height:167px"">
                                            ");
#nullable restore
#line 67 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysUsrUser\_Create.cshtml"
                                       Write(Html.Raw("<img style=\"height: 167px; width: 100 %; display: block; \" src=\"" + @Model.avatar + "\" />"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </div>
                                        <span class=""btn bg-gradient-secondary btn-file btn-block ph5"">
                                            <span class=""fileupload-new"">Avatar</span>
                                            <span class=""fileupload-exists"">Avatar</span>
                                            <input type=""file"" name=""file"" id=""file"" accept=""image/*"">
                                        </span>
                                    </div>
                                </div>
                                ");
#nullable restore
#line 76 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysUsrUser\_Create.cshtml"
                           Write(Html.ValidationMessageFor(m => m.avatar));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                <div class=""col-md-1""></div>
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-sm-8"">
                            <div class=""form-group"">
                                <label>Mật khẩu<span style=""color:red"">*</span></label>
                                ");
#nullable restore
#line 85 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysUsrUser\_Create.cshtml"
                           Write(Html.TextBoxFor(m => m.password, new { @class = "form-control", @type = "password", @placeholder = "Mật khẩu" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 86 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysUsrUser\_Create.cshtml"
                           Write(Html.ValidationMessageFor(m => m.password));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <label></label>
                            <div class=""icheck-primary"" style=""margin-left:25px;padding-top:8px"">
                                ");
#nullable restore
#line 92 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysUsrUser\_Create.cshtml"
                           Write(Html.CheckBoxFor(m => m.isActive, new { @name = "isActive", @id = "isActive" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                <label for=""isActive"">
                                    Kích hoạt
                                </label>
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-sm-12"">
                            <div class=""form-group"">
                                <label>Địa chỉ</label>
                                ");
#nullable restore
#line 103 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysUsrUser\_Create.cshtml"
                           Write(Html.TextBoxFor(m => m.address, new { @class = "form-control", @placeholder = "Địa chỉ" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 104 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysUsrUser\_Create.cshtml"
                           Write(Html.ValidationMessageFor(m => m.address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <input type=\"hidden\" class=\"gui-input\" hidden=\"hidden\" id=\"uploader\"");
            BeginWriteAttribute("value", " value=\"", 6517, "\"", 6538, 1);
#nullable restore
#line 108 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysUsrUser\_Create.cshtml"
WriteAttributeValue("", 6525, Model.avatar, 6525, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""Please Select A File"">
                    <div class=""modal-footer"">
                        <button type=""button"" id=""btnSubmit"" class=""btn btn-success btn-sm float-sm-right disableBtnSave""><span class=""fa fa-save""></span>Lưu</button>
                        <button type=""button"" class=""btn btn-danger btn btn-sm float-sm-right btn-popup-cancel"" id=""btnClose"" style=""margin-right:5px"" data-dismiss=""modal""><span class=""fa fa-times""></span>Thoát</button>
                    </div>
                </div>
");
#nullable restore
#line 114 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysUsrUser\_Create.cshtml"
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
            ""fullName"": {
                required: true
            },
            ""email"": {
                required: true
            },
            ""password"": {
                required: true
            },
        },
        messages: {
            ""fullName"": ""Vui lòng không để trống"",
            ""email"": ""Vui lòng không để trống"",
            ""password"": ""Vui lòng không để trống"",
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tour.Admin.Models.SysUsrUserViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
