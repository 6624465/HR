using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR.Areas.Payroll.Controllers
{
    public class ProcessController : Controller
    {
        public ActionResult PayrollProcess()
        {
            return View("PayrollProcess");
        }
    }
}