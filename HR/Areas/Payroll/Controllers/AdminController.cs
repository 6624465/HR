using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR.Areas.Payroll.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Form16()
        {
            return View("Form16");
        }
        public ActionResult Form24Q()
        {
            return View("Form24Q");
        }
        public ActionResult EmployeeITDeclaration()
        {
            return View("EmployeeITDeclaration");
        }
        public ActionResult PANStatus()
        {
            return View("PANStatus");
        }
        public ActionResult Remittances()
        {
            return View("Remittances");
        }
        public ActionResult PayrollRelease()
        {
            return View("PayrollRelease");
        }
        public ActionResult POITrack()
        {
            return View("POITrack");
        }
        public ActionResult PFKYCMapping()
        {
            return View("PFKYCMapping");
        }
        public ActionResult FBPPlanner()
        {
            return View("FBPPlanner");
        }
        public ActionResult PartAUpload()
        {
            return View("PartAUpload");
        }
        public ActionResult PartADetails()
        {
            return View("PartADetails");
        }
        public ActionResult PartBGenerate()
        {
            return View("PartBGenerate");
        }
        public ActionResult PartBDetails()
        {
            return View("PartBDetails");
        }
        public ActionResult PublishDetails()
        {
            return View("PublishDetails");
        }
        public ActionResult EmailfDetails()
        {
            return View("EmailfDetails");
        }
    }
}