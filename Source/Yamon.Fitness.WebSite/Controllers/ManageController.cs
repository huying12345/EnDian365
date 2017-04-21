using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yamon.Framework.Common;
using Yamon.Framework.MVC;
using Yamon.Module.SiteManage.DAL;
using Yamon.Module.UCenter.DAL;

namespace Yamon.EnDian365.WebSite.Controllers
{
    public class ManageController : BaseController
    {
        //
        // GET: /Manage/

        [NoCheckLogin]
        public ActionResult Index()
        {
            return View();
        }

        [NoCheckLogin]
        public ActionResult Login()
        {
            return View();
        }
        [NoCheckLogin]
        public ActionResult lefts()
        {
            GetMenu();
            return View();
        }

        [NoCheckLogin]
        public ActionResult header()
        {
            GetMenu();
            return View();
        }

        private void GetMenu()
        {
            MenuDAL menuDal = new MenuDAL();
            RolePurviewDAL rolePurviewDal = new RolePurviewDAL();
            string roleId = CookieHelper.GetCookie("RoleIDList");
            ArrayList purviewList = rolePurviewDal.GetPurviewListByRoleID(roleId);
            ViewBag.LeftMenuList = menuDal.GetMyTreeMenuList(roleId, purviewList);
        }


        [NoCheckLogin]
        public ActionResult mains()
        {
            return View();
        }
        [NoCheckLogin]
        public ActionResult news_cat()
        {
            return View();
        }
        [NoCheckLogin]
        public ActionResult ads()
        {
            return View();
        }
        [NoCheckLogin]
        public ActionResult person()
        {
            return View();
        }
        [NoCheckLogin]
        public ActionResult manager()
        {
            return View();
        }
        [NoCheckLogin]
        public ActionResult log()
        {
            return View();
        }
        [NoCheckLogin]
        public ActionResult config()
        {
            return View();
        }
        [NoCheckLogin]
        public ActionResult content()
        {
            return View();
        }
    }
}
