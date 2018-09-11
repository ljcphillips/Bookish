using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bookish.ConsoleApp;

namespace Bookish.Web3.Controllers
{
    public class HomeController : Controller
    {
        public String Index()
        {
            Bookish.ConsoleApp.Program.ItemReturn();
            return "Test";
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