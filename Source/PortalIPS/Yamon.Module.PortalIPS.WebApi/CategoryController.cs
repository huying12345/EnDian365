
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;
using System.IO;
using System.Linq.Expressions;
using System.Web.Mvc;
using Yamon.Framework.DAL;
using Yamon.Module.PortalIPS.Entity;
using Yamon.Module.PortalIPS.DAL;
using Newtonsoft.Json;
using Yamon.Framework.Common;
using Yamon.Module.SiteManage.DAL;
using Yamon.Framework.MVC;



namespace Yamon.Module.PortalIPS.WebApi
{
    /// <summary>
    /// 栏目管理
    /// </summary>
    public partial class CategoryController : _CategoryController
    {
        [CheckPurview(0)]
        public ActionResult GetMyCategoryTreeJsonAction()
        {
            string result = "";
            int userId = DataConverter.ToInt(CookieHelper.GetCookie("UserID"));
            string nodesAction = RequestHelper.GetRequestString("NodesAction", "View");
            int showRoot = RequestHelper.GetInt("ShowRoot");
            string value = RequestHelper.GetString("Value");
            CategoryDAL nodesDAL = new CategoryDAL();
            //result = "[";
            //result += nodesDAL.GetMyCategorysTreeJson("", "AND flag='1' AND a.AppID='" + appId + "'", value, nodesAction, userId);
            result += dal.GetMyCategorysTreeJson("", "AND flag='1' ", value, nodesAction, userId);
            SMB_InformationDAL infoDal = new SMB_InformationDAL();
            if (showRoot == 1)
            {
                result = "[{\"id\":\"\",\"text\":\"所有文章\",\"attributes\":{\"Model\":\"Document\",\"LinkUrl\":\"\",\"NodeType\":\"1\"},\"children\":" + result + "}]";
            }
            
            return Content(result, "application/json");
        }
    }
}
