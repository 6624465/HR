using HR.Core.Models.Master;
using HR.Data;
using HR.Service.Master.IMasterService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HR.Service.Master.MasterService
{
    public class Master : IMaster
    {
        #region Properties
        public IRepository<Company> CompanyRepository;
        public IRepository<Country> CountryRepository;
        public IRepository<Branch> BranchRepository;
        public IRepository<Address> AddressRepository;
        public IRepository<HolidayList> HolidayRepository;
        public IRepository<LookUp> LookUpRepository;
        #endregion


        #region Constructor
        public Master(IRepository<Company> CompanyRepository, IRepository<Country> CountryRepository,
            IRepository<Branch> BranchRepository, IRepository<Address> AddressRepository, IRepository<HolidayList> HolidayRepository, IRepository<LookUp> LookUpRepository)
        {
            this.CompanyRepository = CompanyRepository;
            this.CountryRepository = CountryRepository;
            this.BranchRepository = BranchRepository;
            this.AddressRepository = AddressRepository;
            this.HolidayRepository = HolidayRepository;
            this.LookUpRepository = LookUpRepository;
        }

        #endregion

        #region Company
        public void Save(Company company)
        {
            if (company.Id == 0)
                CompanyRepository.Insert(company);
            else
                CompanyRepository.Update(company);
        }
        public Company GetCompany(int Id)
        {
            return CompanyRepository.GetById(Id);
        }
        public IQueryable<T> GetCompanies<T>(Expression<Func<T, bool>> predicate = null) where T : Company
        {
            var query = CompanyRepository.FindAll().OfType<T>();
            if (predicate != null)
                query = query.Where(predicate);

            return query;
        }
        #endregion

        #region Country
        public IQueryable<T> GetCountries<T>(Expression<Func<T, bool>> predicate = null) where T : Country
        {
            var query = CountryRepository.FindAll().OfType<T>();
            if (predicate != null)
                query = query.Where(predicate);

            return query;
        }
        #endregion

        #region Address
        public Address GetAddress(int Id)
        {
            return AddressRepository.GetById(Id);
        }
        #endregion

        #region Branch
        public void Save(Branch branch)
        {
            if (branch.BranchID == 0)
                BranchRepository.Insert(branch);
            else
                BranchRepository.Update(branch);
        }

        public Branch GetBranch(int Id)
        {
            return BranchRepository.GetById(Id);
        }

        public IQueryable<T> GetBranches<T>(Expression<Func<T, bool>> predicate = null) where T : Branch
        {
            var query = BranchRepository.FindAll().OfType<T>();
            if (predicate != null)
                query = query.Where(predicate);

            return query;
        }


        #endregion

        #region HolidayList
        public void Save(HolidayList holidayList)
        {
            if (holidayList.Id == 0)
                HolidayRepository.Insert(holidayList);
            else
                HolidayRepository.Update(holidayList);
        }
        public void Remove(HolidayList holidayList)
        {
            if (holidayList.Id > 0)
            {
                HolidayRepository.Remove(holidayList);
            }
        }
        public IQueryable<T> GetHolidayLists<T>(Expression<Func<T, bool>> predicate = null) where T : HolidayList
        {
            var query = HolidayRepository.FindAll().OfType<T>();
            if (predicate != null)
                query = query.Where(predicate);

            return query;
        }

        #endregion

        #region LookUP
        public void Save(LookUp lookUp)
        {
            if (lookUp.LookUpID == 0)
                LookUpRepository.Insert(lookUp);
            else
                LookUpRepository.Update(lookUp);
        }

        public IQueryable<T> GetLookUp<T>(Expression<Func<T, bool>> predicate = null) where T : LookUp
        {
            var query = LookUpRepository.FindAll().OfType<T>();
            if (predicate != null)
                query = query.Where(predicate);
            return query;
        }

        public LookUp GetLookUpType(int LookUpID)
        {
            return LookUpRepository.GetById(LookUpID);
        }
        #endregion
    }
}
