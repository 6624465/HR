using HR.Controllers;
using HR.Core.Models.Master;
using HR.Service.Master.IMasterService;
using HR.Service.Security.ISecurityService;
using HR.Service.Utilities;
using HR.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using C = HR.Core.Constants;

namespace HR.Areas.Master.Controllers
{
    public class LookUpController : BaseController
    {
        // GET: Master/EmployeeType
        public LookUpController(IMaster MasterService, ISecurity SecurityService) : base(MasterService, SecurityService)
        {
        }
       
        #region GetEmployeeTypes 
        [HttpPost]
        public JsonResult GetLookUp(string LookUpCategory)
        {
            JsonResult result = null;
            try
            {
                if (!string.IsNullOrWhiteSpace(LookUpCategory))
                {
                    var lookUp = from eType in MasterService.GetLookUp<LookUp>(et => et.LookUpCategory == LookUpCategory)
                                        select new
                                        {
                                            LookUpID = eType.LookUpID,
                                            LookUpCode = eType.LookUpCode,
                                            LookUpDescription = eType.LookUpDescription,
                                            IsActive = eType.IsActive
                                        };
                    if (lookUp.Any() && lookUp != null)
                        result = Json(new { success = true, lookUpLists = lookUp, message = C.SUCCESSFUL_SAVE_MESSAGE }, JsonRequestBehavior.AllowGet);
                    else
                        result = Json(new { success = false, message = C.NO_DATA_FOUND }, JsonRequestBehavior.AllowGet);
                }
                else
                    result = Json(new { success = false, message = C.NO_DATA_FOUND}, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }

        #endregion

        #region Save EmployeeType
        [HttpPost]
        public JsonResult SaveLookUp(LookUpViewModel lookUpViewModel)
        {
            JsonResult result = null;
            try
            {
                if (lookUpViewModel != null)
                {
                    LookUp lookUp = MasterService.GetLookUp<LookUp>(l => l.LookUpID == lookUpViewModel.LookUpID).FirstOrDefault();
                    if (lookUp != null)
                    {
                        lookUp.ModifiedBy = USER_OBJECT.UserID;
                        lookUp.ModifiedOn = DateTimeConverter.SingaporeDateTimeConversion(DateTime.Now);
                    }
                    else
                    {
                        lookUp = new LookUp();
                        lookUp.CreatedBy = USER_OBJECT.UserID;
                        lookUp.CreatedOn = DateTimeConverter.SingaporeDateTimeConversion(DateTime.Now);
                        lookUp.ModifiedOn = null;
                    }

                    lookUp.LookUpCode = lookUpViewModel.LookUpCode;
                    lookUp.LookUpDescription = lookUpViewModel.LookUpDescription;
                    lookUp.IsActive = lookUpViewModel.IsActive;
                    lookUp.LookUpCategory = lookUpViewModel.LookUpCategory;
                    MasterService.Save(lookUp);

                    result = Json(new { success = true, message = C.SUCCESSFUL_SAVE_MESSAGE }, JsonRequestBehavior.AllowGet);
                }

            }
            catch (Exception ex)
            {
                result = Json(new { success = true, message = ex.Message }, JsonRequestBehavior.AllowGet);
            }
            return result;
        }
        #endregion
        #region ActionResult
        public ActionResult EmployeeType()
        {
            return View();
        }
        public ActionResult Designation()
        {
            return View();
        }

        #endregion
    }
}