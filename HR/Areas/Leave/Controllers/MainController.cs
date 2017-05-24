    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR.Areas.Leave.Controllers
{
    public class MainController : Controller
    {
        public ActionResult Overview()
        {
            return View("Overview");
        }
        public ActionResult LeaveCalender()
        {
            return View("LeaveCalender");
        }
        public ActionResult WhoisIn()
        {
            return View("WhoisIn");
        }
    }
}