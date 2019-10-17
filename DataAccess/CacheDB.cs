using DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class CacheDB
    {
        public static List<Employee> Employees = new List<Employee>()
        {
            new Employee(){FirstName = "Martin", LastName = "Panovski"},
            new Employee() { FirstName = "Emilija", LastName = "Joskovska"}
        };
    }
}
