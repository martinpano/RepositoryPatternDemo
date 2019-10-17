using BusinessLayer;
using DomainModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryPatternDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region OrdinaryRepository
            Console.WriteLine("Select from the list of actions what do you want to do:" +
                " \n1.See all employees" +
                " \n2.See all employees from selected company" +
                " \n3.Show employee by id" +
                " \n4.Edit employee" +
                " \n5.Delete employee");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    ShowAllEmployees();
                    break;
                case "2":
                    Console.WriteLine("Please enter company id:");
                    ShowAllCompanies();
                    int companyId = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Employees that works in the selected company:");
                    GetAllEmployeesByCompanyId(companyId);
                    break;
                case "3":
                    Console.WriteLine("Please enter an id:");
                    int id = Int32.Parse(Console.ReadLine());
                    GetEmployeeById(id);
                    break;
                case "4":
                    Console.WriteLine($"Which employee do you want to edit (Enter id)");
                    ShowAllEmployees();
                    int input = Int32.Parse(Console.ReadLine());
                    GetEmployeeById(input);
                    Console.WriteLine("First name: ");
                    string fName = Console.ReadLine();
                    Console.WriteLine("Lastname: ");
                    string lName = Console.ReadLine();
                    Employee emp = new Employee();
                    emp.FirstName = fName;
                    emp.LastName = lName;
                    Edit(emp, input);
                    ShowAllEmployees();
                    break;
                case "5":
                    Console.WriteLine($"Which employee do you want to delete (Enter id)");
                    ShowAllEmployees();
                    int userToDelete = Int32.Parse(Console.ReadLine());
                    Delete(userToDelete);
                    ShowAllEmployees();
                    break;
                default:
                    break;
            }
            Console.ReadLine();
            #endregion
        }

        public static IEmployeeService GetEmployeeServiceInstance()
        {
            return new EmployeeService();
        }
        public static ICompanyService GetCompanyServiceInstance()
        {
            return new CompanyService();
        }

        public static void Edit(Employee model, int id)
        {
            var _employeeService = GetEmployeeServiceInstance();
            Employee employee = _employeeService.GetEmployeeById(id);
            employee.Id = id;
            employee.FirstName = model.FirstName;
            employee.LastName = model.LastName;
            _employeeService.EditEmployee(employee);
        }

        private static void GetEmployeeById(int id)
        {
            var _employeeService = GetEmployeeServiceInstance();
            Employee employee = _employeeService.GetEmployeeById(id);
            Console.WriteLine($"{employee.Id}. {employee.FirstName} {employee.LastName} \n");
        }

        private static void Delete(int id)
        {
            var _employeeService = GetEmployeeServiceInstance();
            _employeeService.DeleteEmployee(id);
        }

        private static void ShowAllEmployees()
        {
            var _employeeService = GetEmployeeServiceInstance();
            List<Employee> employees = _employeeService.GetAllEmployees().ToList();

            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.Id}. {emp.FirstName} {emp.LastName} \n");
            }
        }

        private static void GetAllEmployeesByCompanyId(int id)
        {
            var _employeeService = GetEmployeeServiceInstance();
            List<Employee> employees = _employeeService.GetEmployeesByCompanyId(id).ToList();
            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.Id}. {emp.FirstName} {emp.LastName} \n");
            }
        }
        private static void ShowAllCompanies()
        {
            var _companyService = GetCompanyServiceInstance();
            List<Company> companies = _companyService.GetAllCompanies().ToList();
            foreach (var company in companies)
            {
                Console.WriteLine($"{company.Id}. {company.Name} \n");
            }
        }
    }
}
