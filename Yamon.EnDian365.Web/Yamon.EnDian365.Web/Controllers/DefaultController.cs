using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Yamon.Framework.Common;
using System.Data;
using Yamon.Framework.Common.DataBase;
using Yamon.Framework.Common.IO;
using Yamon.Framework.Common.Paging;
using Yamon.Framework.MVC;
using Yamon.Module.PortalIPS;
using Yamon.Module.SiteManage;
using System.Collections;
using System.IO;
using Yamon.Framework.DBUtility;
using System.Web.Script.Serialization;
using Yamon.Module.PortalIPS.DAL;
using Yamon.Module.PortalIPS.Entity;

namespace Yamon.EnDian365.Web.Controllers
{


    public class DefaultController : Controller
    {

        //
        // GET: /
        private string _cityId;
        public DefaultController()
        {
        }

        /// <summary>
        /// 清空缓存
        /// </summary>
        /// <returns></returns>
        public ActionResult ClearCache()
        {
            CacheHelper.Clear();
            return Content("清空缓存成功！");
        }

        CategoryDAL categoryDal = new CategoryDAL();
        
    
        /// <summary>
        /// 主页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(string cid = "8a39580c-daba-49f4-ba7a-46c9cc0ed875")
        {           
            ViewBag.CategoryDAL = categoryDal;
            if (string.IsNullOrEmpty(cid))
            {
                cid = categoryDal.GetHomeCategoryID();
            }
            try
            {
                Category category = categoryDal.GetInfoByID(cid);
                if (category != null)
                {
                    ViewBag.Title = category.CategoryName;
                }
                ViewBag.Category = category;

                InformationDAL infoDal = new InformationDAL();
                ViewBag.InformationDAL = infoDal;
                string template = category.IndexTemplate;
                if (string.IsNullOrEmpty(template))
                {
                    template = "Index";
                }

                return View(template, category);
            }
            catch
            {


            }
            return View();
        }

       
        /// <summary>
        /// 列表页
        /// </summary>
        /// <returns></returns>
        [AntiSqlInjectFilter]
        public ActionResult InfoList(string cid, int page = 1)
        {
            CategoryDAL categoryDal = new CategoryDAL();
            ViewBag.CategoryDAL = categoryDal;
            Category category = categoryDal.GetInfoByID(cid);
            ViewBag.Category = category;
            if (category != null)
            {
                ViewBag.Title = category.CategoryName;
            }
            int rows = 0;
            string template = category.ListTemplate;
            
            if (category.CategoryInfoType == "VoteInfo")
            {
                VoteDAL voteDal = new VoteDAL();
                Parameters parameters = new Parameters("@CategoryID", DbType.String, cid);
               // DataTable voteList = voteDal.GetAllEntityListByPage("Status='1' AND CategoryID=@CategoryID", "StartTime desc", 20, page, 0, out rows, parameters);
                List<Vote> voteList = voteDal.GetEntityListByPage("Status='1' AND CategoryID=?", new object[]{cid}, "StartTime desc", "*", 20, page, 0, out rows);          
                ViewBag.Model = voteList;
                ViewBag.ShowPage = DefaultPaging.ShowPage(rows, 20, page, categoryDal.GetPageUrl(cid, page), "pageclass", "篇", "投票", 1);
                if (string.IsNullOrEmpty(template))
                {
                    template = "VoteList";
                }
                return View(template, voteList);
            }
            else
            {
                InformationDAL infoDal = new InformationDAL();
                ViewBag.InformationDAL = infoDal;
                DataTable infoTableList = infoDal.GetInfoList(cid, page, 20, out rows);
                List<vwInfoCategory> infoList = infoTableList.ToObjectList<vwInfoCategory>();

                if (string.IsNullOrEmpty(template))
                {
                    template = "WeatherNewsList";
                }
                ViewData["Model"] = infoList;
                string itemName = "文章";
                string unit = "篇";
                if (category.CategoryInfoType == "VideoInfo")
                {
                    itemName = "视频";
                    unit = "个";
                }
                ViewBag.ShowPage = DefaultPaging.ShowPage(rows, 20, page, categoryDal.GetPageUrl(cid, page), "pageclass",
                    unit, itemName, 1);
                return View(template, infoList);
            }

        }
        /// <summary>
        /// 详细页
        /// </summary>
        /// <returns></returns>
        public ActionResult InfoList2(string categoryId)
        {
            CategoryDAL categoryDal = new CategoryDAL();
            ViewBag.CategoryDAL = categoryDal;

            Category category = categoryDal.GetInfoByID(categoryId);//获得栏目标题
            ViewBag.category = category;
            string template = category.ListTemplate;
            if (string.IsNullOrEmpty(template)) {
                template = "enDianMark";
            }
            return View(template);
        }

