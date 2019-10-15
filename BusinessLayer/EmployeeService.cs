using DataAccess.GenericRepositoryImplementation;
using DataAccess.Repository_Ordinary;
using DomainModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class EmployeeService : IEmployeeService
    {
        //private readonly IEmployeeRepository _employeeRepository;
        private readonly Repository<Employee> _genericRepo;
        public EmployeeService()
        {
            //_employeeRepository = new EmployeeRepository();
            _genericRepo = new Repository<Employee>();
        }

        public void CreateEmployee(Employee employee)
        {
            //_employeeRepository.Insert(employee);
            throw new NotFiniteNumberException();
        }

        public void DeleteEmployee(int id)
        {
            //_employeeRepository.Remove(id);
            throw new NotFiniteNumberException();

        }

        public void EditEmployee(Employee employee)
        {
            //_employeeRepository.Update(employee);
            throw new NotFiniteNumberException();

        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            //return _employeeRepository.GetAll();
            return _genericRepo.GetAll(x => x.Include(y => y.FirstName == "Martin"));
        }

        public Employee GetEmployeeById(int id)
        {
            //return _employeeRepository.GetById(id);
            throw new NotFiniteNumberException();

        }
    }
}
