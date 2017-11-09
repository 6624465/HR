using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR.Areas.Payroll.Controllers
{
    public class SetUpController : Controller
    {
        // GET: Payroll/SetUp
        public ActionResult PayItemGroup()
        {
            return View("PayItemGroup");
        }
        public ActionResult PayrollRepository()
        {
            return View("PayrollRepository");
        }
        public ActionResult SalarySetup()
        {
            return View("SalarySetup");
        }
        public ActionResult PayslipSetup()
        {
            return View("PayslipSetup");
        }
        public ActionResult PayslipGallery()
        {
            return View("PayslipGallery");
        }
    }
}