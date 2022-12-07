using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SmartERP.DealerDB.Pages
{

    [PageAuthorize(typeof(DealerRow))]
    public class DealerController : Controller
    {
        [Route("DealerDB/Dealer")]
        public ActionResult Index()
        {
            return View("~/Modules/DealerDB/Dealer/DealerIndex.cshtml");
        }
    }
}