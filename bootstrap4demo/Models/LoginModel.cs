using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bootstrap4demo.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Required")]
        [Display(Name = "Email Address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Required")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
