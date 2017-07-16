using shtuki_tuki.domain.Repository;
using shtuki_tuki.web.Infrastructure;
using shtuki_tuki.web.ViewModels;
using System.Linq;
using System.Web.Http;

namespace shtuki_tuki.web.Controllers
{
    [CustomAuthorize(Roles = "Administrators")]
    public class WebSocialNetworksController : ApiController
    {
        private readonly SocialNetworksRepository _repositorySocial = SocialNetworksRepository.Current;
        private readonly ContactsRepository _repositoryContacts = ContactsRepository.Current;

        [AllowAnonymous]
        public IHttpActionResult Get()
        {
            var viewModel = new ViewModelContacts
            {
                SocialNetworks = _repositorySocial.GetSocialNetworkCollection(),
                Contacts = _repositoryContacts.GetContactCollection().First()
            };

            return Ok(viewModel);
        }
    }
}
