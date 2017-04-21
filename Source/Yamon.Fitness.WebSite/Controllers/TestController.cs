using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Yamon.Framework.Common;
using Yamon.Framework.Common.Encrypt;
using Yamon.Framework.MVC;

namespace Yamon.EnDian365.WebSite.Controllers
{
    [NoCheckLogin]
    public class TestController : BaseController
    {

        
        /// <summary>
        /// Index功能测试
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(int id)
        {
            ParamOptions param = new ParamOptions();
            //param.Method = "Index";
            param.Timestamp = SignHelper.GetUnixTime();
            param.Apikey = "1001";
            param.Properties.Add("User_ID", "1001");
            param.Properties.Add("Token", "41a95968f2bbb0e6fb8dabd80d163483");
            string url = "http://localhost:44569/SiteManage/District/AsyncEditTreeAction";
            string secretKey = "21232f297a57a5a743894a0e4a801fc3";
            param.Sign = SignHelper.CreateSign("GET", param, url, secretKey);
            HttpHelper httpHelper = new HttpHelper();
            var postStr = SignHelper.CreateParamString(param, "&");
            url += "?ID=9&sign=" + param.Sign + postStr;
            string content = httpHelper.Get(url);
            return Content(url + "\r\n" + content);
        }

        /// <summary>
        /// PushMessageBind功能测试
        /// </summary>
        /// <returns></returns>
        public ActionResult PushMessageBind()
        {
            ParamOptions param = new ParamOptions();
            param.Timestamp = SignHelper.GetUnixTime();
            param.Apikey = "1001";
            param.Properties.Add("userId", "123456");
            param.Properties.Add("baiduUserId", "883213573058228598");
            param.Properties.Add("baiduChannelId", "4500570850266122409");
            param.Properties.Add("baiduAppId", "7832029");
            param.Properties.Add("deviceType", "3");
            param.Properties.Add("version", "2");

            string url = "http://localhost:44589/API/PushMessageBind";
            string secretKey = "21232f297a57a5a743894a0e4a801fc3";
            param.Sign = SignHelper.CreateSign("POST", param, url, secretKey);
            HttpHelper httpHelper = new HttpHelper();
            var postStr = SignHelper.CreateParamString(param, "&");
            string content = httpHelper.Post(url, "sign=" + param.Sign + postStr);
            return Content(url + "\r\n" + content);
        }

        public ActionResult InsertDeviceLog()
        {
            ParamOptions param = new ParamOptions();
            param.Timestamp = SignHelper.GetUnixTime();
            param.Apikey = "1001";
            param.Properties.Add("UserID", "862663021980612");

            string url = "http://localhost:44589/API/InsertDeviceLog";
            string secretKey = "21232f297a57a5a743894a0e4a801fc3";
            param.Sign = SignHelper.CreateSign("POST", param, url, secretKey);
            HttpHelper httpHelper = new HttpHelper();
            param.Properties.Add("Version", "0.9");
            param.Properties.Add("DeviceName", "7832029");
            param.Properties.Add("DeviceModel", "MI 2SC");
            param.Properties.Add("DeviceType", "Android");
            param.Properties.Add("SystemVersion", "4.1.1");
            var postStr = SignHelper.CreateParamString(param, "&");
            string content = httpHelper.Post(url, "sign=" + param.Sign + postStr);
            return Content(url + postStr + "\r\n" + content);
        }
    }
}
