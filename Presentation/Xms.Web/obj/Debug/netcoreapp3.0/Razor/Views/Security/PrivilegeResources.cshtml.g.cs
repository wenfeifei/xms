#pragma checksum "G:\projects\xms_v2\Presentation\Xms.Web\Views\Security\PrivilegeResources.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a57945e580aec054f8cdc7b919fe6f6195daec63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Security_PrivilegeResources), @"mvc.1.0.view", @"/Views/Security/PrivilegeResources.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a57945e580aec054f8cdc7b919fe6f6195daec63", @"/Views/Security/PrivilegeResources.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b0011d9a8909cdacaf42363c4ba3a5683bc0ece", @"/Views/_ViewImports.cshtml")]
    public class Views_Security_PrivilegeResources : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Xms.Web.Models.PrivilegeResourceModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("editform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-jsonajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-istip", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-sm-4"">
            <div class=""panel panel-default"">
                <div class=""panel-heading"">
                    <h3 class=""panel-title"">
                        <a data-toggle=""collapse""
                           href=""#collapseOne"">
                            <strong id=""name"">");
#nullable restore
#line 11 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Security\PrivilegeResources.cshtml"
                                         Write(app.T[Model.ResourceName].IfEmpty(Model.ResourceName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong> - <strong>权限控制启用状态</strong>
                        </a>
                    </h3>
                </div>
                <div id=""collapseOne"" class=""panel-collapse collapse in"">
                    <div class=""panel-body"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a57945e580aec054f8cdc7b919fe6f6195daec636789", async() => {
                WriteLiteral("\r\n                            ");
#nullable restore
#line 18 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Security\PrivilegeResources.cshtml"
                       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 19 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Security\PrivilegeResources.cshtml"
                       Write(Html.HiddenFor(x => x.ResourceName));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            <div class=""btn-group"">
                                <button class=""btn btn-default"" type=""button"" data-toggle=""button"" id=""toggleChecked"" data-state=""1"">
                                    <span class=""glyphicon glyphicon-check""></span> ");
#nullable restore
#line 22 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Security\PrivilegeResources.cshtml"
                                                                               Write(app.T["check_all"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" / <span class=\"glyphicon glyphicon-unchecked\"></span> ");
#nullable restore
#line 22 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Security\PrivilegeResources.cshtml"
                                                                                                                                                         Write(app.T["cancel"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </button>\r\n                                <button class=\"btn btn-primary\" type=\"submit\"><span class=\"glyphicon glyphicon-saved\"></span> ");
#nullable restore
#line 24 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Security\PrivilegeResources.cshtml"
                                                                                                                         Write(app.T["save"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n                            </div>\r\n                            <hr />\r\n                            <div");
                BeginWriteAttribute("class", " class=\"", 1723, "\"", 1731, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                <div class=""input-group""><input class=""form-control"" id=""tree_searcher"" /><span class=""input-group-addon""><em class=""glyphicon glyphicon-search""></em></span></div>
                            </div>
                            <div id=""tree1"" class=""text-left"" data-url=""");
#nullable restore
#line 30 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Security\PrivilegeResources.cshtml"
                                                                    Write("/"+app.OrganizationUniqueName);

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Security\PrivilegeResources.cshtml"
                                                                                                    Write(Model.ResourceOwnerDescriptor.ResourceEndpoint);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" style=\"min-height:400px;max-height:400px; overflow:auto; padding:0 5px;\">\r\n                            </div>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 840, "/", 840, 1, true);
#nullable restore
#line 17 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Security\PrivilegeResources.cshtml"
AddHtmlAttributeValue("", 841, app.OrganizationUniqueName, 841, 29, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Security\PrivilegeResources.cshtml"
AddHtmlAttributeValue("", 870, Model.ResourceOwnerDescriptor.PrivilegeStateEndpoint, 870, 53, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
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

        <div class=""col-sm-8"">
            <table class=""table table-hover table-bordered  table-striped table-condensed"">
                <thead>
                    <tr>
                        <th>");
#nullable restore
#line 42 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Security\PrivilegeResources.cshtml"
                       Write(app.T["name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th width=\"30%\">");
#nullable restore
#line 43 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Security\PrivilegeResources.cshtml"
                                   Write(app.T["operation"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
                    </tr>
                </thead>
                <tbody data-bind=""foreach: lines"">
                    <tr>
                        <td>
                            <a href=""#"" data-bind=""click: $root.click""><span data-bind=""text: modulelocalizedname""></span></a>
                        </td>
                        <td>
                            <a class=""btn btn-info btn-xs"" data-bind=""click: $root.click""><span class=""glyphicon glyphicon-cog""></span></a>
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
</div>
");
            DefineSection("Header", async() => {
                WriteLiteral("\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 3308, "\"", 3376, 2);
                WriteAttributeValue("", 3315, "/content/css/jqtree.css?v=", 3315, 26, true);
#nullable restore
#line 61 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Security\PrivilegeResources.cshtml"
WriteAttributeValue("", 3341, app.PlatformSettings.VersionNumber, 3341, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\">\r\n");
            }
            );
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 3431, "\"", 3501, 2);
                WriteAttributeValue("", 3437, "/content/js/xms.utility.js?v=", 3437, 29, true);
#nullable restore
#line 64 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Security\PrivilegeResources.cshtml"
WriteAttributeValue("", 3466, app.PlatformSettings.VersionNumber, 3466, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 3525, "\"", 3595, 2);
                WriteAttributeValue("", 3531, "/content/js/jquery.form.js?v=", 3531, 29, true);
#nullable restore
#line 65 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Security\PrivilegeResources.cshtml"
WriteAttributeValue("", 3560, app.PlatformSettings.VersionNumber, 3560, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 3619, "\"", 3713, 2);
                WriteAttributeValue("", 3625, "/content/js/jquery-validate/jquery.validate.min.js?v=", 3625, 53, true);
#nullable restore
#line 66 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Security\PrivilegeResources.cshtml"
WriteAttributeValue("", 3678, app.PlatformSettings.VersionNumber, 3678, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 3737, "\"", 3803, 2);
                WriteAttributeValue("", 3743, "/content/js/xms.web.js?v=", 3743, 25, true);
#nullable restore
#line 67 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Security\PrivilegeResources.cshtml"
WriteAttributeValue("", 3768, app.PlatformSettings.VersionNumber, 3768, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 3827, "\"", 3896, 2);
                WriteAttributeValue("", 3833, "/content/js/xms.jquery.js?v=", 3833, 28, true);
#nullable restore
#line 68 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Security\PrivilegeResources.cshtml"
WriteAttributeValue("", 3861, app.PlatformSettings.VersionNumber, 3861, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 3920, "\"", 3990, 2);
                WriteAttributeValue("", 3926, "/content/js/tree.jquery.js?v=", 3926, 29, true);
#nullable restore
#line 69 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Security\PrivilegeResources.cshtml"
WriteAttributeValue("", 3955, app.PlatformSettings.VersionNumber, 3955, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 4014, "\"", 4087, 2);
                WriteAttributeValue("", 4020, "/content/js/knockout-2.2.0.js?v=", 4020, 32, true);
#nullable restore
#line 70 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Security\PrivilegeResources.cshtml"
WriteAttributeValue("", 4052, app.PlatformSettings.VersionNumber, 4052, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script>\r\n        var $tree = $(\'#tree1\'), $editform = $(\"#editform\"), resourceEndpoint = \'");
#nullable restore
#line 72 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Security\PrivilegeResources.cshtml"
                                                                             Write("/"+app.OrganizationUniqueName);

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Security\PrivilegeResources.cshtml"
                                                                                                             Write(Model.ResourceOwnerDescriptor.ResourceEndpoint);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
        $(function () {
            Xms.Web.Form($editform, function (response) {
                $('input[value^=""parentid_""]').prop('disabled', false);
              //  Xms.Web.Toast(response.Content,response.IsSuccess);
            }, null, function () {
                    $('input[value^=""parentid_""]').prop('disabled', true)
            });
            $(""#toggleChecked"").click(function () {
                var state = $(this).attr(""data-state"");
                if (state == 1) {
                    $tree.find(""input[type=checkbox]"").prop(""checked"", true);
                    $(this).attr(""data-state"", 0).removeClass(""active"");
                } else {
                    $tree.find(""input[type=checkbox]"").prop(""checked"", false);
                    $(this).attr(""data-state"", 1).addClass(""active"");
                }
            });
            function searchTreeData(e) {
                 var $tree_searcher = $('#tree_searcher'),
                    val = $tree_searcher.val();
  ");
                WriteLiteral(@"              var $tree1 = $('#tree1');
                $tree1.find('>ul>li.jqtree_common').hide();
                $tree1.find('>ul>li.jqtree_common').find('.jqtree-toggler-left').text('►');
                if (val != '') {
                    $tree1.find('.jqtree-title').each(function () {
                        var name = $(this).text();
                        var $li = $(this).parents('li:first');
                        if (name != '' && name.indexOf(val) != -1) {
                          //  $li.show();
                            //if ($li.parents('li:first').is(':hidden')) {
                            $li.parents('li').show().find('.jqtree-toggler-left').text('▼');
                                $li.parents('li').children('ul').show();
                          //  }
                           // $li.parents('li:first')
                        } else {
                           // $li.parents('li:first').find('.jqtree-toggler-left').addClass('jqtree-closed');
                    ");
                WriteLiteral(@"      //  $li.parents('li').show().find('.jqtree-toggler-left').text('►');
                           //  $li.parents('li').hide()
                          //  $li.hide();
                        }
                    });

                } else {
                    $tree1.find('li.jqtree_common').show();
                }

            }
            var debound = $.deboundsEvent(100);
            $('#tree_searcher').on('change', function (e) {
                var self = this;
                //if (e.keyCode == '13') {
                debound(function () {
                    searchTreeData.call(self, e)
                    })
               // }
            }).next().on('click', function (e) {
               var self = this;
                debound(function () {
                    searchTreeData.call(self, e)
                    })
            })

            var treeDatas = [];
            $tree.tree({
                autoOpen: false
                , onTreeFinished: function ");
                WriteLiteral(@"(data, parent_node) {
                    console.log(data, parent_node);
                    var folder = $tree.find('.jqtree-folder');
                    folder.each(function () {
                        var $that = $(this);
                        var list = $that.children('ul');
                        var checkboxs = list.find('input[type=""checkbox""]');
                        var checkeds = list.find('input[type=""checkbox""]:checked');
                        if (checkboxs.length == checkeds.length) {
                            $that.children('.jqtree-element').find('input[type=""checkbox""]').prop('checked', true);
                            $that.children('.jqtree-element').find('a').trigger('click');
                        }
                    });
                }
                , onCreateLi: function (node, $li) {
                    $li.show();
                    var isdisabled = '';
                    if (node.id && node.id.indexOf('parentid') != -1) {
                     ");
                WriteLiteral(@"   isdisabled = 'disabled';
                    }
                    if (treeDatas.length != 1) {
                        $li.find('.jqtree-title').before('<input type=""checkbox"" name=""objectid"" onclick=""setState(this)""  value=""' + node.id+ '"" ' + (node.authorizationenabled ? 'checked' : '') + ' />&nbsp;&nbsp;');
                    } else if (treeDatas.length == 1 && node.children && node.children.length==0) {
                         $li.find('.jqtree-title').before('<span style=""margin-left:10px;"" /><input type=""checkbox"" '+isdisabled+' name=""objectid"" onclick=""setState(this)"" value=""' + node.id + '"" '+(node.authorizationenabled ? 'checked':'')+' />&nbsp;&nbsp;');
                    }

                }
                , selectable: false,
                onCanSelectNode: function (node) {
                    $tree.tree('openNode', node);
                    return true;
                }
                , dataFilter: function (data) {
                    //var ResourceName = $(""#ResourceN");
                WriteLiteral(@"ame"").val();
                    //loadPrivilegeResources(ResourceName);
                    var datas = Xms.Web.GetAjaxResult(data).content;
                    console.log(datas)
                    treeDatas = datas;
                    handlerDatas(datas);
                    return datas;
                }
            });
            var count = 0;
            function handlerDatas(datas) {

                $.each(datas, function (i, n) {
                    if (!n.id) {
                        n.id = 'parentid_' + Xms.Utility.Guid.NewGuid().ToString()
                    }
                    if (n.children && n.children.length > 0) {
                        $.each(n.children, function (ii, nn) {
                            nn._parentid = n.id;
                        });
                        handlerDatas(n.children);
                    }
                    //if (!n.children && count<1) {
                    //    n.children = [{id:'234234234',label:'fdsfdsf'}];
            ");
                WriteLiteral(@"        //    count++;
                    //}
                });
            }
            Xms.Web.GetJson(ORG_SERVERURL + ""/api/security/ResourceOwners"", null, function (data) {
                if (!data) return;
                console.log('data=', data);
                data = Xms.Web.GetAjaxResult(data);
                var result = data.content;
                var Items = function () {
                    var self = this;
                    result = $.grep(result, function (n, i) {
                        n.modulelocalizedname = n.modulelocalizedname || '';
                        return n.statecode == 1;
                    });
                    self.lines = ko.observableArray(result);

                    self.click = function (item) {
                        $(""#ResourceName"").val(item.modulename);
                        $(""#name"").text(item.modulelocalizedname);
                        $tree.data('url', ORG_SERVERURL + item.resourceendpoint);
                        $tree.");
                WriteLiteral(@"tree('reload');
                        loadPrivilegeResources(item.modulename);
                    }
                }
                var _item = new Items();
                console.log(_item);
                ko.applyBindings(_item);
            });
        });

        function loadPrivilegeResources(resourcename) {
            resourcename = resourcename || $(""#ResourceName"").val();

            Xms.Web.GetJson(resourceEndpoint+'?authorizationEnabled=true', null, function (data) {
                if (!data.IsSuccess) return;
                var result = data.content;
                console.info(result);

                if (result.length > 0) {
                    $(result).each(function (i, n) {
                        if (!n.id) {
                            var treeid = Xms.Utility.Guid.EmptyGuid.ToString()
                            n.id = treeid;
                            n.isparent = true;
                        }
                        setLoadedChildrenSelected(n.o");
                WriteLiteral(@"bjectid);
                    });
                }
                else {
                    var node = $tree.tree('getNodeById', Xms.Utility.Guid.EmptyGuid.ToString());
                    if (node) {
                        $tree.tree('openNode', node);
                    }
                }
            });
        }
        function setChildrenSelected(nodeid) {
            var node = $tree.tree('getNodeById', nodeid);
            if (!node) return;
            $(node.element).find(""input[type=checkbox][value="" + nodeid + ""]"").prop(""checked"", true);
            if (node) {
                $tree.tree('openNode', node);
            }
            for (var i = 0; i < node.children.length; i++) {
                var child = node.children[i];
                if (child.children.length > 0) {
                    setChildrenSelected(child.id);
                }

                var childnode = $tree.tree('getNodeById', child.id);
                $(childnode.element).find(""input[type=chec");
                WriteLiteral(@"kbox][value="" + child.id + ""]"").prop(""checked"", true);
                if (childnode) {
                    $tree.tree('openNode', childnode);
                }

            }
        }
        function setLoadedChildrenSelected(nodeid) {
            var node = $tree.tree('getNodeById', nodeid);
            if (!node) return;
            $(node.element).find(""input[type=checkbox][value="" + nodeid + ""]"").prop(""checked"", true);
            if (node) {
                $tree.tree('openNode', node);
            }
            if (node.children.length == 0) {
                var par_ele = $(node.element).parent().siblings("".jqtree-element"");
                if (par_ele.length > 0) {
                    var paridDom = par_ele.find(""input[name='objectid']""), parid = paridDom.val();
                    if (!paridDom.prop(""checked"")) {
                        var parid_treeid = $tree.tree('getNodeById', parid)
                        if (parid_treeid) {
                            $tree.tree('openNo");
                WriteLiteral(@"de', parid_treeid);
                        }
                    }
                }
            }
        }

        function setState(t) {

            var flag = $(t).prop(""checked"");
            var nodeid = $(t).val();
            if (flag) {
                setChildrenSelected(nodeid);
            }
            else {
                var node = $tree.tree('getNodeById', nodeid);
                if (node.children.length > 0) {
                    $(node.element).find(""input[type=checkbox]"").prop(""checked"", false);
                }
            }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Xms.Web.Models.PrivilegeResourceModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
