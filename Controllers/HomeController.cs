
using MVC5RealWorld.Models;
using MVC5RealWorld.Helpers1;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace MVC5RealWorld.Controllers
{
    public class HomeController : Controller
    {
        CalendarContext db = new CalendarContext();
        //private string visitorIPAddress;
        bool disableOAuth = false;

        public ActionResult Index(string licenseId)
        {
            //if (!User.Identity.IsAuthenticated && !disableOAuth)
            //{
            //   // return new KalendarNet.Controllers.AccountController.ChallengeResult("OpenIdConnect", Url.Action("Index", "Home", new { licenseId = licenseId }));
            //    // return RedirectToAction("Login", "Account", new { returnUrl = Url.Action("Index","Home",new {calendarId=calendarId})});
            //}

           // bool accessToCalendar = Util.FindClaim(licenseId, User);

          //  if (accessToCalendar || disableOAuth)
           // {
                //var userInfo = db.calendar_Users.Where(p => p.email.ToLower() == User.Identity.Name.ToLower()).FirstOrDefault();
                //if (disableOAuth)
                //{
                //    userInfo = db.calendar_Users.Where(p => p.email.ToLower() == "testuser@example.com").FirstOrDefault();
                //}
                //if (userInfo == null)
                //{
                //    userInfo = db.calendar_Users.Add(new Calendar_Users() { email = User.Identity.Name, name = User.Identity.Name, password = "P@ssw0rd" });
                //    db.SaveChanges();
                //////}
                ////ViewBag.licenseId = licenseId;
                ////ViewBag.UserId = userInfo.id;
                ////ViewBag.UserName = userInfo.name;
                ////ViewBag.Email = userInfo.email;
                ViewBag.Message = "Welcome!";
               // ViewBag.Version = Util.appVersion;
               
          //  }
           // else
           // {
                //ViewBag.Message = new Message() { Category = "danger", MessageText = "You don’t have license for the calendar with License Id " + licenseId + ", try other calendar" };
               // ViewBag.Message = new Message() { Category = "danger", MessageText = "Någonting har gått fel vid inloggningen till Klassrumskalendern. Om problemet kvarstår, pröva att logga in med ditt konto igen och öppna Klassrumskalendern på nytt. Om problemet ändå kvarstår, kontakta vår support. Du har försökt att använda Licens: " + licenseId + "." };
               // return View("Error");
            //}
            return View();
        }
        ////[Authorize]
        ////public ActionResult Welcome() {
        ////    return View();
        ////}


        ////public ActionResult UnAuthorized() {
        ////    return View();
        ////}

        //[AuthorizeRoles("Admin")]
        //[Authorize(Roles ="Member")]
        //public ActionResult AdminOnly() {
        //    return View();
        //}
       

    }
}