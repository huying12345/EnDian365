
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
    /// 信息内容视图
    /// </summary>
    public partial class vwInfoCategoryController : _vwInfoCategoryController
    {
        [NoCheckLogin]
        public ActionResult GetvwInfoByCategoryIDPage()
        {
            int page = RequestHelper.GetInt("page",1);
            int rows = RequestHelper.GetInt("rows", 0);
            int pageSize = RequestHelper.GetInt("pageSize", 20);
            string categoryID = RequestHelper.GetString("CategoryID","");
            vwInfoCategoryDAL vwInfoDal = new vwInfoCategoryDAL();
            InformationDAL infoDal = new InformationDAL();
            try
            {
                string where = " CategoryID=? and Status='CHECKED' ";
                object[] par=new object[] { categoryID };
                if (categoryID == "")
                {
                    where = " Status='CHECKED' ";
                    par = null;
                }

                List<vwInfoCategory> list = vwInfoDal.GetEntityListByPage(where,
                par, " CreateTime desc ", "*", pageSize, page, 0, out rows);

                foreach (vwInfoCategory vwInfo in list)
                {
                    vwInfo.PageUrlExtend = infoDal.GetPageUrl(vwInfo);
                }

                hash["rows"] = rows;
                hash["data"] = list;
                hash["success"] = true;
            }
            catch (Exception ex)
            {
                hash["message"] = ex.Message;
            }
            return Content(JsonConvert.SerializeObject(hash));
        }

        [NoCheckLogin]
        public ActionResult GetvwInfoBySearchPage()
        {
            int page = RequestHelper.GetInt("page", 1);
            int rows = RequestHelper.GetInt("rows", 0);
            int pageSize = RequestHelper.GetInt("pageSize", 20);
            string categoryID = RequestHelper.GetString("CategoryID", "");//类型
            string series = RequestHelper.GetString("Series", "");//系列
            string author = RequestHelper.GetString("Author", "");//演讲者
            string keyword = RequestHelper.GetString("keyword", "");//关键字


            vwInfoCategoryDAL vwInfoDal = new vwInfoCategoryDAL();
            InformationDAL infoDal = new InformationDAL();
            try
            {
                //Author='寇绍恩' and Series='xilie1' and CategoryID='0f4b33a2-be09-4ed5-80d3-c0fc58713680'  and (Keywords like '%a%' or Keywords like '%b%') 
                string where = " Status='CHECKED' ";
                ArrayList param = new ArrayList();
                object[] arrParam;
                if (!string.IsNullOrEmpty(categoryID))//类型
                {
                    where += " and CategoryID=? ";
                    param.Add(categoryID);
                }
                if (!string.IsNullOrEmpty(series))//系列
                {
                    where += " and Series=? ";
                    param.Add(series);
                }
                if (!string.IsNullOrEmpty(author))//演讲者
                {
                    where += " and author=? ";
                    param.Add(author);
                }
                if (!string.IsNullOrEmpty(keyword))//演讲者
                {
                    string[] keywordList = keyword.Split(new char[] { ',', ' ', '，' }, StringSplitOptions.RemoveEmptyEntries);
                    string whereKey = "";
                    for (int i = 0; i < keywordList.Length; i++)
                    {
                        if (i == keywordList.Length - 1)
                        {
                            whereKey += " Keywords like ? or  Title like ? ";
                        }
                        else
                        {
                            whereKey += " Keywords like ? or  Title like ? or ";
                        }
                        param.Add("%" + keywordList[i] + "%");
                        param.Add("%" + keywordList[i] + "%");
                    }
                    if (whereKey != "")
                    {
                        where += " and (" + whereKey + ")";
                    }
                }

                arrParam = param.ToArray();
                List<vwInfoCategory> list = vwInfoDal.GetEntityListByPage(where,arrParam, " CreateTime desc ", "*", pageSize, page, 0, out rows);

                foreach (vwInfoCategory vwInfo in list)
                {
                    vwInfo.PageUrlExtend = infoDal.GetPageUrl(vwInfo);
                }

                hash["rows"] = rows;
                hash["data"] = list;
                hash["success"] = true;
            }
            catch (Exception ex)
            {
                hash["message"] = ex.Message;
            }
            return Content(JsonConvert.SerializeObject(hash));
        }

        [NoCheckLogin]
        public ActionResult GetvwInfoBySearch()
        {
            string categoryID = RequestHelper.GetString("CategoryID", "");//类型
            string series = RequestHelper.GetString("Series", "");//系列
            string author = RequestHelper.GetString("Author", "");//演讲者
            string keyword = RequestHelper.GetString("keyword", "");//关键字

            vwInfoCategoryDAL vwInfoDal = new vwInfoCategoryDAL();
            InformationDAL infoDal = new InformationDAL();
            try
            {
                //Author='寇绍恩' and Series='xilie1' and CategoryID='0f4b33a2-be09-4ed5-80d3-c0fc58713680'  and (Keywords like '%a%' or Keywords like '%b%') 
                string where = " Status='CHECKED' ";
                ArrayList param = new ArrayList();
                object[] arrParam;
                if (!string.IsNullOrEmpty(categoryID))//类型
                {
                    where += " and CategoryID=? ";
                    param.Add(categoryID);
                }
                if (!string.IsNullOrEmpty(series))//系列
                {
                    where += " and Series=? ";
                    param.Add(series);
                }
                if (!string.IsNullOrEmpty(author))//演讲者
                {
                    where += " and author=? ";
                    param.Add(author);
                }
                if (!string.IsNullOrEmpty(keyword))//演讲者
                {
                    string[] keywordList = keyword.Split(new char[] { ',', ' ', '，' }, StringSplitOptions.RemoveEmptyEntries);
                    string whereKey = "";
                    for (int i = 0; i < keywordList.Length; i++)
                    {
                        if (i == keywordList.Length - 1)
                        {
                            whereKey += " Keywords like ? or  Title like ? ";
                        }
                        else
                        {
                            whereKey += " Keywords like ? or  Title like ? or ";
                        }
                        param.Add("%" + keywordList[i] + "%");
                        param.Add("%" + keywordList[i] + "%");
                    }
                    if (whereKey != "")
                    {
                        where += " and (" + whereKey + ")";
                    }
                }

                arrParam = param.ToArray();
                List<vwInfoCategory> list = vwInfoDal.GetEntityList(where, arrParam, "CreateTime desc", 20,"");
                foreach (vwInfoCategory vwInfo in list)
                {
                    vwInfo.PageUrlExtend = infoDal.GetPageUrl(vwInfo);
                }
                hash["data"] = list;
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
