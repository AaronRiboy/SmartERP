using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SmartERP.CompanyGroupDB.Pages
{

    [PageAuthorize(typeof(CompanyGroupRow))]
    public class CompanyGroupController : Controller
    {
        [Route("CompanyGroupDB/CompanyGroup")]
        public ActionResult Index()
        {
            return View("~/Modules/CompanyGroupDB/CompanyGroup/CompanyGroupIndex.cshtml");
        }
    }
}