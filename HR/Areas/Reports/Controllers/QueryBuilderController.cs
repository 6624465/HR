using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR.Areas.Reports.Controllers
{
    public class QueryBuilderController : Controller
    {
        public ActionResult QueryBuilder()
        {
            return View("QueryBuilder");
        }
    }
}