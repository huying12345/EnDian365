
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.ComponentModel;
using Yamon.Framework.Common.DataBase;

namespace Yamon.Module.PortalIPS.Entity
{
    /// <summary>
    /// 信息内容实体类
    /// </summary>
    [Serializable]
    [Table("Information")]
    public partial class SMB_Information
    {
        public SMB_Information()
        { }

        #region Model

        
        /// <summary>
        /// 信息编号
        /// </summary>
       [Column(isPrimaryKey: true, isIdentity: false)]
       [DisplayName("信息编号")]
       public string InfoGuid
        {
            set;
            get;
        }

        /// <summary>
        /// 信息来源链接
        /// </summary>
       [DisplayName("信息来源链接")]
       public string SourceUrl
        {
            set;
            get;
        }

        /// <summary>
        /// 所属栏目
        /// </summary>
       [Column(notMap:true)]
       [DisplayName("所属栏目")]
       public string CategoryID
        {
            set;
            get;
        }
       [Column(notMap:true)]
       [DisplayName("所属栏目")]
       public string CategoryID_ShowValue
        {
            set;
            get;
        }

        /// <summary>
        /// 信息类型
        /// </summary>
       [DisplayName("信息类型")]
       public string InfoType
        {
            set;
            get;
        }
       [Column(notMap:true)]
       [DisplayName("信息类型")]
       public string InfoType_ShowValue
        {
            set;
            get;
        }

        /// <summary>
        /// 审核人
        /// </summary>
       [DisplayName("审核人")]
       public string AuditorName
        {
            set;
            get;
        }

        /// <summary>
        /// 文号
        /// </summary>
       [DisplayName("文号")]
       public string BackNvarchar2
        {
            set;
            get;
        }

        /// <summary>
        /// 索引号
        /// </summary>
       [DisplayName("索引号")]
       public string BackNvarchar3
        {
            set;
            get;
        }

        /// <summary>
        /// 标题
        /// </summary>
       [DisplayName("标题")]
       public string Title
        {
            set;
            get;
        }

        /// <summary>
        /// BackNvarchar
        /// </summary>
       [DisplayName("BackNvarchar")]
       public string BackNvarchar
        {
            set;
            get;
        }

        /// <summary>
        /// 副标题
        /// </summary>
       [DisplayName("副标题")]
       public string SubTitle
        {
            set;
            get;
        }

        /// <summary>
        /// AppID
        /// </summary>
       [DisplayName("AppID")]
       public string AppID
        {
            set;
            get;
        }

        /// <summary>
        /// 显示日期
        /// </summary>
       [DisplayName("显示日期")]
       public DateTime? ShowTime
        {
            set;
            get;
        }
       [Column(notMap:true)]
       [DisplayName("显示日期")]
       public string ShowTime_ShowValue
        {
            set;
            get;
        }

        /// <summary>
        /// 讲者
        /// </summary>
       [DisplayName("讲者")]
       public string Author
        {
            set;
            get;
        }

        /// <summary>
        /// 信息来源
        /// </summary>
       [DisplayName("信息来源")]
       public string Source
        {
            set;
            get;
        }

        /// <summary>
        /// 关键字
        /// </summary>
       [DisplayName("关键字")]
       public string Keywords
        {
            set;
            get;
        }

        /// <summary>
        /// 首页图片
        /// </summary>
       [DisplayName("首页图片")]
       public string MediaFileName
        {
            set;
            get;
        }

        /// <summary>
        /// 发布人用户名
        /// </summary>
       [DisplayName("发布人用户名")]
       public string Creator
        {
            set;
            get;
        }

        /// <summary>
        /// 发布人
        /// </summary>
       [DisplayName("发布人")]
       public string CreatorName
        {
            set;
            get;
        }

        /// <summary>
        /// 发布时间
        /// </summary>
       [DisplayName("发布时间")]
       public DateTime? CreateTime
        {
            set;
            get;
        }

        /// <summary>
        /// 部门编号
        /// </summary>
       [DisplayName("部门编号")]
       public string GroupID
        {
            set;
            get;
        }

        /// <summary>
        /// 发布部门
        /// </summary>
       [DisplayName("发布部门")]
       public string GroupName
        {
            set;
            get;
        }

        /// <summary>
        /// 最后编辑人用户名
        /// </summary>
       [DisplayName("最后编辑人用户名")]
       public string LastModifier
        {
            set;
            get;
        }

