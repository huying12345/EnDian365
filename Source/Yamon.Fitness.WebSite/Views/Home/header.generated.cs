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
    
    #line 1 "..\..\Views\Home\header.cshtml"
    using System.Data;
    
    #line default
    #line hidden
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
    
    #line 2 "..\..\Views\Home\header.cshtml"
    using Yamon.Module.SiteManage.Entity;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Home/header.cshtml")]
    public partial class _Views_Home_header_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Home_header_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Home\header.cshtml"
  
    ViewBag.Title = "header";
    Layout = null;
    List<Menu> menuList = (List<Menu>)ViewBag.LeftMenuList;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<!DOCTYPE HTML PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3" +
".org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">\r\n<html");

WriteLiteral(" xmlns=\"http://www.w3.org/1999/xhtml\"");

WriteLiteral(">\r\n\r\n<head>\r\n");

WriteLiteral("    ");

            
            #line 13 "..\..\Views\Home\header.cshtml"
Write(RenderPage("~/Views/includeM/head.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    <title>后台管理页面</title>\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
        $(function () {
            //顶部导航切换
            $("".nav li a"").click(function () {
                $("".nav li a.selected"").removeClass(""selected"")
                $(this).addClass(""selected"");
            });

            jQuery("".nav li:first a"").addClass(""selected"");

            parent.menuClickleftFrame(jQuery("".nav li:first""));
        });

        
    </script>

</head>

<body");

WriteLiteral(" style=\"background:url(/Static/Home/img/topbg.gif) repeat-x;\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"topleft\"");

WriteLiteral(">\r\n        <a");

WriteLiteral(" href=\"/Manage/mains\"");

WriteLiteral(" target=\"rightFrame\"");

WriteLiteral("><img");

WriteLiteral(" src=\"/Static/Home/img/365logo.png\"");

WriteLiteral(" border=\"0\"");

WriteLiteral(" title=\"系统首页\"");

WriteLiteral(" /></a>\r\n    </div>\r\n    <ul");

WriteLiteral(" class=\"nav\"");

WriteLiteral(">\r\n");

            
            #line 38 "..\..\Views\Home\header.cshtml"
        
            
            #line default
            #line hidden
            
            #line 38 "..\..\Views\Home\header.cshtml"
         foreach (Menu menu in menuList)
        {
            string menuId = menu.MenuID;
            if (menu.ParentID == "")
            {
                string imageUrl=menu.ImageUrl;
                if (imageUrl == null || imageUrl == "")
                {
                    imageUrl = "/Static/Home/img/icon02.png";
                }
                if (menuId == "0498e053-94b8-48a4-928b-a3bd5f1940e6")
                {

            
            #line default
            #line hidden
WriteLiteral("                    <li");

WriteAttribute("url", Tuple.Create(" url=\"", 1599), Tuple.Create("\"", 1646)
            
            #line 50 "..\..\Views\Home\header.cshtml"
, Tuple.Create(Tuple.Create("", 1605), Tuple.Create<System.Object, System.Int32>(menu.LinkUrl.Replace("Frame=1", "1=1")
            
            #line default
            #line hidden
, 1605), false)
);

WriteAttribute("menuid", Tuple.Create(" menuid=\"", 1647), Tuple.Create("\"", 1663)
            
            #line 50 "..\..\Views\Home\header.cshtml"
, Tuple.Create(Tuple.Create("", 1656), Tuple.Create<System.Object, System.Int32>(menuId
            
            #line default
            #line hidden
, 1656), false)
);

WriteLiteral(">\r\n                        <a");

WriteAttribute("href", Tuple.Create(" href=\'", 1693), Tuple.Create("\'", 1741)
            
            #line 51 "..\..\Views\Home\header.cshtml"
, Tuple.Create(Tuple.Create("", 1700), Tuple.Create<System.Object, System.Int32>(menu.LinkUrl.Replace("Frame=1", "1=1")
            
            #line default
            #line hidden
, 1700), false)
);

WriteLiteral(" target=\"leftFrame\"");

WriteAttribute("menuid", Tuple.Create(" menuid=\"", 1761), Tuple.Create("\"", 1777)
            
            #line 51 "..\..\Views\Home\header.cshtml"
                       , Tuple.Create(Tuple.Create("", 1770), Tuple.Create<System.Object, System.Int32>(menuId
            
            #line default
            #line hidden
, 1770), false)
);

WriteLiteral(">\r\n                            <img");

WriteAttribute("src", Tuple.Create(" src=\"", 1813), Tuple.Create("\"", 1828)
            
            #line 52 "..\..\Views\Home\header.cshtml"
, Tuple.Create(Tuple.Create("", 1819), Tuple.Create<System.Object, System.Int32>(imageUrl
            
            #line default
            #line hidden
, 1819), false)
);

WriteAttribute("title", Tuple.Create(" title=\"", 1829), Tuple.Create("\"", 1853)
            
            #line 52 "..\..\Views\Home\header.cshtml"
, Tuple.Create(Tuple.Create("", 1837), Tuple.Create<System.Object, System.Int32>(menu.MenuName
            
            #line default
            #line hidden
, 1837), false)
);

WriteLiteral(" />\r\n                            <h2>");

            
            #line 53 "..\..\Views\Home\header.cshtml"
                            Write(menu.MenuName);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n                        </a>\r\n                    </li>\r\n");

            
            #line 56 "..\..\Views\Home\header.cshtml"
                }
                else
                {

            
            #line default
            #line hidden
WriteLiteral("                    <li");

WriteAttribute("url", Tuple.Create(" url=\"", 2054), Tuple.Create("\"", 2090)
, Tuple.Create(Tuple.Create("", 2060), Tuple.Create("/Home/lefts?1=1&menuId=", 2060), true)
            
            #line 59 "..\..\Views\Home\header.cshtml"
, Tuple.Create(Tuple.Create("", 2083), Tuple.Create<System.Object, System.Int32>(menuId
            
            #line default
            #line hidden
, 2083), false)
);

WriteAttribute("menuid", Tuple.Create(" menuid=\"", 2091), Tuple.Create("\"", 2107)
            
            #line 59 "..\..\Views\Home\header.cshtml"
, Tuple.Create(Tuple.Create("", 2100), Tuple.Create<System.Object, System.Int32>(menuId
            
            #line default
            #line hidden
, 2100), false)
);

WriteLiteral(">\r\n                        <a");

WriteAttribute("href", Tuple.Create(" href=\'", 2137), Tuple.Create("\'", 2174)
, Tuple.Create(Tuple.Create("", 2144), Tuple.Create("/Home/lefts?1=1&menuId=", 2144), true)
            
            #line 60 "..\..\Views\Home\header.cshtml"
, Tuple.Create(Tuple.Create("", 2167), Tuple.Create<System.Object, System.Int32>(menuId
            
            #line default
            #line hidden
, 2167), false)
);

WriteLiteral(" target=\"leftFrame\"");

WriteAttribute("menuid", Tuple.Create(" menuid=\"", 2194), Tuple.Create("\"", 2210)
            
            #line 60 "..\..\Views\Home\header.cshtml"
            , Tuple.Create(Tuple.Create("", 2203), Tuple.Create<System.Object, System.Int32>(menuId
            
            #line default
            #line hidden
, 2203), false)
);

WriteLiteral(">\r\n                            <img");

WriteAttribute("src", Tuple.Create(" src=\"", 2246), Tuple.Create("\"", 2261)
            
            #line 61 "..\..\Views\Home\header.cshtml"
, Tuple.Create(Tuple.Create("", 2252), Tuple.Create<System.Object, System.Int32>(imageUrl
            
            #line default
            #line hidden
, 2252), false)
);

WriteAttribute("title", Tuple.Create(" title=\"", 2262), Tuple.Create("\"", 2286)
            
            #line 61 "..\..\Views\Home\header.cshtml"
, Tuple.Create(Tuple.Create("", 2270), Tuple.Create<System.Object, System.Int32>(menu.MenuName
            
            #line default
            #line hidden
, 2270), false)
);

WriteLiteral(" />\r\n                            <h2>");

            
            #line 62 "..\..\Views\Home\header.cshtml"
                            Write(menu.MenuName);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n                        </a>\r\n                    </li>\r\n");

            
            #line 65 "..\..\Views\Home\header.cshtml"
                }
            }
        }

            
            #line default
            #line hidden
WriteLiteral("    </ul>\r\n\r\n    <div");

WriteLiteral(" class=\"topright\"");

WriteLiteral(">\r\n        <ul>\r\n            <li>\r\n                <span><img");

WriteLiteral(" src=\"/Static/Home/img/help.png\"");

WriteLiteral(" title=\"帮助\"");

WriteLiteral(" class=\"helpimg\"");

WriteLiteral(" /></span>\r\n                <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(">帮助</a>\r\n            </li>\r\n            <li>\r\n                <a");

WriteLiteral(" href=\"../\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">网站首页</a>\r\n            </li>\r\n            <li>\r\n                <a");

WriteLiteral(" href=\"Login\"");

WriteLiteral(" target=\"_top\"");

WriteLiteral(" onclick=\"return confirm(\'确定退出系统吗？\\n\\n退出后自动关闭窗口！\');\"");

WriteLiteral(">退出</a>\r\n            </li>\r\n        </ul>\r\n\r\n        <div");

WriteLiteral(" class=\"user\"");

WriteLiteral(">\r\n            <span>→ 管理员：  ");

            
            #line 85 "..\..\Views\Home\header.cshtml"
                       Write(CookieHelper.GetCookie("UserName"));

            
            #line default
            #line hidden
WriteLiteral("  管理员级别：");

            
            #line 85 "..\..\Views\Home\header.cshtml"
                                                                    Write(CookieHelper.GetCookie("RoleName"));

            
            #line default
            #line hidden
WriteLiteral(" </span>\r\n        </div>\r\n\r\n    </div>\r\n\r\n</body>\r\n\r\n</html>");

        }
    }
}
#pragma warning restore 1591
