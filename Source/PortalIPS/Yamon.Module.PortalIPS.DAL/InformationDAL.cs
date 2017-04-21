using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Yamon.Framework.DBUtility;

using Yamon.Framework.Common;
using System.Collections;

using Yamon.Module.PortalIPS.Entity;

namespace Yamon.Module.PortalIPS.DAL
{
    public class InformationDAL
    {

        /// <summary>
        /// 视图信息字段
        /// </summary>
        string vwInfoCategoryField = "*";
        /// <summary>

        
        /// 栏目图片信息
        /// </summary>
        /// <param name="TOP">前几条，为空查询全部</param>
        /// <param name="categoryId">栏目ID</param>
        /// <returns></returns>
        public List<vwInfoCategory> GetInfoList_Image(string categoryId, int top, bool showImage = true)
        {
            string topN = "";
            if (top > 0)
            {
                topN = "TOP " + " " + top;
            }
            CategoryDAL categoryDal = new CategoryDAL();

            Category category = categoryDal.GetInfoByID(categoryId);
            if (category == null)
            {
                return new List<vwInfoCategory>();
            }
            string SqlWhere = "";
            //if (DataConverter.ToInt(row["Child"]) > 0)
            //{
            //    SqlWhere = "OR CategoryID in('" + row["AllChildID"].ToString().Replace(",", "','") + "')";

            //}
            string where1 = " MediaFileName<>''";
            if (!showImage)
            {
                where1 = " MediaFileName=''";
            }
            string Sql = string.Format("SELECT {0} {1} FROM  vwInfoCategory where {4} and (CategoryID='{2}' {3}) and Status='CHECKED' and Flag='1' order by BackInt asc,ShowTime desc,CreateTime desc", topN, vwInfoCategoryField, categoryId, SqlWhere, where1);

            return DbHelper.GetConn("UCenter").ExecuteDataTableSql(Sql).ToObjectList<vwInfoCategory>();
        }


        /// <summary>
        /// 获取状态数目
        /// </summary>
        /// <param name="status">关联数据字典</param>
        /// <returns></returns>
        public int GetInformationStatusCount(string status)
        {
            string sql = "select COUNT(*) from InformationCategoryRelation where Status='" + status + "' group by Status ";
            return DbHelper.GetConn("UCenter").GetSingleInt(sql);

        }
        public DataTable GetInfoNumByCondition(string status, DateTime sTime, DateTime eTime)
        {
            string str1 = "";
            string[] str = status.Split(',');
            for (int i = 0; i < str.Length; i++)
            {
                str1 += "'" + str[i] + "'" + ",";
            }
            str1 = str1.TrimEnd(',');

            string sql = string.Format(@"select m.y,m.name,n.publichnum from (select count(*) y,b.GroupName name from InformationCategoryRelation i right join Information b
            on i.InfoGuid=b.InfoGuid where i.status in({0}) and b.CreateTime between '{1}' and '{2}' group by b.GroupName)m left join 
            (select count(*) publichnum,b.GroupName name from InformationCategoryRelation i right join Information b
            on i.InfoGuid=b.InfoGuid where i.Status='CHECKED' and b.CreateTime between '{1}' and '{2}' group by b.GroupName)n
            on m.name=n.name", str1, sTime, eTime);
            return DbHelper.GetConn("UCenter").ExecuteDataTableSql(sql);
        }
        public List<vwInfoCategory> GetInfoList(string categoryId, int top)
        {
            return GetInfoList(vwInfoCategoryField, categoryId, top);
        }

