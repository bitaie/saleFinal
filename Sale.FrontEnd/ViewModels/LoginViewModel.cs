using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sale.FrontEnd.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "وارد کردن ایمیل ضروری است.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "وارد کردن رمز عبور ضروری است.")]

        public string Password { get; set; }
        
        public bool RememberMe { get; set; }
    }
}
