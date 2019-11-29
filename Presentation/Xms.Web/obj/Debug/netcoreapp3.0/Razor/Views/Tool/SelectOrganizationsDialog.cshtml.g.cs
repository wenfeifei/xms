#pragma checksum "G:\projects\xms_v2\Presentation\Xms.Web\Views\Tool\SelectOrganizationsDialog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fee7fdfa231b4326da1069ac7250c60d9bf0780a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tool_SelectOrganizationsDialog), @"mvc.1.0.view", @"/Views/Tool/SelectOrganizationsDialog.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fee7fdfa231b4326da1069ac7250c60d9bf0780a", @"/Views/Tool/SelectOrganizationsDialog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b0011d9a8909cdacaf42363c4ba3a5683bc0ece", @"/Views/_ViewImports.cshtml")]
    public class Views_Tool_SelectOrganizationsDialog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Xms.Web.Models.OrganizationModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Tool\SelectOrganizationsDialog.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Tool\SelectOrganizationsDialog.cshtml"
  
    DialogModel dialogModel = ViewData["DialogModel"] as DialogModel;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- （Modal） -->
<div class=""modal fade"" id=""orgModal"" tabindex=""-1"" role=""dialog""
     aria-labelledby=""orgModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal""
                        aria-hidden=""true"">
                    ×
                </button>
                <h4 class=""modal-title"" id=""orgModalLabel"">
                    <span class=""glyphicon glyphicon-th""></span> 组织
                </h4>
            </div>
            <div class=""modal-body"">
                <div class=""table-responsive"" id=""gridview"">

                    <table class=""table table-striped table-hover table-condensed"" id=""datatable"" data-ajax=""true"" data-ajaxcontainer=""gridview"" data-ajaxcallback=""ajaxgrid_reset()"" data-sortby=""");
#nullable restore
#line 26 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Tool\SelectOrganizationsDialog.cshtml"
                                                                                                                                                                                              Write(Model.SortBy.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-sortdirection=\"");
#nullable restore
#line 26 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Tool\SelectOrganizationsDialog.cshtml"
                                                                                                                                                                                                                                           Write(Model.SortDirection);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-singlemode=\"");
#nullable restore
#line 26 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Tool\SelectOrganizationsDialog.cshtml"
                                                                                                                                                                                                                                                                                  Write(dialogModel.SingleMode);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                        <thead>
                            <tr>
                                <th width=""2%""><input type=""checkbox"" name=""checkall"" /></th>
                                <th data-name=""name"">
                                    名称
                                </th>
                                <th width=""2%"">
                                    选择
                                </th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 39 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Tool\SelectOrganizationsDialog.cshtml"
                             foreach (var item in Model.Items)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td><input type=\"checkbox\"");
            BeginWriteAttribute("value", " value=\"", 1871, "\"", 1899, 1);
#nullable restore
#line 42 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Tool\SelectOrganizationsDialog.cshtml"
WriteAttributeValue("", 1879, item.OrganizationId, 1879, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"recordid\" /></td>\r\n                                    <td>");
#nullable restore
#line 43 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Tool\SelectOrganizationsDialog.cshtml"
                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                    <td>
                                        <a class=""btn btn-link btn-xs"" onclick=""Xms.Web.SelectingRow(this);OrganizationsModel.dialog_return();""><span class=""glyphicon glyphicon-ok""></span></a>
                                    </td>
                                </tr>
");
#nullable restore
#line 48 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Tool\SelectOrganizationsDialog.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                    <div class=\"panel-footer\">\r\n                        <div class=\"row\">\r\n                            <div class=\"col-sm-4\">");
#nullable restore
#line 53 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Tool\SelectOrganizationsDialog.cshtml"
                                              Write("当前" + @Model.Page + "/" + @Model.TotalPages + "页, 共" + @Model.TotalItems + "行记录");

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <div id=\"page-selection\" class=\"col-sm-8\" data-total=\"");
#nullable restore
#line 54 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Tool\SelectOrganizationsDialog.cshtml"
                                                                             Write(Model.TotalPages);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-page=\"");
#nullable restore
#line 54 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Tool\SelectOrganizationsDialog.cshtml"
                                                                                                           Write(Model.Page);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></div>\r\n                        </div>\r\n                    </div>\r\n                    <script");
            BeginWriteAttribute("src", " src=\"", 2849, "\"", 2926, 2);
            WriteAttributeValue("", 2855, "/content/js/jquery.bootpag.min.js?v=", 2855, 36, true);
#nullable restore
#line 57 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Tool\SelectOrganizationsDialog.cshtml"
WriteAttributeValue("", 2891, app.PlatformSettings.VersionNumber, 2891, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></script>\r\n                    <script");
            BeginWriteAttribute("src", " src=\"", 2966, "\"", 3036, 2);
            WriteAttributeValue("", 2972, "/content/js/jquery.form.js?v=", 2972, 29, true);
#nullable restore
#line 58 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Tool\SelectOrganizationsDialog.cshtml"
WriteAttributeValue("", 3001, app.PlatformSettings.VersionNumber, 3001, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></script>\r\n                    <script>\r\n                        var OrganizationsModel = {\r\n                            dialog: $(\'#orgModal\'),\r\n                            pageUrl : \'");
#nullable restore
#line 62 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Tool\SelectOrganizationsDialog.cshtml"
                                  Write(app.Url);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                            callback : ");
#nullable restore
#line 63 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Tool\SelectOrganizationsDialog.cshtml"
                                  Write(dialogModel.CallBack);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n                            inputid : \'");
#nullable restore
#line 64 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Tool\SelectOrganizationsDialog.cshtml"
                                  Write(dialogModel.InputId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                            ajaxgrid_reset : function () {
                                OrganizationsModel.pag_init();
                                Xms.Web.DataTable($(""#datatable""));
                            },
                            pag_init: function () {
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
                                }).on(""page"", function (event, /* page number here */ num) {
                              ");
            WriteLiteral(@"      event.preventDefault();
                                    var url = $.setUrlParam(OrganizationsModel.pageUrl, 'page', num);
                                    $(""#gridview"").ajaxLoad(url, ""#gridview"", function (response) {
                                        OrganizationsModel.ajaxgrid_reset();
                                    });
                                    return false;
                                });
                            },
                            dialog_return : function () {
                                var result = new Array();
                                $(""#datatable"").find(""input[name=recordid]:checked"").each(function (i, n) {
                                    var obj = new Object();
                                    obj.id = $(n).val();
                                    obj.name = $(n).parent().next().text();
                                    result.push(obj);
                                });
                                var");
            WriteLiteral(@" dialog = $(OrganizationsModel.dialogid);
                                if (dialog.data().OpenDialogCallback) {
                                    dialog.data().OpenDialogCallback(result, OrganizationsModel.inputid,OrganizationsModel)
                                } else {
                                    OrganizationsModel.callback && OrganizationsModel.callback(result,OrganizationsModel.inputid);
                                }
                                $('#orgModal').modal('hide');
                                //Xms.Web.CloseDialog('#orgModal');
                            }
                        };

                        $(function () {
                            OrganizationsModel.ajaxgrid_reset();
                            $('#searchForm').ajaxSearch('#gridview', OrganizationsModel.ajaxgrid_reset);
                            $(""#datatable"").ajaxTable();
                            OrganizationsModel.dialog.modal({
                                backdrop:'stati");
            WriteLiteral(@"c'
                            });
                            OrganizationsModel.dialog.on('hidden.bs.modal', function () {
                                Xms.Web.CloseDialog('#orgModal');
                            });
                        });
                    </script>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-default""
                        data-dismiss=""modal"">
                    <span class=""glyphicon glyphicon-remove""></span> 关闭
                </button>
                <button type=""button"" class=""btn btn-primary"" onclick=""OrganizationsModel.dialog_return()"">
                    <span class=""glyphicon glyphicon-ok""></span> 确定
                </button>
            </div>
        </div><!-- /.modal-content -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Xms.Web.Models.OrganizationModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
