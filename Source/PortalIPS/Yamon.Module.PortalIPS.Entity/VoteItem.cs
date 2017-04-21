
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.ComponentModel;
using Yamon.Framework.Common.DataBase;

namespace Yamon.Module.PortalIPS.Entity
{
    /// <summary>
    /// 投票选项模型实体类
    /// </summary>
    [Serializable]
    [Table("Vote_VoteItem")]
    public partial class VoteItem
    {
        public VoteItem()
        { }

        #region Model

        
        /// <summary>
        /// 投票选项编号
        /// </summary>
       [Column(isPrimaryKey: true, isIdentity: false)]
       [DisplayName("投票选项编号")]
       public int? VoteItemID
        {
            set;
            get;
        }

        /// <summary>
        /// 关联键
        /// </summary>
       [DisplayName("关联键")]
       public string VoteID
        {
            set;
            get;
        }

        /// <summary>
        /// 投票名称
        /// </summary>
       [DisplayName("投票名称")]
       public string ItemName
        {
            set;
            get;
        }

        /// <summary>
        /// 权重
        /// </summary>
       [DisplayName("权重")]
       public int? Weight
        {
            set;
            get;
        }

        /// <summary>
        /// 总数
        /// </summary>
       [DisplayName("总数")]
       public int? VoteCount
        {
            set;
            get;
        }


        #endregion Model

        //(Table)
    }
}
