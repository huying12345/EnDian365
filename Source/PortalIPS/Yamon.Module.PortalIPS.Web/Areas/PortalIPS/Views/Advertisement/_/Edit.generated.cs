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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/PortalIPS/Views/Advertisement/_/Edit.cshtml")]
    public partial class _Areas_PortalIPS_Views_Advertisement___Edit_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_PortalIPS_Views_Advertisement___Edit_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 2 "..\..\Areas\PortalIPS\Views\Advertisement\_\Edit.cshtml"
  
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
    ViewBag.Title="编辑广告";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" region=\"center\"");

WriteLiteral(" border=\"true\"");

WriteLiteral(" style=\"padding: 10px; background: #FFFFFF; border: 1px solid #ccc;\"");

WriteLiteral(">\r\n    <form");

WriteLiteral(" id=\"myForm\"");

WriteLiteral(" name=\"myForm\"");

WriteLiteral(" action=\"/api/PortalIPS/Advertisement/Edit\"");

WriteLiteral(" method=\"post\"");

WriteLiteral(">\r\n        <table");

WriteLiteral(" class=\"mytable\"");

WriteLiteral("  cellpadding=\"1\"");

WriteLiteral(" width=\"100%\"");

WriteLiteral(" cellspacing=\"0\"");

WriteLiteral(" align=\"center\"");

WriteLiteral(">\r\n<tr");

WriteLiteral(" id=\"Container_ID\"");

WriteLiteral("><td");

WriteLiteral(" id=\"Label_ID\"");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">ID：</td><td>&nbsp;<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" id=\"ID\"");

WriteLiteral("  name=\"ID\"");

WriteAttribute("value", Tuple.Create(" value=\"", 830), Tuple.Create("\"", 849)
            
            #line 20 "..\..\Areas\PortalIPS\Views\Advertisement\_\Edit.cshtml"
                                           , Tuple.Create(Tuple.Create("", 838), Tuple.Create<System.Object, System.Int32>(Model.ID
            
            #line default
            #line hidden
, 838), false)
);

WriteLiteral("/><span");

WriteLiteral(" id=\"ID_ShowValue\"");

WriteLiteral(">");

            
            #line 20 "..\..\Areas\PortalIPS\Views\Advertisement\_\Edit.cshtml"
                                                                                                                                                           Write(Model.ID);

            
            #line default
            #line hidden
WriteLiteral("</span></td></tr>\r\n<tr");

WriteLiteral(" id=\"Container_Name\"");

WriteLiteral("><td");

WriteLiteral(" id=\"Label_Name\"");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">名称：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"Name\"");

WriteLiteral(" name=\"Name\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1026), Tuple.Create("\"", 1047)
            
            #line 22 "..\..\Areas\PortalIPS\Views\Advertisement\_\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 1034), Tuple.Create<System.Object, System.Int32>(Model.Name
            
            #line default
            #line hidden
, 1034), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"50\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td></tr>\r\n<tr");

WriteLiteral(" id=\"Container_Type\"");

WriteLiteral("><td");

WriteLiteral(" id=\"Label_Type\"");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">类型：</td><td>&nbsp;\r\n<select");

WriteLiteral(" id=\"Type\"");

WriteLiteral(" name=\"Type\"");

WriteLiteral(" class=\"easyui-combobox\"");

WriteLiteral("  style=\"width:200px\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 26 "..\..\Areas\PortalIPS\Views\Advertisement\_\Edit.cshtml"
Write(Html.Raw(MyHtmlHelper2.ShowSelectOptions(ViewBag.DAL.NameValue_Type, Model.Type)));

            
            #line default
            #line hidden
WriteLiteral("\r\n</select></td></tr>\r\n<tr");

WriteLiteral(" id=\"Container_Status\"");

WriteLiteral("><td");

WriteLiteral(" id=\"Label_Status\"");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">状态：</td><td>&nbsp;\r\n<select");

WriteLiteral(" id=\"Status\"");

WriteLiteral(" name=\"Status\"");

WriteLiteral(" class=\"easyui-combobox\"");

WriteLiteral("  style=\"width:200px\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 30 "..\..\Areas\PortalIPS\Views\Advertisement\_\Edit.cshtml"
Write(Html.Raw(MyHtmlHelper2.ShowSelectOptions(ViewBag.DAL.NameValue_Status, Model.Status)));

            
            #line default
            #line hidden
WriteLiteral("\r\n</select></td></tr>\r\n<tr");

WriteLiteral(" id=\"Container_Link\"");

WriteLiteral("><td");

WriteLiteral(" id=\"Label_Link\"");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">链接地址：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"Link\"");

