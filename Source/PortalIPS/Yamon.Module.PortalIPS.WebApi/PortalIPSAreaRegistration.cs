using System.Web.Mvc;
using Yamon.Module.SiteManage.DAL;

namespace Yamon.Module.PortalIPS.WebApi
{
    public class PortalIPSAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "PortalIPS_WebApi";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "PortalIPS_WebApi_default",
                "api/PortalIPS/{controller}/{action}/{id}",
                new { action = "Index", Controller = "Advertisement", id = UrlParameter.Optional },
                new string[] { "Yamon.Module.PortalIPS.WebApi" }
            );

            SiteCommon.AddNoCheckPurview("PortalIPS_Category_EditTree");
        }
    }
}