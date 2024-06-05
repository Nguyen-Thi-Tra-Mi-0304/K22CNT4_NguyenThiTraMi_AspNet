using System.Web;
using System.Web.Mvc;

namespace NttmLesson06CFK22CNT4
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
