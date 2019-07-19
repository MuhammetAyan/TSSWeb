using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TSSWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Kullanıcı giriş yapmışsa
            if (Request.IsAuthenticated)
                return View();
            else //Giriş Yapmamışsa
                return RedirectToAction("Login", "Account");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}