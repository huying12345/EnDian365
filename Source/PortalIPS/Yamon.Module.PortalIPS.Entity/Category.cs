
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.ComponentModel;
using Yamon.Framework.Common.DataBase;

namespace Yamon.Module.PortalIPS.Entity
{
    /// <summary>
    /// 栏目管理实体类
    /// </summary>
    [Serializable]
    [Table("Category")]
    public partial class Category
    {
        public Category()
        { }

        #region Model

        
        /// <summary>
        /// 父级栏目名称
        /// </summary>
       [DisplayName("父级栏目名称")]
       public string C_ParentID
        {
            set;
            get;
        }
       [Column(notMap:true)]
       [DisplayName("父级栏目名称")]
       public string C_ParentID_ShowValue
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
        /// 栏目ID
        /// </summary>
       [Column(isPrimaryKey: true, isIdentity: false)]
       [DisplayName("栏目ID")]
       public string CategoryID
        {
            set;
            get;
        }

        /// <summary>
        /// 栏目名称
        /// </summary>
       [DisplayName("栏目名称")]
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
       /// 栏目图片
       /// </summary>
       [DisplayName("栏目图片")]
       public string imgSrc
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
       [Column(notMap:true)]
       [DisplayName("栏目类型")]
       public string CategoryType_ShowValue
        {
            set;
            get;
        }

        /// <summary>
        /// 栏目类型
        /// </summary>
       [DisplayName("栏目类型")]
       public string BackNvarchar2
        {
            set;
            get;
        }
       [Column(notMap:true)]
       [DisplayName("栏目类型")]
       public string BackNvarchar2_ShowValue
        {
            set;
            get;
        }

        /// <summary>
        /// 栏目显示类型
        /// </summary>
       [DisplayName("栏目显示类型")]
       public int? IsJournal
        {
            set;
            get;
        }
       [Column(notMap:true)]
       [DisplayName("栏目显示类型")]
       public string IsJournal_ShowValue
        {
            set;
            get;
        }

        /// <summary>
        /// 信息类型
        /// </summary>
       [DisplayName("信息类型")]
       public string CategoryInfoType
        {
            set;
            get;
        }
       [Column(notMap:true)]
       [DisplayName("信息类型")]
       public string CategoryInfoType_ShowValue
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
        /// 栏目标识
        /// </summary>
       [DisplayName("栏目标识")]
       public string IconName
        {
            set;
            get;
        }

        /// <summary>
        /// 栏目图片
        /// </summary>
       [DisplayName("栏目图片")]
       public string IconPath
        {
            set;
            get;
        }

        /// <summary>
        /// 是否启用
        /// </summary>
       [DisplayName("是否启用")]
       public int? Flag
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
        /// IsOpened
        /// </summary>
       [DisplayName("IsOpened")]
       public string IsOpened
        {
            set;
            get;
        }

        /// <summary>
        /// 映射栏目编号
        /// </summary>
       [DisplayName("映射栏目编号")]
       public string BackNvarchar
        {
            set;
            get;
        }

        /// <summary>
        /// 是否需要发布
        /// </summary>
       [DisplayName("是否需要发布")]
       public string BackNvarchar1
        {
            set;
            get;
        }
       [Column(notMap:true)]
       [DisplayName("是否需要发布")]
       public string BackNvarchar1_ShowValue
        {
            set;
            get;
        }

        /// <summary>
        /// BackInt
        /// </summary>
       [DisplayName("BackInt")]
       public int? BackInt
        {
            set;
            get;
        }

        /// <summary>
        /// 网站编码
        /// </summary>
       [DisplayName("网站编码")]
       public string AppID
        {
            set;
            get;
        }

        /// <summary>
        /// 栏目路径
        /// </summary>
       [DisplayName("栏目路径")]
       public string CategoryPath
        {
            set;
            get;
        }

        /// <summary>
        /// 模板目录
        /// </summary>
       [DisplayName("模板目录")]
       public string TemplatePath
        {
            set;
            get;
        }

        /// <summary>
        /// 栏目主页模板
        /// </summary>
       [DisplayName("栏目主页模板")]
       public string IndexTemplate
        {
            set;
            get;
        }

        /// <summary>
        /// 栏目列表页模板
        /// </summary>
       [DisplayName("栏目列表页模板")]
       public string ListTemplate
        {
            set;
            get;
        }

        /// <summary>
        /// 栏目详细页模板
        /// </summary>
       [DisplayName("栏目详细页模板")]
       public string DetailTemplate
        {
            set;
            get;
        }

        /// <summary>
        /// 栏目导航地址
        /// </summary>
       [DisplayName("栏目导航地址")]
       public string LinkUrl
        {
            set;
            get;
        }

        /// <summary>
        /// 后台链接地址
        /// </summary>
       [DisplayName("后台链接地址")]
       public string ManageLinkUrl
        {
            set;
            get;
        }

        /// <summary>
        /// 栏目描述
        /// </summary>
       [DisplayName("栏目描述")]
       public string Description
        {
            set;
            get;
        }

        /// <summary>
        /// 是否设为热门专题
        /// </summary>
       [DisplayName("是否设为热门专题")]
       public int? IsTopMenuToPage
        {
            set;
            get;
        }
       [Column(notMap:true)]
       [DisplayName("是否设为热门专题")]
       public string IsTopMenuToPage_ShowValue
        {
            set;
            get;
        }


        #endregion Model

        //(TableTree)
            [Column(notMap:true)]
            [JsonProperty("children")]
            public List<Category> Children
            {
             get;
             set;
            }
            [Column(notMap: true)]
            public int ChildCount
            {
                get;
                set;
            }
            
            
            [Column(notMap: true)]
            [JsonProperty("state")]
            public string State
            {
                get
                {
                    return ChildCount > 0 ? "closed" : "open";
                }
            }
    }
}
