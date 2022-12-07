using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SmartERP.SalesPersonDB.Pages
{

    [PageAuthorize(typeof(SalesPersonRow))]
    public class SalesPersonController : Controller
    {
        [Route("SalesPersonDB/SalesPerson")]
        public ActionResult Index()
        {
            return View("~/Modules/SalesPersonDB/SalesPerson/SalesPersonIndex.cshtml");
        }
    }
}