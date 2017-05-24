using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR.Areas.Leave.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult LeaveGranter()
        {
            return View("LeaveGranter");
        }
        public ActionResult yearEndProcess()
        {
            return View("yearEndProcess");
        }
        public ActionResult ProcessAttendance()
        {
            return View("ProcessAttendance");
        }
        public ActionResult AttesndancePeriodFinalistion()
        {
            return View("AttesndancePeriodFinalistion");
        }
        public ActionResult AttendanceException()
        {
            return View("AttendanceException");
        }
        public ActionResult AttendanceLockConfig()
        {
            return View("AttendanceLockConfig");
        }
        public ActionResult ManualOverride()
        {
            return View("ManualOverride");
        }
    }
}