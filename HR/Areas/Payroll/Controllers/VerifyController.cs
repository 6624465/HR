using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR.Areas.Payroll.Controllers
{
    public class VerifyController : Controller
    {
        public ActionResult QuikeSalaryStatement()
        {
            return View("QuikeSalaryStatement");
        }
        public ActionResult PayrollStatement()
        {
            return View("PayrollStatement");
        }
        public ActionResult PayrollDifferences()
        {
            return View("PayrollDifferences");
        }
    }
}