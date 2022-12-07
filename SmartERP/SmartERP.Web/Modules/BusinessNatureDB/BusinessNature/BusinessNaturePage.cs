using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SmartERP.BusinessNatureDB.Pages
{

    [PageAuthorize(typeof(BusinessNatureRow))]
    public class BusinessNatureController : Controller
    {
        [Route("BusinessNatureDB/BusinessNature")]
        public ActionResult Index()
        {
            return View("~/Modules/BusinessNatureDB/BusinessNature/BusinessNatureIndex.cshtml");
        }
    }
}