#pragma checksum "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Dependency\DependentComponents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f29f220cc87ffcf5e1305d0cd9a8ab327b13aff6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customize_Views_Dependency_DependentComponents), @"mvc.1.0.view", @"/Areas/Customize/Views/Dependency/DependentComponents.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f29f220cc87ffcf5e1305d0cd9a8ab327b13aff6", @"/Areas/Customize/Views/Dependency/DependentComponents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b0e0822572318de59551e4c02160fd04d8a0b74", @"/Areas/Customize/Views/_ViewImports.cshtml")]
    public class Areas_Customize_Views_Dependency_DependentComponents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Xms.Web.Customize.Models.DependentComponentsModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Dependency\DependentComponents.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--（Modal） -->
<div class=""modal fade"" id=""actionsModal"" tabindex=""-1"" role=""dialog""
     aria-labelledby=""actionsModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal""
                        aria-hidden=""true"">
                    ×
                </button>
                <h4 class=""modal-title"" id=""actionsModalLabel"">
                    <span class=""glyphicon glyphicon-th""></span> ");
#nullable restore
#line 17 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Dependency\DependentComponents.cshtml"
                                                            Write(app.T["referenced"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </h4>
            </div>
            <div class=""modal-body"">

                <div class=""panel panel-default"" id=""gridview"">
                    <div class=""table-responsive"">
                        <table class=""table table-hover table-striped table-condensed datatable"" id=""datatable"" data-refresh=""rebind()"" data-ajax=""true"" data-ajaxcontainer=""gridview"" data-ajaxcallback=""ajaxgrid_reset()"" data-sortby=""");
#nullable restore
#line 24 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Dependency\DependentComponents.cshtml"
                                                                                                                                                                                                                                    Write(Model.SortBy.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-sortdirection=\"");
#nullable restore
#line 24 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Dependency\DependentComponents.cshtml"
                                                                                                                                                                                                                                                                                 Write(Model.SortDirection);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-pageurl=\"");
#nullable restore
#line 24 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Dependency\DependentComponents.cshtml"
                                                                                                                                                                                                                                                                                                                     Write(app.Url);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                            <thead>
                                <tr>
                                    <th width=""20%"" data-name=""ComponentType"">
                                        类型
                                    </th>
                                    <th data-name=""name"">
                                        名称
                                    </th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 36 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Dependency\DependentComponents.cshtml"
                                 foreach (var item in Model.Items)
                                {
                                    var m = Xms.Module.Core.ModuleCollection.Descriptors.Values.FirstOrDefault(x => x.Identity == item.ComponentType);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 40 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Dependency\DependentComponents.cshtml"
                                       Write(m.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 41 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Dependency\DependentComponents.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 43 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Dependency\DependentComponents.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-default""
                        data-dismiss=""modal"">
                    <span class=""glyphicon glyphicon-remove""></span>
                    ");
#nullable restore
#line 53 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Dependency\DependentComponents.cshtml"
               Write(app.T["dialog_close"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </button>\r\n                <button type=\"button\" class=\"btn btn-primary\" onclick=\"ActionsModel.dialog_return()\">\r\n                    <span class=\"glyphicon glyphicon-ok\"></span>\r\n                    ");
#nullable restore
#line 57 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Dependency\DependentComponents.cshtml"
               Write(app.T["dialog_ok"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </button>\r\n            </div>\r\n        </div><!-- /.modal-content -->\r\n        <script");
            BeginWriteAttribute("src", " src=\"", 2936, "\"", 3013, 2);
            WriteAttributeValue("", 2942, "/content/js/jquery.bootpag.min.js?v=", 2942, 36, true);
#nullable restore
#line 61 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Dependency\DependentComponents.cshtml"
WriteAttributeValue("", 2978, app.PlatformSettings.VersionNumber, 2978, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></script>\r\n        <script");
            BeginWriteAttribute("src", " src=\"", 3041, "\"", 3111, 2);
            WriteAttributeValue("", 3047, "/content/js/jquery.form.js?v=", 3047, 29, true);
#nullable restore
#line 62 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Dependency\DependentComponents.cshtml"
WriteAttributeValue("", 3076, app.PlatformSettings.VersionNumber, 3076, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></script>\r\n        <script>\r\n                        var ActionsModel = {\r\n                            pageUrl : \'");
#nullable restore
#line 65 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\Dependency\DependentComponents.cshtml"
                                  Write(app.Url);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                            dialog : $('#actionsModal'),
                            ajaxgrid_reset : function () {
                                ActionsModel.pag_init();
                                Xms.Web.DataTable($(""#datatable""));
                            },
                            pag_init : function () {
                                $('#page-selection').bootpag({
                                    total: $('#page-selection').attr('data-total')
                                    , maxVisible: 5
                                    , page: $('#page-selection').attr('data-page')
                                    , leaps: false
                                    , prev: '&lsaquo;'
                                    , next: '&rsaquo;'
                                    , firstLastUse: true
                                    , first: '&laquo;'
                                    , last: '&raquo;'
                                }).on(""page"", function (event, /* page ");
            WriteLiteral(@"number here */ num) {
                                    event.preventDefault();
                                    var url = $.setUrlParam(ActionsModel.pageUrl, 'page', num);
                                    $(""#gridview"").ajaxLoad(url, ""#gridview"", function (response) {
                                        ActionsModel.ajaxgrid_reset();
                                    });
                                    return false;
                                });
                            },
                            dialog_return: function () {
                                console.log(1111111);
                                ActionsModel.dialog.modal('hide');
                            }
                        };

                        $(function () {
                            ActionsModel.ajaxgrid_reset();
                            $(""#datatable"").ajaxTable();
                            ActionsModel.dialog.modal({
                                backdrop:'static'
");
            WriteLiteral(@"                            });
                            ActionsModel.dialog.on('hidden.bs.modal', function () {
                               // Xms.Web.CloseDialog('#actionsModal');//删除字段时会删掉列表内容
                            });
                        });
        </script>
    </div><!-- /.modal-dialog -->
</div><!-- /.modal -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Xms.Web.Customize.Models.DependentComponentsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
