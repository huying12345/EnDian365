﻿
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由亚萌智能表单代码生成工具生成。
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。除非此项目不再使用代码生成器生成。
//     如果想修改此文件的方法，请在此文件的上级目录中的InfoTypeController重写(override)该方法。
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




namespace Yamon.Module.PortalIPS.WebApi
{
    /// <summary>
    /// 信息内容类型管理
    /// </summary>
    public partial class _InfoTypeController :BaseController
    {

        public InfoTypeDAL dal = new InfoTypeDAL();

        public virtual ActionResult Grid1()
        {
             return GridByFilterID("");
        } 
        


        [ValidateInput(false)]
        [LogFilter]
        public virtual ActionResult Create(InfoType model,bool returnData=false)
        {
            object newId = "";
            try
            {
                model = dal.GetInsertModelValue(model);
                dal.CreateFormValidator(model);
                int result = dal.InsertByModel(model);
                hash["success"] = result > 0;
                if (result > 0)
                {
                            newId = model.InfoTypeName;

                    hash["id"] = newId;
                    if(returnData){
                        InfoType newrow = dal.GetModelByID(newId);
                        hash["data"] = newrow;
                    }
                }
               
            }
            catch (Exception ex)
            {
                hash["message"] = ex.Message;
            }
            return Content(JsonConvert.SerializeObject(hash));
        }        [ValidateInput(false)]
        [LogFilter]
        public virtual ActionResult Edit(InfoType model,bool returnData=false)
        {
            try
            {
                model = dal.GetUpdateModelValue(model);
                dal.EditFormValidator(model);
                int result = dal.UpdateByModel(model);
                hash["success"] = result > 0 ;
               if (result > 0)
                {
                    hash["id"] = model.InfoTypeName;
                    if(returnData){
                        InfoType newrow = dal.GetModelByID(model.InfoTypeName);
                        hash["data"] = newrow;
                    }
                }
            }
            catch (Exception ex)
            {
                hash["message"] = ex.Message;
            }
            return Content(JsonConvert.SerializeObject(hash));
		}

        [NonAction]        
        public  virtual List<InfoType> GetGridList(string filterId, int showValue, out int totalRows)
        {
            totalRows = 0;
            string sort = RequestHelper.NameValue.GetString("sort").Replace("_ShowValue","");
            string order = RequestHelper.NameValue.GetString("order");
            int page = RequestHelper.NameValue.GetInt("page");
            int rows = RequestHelper.NameValue.GetInt("rows", 20);
            if (string.IsNullOrEmpty(sort))
            {
                sort = "InfoTypeOrderNum";
            }
            if (string.IsNullOrEmpty(order))
            {
                order = "asc";
            }
            string orderby = sort + " " + order;
            List<InfoType> modelList = new List<InfoType>();
            switch(filterId)
            {

                default:
                    {
                    modelList = dal.GetEntityListByPage(out totalRows,0,page,rows,orderby);
                    break;
                    }
            }
            if (showValue == 0)
            {
                return modelList;
            }
            return  modelList.Select(model => dal.GetModelGridShowValue(model)).ToList();
        }
        [NonAction]
        public  virtual ActionResult GridByFilterID(string filterId)
        {
            filterId = string.IsNullOrEmpty(filterId)?"":filterId;
            try
            {
                int totalRows = 0;
                filterId = string.IsNullOrEmpty(filterId) ? "" : filterId;
                hash["rows"] = GetGridList(filterId, 1, out totalRows);
                hash["total"] = totalRows;
                hash["success"] = true;
            }
            catch (Exception ex)
            {
                hash["success"] = false;
                hash["message"] = ex.Message;
                hash["rows"] = new List<InfoType>();
            }
            return Content(JsonConvert.SerializeObject(hash)); 
        }
   
    [LogFilter]
    public virtual ActionResult BatchDelete()
    {
        string ids = StringHelper.UrlDecode(RequestHelper.GetRequestString("ids"));
        int result = dal.BatchDeleteByID(ids);
        Hashtable hash = new Hashtable();
        hash["success"] = result > 0;
        hash["message"] = "";
        return Json(hash);
    }

    [LogFilter]
    public virtual ActionResult Delete(string id)
    {
        int result = dal.DeleteByID(id);
        hash["success"] = result > 0;
        hash["message"] = "";
        return Json(hash);
    }
        [CheckPurview(pageCode:"PortalIPS_InfoType_Show")]        
        public ActionResult GetEntityByID(string id)
        {
            InfoType model = dal.GetModelByID(id);
            if (model != null)
            {
                hash["data"] = model;
                hash["success"] = true;
            }
            return Content(JsonConvert.SerializeObject(hash));
        }

        [CheckPurview(pageCode:"PortalIPS_InfoType_Show")]
        public ActionResult GetInfoByID(string id)
        {
            InfoType model = dal.GetModelByID(id);
            if (model != null)
            {
                model = dal.GetModelShowValue(model);
                hash["success"] = true;
                hash["data"] = model;
            }
           return Content(JsonConvert.SerializeObject(hash));
        }

        [CheckPurview(pageCode:"PortalIPS_InfoType_Show")]
        public ActionResult GetModelByID(string id)
        {
            InfoType model = dal.GetModelByID(id);
            if (model != null)
            {
                model = dal.GetModelShowValue(model,true);
                hash["data"] = model;
                hash["success"] = true;
                string json = JsonConvert.SerializeObject(hash);
                json=json.Replace("_ShowValue\":","\":");
                return Content(json);
            }
            return Content(JsonConvert.SerializeObject(hash));
        }




    }
}