        /// <summary>
        /// 详细页
        /// </summary>
        /// <returns></returns>
        public ActionResult Info(string categoryId)
        {
            CategoryDAL categoryDal = new CategoryDAL();
            ViewBag.CategoryDAL = categoryDal;

            Category category = categoryDal.GetInfoByID(categoryId);//获得栏目标题
            ViewBag.category = category;
            string template = category.ListTemplate;
            if (string.IsNullOrEmpty(template))
            {
                template = "Fengxian";
            }
            return View(template);
        }

        /// <summary>
        /// 详细页
        /// </summary>
        /// <returns></returns>
        public ActionResult InfoDetail(string categoryId, string infoId)
        {          
            CategoryDAL categoryDal = new CategoryDAL();
            ViewBag.CategoryDAL = categoryDal;

            Category category = categoryDal.GetInfoByID(categoryId);
            ViewBag.Category = category;

            InformationDAL infoDal = new InformationDAL();
            ViewBag.InformationDAL = infoDal;
            string template = category.DetailTemplate;

            vwInfoCategoryDAL vwInfoDal=new vwInfoCategoryDAL();
            vwInfoCategory vwInfo=vwInfoDal.GetInfoByID(infoId);
            ViewBag.vwInfo = vwInfo;
            if (vwInfo.InfoType == "CommonInfo" || vwInfo.InfoType == "VideoInfo" || vwInfo.InfoType == "audioInfo")
            {
                if (vwInfo == null)
                {
                    throw new Exception("找不到指定的内容！");
                }
                else
                {
                    ViewBag.Title = vwInfo.Title;
                }
                if (string.IsNullOrEmpty(template))
                {
                    template = "enDianMark";//默认为图文页面
                }           
            }
            return View(template, vwInfo);

        }

        public ActionResult GetInfoViewCountAction(string infoGuid, string categoryId)
        {
            InformationDAL infoDal = new InformationDAL();
            int count = 0;
            if (!string.IsNullOrEmpty(infoGuid))
            {
                count = infoDal.UpdateViewCount(categoryId, infoGuid);
            }
            return Content("document.write('" + count + "');");
        }
        public ActionResult SearchListAction()
        {
            string key = RequestHelper.GetString("key");
            InformationDAL infoDal = new InformationDAL();
            key = infoDal.fliteringRisk(key);
            return Content(key);
        }

        #region 生成静态网页
        public ActionResult Test()
        {
            CreateHtml("http://localhost:1407/sh/Index/a9756b47-bd8c-43aa-b353-5ff403e25a01", Server.MapPath("~/index.html"));
            return Content("生成成功！");
        }

        /// <summary>
        /// 生成静态网页
        /// </summary>
        /// <param name="url"></param>
        /// <param name="savePath"></param>
        private bool CreateHtml(string url, string savePath)
        {
            try
            {
                Response.Write(RequestHelper.GetRootURI().TrimEnd('/') + url + "<br/>" + Server.MapPath(savePath) + "<br/>");
                HttpHelper httpHelper = new HttpHelper();
                string content = httpHelper.Get(ConfigHelper.GetConfigString("WebUrl").TrimEnd('/') + url);
                if (!string.IsNullOrEmpty(content.Trim()) && !content.Contains("<title>非常抱歉，网页无法访问</title>"))
                {
                    IOHelper.WriteFile(Server.MapPath(savePath), content);
                }
                return true;
            }
            catch (Exception ex)
            {
                AddLog("出错:" + ex.Message);
                return false;
            }
        }

