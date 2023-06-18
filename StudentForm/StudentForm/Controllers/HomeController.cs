using StudentForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentForm.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            //ViewBag.Name = Request["Username"];
            return View();
        }
        [HttpPost]
        public ActionResult Login(string Username, string Password)
        {
            //ViewBag.Name = form["Username"];
            ViewBag.Name = Username;
            return View();
        }
        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(Student u)
        {

            var test = u.Dob.Date.ToString("yyyy-MM-dd");
            if (ModelState.IsValid)
            {
                return RedirectToAction("Login");
            }
            return View(u);
        }
    }
}
