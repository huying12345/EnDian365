
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.ComponentModel;
using Yamon.Framework.Common.DataBase;

namespace Yamon.Module.PortalIPS.Entity
{
    /// <summary>
    /// 信息内容视图实体类
    /// </summary>
    [Serializable]
    [Table("vwInfoCategory")]
    public partial class vwInfoCategory
    {
        public vwInfoCategory()
        { }

        #region Model

        
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
        /// ID
        /// </summary>
       [DisplayName("ID")]
       public string InfoGuid
        {
            set;
            get;
        }

        /// <summary>
        /// ID
        /// </summary>
       [Column(isPrimaryKey: true, isIdentity: true)]
       [DisplayName("ID")]
       public int? ID
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
        /// 副标题
        /// </summary>
       [DisplayName("副标题")]
       public string SubTitle
        {
            set;
            get;
        }

        /// <summary>
        /// 显示时间
        /// </summary>
       [DisplayName("显示时间")]
       public DateTime? ShowTime
        {
            set;
            get;
        }
       [Column(notMap:true)]
       [DisplayName("显示时间")]
       public string ShowTime_ShowValue
        {
            set;
            get;
        }

        /// <summary>
        /// 作者
        /// </summary>
       [DisplayName("作者")]
       public string Author
        {
            set;
            get;
        }

        /// <summary>
        /// 来源
        /// </summary>
       [DisplayName("来源")]
       public string Source
        {
            set;
            get;
        }

        /// <summary>
        /// 来源网址
        /// </summary>
       [DisplayName("来源网址")]
       public string SourceUrl
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
        /// 信息摘要
        /// </summary>
       [DisplayName("信息摘要")]
       public string Description
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
        /// 其他图片
        /// </summary>
       [DisplayName("其他图片")]
       public string BackNvarchar1
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
        /// 发布人
        /// </summary>
       [DisplayName("发布人")]
       public string Creator
        {
            set;
            get;
        }

        /// <summary>
        /// 创建人
        /// </summary>
       [DisplayName("创建人")]
       public string CreatorName
        {
            set;
            get;
        }

        /// <summary>
        /// 创建时间
        /// </summary>
       [DisplayName("创建时间")]
       public DateTime? CreateTime
        {
            set;
            get;
        }

        /// <summary>
        /// 创建部门编号
        /// </summary>
       [DisplayName("创建部门编号")]
       public string GroupID
        {
            set;
            get;
        }

        /// <summary>
        /// 访问次数
        /// </summary>
       [DisplayName("访问次数")]
       public int? ViewCount_Info
        {
            set;
            get;
        }

        /// <summary>
        /// 是否有效
        /// </summary>
       [DisplayName("是否有效")]
       public bool? BackBoolean
        {
            set;
            get;
        }
       [Column(notMap:true)]
       [DisplayName("是否有效")]
       public string BackBoolean_ShowValue
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

        /// <summary>
        /// BackBoolean2
        /// </summary>
       [DisplayName("BackBoolean2")]
       public bool? BackBoolean2
        {
            set;
            get;
        }

        /// <summary>
        /// BackBoolean3
        /// </summary>
       [DisplayName("BackBoolean3")]
       public bool? BackBoolean3
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
        /// BackNvarchar2
        /// </summary>
       [DisplayName("BackNvarchar2")]
       public string BackNvarchar2
        {
            set;
            get;
        }

        /// <summary>
        /// 友情链接
        /// </summary>
       [DisplayName("友情链接")]
       public string BackNvarchar4
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
        /// BackInt3
        /// </summary>
       [DisplayName("BackInt3")]
       public int? BackInt3
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
        /// 图标名称
        /// </summary>
       [DisplayName("图标名称")]
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
        /// 最后修改角色
        /// </summary>
       [DisplayName("最后修改角色")]
       public string LastModifier
        {
            set;
            get;
        }

        /// <summary>
        /// 最后修改人
        /// </summary>
       [DisplayName("最后修改人")]
       public string LastModifierName
        {
            set;
            get;
        }

        /// <summary>
        /// 最后修改时间
        /// </summary>
       [DisplayName("最后修改时间")]
       public DateTime? LastModifyTime
        {
            set;
            get;
        }

        /// <summary>
        /// 审核角色
        /// </summary>
       [DisplayName("审核角色")]
       public string Auditor
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
        /// 审核时间
        /// </summary>
       [DisplayName("审核时间")]
       public DateTime? AuditTime
        {
            set;
            get;
        }

        /// <summary>
        /// 发布角色
        /// </summary>
       [DisplayName("发布角色")]
       public string Publisher
        {
            set;
            get;
        }

        /// <summary>
        /// 发布人
        /// </summary>
       [DisplayName("发布人")]
       public string PublisherName
        {
            set;
            get;
        }

        /// <summary>
        /// 发布日期
        /// </summary>
       [DisplayName("发布日期")]
       public DateTime? PublishTime
        {
            set;
            get;
        }

        /// <summary>
        /// 创建部门
        /// </summary>
       [DisplayName("创建部门")]
       public string GroupName
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
        /// 排序
        /// </summary>
       [DisplayName("排序")]
       public int? BackInt
        {
            set;
            get;
        }

        /// <summary>
        /// 日志ID
        /// </summary>
       [DisplayName("日志ID")]
       public string JournalID
        {
            set;
            get;
        }

        /// <summary>
        /// 栏目ID
        /// </summary>
       [DisplayName("栏目ID")]
       public string CategoryID
        {
            set;
            get;
        }

        /// <summary>
        /// 所属栏目
        /// </summary>
       [DisplayName("所属栏目")]
       public string CategoryName
        {
            set;
            get;
        }

        /// <summary>
        /// 显示名称
        /// </summary>
       [DisplayName("显示名称")]
       public string DisplayName
        {
            set;
            get;
        }
       
        /// <summary>
        /// 栏目类型
        /// </summary>
       [DisplayName("栏目类型")]
       public string CategoryType
        {
            set;
            get;
        }

        /// <summary>
        /// 是否创建日志
        /// </summary>
       [DisplayName("是否创建日志")]
       public string IsJournal
        {
            set;
            get;
        }

        /// <summary>
        /// 父级ID
        /// </summary>
       [DisplayName("父级ID")]
       public string ParentID
        {
            set;
            get;
        }

        /// <summary>
        /// 是否启用
        /// </summary>
       [DisplayName("是否启用")]
       public string Flag
        {
            set;
            get;
        }
       [Column(notMap:true)]
       [DisplayName("是否启用")]
       public string Flag_ShowValue
        {
            set;
            get;
        }

        /// <summary>
        /// 排序ID
        /// </summary>
       [DisplayName("排序ID")]
       public int? OrderNum
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
        /// 视频地址
        /// </summary>
       [DisplayName("视频地址")]
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


        #endregion Model

        //(Table)
    }
}
