using Clarksons.Search.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clarksons.Search.Data.ViewModel
{
    public class EmployeeViewModel : Results
    {
        public List<Employee> Employees { get; set; }
    }
}
