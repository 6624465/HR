using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR.Areas.Payroll.Controllers
{
    public class PublishedInfoController : Controller
    {
        public ActionResult Payslip()
        {
            return View("Payslip");
        }
        public ActionResult ReimbursementPayslip()
        {
            return View("ReimbursementPayslip");
        }
        public ActionResult YTDSummary()
        {
            return View("YTDSummary");
        }
        public ActionResult PFYTDStatement()
        {
            return View("PFYTDStatement");
        }
        public ActionResult ReimbursementStatement()
        {
            return View("ReimbursementStatement");
        }
        public ActionResult LoanStatement()
        {
            return View("LoanStatement");
        }
        public ActionResult ITStatement()
        {
            return View("ITStatement");
        }
        public ActionResult PayslITDeclarationip()
        {
            return View("PayslITDeclarationip");
        }
        public ActionResult FBPDeclaration()
        {
            return View("FBPDeclaration");
        }
    }
}