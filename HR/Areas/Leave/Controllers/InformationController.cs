using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR.Areas.Leave.Controllers
{
    public class InformationController : Controller
    {
        public ActionResult EmployeeLeave()
        {
            return View("EmployeeLeave");
        }
        public ActionResult ShiftRoster()
        {
            return View("ShiftRoster");
        }
        public ActionResult EmployeeSwipes()
        {
            return View("EmployeeSwipes");
        }
        public ActionResult AttendanceMuster()
        {
            return View("AttendanceMuster");
        }
        public ActionResult AttendanceInfo()
        {
            return View("AttendanceInfo");
        }
    }
}