using System.Collections.Generic;
using System.Linq;

namespace shtuki_tuki.domain.Entities
{
    public class Account
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string[] Roles { get; set; }
    }

    public class AccountRepository
    {
        private readonly List<Account> _listAccaunts = new List<Account>();

        public AccountRepository()
        {
            _listAccaunts.Add(new Account
            {
                Username = "Shtuki-tuki",
                Password = "Shtuki-tuki",
                Roles = new[] { "Administrators" }
            });

            _listAccaunts.Add(new Account
            {
                Username = "BrainPhoenix",
                Password = "Helgard240490",
                Roles = new[] { "Administrators" }
            });

            _listAccaunts.Add(new Account
            {
                Username = "Brainbox_ani",
                Password = "meteora281745",
                Roles = new[] { "Administrators" }
            });
        }

        public Account FindAccount(string username)
        {
            return _listAccaunts.Single(
                model => model.Username.Equals(username));
        }

        public Account Login(string username, string password)
        {
            return _listAccaunts.FirstOrDefault(
                model => model.Username.Equals(username) && model.Password.Equals(password));
        }
    }
}