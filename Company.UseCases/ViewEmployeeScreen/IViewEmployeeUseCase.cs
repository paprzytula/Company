using Company.CoreBusiness.Models;
using Company.UseCases.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.UseCases.ViewEmployeeScreen
{
    public interface IViewEmployeeUseCase
    {
      Employee  Execute(int employeeId);
    }
}