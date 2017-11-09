using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR.Areas.ExpenseClaims
{
    public class ExpenseClaimsAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "ExpenseClaims";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "ExpenseClaims_default",
                "ExpenseClaims/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}