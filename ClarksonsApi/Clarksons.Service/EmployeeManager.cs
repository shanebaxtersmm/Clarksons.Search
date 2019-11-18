using Clarksons.Search.Data;
using Clarksons.Search.Data.ViewModel;
using Clarksons.Search.Service.Contexts;
using Clarksons.Search.Service.Models;
using Clarksons.Search.Common.Extensions;
using System;
using System.Linq;
using System.Collections.Generic;


namespace Clarksons.Service
{
    public class EmployeeManager : IEmployeeManager
    {
        private readonly EmplyeeDbConext _conext;
        public EmployeeManager(EmplyeeDbConext conext)
        {
            _conext = conext;
        }
        public Results Add(List<Employee> employees)
        {
            var results = new Results { Succeeded = false };
            try
            {

                if (!employees.IsNull() && employees.Any())
                {
                    _conext.Employee.AddRange(employees);
                    _conext.SaveChanges();
                    results.Succeeded = true;
                }
            }
            catch
            {
                results.AddMessage("Error : Insert failed.");

            }

            return results;
        }

        public EmployeeViewModel Find(string lastname)
        {
            var results = new EmployeeViewModel { Succeeded = false };
            try
            {

                if (!string.IsNullOrWhiteSpace(lastname))
                {
                    //exact match - also made not case sensitive 
                    var employees = _conext.Employee.Where(e => string.Equals(e.Lastname, lastname, StringComparison.InvariantCultureIgnoreCase)).ToList();
                    results.Employees = employees;
                    results.Succeeded = true;
                }
            }
            catch
            {
                results.AddMessage("Error : Insert failed.");

            }

            return results;
        }
    }
}
