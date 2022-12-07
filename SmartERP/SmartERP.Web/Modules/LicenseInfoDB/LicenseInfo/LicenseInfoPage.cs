using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SmartERP.LicenseInfoDB.Pages
{

    [PageAuthorize(typeof(LicenseInfoRow))]
    public class LicenseInfoController : Controller
    {
        [Route("LicenseInfoDB/LicenseInfo")]
        public ActionResult Index()
        {
            return View("~/Modules/LicenseInfoDB/LicenseInfo/LicenseInfoIndex.cshtml");
        }
    }
}