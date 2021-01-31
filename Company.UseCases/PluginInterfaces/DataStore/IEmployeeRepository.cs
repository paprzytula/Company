using Company.CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.UseCases.PluginInterfaces.DataStore
{
  public  interface IEmployeeRepository
    {
        Employee GetEmployee(int employeeId);
        IEnumerable<Employee> GetEmployees(string filter);
        IEnumerable<Employee> GetEmployees();
    }
}
