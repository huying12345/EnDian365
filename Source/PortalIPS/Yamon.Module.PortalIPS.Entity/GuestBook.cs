
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.ComponentModel;
using Yamon.Framework.Common.DataBase;

namespace Yamon.Module.PortalIPS.Entity
{
    /// <summary>
    /// 留言模型实体类
    /// </summary>
    [Serializable]
    [Table("BS_GuestBook")]
    public partial class GuestBook
    {
        public GuestBook()
        { }

        #region Model

        
        /// <summary>
        /// 留言ID
        /// </summary>
       [Column(isPrimaryKey: true, isIdentity: true)]
       [DisplayName("留言ID")]
       public int? ID
        {
            set;
            get;
        }

        /// <summary>
        /// 用户名
        /// </summary>
       [DisplayName("用户名")]
       public string GuestName
        {
            set;
            get;
        }

        /// <summary>
        /// 留言内容
        /// </summary>
       [DisplayName("留言内容")]
       public string GuestContent
        {
            set;
            get;
        }

        /// <summary>
        /// 留言时间
        /// </summary>
       [DisplayName("留言时间")]
       public DateTime? CreateTime
        {
            set;
            get;
        }

        /// <summary>
        /// IsReply
        /// </summary>
       [DisplayName("IsReply")]
       public int? IsReply
        {
            set;
            get;
        }

        /// <summary>
        /// 管理员回复内容
        /// </summary>
       [DisplayName("管理员回复内容")]
       public string AdminReply
        {
            set;
            get;
        }

        /// <summary>
        /// 管理员回复日期
        /// </summary>
       [DisplayName("管理员回复日期")]
       public DateTime? AdminReplyTime
        {
            set;
            get;
        }

        /// <summary>
        /// 回复人
        /// </summary>
       [DisplayName("回复人")]
       public int? ReplyUserID
        {
            set;
            get;
        }
       [Column(notMap:true)]
       [DisplayName("回复人")]
       public string ReplyUserID_ShowValue
        {
            set;
            get;
        }


        #endregion Model

        //(Table)
    }
}
