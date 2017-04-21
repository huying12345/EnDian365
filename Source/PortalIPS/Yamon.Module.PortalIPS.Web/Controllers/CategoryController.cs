
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



namespace Yamon.Module.PortalIPS.Web.Controllers
{
    /// <summary>
    /// 栏目管理
    /// </summary>
    public partial class CategoryController : _CategoryController
    {
        public ActionResult CategoryTree()
        {
            return View();
        }

        public ActionResult CreateHtml()
        {
            return View();
        }
    }
}
