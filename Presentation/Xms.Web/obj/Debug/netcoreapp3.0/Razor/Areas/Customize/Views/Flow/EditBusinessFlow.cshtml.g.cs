#pragma checksum "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Flow\EditBusinessFlow.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88a12df697837daf3668f92e24b158610a719c2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customize_Views_Flow_EditBusinessFlow), @"mvc.1.0.view", @"/Areas/Customize/Views/Flow/EditBusinessFlow.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88a12df697837daf3668f92e24b158610a719c2a", @"/Areas/Customize/Views/Flow/EditBusinessFlow.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b0e0822572318de59551e4c02160fd04d8a0b74", @"/Areas/Customize/Views/_ViewImports.cshtml")]
    public class Areas_Customize_Views_Flow_EditBusinessFlow : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Xms.Web.Customize.Models.EditBusinessFlowModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("editform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"panel panel-default\">\r\n    <div class=\"panel-heading\">\r\n        <h3 class=\"panel-title\">\r\n            <a data-toggle=\"collapse\"\r\n               href=\"#collapseTwo\">\r\n                <strong>");
#nullable restore
#line 8 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Flow\EditBusinessFlow.cshtml"
                   Write(app.PrivilegeTree?.LastOrDefault().DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            </a>\r\n        </h3>\r\n    </div>\r\n    <div id=\"collapseTwo\" class=\"panel-collapse collapse in\">\r\n        <div class=\"panel-body\">\r\n            <div class=\"cntr\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88a12df697837daf3668f92e24b158610a719c2a7157", async() => {
                WriteLiteral("\r\n                    ");
#nullable restore
#line 16 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Flow\EditBusinessFlow.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 17 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Flow\EditBusinessFlow.cshtml"
               Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"StepData\" id=\"StepData\"");
                BeginWriteAttribute("value", " value=\"", 848, "\"", 871, 1);
#nullable restore
#line 18 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Flow\EditBusinessFlow.cshtml"
WriteAttributeValue("", 856, Model.StepData, 856, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input type=\"hidden\" name=\"WorkFlowId\" id=\"WorkFlowId\"");
                BeginWriteAttribute("value", " value=\"", 951, "\"", 976, 1);
#nullable restore
#line 19 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Flow\EditBusinessFlow.cshtml"
WriteAttributeValue("", 959, Model.WorkFlowId, 959, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <div class=\"container-fluid\">\r\n                        <div class=\"form-group col-sm-12\">\r\n                            ");
#nullable restore
#line 22 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Flow\EditBusinessFlow.cshtml"
                       Write(Html.LabelFor(x => x.Name, "名称", new { @class = "col-sm-2 control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            <div class=\"col-sm-10\">\r\n                                ");
#nullable restore
#line 24 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Flow\EditBusinessFlow.cshtml"
                           Write(Html.TextBoxFor(x => x.Name, new { @class = "form-control required" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""form-group col-sm-12"">
                            <label class=""col-sm-2 control-label"">实体</label>
                            <div class=""col-sm-10"">
                                ");
#nullable restore
#line 30 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Flow\EditBusinessFlow.cshtml"
                           Write(Html.HiddenFor(x => x.EntityId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                <select class=\"form-control\" id=\"EntitySel\" data-value=\"");
#nullable restore
#line 31 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Flow\EditBusinessFlow.cshtml"
                                                                                   Write(Model.EntityId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" onchange=\"$(\'#EntityId\').val($(this).val())\" disabled></select>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"form-group col-sm-12\">\r\n                            ");
#nullable restore
#line 35 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Flow\EditBusinessFlow.cshtml"
                       Write(Html.LabelFor(x => x.Description, "描述", new { @class = "col-sm-2 control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            <div class=\"col-sm-10\">\r\n                                ");
#nullable restore
#line 37 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Flow\EditBusinessFlow.cshtml"
                           Write(Html.TextAreaFor(x => x.Description, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </div>
                        </div>
                    </div>

                    <div id=""bussinessWrap"" class=""bussinessWrap"">
                        <ul class=""pcc-tab ul-clr"" id=""entityMenu"" data-bind="" foreach: { data: entityList.list, as: 'item' }"">
                            <li>
                                <i class=""layui-icon layui-icon-right icon-sm-right-arrow"">&#xe602;</i>
                            </li>
                            <li class=""menu-item"" data-bind=""css:{active:item.isShow()}"">
                                <span data-bind=""text:item.entityname(),attr:{'data-id':item.entityid()},click:entityHandle""></span>
                            </li>
                        </ul>
                        <div class=""dropdown add-business-btn "" style=""display: inline;"">
                            <span class=""dropdown-toggle"" data-toggle=""dropdown"">
                                <span class=""addminus-config"">
                        ");
                WriteLiteral(@"            <i class=""glyphicon glyphicon-th-list icon-addminus-config hv addEntityRelationBtn"" id=""addEntityRelationBtn""></i>
                                </span>
                                <span class=""addEntityRelationBtn"">选项</span>
                            </span>
                            <div class=""dropdown-menu add-business-menu"">
                                <ul class=""menu business-list"" id=""entityMenu"" data-bind=""foreach: entityMenulist.list"">
                                    <li>
                                        <a href=""#"" data-bind=""attr:{'data-id':key,'data-name':name},click:addStep""><span data-bind=""text:value,attr:{'data-id':key}""></span></a>
                                    </li>
                                </ul>
                                <div class=""placeRemover"" data-bind=""visible:entityList.isDelete(),click:function(){entityList.remove();entityMenulist.remove();}"">

                                    <i class=""glyphicon glyphicon-trash"">");
                WriteLiteral(@"</i> 删除最后一个实体
                                </div>
                            </div>
                        </div>

                        <div class=""stage-items"" data-bind="" foreach: { data: entityList.list, as: 'litem' }"">
                            <table class=""pcc-tbl wMax"" data-bind=""visible:litem.isShow"">
");
                WriteLiteral(@"                                <tbody>
                                    <tr id=""stepItems"" class=""stepItems"" data-bind=""foreach:{ data: litem.items, as: 'kitem' }"">
                                        <td class=""step-item"" data-bind=""event:{'click':stageHandler},css:{active:kitem.isShow()}"">
                                            <table>
                                                <tr>
                                                    <td width=""13"">
                                                        <i class=""icon-arrow-first""></i>
                                                        <i class=""icon-arrow-white""></i>
                                                    </td>
                                                    <td>
                                                        <div class=""arrow-center"">
                                                            <table>
                                                                <tr>
                        ");
                WriteLiteral(@"                                            <td width=""20"">
                                                                        <a class=""btn btn-link delstageBtn"" data-bind=""click:litem.delStage""><i class=""glyphicon glyphicon-trash ""></i></a>
                                                                    </td>
                                                                    <td>
                                                                        <span data-bind=""text:kitem.name,event:{'mouseenter':nameMouseEnter}""></span>
                                                                        <input type=""text"" class=""c-hide"" name=""step-name"" data-bind=""value:kitem.name,event:{'mouseout':nameMouseOut}"" placeholder=""阶段名称"" />
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                   ");
                WriteLiteral(@"     </div>
                                                    </td>
                                                    <td width=""13"">
                                                        <i class=""icon-arrow-forward""></i>
                                                    </td>
                                                </tr>
                                                <tr class=""step-fields"">
                                                    <td colspan=""3"">
                                                        <table>
                                                            <tr>
                                                                <td colspan=""3"" class=""pos-rt"">
                                                                    <div class=""row stepItems fieldItems"" data-bind=""foreach:{ data: kitem.steps, as: 'step' }"">
                                                                        <div class=""col-sm-4 pb-2"">
                                          ");
                WriteLiteral(@"                                  <div class=""col-sm-4 setW-first control-label"">
                                                                                <table>
                                                                                    <tr>
                                                                                        <td>
                                                                                            <span data-bind=""text:step.displayname(),event:{'mouseenter':nameMouseEnter}""></span>
                                                                                            <input type=""text"" class=""c-hide field-label-input"" name=""step-name"" data-bind=""value:step.displayname(),event:{'mouseout':nameMouseOut}"" />
                                                                                        </td>
                                                                                        <td width=""10"">
                                                       ");
                WriteLiteral(@"                                     <span class=""pull-right "" title=""是否必填"" data-bind=""attr:{'class':step.isrequired?'text-danger':'field-required'},click:function(obj,e){  e = e || window.event;var target = e.target || e.srcElement;$(target).next().click();if($(target).hasClass('field-required')){$(target).removeClass('field-required').addClass('text-danger');}else{$(target).removeClass('text-danger').addClass('field-required');}}"">*</span>
                                                                                            <input class=""hidden"" type=""checkbox"" data-bind=""checked:step.isrequired"" />
                                                                                        </td>
                                                                                    </tr>
                                                                                </table>
                                                                            </div>
                                               ");
                WriteLiteral(@"                             <div class=""col-sm-8"">
                                                                                <table>
                                                                                    <tr>
                                                                                        <td>
                                                                                            <span class=""form-control"" data-bind=""text:step.attrname(),event:{'mouseenter':attrMouseEnter}""></span>
                                                                                            <select class=""attr-selector c-hide form-control"" name=""step-attribute"" data-bind=""
                                                        options:step.options(),
                                                        optionsText: 'optionText' ,
                                                        optionsValue:'optionValue',
                                                        event:{'change':a");
                WriteLiteral("ttrChange,\'mouseout\':attrMouseOut}\r\n                                                        \">\r\n                                                                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88a12df697837daf3668f92e24b158610a719c2a20939", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                                                                            </select>
                                                                                        </td>
                                                                                        <td width=""10""><a class=""delstepBtn"" data-bind=""click:kitem.delStep""><i class=""glyphicon glyphicon-trash ""></i></a></td>
                                                                                    </tr>
                                                                                </table>
                                                                            </div>
                                                                        </div>

                                                                        <div class=""col-sm-4 btn btn-default field-add"" id=""add-step-btn"" data-bind=""click:function(){litem.addStep('','');}"">
                                                                           ");
                WriteLiteral(@" <i class="" glyphicon glyphicon-plus""></i>
                                                                            &nbsp;添加步骤
                                                                        </div>
                                                                    </div>
");
                WriteLiteral(@"                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                        <td class=""step-item-add"">
                                            <div class=""arrow-add"">
                                                <a class=""btn btn-link move-left"" data-bind=""click:litem.moveUp"">
                                                    <i class=""glyphicon glyphicon-arrow-left""></i>
                                                </a>
                                                <a class=""btn btn-link move-right"" data-bind=""click:litem.moveDown"">
                                                    <i class=""glyphicon glyphicon");
                WriteLiteral(@"-arrow-right""></i>
                                                </a>
                                                <a class=""btn btn-link item-add"" id=""add-stage-btn"" data-bind=""click:function(){litem.addItems()}"">
                                                    <i class="" glyphicon glyphicon-plus""></i>
                                                    &nbsp;添加阶段
                                                </a>
                                            </div>
                                        </td>
                                    </tr>
                                </tbody>
");
                WriteLiteral(@"                            </table>
                        </div>
                    </div>
                    <footer class=""footer""></footer>
                    <nav class=""navbar navbar-default navbar-fixed-bottom"" role=""navigation"" id=""body-footer"">
                        <div class=""container"">
                            <div class=""navbar-form navbar-right"" id=""body-footer-content"">
                                <button type=""submit"" class=""btn btn-primary""><span class=""glyphicon glyphicon-saved""></span> 保存</button> <button type=""reset"" class=""btn btn-default""><span class=""glyphicon glyphicon-refresh""></span> 重置</button>
                            </div>
                        </div>
                    </nav>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 6, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 521, "/", 521, 1, true);
#nullable restore
#line 15 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Flow\EditBusinessFlow.cshtml"
AddHtmlAttributeValue("", 522, app.OrganizationUniqueName, 522, 27, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 549, "/customize/", 549, 11, true);
#nullable restore
#line 15 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Flow\EditBusinessFlow.cshtml"
AddHtmlAttributeValue("", 560, app.ControllerName, 560, 19, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 579, "/", 579, 1, true);
#nullable restore
#line 15 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Flow\EditBusinessFlow.cshtml"
AddHtmlAttributeValue("", 580, app.ActionName, 580, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
            DefineSection("Header", async() => {
                WriteLiteral("\r\n        <link");
                BeginWriteAttribute("href", " href=\"", 22593, "\"", 22671, 2);
                WriteAttributeValue("", 22600, "/content/css/businessworkflow.css?v=", 22600, 36, true);
#nullable restore
#line 264 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Flow\EditBusinessFlow.cshtml"
WriteAttributeValue("", 22636, app.PlatformSettings.VersionNumber, 22636, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" />\r\n    ");
            }
            );
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n        <script");
                BeginWriteAttribute("src", " src=\"", 22740, "\"", 22806, 2);
                WriteAttributeValue("", 22746, "/content/js/xms.web.js?v=", 22746, 25, true);
#nullable restore
#line 267 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Flow\EditBusinessFlow.cshtml"
WriteAttributeValue("", 22771, app.PlatformSettings.VersionNumber, 22771, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n        <script");
                BeginWriteAttribute("src", " src=\"", 22834, "\"", 22905, 2);
                WriteAttributeValue("", 22840, "/content/js/xms.metadata.js?v=", 22840, 30, true);
#nullable restore
#line 268 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Flow\EditBusinessFlow.cshtml"
WriteAttributeValue("", 22870, app.PlatformSettings.VersionNumber, 22870, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\r\n        <script");
                BeginWriteAttribute("src", " src=\"", 22935, "\"", 23008, 2);
                WriteAttributeValue("", 22941, "/content/js/knockout-2.2.0.js?v=", 22941, 32, true);
#nullable restore
#line 270 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Flow\EditBusinessFlow.cshtml"
WriteAttributeValue("", 22973, app.PlatformSettings.VersionNumber, 22973, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n        <script>\r\n            var PAGE_TYPE = \'EDIT\';\r\n        </script>\r\n        <script");
                BeginWriteAttribute("src", " src=\"", 23110, "\"", 23185, 2);
                WriteAttributeValue("", 23116, "/content/js/businessworkflow.js?v=", 23116, 34, true);
#nullable restore
#line 274 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Flow\EditBusinessFlow.cshtml"
WriteAttributeValue("", 23150, app.PlatformSettings.VersionNumber, 23150, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Xms.Web.Customize.Models.EditBusinessFlowModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
