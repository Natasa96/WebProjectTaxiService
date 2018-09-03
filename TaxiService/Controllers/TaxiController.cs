using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaxiService.Models;
using TaxiService.Models.Enum;
using TaxiService.Models.Security;

namespace TaxiService.Controllers
{
    public class TaxiController : Controller
    {
        private static DBAccess db = DBAccess.CreateDB();

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

        [Authorize]
        public ActionResult Index()
        {
            if (AuthorizeUser.Role == Uloga.Dispecer)
                return View("DispecerView");

            else if (AuthorizeUser.Role == Uloga.Vozac)
                return View("VozacView");

            else if (AuthorizeUser.Role == Uloga.Musterija)
                return View("MusterijaView");

            else
                return View();
        }
    }
}