        //public ActionResult CreateWeather()
        //{
        //    CategoryDAL categroyDal = new CategoryDAL();
        //    string[] keys = { "tqsk", "tqyb", "qxyj", "index", "ctb", "qxfw" };
        //    string ids = "";
        //    for (int i = 0; i < keys.Length; i++)
        //    {
        //        ids += categroyDal.GetIdByKey(_cityId, keys[i]) + ",";
        //    }
        //    return CreateInfoList(ids, true, false, 0);
        //}

        /// <summary>
        /// 生成顶部导航栏目
        /// </summary>
        /// <returns></returns>
        //public ActionResult CreateTopMenu()
        //{
        //    ClearCache();
        //    CategoryDAL categroyDal = new CategoryDAL();
        //    List<Category> dt = categroyDal.GetTopMenuList(_cityId);
        //    foreach (Category row in dt)
        //    {
        //        CreateInfoList(row.CategoryID.ToString(), true, false, 0);
        //    }
        //    string lxhfId = categroyDal.GetIdByKey(_cityId, "lxhf");
        //    string cjwthfId = categroyDal.GetIdByKey(_cityId, "cjwthf");

        //    CreateInfoList(lxhfId, true, true, 20);
        //    CreateInfoList(cjwthfId, true, true, 20);
        //    return new EmptyResult();
        //}

        //public ActionResult CreateAllInfoList(bool createdetail = true)
        //{
        //    ClearCache();
        //    CategoryDAL categroyDal = new CategoryDAL();
        //    DataTable dt = categroyDal.GetAllEntityList("CategoryID", "Flag='1' AND CategoryType='InfoCategory' and AppID='" + _cityId + "'  and IsJournal<>'9' ", "OrderNum");
        //    foreach (DataRow row in dt.Rows)
        //    {
        //        CreateInfoList(row["CategoryID"].ToString(), true, createdetail, 0);
        //    }
        //    return new EmptyResult();
        //}

        //public ActionResult CreateInfoTopN(int top)
        //{
        //    InformationDAL pp = new InformationDAL();
        //    CategoryDAL categoryDal = new CategoryDAL();
        //    DataTable dt = pp.GetAllInfoList("CategoryID,InfoGuid", top.ToString(), _cityId);
        //    ArrayList categoryList = new ArrayList();
        //    foreach (DataRow info in dt.Rows)
        //    {
        //        CreateInfoDetailByInfoGuid(info["InfoGuid"].ToString(), info["CategoryID"].ToString(), false);
        //        if (!categoryList.Contains(info["CategoryID"].ToString()))
        //        {
        //            categoryList.Add(info["CategoryID"].ToString());
        //        }

        //        foreach (string s in categoryDal.GetParentIDsByID(info["CategoryID"].ToString()))
        //        {
        //            if (!categoryList.Contains(s))
        //            {
        //                categoryList.Add(s);
        //            }
        //        }

        //        foreach (Guid s in categoryDal.GetRefCategoryIDsByID(info["CategoryID"].ToString()))
        //        {
        //            if (!categoryList.Contains(s.ToString()))
        //            {
        //                categoryList.Add(s.ToString());
        //            }
        //        }
        //    }
        //    foreach (string item in categoryList)
        //    {
        //        CreateInfoList(item, true, false, 5);
        //    }
        //    return new EmptyResult();
        //}

