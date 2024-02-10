using ClinicAutomationProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace ClinicAutomationProject.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        // GET: Admin
        Models.ClinicDatabaseEntities3 _db = new Models.ClinicDatabaseEntities3();
       
        public ActionResult Index()                
        {
            return View();
        }

        public ActionResult AddNewPhysician()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNewPhysician(Models.Physician physician)
        {
            if (ModelState.IsValid)
            {
                _db.Physicians.Add(physician);
                _db.SaveChanges();

                User usr = new User();
                usr.ReferenceToId = physician.PhysicianId;
                usr.UserName = physician.FirstName + DateTime.Now.ToString("ddMMyyhhmmss");
                usr.Password = physician.LastName;
                usr.Role = "PHYSICIAN";

                
                _db.Users.Add(usr);
                _db.SaveChanges();
                return RedirectToAction("Index");

            }

            return View();
        }

    }
}