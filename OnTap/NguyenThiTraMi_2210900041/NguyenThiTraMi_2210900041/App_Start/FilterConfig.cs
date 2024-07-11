using System.Web;
using System.Web.Mvc;

namespace NguyenThiTraMi_2210900041
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
