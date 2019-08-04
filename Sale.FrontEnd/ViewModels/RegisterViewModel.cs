using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sale.FrontEnd.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "وارد کردن ایمیل ضروری است.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "وارد کردن رمز عبور ضروری است.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "وارد کردن تکرار رمز عبور ضروری است.")]
        [Compare("Password", ErrorMessage = "رمز عبور و تکرار آن با هم متفاوت هستند.")]
        public string ConfirmPassword { get; set; }
    }
}
