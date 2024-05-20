using System.Web;
using System.Web.Mvc;

namespace _02_WebApplicationMVC
{
  public class FilterConfig
  {
    public static void RegisterGlobalFilters(GlobalFilterCollection filters)
    {
      filters.Add(new HandleErrorAttribute());
    }
  }
}
