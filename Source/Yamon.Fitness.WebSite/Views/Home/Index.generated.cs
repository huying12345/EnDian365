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
    
    #line 1 "..\..\Views\Home\Index.cshtml"
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
    
    #line 2 "..\..\Views\Home\Index.cshtml"
    using Yamon.Framework.Common;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Home\Index.cshtml"
    using Yamon.Module.SiteManage;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Home/Index.cshtml")]
    public partial class _Views_Home_Index_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Home_Index_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<noscript>\r\n    <div");

WriteLiteral(" style=\"position: absolute; z-index: 100000; height: 2046px; top: 0px; left: 0px;" +
"\r\n            width: 100%; background: white; text-align: center;\"");

WriteLiteral(">\r\n        <img");

WriteAttribute("src", Tuple.Create(" src=\"", 267), Tuple.Create("\"", 304)
, Tuple.Create(Tuple.Create("", 273), Tuple.Create<System.Object, System.Int32>(Href("~/Static/v1/images/noscript.gif")
, 273), false)
);

WriteLiteral(" alt=\'抱歉，请开启Javascript脚本支持！\'");

WriteLiteral(" />\r\n    </div>\r\n</noscript>\r\n<div");

WriteLiteral(" id=\"loading-mask\"");

WriteLiteral(" style=\"\"");

WriteLiteral(">\r\n</div>\r\n<div");

WriteLiteral(" id=\"loading\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"loading-indicator\"");

WriteLiteral(">\r\n        <img");

WriteAttribute("src", Tuple.Create(" src=\"", 474), Tuple.Create("\"", 512)
, Tuple.Create(Tuple.Create("", 480), Tuple.Create<System.Object, System.Int32>(Href("~/Static/v1/images/extanim32.gif")
, 480), false)
);

WriteLiteral(" width=\"32\"");

WriteLiteral(" height=\"32\"");

WriteLiteral(" style=\"margin-right: 8px;float: left; vertical-align: top;\"");

WriteLiteral(" /><br />\r\n        <span");

WriteLiteral(" id=\"loading-msg\"");

WriteLiteral(">数据加载中...</span>\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"index_top\"");

WriteLiteral(" region=\"north\"");

WriteLiteral(" split=\"false\"");

WriteLiteral(" border=\"false\"");

WriteLiteral(" style=\"width: 1366px; height: 90px;overflow-y:hidden;overflow-x:hidden;\"");

WriteLiteral(">\r\n    <iframe");

WriteLiteral(" id=\"topFrame\"");

WriteLiteral(" name=\"topFrame\"");

WriteLiteral(" frameborder=\"0\"");

WriteLiteral(" noresize=\"noresize\"");

WriteLiteral(" scrolling=\"no\"");

WriteLiteral(" src=\"/Home/header\"");

WriteLiteral(" height=\"100%\"");

WriteLiteral(" width=\"100%\"");

WriteLiteral("></iframe>\r\n</div>\r\n<div");

WriteLiteral(" id=\"leftRegion\"");

WriteLiteral(" region=\"west\"");

WriteLiteral(" split=\"true\"");

WriteLiteral(" border=\"false\"");

WriteLiteral(" id=\"west\"");

WriteLiteral(" style=\"width: 200px;height: 90%;overflow-y:hidden;overflow-x:hidden;\"");

WriteLiteral(">\r\n    <iframe");

WriteLiteral(" id=\"leftFrame\"");

WriteLiteral(" name=\"leftFrame\"");

WriteLiteral(" frameborder=\"0\"");

WriteLiteral(" scrolling=\"no\"");

WriteLiteral(" src=\"about:blank\"");

WriteLiteral(" height=\"100%\"");

WriteLiteral(" width=\"100%\"");

WriteLiteral("></iframe>\r\n</div>\r\n<div");

WriteLiteral(" id=\"mainPanle\"");

WriteLiteral(" region=\"center\"");

WriteLiteral(" style=\"background: #eee; overflow-y:hidden;overflow-x:hidden;\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" id=\"tabs\"");

WriteLiteral(" class=\"easyui-tabs\"");

WriteLiteral(" fit=\"true\"");

WriteLiteral(" border=\"false\"");

WriteLiteral(">\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"flooter\"");

WriteLiteral(" region=\"south\"");

WriteLiteral(" split=\"false\"");

WriteLiteral(" id=\"bg\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"floot01\"");

WriteLiteral(">\r\n        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;维护支撑：上海天声\r\n    </div>\r\n</div>\r\n<di" +
"v");

WriteLiteral(" id=\"mm\"");

WriteLiteral(" class=\"easyui-menu\"");

WriteLiteral(" style=\"width: 150px;\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" id=\"mm-tabclose\"");

WriteLiteral(">\r\n        关闭\r\n    </div>\r\n    <div");

WriteLiteral(" id=\"mm-tabcloseother\"");

WriteLiteral(">\r\n        除此之外全部关闭\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"menu-sep\"");

WriteLiteral(">\r\n    </div>\r\n    <div");

WriteLiteral(" id=\"mm-tabcloseright\"");

WriteLiteral(">\r\n        当前页右侧全部关闭\r\n    </div>\r\n    <div");

WriteLiteral(" id=\"mm-tabcloseleft\"");

WriteLiteral(">\r\n        当前页左侧全部关闭\r\n    </div>\r\n</div>\r\n\r\n");

DefineSection("styles", () => {

WriteLiteral("\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 1991), Tuple.Create("\"", 2028)
, Tuple.Create(Tuple.Create("", 1998), Tuple.Create<System.Object, System.Int32>(Href("~/Static/Home/css/shcommon.css")
, 1998), false)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n");

});

WriteLiteral("\r\n");

DefineSection("scripts", () => {

WriteLiteral("\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 2088), Tuple.Create("\"", 2119)
, Tuple.Create(Tuple.Create("", 2094), Tuple.Create<System.Object, System.Int32>(Href("~/Static/Home/js/Index.js")
, 2094), false)
);

WriteLiteral(@"></script>
    <script>

        function menuClickleftFrame(menuObj) {

            if (menuObj.attr(""url"") != """") {
                document.getElementById(""leftFrame"").contentWindow.location.href = menuObj.attr(""url"");
            } else {
                document.getElementById(""leftFrame"").contentWindow.location.href = ""/Home/LeftMenu?ParentID="" + menuObj.attr(""menuId"");
            }
        }
    </script>
");

});

        }
    }
}
#pragma warning restore 1591