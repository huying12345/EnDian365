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
    
    #line 23 "..\..\Areas\PortalIPS\Views\Category\_\EditGrid.cshtml"
    using System.Data;
    
    #line default
    #line hidden
    using System.IO;
    using System.Linq;
    using System.Net;
    
    #line 24 "..\..\Areas\PortalIPS\Views\Category\_\EditGrid.cshtml"
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/PortalIPS/Views/Category/_/EditGrid.cshtml")]
    public partial class _Areas_PortalIPS_Views_Category___EditGrid_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_PortalIPS_Views_Category___EditGrid_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 2 "..\..\Areas\PortalIPS\Views\Category\_\EditGrid.cshtml"
  
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

            
            #line 16 "..\..\Areas\PortalIPS\Views\Category\_\EditGrid.cshtml"
Write(RenderPage("~/Areas/PortalIPS/Views/Category/Extend/Model_GridHtml.cshtml"));

            
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

            
            #line 19 "..\..\Areas\PortalIPS\Views\Category\_\EditGrid.cshtml"
        
            
            #line default
            #line hidden
            
            #line 19 "..\..\Areas\PortalIPS\Views\Category\_\EditGrid.cshtml"
         foreach (ToolBar tool in ViewBag.ToolbarList)
{

            
            #line default
            #line hidden
WriteLiteral("    <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteAttribute("id", Tuple.Create(" id=\"", 709), Tuple.Create("\"", 731)
            
            #line 21 "..\..\Areas\PortalIPS\Views\Category\_\EditGrid.cshtml"
, Tuple.Create(Tuple.Create("", 714), Tuple.Create<System.Object, System.Int32>(tool.ToolBarID
            
            #line default
            #line hidden
, 714), false)
);

WriteLiteral(" class=\"easyui-linkbutton\"");

WriteAttribute("iconcls", Tuple.Create(" iconcls=\"", 758), Tuple.Create("\"", 785)
            
            #line 21 "..\..\Areas\PortalIPS\Views\Category\_\EditGrid.cshtml"
             , Tuple.Create(Tuple.Create("", 768), Tuple.Create<System.Object, System.Int32>(tool.ClassName
            
            #line default
            #line hidden
, 768), false)
);

WriteLiteral(" plain=\"true\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 799), Tuple.Create("\"", 873)
, Tuple.Create(Tuple.Create("", 809), Tuple.Create("T_", 809), true)
            
            #line 21 "..\..\Areas\PortalIPS\Views\Category\_\EditGrid.cshtml"
                                                        , Tuple.Create(Tuple.Create("", 811), Tuple.Create<System.Object, System.Int32>(tool.ToolBarID.Replace("-","")
            
            #line default
            #line hidden
, 811), false)
, Tuple.Create(Tuple.Create("", 844), Tuple.Create("ClickHandler();return", 844), true)
, Tuple.Create(Tuple.Create(" ", 865), Tuple.Create("false;", 866), true)
, Tuple.Create(Tuple.Create(" ", 872), Tuple.Create("", 872), true)
);

WriteLiteral(">");

            
            #line 21 "..\..\Areas\PortalIPS\Views\Category\_\EditGrid.cshtml"
                                                                                                                                                                                                  Write(tool.ToolBarName);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 22 "..\..\Areas\PortalIPS\Views\Category\_\EditGrid.cshtml"
}

            
            #line default
            #line hidden
