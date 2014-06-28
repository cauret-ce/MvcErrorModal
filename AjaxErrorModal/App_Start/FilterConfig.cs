using System.Web;
using System.Web.Mvc;

namespace MvcAjaxErrorModal
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
