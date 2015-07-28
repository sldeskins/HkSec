using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TR3_WebApplication3.Models;

namespace TR3_WebApplication3.Controllers
{
    //[Authorize]
    //[Authorize(Roles="Admin")]
    public class HomeController : Controller
    {
        public ActionResult Index ()
        {
            return View(new MyModel());
        }
        [HttpPost]
        public ActionResult Index ( MyModel model )
        {
            return View(model);
        }
        public ActionResult About ()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [AllowAnonymous]
        //[RequireHttps]
        public ActionResult Contact ()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}