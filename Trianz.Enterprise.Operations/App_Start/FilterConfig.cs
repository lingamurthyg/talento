using System.Web;
using System.Web.Mvc;
using Trianz.Enterprise.Operations.Filters;

namespace Trianz.Enterprise.Operations
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new AuthorizeActionFilterAttribute());
        }
    }
}
