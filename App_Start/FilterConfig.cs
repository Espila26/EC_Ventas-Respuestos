using System.Web;
using System.Web.Mvc;

namespace EC_Ventas_Respuestos
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
