using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR.Areas.Employee.Controllers
{
    public class InformationController : Controller
    {
        // GET: Employee/Information
        public ActionResult EmployeeProfile()
        {
            return View("EmployeeProfile");
        }
        public ActionResult BankAccounts()
        {
            return View("BankAccounts");
        }
        public ActionResult FamilyDetails()
        {
            return View("FamilyDetails");
        }
        public ActionResult PassportVisa()
        {
            return View("PassportVisa");
        }
        public ActionResult Assets()
        {
            return View("Assets");
        }
        public ActionResult Assetss()
        {
            return View("Assetss");
        }
        public ActionResult PositionHistory()
        {
            return View("PositionHistory");
        }
        public ActionResult PreviousEmployment()
        {
            return View("PreviousEmployment");
        }
        public ActionResult Separation()
        {
            return View("Separation");
        }
        public ActionResult AccessCardDetails()
        {
            return View("AccessCardDetails");
        }
        public ActionResult NominationDetails()
        {
            return View("NominationDetails");
        }
        public ActionResult EmployeeDocuments()
        {
            return View("EmployeeDocuments");
        }
        public ActionResult EmployeeContracts()
        {
            return View("EmployeeContracts");
        }
    }
}