        /// <summary>
        /// 单信息 返回InfoGuid
        /// </summary>
        /// <param name="categoryId">栏目categoryId</param>
        /// <returns></returns>
        public string GetInfoFirst(string categoryId)
        {
            if (string.IsNullOrEmpty(categoryId))
            {
                return "00000000-0000-0000-0000-000000000000";
            }

            string sql = string.Format("SELECT top 1 InfoGuid  FROM  vwInfoCategory where CategoryID='{0}' and Status='CHECKED' and Flag='1' order by BackInt asc,ShowTime desc,CreateTime desc", categoryId.Replace("'", "''"));
            string infoGuid = DbHelper.GetConn("UCenter").GetSingleString(sql);
            return infoGuid;
        }
        /// <summary>
        /// 栏目信息
        /// </summary>
        /// <param name="TOP">前几条，为空查询全部</param>
        /// <param name="categoryId">栏目ID(父亲和本栏目)</param>
        /// <returns></returns>
        public List<vwInfoCategory> GetInfoList(string fields, string categoryId, int top, string orderBy = " BackInt asc,ShowTime desc,CreateTime desc")
        {
            if (string.IsNullOrEmpty(fields))
            {
                fields = vwInfoCategoryField;
            }
            string topN = "";
            if (top > 0)
            {
                topN = "TOP " + " " + top;
            }
            CategoryDAL categoryDal = new CategoryDAL();
           // categoryId = categoryDal.GetRefCategoryID(categoryId);
            Category category = categoryDal.GetInfoByID(categoryId);
            string SqlWhere = "";
            if (category == null)
            {
                return new List<vwInfoCategory>();
            }
            //if (DataConverter.ToInt(row["Child"]) > 0)
            //{
            //    ArrayList cIds = new ArrayList();
            //    string[] arrChildId = row["AllChildID"].ToString().Split(',');
            //    for (int i = 0; i < arrChildId.Length; i++)
            //    {
            //        cIds.AddRange(categoryDal.GetRefCategoryIDAndChildID(arrChildId[i]));
            //    }
            //    SqlWhere = "OR CategoryID in('" + string.Join(",", (string[])cIds.ToArray(typeof(string))).Replace(",", "','") + "')";

            //}
            string Sql = string.Format("SELECT {0} {3}  FROM  vwInfoCategory where (CategoryID='{1}' {2} ) and Status='CHECKED' and Flag='1' and BackInt3 !=1 order by {4}", topN, categoryId.Replace("'", "''"), SqlWhere, fields, orderBy);
            return DbHelper.GetConn("UCenter").ExecuteDataTableSql(Sql).ToObjectList<vwInfoCategory>();
        }

        /// <summary>
        /// 不启用栏目信息
        /// </summary>
        /// <param name="TOP">前几条，为空查询全部</param>
        /// <param name="categoryId">栏目ID(父亲和本栏目)</param>
        /// <returns></returns>
        //public DataTable GetHiddenInformationlist(string top, string categoryId)
        //{
        //    if (top != "")
        //    {

        //        top = "TOP " + " " + top;
        //    }
        //    CategoryDAL categoryDal = new CategoryDAL();
        //    DataRow row = categoryDal.GetTreeInfoByID(categoryId);
        //    string SqlWhere = "";
        //    if (DataConverter.ToInt(row["Child"]) > 0)
        //    {
        //        SqlWhere = "OR CategoryID in('" + row["AllChildID"].ToString().Replace(",", "','") + "')";

        //    }
        //    string Sql = string.Format("SELECT {0} *  FROM  vwInfoCategory where (CategoryID='{1}' {2} ) and Status='CHECKED' order by   BackInt asc,ShowTime desc,CreateTime desc", top, categoryId.Replace("'", "''"), SqlWhere);
        //    return DbHelper.GetConn("UCenter").ExecuteDataTableSql(Sql);
        //}


        /// <summary>
        /// 栏目信息
        /// </summary>
        /// <param name="TOP">前几条，为空查询全部</param>
        /// <param name="categoryId">栏目ID(父亲和本栏目)</param>
        /// <returns></returns>
        public DataTable GetAllInfoList(string fields, string top, string cityId)
        {
            if (top != "")
            {

                top = "TOP " + " " + top;
            }
            CategoryDAL categoryDal = new CategoryDAL();

            string Sql = string.Format("SELECT {0} {1}  FROM  vwInfoCategory where AppID='{2}' order by   LastModifyTime desc", top, fields, cityId.Replace("'", "''"));
            return DbHelper.GetConn("UCenter").ExecuteDataTableSql(Sql);
        }

