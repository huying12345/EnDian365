
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
    /// 留言模型
    /// </summary>
    public partial class GuestBookController : _GuestBookController
    {
        [NoCheckLogin]
        public ActionResult InsertGuestBook(GuestBook model)
        {

            try
            {
                model = dal.GetInsertModelValue(model);

                dal.InsertByModel(model);
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
