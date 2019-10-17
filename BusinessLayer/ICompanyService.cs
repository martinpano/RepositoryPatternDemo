using DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public interface ICompanyService
    {
        IEnumerable<Company> GetAllCompanies();
        Company GetCompanyById(int id);
        void CreateCompany(Company employee);
        void EditCompany(Company employee);
        void DeleteCompany(int id);
    }
}
