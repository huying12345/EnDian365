
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.ComponentModel;
using Yamon.Framework.Common.DataBase;

namespace Yamon.Module.PortalIPS.Entity
{
    /// <summary>
    /// 友情链接模型实体类
    /// </summary>
    [Serializable]
    [Table("P_Links")]
    public partial class PLinks
    {
        public PLinks()
        { }

        #region Model

        
        /// <summary>
        /// ID
        /// </summary>
       [Column(isPrimaryKey: true, isIdentity: false)]
       [DisplayName("ID")]
       public int? LinkID
        {
            set;
            get;
        }

        /// <summary>
        /// 所属栏目
        /// </summary>
       [DisplayName("所属栏目")]
       public string CategoryID
        {
            set;
            get;
        }

        /// <summary>
        /// 站点名称
        /// </summary>
       [DisplayName("站点名称")]
       public string SiteName
        {
            set;
            get;
        }

        /// <summary>
        /// 站点地址
        /// </summary>
       [DisplayName("站点地址")]
       public string SiteUrl
        {
            set;
            get;
        }

        /// <summary>
        /// 顺序号
        /// </summary>
       [DisplayName("顺序号")]
       public int? OrderID
        {
            set;
            get;
        }

        /// <summary>
        /// 所属站点
        /// </summary>
       [DisplayName("所属站点")]
       public string AppID
        {
            set;
            get;
        }

        /// <summary>
        /// 站点Logo
        /// </summary>
       [DisplayName("站点Logo")]
       public string SiteLogo
        {
            set;
            get;
        }


        #endregion Model

        //(Table)
    }
}
