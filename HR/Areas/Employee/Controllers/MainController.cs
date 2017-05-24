using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR.Areas.Employee.Controllers
{
    public class MainController : Controller
    {
        public ActionResult Overview()
        {
            return View("Overview");
        }

        public ActionResult EmployeeDirectory()
        {
            return View("EmployeeDirectory");
        }
        public ActionResult ReportingStructure()
        {
            return View("ReportingStructure");
        }
        public ActionResult AddEmployee()
        {
            return View("AddEmployee");
        }
    }
}