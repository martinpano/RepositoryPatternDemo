using DataAccess.GenericRepositoryImplementation;
using DataAccess.GenericRepositoryInterface;
using DataAccess.Repository_Ordinary;
using DomainModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class EmployeeService : IEmployeeService
    {
        //private readonly IEmployeeRepository _employeeRepository;
        //private readonly IRepository<Employee> _employeeRepositoryInterface;
        private readonly Repository<Employee> _genericRepo;
        public EmployeeService()
        {
            //_employeeRepository = new EmployeeRepository();
            _genericRepo = new Repository<Employee>();
            //_employeeRepositoryInterface = new EmployeeGenericInterfaceRepository();
        }

        public void CreateEmployee(Employee employee)
        {
            //_employeeRepository.Insert(employee);

            _genericRepo.Insert(employee);

            //_employeeRepositoryInterface.Insert(employee);
        }

        public void DeleteEmployee(int id)
        {

            //_employeeRepository.Remove(id);

            Employee employee = _genericRepo.GetById(id);
            _genericRepo.Delete(employee);

            //_employeeRepositoryInterface.Remove(id);

        }

        public void EditEmployee(Employee employee)
        {
            //_employeeRepository.Update(employee);
            _genericRepo.Update(employee);
            //_employeeRepositoryInterface.Update(employee);

        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            //return _employeeRepository.GetAll();
            //return _employeeRepositoryInterface.GetAll();

            //return _genericRepo.GetAll(x => x.FirstName == "Martin");
            return _genericRepo.GetAll();


        }

        public Employee GetEmployeeById(int id)
        {
            //return _employeeRepository.GetById(id);
            //return _employeeRepositoryInterface.GetById(id);


            return _genericRepo.GetById(id);

        }

        public IEnumerable<Employee> GetEmployeesByCompanyId(int companyId)
        {
            //_employeeRepository.Get
            //return _employeeRepository.GetAll().Where(x => x.CompanyId == companyId);
            return _genericRepo.GetAll(x => x.CompanyId == companyId);
        }
    }
}
