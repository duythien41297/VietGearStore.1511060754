using System.Web;
using System.Web.Mvc;

namespace VietGearStore._1511060754
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
