
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
using System;
using System.Reflection;

namespace Yamon.Module.PortalIPS.DAL
{
    /// <summary>
    /// 信息内容实体类
    ///</summary>
    public partial class SMB_InformationDAL : _SMB_InformationDAL
    {

        public override int InsertByModel(object obj)
        {
            SMB_Information model = (SMB_Information)obj;
            model.ContentNoHTML= StringHelper.FilterScript(model.Content, "html");
            model.InfoGuid = RequestHelper.GetString("InfoGuid");
            List<SqlParametersKeyValue> sqllist = new List<SqlParametersKeyValue>();
            sqllist.Add(GetInsertByModelSql(model));
            sqllist.AddRange(SaveInformationCategoryRelation(RequestHelper.GetRequestNameValueCollection()));
            return Db.ExecuteNonQueryTran(sqllist);
        }

        public override int UpdateByModel(object obj)
        {
            SMB_Information model = (SMB_Information)obj;
            model.ContentNoHTML = StringHelper.FilterScript(model.Content, "html");
            List<SqlParametersKeyValue> sqllist = new List<SqlParametersKeyValue>();
            
            MyNameValueCollection nv = RequestHelper.GetRequestNameValueCollection();
            string status = nv.GetString("Status");
            if (status == "REFUSED" || status == "CHECKED")
            {
                nv.Set("Auditor", CookieHelper.GetCookie("UserName"));
                nv.Set("AuditorName", CookieHelper.GetCookie("TrueName"));
                nv.Set("AuditTime", DateTime.Now.ToString());

                nv.Set("Publisher", CookieHelper.GetCookie("UserName"));
                nv.Set("PublisherName", CookieHelper.GetCookie("TrueName"));
                nv.Set("PublishTime", DateTime.Now.ToString());
            }
            

            if (nv.GetInt("SaveAndAudit") == 0 && (status == "REFUSED" || status == "CHECKED"))
            {
                sqllist.AddRange(SaveInformationCategoryRelation(nv));
            }
            else
            {
                sqllist.Add(GetUpdateByModelSql(model));
                sqllist.AddRange(SaveInformationCategoryRelation(nv));
            }
            return Db.ExecuteNonQueryTran(sqllist);
        }
       

        /// <summary>
        /// 重审
        /// </summary>
        /// <param name="categoryId"></param>
        /// <param name="infoGuid"></param>
        /// <returns></returns>
        public int ReAuditInfo(string categoryId, string infoGuid)
        {
            Parameters p = new Parameters();
            p.AddInParameter("@InfoGuid", DbType.AnsiString, infoGuid);
            p.AddInParameter("@CategoryID", DbType.AnsiString, categoryId);
            p.AddInParameter("@LastModifier", DbType.AnsiString, CookieHelper.GetCookie("UserName"));
            p.AddInParameter("@LastModifierName", DbType.AnsiString, CookieHelper.GetCookie("TrueName"));
            p.AddInParameter("@LastModifyTime", DbType.DateTime, DateTime.Now);
            p.AddInParameter("@Auditor", DbType.AnsiString, CookieHelper.GetCookie("UserName"));
            p.AddInParameter("@AuditorName", DbType.AnsiString, CookieHelper.GetCookie("TrueName"));
            p.AddInParameter("@AuditTime", DbType.DateTime, DateTime.Now);
            p.AddInParameter("@Status", DbType.AnsiString, "SUBMITTED");
            string sql = "Update InformationCategoryRelation Set Auditor=@Auditor,AuditorName=@AuditorName,AuditTime=@AuditTime,Status=@Status,LastModifier=@LastModifier,LastModifierName=@LastModifierName,LastModifyTime=@LastModifyTime Where InfoGuid=@InfoGuid AND CategoryID=@CategoryID";
            return Db.ExecuteNonQuerySql(sql, p);
        }
        /// <summary>
        /// 重审
        /// </summary>
        /// <param name="categoryId"></param>
        /// <param name="infoGuid"></param>
        /// <returns></returns>
        public int ToTop(string categoryId, string infoGuid)
        {
            Parameters p = new Parameters();
            p.AddInParameter("@InfoGuid", DbType.AnsiString, infoGuid);
            p.AddInParameter("@CategoryID", DbType.AnsiString, categoryId);
            string sql = "select BackInt From  InformationCategoryRelation Where InfoGuid=@InfoGuid AND CategoryID=@CategoryID";
            int backInt = Db.GetSingleInt(sql, p);
            if (backInt == -100)
            {
                backInt = 0;
            }
            else
            {
                backInt = -100;
            }
            p.AddInParameter("@LastModifier", DbType.AnsiString, CookieHelper.GetCookie("UserName"));
            p.AddInParameter("@LastModifierName", DbType.AnsiString, CookieHelper.GetCookie("TrueName"));
            p.AddInParameter("@LastModifyTime", DbType.DateTime, DateTime.Now);
            p.AddInParameter("@BackInt", DbType.AnsiString, backInt);
            sql = "Update InformationCategoryRelation Set BackInt=@BackInt,LastModifier=@LastModifier,LastModifierName=@LastModifierName,LastModifyTime=@LastModifyTime Where InfoGuid=@InfoGuid AND CategoryID=@CategoryID";
            return Db.ExecuteNonQuerySql(sql, p);
        }