DefineSection("scripts_toolbar", () => {

WriteLiteral("\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n");

            
            #line 28 "..\..\Areas\PortalIPS\Views\Category\_\EditGrid.cshtml"
    
            
            #line default
            #line hidden
            
            #line 28 "..\..\Areas\PortalIPS\Views\Category\_\EditGrid.cshtml"
     foreach (ToolBar tool in ViewBag.ToolbarList)
    {

            
            #line default
            #line hidden
WriteLiteral("    ");

WriteLiteral(" function T_");

            
            #line 30 "..\..\Areas\PortalIPS\Views\Category\_\EditGrid.cshtml"
              Write(tool.ToolBarID.Replace("-",""));

            
            #line default
            #line hidden
WriteLiteral("ClickHandler() {\r\n");

WriteLiteral("    ");

WriteLiteral("     ");

            
            #line 31 "..\..\Areas\PortalIPS\Views\Category\_\EditGrid.cshtml"
      Write(Html.Raw(tool.OnClick));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

WriteLiteral("     return false;\r\n");

WriteLiteral("    ");

WriteLiteral(" }\r\n");

            
            #line 34 "..\..\Areas\PortalIPS\Views\Category\_\EditGrid.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</script>\r\n");

});

WriteLiteral("\r\n        \r\n\r\n    </form>\r\n</div>\r\n\r\n");

DefineSection("scripts", () => {

WriteLiteral("\r\n\r\n    <script");

WriteLiteral(" src=\"/Resources/JsLib/jquery.query.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/Resources/JsLib/jquery-easyui-extends/jquery.edatagrid.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/Resources/JsLib/jquery.form.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/Resources/JsLib/My97DatePicker/WdatePicker.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/Static/v1/js/GridUtils.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/Static/v1/js/SmartFormGrid.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/Static/v1/js/EditGrid.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
        var toolbar = '#toolbar';
        var _baseUrl = '/PortalIPS/Category';
var _apiUrl = '/api/PortalIPS/Category';
var _pageUrl = '';
var Data = {
BaseUrl: _baseUrl,
ApiUrl: _apiUrl,
FilterID: 'Category_AppID',
DataUrl: _apiUrl + '/EditGrid?'+_pageUrl,
CreateUrl: _baseUrl + '/Create?'+_pageUrl,
EditUrl: _baseUrl + '/Edit/{id}?'+_pageUrl,
ShowUrl: _baseUrl + '/Show/',
BatchDeleteUrl: _apiUrl + '/BatchDelete?'+_pageUrl,
DeleteUrl: _apiUrl + '/Delete?'+_pageUrl,
ModuleID: 'PortalIPS',
ModelID: 'Category',
PageSize: 20,
DialogWidth: 700,
DialogHeight: 600,
FieldShowType_Name_FieldName: 'CategoryName',
TreeField: 'CategoryName',
FieldShowType_Name_Title: '栏目名称',
ItemName: ""栏目管理"",
PrimaryKey: 'CategoryID',
SortField: 'OrderNum',
OrderType: 'asc',
Height: 0,
UnAutoLoadGrid: ");

            
            #line 80 "..\..\Areas\PortalIPS\Views\Category\_\EditGrid.cshtml"
            Write(RequestHelper.GetInt("UnAutoLoadGrid"));

            
            #line default
            #line hidden
WriteLiteral(",\r\ncolumns: [[\r\n");

            
            #line 82 "..\..\Areas\PortalIPS\Views\Category\_\EditGrid.cshtml"
 foreach (ToolBar tool in ViewBag.ToolbarColumnList)
{
    if(tool.OrderID < 0)
    {

            
            #line default
            #line hidden
WriteLiteral("        ");

WriteLiteral("{field: \'");

            
            #line 86 "..\..\Areas\PortalIPS\Views\Category\_\EditGrid.cshtml"
               Write(tool.ToolBarID);

            
            #line default
            #line hidden
WriteLiteral("\', title: \'");

            
            #line 86 "..\..\Areas\PortalIPS\Views\Category\_\EditGrid.cshtml"
                                           Write(tool.ToolBarName);

            
            #line default
            #line hidden
WriteLiteral("\', sortable: false,width:");

            
            #line 86 "..\..\Areas\PortalIPS\Views\Category\_\EditGrid.cshtml"
                                                                                       Write(tool.ToolBarName.Length*15+10);

            
            #line default
            #line hidden
WriteLiteral(",align:\'center\',formatter: function(value, row, index){\r\n");

WriteLiteral("        ");

WriteLiteral("    ");

            
            #line 87 "..\..\Areas\PortalIPS\Views\Category\_\EditGrid.cshtml"
         Write(Html.Raw(tool.OnClick));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

WriteLiteral("}},\r\n");

            
            #line 89 "..\..\Areas\PortalIPS\Views\Category\_\EditGrid.cshtml"
    }
}

            
            #line default
            #line hidden
WriteLiteral("\r\n{field: \'ParentID\', title: \'父级ID\', sortable: true,width:100,hidden:true,align:\'" +
"left\'},\r\n{field: \'CategoryID\', title: \'栏目ID\', sortable: true,width:100,hidden:tr" +
"ue,align:\'left\'},\r\n{field: \'IconName\', title: \'栏目标识\', sortable: true,width:100,a" +
"lign:\'left\',\r\neditor:{type:\'validatebox\',\r\noptions:{\r\ntest:1,required:true\r\n}\r\n}" +
"\r\n},\r\n{field: \'CategoryName\', title: \'栏目名称\', sortable: true,width:300,align:\'lef" +
"t\',\r\neditor:{type:\'validatebox\',\r\noptions:{\r\ntest:1,required:true\r\n}\r\n}\r\n},\r\n{fi" +
"eld: \'DisplayName\', title: \'显示名称\', sortable: true,width:100,align:\'left\',\r\nedito" +
"r:{type:\'validatebox\',\r\noptions:{\r\ntest:1,required:true\r\n}\r\n}\r\n},\r\n{field: \'Back" +
"Nvarchar2\', title: \'栏目类型\', sortable: true,width:100,align:\'left\',\r\neditor:{type:" +
"\'combobox\',\r\noptions:{\r\nvalueField:\'ID\',\r\ntextField:\'Name\',\r\ndata:[{\"ID\":\"容器栏目\"," +
"\"Name\":\"容器栏目\"},{\"ID\":\"多信息\",\"Name\":\"多信息\"},{\"ID\":\"单信息\",\"Name\":\"单信息\"},{\"ID\":\"单页面\",\"" +
"Name\":\"单页面\"},{\"ID\":\"映射栏目\",\"Name\":\"映射栏目\"},{\"ID\":\"外部链接\",\"Name\":\"外部链接\"}]}\r\n}\r\n, for" +
"matter: function(value, row, index) {\r\nreturn row.BackNvarchar2_ShowValue;}\r\n},\r" +
"\n{field: \'C_ParentID\', title: \'父级栏目名称\', sortable: true,width:100,hidden:true,ali" +
"gn:\'left\',\r\neditor:{type:\'combotree\',\r\noptions:{\r\nurl:\'/api/PortalIPS/Category/E" +
"ditTree?&iscombo=1\'}\r\n}\r\n, formatter: function(value, row, index) {\r\nreturn row." +
"C_ParentID_ShowValue;}\r\n},\r\n{field: \'CategoryInfoType\', title: \'信息类型\', sortable:" +
" true,width:100,align:\'left\',\r\neditor:{type:\'combobox\',\r\noptions:{\r\nvalueField:\'" +
"ID\',\r\ntextField:\'Name\',\r\ndata:[{\"ID\":\"CommonInfo\",\"Name\":\"文字信息\"},{\"ID\":\"Attachme" +
"ntInfo\",\"Name\":\"文件资料\"},{\"ID\":\"LinkInfo\",\"Name\":\"外部链接\"},{\"ID\":\"AdInfo\",\"Name\":\"广告" +
"\"}],required:true\r\n}\r\n}\r\n, formatter: function(value, row, index) {\r\nreturn row." +
"CategoryInfoType_ShowValue;}\r\n},\r\n{field: \'OrderNum\', title: \'排序ID\', sortable: t" +
"rue,width:100,align:\'left\',\r\neditor:{type:\'validatebox\',\r\noptions:{\r\ntest:1,requ" +
"ired:true\r\n}\r\n}\r\n},\r\n{field: \'Flag\', title: \'是否启用\', sortable: true,width:100,ali" +
"gn:\'left\',\r\neditor:{type:\'combobox\',\r\noptions:{\r\nvalueField:\'ID\',\r\ntextField:\'Na" +
"me\',\r\ndata:[{\"ID\":\"1\",\"Name\":\"是\"},{\"ID\":\"0\",\"Name\":\"否\"}],required:true\r\n}\r\n}\r\n, " +
"formatter: function(value, row, index) {\r\nreturn row.Flag_ShowValue;}\r\n},\r\n{fiel" +
"d: \'IsJournal\', title: \'栏目显示类型\', sortable: true,width:100,align:\'left\',\r\neditor:" +
"{type:\'combobox\',\r\noptions:{\r\nvalueField:\'ID\',\r\ntextField:\'Name\',\r\ndata:[{\"ID\":\"" +
"1\",\"Name\":\"普通栏目\"},{\"ID\":\"14\",\"Name\":\"普通栏目（导航不显示）\"},{\"ID\":\"0\",\"Name\":\"前台栏目\"},{\"ID" +
"\":\"9\",\"Name\":\"后台栏目\"}],required:true\r\n}\r\n}\r\n, formatter: function(value, row, ind" +
"ex) {\r\nreturn row.IsJournal_ShowValue;}\r\n},\r\n{field: \'BackNvarchar1\', title: \'是否" +
"需要发布\', sortable: true,width:100,align:\'left\',\r\neditor:{type:\'combobox\',\r\noptions" +
":{\r\nvalueField:\'ID\',\r\ntextField:\'Name\',\r\ndata:[{\"ID\":\"是\",\"Name\":\"是\"},{\"ID\":\"否\",\"" +
"Name\":\"否\"}]}\r\n}\r\n, formatter: function(value, row, index) {\r\nreturn row.BackNvar" +
"char1_ShowValue;}\r\n},\r\n{field: \'CategoryPath\', title: \'栏目路径\', sortable: true,wid" +
"th:100,hidden:true,align:\'left\',\r\neditor:{type:\'validatebox\',\r\noptions:{\r\ntest:1" +
",required:true\r\n}\r\n}\r\n}\r\n");

            
            #line 190 "..\..\Areas\PortalIPS\Views\Category\_\EditGrid.cshtml"
 foreach (ToolBar tool in ViewBag.ToolbarColumnList)
{
    if(tool.OrderID >= 0)
    {

            
            #line default
            #line hidden
WriteLiteral(",{field: \'");

            
            #line 194 "..\..\Areas\PortalIPS\Views\Category\_\EditGrid.cshtml"
        Write(tool.ToolBarID);

            
            #line default
            #line hidden
WriteLiteral("\', title: \'");

            
            #line 194 "..\..\Areas\PortalIPS\Views\Category\_\EditGrid.cshtml"
                                    Write(tool.ToolBarName);

            
            #line default
            #line hidden
WriteLiteral("\', sortable: false,width:");

            
            #line 194 "..\..\Areas\PortalIPS\Views\Category\_\EditGrid.cshtml"
                                                                                Write(tool.ToolBarName.Length*15+10);

            
            #line default
            #line hidden
WriteLiteral(",align:\'center\',formatter: function(value, row, index){\r\n");

WriteLiteral("    ");

            
            #line 195 "..\..\Areas\PortalIPS\Views\Category\_\EditGrid.cshtml"
 Write(Html.Raw(tool.OnClick));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("}}\r\n");

            
            #line 197 "..\..\Areas\PortalIPS\Views\Category\_\EditGrid.cshtml"
    }
}

            
            #line default
            #line hidden
WriteLiteral("]],\r\nfrozenColumns: [\r\n    [\r\n        {\r\n            field: \'ck\',\r\n            ch" +
"eckbox: true\r\n        }\r\n    ]\r\n],\r\ntoolbar: \'#toolbar\',\r\nsingleSelect: ");

            
            #line 209 "..\..\Areas\PortalIPS\Views\Category\_\EditGrid.cshtml"
          Write(RequestHelper.GetBool("SingleSelect",true).ToString().ToLower());

            
            #line default
            #line hidden
WriteLiteral("\r\n}\r\n        Data.QuickCreateActionUrl = Data.ApiUrl + \'/Create?ReturnData=true&\'" +
" + _pageUrl;\r\n        Data.QuickEditActionUrl = Data.ApiUrl + \'/Edit?ReturnData=" +
"true&\' + _pageUrl;\r\n        var newrow=");

            
            #line 213 "..\..\Areas\PortalIPS\Views\Category\_\EditGrid.cshtml"
              Write(Html.Raw(ViewData["InsertDefaultValueJson"]));

            
            #line default
            #line hidden
WriteLiteral(";\r\n    </script>\r\n");

            
            #line 215 "..\..\Areas\PortalIPS\Views\Category\_\EditGrid.cshtml"
Write(RenderPage("~/Areas/PortalIPS/Views/Category/Extend/Model_GridJs.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

WriteLiteral("\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
