using HR.Core.Models.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HR.Service.Master.IMasterService
{
    public interface IMaster
    {
        #region Company
        void Save(Company company);
        IQueryable<T> GetCompanies<T>(Expression<Func<T, bool>> predicate = null) where T : Company;
        Company GetCompany(int Id);
        #endregion

        #region Country
        IQueryable<T> GetCountries<T>(Expression<Func<T, bool>> predicate = null) where T : Country;
        #endregion

        #region Branch

        Branch GetBranch(int Id);
        IQueryable<T> GetBranches<T>(Expression<Func<T, bool>> predicate = null) where T : Branch;
        void Save(Branch branch);
        #endregion

        #region Address
        Address GetAddress(int Id);
        #endregion

        #region HolidayList
        IQueryable<T> GetHolidayLists<T>(Expression<Func<T, bool>> predicate = null) where T : HolidayList;
        void Save(HolidayList holidayList);
        void Remove(HolidayList holidayList);
        #endregion

        #region EmployeeType
        void Save(LookUp lookUpData);
        IQueryable<T> GetLookUp<T>(Expression<Func<T, bool>> predicate = null) where T : LookUp;
        LookUp GetLookUpType(int LookUpID);
        #endregion
    }
}
