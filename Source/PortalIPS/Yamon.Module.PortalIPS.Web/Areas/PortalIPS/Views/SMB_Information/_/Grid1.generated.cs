﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    
    #line 24 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Grid1.cshtml"
    using System.Data;
    
    #line default
    #line hidden
    using System.IO;
    using System.Linq;
    using System.Net;
    
    #line 25 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Grid1.cshtml"
    using System.Text;
    
    #line default
    #line hidden
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Yamon.Framework.Common;
    using Yamon.Module.PortalIPS;
    using Yamon.Module.SiteManage.Entity;
    using Yamon.Module.UCenter;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/PortalIPS/Views/SMB_Information/_/Grid1.cshtml")]
    public partial class _Areas_PortalIPS_Views_SMB_Information___Grid1_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_PortalIPS_Views_SMB_Information___Grid1_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n\r\n");

            
            #line 3 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Grid1.cshtml"
  
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由亚萌智能表单代码生成工具生成。
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。除非此项目不再使用代码生成器生成。
//     如果想修改此文件的内容，请复制一份到此文件的上级目录进行修改
//
//     如有问题联系zongeasy@qq.com
//</auto-generated>
//------------------------------------------------------------------------------

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" id=\"tt\"");

WriteLiteral("></div>\r\n");

            
            #line 17 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Grid1.cshtml"
Write(RenderPage("~/Areas/PortalIPS/Views/SMB_Information/Extend/Model_GridHtml.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" id=\"toolbar\"");

WriteLiteral(" style=\"padding: 5px; height: auto\"");

WriteLiteral(">\r\n    <form");

WriteLiteral(" id=\"searchForm\"");

WriteLiteral(" name=\"searchForm\"");

WriteLiteral(" action=\"\"");

WriteLiteral(" method=\"post\"");

WriteLiteral(">\r\n");

            
            #line 20 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Grid1.cshtml"
        
            
            #line default
            #line hidden
            
            #line 20 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Grid1.cshtml"
         foreach (ToolBar tool in ViewBag.ToolbarList)
{

            
            #line default
            #line hidden
WriteLiteral("    <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteAttribute("id", Tuple.Create(" id=\"", 718), Tuple.Create("\"", 740)
            
            #line 22 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Grid1.cshtml"
, Tuple.Create(Tuple.Create("", 723), Tuple.Create<System.Object, System.Int32>(tool.ToolBarID
            
            #line default
            #line hidden
, 723), false)
);

WriteLiteral(" class=\"easyui-linkbutton\"");

WriteAttribute("iconcls", Tuple.Create(" iconcls=\"", 767), Tuple.Create("\"", 794)
            
            #line 22 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Grid1.cshtml"
             , Tuple.Create(Tuple.Create("", 777), Tuple.Create<System.Object, System.Int32>(tool.ClassName
            
            #line default
            #line hidden
, 777), false)
);

WriteLiteral(" plain=\"true\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 808), Tuple.Create("\"", 882)
, Tuple.Create(Tuple.Create("", 818), Tuple.Create("T_", 818), true)
            
            #line 22 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Grid1.cshtml"
                                                        , Tuple.Create(Tuple.Create("", 820), Tuple.Create<System.Object, System.Int32>(tool.ToolBarID.Replace("-","")
            
            #line default
            #line hidden
, 820), false)
, Tuple.Create(Tuple.Create("", 853), Tuple.Create("ClickHandler();return", 853), true)
, Tuple.Create(Tuple.Create(" ", 874), Tuple.Create("false;", 875), true)
, Tuple.Create(Tuple.Create(" ", 881), Tuple.Create("", 881), true)
);

WriteLiteral(">");

            
            #line 22 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Grid1.cshtml"
                                                                                                                                                                                                  Write(tool.ToolBarName);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 23 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Grid1.cshtml"
}

            
            #line default
            #line hidden
DefineSection("scripts_toolbar", () => {

WriteLiteral("\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n");

            
            #line 29 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Grid1.cshtml"
    
            
            #line default
            #line hidden
            
            #line 29 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Grid1.cshtml"
     foreach (ToolBar tool in ViewBag.ToolbarList)
    {

            
            #line default
            #line hidden
WriteLiteral("    ");

WriteLiteral(" function T_");

            
            #line 31 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Grid1.cshtml"
              Write(tool.ToolBarID.Replace("-",""));

            
            #line default
            #line hidden
WriteLiteral("ClickHandler() {\r\n");

WriteLiteral("    ");

WriteLiteral("     ");

            
            #line 32 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Grid1.cshtml"
      Write(Html.Raw(tool.OnClick));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

WriteLiteral("     return false;\r\n");

WriteLiteral("    ");

WriteLiteral(" }\r\n");

            
            #line 35 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Grid1.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</script>\r\n");

});

WriteLiteral("\r\n        \r\n    </form>\r\n</div>\r\n<div");

WriteLiteral(" id=\"PagerButtons\"");

WriteLiteral("><label><input");

WriteLiteral(" id=\"BatchCheck\"");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" />多选</label></div>\r\n");