WriteLiteral(" name=\"Link\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1802), Tuple.Create("\"", 1823)
            
            #line 33 "..\..\Areas\PortalIPS\Views\Advertisement\_\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 1810), Tuple.Create<System.Object, System.Int32>(Model.Link
            
            #line default
            #line hidden
, 1810), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"500\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td></tr>\r\n<tr");

WriteLiteral(" id=\"Container_Url\"");

WriteLiteral("><td");

WriteLiteral(" id=\"Label_Url\"");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">图片：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"Url\"");

WriteLiteral(" name=\"Url\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2029), Tuple.Create("\"", 2049)
            
            #line 36 "..\..\Areas\PortalIPS\Views\Advertisement\_\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 2037), Tuple.Create<System.Object, System.Int32>(Model.Url
            
            #line default
            #line hidden
, 2037), false)
);

WriteLiteral("   class=\"easyui-validatebox\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral("/>\r\n<br/>\r\n<input");

WriteLiteral(" class=\"easyui-filebox\"");

WriteLiteral(" data-options=\"buttonText:\'浏览\',accept: \'image/*\',buttonAlign:\'left\'\"");

WriteLiteral(" id=\"Upload_Url\"");

WriteLiteral(" name=\"Upload_Url\"");

WriteLiteral(" style=\"width: 200px;\"");

WriteLiteral(" />\r\n<input");

WriteLiteral(" class=\"easyui-linkbutton\"");

WriteLiteral(" type=\"button\"");

WriteLiteral(" id=\"btnUrl_Upload\"");

WriteLiteral(" name=\"btnUrl_Upload\"");

WriteLiteral(" value=\"上传\"");

WriteLiteral(" onclick=\"btnUrl_UploadClick()\"");

WriteLiteral("/>\r\n");

            
            #line 40 "..\..\Areas\PortalIPS\Views\Advertisement\_\Edit.cshtml"
 if(!string.IsNullOrEmpty(Model.Url)){

            
            #line default
            #line hidden
WriteLiteral(" <br/>");

WriteLiteral("<img");

WriteLiteral(" id=\"Preview_Url\"");

WriteAttribute("src", Tuple.Create(" src=\"", 2467), Tuple.Create("\"", 2485)
            
            #line 41 "..\..\Areas\PortalIPS\Views\Advertisement\_\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 2473), Tuple.Create<System.Object, System.Int32>(Model.Url
            
            #line default
            #line hidden
, 2473), false)
);

WriteLiteral(" style=\"height: 60px; \"");

WriteLiteral("/>\r\n");

            
            #line 42 "..\..\Areas\PortalIPS\Views\Advertisement\_\Edit.cshtml"
}else{

            
            #line default
            #line hidden
WriteLiteral(" <br/>");

WriteLiteral("<img");

WriteLiteral(" id=\"Preview_Url\"");

WriteAttribute("src", Tuple.Create(" src=\"", 2548), Tuple.Create("\"", 2566)
            
            #line 43 "..\..\Areas\PortalIPS\Views\Advertisement\_\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 2554), Tuple.Create<System.Object, System.Int32>(Model.Url
            
            #line default
            #line hidden
, 2554), false)
);

WriteLiteral(" style=\"height: 60px; display: none; \"");

WriteLiteral("/>\r\n");

            
            #line 44 "..\..\Areas\PortalIPS\Views\Advertisement\_\Edit.cshtml"
 }

            
            #line default
            #line hidden
