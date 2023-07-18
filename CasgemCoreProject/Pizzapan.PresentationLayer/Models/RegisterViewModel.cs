using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzapan.PresentationLayer.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Lütfen adınızı giriniz")]
        public string Name { get; set; }
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen adınızı giriniz")]
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor")]
        public string ConfirmPassword { get; set; }
    }
}
