using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SmartERP.UserDB.Pages
{

    [PageAuthorize(typeof(UserRow))]
    public class UserController : Controller
    {
        [Route("UserDB/User")]
        public ActionResult Index()
        {
            return View("~/Modules/UserDB/User/UserIndex.cshtml");
        }
    }
}