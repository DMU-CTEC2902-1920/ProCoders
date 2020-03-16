using System.Web;
using System.Web.Mvc;

namespace Week24Lab_Views_Controller2View_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
