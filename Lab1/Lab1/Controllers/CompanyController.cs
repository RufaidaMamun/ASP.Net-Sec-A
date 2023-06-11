using Lab1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using System.Web.UI.WebControls.Expressions;

namespace Lab1.Controllers
{
    public class CompanyController : Controller
    {
        // GET: Company
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Services()
        {
            var e1 = new Services()
            {
                Title = "C++",
                Duration = "3",
                fees = "10k"

            };
            var e2 = new Services()
            {
                Title = "Java",
                Duration = "3",
                fees= "15k"
            };
            var e3 = new Services()
            {
                Title = "C#",
                Duration = "2",
                fees = "DHAKA"
            };
            Services[] eds = new Services[] { e1, e2, e3 };

            return View(eds);
            
        }

        public ActionResult Team()
        {

            var e1 = new Team()
            {
                Name = "Rufaida Mamun",
                Age = "22",
                Role = "Teacher"

            };
            var e2 = new Team()
            {
                Name = "Abeer ahmed",
                Age = "24",
                Role = "Researcher"
            };
            var e3 = new Team()
            {
                Name = "Ahad Hussain",
                Age = "20",
                Role = "Developer"
            };
            Team[] eds = new Team[] { e1, e2, e3 };

            return View(eds);
            
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}