using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SmartERP.CustomerStatusDB.Pages
{

    [PageAuthorize(typeof(CustomerStatusRow))]
    public class CustomerStatusController : Controller
    {
        [Route("CustomerStatusDB/CustomerStatus")]
        public ActionResult Index()
        {
            return View("~/Modules/CustomerStatusDB/CustomerStatus/CustomerStatusIndex.cshtml");
        }
    }
}