        public ActionResult CreateInfoList(string categoryId, bool createList, bool createdetail, int pageCount = 0)
        {
            string[] arrCategoryId = categoryId.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            for (int k = 0; k < arrCategoryId.Length; k++)
            {
                CategoryDAL categoryDal = new CategoryDAL();
                InformationDAL infoDal = new InformationDAL();
                Category category = categoryDal.GetInfoByID(arrCategoryId[k]);
                string pageUrl = categoryDal.GetPageUrl(arrCategoryId[k], false);
                string savePath = categoryDal.GetPageUrl(arrCategoryId[k], true);
                if (category != null)
                {
                    if (category.BackNvarchar2 == "外部链接" && category.LinkUrl != "")
                    {
                        continue;
                    }
                    else if (category.BackNvarchar2 == "多信息")
                    {
                        CreateHtml(pageUrl, savePath);
                        int rows = 0;
                        if (category.CategoryInfoType == "VoteInfo")
                        {
                            VoteDAL voteDal = new VoteDAL();
                            voteDal.GetAllEntityListByPage(string.Format("Status='1' AND CategoryID='{0}'", arrCategoryId[k].Replace("'", "''")), "StartTime desc", 20, 1, 0,out rows);
                        }
                        //else if (categoryInfo["CategoryInfoType"].ToString() == "MailInfo")
                        //{
                        //    MailboxDAL voteDal = new MailboxDAL();
                        //    voteDal.GetInfoListByPage(arrCategoryId[k], 1, 20, 0, out rows);
                        //}
                        else
                        {
                            rows = infoDal.GetInfoListCount(arrCategoryId[k]);
                        }
                        int totalPage = rows / 20;
                        if (rows == 0)
                        {
                            totalPage = 1;
                        }
                        if (rows % 20 > 0)
                        {
                            totalPage += 1;
                        }
                        if (pageCount > 0 && pageCount < totalPage)
                        {
                            totalPage = pageCount;
                        }
                        AddLog("正在生成编号为" + arrCategoryId[k] + "的列表页，共" + totalPage + "页，当前第1页<br/>");
                        if (rows > 20)
                        {
                            for (int i = 1; i <= totalPage; i++)
                            {
                                AddLog("正在生成编号为" + arrCategoryId[k] + "的列表页，共" + totalPage + "页，当前第" + i + "页<br/>");
                                pageUrl = string.Format(categoryDal.GetPageUrl(arrCategoryId[k], i, false), i);
                                savePath = string.Format(categoryDal.GetPageUrl(arrCategoryId[k], i, true), i);
                                CreateHtml(pageUrl, savePath);
                            }
                        }

                        if (createdetail)
                        {
                            CreateInfoDetailHtmlByCategoryID(arrCategoryId[k]);
                        }
                    }
                    else
                    {
                        CreateHtml(pageUrl, savePath);
                    }
                }
            }
            return new EmptyResult();
        }

        /// <summary>
        /// 生成新闻内页BY类型
        /// </summary>
        /// <param name="categoryID"></param>
        public ActionResult CreateInfoDetailHtmlByCategoryID(string categoryId)
        {
            CategoryDAL categoryDal = new CategoryDAL();

            Category category=categoryDal.GetInfoByID(categoryId);

            InformationDAL pp = new InformationDAL();
            List<vwInfoCategory> infoList = pp.GetInfoList("InfoGuid,CategoryID,AppID,BackNvarchar4", categoryId, 0);
            for (int i = 0; i < infoList.Count; i++)
            {
                AddLog("正在生成" + category.CategoryName + "编号为" + infoList[i].InfoGuid + "的文章内页，共" + infoList.Count + "篇，当前第" + (i + 1) + "篇");
                string pageUrl = pp.GetPageUrl(infoList[i], false);
                string savePath = pp.GetPageUrl(infoList[i], true);
                bool result = CreateHtml(pageUrl, savePath);
                if (result)
                {
                    AddLog("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;成功！<br/>");
                }
                else
                {
                    AddLog("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;失败！<br/>");
                }
            }
            return new EmptyResult();
        }

        //public ActionResult CreateInfoDetailByInfoGuid(string infoGuid, string categoryId, bool createList)
        //{
        //    InformationDAL pp = new InformationDAL();
        //    Info info = pp.GetInfoDetail(infoGuid, categoryId);
        //    AddLog("正在生成编号为" + infoGuid + "的文章内页");
        //    string pageUrl = pp.GetPageUrl(info, false);
        //    string savePath = pp.GetPageUrl(info, true);
        //    bool result = CreateHtml(pageUrl, savePath);
        //    if (result)
        //    {
        //        AddLog("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;成功！<br/>");
        //    }
        //    else
        //    {
        //        AddLog("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;失败！<br/>");
        //    }
        //    if (createList)
        //    {
        //        CreateInfoList(categoryId, true, false, 5);
        //    }
        //    return new EmptyResult();
        //}

        private void AddLog(string msg)
        {
            Response.Buffer = false;
            Response.Write(DateTime.Now + "|" + msg);
        }

        #endregion


    }
}
