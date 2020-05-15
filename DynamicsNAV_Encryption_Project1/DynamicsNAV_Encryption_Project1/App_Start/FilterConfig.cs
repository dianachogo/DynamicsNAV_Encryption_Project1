using System.Web;
using System.Web.Mvc;

namespace DynamicsNAV_Encryption_Project1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
