#pragma checksum "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\EditWebResource.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d35b414713b93ff6daf998c09c882811d922fb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customize_Views_WebResource_EditWebResource), @"mvc.1.0.view", @"/Areas/Customize/Views/WebResource/EditWebResource.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d35b414713b93ff6daf998c09c882811d922fb7", @"/Areas/Customize/Views/WebResource/EditWebResource.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b0e0822572318de59551e4c02160fd04d8a0b74", @"/Areas/Customize/Views/_ViewImports.cshtml")]
    public class Areas_Customize_Views_WebResource_EditWebResource : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Xms.Web.Customize.Models.EditWebResourceModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("editform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-autoreset", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 8 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\EditWebResource.cshtml"
                   Write(app.PrivilegeTree?.LastOrDefault().DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            </a>\r\n        </h3>\r\n    </div>\r\n    <div id=\"collapseTwo\" class=\"panel-collapse collapse in\">\r\n        <div class=\"panel-body\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d35b414713b93ff6daf998c09c882811d922fb77091", async() => {
                WriteLiteral("\r\n                ");
#nullable restore
#line 15 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\EditWebResource.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 16 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\EditWebResource.cshtml"
           Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 17 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\EditWebResource.cshtml"
           Write(Html.HiddenFor(x => x.SolutionId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 18 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\EditWebResource.cshtml"
           Write(Html.HiddenFor(x => x.WebResourceId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"form-group col-sm-12\">\r\n                    ");
#nullable restore
#line 20 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\EditWebResource.cshtml"
               Write(Html.LabelFor(x => x.Name, "名称", new { @class = "col-sm-2 control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <div class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 22 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\EditWebResource.cshtml"
                   Write(Html.TextBoxFor(x => x.Name, new { @class = "form-control required" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group col-sm-12\">\r\n                    ");
#nullable restore
#line 26 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\EditWebResource.cshtml"
               Write(Html.LabelFor(x => x.WebResourceType, "类型", new { @class = "col-sm-2 control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <div class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 28 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\EditWebResource.cshtml"
                   Write(Html.TextBoxFor(x => x.WebResourceType, new { @class = "form-control required", @data_value = Model.WebResourceType.ToString() }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group col-sm-12\">\r\n                    ");
#nullable restore
#line 32 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\EditWebResource.cshtml"
               Write(Html.LabelFor(x => x.Description, "描述", new { @class = "col-sm-2 control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <div class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 34 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\EditWebResource.cshtml"
                   Write(Html.TextAreaFor(x => x.Description, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>
                </div>
                <div class=""form-group col-sm-12"">
                    <label class=""col-sm-2 control-label""></label>
                    <div class=""col-sm-10"">
                        <label class=""checkbox-inline"">
                            <input type=""radio"" class=""radio-inline"" name=""type"" data-value=""editor"" value=""1"" checked /> 文本编辑
                        </label>
                        <label class=""checkbox-inline"">
                            <input type=""radio"" class=""radio-inline"" name=""type"" data-value=""upload"" value=""0"" /> 上传文件
                        </label>
                    </div>
                </div>
                <div id=""type-editor"" class=""form-group col-sm-12 contentEditor-wrap"">
                    ");
#nullable restore
#line 49 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\EditWebResource.cshtml"
               Write(Html.LabelFor(x => x.Content, "内容", new { @class = "col-sm-2 control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <div class=\"col-sm-10\">\r\n");
                WriteLiteral("                        <div id=\"contentEditor\" class=\"contentEditor\"><span class=\"contentEditor-close glyphicon glyphicon-remove\"></span><span class=\"contentEditor-fullscreen glyphicon glyphicon-fullscreen\"></span>");
#nullable restore
#line 52 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\EditWebResource.cshtml"
                                                                                                                                                                                                                  Write(Html.TextAreaFor(x => x.Content, new { @class = "form-control", @rows = 8 }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</div>
                    </div>
                </div>
                <div id=""type-upload"" class=""form-group col-sm-12 hide"">
                    <label for=""file"" class=""col-sm-2 control-label"">文件</label>
                    <div class=""col-sm-10"">
                        <input type=""file"" name=""ResourceFile"" id=""file"" class=""form-control hidden"" onchange=""$('#fileText').val($(this).val());"">
                        <div class=""input-group"">
                            <input id=""fileText"" type=""text"" class=""form-control"" placeholder=""文件名称"" disabled>
                            <span class=""input-group-btn"">
                                <button class=""btn btn-info"" type=""button"" onclick=""$('#file').click();""><i class=""glyphicon glyphicon-cloud-upload""></i>上传</button>
                            </span>
                        </div>
                    </div>
                </div>
                <div class=""form-group col-sm-12 text-center"" id=""form-buttons"">
                    <bu");
                WriteLiteral(@"tton type=""submit"" class=""btn btn-primary""><span class=""glyphicon glyphicon-saved""></span> 保存</button>
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
            AddHtmlAttributeValue("", 484, "/", 484, 1, true);
#nullable restore
#line 14 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\EditWebResource.cshtml"
AddHtmlAttributeValue("", 485, app.OrganizationUniqueName, 485, 27, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 512, "/customize/", 512, 11, true);
#nullable restore
#line 14 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\EditWebResource.cshtml"
AddHtmlAttributeValue("", 523, app.ControllerName, 523, 19, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 542, "/", 542, 1, true);
#nullable restore
#line 14 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\EditWebResource.cshtml"
AddHtmlAttributeValue("", 543, app.ActionName, 543, 15, false);

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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("Header", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" type=\"text/css\"");
                BeginWriteAttribute("href", " href=\"", 4721, "\"", 4810, 2);
                WriteAttributeValue("", 4728, "/content/customize/codemirror/codemirror.css?v=", 4728, 47, true);
#nullable restore
#line 76 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\EditWebResource.cshtml"
WriteAttributeValue("", 4775, app.PlatformSettings.VersionNumber, 4775, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <link rel=\"stylesheet\" type=\"text/css\"");
                BeginWriteAttribute("href", " href=\"", 4858, "\"", 4958, 2);
                WriteAttributeValue("", 4865, "/content/customize/codemirror/tomorrow-night-bright.css?v=", 4865, 58, true);
#nullable restore
#line 77 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\EditWebResource.cshtml"
WriteAttributeValue("", 4923, app.PlatformSettings.VersionNumber, 4923, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
            }
            );
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 4998, "\"", 5068, 2);
                WriteAttributeValue("", 5004, "/content/js/jquery.form.js?v=", 5004, 29, true);
#nullable restore
#line 80 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\EditWebResource.cshtml"
WriteAttributeValue("", 5033, app.PlatformSettings.VersionNumber, 5033, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 5092, "\"", 5186, 2);
                WriteAttributeValue("", 5098, "/content/js/jquery-validate/jquery.validate.min.js?v=", 5098, 53, true);
#nullable restore
#line 81 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\EditWebResource.cshtml"
WriteAttributeValue("", 5151, app.PlatformSettings.VersionNumber, 5151, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 5210, "\"", 5313, 2);
                WriteAttributeValue("", 5216, "/content/js/jquery-validate/localization/messages_zh.min.js?v=", 5216, 62, true);
#nullable restore
#line 82 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\EditWebResource.cshtml"
WriteAttributeValue("", 5278, app.PlatformSettings.VersionNumber, 5278, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 5337, "\"", 5424, 2);
                WriteAttributeValue("", 5343, "/content/customize/codemirror/codemirror.js?v=", 5343, 46, true);
#nullable restore
#line 83 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\EditWebResource.cshtml"
WriteAttributeValue("", 5389, app.PlatformSettings.VersionNumber, 5389, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text/javascript\"></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 5471, "\"", 5575, 2);
                WriteAttributeValue("", 5477, "/content/customize/codemirror/addon/selection/active-line.js?v=", 5477, 63, true);
#nullable restore
#line 84 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\EditWebResource.cshtml"
WriteAttributeValue("", 5540, app.PlatformSettings.VersionNumber, 5540, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 5599, "\"", 5694, 2);
                WriteAttributeValue("", 5605, "/content/customize/codemirror/edit/matchbrackets.js?v=", 5605, 54, true);
#nullable restore
#line 85 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\EditWebResource.cshtml"
WriteAttributeValue("", 5659, app.PlatformSettings.VersionNumber, 5659, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 5718, "\"", 5815, 2);
                WriteAttributeValue("", 5724, "/content/customize/codemirror/addon/hint/show-hint.js?v=", 5724, 56, true);
#nullable restore
#line 86 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\EditWebResource.cshtml"
WriteAttributeValue("", 5780, app.PlatformSettings.VersionNumber, 5780, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 5839, "\"", 5942, 2);
                WriteAttributeValue("", 5845, "/content/customize/codemirror/addon/hint/javascript-hint.js?v=", 5845, 62, true);
#nullable restore
#line 87 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\EditWebResource.cshtml"
WriteAttributeValue("", 5907, app.PlatformSettings.VersionNumber, 5907, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 5966, "\"", 6058, 2);
                WriteAttributeValue("", 5972, "/content/customize/codemirror/mode/javascript.js?v=", 5972, 51, true);
#nullable restore
#line 88 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\EditWebResource.cshtml"
WriteAttributeValue("", 6023, app.PlatformSettings.VersionNumber, 6023, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 6082, "\"", 6172, 2);
                WriteAttributeValue("", 6088, "/content/customize/codemirror/mode/markdown.js?v=", 6088, 49, true);
#nullable restore
#line 89 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\EditWebResource.cshtml"
WriteAttributeValue("", 6137, app.PlatformSettings.VersionNumber, 6137, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"></script>
    <script>
        var editor;
        $(function () {
            $('#WebResourceType').picklist({
                items: [{ label: '脚本', value: 'Script' }, { label: '样式', value: 'Css' }, { label: '网页', value: 'Html' }, { label: '图片', value: 'Picture' }]
                , required: true
            });
            //表单验证
            Xms.Web.Form($(""#editform""));

            $('#editform').find('input[name=type]').bind('click', function () {
                var t = $(this).attr('data-value');
                $('div[id^=type-]').addClass('hide');
                $('#type-' + t).removeClass('hide');
            });

            $('#WebResourceType').next().bind('change', function () {
                var t = $(this).val().toLowerCase();
                if (t == 'script') {
                    $('#type-editor').removeClass('hide');
                    $('#type-upload').addClass('hide');
                    $('#editform').find('input[name=type]').removeProp('disabled');
      ");
                WriteLiteral(@"              $('#editform').find('input[name=type]').first().trigger('click');
                }
                else if (t == 'picture') {
                    $('#type-editor').addClass('hide');
                    $('#type-upload').removeClass('hide');
                    $('#editform').find('input[name=type]').last().trigger('click');
                    $('#editform').find('input[name=type]').prop('disabled', 'disabled');
                }
                else if (t == 'html') {
                    $('#type-editor').removeClass('hide');
                    $('#type-upload').addClass('hide');
                    $('#editform').find('input[name=type]').removeProp('disabled');
                    $('#editform').find('input[name=type]').first().trigger('click');
                }
            }).trigger('change');

            $('.contentEditor-fullscreen').on('click', function () {
                $('.contentEditor-wrap').addClass('active');
            })
            $('.contentEditor-clo");
                WriteLiteral(@"se').on('click', function () {
                $('.contentEditor-wrap').removeClass('active');
            })
            var textarea = document.getElementById('Content');
            editor = CodeMirror.fromTextArea(textarea, {
                indentWithTabs: true,
                smartIndent: true,
                lineNumbers: true,
                styleActiveLine: true,
                matchBrackets: true
            });
            editor.setOption(""theme"", ""tomorrow-night-bright"");
            editor.on(""change"", function (editor, changes) {
                $('#Content').val(editor.getValue());
            });
        });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Xms.Web.Customize.Models.EditWebResourceModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
