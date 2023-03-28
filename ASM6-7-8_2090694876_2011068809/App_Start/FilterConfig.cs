using System.Web;
using System.Web.Mvc;

namespace ASM6_7_8_2090694876_2011068809
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
