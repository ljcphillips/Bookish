using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bookish.ConsoleApp;

namespace Bookish.Web3.Controllers
{
    public class Book
    {
        public string Title;
    }
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var books = new List<Book> { new Book { Title = "foo" }, new Book { Title = "bar" } }; //bookRepo.GetBooks();
            ViewBag.Books = books;

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