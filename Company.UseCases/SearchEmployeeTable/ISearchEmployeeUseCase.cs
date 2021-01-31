using Company.CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.UseCases.SearchEmployeeTable
{
   public interface ISearchEmployeeUseCase
    {
        IEnumerable<Employee> Execute(string filter);
        IEnumerable<Employee> Execute();
    }
}
