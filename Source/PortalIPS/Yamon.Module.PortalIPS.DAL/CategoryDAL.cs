
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Yamon.Framework.DBUtility;
using System.Collections;
using Yamon.Framework.Common.DataBase;
using Yamon.Framework.Common;
using Yamon.Framework.Common.IO;
using System.IO;
using System.Linq.Expressions;
using Yamon.Framework.DAL;
using Yamon.Module.PortalIPS.Entity;
using Yamon.Module.Common;
using System;

namespace Yamon.Module.PortalIPS.DAL
{
    /// <summary>
    /// 栏目管理实体类
    ///</summary>
    public partial class CategoryDAL : _CategoryDAL
    {
        TreeHelper tree = new TreeHelper("CategoryID", "DisplayName", "OrderNum", "C_ParentID");


        public override int InsertByModel(object obj)
        {
            Category category = (Category)obj;
            string reslut = Db.ExecuteStringSqlEx("select COUNT(1) from dbo.Category where C_ParentID=?", category.C_ParentID);
            if (DataConverter.ToInt(reslut) <= 8)
            {
                return base.InsertByModel(obj);
            }
            else
            {
                throw new Exception("二级栏目不能超过8个");
            }
        }
        
        public string GetMyCategorysTreeJson(object parentId, string where, string value, string actions, int userId)
        {
            value = "," + value + ",";
           // string sql = string.Format("select a.CategoryID,DisplayName,CategoryType,CategoryInfoType,CategoryName,C_ParentID,OrderNum,LinkUrl,ManageLinkUrl,BackNvarchar2 from {3} a,P_CategoryPurview b where a.CategoryID=b.CategoryID AND a.AppID = b.AppID and b.Action='{0}' And b.UserID={1} {2} order by OrderNum", actions, userId, where, "Category");
            string sql = string.Format("select a.CategoryID,DisplayName,CategoryType,CategoryInfoType,CategoryName,C_ParentID,OrderNum,LinkUrl,ManageLinkUrl,BackNvarchar2 from {3} a where 1=1 {2} order by OrderNum", actions, userId, where, "Category");
            System.Data.DataTable dt = Db.ExecuteDataTableSql(sql);
            StringBuilder sb = new StringBuilder();
            System.Data.DataTable newdt = dt.Clone();
            string[] attributes = new string[] { "DisplayName", "CategoryType", "CategoryInfoType", "BackNvarchar2", "ManageLinkUrl" };

            TreeHelper _treeHelper = new TreeHelper("CategoryID", "DisplayName", "OrderNum", "C_ParentID");
            string sbs = _treeHelper.GetTreeJson(dt, "", value, "", attributes);
            return sbs;
        }

        

        public string GetHomeCategoryID()
        {
            string sql = "SELECT TOP 1 CategoryID FROM Category  where Flag='1'  and IsJournal='1' and C_ParentID='' order by OrderNum asc ";
            return Db.GetSingleString(sql);
        }

        public string GetPageUrl(string categoryId, int page, bool createHtml)
        {
            Category category = GetInfoByID(categoryId);

            if (createHtml)
            {
                string strPage = page.ToString();
                string categoryPath = GetParentPathByID(categoryId);
                return string.Format("{2}{0}/infolist/", categoryPath, strPage, ConfigHelper.GetConfigString("BaseURI", "/")) + "{0}.html";
            }
            else
            {
                return SiteCommonIPS.GetBaseUrl() + "InfoList?cid=" + categoryId + "&page={0}";
            }
        }

