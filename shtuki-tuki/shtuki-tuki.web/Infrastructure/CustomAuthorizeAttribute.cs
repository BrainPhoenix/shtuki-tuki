using shtuki_tuki.domain.Entities;
using System.Web.Mvc;
using System.Web.Routing;

namespace shtuki_tuki.web.Infrastructure
{
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (string.IsNullOrEmpty(SessionPersister.Username))
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new
                {
                    controller = "Account",
                    action = "Index"
                }));
            else
            {
                AccountRepository accountRepository = new AccountRepository();
                CustomPrincipal customPrincipal = new CustomPrincipal(accountRepository.FindAccount(SessionPersister.Username));

                if (!customPrincipal.IsInRole(Roles))
                    filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new
                    {
                        controller = "Home",
                        action = "Index"
                    }));
            }
        }
    }
}