using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SmartERP.LeadSourceDB.Pages
{

    [PageAuthorize(typeof(LeadSourceRow))]
    public class LeadSourceController : Controller
    {
        [Route("LeadSourceDB/LeadSource")]
        public ActionResult Index()
        {
            return View("~/Modules/LeadSourceDB/LeadSource/LeadSourceIndex.cshtml");
        }
    }
}