        /// <summary>
        /// 最后编辑人
        /// </summary>
       [DisplayName("最后编辑人")]
       public string LastModifierName
        {
            set;
            get;
        }

        /// <summary>
        /// 经文
        /// </summary>
       [DisplayName("经文")]
       public string Description
        {
            set;
            get;
        }

        /// <summary>
        /// 最后编辑时间
        /// </summary>
       [DisplayName("最后编辑时间")]
       public DateTime? LastModifyTime
        {
            set;
            get;
        }

        /// <summary>
        /// 内容
        /// </summary>
       [DisplayName("内容")]
       public string ContentNoHTML
        {
            set;
            get;
        }

        /// <summary>
        /// 审核人编号
        /// </summary>
       [DisplayName("审核人编号")]
       public string Auditor
        {
            set;
            get;
        }

        /// <summary>
        /// 审核时间
        /// </summary>
       [DisplayName("审核时间")]
       public DateTime? AuditTime
        {
            set;
            get;
        }

        /// <summary>
        /// 状态
        /// </summary>
       [DisplayName("状态")]
       public string Status
        {
            set;
            get;
        }
       [Column(notMap:true)]
       [DisplayName("状态")]
       public string Status_ShowValue
        {
            set;
            get;
        }

        /// <summary>
        /// 点击次数
        /// </summary>
       [DisplayName("点击次数")]
       public int? ViewCount
        {
            set;
            get;
        }

        /// <summary>
        /// SendToUserNames
        /// </summary>
       [DisplayName("SendToUserNames")]
       public string SendToUserNames
        {
            set;
            get;
        }

        /// <summary>
        /// SendToGroupNames
        /// </summary>
       [DisplayName("SendToGroupNames")]
       public string SendToGroupNames
        {
            set;
            get;
        }

        /// <summary>
        /// 是否有效
        /// </summary>
       [DisplayName("是否有效")]
       public int? BackBoolean
        {
            set;
            get;
        }

        /// <summary>
        /// 突出显示
        /// </summary>
       [DisplayName("突出显示")]
       public int? BackBoolean1
        {
            set;
            get;
        }
       [Column(notMap:true)]
       [DisplayName("突出显示")]
       public string BackBoolean1_ShowValue
        {
            set;
            get;
        }

        /// <summary>
        /// 排序号
        /// </summary>
       [DisplayName("排序号")]
       public int? BackInt
        {
            set;
            get;
        }

        /// <summary>
        /// BackNvarchar1
        /// </summary>
       [DisplayName("BackNvarchar1")]
       public string BackNvarchar1
        {
            set;
            get;
        }

        /// <summary>
        /// 链接地址
        /// </summary>
       [DisplayName("链接地址")]
       public string BackNvarchar4
        {
            set;
            get;
        }

        /// <summary>
        /// BackInt1
        /// </summary>
       [DisplayName("BackInt1")]
       public int? BackInt1
        {
            set;
            get;
        }

        /// <summary>
        /// BackInt2
        /// </summary>
       [DisplayName("BackInt2")]
       public int? BackInt2
        {
            set;
            get;
        }

        /// <summary>
        /// 是否列表显示
        /// </summary>
       [DisplayName("是否列表显示")]
       public int? BackInt3
        {
            set;
            get;
        }
       [Column(notMap:true)]
       [DisplayName("是否列表显示")]
       public string BackInt3_ShowValue
        {
            set;
            get;
        }

        /// <summary>
        /// IconName
        /// </summary>
       [DisplayName("IconName")]
       public string IconName
        {
            set;
            get;
        }

        /// <summary>
        /// 页面名称
        /// </summary>
       [DisplayName("页面名称")]
       public string PageName
        {
            set;
            get;
        }

        /// <summary>
        /// TalkGuid
        /// </summary>
       [DisplayName("TalkGuid")]
       public string TalkGuid
        {
            set;
            get;
        }

        /// <summary>
        /// 视频音频地址
        /// </summary>
       [DisplayName("视频音频地址")]
       public string VideoUrl
        {
            set;
            get;
        }

        /// <summary>
        /// 内容
        /// </summary>
       [DisplayName("内容")]
       public string Content
        {
            set;
            get;
        }

        /// <summary>
        /// 附件
        /// </summary>
       [Column(notMap:true)]
       [DisplayName("附件")]
       public string Attachment
        {
            set;
            get;
        }
       [Column(notMap:true)]
       [DisplayName("附件")]
       public string Attachment_ShowValue
        {
            set;
            get;
        }


        #endregion Model

        //(Table)
    }
}
