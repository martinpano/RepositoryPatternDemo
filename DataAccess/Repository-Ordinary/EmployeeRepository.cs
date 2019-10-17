using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainModels;

namespace DataAccess.Repository_Ordinary
{
    public class EmployeeRepository : BaseRepository, IEmployeeRepository
    {
        public IEnumerable<Employee> GetAll()
        {
            return _context.Employees;
            //return CacheDB.Employees;
        }

        public Employee GetById(int id)
        {
            Employee employee = _context.Employees.SingleOrDefault(x => x.Id == id);
            if (employee != null)
                return employee;
            throw new Exception("Employee does not exist!");
        }

        public void Insert(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public void Remove(int id)
        {
            Employee employee = _context.Employees.SingleOrDefault(x => x.Id == id);
            if (employee != null)
                _context.Employees.Remove(employee);
            _context.SaveChanges();
        }

        public void Update(Employee employee)
        {
            Employee emp = _context.Employees.SingleOrDefault(x => x.Id == employee.Id);
            if (emp != null)
                _context.Employees.Update(emp);
            _context.SaveChanges();

        }
    }
}
