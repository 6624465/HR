using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR.Areas.Reports.Controllers
{
    public class ReportsController : Controller
    {
        // GET: Reports/Reports
        public ActionResult Index()
        {
            return View();
        }
    }
}