using System.Web.Mvc;

namespace ASM6_7_8_2090694876_2011068809.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { controller = "Book", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}