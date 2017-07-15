using shtuki_tuki.web.Infrastructure;
using System.Web.Mvc;

namespace shtuki_tuki.web.Controllers
{
    [CustomAuthorize(Roles = "Administrators")]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
    }
}