using shtuki_tuki.web.Infrastructure;
using shtuki_tuki.web.ViewModels;
using System.Web.Mvc;

namespace shtuki_tuki.web.Controllers
{
    [CustomAuthorize(Roles = "Administrators")]
    public class AdminController : Controller
    {
        public PartialViewResult NavigationAdmin()
        {
            return PartialView();
        }

        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AdminGoods()
        {
            return View();
        }

        public JsonResult GoodAvatarUpload(int goodId)
        {
            if (Request.Files != null)
            {
                
            }

            return new JsonResult();
        }

        public ActionResult AdminVideo()
        {
            return View();
        }

        public ActionResult AdminReviews()
        {
            return View();
        }

        public ActionResult AdminOffers()
        {
            return View();
        }

        public ActionResult AdminCurrency()
        {
            return View();
        }

        public ActionResult AdminIndexPage()
        {
            return View();
        }        
    }
}