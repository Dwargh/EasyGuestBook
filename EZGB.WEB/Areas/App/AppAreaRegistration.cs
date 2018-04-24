using System.Web.Mvc;

namespace EZGB.Web.Areas.App
{
    public class AppAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "App";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "App_default",
                "GuestBook/{controller}/{action}/{id}",
                new { controller = "Post" , action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}