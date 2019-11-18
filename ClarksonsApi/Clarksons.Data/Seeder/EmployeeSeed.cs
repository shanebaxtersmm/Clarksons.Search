using Clarksons.Search.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clarksons.Search.Data.Seeder
{
    public class EmployeeSeed
    {
        public static List<Employee> Data()
        {
            var employees = new List<Employee>();

            employees.Add(new Employee
            {
                Firstname = "John",
                Lastname = "Snow",
                HireDate = DateTime.Parse("2011-01-01")
            });

            employees.Add(new Employee
            {
                Firstname = "Jimmy",
                Lastname = "Neutron",
                HireDate = DateTime.Parse("2012-06-21")
            });

            employees.Add(new Employee
            {
                Firstname = "Dana",
                Lastname = "Lane",
                HireDate = DateTime.Parse("2019-04-17")
            });

            employees.Add(new Employee
            {
                Firstname = "Sarah",
                Lastname = "Connor",
                HireDate = DateTime.Parse("2014-09-15")
            });

            employees.Add(new Employee
            {
                Firstname = "Shane",
                Lastname = "Baxter",
                HireDate = DateTime.Parse("2020-01-20")
            });

            return employees;
        }
    }
}
