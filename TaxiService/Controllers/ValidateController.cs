using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Script.Serialization;
using System.Web.Security;
using TaxiService.Models;
using TaxiService.Models.DB;
using TaxiService.Models.Security;

namespace TaxiService.Controllers
{
    public class ValidateController : ApiController
    {
        private static DBAccess db = DBAccess.CreateDB();

        [HttpPost, Route("api/Validate/ValidateLogin")]
        public IHttpActionResult ValidateLogin(LogIn data)
        {
            try
            {
                lock (db)
                {
                    var user = db.UsersDB.ToList().Find(p => p.Username == data.Username && p.Password == data.Password);

                    if (user != null)
                    {
                        CustomPrincipalSerializeModel serializeModel = new CustomPrincipalSerializeModel();
                        serializeModel.ID = user.ID;
                        serializeModel.Username = user.Username;
                        serializeModel.Password = user.Password;
                        serializeModel.Role = user.Role;
                        JavaScriptSerializer serializer = new JavaScriptSerializer();

                        string userData = serializer.Serialize(serializeModel);
                        FormsAuthenticationTicket aTicket = new FormsAuthenticationTicket(
                            1,
                            user.Username,
                            DateTime.Now,
                            DateTime.Now.AddMinutes(15),
                            false,
                            userData);
                        string encTicket = FormsAuthentication.Encrypt(aTicket);                                //wtf is this?
                        HttpCookie faCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encTicket);
                        HttpContext.Current.Response.Cookies.Add(faCookie);
                        return Ok();
                    }
                    else
                    {
                        return BadRequest("Invalid username or password.");
                    }
                }
            }
            catch
            {
                return NotFound();
            }
        }

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

        [HttpGet, Route("api/Validate/getUser")]
        public LogIn getUser()
        {
            lock (db)
                return db.UsersDB.ToList().Find(p => p.Username == AuthorizeUser.Username);
        }

        [HttpGet, Route("api/Validate/getCarTypes")]
        public List<string> getCarTypes()
        {
            List<string> item = new List<string>()
            {
                TipAutomobila.Kombi,
                TipAutomobila.Putnicki,
                TipAutomobila.Not
            };
            return item;
        }
    }
}
