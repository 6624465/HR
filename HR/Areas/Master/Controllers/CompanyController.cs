using HR.Controllers;
using HR.Core.Models.Master;
using HR.Service.Master.IMasterService;
using HR.Service.Security.ISecurityService;
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
        public CompanyController(IMaster MasterService, ISecurity SecurityService) : base(MasterService, SecurityService)
        {
        }
        #endregion

        #region Get Company Details
        public JsonResult GetCompanyDetails(int companyId)
        {
            JsonResult result = null;
            try
            {
                if (companyId > 0)
                {
                    Company company = MasterService.GetCompany(companyId);
                    Address address = company != null ? MasterService.GetAddress(company.AddressID) : null;
                    CompanyViewModel companyViewModel = new CompanyViewModel();
                    AddressViewModel addressViewModel = new AddressViewModel();
                    companyViewModel.Id = company.Id;
                    companyViewModel.CompanyCode = company.CompanyCode;
                    companyViewModel.CompanyName = company.CompanyName;
                    companyViewModel.RegNo = company.RegNo;
                    companyViewModel.Address = PrepareAddressViewModel(address);

                    result = Json(companyViewModel, JsonRequestBehavior.AllowGet);

                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null && !string.IsNullOrWhiteSpace(ex.InnerException.Message))
                    result = Json(new { sucess = false, exception = ex.InnerException.Message, JsonRequestBehavior.AllowGet });
            }
            return result;
        }
        #endregion

        #region Save Company
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
                        company = MasterService.GetCompany(companyViewModel.Id);
                        //company.Address = MasterService.GetAddress(company.AddressID);
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
                    company.Address = companyViewModel.Address.AddressID == 0 ? new Address() : company.Address;
                    company.Address = GetAddress(companyViewModel.Address, company.Address, true);

                    MasterService.Save(company);

                    result = Json(new { success = true, message = "Saved Successfully.", JsonRequestBehavior.AllowGet });
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

        #region common JsonResults
        public JsonResult GetCountries()
        {
            JsonResult result = null;
            try
            {
                List<CountryViewModel> countryViewModelList = GetCountryDetails();
                if (countryViewModelList != null)
                    result = Json(countryViewModelList, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null && !string.IsNullOrEmpty(ex.InnerException.Message))
                    return Json(new { success = false, message = ex.InnerException.Message }, JsonRequestBehavior.AllowGet);
            }
            return result;
        }
        #endregion

        #region View Result
        public ActionResult Index()
        {
            ViewData["Countries"] = GetCountryDetails();
            return View();
        }
        #endregion

    }
}