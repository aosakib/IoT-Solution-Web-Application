using System.Web;
using System.Web.Mvc;

namespace IoT_Solution_Web_Application
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
