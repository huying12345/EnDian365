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
    
    #line 1 "..\..\Views\Shared\Navigation.cshtml"
    using Yamon.Module.SiteManage.Entity;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/Navigation.cshtml")]
    public partial class _Views_Shared_Navigation_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared_Navigation_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Shared\Navigation.cshtml"
  
    List<Menu> menuList = (List<Menu>)ViewBag.LeftMenuList;
    Layout = null;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n\r\n\r\n");

            
            #line 9 "..\..\Views\Shared\Navigation.cshtml"
        
            
            #line default
            #line hidden
            
            #line 9 "..\..\Views\Shared\Navigation.cshtml"
         foreach (Menu menu in menuList)
        {
            if (menu.Children == null)
            {

            
            #line default
            #line hidden
WriteLiteral("                <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 263), Tuple.Create("\"", 285)
            
            #line 13 "..\..\Views\Shared\Navigation.cshtml"
, Tuple.Create(Tuple.Create("", 270), Tuple.Create<System.Object, System.Int32>(menu.LinkUrl
            
            #line default
            #line hidden
, 270), false)
);

WriteLiteral(">");

            
            #line 13 "..\..\Views\Shared\Navigation.cshtml"
                                          Write(menu.MenuName);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 14 "..\..\Views\Shared\Navigation.cshtml"
            }
            else
            {

            
            #line default
            #line hidden
WriteLiteral("                <li");

WriteLiteral(" class=\"dropdown\"");

WriteLiteral(">\r\n                    <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"dropdown-toggle\"");

WriteLiteral(" data-toggle=\"dropdown\"");

WriteLiteral(">");

            
            #line 18 "..\..\Views\Shared\Navigation.cshtml"
                                                                           Write(menu.MenuName);

            
            #line default
            #line hidden
WriteLiteral("<span");

WriteLiteral(" class=\"caret\"");

WriteLiteral("></span></a>\r\n                    <ul");

WriteLiteral(" class=\"dropdown-menu\"");

WriteLiteral(" role=\"menu\"");

WriteLiteral(" id=\"dataList\"");

WriteLiteral(">\r\n");

            
            #line 20 "..\..\Views\Shared\Navigation.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\Shared\Navigation.cshtml"
                         foreach (Menu subMenu in menu.Children)
                        {
                            if (subMenu != null) { 
                                if (subMenu.Children != null)
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <li");

WriteLiteral(" style=\"padding: 5px; font-weight: bold;\"");

WriteLiteral(">");

            
            #line 25 "..\..\Views\Shared\Navigation.cshtml"
                                                                             Write(subMenu.MenuName);

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n");

WriteLiteral("                                    <li");

WriteLiteral(" class=\"divider\"");

WriteLiteral("></li>\r\n");

            
            #line 27 "..\..\Views\Shared\Navigation.cshtml"
                                    foreach (Menu subMenu2 in subMenu.Children)
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <li");

WriteLiteral(" style=\"position: relative\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1210), Tuple.Create("\"", 1236)
            
            #line 29 "..\..\Views\Shared\Navigation.cshtml"
 , Tuple.Create(Tuple.Create("", 1217), Tuple.Create<System.Object, System.Int32>(subMenu2.LinkUrl
            
            #line default
            #line hidden
, 1217), false)
);

WriteLiteral(" ");

            
            #line 29 "..\..\Views\Shared\Navigation.cshtml"
                                                                                                 Write(subMenu2.OpenType>0?"target=\"_blank\"":"");

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 29 "..\..\Views\Shared\Navigation.cshtml"
                                                                                                                                               Write(subMenu2.MenuName);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 30 "..\..\Views\Shared\Navigation.cshtml"
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                    <li");

WriteLiteral(" class=\"divider\"");

WriteLiteral("></li>\r\n");

            
            #line 32 "..\..\Views\Shared\Navigation.cshtml"
                                }
                                else
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1567), Tuple.Create("\"", 1592)
            
            #line 35 "..\..\Views\Shared\Navigation.cshtml"
, Tuple.Create(Tuple.Create("", 1574), Tuple.Create<System.Object, System.Int32>(subMenu.LinkUrl
            
            #line default
            #line hidden
, 1574), false)
);

WriteLiteral(" ");

            
            #line 35 "..\..\Views\Shared\Navigation.cshtml"
                                                                 Write(subMenu.OpenType > 0 ? "target=\"_blank\"" : "");

            
            #line default
            #line hidden
WriteLiteral(" id=\"newPage\">");

            
            #line 35 "..\..\Views\Shared\Navigation.cshtml"
                                                                                                                                 Write(subMenu.MenuName);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 36 "..\..\Views\Shared\Navigation.cshtml"
                                }
                            }
                        }

            
            #line default
            #line hidden
WriteLiteral("                        \r\n                    </ul>\r\n                </li>\r\n");

            
            #line 42 "..\..\Views\Shared\Navigation.cshtml"
            }
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
