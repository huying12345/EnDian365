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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Home/config.cshtml")]
    public partial class _Views_Home_config_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Home_config_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Home\config.cshtml"
   ViewBag.Title = "config"; 
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<!DOCTYPE HTML PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3" +
".org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">\r\n<html");

WriteLiteral(" xmlns=\"http://www.w3.org/1999/xhtml\"");

WriteLiteral(">\r\n\r\n<head>\r\n    <title>系统参数设置</title>\r\n");

WriteLiteral("    ");

            
            #line 8 "..\..\Views\Home\config.cshtml"
Write(RenderPage("~/Views/includeM/head.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    <script");

WriteLiteral(" src=\"/Static/manage/js/checkfrom.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteAttribute("src", Tuple.Create(" src=\"", 382), Tuple.Create("\"", 422)
, Tuple.Create(Tuple.Create("", 388), Tuple.Create<System.Object, System.Int32>(Href("~/assets/libs/jquery.idTabs.min.js")
, 388), false)
);

WriteLiteral("></script>\r\n</head>\r\n\r\n<body>\r\n\r\n    <div");

WriteLiteral(" class=\"place\"");

WriteLiteral(">\r\n        <span>位置：</span>\r\n        <ul");

WriteLiteral(" class=\"placeul\"");

WriteLiteral(">\r\n            <li>基本信息</li>\r\n            <li>管理页面</li>\r\n        </ul>\r\n    </div" +
">\r\n\r\n    <div");

WriteLiteral(" class=\"formbody\"");

WriteLiteral("> \r\n        <div");

WriteLiteral(" id=\"usual1\"");

WriteLiteral(" class=\"usual\"");

WriteLiteral(">\r\n\r\n            <div");

WriteLiteral(" class=\"itab\"");

WriteLiteral(">\r\n                <ul>\r\n                    <li>\r\n                        <a");

WriteLiteral(" href=\"#tab1\"");

WriteLiteral(" class=\"selected\"");

WriteLiteral(">基本信息</a>\r\n                    </li>\r\n                    <li>\r\n                 " +
"       <a");

WriteLiteral(" href=\"#tab2\"");

WriteLiteral(">上传参数</a>\r\n                    </li>\r\n                    <li>\r\n                 " +
"       <a");

WriteLiteral(" href=\"#tab3\"");

WriteLiteral(">SEO设置</a>\r\n                    </li>\r\n                    <li>\r\n                " +
"        <a");

WriteLiteral(" href=\"#tab4\"");

WriteLiteral(">第三方安装代码</a>\r\n                    </li>\r\n                </ul>\r\n            </div" +
">\r\n            <form");

WriteLiteral(" action=\"\"");

WriteLiteral(" method=\"post\"");

WriteLiteral(" name=\"myform\"");

WriteLiteral(" id=\"myform\"");

WriteLiteral(" enctype=\"multipart/form-data\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"delimg\"");

WriteLiteral(" value=\"2015071815135373.png\"");

WriteLiteral(" />\r\n                <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"delimg2\"");

WriteLiteral(" value=\"2015071509322045.jpg\"");

WriteLiteral(" />\r\n                <div");

WriteLiteral(" id=\"tab1\"");

WriteLiteral(" class=\"tabson\"");

WriteLiteral(">\r\n\r\n                    <div");

WriteLiteral(" class=\"formtext\"");

WriteLiteral(">Hi，<b>admin</b>，欢迎您使用信息发布功能！</div>\r\n                    <ul");

WriteLiteral(" class=\"forminfo\"");

WriteLiteral(">\r\n                        <li><label");

WriteLiteral(" style=\"width:110px;\"");

WriteLiteral(">网站名称<b>*</b></label><input");

WriteLiteral(" name=\"sitename\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"dfinput\"");

WriteLiteral(" value=\"上海珺意科技股份有限公司\"");

WriteLiteral(" style=\"width:518px;\"");

WriteLiteral(" /></li>\r\n\r\n                        <li>\r\n                            <label");

WriteLiteral(" style=\"width:110px;\"");

WriteLiteral(">网站LOGO<b>*</b></label><cite>\r\n                                <input");

WriteLiteral(" name=\"img1\"");

WriteLiteral(" type=\"file\"");

WriteLiteral(" id=\"img1\"");

WriteLiteral(" /> <a");

WriteLiteral(" href=\"../uploadfile/upload/2015071815135373.png\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">查看图片</a>  <input");

WriteLiteral(" name=\"isdel1\"");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" class=radio");

WriteLiteral(" id=\"isdel1\"");

WriteLiteral(" value=\"1\"");

WriteLiteral(" /> 删除 <font");

WriteLiteral(" color=\"red\"");

