using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sale.FrontEnd.Home
{
    public class MainController : Controller
    {
        [Route("Identity/Account/Login")]
        public IActionResult LoginRedirect(string ReturnUrl)
        {
            return Redirect("/Account/Login?ReturnUrl=" + ReturnUrl);
        }
        [Route("Identity/Account/AccessDenied")]
        public IActionResult AccessDeniedRedirect(string ReturnUrl)
        {
            return Redirect("/Account/AccessDenied?ReturnUrl=" + ReturnUrl);
        }
    }
}