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
    public class BranchController : BaseController
    {
        public BranchController(IMaster MasterService, ISecurity SecurityService) : base(MasterService, SecurityService)
        {
        }

        #region SaveBranchDetails
        public JsonResult SaveBranchDetails(BranchViewModel branchViewModel)
        {
            JsonResult result = null;
            try
            {
                if (branchViewModel != null)
                {
                    Branch branch = new Branch();

                    if (branchViewModel.Id > 0)
                    {
                        branch.ModifiedBy = "Admin";
                        branch.ModifiedOn = DateTime.Now;
                    }
                    else
                    {
                        branch.CreatedBy = "Admin";
                        branch.CreatedOn = DateTime.Now;
                        branch.ModifiedBy = null;
                    }

                    branch.BranchName = !string.IsNullOrWhiteSpace(branchViewModel.BranchName) ? branchViewModel.BranchName : string.Empty;
                    branch.BranchCode = !string.IsNullOrWhiteSpace(branchViewModel.BranchCode) ? branchViewModel.BranchCode : string.Empty;
                    branch.CompanyCode = !string.IsNullOrWhiteSpace(branch.CompanyCode) ? branchViewModel.CompanyCode : string.Empty;

                    branch.RegNo = !string.IsNullOrWhiteSpace(branchViewModel.RegNo) ? branchViewModel.RegNo : string.Empty;
                    branch.IsActive = branchViewModel.IsActive;
                    branch.Address = GetAddress(branchViewModel.Address, branch.Address, false);

                    MasterService.Save(branch);

                    result = Json(new { success = true, message = "Saved Successfully.", JsonRequestBehavior.AllowGet });
                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null && !string.IsNullOrEmpty(ex.InnerException.Message))
                    return Json(new { success = false, message = ex.InnerException.Message }, JsonRequestBehavior.AllowGet);
            }

            return result;
        }
        #endregion
        public ActionResult Index()
        {
            ViewData["Countries"] = GetCountryDetails();
            return View();
        }
    }
}