        public int ToBold(string infoGuid, int value)
        {
            string infoIds = infoGuid.Replace(",", "','");
            Parameters p = new Parameters();
            p.AddInParameter("@LastModifier", DbType.AnsiString, CookieHelper.GetCookie("UserName"));
            p.AddInParameter("@LastModifierName", DbType.AnsiString, CookieHelper.GetCookie("TrueName"));
            p.AddInParameter("@LastModifyTime", DbType.DateTime, DateTime.Now);
            p.AddInParameter("@BackBoolean1", DbType.Int32, value);
            string sql = "Update Information Set BackBoolean1=@BackBoolean1,LastModifier=@LastModifier,LastModifierName=@LastModifierName,LastModifyTime=@LastModifyTime Where InfoGuid in('" + infoIds + "')";
            return Db.ExecuteNonQuerySql(sql, p);
        }

        public int Checks(string ids, string value)
        {
            string infoIds = ids.Replace(",", "','");
            Parameters p = new Parameters();
            p.AddInParameter("@LastModifier", DbType.AnsiString, CookieHelper.GetCookie("UserName"));
            p.AddInParameter("@LastModifierName", DbType.AnsiString, CookieHelper.GetCookie("TrueName"));
            p.AddInParameter("@LastModifyTime", DbType.DateTime, DateTime.Now);
            p.AddInParameter("@Status", DbType.AnsiString, value);
            p.AddInParameter("@Auditor", DbType.AnsiString, CookieHelper.GetCookie("UserName"));
            p.AddInParameter("@AuditorName", DbType.AnsiString, CookieHelper.GetCookie("TrueName"));
            p.AddInParameter("@AuditTime", DbType.DateTime, DateTime.Now);
            string sql = "Update InformationCategoryRelation Set Status=@Status,Auditor=@Auditor,AuditorName=@AuditorName,AuditTime=@AuditTime,LastModifier=@LastModifier,LastModifierName=@LastModifierName,LastModifyTime=@LastModifyTime Where Status in ('SUBMITTED','SAVED') and ID in('" + infoIds + "')";
            return Db.ExecuteNonQuerySql(sql, p);
        }

        public int Audits(string infoGuid, string value)
        {
            string infoIds = infoGuid.Replace(",", "','");
            Parameters p = new Parameters();
            p.AddInParameter("@LastModifier", DbType.AnsiString, CookieHelper.GetCookie("UserName"));
            p.AddInParameter("@LastModifierName", DbType.AnsiString, CookieHelper.GetCookie("TrueName"));
            p.AddInParameter("@LastModifyTime", DbType.DateTime, DateTime.Now);
            p.AddInParameter("@Status", DbType.AnsiString, value);
            p.AddInParameter("@Publisher", DbType.AnsiString, CookieHelper.GetCookie("UserName"));
            p.AddInParameter("@PublisherName", DbType.AnsiString, CookieHelper.GetCookie("TrueName"));
            p.AddInParameter("@PublishTime", DbType.DateTime, DateTime.Now);
            string sql = "Update InformationCategoryRelation Set Status=@Status,Publisher=@Publisher,PublisherName=@PublisherName,PublishTime=@PublishTime,LastModifier=@LastModifier,LastModifierName=@LastModifierName,LastModifyTime=@LastModifyTime Where Status='CHECKED' and InfoGuid in('" + infoIds + "')";
            return Db.ExecuteNonQuerySql(sql, p);
        }


