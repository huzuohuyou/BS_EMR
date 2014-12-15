using System.Web;
using System.Web.Mvc;

namespace MvcApplication2014_12_08
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}