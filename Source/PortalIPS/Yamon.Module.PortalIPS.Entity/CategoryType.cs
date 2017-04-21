
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.ComponentModel;
using Yamon.Framework.Common.DataBase;

namespace Yamon.Module.PortalIPS.Entity
{
    /// <summary>
    /// 栏目类型模型实体类
    /// </summary>
    [Serializable]
    [Table("CategoryType")]
    public partial class CategoryType
    {
        public CategoryType()
        { }

        #region Model

        
        /// <summary>
        /// 编码名称
        /// </summary>
       [Column(isPrimaryKey: true, isIdentity: false)]
       [DisplayName("编码名称")]
       public string TypeName
        {
            set;
            get;
        }

        /// <summary>
        /// 名称
        /// </summary>
       [DisplayName("名称")]
       public string DisplayName
        {
            set;
            get;
        }

        /// <summary>
        /// 序号
        /// </summary>
       [DisplayName("序号")]
       public string Description
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


        #endregion Model

        //(Table)
    }
}
