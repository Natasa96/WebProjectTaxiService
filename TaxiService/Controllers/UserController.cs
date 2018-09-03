using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using TaxiService.Models;
using TaxiService.Models.DB;
using TaxiService.Models.Enum;
using TaxiService.Models.Security;

namespace TaxiService.Controllers
{
    public class UserController : ApiController
    {
        private static DBAccess db = DBAccess.CreateDB();

        public CustomPrincipal AuthorizeUser
        {
            get
            {
                if (HttpContext.Current.User != null)
                    return HttpContext.Current.User as CustomPrincipal;
                else
                    return null;
            }
        }

        [HttpPost, Route("api/User/AddUser")]
        [AllowAnonymous]
        public IHttpActionResult AddUser(Musterija data)
        {
            lock (db)
            {
                if(!db.VozacDB.ToList().Exists(p => p.kIme == data.kIme)
                    && !db.MusterijaDB.ToList().Exists(p => p.kIme == data.kIme)
                    && !db.DispecerDB.ToList().Exists(p => p.kIme == data.kIme)
                    && !string.IsNullOrEmpty(data.kIme))
                {
                    data.Uloge = Uloga.Musterija;
                    db.UsersDB.Add(new LogIn()
                    {
                        Username = data.kIme,
                        Password = data.Lozinka,
                        Role = data.Uloge
                    });
                    db.MusterijaDB.Add(data);
                    db.SaveChanges();
                    return Ok(data);
                }
                else
                {
                    return BadRequest();
                }
            }
        }

        [HttpPost, Route("api/User/Update")]
        public IHttpActionResult Update(Musterija data)
        {
            lock (db)
            {
                int id = db.MusterijaDB.ToList().IndexOf(db.MusterijaDB.ToList().Find(p => p.kIme == data.kIme));
                db.MusterijaDB.ToList()[id].Lozinka = data.Lozinka;
                db.MusterijaDB.ToList()[id].Ime = data.Ime;
                db.MusterijaDB.ToList()[id].Prezime = data.Prezime;
                db.MusterijaDB.ToList()[id].Jmbg = data.Jmbg;
                db.MusterijaDB.ToList()[id].Email = data.Email;
                db.MusterijaDB.ToList()[id].Telefon = data.Telefon;
                db.MusterijaDB.ToList()[id].Pol = data.Pol;

                db.SaveChanges();
                return Ok();
            }
        }

        [HttpPost, Route("api/User/LogOff")]
        public IHttpActionResult LogOff(LogIn data)
        {
            lock (db)
            {
                System.Web.Security.FormsAuthentication.SignOut();
                return Ok();
            }
        }
    }
}
