using System.Web;
using System.Web.Mvc;

namespace IMDB_MVC_Sudarshan
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
