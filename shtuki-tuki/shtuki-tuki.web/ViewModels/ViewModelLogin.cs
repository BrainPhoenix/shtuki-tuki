using System.ComponentModel.DataAnnotations;

namespace shtuki_tuki.web.ViewModels
{
    public class ViewModelLogin
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}