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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/PortalIPS/Views/SMB_Information/_/Show.cshtml")]
    public partial class _Areas_PortalIPS_Views_SMB_Information___Show_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_PortalIPS_Views_SMB_Information___Show_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 2 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Show.cshtml"
  
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

WriteLiteral(" region=\"center\"");

WriteLiteral(" border=\"true\"");

WriteLiteral(" style=\"padding: 10px; background: #F6F6F6; border: 1px solid #ccc;\"");

WriteLiteral(">\r\n    <form");

WriteLiteral(" id=\"myForm\"");

WriteLiteral(" name=\"myForm\"");

WriteLiteral(" action=\"/api/PortalIPS/SMB_Information/Show\"");

WriteLiteral(" method=\"post\"");

WriteLiteral(">\r\n        <table");

WriteLiteral(" class=\"mytable\"");

WriteLiteral("  cellpadding=\"1\"");

WriteLiteral(" width=\"100%\"");

WriteLiteral(" cellspacing=\"0\"");

WriteLiteral(" align=\"center\"");

WriteLiteral(">\r\n<tr");

WriteLiteral(" id=\"Container_InfoGuid\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">信息编号：</td><td>&nbsp;<span");

WriteLiteral(" id=\"InfoGuid\"");

WriteLiteral(">");

            
            #line 19 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Show.cshtml"
                                                        Write(Html.Raw(Model.InfoGuid));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">信息来源链接：</td><td>&nbsp;<span");

WriteLiteral(" id=\"SourceUrl\"");

WriteLiteral(">");

            
            #line 20 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Show.cshtml"
                                                           Write(Html.Raw(Model.SourceUrl));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_CategoryID\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">所属栏目：</td><td>&nbsp;<span");

WriteLiteral(" id=\"CategoryID\"");

WriteLiteral(">");

            
            #line 23 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Show.cshtml"
                                                          Write(Html.Raw(Model.CategoryID_ShowValue));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">信息类型：</td><td>&nbsp;<span");

WriteLiteral(" id=\"InfoType\"");

WriteLiteral(">");

            
            #line 24 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Show.cshtml"
                                                        Write(Html.Raw(Model.InfoType_ShowValue));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_AuditorName\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">审核人：</td><td>&nbsp;<span");

WriteLiteral(" id=\"AuditorName\"");

WriteLiteral(">");

            
            #line 27 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Show.cshtml"
                                                          Write(Html.Raw(Model.AuditorName));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">文号：</td><td>&nbsp;<span");

WriteLiteral(" id=\"BackNvarchar2\"");

WriteLiteral(">");

            
            #line 28 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Show.cshtml"
                                                           Write(Html.Raw(Model.BackNvarchar2));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_BackNvarchar3\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">索引号：</td><td>&nbsp;<span");

WriteLiteral(" id=\"BackNvarchar3\"");

WriteLiteral(">");

            
            #line 31 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Show.cshtml"
                                                            Write(Html.Raw(Model.BackNvarchar3));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n<td>&nbsp;</td><td>&nbsp;</td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_Title\"");

WriteLiteral(">\r\n<td");

WriteLiteral("  class=\"labeltd\"");

WriteLiteral(">标题：</td><td");

WriteLiteral("  colspan=\"3\"");

WriteLiteral(" >&nbsp;<span");

WriteLiteral(" id=\"Title\"");

WriteLiteral(">");

            
            #line 35 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Show.cshtml"
                                                                  Write(Html.Raw(Model.Title));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_BackNvarchar\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">BackNvarchar：</td><td>&nbsp;<span");

WriteLiteral(" id=\"BackNvarchar\"");

WriteLiteral(">");

            
            #line 38 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Show.cshtml"
                                                                    Write(Html.Raw(Model.BackNvarchar));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n<td>&nbsp;</td><td>&nbsp;</td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_SubTitle\"");

WriteLiteral(">\r\n<td");

WriteLiteral("  class=\"labeltd\"");

WriteLiteral(">副标题：</td><td");

