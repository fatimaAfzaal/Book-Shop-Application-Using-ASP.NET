using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookShopApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "These are the details about us You can know more about us by clicking on links below";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "This is where you can contact us and discuss whatever you want";

            return View();
        }
    }
}