WriteLiteral("<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
    ///上传按钮事件
    function btnUrl_UploadClick(){
        jQuery(""#myForm"").ajaxSubmit( {
            type: 'post',
            dataType: 'text',
            url: ""/api/SiteManage/UploadImage/Upload?FieldName=Url&UploadFieldName=Upload_Url&ModelID=Advertisement&ModuleID=PortalIPS"",
            beforeSubmit: function(formData, jqForm, options) {
                var queryString = jQuery.param(formData);
                if( jQuery(""Upload_Url"").val()==""""){
                    alert(""请选择你要上传的图片！"");
                }
                return true;
            },
            success: function(msg) {
                eval(""var result=""+msg);
                if(result.Status==1){
                    jQuery(""#Url"").val(result.returnValue);
                    alert(""上传成功!"");
                    $('#Upload_Url').filebox('clear');
                    $('#Preview_Url').attr('src',result.returnValue);
                }else{
                    alert(result.returnValue);
                }
            },
            error: function(error) {
            }
        });
    }
</script>
</td></tr>
<tr");

WriteLiteral(" id=\"Container_Count\"");

WriteLiteral("><td");

WriteLiteral(" id=\"Label_Count\"");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">内容：</td><td>&nbsp;\r\n<textarea");

WriteLiteral(" id=\"Count\"");

WriteLiteral(" name=\"Count\"");

WriteLiteral(" class=\"easyui-validatebox\"");

WriteLiteral("  style=\"width:300px;height:50px\"");

WriteLiteral(">");

            
            #line 77 "..\..\Areas\PortalIPS\Views\Advertisement\_\Edit.cshtml"
                                                                                          Write(Model.Count);

            
            #line default
            #line hidden
WriteLiteral("</textarea>\r\n</td></tr>\r\n<tr");

WriteLiteral(" id=\"Container_Width\"");

WriteLiteral("><td");

WriteLiteral(" id=\"Label_Width\"");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">宽度：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"Width\"");

WriteLiteral(" name=\"Width\"");

WriteAttribute("value", Tuple.Create(" value=\"", 4106), Tuple.Create("\"", 4128)
            
            #line 80 "..\..\Areas\PortalIPS\Views\Advertisement\_\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 4114), Tuple.Create<System.Object, System.Int32>(Model.Width
            
            #line default
            #line hidden
, 4114), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"4\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td></tr>\r\n<tr");

WriteLiteral(" id=\"Container_Height\"");

WriteLiteral("><td");

WriteLiteral(" id=\"Label_Height\"");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">高度：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"Height\"");

WriteLiteral(" name=\"Height\"");

WriteAttribute("value", Tuple.Create(" value=\"", 4344), Tuple.Create("\"", 4367)
            
            #line 83 "..\..\Areas\PortalIPS\Views\Advertisement\_\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 4352), Tuple.Create<System.Object, System.Int32>(Model.Height
            
            #line default
            #line hidden
, 4352), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"4\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td></tr>\r\n<tr");

WriteLiteral(" id=\"Container_PositionLeft\"");

WriteLiteral("><td");

WriteLiteral(" id=\"Label_PositionLeft\"");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">距左距离：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"PositionLeft\"");

WriteLiteral(" name=\"PositionLeft\"");

WriteAttribute("value", Tuple.Create(" value=\"", 4609), Tuple.Create("\"", 4638)
            
            #line 86 "..\..\Areas\PortalIPS\Views\Advertisement\_\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 4617), Tuple.Create<System.Object, System.Int32>(Model.PositionLeft
            
            #line default
            #line hidden
, 4617), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"4\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td></tr>\r\n<tr");

WriteLiteral(" id=\"Container_PositionTop\"");

WriteLiteral("><td");

WriteLiteral(" id=\"Label_PositionTop\"");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">距顶距离：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"PositionTop\"");

WriteLiteral(" name=\"PositionTop\"");

WriteAttribute("value", Tuple.Create(" value=\"", 4876), Tuple.Create("\"", 4904)
            
            #line 89 "..\..\Areas\PortalIPS\Views\Advertisement\_\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 4884), Tuple.Create<System.Object, System.Int32>(Model.PositionTop
            
            #line default
            #line hidden
, 4884), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"4\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td></tr>\r\n<tr");

WriteLiteral(" id=\"Container_Velocity\"");

WriteLiteral("><td");

WriteLiteral(" id=\"Label_Velocity\"");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">浮动速度：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"Velocity\"");

WriteLiteral(" name=\"Velocity\"");

WriteAttribute("value", Tuple.Create(" value=\"", 5130), Tuple.Create("\"", 5155)
            
            #line 92 "..\..\Areas\PortalIPS\Views\Advertisement\_\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 5138), Tuple.Create<System.Object, System.Int32>(Model.Velocity
            
            #line default
            #line hidden
, 5138), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"4\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td></tr>\r\n\r\n</table>\r\n\r\n");

WriteLiteral("        ");

            
            #line 97 "..\..\Areas\PortalIPS\Views\Advertisement\_\Edit.cshtml"
   Write(RenderPage("~/Areas/PortalIPS/Views/Advertisement/Extend/Model_FormHtml.cshtml"));

            
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

            
            #line 125 "..\..\Areas\PortalIPS\Views\Advertisement\_\Edit.cshtml"
Write(RenderPage("~/Areas/PortalIPS/Views/Advertisement/Extend/Model_FormJs.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
