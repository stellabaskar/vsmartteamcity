using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using MVC5RealWorld.Models;

namespace MVC5RealWorld.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {


        //
        // GET: /Account/Login
      
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View("Login");
        }

        //
    }
}