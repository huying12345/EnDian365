
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.ComponentModel;
using Yamon.Framework.Common.DataBase;

namespace Yamon.Module.PortalIPS.Entity
{
    /// <summary>
    /// 信息内容类型管理实体类
    /// </summary>
    [Serializable]
    [Table("InfoType")]
    public partial class InfoType
    {
        public InfoType()
        { }

        #region Model

        
        /// <summary>
        /// 编码名称
        /// </summary>
       [Column(isPrimaryKey: true, isIdentity: false)]
       [DisplayName("编码名称")]
       public string InfoTypeName
        {
            set;
            get;
        }

        /// <summary>
        /// 显示名称
        /// </summary>
       [DisplayName("显示名称")]
       public string InfoTypeDisplayName
        {
            set;
            get;
        }

        /// <summary>
        /// 排序ID
        /// </summary>
       [DisplayName("排序ID")]
       public int? InfoTypeOrderNum
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
        /// 访问类型
        /// </summary>
       [DisplayName("访问类型")]
       public string AppType
        {
            set;
            get;
        }


        #endregion Model

        //(Table)
    }
}
