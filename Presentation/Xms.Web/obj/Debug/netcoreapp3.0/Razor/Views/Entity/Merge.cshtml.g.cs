#pragma checksum "G:\projects\xms_v2\Presentation\Xms.Web\Views\Entity\Merge.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12a809253a3736f89d5fbe98c063cd4fe2126a3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Entity_Merge), @"mvc.1.0.view", @"/Views/Entity/Merge.cshtml")]
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
#nullable restore
#line 1 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Entity\Merge.cshtml"
using Xms.Schema.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12a809253a3736f89d5fbe98c063cd4fe2126a3a", @"/Views/Entity/Merge.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b0011d9a8909cdacaf42363c4ba3a5683bc0ece", @"/Views/_ViewImports.cshtml")]
    public class Views_Entity_Merge : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Xms.Web.Models.MergeModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Entity\Merge.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- （Modal） -->
<div class=""modal fade"" id=""mergeModal"" tabindex=""-1"" role=""dialog""
     aria-labelledby=""mergeModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal""
                        aria-hidden=""true"">
                    ×
                </button>
                <h4 class=""modal-title"" id=""mergeModalLabel"">
                    <span class=""glyphicon glyphicon-user""></span> 合并
                </h4>
            </div>
            <div class=""modal-body"" style=""max-height:400px;overflow:auto;"">
                <div class=""row container-fluid"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12a809253a3736f89d5fbe98c063cd4fe2126a3a5855", async() => {
                WriteLiteral("\r\n                        ");
#nullable restore
#line 24 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Entity\Merge.cshtml"
                   Write(Html.HiddenFor(n => n.EntityId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 25 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Entity\Merge.cshtml"
                   Write(Html.HiddenFor(n => n.RecordId1));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 26 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Entity\Merge.cshtml"
                   Write(Html.HiddenFor(n => n.RecordId2));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <div class=\"form-group col-sm-12\">\r\n                            <span class=\"glyphicon glyphicon-warning-sign\"></span>\r\n                            <span class=\"text-muted\">");
#nullable restore
#line 29 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Entity\Merge.cshtml"
                                                 Write(app.T["security_merge_tip"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                        </div>
                        <table class=""table table-condensed table-bordered table-striped"">
                            <thead>
                                <tr>
                                    <th>主记录</th>
                                    <th>
                                        <label><input type=""radio"" name=""mainrecordid"" class=""merge-firstlist""");
                BeginWriteAttribute("value", " value=\"", 1759, "\"", 1834, 1);
#nullable restore
#line 36 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Entity\Merge.cshtml"
WriteAttributeValue("", 1767, Model.Record1[Model.Attributes.Find(n=>n.TypeIsPrimaryKey()).Name], 1767, 67, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" data-type=\"first\" checked /> ");
#nullable restore
#line 36 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Entity\Merge.cshtml"
                                                                                                                                                                                                                   Write(Model.Record1["name"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
                                        <button class=""btn btn-link checkallBtn"" data-type=""first"">全选</button>
                                    </th>
                                    <th>
                                        <label><input type=""radio"" name=""mainrecordid"" class=""merge-secondlist"" data-type=""second""");
                BeginWriteAttribute("value", " value=\"", 2224, "\"", 2299, 1);
#nullable restore
#line 40 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Entity\Merge.cshtml"
WriteAttributeValue("", 2232, Model.Record2[Model.Attributes.Find(n=>n.TypeIsPrimaryKey()).Name], 2232, 67, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /> ");
#nullable restore
#line 40 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Entity\Merge.cshtml"
                                                                                                                                                                                                             Write(Model.Record2["name"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
                                        <button class=""btn btn-link checkallBtn"" data-type=""second"">全选</button>
                                    </th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 46 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Entity\Merge.cshtml"
                                 foreach (var attr in Model.Attributes)
                                {
                                    if (attr.TypeIsPrimaryKey() || attr.Name.IsCaseInsensitiveEqual("owneridtype") || attr.Name.IsCaseInsensitiveEqual("versionnumber")
                                        || attr.Name.IsCaseInsensitiveEqual("workflowid") || attr.Name.IsCaseInsensitiveEqual("processstate")
                                        || attr.Name.IsCaseInsensitiveEqual("stageid") || attr.Name.IsCaseInsensitiveEqual("modifiedby") || attr.Name.IsCaseInsensitiveEqual("modifiedon"))
                                    {
                                        continue;
                                    }
                                    var displayName = attr.GetNameField();
                                    var disabled = attr.IsSystemControl() ? "disabled" : "";

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 58 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Entity\Merge.cshtml"
                                       Write(attr.LocalizedName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            <label><input type=\"radio\" class=\"merge-firstlist\"");
                BeginWriteAttribute("name", " name=\"", 3854, "\"", 3871, 1);
#nullable restore
#line 61 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Entity\Merge.cshtml"
WriteAttributeValue("", 3861, attr.Name, 3861, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 3872, "\"", 3896, 1);
#nullable restore
#line 61 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Entity\Merge.cshtml"
WriteAttributeValue("", 3880, Model.RecordId1, 3880, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" checked ");
#nullable restore
#line 61 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Entity\Merge.cshtml"
                                                                                                                                             Write(disabled);

#line default
#line hidden
#nullable disable
                WriteLiteral(" /> ");
#nullable restore
#line 61 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Entity\Merge.cshtml"
                                                                                                                                                          Write(Model.Record1[displayName]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                                        </td>\r\n                                        <td>\r\n                                            <label><input type=\"radio\" class=\"merge-secondlist\"");
                BeginWriteAttribute("name", " name=\"", 4144, "\"", 4161, 1);
#nullable restore
#line 64 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Entity\Merge.cshtml"
WriteAttributeValue("", 4151, attr.Name, 4151, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 4162, "\"", 4186, 1);
#nullable restore
#line 64 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Entity\Merge.cshtml"
WriteAttributeValue("", 4170, Model.RecordId2, 4170, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" ");
#nullable restore
#line 64 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Entity\Merge.cshtml"
                                                                                                                                      Write(disabled);

#line default
#line hidden
#nullable disable
                WriteLiteral(" /> ");
#nullable restore
#line 64 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Entity\Merge.cshtml"
                                                                                                                                                   Write(Model.Record2[displayName]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 67 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Entity\Merge.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </tbody>\r\n                        </table>\r\n                        <div class=\"form-group col-sm-12 hide\">\r\n                            <label><input type=\"radio\"");
                BeginWriteAttribute("name", " name=\"", 4554, "\"", 4561, 0);
                EndWriteAttribute();
                WriteLiteral(" value=\"1\" checked /></label>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 883, "/", 883, 1, true);
#nullable restore
#line 23 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Entity\Merge.cshtml"
AddHtmlAttributeValue("", 884, app.OrganizationUniqueName, 884, 29, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 913, "/api/data/merge", 913, 15, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <script");
            BeginWriteAttribute("src", " src=\"", 4701, "\"", 4771, 2);
            WriteAttributeValue("", 4707, "/content/js/jquery.form.js?v=", 4707, 29, true);
#nullable restore
#line 75 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Entity\Merge.cshtml"
WriteAttributeValue("", 4736, app.PlatformSettings.VersionNumber, 4736, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></script>\r\n                <script>\r\n                    //");
            WriteLiteral("@ sourceUrl = merge.js\r\n                    var mergeModel = {\r\n                        dialog: $(\'#mergeModal\'),\r\n                        dialogid: \'mergeModal\',\r\n                        entityid: \'");
#nullable restore
#line 81 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Entity\Merge.cshtml"
                              Write(Model.EntityId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                        submit: function () {
                            mergeModel.dialog.find('form').submit();
                        },
                        dialog_return: function () {
                            mergeModel.dialog.modal('hide');
                        },
                        bindselected: function (result, inputid) {
                            console.log(result);
                            if (!result || result.length == 0) return;
                            mergeModel.dialog.find('#ownerid').val(result[0].name);
                            mergeModel.dialog.find('input[name=ownerid]').val(result[0].id);
                            var target = [];
                            $(result).each(function (i, n) {
                                target.push(n.id);
                            });
                            console.log(target);
                        }
                    };
                    $(function () {
                        mergeMo");
            WriteLiteral(@"del.dialog.modal({
                            //backdrop: 'static'
                        });
                        mergeModel.dialog.on('hidden.bs.modal', function () {
                            Xms.Web.CloseDialog(mergeModel.dialogid);
                        });
                        mergeModel.dialog.find('form').ajaxForm(function (response) {
                            if (response.IsSuccess) {
                                Xms.Web.Alert(true, response.Content, function () {
                                    mergeModel.dialog_return();
                                    location.reload(true);
                                }, function () {
                                    mergeModel.dialog_return();
                                    location.reload(true);
                                });
                                return;
                            }
                            Xms.Web.Alert(false, response.Content);
                        });

          ");
            WriteLiteral(@"              function checkChange(e) {
                            e = e || window.event;
                            if (e.preventDefault) {
                                e.preventDefault();
                            } else if (e.returnValue) {
                                e.returnValue = false;
                            }
                            var target = e.target || e.srcElement;
                            var $this = $(target);
                            var type = $this.attr('data-type');
                            if (type == 'first') {
                                $('input.merge-firstlist:not(:disabled)').prop('checked', true);
                            } else if (type == 'second') {
                                $('input.merge-secondlist:not(:disabled)').prop('checked', true);
                            }
                        }

                        mergeModel.dialog.find('button.checkallBtn').on('click', function (e) {
                            ch");
            WriteLiteral(@"eckChange(e);
                        });
                        mergeModel.dialog.find('input[name=""mainrecordid""]').on('change', function (e) {
                            checkChange(e);
                        });
                    });
                </script>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-default""
                        data-dismiss=""modal"">
                    <span class=""glyphicon glyphicon-remove""></span>
                    ");
#nullable restore
#line 151 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Entity\Merge.cshtml"
               Write(app.T["dialog_close"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </button>\r\n                <button type=\"button\" class=\"btn btn-primary\" onclick=\"mergeModel.submit()\">\r\n                    <span class=\"glyphicon glyphicon-ok\"></span>\r\n                    ");
#nullable restore
#line 155 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Entity\Merge.cshtml"
               Write(app.T["dialog_ok"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </button>\r\n            </div>\r\n        </div><!-- /.modal-content -->\r\n    </div><!-- /.modal-dialog -->\r\n</div><!-- /.modal -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Xms.Web.Models.MergeModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
