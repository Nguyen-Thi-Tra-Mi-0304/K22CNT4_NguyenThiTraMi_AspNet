using System.Web;
using System.Web.Mvc;

namespace Nttm_Lab04_BAITAPTULAM_1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
