#pragma checksum "G:\projects\xms_v2\Presentation\Xms.Web\Views\User\ResetMyPassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b60273be7bb1cf6172400c60694f01ca01804e56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_ResetMyPassword), @"mvc.1.0.view", @"/Views/User/ResetMyPassword.cshtml")]
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
#line 1 "G:\projects\xms_v2\Presentation\Xms.Web\Views\_ViewImports.cshtml"
using Xms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\projects\xms_v2\Presentation\Xms.Web\Views\_ViewImports.cshtml"
using Xms.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\projects\xms_v2\Presentation\Xms.Web\Views\_ViewImports.cshtml"
using Xms.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\projects\xms_v2\Presentation\Xms.Web\Views\_ViewImports.cshtml"
using Xms.Infrastructure.Utility;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\projects\xms_v2\Presentation\Xms.Web\Views\_ViewImports.cshtml"
using Xms.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\projects\xms_v2\Presentation\Xms.Web\Views\_ViewImports.cshtml"
using Xms.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\projects\xms_v2\Presentation\Xms.Web\Views\_ViewImports.cshtml"
using Xms.Web.Framework;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b60273be7bb1cf6172400c60694f01ca01804e56", @"/Views/User/ResetMyPassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b0011d9a8909cdacaf42363c4ba3a5683bc0ece", @"/Views/_ViewImports.cshtml")]
    public class Views_User_ResetMyPassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Xms.Web.Models.ResetMyPasswordModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"panel panel-default\">\r\n    <div class=\"panel-heading\">\r\n        <h3 class=\"panel-title\">\r\n            <a data-toggle=\"collapse\"\r\n               href=\"#collapseTwo\">\r\n                <strong>");
#nullable restore
#line 8 "G:\projects\xms_v2\Presentation\Xms.Web\Views\User\ResetMyPassword.cshtml"
                   Write(app.PrivilegeTree?.LastOrDefault().DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            </a>\r\n        </h3>\r\n    </div>\r\n    <div id=\"collapseTwo\" class=\"panel-collapse collapse in\">\r\n        <div class=\"panel-body\">\r\n");
#nullable restore
#line 14 "G:\projects\xms_v2\Presentation\Xms.Web\Views\User\ResetMyPassword.cshtml"
             using (Html.BeginForm("ResetMyPassword", "user", FormMethod.Post, new { @id = "editform", @class = "form-horizontal" }))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "G:\projects\xms_v2\Presentation\Xms.Web\Views\User\ResetMyPassword.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"form-group col-sm-12\">\r\n                    <label class=\"col-sm-2 control-label\" for=\"Name\">");
#nullable restore
#line 18 "G:\projects\xms_v2\Presentation\Xms.Web\Views\User\ResetMyPassword.cshtml"
                                                                Write(app.T["user_name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    <div class=\"col-sm-10\">\r\n                        <input type=\"text\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 898, "\"", 931, 1);
#nullable restore
#line 20 "G:\projects\xms_v2\Presentation\Xms.Web\Views\User\ResetMyPassword.cshtml"
WriteAttributeValue("", 906, app.CurrentUser.UserName, 906, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled />\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group col-sm-12\">\r\n                    ");
#nullable restore
#line 24 "G:\projects\xms_v2\Presentation\Xms.Web\Views\User\ResetMyPassword.cshtml"
               Write(Html.LabelFor(x => x.OriginalPassword, app.T["user_originalpassword"], new { @class = "col-sm-2 control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 26 "G:\projects\xms_v2\Presentation\Xms.Web\Views\User\ResetMyPassword.cshtml"
                   Write(Html.PasswordFor(x => x.OriginalPassword, new { @class = "form-control", @size = "16" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group col-sm-12\">\r\n                    ");
#nullable restore
#line 30 "G:\projects\xms_v2\Presentation\Xms.Web\Views\User\ResetMyPassword.cshtml"
               Write(Html.LabelFor(x => x.NewPassword, app.T["user_newpassword"], new { @class = "col-sm-2 control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 32 "G:\projects\xms_v2\Presentation\Xms.Web\Views\User\ResetMyPassword.cshtml"
                   Write(Html.PasswordFor(x => x.NewPassword, new { @class = "form-control", @size = "16" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group col-sm-12\">\r\n                    ");
#nullable restore
#line 36 "G:\projects\xms_v2\Presentation\Xms.Web\Views\User\ResetMyPassword.cshtml"
               Write(Html.LabelFor(x => x.ConfirmPassword, app.T["user_newpassword_confirm"], new { @class = "col-sm-2 control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 38 "G:\projects\xms_v2\Presentation\Xms.Web\Views\User\ResetMyPassword.cshtml"
                   Write(Html.PasswordFor(x => x.ConfirmPassword, new { @class = "form-control", @size = "16" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group col-sm-12 text-center\" id=\"form-buttons\">\r\n                    <button type=\"submit\" class=\"btn btn-primary\"><span class=\"glyphicon glyphicon-saved\"></span> ");
#nullable restore
#line 42 "G:\projects\xms_v2\Presentation\Xms.Web\Views\User\ResetMyPassword.cshtml"
                                                                                                             Write(app.T["save"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                    <button type=\"reset\" class=\"btn btn-default\"><span class=\"glyphicon glyphicon-refresh\"></span> ");
#nullable restore
#line 43 "G:\projects\xms_v2\Presentation\Xms.Web\Views\User\ResetMyPassword.cshtml"
                                                                                                              Write(app.T["reset"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                </div>\r\n");
#nullable restore
#line 45 "G:\projects\xms_v2\Presentation\Xms.Web\Views\User\ResetMyPassword.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 2652, "\"", 2722, 2);
                WriteAttributeValue("", 2658, "/content/js/jquery.form.js?v=", 2658, 29, true);
#nullable restore
#line 50 "G:\projects\xms_v2\Presentation\Xms.Web\Views\User\ResetMyPassword.cshtml"
WriteAttributeValue("", 2687, app.PlatformSettings.VersionNumber, 2687, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 2746, "\"", 2840, 2);
                WriteAttributeValue("", 2752, "/content/js/jquery-validate/jquery.validate.min.js?v=", 2752, 53, true);
#nullable restore
#line 51 "G:\projects\xms_v2\Presentation\Xms.Web\Views\User\ResetMyPassword.cshtml"
WriteAttributeValue("", 2805, app.PlatformSettings.VersionNumber, 2805, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 2864, "\"", 2967, 2);
                WriteAttributeValue("", 2870, "/content/js/jquery-validate/localization/messages_zh.min.js?v=", 2870, 62, true);
#nullable restore
#line 52 "G:\projects\xms_v2\Presentation\Xms.Web\Views\User\ResetMyPassword.cshtml"
WriteAttributeValue("", 2932, app.PlatformSettings.VersionNumber, 2932, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script>\r\n        $(function () {\r\n            //表单验证\r\n            Xms.Web.Form($(\"#editform\"));\r\n        });\r\n    </script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Xms.Web.Framework.Context.IWebAppContext app { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Xms.Web.Models.ResetMyPasswordModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
