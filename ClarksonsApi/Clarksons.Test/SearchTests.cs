using Clarksons.Search.Data;
using Clarksons.Search.Data.Seeder;
using Clarksons.Search.Service.Contexts;
using Clarksons.Service;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Xunit;

namespace Clarkson.Test
{
    public class SearchTests
    {

        private readonly IEmployeeManager _manager;

        public SearchTests()
        {
            // Use a clean instance of the context to run the test
            var options = new DbContextOptionsBuilder<EmplyeeDbConext>()
                .UseInMemoryDatabase(databaseName: $"Clarkson.Empoyees.{Guid.NewGuid().ToString()}")
                .Options;

            var conext = new EmplyeeDbConext(options);

            _manager = new EmployeeManager(conext);
        }

        [Fact]
        public void Search_ContextHasRecords()
        {
            //Arrange
            var employees = EmployeeSeed.Data();

            //Act
            var results = _manager.Add(employees);

            //Assert 
            Assert.True(results.Succeeded);

        }

        [Fact]
        public void Search_FindStaffs()
        {
            //Arrange
            var employees = EmployeeSeed.Data();
            var search = "Baxter";

            //Act
            var addResults = _manager.Add(employees);
            var results = _manager.Find(search);


            //Assert 
            Assert.True(addResults.Succeeded);

            Assert.True(results.Succeeded);
            Assert.Equal(search, results.Employees.First().Lastname);

        }





    }
}
