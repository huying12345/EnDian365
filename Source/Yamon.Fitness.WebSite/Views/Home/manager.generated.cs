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
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Yamon.Framework.Common;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Home/manager.cshtml")]
    public partial class _Views_Home_manager_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Home_manager_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Home\manager.cshtml"
   ViewBag.Title = "manager"; 
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<!DOCTYPE HTML PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3" +
".org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">\r\n<html");

WriteLiteral(" xmlns=\"http://www.w3.org/1999/xhtml\"");

WriteLiteral(">\r\n\r\n<head>\r\n    <title>管理员</title>\r\n");

WriteLiteral("    ");

            
            #line 8 "..\..\Views\Home\manager.cshtml"
Write(RenderPage("~/Views/includeM/head.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    <script");

WriteLiteral(" src=\"/Static/manage/js/checkfrom.js\"");

WriteLiteral("></script>\r\n</head>\r\n\r\n<body>\r\n    <div");

WriteLiteral(" class=\"place\"");

WriteLiteral(">\r\n        <span>位置：</span>\r\n        <ul");

WriteLiteral(" class=\"placeul\"");

WriteLiteral(">\r\n            <li>\r\n                <a");

WriteLiteral(" href=\"/Views/Manage/mains\"");

WriteLiteral(">首页</a>\r\n            </li>\r\n            <li>管理员信息</li>\r\n            <li>信息管理</li>" +
"\r\n        </ul>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"rightinfo\"");

WriteLiteral(">\r\n        <form");

WriteLiteral(" name=\"formlist\"");

WriteLiteral(" method=\"post\"");

WriteLiteral(" action=\"manager.php?action=del\"");

WriteLiteral(">\r\n\r\n            <div");

WriteLiteral(" class=\"tools\"");

WriteLiteral(">\r\n\r\n                <ul");

WriteLiteral(" class=\"toolbar\"");

WriteLiteral(">\r\n                    <a");

WriteLiteral(" href=\"?\"");

WriteLiteral("><img");

WriteLiteral(" src=\"/Static/Home/img/sx.jpg\"");

WriteLiteral(" /></a>\r\n                    <li>&nbsp;<input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" name=\"all\"");

WriteLiteral(" onclick=\"CheckAll(this);\"");

WriteLiteral(" /> 全选</li>\r\n                    <a");

WriteLiteral(" href=\"manager_add.php\"");

WriteLiteral("><img");

WriteLiteral(" src=\"/Static/Home/img/add.jpg\"");

WriteLiteral(" /></a>\r\n                    <input");

WriteLiteral(" type=\"image\"");

WriteLiteral(" src=\"/Static/Home/img/del.jpg\"");

WriteLiteral(" onclick=\"return checkData();\"");

WriteLiteral(" name=\"ok\"");

WriteLiteral(" value=\"删 除\"");

WriteLiteral(" />\r\n                </ul>\r\n\r\n            </div>\r\n\r\n            <table");

WriteLiteral(" class=\"tablelist\"");

WriteLiteral(">\r\n                <thead>\r\n                    <tr>\r\n                        <th" +
"");

WriteLiteral(" width=\"5%\"");

WriteLiteral(">选择</th>\r\n                        <th");

WriteLiteral(" width=\"8%\"");

WriteLiteral(">编号</th>\r\n                        <th");

WriteLiteral(" width=\"29%\"");

WriteLiteral(">维护人员帐号</th>\r\n                        <th");

WriteLiteral(" width=\"14%\"");

WriteLiteral(">维护人员姓名</th>\r\n                        <th");

WriteLiteral(" width=\"11%\"");

WriteLiteral(">维护人员类型</th>\r\n                        <th");

WriteLiteral(" width=\"6%\"");

WriteLiteral(">是否审核</th>\r\n                        <th");

WriteLiteral(" width=\"16%\"");

WriteLiteral(">发布时间</th>\r\n                        <th");

WriteLiteral(" width=\"11%\"");

WriteLiteral(">操作</th>\r\n                    </tr>\r\n                </thead>\r\n                <t" +
"body>\r\n                    <tr>\r\n                        <td><input");

WriteLiteral(" name=\"checkid[]\"");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" id=\"checkid[]\"");

WriteLiteral(" value=\"1\"");

WriteLiteral(" /></td>\r\n                        <td>1</td>\r\n                        <td>超级管理员</" +
"td>\r\n                        <td>admin</td>\r\n                        <td>超级管理员</" +
"td>\r\n                        <td>\r\n                            <a");

WriteLiteral(" href=\'?action=confirm&id=1\'");

WriteLiteral(">\r\n                                <font");

WriteLiteral(" color=\'red\'");

WriteLiteral(">已审核</font>\r\n                            </a>\r\n                        </td>\r\n   " +
"                     <td>2016-12-14 15:42:52</td>\r\n                        <td>\r" +
"\n                            <a");

WriteLiteral(" href=\"manager_edit.php?id=1\"");

WriteLiteral(" class=\"tablelink\"");

WriteLiteral(">修改</a>\r\n                        </td>\r\n                    </tr>\r\n\r\n            " +
"    </tbody>\r\n            </table>\r\n\r\n            <div");

WriteLiteral(" class=\"fy\"");

WriteLiteral(">\r\n                <a");

WriteLiteral(" href=\"javascript:void()\"");

WriteLiteral(">首页</a>\r\n                <a");

WriteLiteral(" href=\"javascript:void()\"");

WriteLiteral(">上一页</a>\r\n                <a");

WriteLiteral(" href=\"javascript:void()\"");

WriteLiteral(" id=\"active1\"");

WriteLiteral(">1</a>\r\n                <a");

WriteLiteral(" href=\"javascript:void()\"");

WriteLiteral(">下一页</a>\r\n                <a");

WriteLiteral(" href=\"javascript:void()\"");

WriteLiteral(">末页</a>\r\n            </div>\r\n        </form>\r\n\r\n    </div>\r\n\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        $(\'.tablelist tbody tr:odd\').addClass(\'odd\');\r\n    </script>\r\n\r\n</body" +
">\r\n\r\n</html>");

        }
    }
}
#pragma warning restore 1591