WriteLiteral("  colspan=\"3\"");

WriteLiteral(" >&nbsp;<span");

WriteLiteral(" id=\"SubTitle\"");

WriteLiteral(">");

            
            #line 42 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Show.cshtml"
                                                                      Write(Html.Raw(Model.SubTitle));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_AppID\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">AppID：</td><td>&nbsp;<span");

WriteLiteral(" id=\"AppID\"");

WriteLiteral(">");

            
            #line 45 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Show.cshtml"
                                                      Write(Html.Raw(Model.AppID));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">显示日期：</td><td>&nbsp;<span");

WriteLiteral(" id=\"ShowTime\"");

WriteLiteral(">");

            
            #line 46 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Show.cshtml"
                                                        Write(Html.Raw(Model.ShowTime_ShowValue));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_Author\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">讲者：</td><td>&nbsp;<span");

WriteLiteral(" id=\"Author\"");

WriteLiteral(">");

            
            #line 49 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Show.cshtml"
                                                    Write(Html.Raw(Model.Author));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">信息来源：</td><td>&nbsp;<span");

WriteLiteral(" id=\"Source\"");

WriteLiteral(">");

            
            #line 50 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Show.cshtml"
                                                      Write(Html.Raw(Model.Source));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_Keywords\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">关键字：</td><td>&nbsp;<span");

WriteLiteral(" id=\"Keywords\"");

WriteLiteral(">");

            
            #line 53 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Show.cshtml"
                                                       Write(Html.Raw(Model.Keywords));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n<td>&nbsp;</td><td>&nbsp;</td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_MediaFileName\"");

WriteLiteral(">\r\n<td");

WriteLiteral("  class=\"labeltd\"");

WriteLiteral(">首页图片：</td><td");

WriteLiteral("  colspan=\"3\"");

WriteLiteral(" >&nbsp;<span");

WriteLiteral(" id=\"MediaFileName\"");

WriteLiteral(">");

            
            #line 57 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Show.cshtml"
                                                                            Write(Html.Raw(Model.MediaFileName));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_Creator\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">发布人用户名：</td><td>&nbsp;<span");

WriteLiteral(" id=\"Creator\"");

WriteLiteral(">");

            
            #line 60 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Show.cshtml"
                                                         Write(Html.Raw(Model.Creator));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">发布人：</td><td>&nbsp;<span");

WriteLiteral(" id=\"CreatorName\"");

WriteLiteral(">");

            
            #line 61 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Show.cshtml"
                                                          Write(Html.Raw(Model.CreatorName));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_CreateTime\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">发布时间：</td><td>&nbsp;<span");

WriteLiteral(" id=\"CreateTime\"");

WriteLiteral(">");

            
            #line 64 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Show.cshtml"
                                                          Write(Html.Raw(Model.CreateTime));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">部门编号：</td><td>&nbsp;<span");

WriteLiteral(" id=\"GroupID\"");

WriteLiteral(">");

            
            #line 65 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Show.cshtml"
                                                       Write(Html.Raw(Model.GroupID));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_GroupName\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">发布部门：</td><td>&nbsp;<span");

WriteLiteral(" id=\"GroupName\"");

WriteLiteral(">");

            
            #line 68 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Show.cshtml"
                                                         Write(Html.Raw(Model.GroupName));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">最后编辑人用户名：</td><td>&nbsp;<span");

WriteLiteral(" id=\"LastModifier\"");

WriteLiteral(">");

            
            #line 69 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Show.cshtml"
                                                                Write(Html.Raw(Model.LastModifier));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_LastModifierName\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">最后编辑人：</td><td>&nbsp;<span");

WriteLiteral(" id=\"LastModifierName\"");

WriteLiteral(">");

            
            #line 72 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Show.cshtml"
                                                                 Write(Html.Raw(Model.LastModifierName));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n<td>&nbsp;</td><td>&nbsp;</td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_Description\"");

WriteLiteral(">\r\n<td");

WriteLiteral("  class=\"labeltd\"");

WriteLiteral(">经文：</td><td");

