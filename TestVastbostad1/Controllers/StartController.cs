using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestVastbostad1.Controllers
{
    public class StartController : Controller
    {
   
        public ActionResult Home()
        {
            return View();
        }
        
        public ActionResult Bostader()
        {
            return View();
        }
        public ActionResult Lokaler()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }


    }
}