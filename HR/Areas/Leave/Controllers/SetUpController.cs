using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR.Areas.Leave.Controllers
{
    public class SetUpController : Controller
    {
        public ActionResult HolidayList()
        {
            return View("HolidayList");
        }
        public ActionResult ShiftRotationCalender()
        {
            return View("ShiftRotationCalender");
        }
    }
}