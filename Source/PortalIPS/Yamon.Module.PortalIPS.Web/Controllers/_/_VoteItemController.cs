﻿
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由亚萌智能表单代码生成工具生成。
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。除非此项目不再使用代码生成器生成。
//     如果想修改此文件的方法，请在此文件的上级目录中的VoteItemController重写(override)该方法。
//     如有问题联系zongeasy@qq.com
//
//</auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;
using System.IO;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using Yamon.Framework.DAL;
using Yamon.Module.SiteManage.Entity;
using Yamon.Module.PortalIPS.Entity;
using Yamon.Module.PortalIPS.DAL;
using Newtonsoft.Json;
using Yamon.Framework.Common;
using Yamon.Module.SiteManage.DAL;
using Yamon.Module.UCenter.DAL;
using Yamon.Framework.Common.IO;
using Yamon.Framework.MVC;
using Yamon.Module.Common;
using Yamon.Framework.NPOI;




namespace Yamon.Module.PortalIPS.Web.Controllers
{
    /// <summary>
    /// 投票选项模型
    /// </summary>
    public partial class _VoteItemController :BaseController
    {

        public VoteItemDAL dal = new VoteItemDAL();

        public virtual ActionResult Grid1()
        {
            return Index("Grid1","");
        }
        
        [NonAction]
        public ActionResult Index(string m,string filterId)
        {
            
            int userId = CookieHelper.GetCookieInt("UserID");
            string roleIds = CookieHelper.GetCookie("RoleIDList");
            string cityId = CookieHelper.GetCookie("CityID");
            string menuId = RequestHelper.GetRequestString("Menu");
            ViewBag.DAL = new VoteItemDAL();
            RolePurviewDAL rolePurviewDal = new RolePurviewDAL();
            ArrayList purviewList = rolePurviewDal.GetPurviewListByRoleID(roleIds);
            ToolBarDAL toolBarDal = new ToolBarDAL();
            List<ToolBar> toolbarList = toolBarDal.GetMyToolBarList(cityId, menuId, purviewList);
            ViewBag.ToolbarColumnList = toolbarList.Where(o => o.ToolbarType == "GridItem").ToList();
            ViewBag.ToolbarList=toolbarList.Where(o => ((o.ToolbarType == "Toolbar") || (o.ToolbarType == "CommonToolbar"))).ToList();

            string formPath = string.Format("~/Areas/PortalIPS/Views/VoteItem/_/{0}.cshtml", m);
            formPath = SiteCommon.GetCustomPage(formPath);
            return View(formPath);
		}



public virtual ActionResult Create(string id = "")
{
    ViewBag.ID = id;
    ViewBag.DAL=dal;
    VoteItem model= dal.GetCreateFormDefaultValue();
    model=dal.GetModelShowValue(model);
    string formPath = SiteCommon.GetCustomPage("~/Areas/PortalIPS/Views/VoteItem/_/Create.cshtml");
    return View(formPath,model);
}
public virtual ActionResult Edit(string id = "")
{
    ViewBag.ID = id;
    ViewBag.DAL=dal;
    VoteItem model = dal.GetModelByID(id);
    model=dal.GetEditFormDefaultValue(model);
    model=dal.GetModelShowValue(model);
    string formPath = SiteCommon.GetCustomPage("~/Areas/PortalIPS/Views/VoteItem/_/Edit.cshtml");
    return View(formPath,model);
}public virtual ActionResult Show(string id = "")
{
    ViewBag.ID = id;
    ViewBag.DAL=dal;
    VoteItem model = dal.GetModelByID(id);
    model=dal.GetModelShowValue(model);
    string formPath = SiteCommon.GetCustomPage("~/Areas/PortalIPS/Views/VoteItem/_/Show.cshtml");
    return View(formPath,model);
}
 
    }
}
