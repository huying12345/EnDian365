using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yamon.Framework.Common;

namespace Yamon.Module.PortalIPS.DAL
{

    public class SiteCommonIPS
    {

        /// <summary>
        /// 获取网站根路径
        /// </summary>
        /// <param name="cityId"></param>
        /// <returns></returns>
        public static string GetBaseUrl()
        {
          
                return ConfigHelper.GetConfigString("BaseURI", "/");
           
        }


        /// <summary>
        /// 获取全路径
        /// </summary>
        /// <param name="cityId"></param>
        /// <returns></returns>
        public static string GetRootUrl()
        {
            return ConfigHelper.GetConfigString("WebUrl");
        }
    }
}