        /// <summary>
        /// 获取固定长度的字符串
        /// </summary>
        /// <param name="num"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        private string GetFixedStringByNumber(int num, int length)
        {
            if (num.ToString().Length > length)
            {
                return num.ToString();
            }

            string str = "";
            for (int i = 0; i < length; i++)
            {
                if (num.ToString().Length + i >= length)
                {
                    str += num.ToString()[num.ToString().Length + i - length].ToString();
                }
                else
                {
                    str += "0";
                }
            }
            return str;
        }

        /// <summary>
        /// 保存栏目关系
        /// </summary>
        /// <param name="nv"></param>
        /// <returns></returns>
        public List<SqlParametersKeyValue> SaveInformationCategoryRelation(MyNameValueCollection nv)
        {
            int orderNum = nv.GetInt("BackInt");
            string[] categoryId = (nv.GetString("CategoryID")).Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            try
            {
                string delcate = "";
                foreach (string item in categoryId)
                {
                    delcate += "'" + item + "',";
                }
                delcate = delcate.TrimEnd(',');
                string sqldel = " update  InformationCategoryRelation set Status='DELETED' where CategoryID not in (" + delcate + ") and InfoGuid='" + nv.Get("InfoGuid") + "'";
                Db.ExecuteNonQuerySql(sqldel);
            }
            catch (Exception)
            {

            }
            //


            List<SqlParametersKeyValue> sqllist = new List<SqlParametersKeyValue>();
            for (int i = 0; i < categoryId.Length; i++)
            {
                Parameters p = new Parameters();
                p.AddInParameter("@InfoGuid", DbType.AnsiString, nv.Get("InfoGuid"));
                p.AddInParameter("@BackInt", DbType.Int32, orderNum);
                p.AddInParameter("@CategoryID", DbType.AnsiString, categoryId[i]);
                string status = nv.Get("Status");
                int count = Db.GetSingleInt(string.Format("select count(1) from InformationCategoryRelation where InfoGuid='{0}' AND CategoryID='{1}'", nv.Get("InfoGuid"), categoryId[i]));
                string sql = "";

                if (count > 0)
                {
                    string fields = "";
                    if (status == "CHECKED")
                    {
                        fields = "Auditor=@Auditor,AuditorName=@AuditorName,AuditTime=@AuditTime,";
                        CategoryDAL categoryDal = new CategoryDAL();
                        Category categroyInfo = categoryDal.GetModelByID(categoryId[i]);

                    }

                    fields += "Publisher=@Publisher,PublisherName=@PublisherName,PublishTime=@PublishTime,";
                    sql = "Update InformationCategoryRelation Set " + fields + "BackInt=@BackInt,Status=@Status,LastModifier=@LastModifier,LastModifierName=@LastModifierName,LastModifyTime=@LastModifyTime,ShowTime=@ShowTime Where InfoGuid=@InfoGuid AND CategoryID=@CategoryID";
                }
                else
                {
                    string fields1 = "";
                    string fields2 = "";
                    if (nv.Get("Status") == "CHECKED")
                    {
                        fields1 = "Auditor,AuditorName,AuditTime,";
                        fields2 = "@Auditor,@AuditorName,@AuditTime,";

                        CategoryDAL categoryDal = new CategoryDAL();
                        Category categroyInfo = categoryDal.GetModelByID(categoryId[i]);

                    }

                    fields1 += "Publisher,PublisherName,PublishTime,";
                    fields2 += "@Publisher,@PublisherName,@PublishTime,";
                    sql = "Insert Into InformationCategoryRelation(" + fields1 + "InfoGuid,CategoryID,JournalID,LastModifier,LastModifierName,LastModifyTime,ShowTime,Status,ViewCount,BackInt) Values(" + fields2 + "@InfoGuid,@CategoryID,'00000000-0000-0000-0000-000000000000',@LastModifier,@LastModifierName,@LastModifyTime,@ShowTime,@Status,@ViewCount,@BackInt)";
                }

                p.AddInParameter("@LastModifier", DbType.AnsiString, nv.Get("LastModifier"));
                p.AddInParameter("@LastModifierName", DbType.AnsiString, nv.Get("LastModifierName"));
                p.AddInParameter("@LastModifyTime", DbType.DateTime, nv.Get("LastModifyTime"));
                p.AddInParameter("@Auditor", DbType.AnsiString, nv.Get("Auditor"));
                p.AddInParameter("@AuditorName", DbType.AnsiString, nv.Get("AuditorName"));
                p.AddInParameter("@AuditTime", DbType.DateTime, nv.Get("AuditTime"));
                p.AddInParameter("@Publisher", DbType.AnsiString, nv.Get("Publisher"));
                p.AddInParameter("@PublisherName", DbType.AnsiString, nv.Get("PublisherName"));
                p.AddInParameter("@PublishTime", DbType.DateTime, nv.Get("PublishTime"));
                p.AddInParameter("@ShowTime", DbType.DateTime, nv.Get("ShowTime"));
                p.AddInParameter("@Status", DbType.AnsiString, status);
                p.AddInParameter("@ViewCount", DbType.Int32, nv.GetInt("ViewCount"));
                sqllist.Add(new SqlParametersKeyValue(sql, p));
            }
            return sqllist;
        }



