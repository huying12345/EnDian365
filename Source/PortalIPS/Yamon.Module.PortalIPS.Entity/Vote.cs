
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.ComponentModel;
using Yamon.Framework.Common.DataBase;

namespace Yamon.Module.PortalIPS.Entity
{
    /// <summary>
    /// 投票模型实体类
    /// </summary>
    [Serializable]
    [Table("Vote_Vote")]
    public partial class Vote
    {
        public Vote()
        { }

        #region Model

        
        /// <summary>
        /// ID
        /// </summary>
       [Column(isPrimaryKey: true, isIdentity: false)]
       [DisplayName("ID")]
       public string VoteID
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
        /// 站点编号
        /// </summary>
       [DisplayName("站点编号")]
       public string AppID
        {
            set;
            get;
        }

        /// <summary>
        /// 投票主题
        /// </summary>
       [DisplayName("投票主题")]
       public string VoteName
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
        /// 开始时间
        /// </summary>
       [DisplayName("开始时间")]
       public DateTime? StartTime
        {
            set;
            get;
        }

        /// <summary>
        /// 结束时间
        /// </summary>
       [DisplayName("结束时间")]
       public DateTime? EndTime
        {
            set;
            get;
        }

        /// <summary>
        /// 投票说明
        /// </summary>
       [DisplayName("投票说明")]
       public string VoteContent
        {
            set;
            get;
        }

        /// <summary>
        /// 总票数
        /// </summary>
       [DisplayName("总票数")]
       public int? VoteCount
        {
            set;
            get;
        }

        /// <summary>
        /// 可选项数目
        /// </summary>
       [DisplayName("可选项数目")]
       public int? MaxSelectNum
        {
            set;
            get;
        }

        /// <summary>
        /// 投票选项
        /// </summary>
       [Column(notMap:true)]
       [DisplayName("投票选项")]
       public string VoteItem
        {
            set;
            get;
        }


        #endregion Model

        //(Table)
    }
}
