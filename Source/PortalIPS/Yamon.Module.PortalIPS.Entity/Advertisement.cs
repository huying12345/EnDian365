
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.ComponentModel;
using Yamon.Framework.Common.DataBase;

namespace Yamon.Module.PortalIPS.Entity
{
    /// <summary>
    /// 广告实体类
    /// </summary>
    [Serializable]
    [Table("Advertisement")]
    public partial class Advertisement
    {
        public Advertisement()
        { }

        #region Model

        
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
        /// 名称
        /// </summary>
       [DisplayName("名称")]
       public string Name
        {
            set;
            get;
        }

        /// <summary>
        /// 类型
        /// </summary>
       [DisplayName("类型")]
       public int? Type
        {
            set;
            get;
        }
       [Column(notMap:true)]
       [DisplayName("类型")]
       public string Type_ShowValue
        {
            set;
            get;
        }

        /// <summary>
        /// 状态
        /// </summary>
       [DisplayName("状态")]
       public int? Status
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
        /// 链接地址
        /// </summary>
       [DisplayName("链接地址")]
       public string Link
        {
            set;
            get;
        }

        /// <summary>
        /// 图片
        /// </summary>
       [DisplayName("图片")]
       public string Url
        {
            set;
            get;
        }

        /// <summary>
        /// 内容
        /// </summary>
       [DisplayName("内容")]
       public string Count
        {
            set;
            get;
        }

        /// <summary>
        /// 宽度
        /// </summary>
       [DisplayName("宽度")]
       public int? Width
        {
            set;
            get;
        }

        /// <summary>
        /// 高度
        /// </summary>
       [DisplayName("高度")]
       public int? Height
        {
            set;
            get;
        }

        /// <summary>
        /// 距左距离
        /// </summary>
       [DisplayName("距左距离")]
       public int? PositionLeft
        {
            set;
            get;
        }

        /// <summary>
        /// 距顶距离
        /// </summary>
       [DisplayName("距顶距离")]
       public int? PositionTop
        {
            set;
            get;
        }

        /// <summary>
        /// 浮动速度
        /// </summary>
       [DisplayName("浮动速度")]
       public int? Velocity
        {
            set;
            get;
        }

        /// <summary>
        /// 所属站点
        /// </summary>
       [DisplayName("所属站点")]
       public string CityID
        {
            set;
            get;
        }


        #endregion Model

        //(Table)
    }
}
