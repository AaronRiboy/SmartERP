using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SmartERP.UserGroupDB.Pages
{

    [PageAuthorize(typeof(UserGroupRow))]
    public class UserGroupController : Controller
    {
        [Route("UserGroupDB/UserGroup")]
        public ActionResult Index()
        {
            return View("~/Modules/UserGroupDB/UserGroup/UserGroupIndex.cshtml");
        }
    }
}