using DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
        void CreateEmployee(Employee employee);
        void EditEmployee(Employee employee);
        void DeleteEmployee(int id);
        IEnumerable<Employee> GetEmployeesByCompanyId(int companyId);
    }
}
