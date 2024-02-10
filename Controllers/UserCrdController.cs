using ClinicAutomationProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ClinicAutomationProject.Controllers
{
    public class UserCrdController : Controller
    {
        // GET: UserCrd
        public class UserController : Controller
        {
            // GET: UserCrd
            public ActionResult Login()
            {
                return View();
            }
            [HttpPost]

            public ActionResult Login(UserModel user)
            {
                if (ModelState.IsValid)
                {

                    Models.ClinicDatabaseEntities3 _db = new ClinicDatabaseEntities3();

                    User usr = _db.Users.SingleOrDefault(dbusr => dbusr.UserName.ToLower() == user
                   .UserName.ToLower() && dbusr.Password == user.Password);

                    if (usr != null)
                    {
                        FormsAuthentication.SetAuthCookie(usr.UserName, false);
                        CurrentUserModel cusr = new CurrentUserModel();
                        cusr.UserName = usr.UserName;
                        cusr.RefrenceToId = usr.ReferenceToId;
                        cusr.UserId = usr.UserId;
                        cusr.Role = usr.Role;

                        if (usr.Role == "PHYSICIAN")
                        {

                            cusr.FirstName = _db.Physicians.Find(usr.ReferenceToId).FirstName;
                            cusr.LastName = _db.Physicians.Find(usr.ReferenceToId).LastName;
                        }



                        Session["CurrentUser"] = cusr;
                        return RedirectToAction("Index", usr.Role);
                    }
                }
                ModelState.AddModelError("", "invalid Username or Password");
                return View();
            }





            public ActionResult Logout()
            {
                FormsAuthentication.SignOut();
                return RedirectToAction("Login");
            }

        }
    }
}