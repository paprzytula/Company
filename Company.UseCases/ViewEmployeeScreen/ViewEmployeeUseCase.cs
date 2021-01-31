using Company.CoreBusiness.Models;
using Company.UseCases.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.UseCases.ViewEmployeeScreen
{
   public class ViewEmployeeUseCase : IViewEmployeeUseCase
    {
        private readonly IEmployeeRepository employeeRepository;


        public ViewEmployeeUseCase(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }
        public Employee Execute(int employeeId)
        {
            return employeeRepository.GetEmployee(employeeId);
        }
    }
}