        /// <summary>
        /// 详细信息
        /// </summary>
        /// <param name="InfoGuid">信息ID</param>
        /// <returns></returns>
        public vwInfoCategory GetInfoDetail(string infoguid, string categoryId)
        {
            try
            {
                string sql = String.Format(
                    "select {0}  from  vwInfoCategory where InfoGuid='{1}' AND CategoryID='{2}'", vwInfoCategoryField,
                    infoguid.Replace("'", "''"), categoryId.Replace("'", "''"));
                return DbHelper.GetConn("UCenter").ExecuteDataRowSql(sql).ToObject<vwInfoCategory>();
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 详细信息
        /// </summary>
        /// <param name="InfoGuid">信息ID</param>
        /// <returns></returns>
        public DataRow GetInfoDetail(string infoguid)
        {
            string Sql = String.Format("select {0}  from  vwInfoCategory where InfoGuid='{1}'", vwInfoCategoryField, infoguid.Replace("'", "''"));
            return DbHelper.GetConn("UCenter").ExecuteDataRowSql(Sql);
        }
        /// <summary>
        /// 获取下载附件
        /// </summary>
        /// <param name="infoGuid">信息ID</param>
        /// <returns></returns>
        public DataTable GetInformationAttachment(string infoGuid)
        {
            string sql = String.Format("select a.InfoGuid,a.AttachmentID,b.AttachmentID,b.DisplayFileName ,b.PhysicalFileName,b.PhysicalFileUrl,b.PhysicalFilePath,b.DownloadCount,b.Uploader,b.UploaderName,b.UploadTime,b.FileSize,b.Dimension,b.Miniature,b.Price,b.SourceFileName,b.ShootPlace,b.ShootTime,b.Camera from InformationAttachmentRelation a,Attachment b where a.AttachmentID=b.AttachmentID and a.InfoGuid='{0}'", infoGuid.Replace("'", "''"));
            return DbHelper.GetConn("UCenter").ExecuteDataTableSql(sql);

        }
        /// <summary>
        /// 信息列表
        /// </summary>
        /// <param name="catagoryId">栏目ID</param>
        /// <param name="page">页码</param>
        /// <param name="pageSize">页码URL</param>
        /// <param name="rows">信息总数</param>
        /// <returns></returns>
        public DataTable GetInfoList(string categoryId, int page, int pageSize, out int rows, string orderBy = "BackInt asc,ShowTime desc,CreateTime desc")
        {
            CategoryDAL categoryDal = new CategoryDAL();
            Category category = categoryDal.GetInfoByID(categoryId);
            string sqlWhere2 = "";
           
            string sqlWhere = string.Format("(CategoryID='{0}' {1}) and Status='CHECKED' and Flag='1'", categoryId.Replace("'", "''"), sqlWhere2);
            return DbHelper.GetConn("UCenter").ExecuteDataTableByPage("vwInfoCategory", "InfoGuid", vwInfoCategoryField, sqlWhere, orderBy, pageSize, page, 0, out rows);
        }


        public int GetInfoListCount(string categoryId)
        {
            CategoryDAL categoryDal = new CategoryDAL();

            Category category = categoryDal.GetInfoByID(categoryId);
            string sqlWhere2 = "";
            
            string sqlWhere = string.Format("select count(1) from vwInfoCategory where (CategoryID='{0}' {1}) and Status='CHECKED' and Flag='1'", categoryId, sqlWhere2);
            return DbHelper.GetConn("UCenter").GetSingleInt(sqlWhere);
        }
        /// <summary>
        /// 信息列表
        /// </summary>
        /// <param name="catagoryId">栏目ID</param>
        /// <param name="page">页码</param>
        /// <param name="pageSize">页码URL</param>
        /// <param name="rows">信息总数</param>
        /// <returns></returns>
        public DataTable GetInfoList1(string categoryId, int page, int pageSize, out int rows)
        {
            CategoryDAL categoryDal = new CategoryDAL();
            Category category = categoryDal.GetInfoByID(categoryId);
            string SqlWhere2 = "";
            /*if (DataConverter.ToInt(row["Child"]) > 0)
            {
                SqlWhere2 = "OR CategoryID in('" + row["AllChildID"].ToString().Replace(",", "','") + "')";

            }*/
            string sqlWhere = string.Format("(CategoryID='{0}' {1}) and Status='CHECKED' and Flag='1'", categoryId, SqlWhere2);
            return DbHelper.GetConn("UCenter").ExecuteDataTableByPage("vwInfoCategory", "InfoGuid", vwInfoCategoryField, sqlWhere, "BackInt asc,ShowTime desc,CreateTime desc", pageSize, page, 0, out rows);
        }



        /// <summary>
        /// 信息列表
        /// </summary>
        /// <param name="catagoryId">栏目ID</param>
        /// <param name="page">页码</param>
        /// <param name="pageSize">页码URL</param>
        /// <param name="rows">信息总数</param>
        /// <returns></returns>
        public List<vwInfoCategory> GetInfoSearchList(string appId, string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                return new List<vwInfoCategory>();
            }
            string sql = string.Format("Select top 100  {1}  from  vwInfoCategory where (Title like '%{0}%' OR BackNvarchar3='{0}') and Status='CHECKED' and Flag='1' and AppID='" + appId + "' and IsJournal<>'9' Order by ShowTime desc", key.Replace("'", "''"), vwInfoCategoryField);
            return DbHelper.GetConn("UCenter").ExecuteDataTableSql(sql).ToObjectList<vwInfoCategory>();
        }


        /// <summary>
        ///查询
        /// </summary>
        /// <param name="top"></param>
        /// <param name="key"></param>
        /// <param name="name"></param>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        //public DataTable GetInfoSearchList(string top, string key, string name, string categoryId)
        //{
        //    if (top != "")
        //    {

        //        top = "TOP " + " " + top;
        //    }
        //    CategoryDAL categoryDal = new CategoryDAL();
        //    DataRow row = categoryDal.GetTreeInfoByID(categoryId);
        //    string SqlWhere = "";
        //    string SqlKeyWhere = "";
        //    if (name != "" && key == "")
        //    {
        //        SqlKeyWhere = string.Format("  and Title  like  '%{0}%'  ", name);
        //    }
        //    else if (name == "" && key != "")
        //    {
        //        SqlKeyWhere = string.Format("  and BackNvarchar3  like  '%{0}%'  ", key);
        //    }
        //    else if (name != "" && key != "")
        //    {
        //        SqlKeyWhere = string.Format("  and Title  like  '%{0}%'  and BackNvarchar3 like  '%{1}%'", name, key);
        //    }
        //    if (DataConverter.ToInt(row["Child"]) > 0)
        //    {
        //        SqlWhere = "OR CategoryID in('" + row["AllChildID"].ToString().Replace(",", "','") + "')";

        //    }
        //    string Sql = string.Format("SELECT {0} {3}  FROM  vwInfoCategory where (CategoryID='{1}' {2} ) {4} and Status='CHECKED' and Flag='1' order by   BackInt asc, ShowTime desc,CreateTime desc", top, categoryId, SqlWhere, vwInfoCategoryField, SqlKeyWhere);
        //    return DbHelper.GetConn("UCenter").ExecuteDataTableSql(Sql);
        //}

        /// <summary>
        /// 详细信息链接
        /// </summary>
        /// <param name="categoryId">信息栏目ID</param>
        /// <param name="infoGuid">信息ID</param>
        /// <returns></returns>

        public string GetPageUrl(string categoryId, string infoGuid, bool createHtml)
        {
            vwInfoCategory info = GetInfoDetail(infoGuid, categoryId);
            return GetPageUrl(info, createHtml);
        }

        public string GetPageUrl(vwInfoCategory row)
        {
            return GetPageUrl(row, ConfigHelper.GetConfigBool("AutoCreateHtml"));
        }

        /// <summary>
        ///详细信息链接
        /// </summary>
        /// <param name="row">信息列</param>
        /// <returns></returns>
        public string GetPageUrl(vwInfoCategory row, bool createHtml)
        {
            string url = "";
            if (row == null)
            {
                return "#";
            }
            if (row.InfoType == "LinkInfo")
            {
                return row.BackNvarchar4 + "\" target=\"_blank";
            }
            if (createHtml)
            {
                CategoryDAL categtoyDal = new CategoryDAL();
                string categoryPath = categtoyDal.GetParentPathByID(row.CategoryID.ToString());
                //return string.Format("{2}{0}/infodetail/{1}.html", categoryPath, row.InfoGuid.ToString(), ConfigHelper.GetConfigString("BaseURI", "/"));
                url= string.Format("{2}{0}/infodetail/{1}.html", categoryPath, row.ID, ConfigHelper.GetConfigString("BaseURI", "/"));
            }
            else
            {
                //return string.Format("{2}InfoDetail?infoId={1}&CategoryID={0}", row.CategoryID, row.InfoGuid, SiteCommonIPS.GetBaseUrl());
                url= string.Format("{2}Default/InfoDetail?infoId={1}&CategoryID={0}", row.CategoryID, row.ID, ConfigHelper.GetConfigString("BaseURI", "/"));
            }
            return url;
        }



        public string GetVoteUrl(string id)
        {

            if (ConfigHelper.GetConfigBool("AutoCreateHtml"))
            {
                return string.Format("{0}html/vote/vote{1}.html", ConfigHelper.GetConfigString("BaseURI", "/"), id);
            }
            else
            {
                return string.Format("{1}Default.aspx?m=vote&id={0}", id, ConfigHelper.GetConfigString("BaseURI", "/"));
            }

        }


        /// <summary>
        /// 判断图片路径
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public string PathJudgment(string path)
        {
            if (path.StartsWith("http://"))
            {
                return path;
            }
            else if (path.StartsWith("/"))
            {
                return path;
            }
            else
            {
                return ConfigHelper.GetConfigString("BaseURI", "/") + path;
            }
        }
        /// <summary>
        /// 更新访问次数
        /// </summary>
        /// <param name="categoryId"></param>
        /// <param name="infoguid"></param>
        /// <returns></returns>
        public int UpdateViewCount(string categoryId, string infoguid)
        {
            int i = 0;
            try
            {
                ArrayList sqllist = new ArrayList();
                string Sql = "";
                Sql = string.Format("UPDATE Information SET ViewCount=ViewCount+1 WHERE InfoGuid='{0}'", infoguid);
                sqllist.Add(Sql);
                Sql = string.Format("UPDATE InformationCategoryRelation SET ViewCount=ViewCount+1 WHERE InfoGuid='{0}' And  CategoryID='{1}'", infoguid, categoryId);
                sqllist.Add(Sql);
                DbHelper.GetConn("UCenter").ExecuteNonQueryTran(sqllist);
                string Sql1 = string.Format("select ViewCount FROM Information WHERE InfoGuid='{0}'", infoguid);
                return DbHelper.GetConn("UCenter").GetSingleInt(Sql1);
            }
            catch (Exception)
            {
                return i;
            }
        }
        /// <summary>
        /// 根据infoguid查询信息访问次数
        /// </summary>
        /// <param name="infoguid"></param>
        /// <returns></returns>
        public int SelectViewCount(string infoguid)
        {
            string Sql = string.Format("select ViewCount FROM Information WHERE InfoGuid='{0}'", infoguid);
            return DbHelper.GetConn("UCenter").GetSingleInt(Sql);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataTable GetNumByGroupName()
        {
            string sql = "select count(*) y,GroupName name from Information group by GroupName";
            return DbHelper.GetConn("UCenter").ExecuteDataTableSql(sql);
        }
        /// <summary>
        /// 专题栏目名称
        /// </summary>
        string[] SpecialName = { "专题首页", "图片新闻", "贯彻学习", "专题新闻", "评论与解读", "上海气象局", "中国气象局", "专题图片", "抗台动态", "政府之声", "最新台风消息", "气象服务", "台风知识", "灾害防御" };

        /// <summary>
        /// 政治学习宣传专题
        /// </summary>
        /// <param name="parentId">专题CategorgID</param>
        /// <param name="numId">专题子级Id编号</param>
        //public string GetSpecialEPSUrl(string parentId, int numId)
        //{
        //    CategoryDAL categoryDal = new CategoryDAL();
        //    return categoryDal.GetSpecialCategorgID(parentId, SpecialName[numId]);
        //}
        /// <summary>
        /// 过滤危险字符
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string fliteringRisk(string key)
        {

            key = key.Replace("|", "");
            key = key.Replace("&", "");
            key = key.Replace(";", "");
            key = key.Replace("$", "");
            key = key.Replace("%", "");
            key = key.Replace("@", "");
            key = key.Replace("at", "");
            key = key.Replace("'", "''");
            key = key.Replace("\"", "");
            key = key.Replace("\\'", "");
            key = key.Replace("\\\"", "");
            key = key.Replace("<", "");
            key = key.Replace(">", "");
            key = key.Replace("(", "");
            key = key.Replace(")", "");
            key = key.Replace("+", "");
            key = key.Replace("CR", "");
            key = key.Replace("ASCII", "");
            key = key.Replace("0x0d", "");
            key = key.Replace("ASCII 0x0d", "");
            key = key.Replace("LF", "");
            key = key.Replace("ASCII", "");
            key = key.Replace("0x0a", "");
            key = key.Replace("ASCII 0x0a", "");
            key = key.Replace(",", "");
            key = key.Replace("\\", "");
            return key;
        }

    }
}
