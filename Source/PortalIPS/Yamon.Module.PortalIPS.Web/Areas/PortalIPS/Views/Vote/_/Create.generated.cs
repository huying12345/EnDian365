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
    using System.Data;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/PortalIPS/Views/Vote/_/Create.cshtml")]
    public partial class _Areas_PortalIPS_Views_Vote___Create_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_PortalIPS_Views_Vote___Create_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 2 "..\..\Areas\PortalIPS\Views\Vote\_\Create.cshtml"
  
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
    ViewBag.Title="新建投票";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" region=\"center\"");

WriteLiteral(" border=\"true\"");

WriteLiteral(" style=\"padding: 10px; background: #FFFFFF; border: 1px solid #ccc;\"");

WriteLiteral(">\r\n    <form");

WriteLiteral(" id=\"myForm\"");

WriteLiteral(" name=\"myForm\"");

WriteLiteral(" action=\"/api/PortalIPS/Vote/Create\"");

WriteLiteral(" method=\"post\"");

WriteLiteral(">\r\n        <table");

WriteLiteral(" class=\"mytable\"");

WriteLiteral("  cellpadding=\"1\"");

WriteLiteral(" width=\"100%\"");

WriteLiteral(" cellspacing=\"0\"");

WriteLiteral(" align=\"center\"");

WriteLiteral(">\r\n<tr");

WriteLiteral(" id=\"Container_VoteName\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">投票主题：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"VoteName\"");

WriteLiteral(" name=\"VoteName\"");

WriteAttribute("value", Tuple.Create(" value=\"", 830), Tuple.Create("\"", 855)
            
            #line 22 "..\..\Areas\PortalIPS\Views\Vote\_\Create.cshtml"
, Tuple.Create(Tuple.Create("", 838), Tuple.Create<System.Object, System.Int32>(Model.VoteName
            
            #line default
            #line hidden
, 838), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral(" required=\"true\"");

WriteLiteral("  maxlength=\"50\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">状态：</td><td>&nbsp;\r\n");

            
            #line 25 "..\..\Areas\PortalIPS\Views\Vote\_\Create.cshtml"
Write(Html.Raw(MyHtmlHelper2.ShowRadio(ViewBag.DAL.NameValue_Status, "Status", Model.Status, "&nbsp;&nbsp;")));

            
            #line default
            #line hidden
WriteLiteral("\r\n</td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_VoteContent\"");

WriteLiteral(">\r\n<td");

WriteLiteral("  class=\"labeltd\"");

WriteLiteral(">投票说明：</td><td");

WriteLiteral("  colspan=\"3\"");

WriteLiteral(" >&nbsp;\r\n<textarea");

WriteLiteral(" id=\"VoteContent\"");

WriteLiteral(" name=\"VoteContent\"");

WriteLiteral(" class=\"easyui-validatebox\"");

WriteLiteral("  style=\"width:500px;height:80px\"");

WriteLiteral(">");

            
            #line 30 "..\..\Areas\PortalIPS\Views\Vote\_\Create.cshtml"
                                                                                                      Write(Model.VoteContent);

            
            #line default
            #line hidden
WriteLiteral("</textarea>\r\n</td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_VoteItem\"");

WriteLiteral(">\r\n<td");

WriteLiteral("  class=\"labeltd\"");

WriteLiteral(">投票选项：</td><td");

WriteLiteral("  colspan=\"3\"");

WriteLiteral(" >&nbsp;<iframe");

WriteLiteral(" id=\"tab2Frame\"");

WriteLiteral(" name=\"tab2Frame\"");

WriteLiteral(" style=\"width:99%;height:300px\"");

WriteAttribute("src", Tuple.Create(" src=\"", 1513), Tuple.Create("\"", 1640)
, Tuple.Create(Tuple.Create("", 1519), Tuple.Create("/SF/PortalIPS/VoteItem/EditGrid?VoteID=", 1519), true)
            
            #line 34 "..\..\Areas\PortalIPS\Views\Vote\_\Create.cshtml"
                                                                                           , Tuple.Create(Tuple.Create("", 1558), Tuple.Create<System.Object, System.Int32>(Model.VoteID.Value
            
            #line default
            #line hidden
, 1558), false)
, Tuple.Create(Tuple.Create("", 1579), Tuple.Create("&AppID=", 1579), true)
            
            #line 34 "..\..\Areas\PortalIPS\Views\Vote\_\Create.cshtml"
                                                                                                                       , Tuple.Create(Tuple.Create("", 1586), Tuple.Create<System.Object, System.Int32>(RequestHelper.GetString("AppID")
            
            #line default
            #line hidden
, 1586), false)
, Tuple.Create(Tuple.Create("", 1621), Tuple.Create("&Menu=VoteItem_List", 1621), true)
);

WriteLiteral(" frameborder=\"0\"");

WriteLiteral("></iframe></td>\r\n</tr>\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" id=\"VoteID\"");

WriteLiteral("  name=\"VoteID\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1728), Tuple.Create("\"", 1751)
            
            #line 36 "..\..\Areas\PortalIPS\Views\Vote\_\Create.cshtml"
, Tuple.Create(Tuple.Create("", 1736), Tuple.Create<System.Object, System.Int32>(Model.VoteID
            
            #line default
            #line hidden
, 1736), false)
);

WriteLiteral("/><input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" id=\"CategoryID\"");

WriteLiteral("  name=\"CategoryID\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1809), Tuple.Create("\"", 1836)
            
            #line 36 "..\..\Areas\PortalIPS\Views\Vote\_\Create.cshtml"
                                                         , Tuple.Create(Tuple.Create("", 1817), Tuple.Create<System.Object, System.Int32>(Model.CategoryID
            
            #line default
            #line hidden
, 1817), false)
);

WriteLiteral("/><input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" id=\"AppID\"");

WriteLiteral("  name=\"AppID\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1884), Tuple.Create("\"", 1906)
            
            #line 36 "..\..\Areas\PortalIPS\Views\Vote\_\Create.cshtml"
                                                                                                                                    , Tuple.Create(Tuple.Create("", 1892), Tuple.Create<System.Object, System.Int32>(Model.AppID
            
            #line default
            #line hidden
, 1892), false)
);

