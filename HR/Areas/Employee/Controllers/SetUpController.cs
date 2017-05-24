using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR.Areas.Employee.Controllers
{
    public class SetUpController : Controller
    {

        public ActionResult LetterTemplate()
        {
            return View("LetterTemplate");
        }
        public ActionResult HRForms()
        {
            return View("HRForms");
        }
        public ActionResult EmployeeFilter()
        {
            return View("EmployeeFilter");
        }
    }
}