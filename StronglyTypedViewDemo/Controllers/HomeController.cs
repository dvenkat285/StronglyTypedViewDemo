using StronglyTypedViewDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StronglyTypedViewDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Employee emp1 = new Employee();
            emp1.Id = 11;
            emp1.Name = "Ali Khan";
            emp1.Age = 25;

            ViewData["Var1"] = emp1;
            ViewBag.Var2 = emp1;

            return View();
        }
    }
}