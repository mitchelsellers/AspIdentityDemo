using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConferenceDemo.Data;
using ConferenceDemo.Web.Models;
using Microsoft.AspNet.Identity.Owin;

namespace ConferenceDemo.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult CustomDataPage()
        {
            var context = HttpContext.GetOwinContext().Get<ConfenceDemoDbContext>();

            //TODO:Finish
            return View();
        }
    }
}