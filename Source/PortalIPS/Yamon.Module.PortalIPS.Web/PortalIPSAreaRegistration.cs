using System.Web.Mvc;

namespace Yamon.Module.PortalIPS.Web.Controllers
{
    public class PortalIPSAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "PortalIPS";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "PortalIPS_default",
                "PortalIPS/{controller}/{action}/{id}",
                new { action = "Index", Controller = "Advertisement", id = UrlParameter.Optional },
                new string[] { "Yamon.Module.PortalIPS.Web.Controllers" }
            );
        }
    }
}