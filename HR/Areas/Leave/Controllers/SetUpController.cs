using HR.Controllers;
using HR.Core.Models.Master;
using HR.Service.Master.IMasterService;
using HR.Service.Security.ISecurityService;
using HR.Service.Utilities;
using HR.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR.Areas.Leave.Controllers
{
    public class SetUpController : BaseController
    {
        #region Properties
        #endregion

        #region Constructor
        public SetUpController(IMaster MasterService, ISecurity SeurityService) : base(MasterService, SeurityService)
        {
        }
        #endregion

        #region HolidayList

        #region Public Methods
        public JsonResult GetHolidayLists(int branchId)
        {
            JsonResult result = null;
            try
            {
                if (branchId > 0)
                {
                    List<HolidayList> holidayLists = MasterService.GetHolidayLists<HolidayList>(hl => hl.BranchID == branchId).ToList();
                    if (holidayLists != null && holidayLists.Any())
                    {
                        List<HolidayListViewModel> holidayListViewModels = new List<HolidayListViewModel>();
                        foreach (var holidayList in holidayLists)
                        {
                            Branch branch = MasterService.GetBranch(branchId);
                            Country country = branch.Address != null ? MasterService.GetCountries<Country>(c => c.CountryCode == branch.Address.CountryCode).FirstOrDefault() : null;
                            HolidayListViewModel holidayListViewModel = new HolidayListViewModel()
                            {
                                start = holidayList.Date != null ? holidayList.Date : DateTimeConverter.SingaporeDateTimeConversion(DateTime.Now),
                                title = !string.IsNullOrWhiteSpace(holidayList.Description) ? holidayList.Description : string.Empty,
                                Id = holidayList.Id,
                                Date = holidayList.Date != null ? holidayList.Date.ToShortDateString() : DateTimeConverter.SingaporeDateTimeConversion(DateTime.Now).ToShortDateString(),
                                Description = !string.IsNullOrWhiteSpace(holidayList.Description) ? holidayList.Description : string.Empty,
                                CreatedBy = !string.IsNullOrWhiteSpace(holidayList.CreatedBy) ? holidayList.CreatedBy : string.Empty,
                                CreatedOn = holidayList.CreatedOn != null ? holidayList.CreatedOn : DateTime.Now,
                                ModifiedBy = !string.IsNullOrWhiteSpace(holidayList.ModifiedBy) ? holidayList.ModifiedBy : string.Empty,
                                ModifiedOn = holidayList.ModifiedOn.HasValue ? holidayList.ModifiedOn.Value : DateTime.Now,
                                BranchID = Convert.ToInt16(holidayList.BranchID),
                                Location = country.CountryName
                            };
                            //HolidayListViewModel holidayListViewModel = new HolidayListViewModel()
                            //{
                            //    Id = holidayList.Id,
                            //    Date = holidayList.Date != null ? holidayList.Date : DateTime.Now,
                            //    Description = !string.IsNullOrWhiteSpace(holidayList.Description) ? holidayList.Description : string.Empty,
                            //    CreatedBy = !string.IsNullOrWhiteSpace(holidayList.CreatedBy) ? holidayList.CreatedBy : string.Empty,
                            //    CreatedOn = holidayList.CreatedOn != null ? holidayList.CreatedOn : DateTime.Now,
                            //    ModifiedBy = !string.IsNullOrWhiteSpace(holidayList.ModifiedBy) ? holidayList.ModifiedBy : string.Empty,
                            //    ModifiedOn = holidayList.ModifiedOn.HasValue ? holidayList.ModifiedOn.Value : DateTime.Now,
                            //    BranchID = Convert.ToInt16(holidayList.BranchID)
                            //};

                            holidayListViewModels.Add(holidayListViewModel);
                        }
                        result = Json(holidayListViewModels, JsonRequestBehavior.AllowGet);
                    }
                    else
                        result = Json(new { success = false, message = "Not Found." }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null && !string.IsNullOrEmpty(ex.InnerException.Message))
                    result = Json(new { success = false, message = ex.InnerException.Message }, JsonRequestBehavior.AllowGet);
            }
            return result;
        }

        public JsonResult SaveHolidayLists(HolidayListViewModel holidayListViewModel)
        {
            JsonResult result = null;
            //HolidayListViewModel holidayListViewModel = new HolidayListViewModel();
            try
            {
                Branch branch = holidayListViewModel.BranchID > 0 ? MasterService.GetBranch(holidayListViewModel.BranchID) : null;
                if (holidayListViewModel != null)
                {
                    HolidayList holidayList = new HolidayList();
                    if (holidayListViewModel.Id == 0)
                    {
                        holidayList.CreatedBy = "Admin";
                        holidayList.CreatedOn = DateTimeConverter.SingaporeDateTimeConversion(DateTime.Now);
                    }
                    else
                    {
                        holidayList.ModifiedBy = "Admin";
                        holidayList.ModifiedOn = DateTimeConverter.SingaporeDateTimeConversion(DateTime.Now);
                    }
                    holidayList.Date = DateTimeConverter.SingaporeDateTimeConversion(DateTime.ParseExact(holidayListViewModel.Date, "dd/MM/yyyy", CultureInfo.InvariantCulture));
                    holidayList.Description = !string.IsNullOrWhiteSpace(holidayListViewModel.Description) ? holidayListViewModel.Description : string.Empty;
                    holidayList.BranchID = branch != null ? branch.BranchID : 0;

                    if (holidayList != null)
                        MasterService.Save(holidayList);
                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null && !string.IsNullOrEmpty(ex.InnerException.Message))
                    return Json(new { success = false, message = ex.InnerException.Message }, JsonRequestBehavior.AllowGet);
            }
            return result;
        }

        public JsonResult GetBranchCountries()
        {
            JsonResult result = null;
            try
            {
                List<string> BranchCountryCodes = MasterService.GetBranches<Branch>().Select(br => br.Address.CountryCode).ToList();
                List<CountryViewModel> countryViewModelList = new List<CountryViewModel>();
                if (BranchCountryCodes != null && BranchCountryCodes.Any())
                {
                    foreach (string BranchCountryCode in BranchCountryCodes)
                    {

                        Country country = MasterService.GetCountries<Country>(s => s.CountryCode == BranchCountryCode).FirstOrDefault();

                        CountryViewModel countryViewModel = new CountryViewModel
                        {
                            Id = country.Id,
                            CountryName = country.CountryName
                        };
                        countryViewModelList.Add(countryViewModel);
                    }

                    result = Json(countryViewModelList, JsonRequestBehavior.AllowGet);
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



        #region PrivateMethods
        #endregion

        #endregion


        #region  Action Result
        public ActionResult HolidayList()
        {
            return View("HolidayList");
        }
        public ActionResult ShiftRotationCalender()
        {
            return View("ShiftRotationCalender");
        }

        #endregion
    }
}