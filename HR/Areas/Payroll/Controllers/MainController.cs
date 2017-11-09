using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR.Areas.Payroll.Controllers
{
    public class MainController : Controller
    {
        public ActionResult Overview()
        {
            return View("Overview");
        }
    }
}