using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR.Areas.Employee.Controllers
{
    public class StatutoryController : Controller
    {
        public ActionResult FinesDamages()
        {
            return View("FinesDamages");
        }
    }
}