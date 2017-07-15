using shtuki_tuki.domain.Entities;
using shtuki_tuki.web.Infrastructure;
using shtuki_tuki.web.ViewModels;
using System.Web.Mvc;

namespace shtuki_tuki.web.Controllers
{
    public class AccountController : Controller
    {
        [AllowAnonymous]
        // GET: Account
        public ActionResult Login()
        {
            if (!string.IsNullOrEmpty(SessionPersister.Username))
            {
                return RedirectToAction("Index", "Admin");
            }

            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(ViewModelLogin model)
        {
            AccountRepository accountRepository = new AccountRepository();

            if(!string.IsNullOrEmpty(model.Username) && !string.IsNullOrEmpty(model.Password))
            {
                if (accountRepository.Login(model.Username, model.Password) != null)
                {
                    SessionPersister.Username = model.Username;
                    return RedirectToAction("Index", "Admin");
                }

                ViewBag.LoginMessage = "Пользователь с таким логином и паролем не найден";
                return View();
            }

            ViewBag.LoginMessage = "Метод не получил данные! Повторите попытку.";
            return View();
        }

        [CustomAuthorize(Roles = "Administrators")]
        public ActionResult Logout()
        {
            SessionPersister.Username = string.Empty;
            return RedirectToAction("Index", "Home");
        }
    }
}