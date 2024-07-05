using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnepProject.Models;
using UnpeTest.Models;

namespace UnpeTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DataContext dbcontext = new DataContext("Server=tcp:unep.database.windows.net,1433;Initial Catalog=unep_test;Persist Security Info=False;User ID=smuwanguzi;Password=Password.01;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            List<StaffPersonalInformation> slist = new List<StaffPersonalInformation>();
            ViewBag.staff_list = dbcontext.StaffPersonalInformation.ToArray();
            return View();
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