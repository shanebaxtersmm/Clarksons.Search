using Clarksons.Search.Data.ViewModel;
using Clarksons.Search.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clarksons.Search.Data
{
    public interface IEmployeeManager
    {
        Results Add(List<Employee> employees);
        EmployeeViewModel Find(string lastname);

    }
}
