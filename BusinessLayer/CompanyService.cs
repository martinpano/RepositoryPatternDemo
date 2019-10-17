using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.GenericRepositoryImplementation;
using DomainModels;

namespace BusinessLayer
{
    public class CompanyService : ICompanyService
    {
        private readonly Repository<Company> _genericRepo;

        public CompanyService()
        {
            _genericRepo = new Repository<Company>();
        }
        public void CreateCompany(Company employee)
        {
            throw new NotImplementedException();
        }

        public void DeleteCompany(int id)
        {
            throw new NotImplementedException();
        }

        public void EditCompany(Company employee)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Company> GetAllCompanies()
        {
            return _genericRepo.GetAll();
        }

        public Company GetCompanyById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
