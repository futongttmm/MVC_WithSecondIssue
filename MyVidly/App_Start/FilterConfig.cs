using System.Web;
using System.Web.Mvc;

namespace MyVidly
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());

            // add the authorization globally
            filters.Add(new AuthorizeAttribute());

            // my application endpoint will no longer be available on http channel
            filters.Add(new RequireHttpsAttribute());
        }
    }
}
