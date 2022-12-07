using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SmartERP.CountryDB.Pages
{

    [PageAuthorize(typeof(CountryRow))]
    public class CountryController : Controller
    {
        [Route("CountryDB/Country")]
        public ActionResult Index()
        {
            return View("~/Modules/CountryDB/Country/CountryIndex.cshtml");
        }
    }
}