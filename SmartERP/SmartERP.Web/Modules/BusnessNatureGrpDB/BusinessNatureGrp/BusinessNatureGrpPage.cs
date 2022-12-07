using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SmartERP.BusnessNatureGrpDB.Pages
{

    [PageAuthorize(typeof(BusinessNatureGrpRow))]
    public class BusinessNatureGrpController : Controller
    {
        [Route("BusnessNatureGrpDB/BusinessNatureGrp")]
        public ActionResult Index()
        {
            return View("~/Modules/BusnessNatureGrpDB/BusinessNatureGrp/BusinessNatureGrpIndex.cshtml");
        }
    }
}