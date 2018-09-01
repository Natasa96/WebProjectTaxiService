using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaxiService.Models.Security;

namespace TaxiService.Controllers
{
    public class HomeController : Controller
    {
        public CustomPrincipal AuthorizeUser
        {
            get
            {
                if (System.Web.HttpContext.Current.User != null)
                    return System.Web.HttpContext.Current.User as CustomPrincipal;
                else
                    return null;
            }
        }

        [AllowAnonymous]
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        [AllowAnonymous]
        public ActionResult LogIn()
        {
            return View(); 
        }

        [AllowAnonymous]
        public ActionResult Registration()
        {
            return View();
        }
    }
}