WriteLiteral("/>\r\n</table>\r\n\r\n");

WriteLiteral("        ");

            
            #line 39 "..\..\Areas\PortalIPS\Views\Vote\_\Create.cshtml"
   Write(RenderPage("~/Areas/PortalIPS/Views/Vote/Extend/Model_FormHtml.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </form>\r\n</div>\r\n<div");

WriteLiteral(" region=\"south\"");

WriteLiteral(" border=\"false\"");

WriteLiteral(" style=\"text-align: right; background: #F6F6F6;height: 30px; line-height: 30px;\"");

WriteLiteral(">\r\n    <a");

WriteLiteral(" id=\"btnSubmit\"");

WriteLiteral(" class=\"easyui-linkbutton\"");

WriteLiteral(" icon=\"icon-ok\"");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(">确定</a>\r\n    <a");

WriteLiteral(" id=\"btnCancel\"");

WriteLiteral(" class=\"easyui-linkbutton\"");

WriteLiteral(" icon=\"icon-cancel\"");

WriteLiteral(" href=\"javascript:CloseDialog();\"");

WriteLiteral(">\r\n        取消\r\n    </a>\r\n</div>\r\n");

DefineSection("scripts", () => {

WriteLiteral("\r\n    <script");

WriteLiteral(" src=\"/Resources/JsLib/jquery.form.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/Resources/JsLib/My97DatePicker/WdatePicker.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/Static/v1/js/Utils.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/Static/v1/js/form.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
        jQuery(function() {
            CheckConditions();
function CheckConditions(){
jQuery('fieldset').show(); 
jQuery(""fieldset"").each(function(){ 
if(jQuery('tr',this).length>0){
if(jQuery('tr:visible',this).length>0){jQuery(this).show()} else{jQuery(this).hide()}
}
});
}
;
        });
    </script>
");

WriteLiteral("    ");

            
            #line 67 "..\..\Areas\PortalIPS\Views\Vote\_\Create.cshtml"
Write(RenderPage("~/Areas/PortalIPS/Views/Vote/Extend/Model_FormJs.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591