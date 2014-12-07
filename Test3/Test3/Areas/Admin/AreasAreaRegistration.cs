using System.Web.Mvc;

namespace Test3.Areas.Areas
{
    public class AreasAreaRegistration : AreaRegistration
    {
        private static readonly string[] Namespaces = new[] { "Test3.Areas.Admin.Controllers" };
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
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                , Namespaces
            );
        }
    }
}
