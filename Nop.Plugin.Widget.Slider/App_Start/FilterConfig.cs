using System.Web;
using System.Web.Mvc;

namespace Nop.Plugin.Widget.Slider
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
