using shtuki_tuki.domain.Entities;
using System.Linq;
using System.Security.Principal;

namespace shtuki_tuki.web.Infrastructure
{
    public class CustomPrincipal : IPrincipal
    {
        private readonly Account _account;

        public CustomPrincipal(Account account)
        {
            _account = account;
            Identity = new GenericIdentity(account.Username);
        }

        public IIdentity Identity { get; set; }

        public bool IsInRole(string role)
        {
            var roles = role.Split(',');
            return roles.Any(r => _account.Roles.Contains(r));
        }
    }
}