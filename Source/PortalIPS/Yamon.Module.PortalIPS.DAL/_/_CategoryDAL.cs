﻿
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由亚萌智能表单代码生成工具生成。
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。除非此项目不再使用代码生成器生成。
//     如果想修改此文件的方法，请在此文件的上级目录中的CategoryDAL重写(override)该方法。
//     如有问题联系zongeasy@qq.com
//
//</auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ComponentModel;
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
    /// 栏目管理实体类
    ///</summary>
    public partial class _CategoryDAL : BaseModelDAL<Category>
    {
        public _CategoryDAL():base("UCenter")
        {
        }

		/// <summary>
        /// 父级栏目名称（C_ParentID）字段的数据集合（键值对）
        /// </summary>
		public MyNameValueCollection NameValue_C_ParentID
		{
			get
			{
			    Yamon.Module.PortalIPS.DAL.CategoryDAL dal = new Yamon.Module.PortalIPS.DAL.CategoryDAL();
                string cacheKey = dal.CacheKeyPrefix + "NameValue_Category";
                object obj=CacheHelper.Get(cacheKey);
                if (obj == null)
                {
                   obj= dal.GetAllEntityTable_AppID("C_ParentID,CategoryName").ToNameValueCollection();
                   CacheHelper.Insert(cacheKey,obj);
                }
                return (MyNameValueCollection) obj;

			}
		}
		/// <summary>
        /// 栏目类型（CategoryType）字段的数据集合（键值对）
        /// </summary>
		public MyNameValueCollection NameValue_CategoryType
		{
			get
			{
			    Yamon.Module.PortalIPS.DAL.CategoryTypeDAL dal = new Yamon.Module.PortalIPS.DAL.CategoryTypeDAL();
                string cacheKey = dal.CacheKeyPrefix + "NameValue_CategoryType";
                object obj=CacheHelper.Get(cacheKey);
                if (obj == null)
                {
                   obj= dal.GetAllEntityTable("TypeName,DisplayName").ToNameValueCollection();
                   CacheHelper.Insert(cacheKey,obj);
                }
                return (MyNameValueCollection) obj;

			}
		}
		/// <summary>
        /// 栏目类型（BackNvarchar2）字段的数据集合（键值对）
        /// </summary>
		public MyNameValueCollection NameValue_BackNvarchar2
		{
			get
			{
			    MyNameValueCollection nv=new MyNameValueCollection();
                nv.Add("容器栏目", "容器栏目");
                nv.Add("多信息", "多信息");
                nv.Add("单信息", "单信息");
                nv.Add("单页面", "单页面");
                nv.Add("映射栏目", "映射栏目");
                nv.Add("外部链接", "外部链接");
                return nv;

			}
		}
		/// <summary>
        /// 栏目显示类型（IsJournal）字段的数据集合（键值对）
        /// </summary>
		public MyNameValueCollection NameValue_IsJournal
		{
			get
			{
			    MyNameValueCollection nv=new MyNameValueCollection();
                nv.Add("1", "普通栏目");
                nv.Add("14", "普通栏目（导航不显示）");
                nv.Add("0", "前台栏目");
                nv.Add("9", "后台栏目");
                return nv;

			}
		}
		/// <summary>
        /// 信息类型（CategoryInfoType）字段的数据集合（键值对）
        /// </summary>
		public MyNameValueCollection NameValue_CategoryInfoType
		{
			get
			{
			    Yamon.Module.PortalIPS.DAL.InfoTypeDAL dal = new Yamon.Module.PortalIPS.DAL.InfoTypeDAL();
                string cacheKey = dal.CacheKeyPrefix + "NameValue_InfoType";
                object obj=CacheHelper.Get(cacheKey);
                if (obj == null)
                {
                   obj= dal.GetAllEntityTable("InfoTypeName,InfoTypeDisplayName").ToNameValueCollection();
                   CacheHelper.Insert(cacheKey,obj);
                }
                return (MyNameValueCollection) obj;

			}
		}
		/// <summary>
        /// 是否启用（Flag）字段的数据集合（键值对）
        /// </summary>
		public MyNameValueCollection NameValue_Flag
		{
			get
			{
			    MyNameValueCollection nv=new MyNameValueCollection();
                nv.Add("1", "是");
                nv.Add("0", "否");
                return nv;

			}
		}
		/// <summary>
        /// 是否需要发布（BackNvarchar1）字段的数据集合（键值对）
        /// </summary>
		public MyNameValueCollection NameValue_BackNvarchar1
		{
			get
			{
			    MyNameValueCollection nv=new MyNameValueCollection();
                nv.Add("是", "是");
                nv.Add("否", "否");
                return nv;

			}
		}
		/// <summary>
        /// 是否设为热门专题（IsTopMenuToPage）字段的数据集合（键值对）
        /// </summary>
		public MyNameValueCollection NameValue_IsTopMenuToPage
		{
			get
			{
			    MyNameValueCollection nv=new MyNameValueCollection();
                nv.Add("0", "否");
                nv.Add("1", "是");
                return nv;

			}
		}



		/// <summary>
		/// 获取数据实体列表(过滤)
		///</summary>
		/// <param name="nv">页面传递参数集合</param>
		/// <param name="topN">数据条数</param>
		/// <param name="fields">查询的字段</param>
		/// <returns>实体列表</returns>
        public virtual List<Category> GetEntityList_AppID(int topN = 0,string fields="")
        {
            object[] arrParams = new object[] { "InfoCategory" };
            return GetEntityList("1=1 AND CategoryType=? ",arrParams, "", topN,fields);
        }
		
		/// <summary>
		/// 获取数据实体列表(过滤)
		///</summary>
		/// <param name="fields">查询的字段</param>
		/// <returns>实体列表</returns>
        public virtual List<Category> GetAllEntityList_AppID(string fields="")
        {
            return GetEntityList_AppID(0,fields);
        }
		
		/// <summary>
		/// 获取分页的数据实体列表(过滤)
		///</summary>
		/// <param name="totalRows">记录总条数（out）</param>
		/// <param name="nv">页面传递参数集合</param>
		/// <param name="topN">数据条数</param>
		/// <param name="page">页码</param>
		/// <param name="rows">每页记录数</param>
		/// <param name="orderBy">排序</param>
		/// <returns>实体列表</returns>
        public virtual List<Category> GetEntityListByPage_AppID(out int totalRows,int topN = 0, int page=1,int rows=20,string orderBy="")
        {
			string order = "";
			if (!string.IsNullOrEmpty(orderBy))
			{
			   order = orderBy;
			}
			object[] searchParams;
			string where = GetSearchSql("", out searchParams);
			object[] arrParams = new object[] { "InfoCategory" };
            arrParams=arrParams.Concat(searchParams).ToArray();
            string fields="C_ParentID,ParentID,CategoryID,CategoryName,DisplayName,BackNvarchar2,IsJournal,CategoryInfoType,OrderNum,IconName,Flag,BackNvarchar1,CategoryPath";
            return GetEntityListByPage("1=1 AND CategoryType=? "+ where, arrParams,order,fields ,rows,page,topN,out totalRows);
        }
		
		/// <summary>
		/// 获取数据列表DataTable(过滤)
		///</summary>
		/// <param name="nv">页面传递参数集合</param>
		/// <param name="topN">数据条数</param>
		/// <param name="fields">查询的字段</param>
		/// <returns>数据列表</returns>
        public virtual DataTable GetEntityTable_AppID(int topN = 0,string fields="")
        {
            object[] arrParams = new object[] { "InfoCategory" };
            return GetEntityTable("1=1 AND CategoryType=? ",arrParams, "", topN,fields);
        }
		
		/// <summary>
		/// 获取数据列表DataTable(过滤)
		///</summary>
		/// <param name="fields">查询的字段</param>
		/// <returns>数据列表</returns>
        public virtual DataTable GetAllEntityTable_AppID(string fields="")
        {
        	return GetEntityTable_AppID(0,fields);
        }
		/// <summary>
		/// 获取分页的数据列表DataTable(过滤)
		///</summary>
		/// <param name="totalRows">记录总条数（out）</param>
		/// <param name="nv">页面传递参数集合</param>
		/// <param name="topN">数据条数</param>
		/// <param name="page">页码</param>
		/// <param name="rows">每页记录数</param>
		/// <param name="orderBy">排序</param>
		/// <returns>DataTable</returns>
        public virtual DataTable GetEntityTableByPage_AppID(out int totalRows,int topN = 0, int page=1,int rows=20,string orderBy="")
        {
			string order = "";
			if (!string.IsNullOrEmpty(orderBy))
			{
			    order = orderBy;
			}
			object[] searchParams;
			string where = GetSearchSql("", out searchParams);
			object[] arrParams = new object[] { "InfoCategory" };
            arrParams=arrParams.Concat(searchParams).ToArray();
            string fields="C_ParentID,ParentID,CategoryID,CategoryName,DisplayName,BackNvarchar2,IsJournal,CategoryInfoType,OrderNum,IconName,Flag,BackNvarchar1,CategoryPath";
            return GetEntityTableByPage("1=1 AND CategoryType=? "+ where, arrParams,order,fields, rows,page,topN,out totalRows);
        }

		/// <summary>
		/// 获取分页的数据实体列表
		///</summary>
		/// <param name="totalRows">记录总条数（out）</param>
		/// <param name="nv">页面传递参数集合</param>
		/// <param name="topN">数据条数</param>
		/// <param name="page">页码</param>
		/// <param name="rows">每页记录数</param>
		/// <param name="orderBy">排序</param>
		/// <returns>实体列表</returns>
		public virtual List<Category> GetEntityListByPage(out int totalRows,int topN = 0, int page=1,int rows=20,string orderBy="")
		{
			string order = "";
			if (!string.IsNullOrEmpty(orderBy))
			{
				order = orderBy;
			}
			object[] searchParams;
			string where = GetSearchSql("", out searchParams);
			string fields="C_ParentID,ParentID,CategoryID,CategoryName,DisplayName,BackNvarchar2,IsJournal,CategoryInfoType,OrderNum,IconName,Flag,BackNvarchar1,CategoryPath";
			return GetEntityListByPage("1=1 "+ where, searchParams,order,fields, rows,page,topN,out totalRows);
		}

		/// <summary>
		/// 获取分页的数据列表DataTable
		///</summary>
		/// <param name="totalRows">记录总条数（out）</param>
		/// <param name="nv">页面传递参数集合</param>
		/// <param name="topN">数据条数</param>
		/// <param name="page">页码</param>
		/// <param name="rows">每页记录数</param>
		/// <param name="orderBy">排序</param>
		/// <returns>DataTable</returns>
		public virtual DataTable GetEntityTableByPage(out int totalRows,int topN = 0, int page=1,int rows=20,string orderBy="")
		{
			string order = "";
			if (!string.IsNullOrEmpty(orderBy))
			{
				order = orderBy;
			}
			object[] searchParams;
			string where = GetSearchSql("", out searchParams);
			string fields="C_ParentID,ParentID,CategoryID,CategoryName,DisplayName,BackNvarchar2,IsJournal,CategoryInfoType,OrderNum,IconName,Flag,BackNvarchar1,CategoryPath";
			return GetEntityTableByPage("1=1 "+ where, searchParams,order,fields,rows,page,topN,out totalRows);
		}

		/// <summary>
        /// 拼接查询Sql语句及参数
        /// </summary>
        /// <param name="nv">页面传递的参数集合</param>
        /// <param name="notIn">排除字段</param>
        /// <param name="arrParam">out查询参数</param>
        /// <returns>查询Sql语句</returns>
		public virtual string GetSearchSql(string notIn,out object[] arrParam)
		{
			StringBuilder sb=new StringBuilder();
			string value="";
			string value1 = "";
			string value2 = "";
			ArrayList param=new ArrayList();
			arrParam=param.ToArray();
			return sb.ToString();

		}

		
	    public virtual Category GetModelValue(Category model)
        {
            return model;
        }
		/// <summary>
        /// 设置栏目管理实体(Category)的显示值
        /// </summary>
        /// <param name="model">栏目管理实体(Category)</param>
        /// <returns>栏目管理实体(Category)</returns>
		public virtual Category GetModelShowValue(Category model,bool clearValue=false)
        {
            model=GetModelValue(model);
            if (model.C_ParentID!= null)
			{
				model.C_ParentID_ShowValue=NameValue_C_ParentID.Get(model.C_ParentID.ToString());
			}
			if (model.CategoryType!=null)
			{
				model.CategoryType_ShowValue=NameValue_CategoryType.Get(model.CategoryType.ToString());
			}
			if (model.BackNvarchar2!=null)
			{
				model.BackNvarchar2_ShowValue=NameValue_BackNvarchar2.Get(model.BackNvarchar2.ToString());
			}
			if (model.IsJournal!=null)
			{
				model.IsJournal_ShowValue=NameValue_IsJournal.Get(model.IsJournal.ToString());
			}
			if (model.CategoryInfoType!=null)
			{
				model.CategoryInfoType_ShowValue=NameValue_CategoryInfoType.Get(model.CategoryInfoType.ToString());
			}
			if (model.Flag!=null)
			{
				model.Flag_ShowValue=NameValue_Flag.Get(model.Flag.ToString());
			}
			if (model.BackNvarchar1!=null)
			{
				model.BackNvarchar1_ShowValue=NameValue_BackNvarchar1.Get(model.BackNvarchar1.ToString());
			}
			if (model.IsTopMenuToPage!=null)
			{
				model.IsTopMenuToPage_ShowValue=NameValue_IsTopMenuToPage.Get(model.IsTopMenuToPage.ToString());
			}
			if(clearValue)
			{
				model.C_ParentID = null;
				model.CategoryType = null;
				model.BackNvarchar2 = null;
				model.IsJournal = null;
				model.CategoryInfoType = null;
				model.Flag = null;
				model.BackNvarchar1 = null;
				model.IsTopMenuToPage = null;
			}
			return model;
		}
		
		/// <summary>
        /// 设置栏目管理实体(Category)的列表显示值
        /// </summary>
        /// <param name="model">栏目管理实体(Category)</param>
        /// <returns>栏目管理实体(Category)</returns>
		public virtual Category GetModelGridShowValue(Category model){
			model=GetModelShowValue(model);
			return model;
        }

        public virtual Category GetInfoByID(object id){
            Category model = GetModelByID(id);
            model = GetModelShowValue(model);
            return model;
        } 


      #region 新建相关方法
		/// <summary>
        /// 设置新增入库时栏目管理实体(Category)默认值
        /// </summary>
        /// <param name="model">栏目管理实体(Category)</param>
        /// <returns>栏目管理实体(Category)</returns>
		public virtual Category GetInsertModelValue(Category model)
		{
			model.CategoryID =(Guid.NewGuid().ToString());
			model.CategoryType = "InfoCategory";
			model.AppID =CookieHelper.GetCookie("CityID");
			return model;
		}		/// <summary>
        /// 设置新建页面的栏目管理实体(Category)默认值
        /// </summary>
        /// <param name="model">栏目管理实体(Category)</param>
        /// <returns>栏目管理实体(Category)</returns>
		public virtual Category GetCreateFormDefaultValue()
		{
            Category model = new Category();
			model.CategoryID=(Guid.NewGuid().ToString());
			model.CategoryType="InfoCategory";
			model.BackNvarchar2="多信息";
			model.IsJournal=0;
			model.CategoryInfoType="CommonInfo";
			model.OrderNum=0;
			model.Flag=1;
			model.BackNvarchar1="是";
			model.IsTopMenuToPage=1;
            return model;
		}

		/// <summary>
        /// 新建数据格式验证
        /// </summary>
        /// <param name="model">栏目管理实体(Category)</param>
        public virtual void CreateFormValidator(Category model)
        {
			string value="";
			
			//CategoryID验证
			value = model.CategoryID!=null ? model.CategoryID.ToString() : "";
		            if ( string.IsNullOrEmpty(value))
		            {
		             throw new Exception("栏目ID不能为空！");
		            }
			
			//CategoryName验证
			value = model.CategoryName!=null ? model.CategoryName.ToString() : "";
		            if ( string.IsNullOrEmpty(value))
		            {
		             throw new Exception("栏目名称不能为空！");
		            }
			
			//DisplayName验证
			value = model.DisplayName!=null ? model.DisplayName.ToString() : "";
		            if ( string.IsNullOrEmpty(value))
		            {
		             throw new Exception("显示名称不能为空！");
		            }
			
			//CategoryType验证
			value = model.CategoryType!=null ? model.CategoryType.ToString() : "";
		            if ( string.IsNullOrEmpty(value))
		            {
		             throw new Exception("栏目类型不能为空！");
		            }
			
			//IsJournal验证
			value = model.IsJournal!=null ? model.IsJournal.ToString() : "";
		            if ( string.IsNullOrEmpty(value))
		            {
		             throw new Exception("栏目显示类型不能为空！");
		            }
			
			//CategoryInfoType验证
			value = model.CategoryInfoType!=null ? model.CategoryInfoType.ToString() : "";
		            if ( string.IsNullOrEmpty(value))
		            {
		             throw new Exception("信息类型不能为空！");
		            }
			
			//OrderNum验证
			value = model.OrderNum!=null ? model.OrderNum.ToString() : "";
		            if ( string.IsNullOrEmpty(value))
		            {
		             throw new Exception("排序ID不能为空！");
		            }
			
			//IconName验证
			value = model.IconName!=null ? model.IconName.ToString() : "";
		            if ( string.IsNullOrEmpty(value))
		            {
		             throw new Exception("栏目标识不能为空！");
		            }
			
			//Flag验证
			value = model.Flag!=null ? model.Flag.ToString() : "";
		            if ( string.IsNullOrEmpty(value))
		            {
		             throw new Exception("是否启用不能为空！");
		            }
			
			//CategoryPath验证
			value = model.CategoryPath!=null ? model.CategoryPath.ToString() : "";
		            if ( string.IsNullOrEmpty(value))
		            {
		             throw new Exception("栏目路径不能为空！");
		            }
            if (!string.IsNullOrEmpty(value)&&ExistsByField("CategoryPath",value))
            {
                throw new Exception(string.Format("栏目路径为({0})已存在！", value));
            }
}
      #endregion

      #region 修改相关方法
		/// <summary>
        /// 设置更新入库时栏目管理实体(Category)默认值
        /// </summary>
        /// <param name="model">栏目管理实体(Category)</param>
        /// <returns>栏目管理实体(Category)</returns>
		public virtual Category GetUpdateModelValue(Category model)
		{
			model.CategoryType =null;
			model.AppID =null;
			return model;
		}		/// <summary>
        /// 设置编辑页面的栏目管理实体(Category)默认值
        /// </summary>
        /// <param name="model">栏目管理实体(Category)</param>
        /// <returns>栏目管理实体(Category)</returns>
		public virtual Category GetEditFormDefaultValue(Category model)
		{
			return model;
		}

		/// <summary>
        /// 编辑数据格式验证
        /// </summary>
        /// <param name="model">栏目管理实体(Category)</param>
        public virtual void EditFormValidator(Category model)
        {
			string value="";
			
			//CategoryName验证
			value = model.CategoryName!=null ? model.CategoryName.ToString() : "";
		            if ( string.IsNullOrEmpty(value))
		            {
		             throw new Exception("栏目名称不能为空！");
		            }
			
			//DisplayName验证
			value = model.DisplayName!=null ? model.DisplayName.ToString() : "";
		            if ( string.IsNullOrEmpty(value))
		            {
		             throw new Exception("显示名称不能为空！");
		            }
			
			//IsJournal验证
			value = model.IsJournal!=null ? model.IsJournal.ToString() : "";
		            if ( string.IsNullOrEmpty(value))
		            {
		             throw new Exception("栏目显示类型不能为空！");
		            }
			
			//CategoryInfoType验证
			value = model.CategoryInfoType!=null ? model.CategoryInfoType.ToString() : "";
		            if ( string.IsNullOrEmpty(value))
		            {
		             throw new Exception("信息类型不能为空！");
		            }
			
			//OrderNum验证
			value = model.OrderNum!=null ? model.OrderNum.ToString() : "";
		            if ( string.IsNullOrEmpty(value))
		            {
		             throw new Exception("排序ID不能为空！");
		            }
			
			//IconName验证
			value = model.IconName!=null ? model.IconName.ToString() : "";
		            if ( string.IsNullOrEmpty(value))
		            {
		             throw new Exception("栏目标识不能为空！");
		            }
			
			//Flag验证
			value = model.Flag!=null ? model.Flag.ToString() : "";
		            if ( string.IsNullOrEmpty(value))
		            {
		             throw new Exception("是否启用不能为空！");
		            }
			
			//CategoryPath验证
			value = model.CategoryPath!=null ? model.CategoryPath.ToString() : "";
		            if ( string.IsNullOrEmpty(value))
		            {
		             throw new Exception("栏目路径不能为空！");
		            }
            if (!string.IsNullOrEmpty(value)&&ExistsByField("CategoryPath",value,model.CategoryID))
            {
                throw new Exception(string.Format("栏目路径为({0})已存在！", value));
            }
}
      #endregion

		
		/// <summary>
		/// 获取异步树栏目管理实体(Category)列表(过滤)
		///</summary>
		/// <param name="nv">页面传递的参数集合</param>
        /// <param name="parentId">上级菜单</param>
        /// <param name="fields">字段列表</param>
		/// <returns></returns>
		public virtual List<Category> GetAsyncModelTreeList_AppID(object parentId,string fields="")
		{
		  return GetAsyncTreeList_AppID(parentId, fields).ToObjectList<Category>();
		}
		
        /// <summary>
        /// 获取异步树列表(DataTable)(过滤)
        /// </summary>
        /// <param name="nv">页面传递的参数集合</param>
        /// <param name="parentId">上级菜单</param>
        /// <param name="fields">字段列表</param>
        /// <returns>栏目管理实体(Category)列表</returns>
		public virtual DataTable GetAsyncTreeList_AppID(object parentId,string fields="")
		{
		if (string.IsNullOrEmpty(fields))
		{
		    fields = AllFields;
		}
		 object[] parentParam = new object[] { parentId ,"InfoCategory",parentId,"InfoCategory"};
		 string sql = @"select {0},ChildCount from Category as a left join
		(select C_ParentID as __ParentID,count(1) as ChildCount from Category where ParentID in(
		SELECT  CategoryID  FROM Category where  C_ParentID=? AND CategoryType=?) group by C_ParentID) as b
		on a.CategoryID=b.__ParentID where  a.C_ParentID=? AND CategoryType=?";
		  sql = string.Format(sql, fields);
		  return Db.ExecuteDataTableSqlEx(sql, parentParam);
		}


        /// <summary>
        /// 获取异步树栏目管理实体(Category)列表
        /// </summary>
        /// <param name="nv">页面传递的参数集合</param>
        /// <param name="parentId">上级菜单</param>
        /// <param name="fields">字段列表</param>
        /// <returns>栏目管理实体(Category)列表</returns>
		public virtual List<Category> GetAsyncModelTreeList(object parentId,string fields="")
		{
			return GetAsyncTreeList(parentId, fields).ToObjectList<Category>();
			
		}
		
		
        /// <summary>
        /// 获取异步树列表(DataTable)
        /// </summary>
        /// <param name="nv">页面传递的参数集合</param>
        /// <param name="parentId">上级菜单</param>
        /// <param name="fields">字段列表</param>
        /// <returns>DataTable</returns>
		public virtual DataTable GetAsyncTreeList(object parentId,string fields="")
		{
			if (string.IsNullOrEmpty(fields))
			{
				fields = AllFields;
			}
			object[] parentParam = new object[] { parentId,parentId };
			string sql = @"select {0},ChildCount from Category as a left join
			(select C_ParentID as __ParentID,count(1) as ChildCount from Category where ParentID in(
			SELECT  CategoryID  FROM Category where  C_ParentID=?) group by C_ParentID) as b
			on a.CategoryID=b.__ParentID where  a.C_ParentID=?";
			sql = string.Format(sql, fields);
			return Db.ExecuteDataTableSqlEx(sql, parentParam);
		}
        /// <summary>
        /// 更新为树级实体列表
        /// </summary>
        /// <param name="list">实体列表</param>
        /// <returns>树级实体列表</returns>
		public List<Category> ModelListToTree(List<Category> list)
		{
			//查找父节点
			List<Category> rootType = list.Where(o => o.C_ParentID == "").OrderBy(o => o.OrderNum ).ToList();
			//递归主函数
			Action<Category> addChild = null;
			addChild = (info =>
				{
					var childInfo = list.Where(o => o.C_ParentID == info.CategoryID).OrderBy(o => o.OrderNum );
					if (childInfo.Count() == 0)
						return;
					childInfo.All(o =>
					{
						if (info.Children == null)
						{
							info.Children=new List<Category>();
						}
						info.Children.Add(o);
						addChild(o);
						return true;
					});
				});
			//递归调用
			rootType.ForEach(o => { addChild(o); });
			return rootType;
		}
		
		// <summary>
        /// 获取树级实体列表
        /// </summary>
        /// <returns>树级实体列表</returns>
        public List<Category> GetModelTreeList()
        {
            List<Category> list = GetAllEntityList();
            return ModelListToTree(list);
        }

        /// <summary>
        /// 保存编辑树
        /// </summary>
        /// <param name="id"></param>
        /// <param name="targetId"></param>
        /// <param name="point"></param>
        /// <returns></returns>
        public int SaveEditTree(string id, string targetId, string point)
        {
            Category targetModel = GetModelByID(targetId);
            string parentId="";
            int orderId = 0;
            if (point == "append")
            {
                parentId = targetModel.CategoryID ?? "";
                orderId = 1;
            }
            else if (point == "top")
            {
                parentId = targetModel.C_ParentID ?? "";
                orderId = DataConverter.ToInt(targetModel.OrderNum) - 1;
            }
            else if (point == "bottom")
            {
                parentId = targetModel.C_ParentID ?? "";
                orderId = DataConverter.ToInt(targetModel.OrderNum) + 1;
            }
            Category model=new Category();
            model.CategoryID = id;
            model.OrderNum = orderId;
            model.C_ParentID = parentId;
            return UpdateByModel(model);
        }    }
}
