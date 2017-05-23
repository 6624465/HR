using HR.Controllers;
using HR.Core.Models.Master;
using HR.Service.Master.IMasterService;
using HR.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR.Areas.Master.Controllers
{
    public class CompanyController : BaseController
    {
        #region Constructor
        public CompanyController(IMaster MasterService):base(MasterService)
        {
        }
        #endregion

        #region save company

        public JsonResult SaveCompany(CompanyViewModel companyViewModel)
        {
            JsonResult result = null;
            if (companyViewModel != null)
            {
                try
                {
                    Company company = new Company();
                    if (companyViewModel.Id > 0)
                    {
                        company.ModifiedBy = "Admin";
                        company.ModifiedOn = DateTime.Now;
                    }
                    else
                    {
                        company.CreatedBy = "Admin";
                        company.CreatedOn = DateTime.Now;
                        company.ModifiedOn = null;
                    }

                    company.CompanyCode = !string.IsNullOrWhiteSpace(companyViewModel.CompanyCode) ? companyViewModel.CompanyCode : string.Empty;
                    company.CompanyName = !string.IsNullOrWhiteSpace(companyViewModel.CompanyName) ? companyViewModel.CompanyName : string.Empty;
                    company.IsActive = companyViewModel.IsActive;
                    company.RegNo = companyViewModel.RegNo;
                    company.Address = new Address();
                    company.Address = GetAddress(companyViewModel.Address);

                    MasterService.Save(company);

                    result = Json(new { success = true, message = "Saved Successfully.",  JsonRequestBehavior.AllowGet });
                }
                catch (Exception ex)
                {
                    if (ex.InnerException != null && !string.IsNullOrEmpty(ex.InnerException.Message))
                        return Json(new { success = false, message = ex.InnerException.Message }, JsonRequestBehavior.AllowGet);
                }
            }
            return result;
        }

        #endregion

        #region view result
        public ActionResult Index()
        {
            ViewData["Countries"] = GetCountryDetails();
            return View();
        }
        #endregion

    }
}