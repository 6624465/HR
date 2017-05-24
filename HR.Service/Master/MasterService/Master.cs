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
    public class Master :IMaster
    {
        #region Properties
        public IRepository<Company> CompanyRepository;
        public IRepository<Country> CountryRepository;
        public IRepository<Branch> BranchRepository;
        public IRepository<Address> AddressRepository;
        #endregion


        #region Constructor
        public Master(IRepository<Company> CompanyRepository, IRepository<Country> CountryRepository, IRepository<Branch> BranchRepository, IRepository<Address> AddressRepository)
        {
            this.CompanyRepository = CompanyRepository;
            this.CountryRepository = CountryRepository;
            this.BranchRepository = BranchRepository;
            this.AddressRepository = AddressRepository;
        }

        #endregion

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
        public IQueryable<T> GetCountries<T>(Expression<Func<T, bool>> predicate = null) where T : Country
        {
            var query = CountryRepository.FindAll().OfType<T>();
            if (predicate != null)
                query = query.Where(predicate);

            return query;
        }


        public Address GetAddress(int Id)
        {
            return AddressRepository.GetById(Id);
        }

        #region Branch
        public void Save(Branch branch)
        {
            if (branch.BranchID == 0)
                BranchRepository.Insert(branch);
            else
                BranchRepository.Update(branch);
        }

        #endregion
    }
}