        public string GetPageUrl(string categoryId, int page)
        {
            return GetPageUrl(categoryId, page, ConfigHelper.GetConfigBool("AutoCreateHtml"));
        }
        public string GetPageUrl(string categoryId)
        {
            return GetPageUrl(categoryId, ConfigHelper.GetConfigBool("AutoCreateHtml"));
        }
        public string GetPageUrl(string categoryId, bool createHtml)
        {
            Category category = GetInfoByID(categoryId);
            if (category != null)
            {
                string linkUrl = category.LinkUrl;
                if (category.BackNvarchar2 == "外部链接" && linkUrl != "")
                {
                    if (linkUrl.StartsWith("@"))
                    {
                        linkUrl = linkUrl.Replace("@", "");
                        string[] arrLinkUrl = linkUrl.Split('#');
                        string newId = GetIdByKey(arrLinkUrl[0]);
                        string newLinkUrl = GetPageUrl(newId, createHtml);
                        if (arrLinkUrl.Length > 1)
                        {
                            newLinkUrl = newLinkUrl + "#" + arrLinkUrl[1];
                        }
                        return newLinkUrl;
                    }
                    return linkUrl;
                }
                else if (category.BackNvarchar2 == "容器栏目")
                {
                    return GetPageUrl(GetCategoryIDByParentID(category.CategoryID), createHtml);
                }
                else if (category.BackNvarchar2 == "单信息")
                {
                    if (category.CategoryInfoType == "VoteInfo")
                    {
                        VoteDAL voteDal = new VoteDAL();
                        DataRow row = voteDal.GetOpenVote(category.AppID.ToString());
                        return voteDal.GetPageUrl(row, createHtml);
                    }
                    else
                    {
                        InformationDAL infoDal = new InformationDAL();
                        string infoGuid = infoDal.GetInfoFirst(categoryId);
                        return infoDal.GetPageUrl(categoryId, infoGuid, createHtml);
                    }
                }
                else if (category.BackNvarchar2 == "单页面")
                {
                    if (createHtml)
                    {
                        if (category.IconName == "index")
                        {
                            return string.Format("{0}index.html", ConfigHelper.GetConfigString("BaseURI", "/"));
                        }
                        string categoryPath = GetParentPathByID(categoryId);
                        return string.Format("{1}{0}/index.html", categoryPath, ConfigHelper.GetConfigString("BaseURI", "/"));
                    }
                    else
                    {
                        return SiteCommonIPS.GetBaseUrl() + "Default/Index?cid=" + categoryId;
                    }
                }
                else
                {
                    if (createHtml)
                    {
                        string categoryPath = GetParentPathByID(categoryId);
                        return string.Format("{1}{0}/index.html", categoryPath, ConfigHelper.GetConfigString("BaseURI", "/"));
                    }
                    else
                    {
                        return SiteCommonIPS.GetBaseUrl() + "Default/InfoList?cid=" + categoryId;
                    }
                }
            }
            return "#";
        }


        /// <summary>
        /// 根据Key获取关键字
        /// </summary>
        /// <param name="catagoryId">栏目CategoryID</param>
        /// <returns></returns>
        public string GetIdByKey(string key)
        {
            string sql = "select top 1 CategoryID FROM Category where IconName=? ";
            return Db.GetSingleStringEx(sql, key);
        }

        /// <summary>
        /// 获取映射栏目下级第一个栏目ID
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public string GetCategoryIDByParentID(string categoryId)
        {
            string Sql = string.Format("SELECT TOP 1 CategoryID  FROM  Category where C_ParentID='{0}'And Flag='1' AND CategoryType='InfoCategory'  and IsJournal<>'9'  and IsJournal<>'4' order by OrderNum asc", categoryId);
            string dt = Db.GetSingleString(Sql);
            return dt;

        }


        public string GetParentPathByID(string categoryId)
        {
            StringBuilder sb = new StringBuilder();
            Category category = GetInfoByID(categoryId);
            DataTable dt = Db.ExecuteDataTableSqlEx(" select * FROM Category where Flag=1 ");
            DataTable newdt = tree.GetTreeDataTable(dt, "");

            DataRow[] drs12 = newdt.Select(string.Format("CategoryID='{0}'", categoryId));
            if (drs12.Length > 0)
            {
                string[] arrParent = (drs12[0]["ParentPath"].ToString() + "," + categoryId).Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < arrParent.Length; i++)
                {
                    Category categoryi = GetInfoByID(arrParent[i]);
                    string categoryPath = categoryi.CategoryPath;
                    if (string.IsNullOrEmpty(categoryPath))
                    {
                        categoryPath = categoryId;
                    }
                    sb.Append(categoryPath + "/");
                }
            }
            return sb.ToString().TrimEnd('/');
        }

    }
}
