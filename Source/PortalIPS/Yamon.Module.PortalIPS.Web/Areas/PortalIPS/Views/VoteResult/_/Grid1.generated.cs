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
    
    #line 24 "..\..\Areas\PortalIPS\Views\VoteResult\_\Grid1.cshtml"
    using System.Data;
    
    #line default
    #line hidden
    using System.IO;
    using System.Linq;
    using System.Net;
    
    #line 25 "..\..\Areas\PortalIPS\Views\VoteResult\_\Grid1.cshtml"
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/PortalIPS/Views/VoteResult/_/Grid1.cshtml")]
    public partial class _Areas_PortalIPS_Views_VoteResult___Grid1_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_PortalIPS_Views_VoteResult___Grid1_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n\r\n");

            
            #line 3 "..\..\Areas\PortalIPS\Views\VoteResult\_\Grid1.cshtml"
  
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

            
            #line 17 "..\..\Areas\PortalIPS\Views\VoteResult\_\Grid1.cshtml"
Write(RenderPage("~/Areas/PortalIPS/Views/VoteResult/Extend/Model_GridHtml.cshtml"));

            
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

            
            #line 20 "..\..\Areas\PortalIPS\Views\VoteResult\_\Grid1.cshtml"
        
            
            #line default
            #line hidden
            
            #line 20 "..\..\Areas\PortalIPS\Views\VoteResult\_\Grid1.cshtml"
         foreach (ToolBar tool in ViewBag.ToolbarList)
{

            
            #line default
            #line hidden
WriteLiteral("    <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteAttribute("id", Tuple.Create(" id=\"", 713), Tuple.Create("\"", 735)
            
            #line 22 "..\..\Areas\PortalIPS\Views\VoteResult\_\Grid1.cshtml"
, Tuple.Create(Tuple.Create("", 718), Tuple.Create<System.Object, System.Int32>(tool.ToolBarID
            
            #line default
            #line hidden
, 718), false)
);

WriteLiteral(" class=\"easyui-linkbutton\"");

WriteAttribute("iconcls", Tuple.Create(" iconcls=\"", 762), Tuple.Create("\"", 789)
            
            #line 22 "..\..\Areas\PortalIPS\Views\VoteResult\_\Grid1.cshtml"
             , Tuple.Create(Tuple.Create("", 772), Tuple.Create<System.Object, System.Int32>(tool.ClassName
            
            #line default
            #line hidden
, 772), false)
);

WriteLiteral(" plain=\"true\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 803), Tuple.Create("\"", 877)
, Tuple.Create(Tuple.Create("", 813), Tuple.Create("T_", 813), true)
            
            #line 22 "..\..\Areas\PortalIPS\Views\VoteResult\_\Grid1.cshtml"
                                                        , Tuple.Create(Tuple.Create("", 815), Tuple.Create<System.Object, System.Int32>(tool.ToolBarID.Replace("-","")
            
            #line default
            #line hidden
, 815), false)
, Tuple.Create(Tuple.Create("", 848), Tuple.Create("ClickHandler();return", 848), true)
, Tuple.Create(Tuple.Create(" ", 869), Tuple.Create("false;", 870), true)
, Tuple.Create(Tuple.Create(" ", 876), Tuple.Create("", 876), true)
);

WriteLiteral(">");

            
            #line 22 "..\..\Areas\PortalIPS\Views\VoteResult\_\Grid1.cshtml"
                                                                                                                                                                                                  Write(tool.ToolBarName);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 23 "..\..\Areas\PortalIPS\Views\VoteResult\_\Grid1.cshtml"
}

            
            #line default
            #line hidden