WriteLiteral("  colspan=\"3\"");

WriteLiteral(" >&nbsp;<span");

WriteLiteral(" id=\"Description\"");

WriteLiteral(">");

            
            #line 76 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Show.cshtml"
                                                                        Write(Html.Raw(Model.Description));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_LastModifyTime\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">最后编辑时间：</td><td>&nbsp;<span");

WriteLiteral(" id=\"LastModifyTime\"");

WriteLiteral(">");

            
            #line 79 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Show.cshtml"
                                                                Write(Html.Raw(Model.LastModifyTime));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">内容：</td><td>&nbsp;<span");

WriteLiteral(" id=\"ContentNoHTML\"");

WriteLiteral(">");

            
            #line 80 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Show.cshtml"
                                                           Write(Html.Raw(Model.ContentNoHTML));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_Auditor\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">审核人编号：</td><td>&nbsp;<span");

WriteLiteral(" id=\"Auditor\"");

WriteLiteral(">");

            
            #line 83 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Show.cshtml"
                                                        Write(Html.Raw(Model.Auditor));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">审核时间：</td><td>&nbsp;<span");

WriteLiteral(" id=\"AuditTime\"");

WriteLiteral(">");

            
            #line 84 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Show.cshtml"
                                                         Write(Html.Raw(Model.AuditTime));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_Status\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">状态：</td><td>&nbsp;<span");

WriteLiteral(" id=\"Status\"");

WriteLiteral(">");

            
            #line 87 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Show.cshtml"
                                                    Write(Html.Raw(Model.Status_ShowValue));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">点击次数：</td><td>&nbsp;<span");

WriteLiteral(" id=\"ViewCount\"");

WriteLiteral(">");

            
            #line 88 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Show.cshtml"
                                                         Write(Html.Raw(Model.ViewCount));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_SendToUserNames\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">SendToUserNames：</td><td>&nbsp;<span");

WriteLiteral(" id=\"SendToUserNames\"");

WriteLiteral(">");

            
            #line 91 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Show.cshtml"
                                                                          Write(Html.Raw(Model.SendToUserNames));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">SendToGroupNames：</td><td>&nbsp;<span");

WriteLiteral(" id=\"SendToGroupNames\"");

WriteLiteral(">");

            
            #line 92 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Show.cshtml"
                                                                            Write(Html.Raw(Model.SendToGroupNames));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_BackBoolean\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">是否有效：</td><td>&nbsp;<span");

WriteLiteral(" id=\"BackBoolean\"");

WriteLiteral(">");

            
            #line 95 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Show.cshtml"
                                                           Write(Html.Raw(Model.BackBoolean));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">突出显示：</td><td>&nbsp;<span");

WriteLiteral(" id=\"BackBoolean1\"");

WriteLiteral(">");

            
            #line 96 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Show.cshtml"
                                                            Write(Html.Raw(Model.BackBoolean1_ShowValue));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_BackInt\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">排序号：</td><td>&nbsp;<span");

WriteLiteral(" id=\"BackInt\"");

WriteLiteral(">");

            
            #line 99 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Show.cshtml"
                                                      Write(Html.Raw(Model.BackInt));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">BackNvarchar1：</td><td>&nbsp;<span");

WriteLiteral(" id=\"BackNvarchar1\"");

WriteLiteral(">");

            
            #line 100 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Show.cshtml"
                                                                      Write(Html.Raw(Model.BackNvarchar1));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_BackNvarchar4\"");

WriteLiteral(">\r\n<td");

WriteLiteral("  class=\"labeltd\"");

WriteLiteral(">链接地址：</td><td");

WriteLiteral("  colspan=\"3\"");

WriteLiteral(" >&nbsp;<span");

WriteLiteral(" id=\"BackNvarchar4\"");

WriteLiteral(">");

            
            #line 103 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Show.cshtml"
                                                                            Write(Html.Raw(Model.BackNvarchar4));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_BackInt1\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">BackInt1：</td><td>&nbsp;<span");

