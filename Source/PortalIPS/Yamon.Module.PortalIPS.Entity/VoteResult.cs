
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.ComponentModel;
using Yamon.Framework.Common.DataBase;

namespace Yamon.Module.PortalIPS.Entity
{
    /// <summary>
    /// 投票结果模型实体类
    /// </summary>
    [Serializable]
    [Table("Vote_VoteResult")]
    public partial class VoteResult
    {
        public VoteResult()
        { }

        #region Model

        
        /// <summary>
        /// 结果编号
        /// </summary>
       [Column(isPrimaryKey: true, isIdentity: false)]
       [DisplayName("结果编号")]
       public int? VoteResultID
        {
            set;
            get;
        }

        /// <summary>
        /// 所属投票主题
        /// </summary>
       [DisplayName("所属投票主题")]
       public string VoteID
        {
            set;
            get;
        }

        /// <summary>
        /// VoteItemID
        /// </summary>
       [DisplayName("VoteItemID")]
       public int? VoteItemID
        {
            set;
            get;
        }

        /// <summary>
        /// 投票项
        /// </summary>
       [DisplayName("投票项")]
       public string VoteItem
        {
            set;
            get;
        }

        /// <summary>
        /// 投票会员编号
        /// </summary>
       [DisplayName("投票会员编号")]
       public int? UserID
        {
            set;
            get;
        }

        /// <summary>
        /// 投票IP
        /// </summary>
       [DisplayName("投票IP")]
       public string IP
        {
            set;
            get;
        }

        /// <summary>
        /// 投票时间
        /// </summary>
       [DisplayName("投票时间")]
       public DateTime? VoteTime
        {
            set;
            get;
        }

        /// <summary>
        /// Cookie
        /// </summary>
       [DisplayName("Cookie")]
       public string CookieKey
        {
            set;
            get;
        }


        #endregion Model

        //(Table)
    }
}