WriteLiteral(">*请上传png透明底图,尺寸:215*80像素</font>\r\n                            </cite>\r\n           " +
"             </li>\r\n\r\n                        <li>\r\n                            " +
"<label");

WriteLiteral(" style=\"width:110px;\"");

WriteLiteral(">下拉菜单</label><cite>\r\n                                <input");

WriteLiteral(" type=\"radio\"");

WriteLiteral(" name=\"ismenu\"");

WriteLiteral(" value=\"0\"");

WriteLiteral(" checked=checked");

WriteLiteral(" /> 开启</input>\r\n                                <input");

WriteLiteral(" type=\"radio\"");

WriteLiteral(" name=\"ismenu\"");

WriteLiteral(" value=\"1\"");

WriteLiteral(" /> 关闭</input>\r\n                            </cite>\r\n                        </li" +
">\r\n\r\n                        <li>\r\n                            <label");

WriteLiteral(" style=\"width:110px;\"");

WriteLiteral(">在线QQ</label><cite>\r\n                                <input");

WriteLiteral(" type=\"radio\"");

WriteLiteral(" name=\"isqq\"");

WriteLiteral(" value=\"0\"");

WriteLiteral(" checked=checked");

WriteLiteral(" /> 开启</input>\r\n                                <input");

WriteLiteral(" type=\"radio\"");

WriteLiteral(" name=\"isqq\"");

WriteLiteral(" value=\"1\"");

WriteLiteral(" /> 关闭</input>\r\n                            </cite>\r\n                        </li" +
">\r\n\r\n                        <li>\r\n                            <label");

WriteLiteral(" style=\"padding-right:300px;\"");

