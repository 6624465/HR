using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR.Areas.Payroll.Controllers
{
    public class PayrollInputsController : Controller
    {
        public ActionResult Salary()
        {
            return View("Salary");
        }
        public ActionResult Loan()
        {
            return View("Loan");
        }
        public ActionResult SalaryRevisions()
        {
            return View("SalaryRevisions");
        }
        public ActionResult Reimbursement()
        {
            return View("Reimbursement");
        }
        public ActionResult IncomeTax()
        {
            return View("IncomeTax");
        }
        public ActionResult EmployeeLOPDays()
        {
            return View("EmployeeLOPDays");
        }
        public ActionResult StopSalaryProcessing()
        {
            return View("StopSalaryProcessing");
        }
        public ActionResult Arrears()
        {
            return View("Arrears");
        }
        public ActionResult FinalSettlement()
        {
            return View("FinalSettlement");
        }
        public ActionResult Resettkement()
        {
            return View("Resettkement");
        }
        public ActionResult OvertimeRegister()
        {
            return View("OvertimeRegister");
        }
        public ActionResult AddSalary()
        {
            return View("AddSalary");
        }
        public ActionResult PayArrears()
        {
            return View("PayArrears");
        }
        public ActionResult SettleEmployee()
        {
            return View("SettleEmployee");
        }
    }
}