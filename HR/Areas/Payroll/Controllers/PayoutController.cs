using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR.Areas.Payroll.Controllers
{
    public class PayoutController : Controller
    {
        public ActionResult JVQuickBooksOnline()
        {
            return View("JVQuickBooksOnline");
        }
        public ActionResult BankTransfer()
        {
            return View("BankTransfer");
        }
        public ActionResult ChequeCashStatement()
        {
            return View("ChequeCashStatement");
        }
        public ActionResult Payslips()
        {
            return View("Payslips");
        }
        public ActionResult NewBankTransfer()
        {
            return View("NewBankTransfer");
        }
    }
}