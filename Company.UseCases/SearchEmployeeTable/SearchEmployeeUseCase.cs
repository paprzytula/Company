using Company.CoreBusiness.Models;
using Company.UseCases.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.UseCases.SearchEmployeeTable 
{
    public class SearchEmployeeUseCase : ISearchEmployeeUseCase
    {
        private readonly IEmployeeRepository employeeRepository;

        public SearchEmployeeUseCase(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }
        public IEnumerable<Employee> Execute(string filter)
        {
         return   employeeRepository.GetEmployees(filter);
        }

        public IEnumerable<Employee> Execute()
        {
            return employeeRepository.GetEmployees();
        }
    }
}
