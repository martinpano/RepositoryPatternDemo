using DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repository_Ordinary
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        Employee GetById(int id);
        void Insert(Employee employee);
        void Update(Employee employee);
        void Remove(int id);
    }
}