WriteLiteral(@">
                                <script>
                                    function doroom() {
                                        var i;
                                        var str = """";
                                        var oldi = 0;
                                        var j = 0;
                                        oldi = parseInt(document.myform.oeditroomnum.value);
                                        for (i = 1; i <= document.myform.oroomnum.value; i++) {
                                            j = i + oldi;
                                            str = str + ""<tr><td>QQ号：<input name=oqq[] value='' class='dfinput' style='width:150px'> 名称：<input name=otitle[] value='' class='dfinput' style='width:100px'></td></tr>"";
                                        }
                                        document.getElementById(""addroom"").innerHTML = ""<table width='100%'>"" + str + ""</table>"";
                                    }
                                </script>
                                <table");

WriteLiteral(" width=\"500\"");

WriteLiteral(">\r\n                                    <tr>\r\n                                    " +
"    <td>\r\n                                            <input");

WriteLiteral(" value=\"2\"");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" name=\"odelpathid[]\"");

WriteLiteral(" />删 QQ号：<input");

WriteLiteral(" name=\"oqq[]\"");

WriteLiteral(" class=\"dfinput\"");

WriteLiteral(" style=\"width:150px;\"");

WriteLiteral(" value=\"1534996449\"");

WriteLiteral(" size=\"25\"");

WriteLiteral(" />\r\n                                            名称：<input");

WriteLiteral(" name=\"otitle[]\"");

WriteLiteral(" class=\"dfinput\"");

WriteLiteral(" style=\"width:100px;\"");

WriteLiteral(" value=\"售前咨询\"");

WriteLiteral(" size=\"25\"");

WriteLiteral(" />\r\n                                            <input");

WriteLiteral(" value=\"2\"");

WriteLiteral(" name=\"odownid[]\"");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" />\r\n                                            <font");

WriteLiteral(" color=\"red\"");

WriteLiteral(">*限4个字</font>\r\n                                        </td>\r\n                   " +
"                 </tr>\r\n                                    <tr>\r\n              " +
"                          <td>\r\n                                            <inp" +
"ut");

WriteLiteral(" value=\"3\"");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" name=\"odelpathid[]\"");

WriteLiteral(" />删 QQ号：<input");

WriteLiteral(" name=\"oqq[]\"");

WriteLiteral(" class=\"dfinput\"");

WriteLiteral(" style=\"width:150px;\"");

WriteLiteral(" value=\"123456788\"");

WriteLiteral(" size=\"25\"");

WriteLiteral(" />\r\n                                            名称：<input");

WriteLiteral(" name=\"otitle[]\"");

WriteLiteral(" class=\"dfinput\"");

WriteLiteral(" style=\"width:100px;\"");

WriteLiteral(" value=\"售后服务\"");

WriteLiteral(" size=\"25\"");

WriteLiteral(" />\r\n                                            <input");

WriteLiteral(" value=\"3\"");

WriteLiteral(" name=\"odownid[]\"");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" />\r\n                                            <font");

WriteLiteral(" color=\"red\"");

WriteLiteral(">*限4个字</font>\r\n                                        </td>\r\n                   " +
"                 </tr>\r\n                                    <tr>\r\n              " +
"                          <td>\r\n                                            再增加：" +
"<input");

WriteLiteral(" id=\"oeditroomnum\"");

WriteLiteral(" value=\"2\"");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"oeditroomnum\"");

WriteLiteral(" />\r\n                                            <input");

WriteLiteral(" id=\"oroomnum\"");

WriteLiteral(" value=\"1\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" name=\"oroomnum\"");

WriteLiteral(" class=\"dfinput\"");

WriteLiteral(" style=\"width:50px;\"");

WriteLiteral(" /> 个\r\n                                            <a");

WriteLiteral(" href=\"javascript:void()\"");

WriteLiteral(" onclick=\"javascript:doroom();\"");

WriteLiteral(">确认增加</a>\r\n                                        </td>\r\n                       " +
"             </tr>\r\n                                    <tr>\r\n                  " +
"                      <td");

WriteLiteral(" id=addroom");

WriteLiteral(">&nbsp;</td>\r\n                                    </tr>\r\n                        " +
"        </table>\r\n                            </label>\r\n                        " +
"</li>\r\n                        <li>\r\n                            <label");

WriteLiteral(" style=\"width:110px;\"");

WriteLiteral(">QQ下方二维码</label><cite>\r\n                                <input");

WriteLiteral(" type=\"radio\"");

WriteLiteral(" name=\"isweixin\"");

WriteLiteral(" value=\"0\"");

WriteLiteral(" checked=checked");

WriteLiteral(" /> 开启</input>\r\n                                <input");

WriteLiteral(" type=\"radio\"");

WriteLiteral(" name=\"isweixin\"");

WriteLiteral(" value=\"1\"");

WriteLiteral(" /> 关闭</input>\r\n                                <input");

WriteLiteral(" name=\"img2\"");

WriteLiteral(" type=\"file\"");

WriteLiteral(" id=\"img2\"");

WriteLiteral(" /> <a");

WriteLiteral(" href=\"../uploadfile/upload/2015071509322045.jpg\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">查看图片</a>  <input");

WriteLiteral(" name=\"isdel2\"");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" class=radio");

WriteLiteral(" id=\"isdel2\"");

WriteLiteral(" value=\"1\"");

WriteLiteral(" /> 删除\r\n                            </cite>\r\n                        </li>\r\n     " +
"                   <li><label");

WriteLiteral(" style=\"width:110px;\"");

WriteLiteral(">网站客服电话</label><input");

WriteLiteral(" name=\"phone\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"dfinput\"");

WriteLiteral(" value=\"\"");

WriteLiteral(" /></li>\r\n                        <li><label");

WriteLiteral(" style=\"width:110px;\"");

WriteLiteral(">网站邮箱</label><input");

WriteLiteral(" name=\"siteurl\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"dfinput\"");

WriteLiteral(" value=\"\"");

WriteLiteral(" /></li>\r\n                        <li><label");

WriteLiteral(" style=\"width:110px;\"");

WriteLiteral(">底部版权</label><textarea");

WriteLiteral(" id=\"copyright\"");

WriteLiteral(" name=\"copyright\"");

WriteLiteral(" style=\"width:520px;height:100px;\"");

WriteLiteral(" class=\"dfinput\"");

WriteLiteral(@"><p>地址：上海市虹口区汶水东路181弄三九大厦2号1206室   联系电话：400-0960305
                        </p></textarea></li>
                    </ul>
                </div>
                <p>Copyright 2015-2016 上海慧赟软件有限公司 版权所有 沪ICP备15052564号</p></textarea></li>
                <li><label");

WriteLiteral(" style=\"width:110px;\"");

WriteLiteral(">子页左侧联系方式</label><textarea");

WriteLiteral(" id=\"contact\"");

WriteLiteral(" name=\"contact\"");

WriteLiteral(" style=\"width:520px;height:100px;\"");

WriteLiteral(" class=\"dfinput\"");

WriteLiteral("></textarea></li>\r\n                </ul>\r\n            </form>\r\n        </div>\r\n\r\n" +
"        <div");

WriteLiteral(" id=\"tab2\"");

WriteLiteral(" class=\"tabson\"");

WriteLiteral(">\r\n            <ul");

WriteLiteral(" class=\"forminfo\"");

WriteLiteral(">\r\n                <li><label");

WriteLiteral(" style=\"width:110px;\"");

WriteLiteral(">文件类型<b>*</b></label><input");

WriteLiteral(" name=\"filetype\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"dfinput\"");

WriteLiteral(" value=\"pdf|doc|docx|rar|zip\"");

WriteLiteral(" style=\"width:518px;\"");

WriteLiteral(" /> 以|分隔后缀名,切记勿允许上传asp/exe文件</li>\r\n                <li><label");

WriteLiteral(" style=\"width:110px;\"");

WriteLiteral(">文件大小<b>*</b></label><input");

WriteLiteral(" name=\"filesize\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"dfinput\"");

WriteLiteral(" value=\"20480\"");

WriteLiteral(" style=\"width:518px;\"");

WriteLiteral(" /> K</li>\r\n                <li><label");

WriteLiteral(" style=\"width:110px;\"");

WriteLiteral(">图片类型<b>*</b></label><input");

WriteLiteral(" name=\"pictype\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"dfinput\"");

WriteLiteral(" value=\"gif|jpg|jpeg|png\"");

WriteLiteral(" style=\"width:518px;\"");

WriteLiteral(" /> 以|分隔后缀名,切记勿允许上传asp/exe文件</li>\r\n                <li><label");

WriteLiteral(" style=\"width:110px;\"");

WriteLiteral(">图片大小<b>*</b></label><input");

WriteLiteral(" name=\"picsize\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"dfinput\"");

WriteLiteral(" value=\"20480\"");

WriteLiteral(" style=\"width:518px;\"");

WriteLiteral(" /> K</li>\r\n            </ul>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" id=\"tab3\"");

WriteLiteral(" class=\"tabson\"");

WriteLiteral(">\r\n            <ul");

WriteLiteral(" class=\"forminfo\"");

WriteLiteral(">\r\n                <li><label");

WriteLiteral(" style=\"width:110px;\"");

WriteLiteral(">页面标题<b>*</b></label><input");

WriteLiteral(" name=\"seotitle\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"dfinput\"");

WriteLiteral(" value=\"\"");

WriteLiteral(" style=\"width:518px;\"");

WriteLiteral(" /></li>\r\n                <li><label");

WriteLiteral(" style=\"width:110px;\"");

WriteLiteral(">页面关键字<b>*</b></label><textarea");

WriteLiteral(" id=\"keywords\"");

WriteLiteral(" name=\"keywords\"");

WriteLiteral(" style=\"width:520px;height:100px;\"");

WriteLiteral(" class=\"dfinput\"");

WriteLiteral("></textarea></li>\r\n                <li><label");

WriteLiteral(" style=\"width:110px;\"");

WriteLiteral(">页面描述<b>*</b></label><textarea");

WriteLiteral(" id=\"description\"");

WriteLiteral(" name=\"description\"");

WriteLiteral(" style=\"width:520px;height:100px;\"");

WriteLiteral(" class=\"dfinput\"");

WriteLiteral("></textarea></li>\r\n            </ul>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" id=\"tab4\"");

WriteLiteral(" class=\"tabson\"");

WriteLiteral(">\r\n            <ul");

WriteLiteral(" class=\"forminfo\"");

WriteLiteral(">\r\n                <li><label>流量统计<b>*</b></label><textarea");

WriteLiteral(" id=\"visits\"");

WriteLiteral(" name=\"visits\"");

WriteLiteral(" style=\"width:520px;height:100px;\"");

WriteLiteral(" class=\"dfinput\"");

WriteLiteral("></textarea></li>\r\n                <li><label>在线客服<b>*</b></label><textarea");

WriteLiteral(" id=\"qq\"");

WriteLiteral(" name=\"qq\"");

WriteLiteral(" style=\"width:520px;height:100px;\"");

WriteLiteral(" class=\"dfinput\"");

WriteLiteral("></textarea></li>\r\n                <li><label>在线分享<b>*</b></label><textarea");

WriteLiteral(" id=\"share\"");

WriteLiteral(" name=\"share\"");

WriteLiteral(" style=\"width:520px;height:100px;\"");

WriteLiteral(" class=\"dfinput\"");

WriteLiteral("> </textarea></li>\r\n            </ul>\r\n        </div>\r\n\r\n        <li><label");

WriteLiteral(" style=\"width:110px;\"");

WriteLiteral(">&nbsp;</label><input");

WriteLiteral(" name=\"update\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn\"");

WriteLiteral(" value=\"马上修改\"");

WriteLiteral(" /></li>\r\n        </form>\r\n    </div>\r\n\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        $(\"#usual1 ul\").idTabs();\r\n    </script>\r\n\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        $(\'.tablelist tbody tr:odd\').addClass(\'odd\');\r\n    </script>\r\n\r\n    </" +
"div>\r\n\r\n</body>\r\n\r\n</html>");

        }
    }
}
#pragma warning restore 1591
