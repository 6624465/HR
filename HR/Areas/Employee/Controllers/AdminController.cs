using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR.Areas.Employee.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult GenerateLetter()
        {
            return View("GenerateLetter");
        }
        public ActionResult ExcelImport()
        {
            return View("ExcelImport");
        }
        public ActionResult BulletinBoard()
        {
            return View("BulletinBoard");
        }
        public ActionResult MassCommunication()
        {
            return View("MassCommunication");
        }
        public ActionResult IdentityVerification()
        {
            return View("IdentityVerification");
        }
        public ActionResult DataDrive()
        {
            return View("DataDrive");
        }
        public ActionResult ContractDetails()
        {
            return View("ContractDetails");
        }
    }
}