DefineSection("scripts_toolbar", () => {

WriteLiteral("\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n");

            
            #line 29 "..\..\Areas\PortalIPS\Views\VoteResult\_\Grid1.cshtml"
    
            
            #line default
            #line hidden
            
            #line 29 "..\..\Areas\PortalIPS\Views\VoteResult\_\Grid1.cshtml"
     foreach (ToolBar tool in ViewBag.ToolbarList)
    {

            
            #line default
            #line hidden
WriteLiteral("    ");

WriteLiteral(" function T_");

            
            #line 31 "..\..\Areas\PortalIPS\Views\VoteResult\_\Grid1.cshtml"
              Write(tool.ToolBarID.Replace("-",""));

            
            #line default
            #line hidden
WriteLiteral("ClickHandler() {\r\n");

WriteLiteral("    ");

WriteLiteral("     ");

            
            #line 32 "..\..\Areas\PortalIPS\Views\VoteResult\_\Grid1.cshtml"
      Write(Html.Raw(tool.OnClick));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

WriteLiteral("     return false;\r\n");

WriteLiteral("    ");

WriteLiteral(" }\r\n");

            
            #line 35 "..\..\Areas\PortalIPS\Views\VoteResult\_\Grid1.cshtml"
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
        var _baseUrl = '/PortalIPS/VoteResult';
var _apiUrl = '/api/PortalIPS/VoteResult';
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
ModelID: 'VoteResult',
PageSize: 20,
DialogWidth: 700,
DialogHeight: 600,
FieldShowType_Name_FieldName: '',
TreeField: '',
FieldShowType_Name_Title: '',
ItemName: ""投票结果"",
PrimaryKey: 'VoteResultID',
SortField: 'VoteResultID',
OrderType: 'asc',
Height: 0,
UnAutoLoadGrid: ");

            
            #line 72 "..\..\Areas\PortalIPS\Views\VoteResult\_\Grid1.cshtml"
            Write(RequestHelper.GetInt("UnAutoLoadGrid"));

            
            #line default
            #line hidden
WriteLiteral(",\r\ncolumns: [[\r\n");

            
            #line 74 "..\..\Areas\PortalIPS\Views\VoteResult\_\Grid1.cshtml"
 foreach (ToolBar tool in ViewBag.ToolbarColumnList)
{
    if(tool.OrderID < 0)
    {

            
            #line default
            #line hidden
WriteLiteral("        ");

WriteLiteral("{field: \'");

            
            #line 78 "..\..\Areas\PortalIPS\Views\VoteResult\_\Grid1.cshtml"
               Write(tool.ToolBarID);

            
            #line default
            #line hidden
WriteLiteral("\', title: \'");

            
            #line 78 "..\..\Areas\PortalIPS\Views\VoteResult\_\Grid1.cshtml"
                                           Write(tool.ToolBarName);

            
            #line default
            #line hidden
WriteLiteral("\', sortable: false,width:");

            
            #line 78 "..\..\Areas\PortalIPS\Views\VoteResult\_\Grid1.cshtml"
                                                                                       Write(tool.ToolBarName.Length*15+10);

            
            #line default
            #line hidden
WriteLiteral(",align:\'center\',formatter: function(value, row, index){\r\n");

WriteLiteral("        ");

WriteLiteral("    ");

            
            #line 79 "..\..\Areas\PortalIPS\Views\VoteResult\_\Grid1.cshtml"
         Write(Html.Raw(tool.OnClick));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

WriteLiteral("}},\r\n");

            
            #line 81 "..\..\Areas\PortalIPS\Views\VoteResult\_\Grid1.cshtml"
    }
}

            
            #line default
            #line hidden
WriteLiteral(@"
{field: 'VoteResultID', title: '结果编号', sortable: true,width:100,align:'left'},
{field: 'VoteID', title: '所属投票主题', sortable: true,width:100,align:'left'},
{field: 'VoteItemID', title: 'VoteItemID', sortable: true,width:100,align:'left'},
{field: 'VoteItem', title: '投票项', sortable: true,width:100,align:'left'},
{field: 'UserID', title: '投票会员编号', sortable: true,width:100,align:'left'},
{field: 'IP', title: '投票IP', sortable: true,width:100,align:'left'},
{field: 'VoteTime', title: '投票时间', sortable: true,width:100,align:'left'},
{field: 'CookieKey', title: 'Cookie', sortable: true,width:100,align:'left'}
");

            
            #line 92 "..\..\Areas\PortalIPS\Views\VoteResult\_\Grid1.cshtml"
 foreach (ToolBar tool in ViewBag.ToolbarColumnList)
{
    if(tool.OrderID >= 0)
    {

            
            #line default
            #line hidden
WriteLiteral(",{field: \'");

            
            #line 96 "..\..\Areas\PortalIPS\Views\VoteResult\_\Grid1.cshtml"
        Write(tool.ToolBarID);

            
            #line default
            #line hidden
WriteLiteral("\', title: \'");

            
            #line 96 "..\..\Areas\PortalIPS\Views\VoteResult\_\Grid1.cshtml"
                                    Write(tool.ToolBarName);

            
            #line default
            #line hidden
WriteLiteral("\', sortable: false,width:");

            
            #line 96 "..\..\Areas\PortalIPS\Views\VoteResult\_\Grid1.cshtml"
                                                                                Write(tool.ToolBarName.Length*15+10);

            
            #line default
            #line hidden
WriteLiteral(",align:\'center\',formatter: function(value, row, index){\r\n");

WriteLiteral("    ");

            
            #line 97 "..\..\Areas\PortalIPS\Views\VoteResult\_\Grid1.cshtml"
 Write(Html.Raw(tool.OnClick));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("}}\r\n");

            
            #line 99 "..\..\Areas\PortalIPS\Views\VoteResult\_\Grid1.cshtml"
    }
}

            
            #line default
            #line hidden
WriteLiteral("]],\r\nfrozenColumns: [\r\n    [\r\n        {\r\n            field: \'ck\',\r\n            ch" +
"eckbox: true\r\n        }\r\n    ]\r\n],\r\ntoolbar: \'#toolbar\',\r\nsingleSelect: ");

            
            #line 111 "..\..\Areas\PortalIPS\Views\VoteResult\_\Grid1.cshtml"
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

            
            #line 119 "..\..\Areas\PortalIPS\Views\VoteResult\_\Grid1.cshtml"
Write(RenderPage("~/Areas/PortalIPS/Views/VoteResult/Extend/Model_GridJs.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

        }
    }
}
#pragma warning restore 1591
