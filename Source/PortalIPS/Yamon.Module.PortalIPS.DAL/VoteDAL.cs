
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

namespace Yamon.Module.PortalIPS.DAL
{
    /// <summary>
    /// 投票模型实体类
    ///</summary>
    public partial class VoteDAL : _VoteDAL
    {
        public DataRow GetOpenVote(string appId)
        {
            string Sql = " select top 1 * FROM  Vote_Vote  where Status='1' order by StartTime";
            return Db.ExecuteDataRowSql(Sql);
        }


        /// <summary>
        /// 根据VoteID调查
        /// </summary>
        /// <returns></returns>
        public DataRow GetOpenVoteByVoteID(string voteId)
        {

            Parameters p = new Parameters();
            p.AddInParameter("@VoteID", DbType.AnsiString, voteId);
            string Sql = "select * FROM  Vote_Vote  where VoteID=@VoteID";
            return Db.ExecuteDataRowSql(Sql, p);
        }

        public string GetPageUrl(DataRow voteInfo)
        {
            return GetPageUrl(voteInfo, ConfigHelper.GetConfigBool("AutoCreateHtml"));
        }

        /// <summary>
        ///详细信息链接
        /// </summary>
        /// <param name="row">信息列</param>
        /// <returns></returns>
        public string GetPageUrl(DataRow voteInfo, bool createHtml)
        {
            if (voteInfo == null)
            {
                return "#";
            }

            if (createHtml)
            {
                CategoryDAL categtoyDal = new CategoryDAL();
                string categoryPath = categtoyDal.GetParentPathByID(voteInfo["CategoryID"].ToString());
                return string.Format("{2}{3}/{0}/infodetail/{1}.html", categoryPath, voteInfo["VoteID"], ConfigHelper.GetConfigString("BaseURI", "/"), voteInfo["AppID"]);
            }
            else
            {
                return string.Format("{2}InfoDetail?infoId={1}&CategoryID={0}", voteInfo["CategoryID"], voteInfo["VoteID"], SiteCommonIPS.GetBaseUrl());
            }
        }
    }
}
