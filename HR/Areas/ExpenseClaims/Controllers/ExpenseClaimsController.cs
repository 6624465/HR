using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR.Areas.ExpenseClaims.Controllers
{
    public class ExpenseClaimsController : Controller
    {
        public ActionResult ExpenseClaims()
        {
            return View("ExpenseClaims");
        }
    }
}