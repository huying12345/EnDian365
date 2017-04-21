
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
    /// 信息内容
    /// </summary>
    public partial class SMB_InformationController : _SMB_InformationController
    {
        [CheckPurview(0)]
        public ActionResult DelAction()
        {
            string categoryId = RequestHelper.GetRequestString("CategoryID");
            string ids = RequestHelper.GetRequestString("ids");

            try
            {
                string result = dal.DelInformationCategory(categoryId, ids).ToString();
                string[] arrId = RequestHelper.GetRequestString("ids").Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < arrId.Length; i++)
                {
                    string myId = arrId[i];
                    LogDAL.AddLog("PortalIPS_SMB_Information", "PortalIPS_SMB_Information_" + myId + categoryId, "删除", "删除成功！");
                }
                hash["success"] = true;
            }
            catch (Exception ex)
            {
                hash["message"] = ex.Message;
            }
            return Content(JsonConvert.SerializeObject(hash));
        }

        [CheckPurview(0)]
        public ActionResult ChecksAction()
        {
            string ids = RequestHelper.GetRequestString("ids");
            try
            {
                string result = dal.Checks(ids, "CHECKED") > 0 ? "1" : "0";
                LogDAL.AddLog("PortalIPS_SMB_Information", "PortalIPS_SMB_Information_" + ids, "批量审核", "批量审核成功！");
                hash["result"] = result;
                hash["success"] = true;
            }
            catch (Exception ex)
            {
                hash["message"] = ex.Message;
            }
            return Content(JsonConvert.SerializeObject(hash));
        }

    }
}
