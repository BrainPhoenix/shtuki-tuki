using shtuki_tuki.domain.Entities;
using System.Collections.Generic;

namespace shtuki_tuki.web.ViewModels
{
    public class ViewModelContacts
    {
        public List<SocialNetwork> SocialNetworks { get; set; }

        public Contact Contacts { get; set; }
    }
}