        /// <summary>
        ///移动栏目关系
        /// </summary>
        /// <param name="nv"></param>
        /// <returns></returns>
        public int MoveInformation(string categoryIds, string infoGuids, string oldCategoryId)
        {
            string[] categoryId = categoryIds.Split(',');
            string[] infoGuid = infoGuids.Split(',');
            List<SqlParametersKeyValue> sqllist = new List<SqlParametersKeyValue>();

            for (int j = 0; j < infoGuid.Length; j++)
            {
                DataRow row = Db.ExecuteDataRowSql(string.Format("select * from InformationCategoryRelation where InfoGuid='{0}' AND CategoryID='{1}'", infoGuid[j], oldCategoryId));
                if (row != null)
                {
                    for (int i = 0; i < categoryId.Length; i++)
                    {
                        Parameters p = new Parameters();
                        p.AddInParameter("@InfoGuid", DbType.AnsiString, row["InfoGuid"].ToString());
                        p.AddInParameter("@CategoryID", DbType.AnsiString, categoryId[i]);
                        p.AddInParameter("@OldCategoryID", DbType.AnsiString, oldCategoryId);
                        p.AddInParameter("@LastModifier", DbType.AnsiString, CookieHelper.GetCookie("UserName"));
                        p.AddInParameter("@LastModifierName", DbType.AnsiString, CookieHelper.GetCookie("TrueName"));
                        p.AddInParameter("@LastModifyTime", DbType.DateTime, DateTime.Now);
                        string sql = "Delete InformationCategoryRelation Where InfoGuid=@InfoGuid AND CategoryID=@CategoryID";
                        sqllist.Add(new SqlParametersKeyValue(sql, p));
                        sql = "Update InformationCategoryRelation Set  CategoryID=@CategoryID,LastModifier=@LastModifier,LastModifierName=@LastModifierName,LastModifyTime=@LastModifyTime Where InfoGuid=@InfoGuid AND CategoryID=@OldCategoryID";
                        sqllist.Add(new SqlParametersKeyValue(sql, p));
                    }
                }
            }
            return Db.ExecuteNonQueryTran(sqllist);
        }
        /// <summary>
        /// 保存栏目关系
        /// </summary>
        /// <param name="nv"></param>
        /// <returns></returns>
        public int CopyInformation(string categoryIds, string infoGuids)
        {
            string[] categoryId = categoryIds.Split(',');
            string[] infoGuid = infoGuids.Split(',');
            List<SqlParametersKeyValue> sqllist = new List<SqlParametersKeyValue>();

            for (int j = 0; j < infoGuid.Length; j++)
            {
                DataRow row = Db.ExecuteDataRowSql("select InfoGuid,ShowTime from Information where InfoGuid='" + infoGuid[j] + "'");
                if (row != null)
                {
                    for (int i = 0; i < categoryId.Length; i++)
                    {
                        Parameters p = new Parameters();
                        p.AddInParameter("@InfoGuid", DbType.AnsiString, row["InfoGuid"].ToString());
                        p.AddInParameter("@CategoryID", DbType.AnsiString, categoryId[i]);
                        p.AddInParameter("@LastModifier", DbType.AnsiString, CookieHelper.GetCookie("UserName"));
                        p.AddInParameter("@LastModifierName", DbType.AnsiString, CookieHelper.GetCookie("TrueName"));
                        p.AddInParameter("@LastModifyTime", DbType.DateTime, DateTime.Now);

                        p.AddInParameter("@ShowTime", DbType.DateTime, row["ShowTime"]);
                        p.AddInParameter("@Status", DbType.AnsiString, "SUBMITTED");
                        p.AddInParameter("@ViewCount", DbType.Int32, 0);
                        int count = Db.GetSingleInt(string.Format("select count(1) from InformationCategoryRelation where InfoGuid='{0}' AND CategoryID='{1}'", infoGuid[j], categoryId[i]));
                        string sql = "";
                        if (count == 0)
                        {
                            sql = "Insert Into InformationCategoryRelation(InfoGuid,CategoryID,JournalID,LastModifier,LastModifierName,LastModifyTime,ShowTime,Status,ViewCount) Values(@InfoGuid,@CategoryID,'00000000-0000-0000-0000-000000000000',@LastModifier,@LastModifierName,@LastModifyTime,@ShowTime,@Status,@ViewCount)";
                            sqllist.Add(new SqlParametersKeyValue(sql, p));
                        }
                    }
                }
            }
            return Db.ExecuteNonQueryTran(sqllist);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="nv"></param>
        /// <returns></returns>
        public int DelInformationCategory(string categoryId, string ids)
        {
            string[] arrId = ids.Split(',');
            List<SqlParametersKeyValue> sqllist = new List<SqlParametersKeyValue>();
            for (int i = 0; i < arrId.Length; i++)
            {
                Parameters p = new Parameters();
                //p.AddInParameter("@InfoGuid", DbType.AnsiString, arrId[i]);
                //p.AddInParameter("@CategoryID", DbType.AnsiString, categoryId);
                //p.AddInParameter("@Status", DbType.AnsiString, "DELETED");
                //p.AddInParameter("@LastModifier", DbType.AnsiString, CookieHelper.GetCookie("UserName"));
                //p.AddInParameter("@LastModifierName", DbType.AnsiString, CookieHelper.GetCookie("TrueName"));
                //p.AddInParameter("@LastModifyTime", DbType.DateTime, DateTime.Now);
                //string sql = "Update InformationCategoryRelation Set Status=@Status,LastModifier=@LastModifier,LastModifierName=@LastModifierName,LastModifyTime=@LastModifyTime Where InfoGuid=@InfoGuid AND CategoryID=@CategoryID";

                p.AddInParameter("@ID", DbType.AnsiString, arrId[i]);
                p.AddInParameter("@Status", DbType.AnsiString, "DELETED");
                p.AddInParameter("@LastModifier", DbType.AnsiString, CookieHelper.GetCookie("UserName"));
                p.AddInParameter("@LastModifierName", DbType.AnsiString, CookieHelper.GetCookie("TrueName"));
                p.AddInParameter("@LastModifyTime", DbType.DateTime, DateTime.Now);
                string sql = "Update InformationCategoryRelation Set Status=@Status,LastModifier=@LastModifier,LastModifierName=@LastModifierName,LastModifyTime=@LastModifyTime Where ID=@ID ";

                sqllist.Add(new SqlParametersKeyValue(sql, p));
            }
            return Db.ExecuteNonQueryTran(sqllist);
        }

        public override SMB_Information GetEditFormDefaultValue(SMB_Information model)
        {
            model.CategoryID = Db.ExecuteStringSql("Select CategoryID from  InformationCategoryRelation where InfoGuid='" + model.InfoGuid + "'");
            return base.GetModelValue(model);
        }

        //讲者
        public MyNameValueCollection NameValue_Author
        {
            get
            {
                MyNameValueCollection nv = new MyNameValueCollection();
                string author = Db.ExecuteStringSqlEx("SELECT Author FROM Information where Author<>'' or Author<>null group by Author");
                string[] authorList = author.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string item in authorList)
                {
                    nv.Add(item, item);
                }
                return nv;
            }
        }
        //系列
        public MyNameValueCollection NameValue_Series
        {
            get
            {
                MyNameValueCollection nv = new MyNameValueCollection();
                CategoryDAL categoryDal = new CategoryDAL();
                List<Category> list = categoryDal.GetEntityList("flag='1'and IsJournal='2' and C_ParentID!=''");
                foreach (Category item in list)
                {
                    nv.Add(item.CategoryID, item.DisplayName);
                }
                return nv;
            }
        }

        public MyNameValueCollection NameValue_CategoryID
        {
            get
            {
                MyNameValueCollection nv = new MyNameValueCollection();
                CategoryDAL categoryDal = new CategoryDAL();
                List<Category> list = categoryDal.GetEntityList("flag='1'and IsJournal='0' and C_ParentID!=''");
                foreach (Category item in list)
                {
                    nv.Add(item.CategoryID, item.DisplayName);
                }
                return nv;
            }
        }
    }
}