DefineSection("scripts", () => {

WriteLiteral("\r\n\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
        var _baseUrl = '/PortalIPS/SMB_Information';
var _apiUrl = '/api/PortalIPS/SMB_Information';
var _pageUrl = '';
var Data = {
BaseUrl: _baseUrl,
ApiUrl: _apiUrl,
FilterID: '',
DataUrl: _apiUrl + '/Grid1?'+_pageUrl,
CreateUrl: _baseUrl + '/Create?'+_pageUrl,
EditUrl: _baseUrl + '/Edit/{id}?'+_pageUrl,
ShowUrl: _baseUrl + '/Show/',
BatchDeleteUrl: _apiUrl + '/BatchDelete?'+_pageUrl,
DeleteUrl: _apiUrl + '/Delete?'+_pageUrl,
ModuleID: 'PortalIPS',
ModelID: 'SMB_Information',
PageSize: 20,
DialogWidth: 700,
DialogHeight: 600,
FieldShowType_Name_FieldName: '',
TreeField: '',
FieldShowType_Name_Title: '',
ItemName: ""信息内容"",
PrimaryKey: 'InfoGuid',
SortField: 'CreateTime',
OrderType: 'asc',
Height: 0,
UnAutoLoadGrid: ");

            
            #line 72 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Grid1.cshtml"
            Write(RequestHelper.GetInt("UnAutoLoadGrid"));

            
            #line default
            #line hidden
WriteLiteral(",\r\ncolumns: [[\r\n");

            
            #line 74 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Grid1.cshtml"
 foreach (ToolBar tool in ViewBag.ToolbarColumnList)
{
    if(tool.OrderID < 0)
    {

            
            #line default
            #line hidden
WriteLiteral("        ");

WriteLiteral("{field: \'");

            
            #line 78 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Grid1.cshtml"
               Write(tool.ToolBarID);

            
            #line default
            #line hidden
WriteLiteral("\', title: \'");

            
            #line 78 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Grid1.cshtml"
                                           Write(tool.ToolBarName);

            
            #line default
            #line hidden
WriteLiteral("\', sortable: false,width:");

            
            #line 78 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Grid1.cshtml"
                                                                                       Write(tool.ToolBarName.Length*15+10);

            
            #line default
            #line hidden
WriteLiteral(",align:\'center\',formatter: function(value, row, index){\r\n");

WriteLiteral("        ");

WriteLiteral("    ");

            
            #line 79 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Grid1.cshtml"
         Write(Html.Raw(tool.OnClick));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

WriteLiteral("}},\r\n");

            
            #line 81 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Grid1.cshtml"
    }
}

            
            #line default
            #line hidden
WriteLiteral("\r\n{field: \'InfoGuid\', title: \'信息编号\', sortable: true,width:100,hidden:true,align:\'" +
"left\'},\r\n{field: \'Title\', title: \'标题\', sortable: true,width:100,align:\'left\'},\r\n" +
"{field: \'SubTitle\', title: \'副标题\', sortable: true,width:100,align:\'left\'},\r\n{fiel" +
"d: \'Author\', title: \'讲者\', sortable: true,width:100,align:\'left\'},\r\n{field: \'Sour" +
"ce\', title: \'信息来源\', sortable: true,width:100,align:\'left\'},\r\n{field: \'SourceUrl\'" +
", title: \'信息来源链接\', sortable: true,width:100,align:\'left\'},\r\n{field: \'Keywords\', " +
"title: \'关键字\', sortable: true,width:100,align:\'left\'},\r\n{field: \'Description\', ti" +
"tle: \'经文\', sortable: true,width:100,align:\'left\',formatter: function(value, row," +
" index){if(value){return \'<div title=\"\'+value+\'\">\'+value+\'</div>\';}}},\r\n{field: " +
"\'Content\', title: \'内容\', sortable: true,width:100,align:\'left\'},\r\n{field: \'Conten" +
"tNoHTML\', title: \'内容\', sortable: true,width:100,align:\'left\'},\r\n{field: \'MediaFi" +
"leName\', title: \'首页图片\', sortable: true,width:100,align:\'left\'},\r\n{field: \'InfoTy" +
"pe_ShowValue\', title: \'信息类型\', sortable: true,width:100,align:\'left\'},\r\n{field: \'" +
"Creator\', title: \'发布人用户名\', sortable: true,width:100,align:\'left\'},\r\n{field: \'Cre" +
"atorName\', title: \'发布人\', sortable: true,width:100,align:\'left\'},\r\n{field: \'Creat" +
"eTime\', title: \'发布时间\', sortable: true,width:100,align:\'left\'},\r\n{field: \'GroupID" +
"\', title: \'部门编号\', sortable: true,width:100,align:\'left\'},\r\n{field: \'GroupName\', " +
"title: \'发布部门\', sortable: true,width:100,align:\'left\'},\r\n{field: \'LastModifier\', " +
"title: \'最后编辑人用户名\', sortable: true,width:100,align:\'left\'},\r\n{field: \'LastModifie" +
"rName\', title: \'最后编辑人\', sortable: true,width:100,align:\'left\'},\r\n{field: \'LastMo" +
"difyTime\', title: \'最后编辑时间\', sortable: true,width:100,align:\'left\'},\r\n{field: \'Au" +
"ditor\', title: \'审核人编号\', sortable: true,width:100,align:\'left\'},\r\n{field: \'Audito" +
"rName\', title: \'审核人\', sortable: true,width:100,align:\'left\'},\r\n{field: \'AuditTim" +
"e\', title: \'审核时间\', sortable: true,width:100,align:\'left\'},\r\n{field: \'ShowTime_Sh" +
"owValue\', title: \'显示日期\', sortable: true,width:100,align:\'left\'},\r\n{field: \'Statu" +
"s_ShowValue\', title: \'状态\', sortable: true,width:100,align:\'left\'},\r\n{field: \'Vie" +
"wCount\', title: \'点击次数\', sortable: true,width:100,align:\'left\'},\r\n{field: \'SendTo" +
"UserNames\', title: \'SendToUserNames\', sortable: true,width:100,align:\'left\'},\r\n{" +
"field: \'SendToGroupNames\', title: \'SendToGroupNames\', sortable: true,width:100,a" +
"lign:\'left\'},\r\n{field: \'BackBoolean\', title: \'是否有效\', sortable: true,width:100,al" +
"ign:\'left\'},\r\n{field: \'BackBoolean1_ShowValue\', title: \'突出显示\', sortable: true,wi" +
"dth:100,align:\'left\'},\r\n{field: \'BackNvarchar\', title: \'BackNvarchar\', sortable:" +
" true,width:100,align:\'left\'},\r\n{field: \'BackNvarchar1\', title: \'BackNvarchar1\'," +
" sortable: true,width:100,align:\'left\'},\r\n{field: \'BackNvarchar3\', title: \'索引号\'," +
" sortable: true,width:100,align:\'left\'},\r\n{field: \'BackInt\', title: \'排序号\', sorta" +
"ble: true,width:100,align:\'left\'},\r\n{field: \'BackInt1\', title: \'BackInt1\', sorta" +
"ble: true,width:100,align:\'left\'},\r\n{field: \'BackInt2\', title: \'BackInt2\', sorta" +
"ble: true,width:100,align:\'left\'},\r\n{field: \'BackInt3_ShowValue\', title: \'是否列表显示" +
"\', sortable: true,width:100,align:\'left\'},\r\n{field: \'IconName\', title: \'IconName" +
"\', sortable: true,width:100,align:\'left\'},\r\n{field: \'PageName\', title: \'页面名称\', s" +
"ortable: true,width:100,align:\'left\'},\r\n{field: \'TalkGuid\', title: \'TalkGuid\', s" +
"ortable: true,width:100,align:\'left\'},\r\n{field: \'VideoUrl\', title: \'视频音频地址\', sor" +
"table: true,width:100,align:\'left\'},\r\n{field: \'AppID\', title: \'AppID\', sortable:" +
" true,width:100,align:\'left\'}\r\n");

            
            #line 126 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Grid1.cshtml"
 foreach (ToolBar tool in ViewBag.ToolbarColumnList)
{
    if(tool.OrderID >= 0)
    {

            
            #line default
            #line hidden
WriteLiteral(",{field: \'");

            
            #line 130 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Grid1.cshtml"
        Write(tool.ToolBarID);

            
            #line default
            #line hidden
WriteLiteral("\', title: \'");

            
            #line 130 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Grid1.cshtml"
                                    Write(tool.ToolBarName);

            
            #line default
            #line hidden
WriteLiteral("\', sortable: false,width:");

            
            #line 130 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Grid1.cshtml"
                                                                                Write(tool.ToolBarName.Length*15+10);

            
            #line default
            #line hidden
WriteLiteral(",align:\'center\',formatter: function(value, row, index){\r\n");

WriteLiteral("    ");

            
            #line 131 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Grid1.cshtml"
 Write(Html.Raw(tool.OnClick));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("}}\r\n");

            
            #line 133 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Grid1.cshtml"
    }
}

            
            #line default
            #line hidden
WriteLiteral("]],\r\nfrozenColumns: [\r\n    [\r\n        {\r\n            field: \'ck\',\r\n            ch" +
"eckbox: true\r\n        }\r\n    ]\r\n],\r\ntoolbar: \'#toolbar\',\r\nsingleSelect: ");

            
            #line 145 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Grid1.cshtml"
          Write(RequestHelper.GetBool("SingleSelect",true).ToString().ToLower());

            
            #line default
            #line hidden
WriteLiteral("\r\n}\r\n    </script>\r\n    <script");

WriteLiteral(" src=\"/Resources/JsLib/jquery.query.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/Resources/JsLib/jquery.form.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/Static/v1/js/GridUtils.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/Static/v1/js/SmartFormGrid.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/Static/v1/js/Grid.js\"");

WriteLiteral("></script>\r\n");

            
            #line 153 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Grid1.cshtml"
Write(RenderPage("~/Areas/PortalIPS/Views/SMB_Information/Extend/Model_GridJs.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

        }
    }
}
#pragma warning restore 1591