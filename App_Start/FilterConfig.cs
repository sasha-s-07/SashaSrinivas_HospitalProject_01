using System.Web;
using System.Web.Mvc;

namespace SashaSrinivas_HospitalProject_01
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
