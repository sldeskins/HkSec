using System.Web;
using System.Web.Mvc;

namespace TR5_WebApplication5
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters ( GlobalFilterCollection filters )
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
