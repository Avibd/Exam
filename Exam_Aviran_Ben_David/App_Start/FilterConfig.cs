using System.Web;
using System.Web.Mvc;

namespace Exam_Aviran_Ben_David
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
