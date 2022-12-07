using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SmartERP.LeadStatusDB.Pages
{

    [PageAuthorize(typeof(LeadStatusRow))]
    public class LeadStatusController : Controller
    {
        [Route("LeadStatusDB/LeadStatus")]
        public ActionResult Index()
        {
            return View("~/Modules/LeadStatusDB/LeadStatus/LeadStatusIndex.cshtml");
        }
    }
}