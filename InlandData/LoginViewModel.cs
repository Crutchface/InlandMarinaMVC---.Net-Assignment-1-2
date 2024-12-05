using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlandData
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Username is reqiuired")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Password is reqiuired")]
        public string? Password { get; set; }

        [Display(Name ="Remember Me")]
        public  bool  RememberMe { get; set; }
    }
}
