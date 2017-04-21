using System.Web;
using System.Web.Mvc;
using Yamon.Framework.MVC;

namespace Yamon.EnDian365.WebSite
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //filters.Add(new MyExceptionFilterAttribute());
            filters.Add(new CheckLoginFilterAttribute(),1);
            filters.Add(new CheckPurviewFilterAttribute(), 2);
        }
    }
}