WriteLiteral(" id=\"BackInt1\"");

WriteLiteral(">");

            
            #line 106 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Show.cshtml"
                                                            Write(Html.Raw(Model.BackInt1));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">BackInt2：</td><td>&nbsp;<span");

WriteLiteral(" id=\"BackInt2\"");

WriteLiteral(">");

            
            #line 107 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Show.cshtml"
                                                            Write(Html.Raw(Model.BackInt2));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_BackInt3\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">是否列表显示：</td><td>&nbsp;<span");

WriteLiteral(" id=\"BackInt3\"");

WriteLiteral(">");

            
            #line 110 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Show.cshtml"
                                                          Write(Html.Raw(Model.BackInt3_ShowValue));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">IconName：</td><td>&nbsp;<span");

WriteLiteral(" id=\"IconName\"");

WriteLiteral(">");

            
            #line 111 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Show.cshtml"
                                                            Write(Html.Raw(Model.IconName));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_PageName\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">页面名称：</td><td>&nbsp;<span");

WriteLiteral(" id=\"PageName\"");

WriteLiteral(">");

            
            #line 114 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Show.cshtml"
                                                        Write(Html.Raw(Model.PageName));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">TalkGuid：</td><td>&nbsp;<span");

WriteLiteral(" id=\"TalkGuid\"");

WriteLiteral(">");

            
            #line 115 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Show.cshtml"
                                                            Write(Html.Raw(Model.TalkGuid));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_VideoUrl\"");

WriteLiteral(">\r\n<td");

WriteLiteral("  class=\"labeltd\"");

WriteLiteral(">视频音频地址：</td><td");

WriteLiteral("  colspan=\"3\"");

WriteLiteral(" >&nbsp;<span");

WriteLiteral(" id=\"VideoUrl\"");

WriteLiteral(">");

            
            #line 118 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Show.cshtml"
                                                                         Write(Html.Raw(Model.VideoUrl));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_Content\"");

WriteLiteral(">\r\n<td");

WriteLiteral("  class=\"labeltd\"");

WriteLiteral(">内容：</td><td");

WriteLiteral("  colspan=\"3\"");

WriteLiteral(" >&nbsp;<span");

WriteLiteral(" id=\"Content\"");

WriteLiteral(">");

            
            #line 121 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Show.cshtml"
                                                                    Write(Html.Raw(Model.Content));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_Attachment\"");

WriteLiteral(">\r\n<td");

WriteLiteral("  class=\"labeltd\"");

WriteLiteral(">附件：</td><td");

WriteLiteral("  colspan=\"3\"");

WriteLiteral(" >&nbsp;<span");

WriteLiteral(" id=\"Attachment\"");

WriteLiteral(">");

            
            #line 124 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Show.cshtml"
                                                                       Write(Html.Raw(Model.Attachment_ShowValue));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n</tr>\r\n\r\n</table>\r\n\r\n");

WriteLiteral("        ");

            
            #line 129 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Show.cshtml"
   Write(RenderPage("~/Areas/PortalIPS/Views/SMB_Information/Extend/Model_ViewHtml.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </form>\r\n</div>\r\n<div");

WriteLiteral(" region=\"south\"");

WriteLiteral(" border=\"false\"");

WriteLiteral(" style=\"text-align: right; background: #F6F6F6;height: 30px; line-height: 30px;\"");

WriteLiteral(">\r\n    <a");

WriteLiteral(" id=\"btnCancel\"");

WriteLiteral(" class=\"easyui-linkbutton\"");

WriteLiteral(" icon=\"icon-cancel\"");

WriteLiteral(" href=\"javascript:CloseDialog();\"");

WriteLiteral(">\r\n        关闭\r\n    </a>\r\n</div>\r\n");

            
            #line 137 "..\..\Areas\PortalIPS\Views\SMB_Information\_\Show.cshtml"
Write(RenderPage("~/Areas/PortalIPS/Views/SMB_Information/Extend/Model_ViewJs.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

        }
    }
}
#pragma warning restore 1591