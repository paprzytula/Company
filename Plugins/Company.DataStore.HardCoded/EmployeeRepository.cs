using Company.CoreBusiness.Models;
using Company.UseCases.PluginInterfaces.DataStore;
using NinjaNye.SearchExtensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Company.DataStore.HardCoded
{
    public class EmployeeRepository :IEmployeeRepository
    {
        private readonly List<Employee> employees = new List<Employee>
        {
         new Employee { EmployeeId=1, Department = "IT", FirstName= "Błażej", LastName ="Nowy", Email ="bnowy@gmail.com" },
         new Employee {   EmployeeId=2, Department = "Shopfloor", FirstName= "Paweł", LastName ="Tuliś", Email ="ptulis@gmail.com" },
         new Employee {   EmployeeId=3, Department = "Administracja", FirstName= "Weronika", LastName ="Rak", Email ="wrak@gmail.com" },
        };
        public EmployeeRepository()
        {

        }

        public IEnumerable<Employee> GetEmployees()
        {
            return employees;
        }

        Employee IEmployeeRepository.GetEmployee(int employeeId)
        {
            return employees.FirstOrDefault(x => x.EmployeeId == employeeId);
            
        }


        IEnumerable<Employee> IEmployeeRepository.GetEmployees(string filter)
        {
            if (string.IsNullOrWhiteSpace(filter)) return employees;
            filter = filter.ToLower();

            var result = employees.Search(x => x.FirstName.ToLower(),
               x => x.LastName.ToLower(),
               x => x.Email.ToLower(),
                x => x.Department.ToLower()).Containing(filter).ToList();
            return result;
        }
    }
}
