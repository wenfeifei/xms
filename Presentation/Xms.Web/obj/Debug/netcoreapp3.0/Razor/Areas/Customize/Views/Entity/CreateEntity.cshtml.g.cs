#pragma checksum "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd71f10abb536b86645faeab1d050ada2559fc73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customize_Views_Entity_CreateEntity), @"mvc.1.0.view", @"/Areas/Customize/Views/Entity/CreateEntity.cshtml")]
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
#line 1 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\_ViewImports.cshtml"
using Xms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\_ViewImports.cshtml"
using Xms.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\_ViewImports.cshtml"
using Xms.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\_ViewImports.cshtml"
using Xms.Infrastructure.Utility;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\_ViewImports.cshtml"
using Xms.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\_ViewImports.cshtml"
using Xms.Web.Framework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\_ViewImports.cshtml"
using Xms.Web.Customize.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
using Xms.Schema.Abstractions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd71f10abb536b86645faeab1d050ada2559fc73", @"/Areas/Customize/Views/Entity/CreateEntity.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b0e0822572318de59551e4c02160fd04d8a0b74", @"/Areas/Customize/Views/_ViewImports.cshtml")]
    public class Areas_Customize_Views_Entity_CreateEntity : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Xms.Web.Customize.Models.CreateEntityModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("editform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-autoreset", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"panel panel-default\">\r\n    <div class=\"panel-heading\">\r\n        <h3 class=\"panel-title\">\r\n            <a data-toggle=\"collapse\"\r\n               href=\"#collapseTwo\">\r\n                <strong>");
