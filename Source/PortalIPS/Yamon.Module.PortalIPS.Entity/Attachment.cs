
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.ComponentModel;
using Yamon.Framework.Common.DataBase;

namespace Yamon.Module.PortalIPS.Entity
{
    /// <summary>
    /// 附件模型实体类
    /// </summary>
    [Serializable]
    [Table("Attachment")]
    public partial class Attachment
    {
        public Attachment()
        { }

        #region Model

        
        /// <summary>
        /// 附件编号
        /// </summary>
       [Column(isPrimaryKey: true, isIdentity: false)]
       [DisplayName("附件编号")]
       public string AttachmentID
        {
            set;
            get;
        }

        /// <summary>
        /// 显示名称
        /// </summary>
       [DisplayName("显示名称")]
       public string DisplayFileName
        {
            set;
            get;
        }

        /// <summary>
        /// 物理文件名
        /// </summary>
       [DisplayName("物理文件名")]
       public string PhysicalFileName
        {
            set;
            get;
        }

        /// <summary>
        /// 文件访问地址
        /// </summary>
       [DisplayName("文件访问地址")]
       public string PhysicalFileUrl
        {
            set;
            get;
        }

        /// <summary>
        /// 文件存储路径
        /// </summary>
       [DisplayName("文件存储路径")]
       public string PhysicalFilePath
        {
            set;
            get;
        }

        /// <summary>
        /// 下载次数
        /// </summary>
       [DisplayName("下载次数")]
       public int? DownloadCount
        {
            set;
            get;
        }

        /// <summary>
        /// 上传者
        /// </summary>
       [DisplayName("上传者")]
       public string Uploader
        {
            set;
            get;
        }

        /// <summary>
        /// 上传人
        /// </summary>
       [DisplayName("上传人")]
       public string UploaderName
        {
            set;
            get;
        }

        /// <summary>
        /// 上传时间
        /// </summary>
       [DisplayName("上传时间")]
       public DateTime? UploadTime
        {
            set;
            get;
        }

        /// <summary>
        /// 文件大小
        /// </summary>
       [DisplayName("文件大小")]
       public long? FileSize
        {
            set;
            get;
        }

        /// <summary>
        /// InfoGuid
        /// </summary>
       [Column(notMap:true)]
       [DisplayName("InfoGuid")]
       public string InfoGuid
        {
            set;
            get;
        }


        #endregion Model

        //(Table)
    }
}
