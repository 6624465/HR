using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR.Areas.Payroll.Controllers
{
    public class InformationController : Controller
    {
        public ActionResult SalaryRevisonHistory()
        {
            return View("SalaryRevisonHistory");
        }
        public ActionResult SalaryRevisionAnalytics()
        {
            return View("SalaryRevisionAnalytics");
        }
    }
}