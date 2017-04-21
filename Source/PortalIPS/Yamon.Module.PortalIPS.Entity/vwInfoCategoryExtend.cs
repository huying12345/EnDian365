
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.ComponentModel;
using Yamon.Framework.Common.DataBase;

namespace Yamon.Module.PortalIPS.Entity
{

    public partial class vwInfoCategory
    {

        /// 索引号
        /// </summary>
        [Column(notMap: true)]
        public string PageUrlExtend
        {
            set;
            get;
        }


    }
}