#nullable restore
#line 9 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
                   Write(app.PrivilegeTree?.LastOrDefault().DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            </a>\r\n        </h3>\r\n    </div>\r\n    <div id=\"collapseTwo\" class=\"panel-collapse collapse in\">\r\n        <div class=\"panel-body\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd71f10abb536b86645faeab1d050ada2559fc736880", async() => {
                WriteLiteral(@"
                <ul id=""myTab"" class=""nav nav-tabs"">
                    <li class=""active"">
                        <a href=""#common"" data-toggle=""tab"">
                            实体信息
                        </a>
                    </li>
                    <li>
                        <a href=""#defaults"" data-toggle=""tab"">
                            默认创建
                        </a>
                    </li>
                </ul>
                <div id=""myTabContent"" class=""tab-content"">
                    <div id=""common"" class=""tab-pane fade in active"" style=""padding:5px;"">
                        ");
#nullable restore
#line 30 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
                   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 31 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
                   Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 32 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
                   Write(Html.HiddenFor(x => x.SolutionId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <div class=\"form-group col-sm-12\">\r\n                            ");
#nullable restore
#line 34 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
                       Write(Html.LabelFor(x => x.Name, app.T["name"], new { @class = "col-sm-2 control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            <div class=\"col-sm-10\">\r\n                                ");
#nullable restore
#line 36 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
                           Write(Html.TextBoxFor(x => x.Name, new { @class = "form-control required", @data_custom = "entitieName", entitieName = true, @data_customMsg = "首字符为字母，只能输入数字，字母或者下划线", @data_customReg = "^[a-zA-Z]+[\\w_]*$", @autofocus = true }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"form-group col-sm-12\">\r\n                            ");
#nullable restore
#line 40 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
                       Write(Html.LabelFor(x => x.LocalizedName, app.T["displayname"], new { @class = "col-sm-2 control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            <div class=\"col-sm-10\">\r\n                                ");
#nullable restore
#line 42 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
                           Write(Html.TextBoxFor(x => x.LocalizedName, new { @class = "form-control required" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"form-group col-sm-12\">\r\n                            ");
#nullable restore
#line 46 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
                       Write(Html.LabelFor(x => x.ParentEntityId, app.T["entity_parent"], new { @class = "col-sm-2 control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            <div class=\"col-sm-10\">\r\n                                ");
#nullable restore
#line 48 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
                           Write(Html.TextBoxFor(x => x.ParentEntityId, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"form-group col-sm-12\">\r\n                            ");
#nullable restore
#line 52 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
                       Write(Html.LabelFor(x => x.EntityMask, app.T["entity_mask"], new { @class = "col-sm-2 control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            <div class=\"col-sm-10\">\r\n                                <label class=\"checkbox-inline\">\r\n                                    ");
#nullable restore
#line 55 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
                               Write(Html.RadioButtonFor(x => x.EntityMask, EntityMaskEnum.User, new { @class = "required" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 55 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
                                                                                                                         Write(app.T["entity_mask_user"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </label>\r\n                                <label class=\"checkbox-inline\">\r\n                                    ");
#nullable restore
#line 58 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
                               Write(Html.RadioButtonFor(x => x.EntityMask, EntityMaskEnum.Organization, new { @class = "required" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 58 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
                                                                                                                                 Write(app.T["entity_mask_organization"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </label>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"form-group col-sm-12\">\r\n                            ");
#nullable restore
#line 63 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
                       Write(Html.LabelFor(x => x.LogEnabled, app.T["entity_isloged"], new { @class = "col-sm-2 control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            <div class=\"col-sm-10\">\r\n                                <label class=\"checkbox-inline\">\r\n                                    ");
#nullable restore
#line 66 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
                               Write(Html.RadioButtonFor(x => x.LogEnabled, true, new { @class = "required" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 66 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
                                                                                                          Write(app.T["enabled"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </label>\r\n                                <label class=\"checkbox-inline\">\r\n                                    ");
#nullable restore
#line 69 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
                               Write(Html.RadioButtonFor(x => x.LogEnabled, false, new { @class = "required" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 69 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
                                                                                                           Write(app.T["disabled"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </label>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"form-group col-sm-12\">\r\n                            ");
#nullable restore
#line 74 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
                       Write(Html.LabelFor(x => x.AuthorizationEnabled, app.T["power_control"], new { @class = "col-sm-2 control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            <div class=\"col-sm-10\">\r\n                                <label class=\"checkbox-inline\">\r\n                                    ");
#nullable restore
#line 77 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
                               Write(Html.RadioButtonFor(x => x.AuthorizationEnabled, true, new { @class = "required" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 77 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
                                                                                                                    Write(app.T["enabled"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </label>\r\n                                <label class=\"checkbox-inline\">\r\n                                    ");
#nullable restore
#line 80 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
                               Write(Html.RadioButtonFor(x => x.AuthorizationEnabled, false, new { @class = "required" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 80 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
                                                                                                                     Write(app.T["disabled"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </label>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"form-group col-sm-12\">\r\n                            ");
#nullable restore
#line 85 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
                       Write(Html.LabelFor(x => x.DuplicateEnabled, app.T["repeat_duplicate"], new { @class = "col-sm-2 control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            <div class=\"col-sm-10\">\r\n                                <label class=\"checkbox-inline\">\r\n                                    ");
#nullable restore
#line 88 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
                               Write(Html.RadioButtonFor(x => x.DuplicateEnabled, true, new { @class = "required" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 88 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
                                                                                                                Write(app.T["enabled"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </label>\r\n                                <label class=\"checkbox-inline\">\r\n                                    ");
#nullable restore
#line 91 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
                               Write(Html.RadioButtonFor(x => x.DuplicateEnabled, false, new { @class = "required" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 91 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
                                                                                                                 Write(app.T["disabled"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </label>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"form-group col-sm-12\">\r\n                            ");
#nullable restore
#line 96 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
                       Write(Html.LabelFor(x => x.WorkFlowEnabled, app.T["entity_workflowenabled"], new { @class = "col-sm-2 control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            <div class=\"col-sm-10\">\r\n                                <label class=\"checkbox-inline\">\r\n                                    ");
#nullable restore
#line 99 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
                               Write(Html.RadioButtonFor(x => x.WorkFlowEnabled, true, new { @class = "required" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 99 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
                                                                                                               Write(app.T["enabled"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </label>\r\n                                <label class=\"checkbox-inline\">\r\n                                    ");
#nullable restore
#line 102 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
                               Write(Html.RadioButtonFor(x => x.WorkFlowEnabled, false, new { @class = "required" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 102 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
                                                                                                                Write(app.T["disabled"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </label>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"form-group col-sm-12\">\r\n                            ");
#nullable restore
#line 107 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
                       Write(Html.LabelFor(x => x.BusinessFlowEnabled, app.T["entity_businessflowenabled"], new { @class = "col-sm-2 control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            <div class=\"col-sm-10\">\r\n                                <label class=\"checkbox-inline\">\r\n                                    ");
#nullable restore
#line 110 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
                               Write(Html.RadioButtonFor(x => x.BusinessFlowEnabled, true, new { @class = "required" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 110 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
                                                                                                                   Write(app.T["enabled"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </label>\r\n                                <label class=\"checkbox-inline\">\r\n                                    ");
#nullable restore
#line 113 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
                               Write(Html.RadioButtonFor(x => x.BusinessFlowEnabled, false, new { @class = "required" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 113 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
                                                                                                                    Write(app.T["disabled"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </label>
                            </div>
                        </div>
                        <div class=""form-group col-sm-12"">
                            <label class=""col-sm-2 control-label"">分组</label>
                            <div class=""col-sm-10"" id=""entitygroups"">
                            </div>
                        </div>
                        <div class=""form-group col-sm-12"">
                            ");
#nullable restore
#line 123 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
                       Write(Html.LabelFor(x => x.Description, app.T["description"], new { @class = "col-sm-2 control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            <div class=\"col-sm-10\">\r\n                                ");
#nullable restore
#line 125 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
                           Write(Html.TextAreaFor(x => x.Description, new { @class = "form-control", @row = 5 }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""form-group col-sm-12 text-center"" id=""form-buttons"">
                            <button type=""submit"" class=""btn btn-primary""><span class=""glyphicon glyphicon-saved""></span> ");
#nullable restore
#line 129 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
                                                                                                                     Write(app.T["save"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n                            <button type=\"reset\" class=\"btn btn-default\"><span class=\"glyphicon glyphicon-refresh\"></span> ");
#nullable restore
#line 130 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
                                                                                                                      Write(app.T["reset"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</button>
                        </div>
                    </div>
                    <div id=""defaults"" class=""tab-pane fade"" style=""padding:5px;"">
                        <div class=""form-group col-sm-12"">
                            <label class=""col-sm-2 control-label"">默认表单</label>
                            <div class=""col-sm-10"">
                                <label><input type=""checkbox"" name=""createDefaultForm"" checked=""checked"" value=""true"" /> 创建</label>
                            </div>
                        </div>
                        <div class=""form-group col-sm-12"">
                            <label class=""col-sm-2 control-label"">默认视图</label>
                            <div class=""col-sm-10"">
                                <label><input type=""checkbox"" name=""createDefaultView"" checked=""checked"" value=""true"" /> 创建</label>
                            </div>
                        </div>
                        <div class=""form-group col-sm-12"">
                     ");
                WriteLiteral(@"       <label class=""col-sm-2 control-label"">默认字段</label>
                            <div class=""col-sm-10"" id=""defaultAttributes"">
                                <div class=""col-sm-12 btn-group btn-group-xs"">
                                    <button type=""button"" class=""btn btn-default"">全选</button>
                                    <button type=""button"" class=""btn btn-default"">取消</button>
                                </div>
                            </div>
                        </div>
                        <div class=""form-group col-sm-12"">
                            <label class=""col-sm-2 control-label"">默认按钮</label>
                            <div class=""col-sm-10"" id=""defaultButtons"">
                                <div class=""col-sm-12 btn-group btn-group-xs"">
                                    <button type=""button"" class=""btn btn-default"">全选</button>
                                    <button type=""button"" class=""btn btn-default"">取消</button>
                            ");
                WriteLiteral("    </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 514, "/", 514, 1, true);
#nullable restore
#line 15 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
AddHtmlAttributeValue("", 515, app.OrganizationUniqueName, 515, 27, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 542, "/customize/entity/", 542, 18, true);
#nullable restore
#line 15 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
AddHtmlAttributeValue("", 560, app.ActionName, 560, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 11073, "\"", 11143, 2);
                WriteAttributeValue("", 11079, "/content/js/jquery.form.js?v=", 11079, 29, true);
#nullable restore
#line 171 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
WriteAttributeValue("", 11108, app.PlatformSettings.VersionNumber, 11108, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 11167, "\"", 11261, 2);
                WriteAttributeValue("", 11173, "/content/js/jquery-validate/jquery.validate.min.js?v=", 11173, 53, true);
#nullable restore
#line 172 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
WriteAttributeValue("", 11226, app.PlatformSettings.VersionNumber, 11226, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 11285, "\"", 11388, 2);
                WriteAttributeValue("", 11291, "/content/js/jquery-validate/localization/messages_zh.min.js?v=", 11291, 62, true);
#nullable restore
#line 173 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Entity\CreateEntity.cshtml"
WriteAttributeValue("", 11353, app.PlatformSettings.VersionNumber, 11353, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"></script>
    <script>
        $(function () {
            //表单验证
            Xms.Web.Form($(""#editform""), function (response) {
                Xms.Web.Alert(response.IsSuccess, response.Content);
                if (response.IsSuccess) {
                    Xms.Web.Event.publish('refresh');
                    Xms.Web.Event.publish('refreshtree');
                }
            }, null, null, { onKeyup: true });
            //检查名称是否已存在
            $('#Name').bind('change', function () {
                var $this = $(this);
                var name = $this.val();
                if (name != '') {
                    Xms.Web.Get('/customize/entity/Exists?entityid=' + $('#EntityId').val() + '&name=' + name, function (response) {
                        $this.next().remove();
                        $this.parents('.form-group').removeClass('has-error');
                        if (!response.IsSuccess) {
                            $this.after($('<div class=""text-danger""><span class=""glyphico");
                WriteLiteral(@"n glyphicon-remove-sign""></span>' + response.Content + '</div>'));
                            $this.parents('.form-group').addClass('has-error');
                        }
                    });
                }
            });
            bindSystemAttributes();
            bindSystemButtons();
            loadEntities();
            bindEntityGroups();
        });
        function bindEntityGroups() {
            Xms.Ajax.GetJson('/api/data/retrieve/all/entitygroup/name/name:asc', null, function (response) {
                var data = Xms.Web.GetAjaxResult(response);
                var $container = $('#entitygroups');
                $(data.content).each(function (i, n) {
                    $container.append('<label class=""col-sm-3 col-xs-3""><input type=""checkbox"" name=""entitygroupid"" value=""' + n.entitygroupid + '"" />' + n.name + '</label>');
                });
            });
        }
        function bindSystemAttributes() {
            Xms.Ajax.GetJson('/api/schema/attribute/");
                WriteLiteral(@"SystemAttributes/user', null, function (response) {
                console.log(response);
                if (response.IsSuccess) {
                    var container = $('#defaultAttributes');
                    var data = JSON.parse(response.Content);
                    $(data).each(function (i, n) {
                        if (n.attributetypename == 'primarykey') {
                            //n.localizedname = LOC_ATTRIBUTETYPE_PRIMARYKEY;
                            return true;
                        }
                        container.append($('<label class=""col-sm-3""><input type=""checkbox"" name=""defaultattributes"" value=""' + n.name + '"" checked=""checked"" /> ' + n.localizedname + '</label>'));
                    });
                    container.find('button:eq(0)').click(function () {
                        container.find('input[type=checkbox]').prop('checked', true);
                    });
                    container.find('button:eq(1)').click(function () {
                  ");
                WriteLiteral(@"      container.find('input[type=checkbox]').removeProp('checked');
                    });
                }
                else {
                    Xms.Web.Alert(response.Content);
                }
            })
        }
        function bindSystemButtons() {
            Xms.Ajax.GetJson('/api/ribbonbutton/SystemButtons/user', null, function (response) {
                console.log(response);
                if (response.IsSuccess) {
                    var container = $('#defaultButtons');
                    var data = JSON.parse(response.Content);
                    var group = [];
                    $(data).each(function (i, n) {
                        if ($.inArray(n.showarea, group) < 0) {
                            group.push(n.showarea);
                        }
                    });
                    var groupNames = ['表单', '列表头部', '列表行内', '单据体'];
                    $(group).each(function (j, g) {
                        var groupLine = $('<div class=""col-sm-12");
                WriteLiteral(@"""></div>');
                        groupLine.append($('<h5>' + groupNames[g - 1] + '</h5>'));
                        $(data).each(function (i, n) {
                            if (g == n.showarea) {
                                groupLine.append($('<label class=""col-sm-3""><input type=""checkbox"" name=""defaultbuttons"" value=""' + n.ribbonbuttonid + '"" checked=""checked"" /> ' + n.label + '</label>'));
                            }
                        });
                        container.append(groupLine);
                    });
                    container.find('button:eq(0)').click(function () {
                        container.find('input[type=checkbox]').prop('checked', true);
                    });
                    container.find('button:eq(1)').click(function () {
                        container.find('input[type=checkbox]').removeProp('checked');
                    });
                }
                else {
                    Xms.Web.Alert(response.Content);
           ");
                WriteLiteral("     }\r\n            })\r\n        }\r\n        //加载引用实体\r\n        function loadEntities() {\r\n            var entitySelect = $(\'#ParentEntityId\');\r\n            entitySelect.entitySelector({});\r\n        }\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Xms.Web.Customize.Models.CreateEntityModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
