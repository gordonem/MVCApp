using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCApp.Models;

namespace MVCApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            string timeOfDay;
            if (hour < 12)
                timeOfDay = "Good Morning";
            else if (hour < 18)
                timeOfDay = "Good Afternoon";
            else
                timeOfDay = "Good Evening";
            ViewBag.Greeting = timeOfDay;
            return View();
        }

        [HttpGet]
        public ViewResult InfoForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult InfoForm(Response response)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", Response);
            }
            else
            {
                {
                    return View();
                }
            }
        }
    }
}