using System.Web;
using System.Web.Mvc;

namespace SpaceX_API_Listing
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
