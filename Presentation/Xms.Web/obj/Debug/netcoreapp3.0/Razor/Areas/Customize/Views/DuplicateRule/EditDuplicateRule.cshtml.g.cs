#pragma checksum "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\DuplicateRule\EditDuplicateRule.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e1a7bfcef6e8597a34557e9e7e9b7c4ea40199c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customize_Views_DuplicateRule_EditDuplicateRule), @"mvc.1.0.view", @"/Areas/Customize/Views/DuplicateRule/EditDuplicateRule.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e1a7bfcef6e8597a34557e9e7e9b7c4ea40199c", @"/Areas/Customize/Views/DuplicateRule/EditDuplicateRule.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b0e0822572318de59551e4c02160fd04d8a0b74", @"/Areas/Customize/Views/_ViewImports.cshtml")]
    public class Areas_Customize_Views_DuplicateRule_EditDuplicateRule : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Xms.Web.Customize.Models.EditDuplicateRuleModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("editform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 8 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\DuplicateRule\EditDuplicateRule.cshtml"
                   Write(app.PrivilegeTree?.LastOrDefault().DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 8 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\DuplicateRule\EditDuplicateRule.cshtml"
                                                                     Write(Model.EntityMeta.LocalizedName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            </a>\r\n        </h3>\r\n    </div>\r\n    <div id=\"collapseTwo\" class=\"panel-collapse collapse in\">\r\n        <div class=\"panel-body\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e1a7bfcef6e8597a34557e9e7e9b7c4ea40199c6727", async() => {
                WriteLiteral("\r\n                ");
#nullable restore
#line 15 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\DuplicateRule\EditDuplicateRule.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 16 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\DuplicateRule\EditDuplicateRule.cshtml"
           Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 17 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\DuplicateRule\EditDuplicateRule.cshtml"
           Write(Html.HiddenFor(x => x.EntityId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 18 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\DuplicateRule\EditDuplicateRule.cshtml"
           Write(Html.HiddenFor(x => x.DuplicateRuleId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"form-group col-sm-12\">\r\n                    <label class=\"col-sm-2 control-label\">实体</label>\r\n                    <div class=\"col-sm-10\">\r\n                        <input type=\"text\" class=\"form-control input-sm\"");
                BeginWriteAttribute("value", " value=\"", 1093, "\"", 1132, 1);
#nullable restore
#line 22 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\DuplicateRule\EditDuplicateRule.cshtml"
WriteAttributeValue("", 1101, Model.EntityMeta.LocalizedName, 1101, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" disabled />\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group col-sm-12\">\r\n                    ");
#nullable restore
#line 26 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\DuplicateRule\EditDuplicateRule.cshtml"
               Write(Html.LabelFor(x => x.Name, "名称", new { @class = "col-sm-2 control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <div class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 28 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\DuplicateRule\EditDuplicateRule.cshtml"
                   Write(Html.TextBoxFor(x => x.Name, new { @class = "form-control required" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group col-sm-12\">\r\n                    ");
#nullable restore
#line 32 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\DuplicateRule\EditDuplicateRule.cshtml"
               Write(Html.LabelFor(x => x.Description, "描述", new { @class = "col-sm-2 control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <div class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 34 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\DuplicateRule\EditDuplicateRule.cshtml"
                   Write(Html.TextAreaFor(x => x.Description, new { @class = "form-control", @rows = 3 }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group col-sm-12\">\r\n                    ");
#nullable restore
#line 38 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\DuplicateRule\EditDuplicateRule.cshtml"
               Write(Html.LabelFor(x => x.Intercepted, "拦截", new { @class = "col-sm-2 control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("<!--\"状态\"-->\r\n                    <div class=\"col-sm-10\">\r\n                        <label class=\"checkbox-inline\">\r\n                            ");
#nullable restore
#line 41 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\DuplicateRule\EditDuplicateRule.cshtml"
                       Write(Html.RadioButtonFor(x => x.Intercepted, true, new { @class = "required" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 41 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\DuplicateRule\EditDuplicateRule.cshtml"
                                                                                                   Write(app.T["yes"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </label>\r\n                        <label class=\"checkbox-inline\">\r\n                            ");
#nullable restore
#line 44 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\DuplicateRule\EditDuplicateRule.cshtml"
                       Write(Html.RadioButtonFor(x => x.Intercepted, false, new { @class = "required" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 44 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\DuplicateRule\EditDuplicateRule.cshtml"
                                                                                                    Write(app.T["no"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </label>\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group col-sm-12\">\r\n                    ");
#nullable restore
#line 49 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\DuplicateRule\EditDuplicateRule.cshtml"
               Write(Html.LabelFor(x => x.StateCode, "状态", new { @class = "col-sm-2 control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <div class=\"col-sm-10\">\r\n                        <label class=\"checkbox-inline\">\r\n                            ");
#nullable restore
#line 52 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\DuplicateRule\EditDuplicateRule.cshtml"
                       Write(Html.RadioButtonFor(x => x.StateCode, Xms.Core.RecordState.Enabled, new { @class = "required" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" 可用\r\n                        </label>\r\n                        <label class=\"checkbox-inline\">\r\n                            ");
#nullable restore
#line 55 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\DuplicateRule\EditDuplicateRule.cshtml"
                       Write(Html.RadioButtonFor(x => x.StateCode, Xms.Core.RecordState.Disabled, new { @class = "required" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@" 禁用
                        </label>
                    </div>
                </div>
                <div class=""form-group col-sm-12"">
                    <label class=""col-sm-2 control-label"" for=""optionset-picklist"">条件</label>
                    <div class=""col-sm-10"">
                        <div id=""optionset-area"">
                            <div class=""btn-group"">
                                <button type=""button"" class=""btn btn-primary btn-xs"" onclick=""addOption('optionset-picklist')"">
                                    <span class=""glyphicon glyphicon-plus-sign""></span> 增加
                                </button>
                                <button type=""button"" class=""btn btn-default btn-xs"" onclick=""clearOption('optionset-picklist')"">
                                    <span class=""glyphicon glyphicon-trash""></span> 清空
                                </button>
                            </div>
                            <div class=""text-muted pull-right"">字段不能重复选择</di");
                WriteLiteral(@"v>
                            <table id=""optionset-picklist"" class=""table"">
                                <thead>
                                    <tr>
                                        <th>字段</th>
                                        <th>忽略空值</th>
                                        <th>区分大小写</th>
                                        <th>操作</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 82 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\DuplicateRule\EditDuplicateRule.cshtml"
                                     foreach (var item in Model.Conditions)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <tr class=\"row_clone\">\r\n                                            <td>\r\n                                                <input type=\"text\" name=\"attributeid\"");
                BeginWriteAttribute("value", " value=\"", 5037, "\"", 5062, 1);
#nullable restore
#line 86 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\DuplicateRule\EditDuplicateRule.cshtml"
WriteAttributeValue("", 5045, item.AttributeId, 5045, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                                <input type=\"hidden\" name=\"detailid\"");
                BeginWriteAttribute("value", " value=\"", 5152, "\"", 5190, 1);
#nullable restore
#line 87 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\DuplicateRule\EditDuplicateRule.cshtml"
WriteAttributeValue("", 5160, item.DuplicateRuleConditionId, 5160, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                            </td>\r\n                                            <td>\r\n                                                <input type=\"checkbox\" onclick=\"$(this).next().val($(this).prop(\'checked\'))\" ");
#nullable restore
#line 90 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\DuplicateRule\EditDuplicateRule.cshtml"
                                                                                                                         Write(item.IgnoreNullValues ? "checked" : "");

#line default
#line hidden
#nullable disable
                WriteLiteral(" />\r\n                                                <input name=\"ignorenullvalues\" type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 5560, "\"", 5603, 1);
#nullable restore
#line 91 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\DuplicateRule\EditDuplicateRule.cshtml"
WriteAttributeValue("", 5568, item.IgnoreNullValues.ToString(), 5568, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                            </td>\r\n                                            <td>\r\n                                                <input type=\"checkbox\" onclick=\"$(this).next().val($(this).prop(\'checked\'))\" ");
#nullable restore
#line 94 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\DuplicateRule\EditDuplicateRule.cshtml"
                                                                                                                         Write(item.IsCaseSensitive ? "checked" : "");

#line default
#line hidden
#nullable disable
                WriteLiteral(" />\r\n                                                <input name=\"iscasesensitive\" type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 5971, "\"", 6013, 1);
#nullable restore
#line 95 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\DuplicateRule\EditDuplicateRule.cshtml"
WriteAttributeValue("", 5979, item.IsCaseSensitive.ToString(), 5979, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                            </td>
                                            <td>
                                                <button type=""button"" class=""btn btn-warning btn-xs"" onclick=""removeOption('optionset-picklist', this)"">
                                                    <span class=""glyphicon glyphicon-trash""></span>
                                                </button>
                                            </td>
                                        </tr>
");
#nullable restore
#line 103 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\DuplicateRule\EditDuplicateRule.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
                <div class=""form-group col-sm-12 text-center"" id=""form-buttons"">
                    <button type=""submit"" class=""btn btn-primary""><span class=""glyphicon glyphicon-saved""></span> 保存</button>
                    <button type=""reset"" class=""btn btn-default""><span class=""glyphicon glyphicon-refresh""></span> 重置</button>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 6, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 520, "/", 520, 1, true);
#nullable restore
#line 14 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\DuplicateRule\EditDuplicateRule.cshtml"
AddHtmlAttributeValue("", 521, app.OrganizationUniqueName, 521, 27, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 548, "/customize/", 548, 11, true);
#nullable restore
#line 14 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\DuplicateRule\EditDuplicateRule.cshtml"
AddHtmlAttributeValue("", 559, app.ControllerName, 559, 19, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 578, "/", 578, 1, true);
#nullable restore
#line 14 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\DuplicateRule\EditDuplicateRule.cshtml"
AddHtmlAttributeValue("", 579, app.ActionName, 579, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
                BeginWriteAttribute("src", " src=\"", 7184, "\"", 7255, 2);
                WriteAttributeValue("", 7190, "/content/js/xms.metadata.js?v=", 7190, 30, true);
#nullable restore
#line 118 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\DuplicateRule\EditDuplicateRule.cshtml"
WriteAttributeValue("", 7220, app.PlatformSettings.VersionNumber, 7220, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 7279, "\"", 7349, 2);
                WriteAttributeValue("", 7285, "/content/js/jquery.form.js?v=", 7285, 29, true);
#nullable restore
#line 119 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\DuplicateRule\EditDuplicateRule.cshtml"
WriteAttributeValue("", 7314, app.PlatformSettings.VersionNumber, 7314, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 7373, "\"", 7467, 2);
                WriteAttributeValue("", 7379, "/content/js/jquery-validate/jquery.validate.min.js?v=", 7379, 53, true);
#nullable restore
#line 120 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\DuplicateRule\EditDuplicateRule.cshtml"
WriteAttributeValue("", 7432, app.PlatformSettings.VersionNumber, 7432, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 7491, "\"", 7594, 2);
                WriteAttributeValue("", 7497, "/content/js/jquery-validate/localization/messages_zh.min.js?v=", 7497, 62, true);
#nullable restore
#line 121 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\DuplicateRule\EditDuplicateRule.cshtml"
WriteAttributeValue("", 7559, app.PlatformSettings.VersionNumber, 7559, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"></script>
    <script>
        var AttributeMetaDatas = [];
        $(function () {
            //表单验证
            Xms.Web.Form($(""#editform""), function (response) {
                Xms.Web.Alert(response.IsSuccess, response.Content, function () {
                    reloadSetAttribute();
                }, function () {
                    reloadSetAttribute();
                });

            });

            loadAttribute();
        });
        function loadAttribute() {
            Xms.Schema.GetAttributes({ getall: true, entityid: $('#EntityId').val() }, function (response) {
                AttributeMetaDatas = [];
                $(response).each(function (i, n) {
                    var attr = {};
                    attr.id = n.attributeid;
                    attr.name = n.name;
                    attr.text = n.localizedname;
                    attr.value = n.attributeid;

                    AttributeMetaDatas.push(attr);
                });
                setAttribu");
                WriteLiteral(@"teOptions();
            });
        }
        function setAttributeOptions() {
            $('#optionset-picklist').find('input[name=attributeid]:not(.hide)').each(function () {
                $(this).removeAttr('data-picklistinit').removeAttr('data-instance');
                if ($(this).next('select').length > 0) {
                    $(this).next('select').remove()
                }
                var value = $(this).val();
                console.log(value)
                $(this).picklist({
                    isDefault: true,
                    items: AttributeMetaDatas
                });
            });
        }
        function reloadSetAttribute() {
            $('#optionset-picklist').find('input[name=attributeid]').each(function () {
                var seler = $(this).next(), val = $(this).attr('data-value');
                if (val != """") {
                    seler.val(val);
                }
            });
        }
        //增加选项
        function addOption(id) ");
                WriteLiteral(@"{
            var $target = $(""#"" + id);
            var newRow = $target.find('tr:last').clone();
            newRow.find('input[type=text]').val('');
            newRow.find('input[type=hidden]').val(Xms.Utility.Guid.EmptyGuid.ToString());
            newRow.find('input[type=checkbox]').prop('checked', false).next().val(false);
            $target.append(newRow);
            $target.find('select:last').find('option:not(.hide)').eq(1).prop('selected', true).trigger('change');
            OptionState();
            setAttributeOptions();
            return newRow;
        }
        //删除选项
        function removeOption(id, row) {
            var $target = $(""#"" + id);
            if ($(row).parents('tr').siblings().length > 0) {
                $(row).parents('tr').remove();
            }
            else {
                var newRow = $(row).parents('tr');
                $target.find('tbody').empty();
                addOption(id, newRow);
                setAttributeOptions();
       ");
                WriteLiteral(@"     }
        }
        //清空选项
        function clearOption(id,isSetOptions) {
            var $target = $(""#"" + id);
            $target.find('tbody').find('tr:gt(0)').remove();
            var newRow = addOption(id, newRow).clone(true);
            newRow.find('input[name=""attributeid""]').removeClass('hide');
            $target.find('tbody').empty();
            $target.find('tbody').append(newRow);
            if (!isSetOptions) {
                setAttributeOptions();
            }
        }
         function OptionState() {
            $('#optionset-picklist option').removeClass('show');
            $('#optionset-picklist select').each(function (i, n) {
                var val = $(n).find('option:selected').val();
                $(n).find('option[value=""""]').addClass('hide');
                $(n).parents('tr').siblings('tr').find('option[value=""' + val + '""]').addClass('hide');
            });
        }
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Xms.Web.Customize.Models.EditDuplicateRuleModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
