using Clarksons.Search.Data.Seeder;
using Clarksons.Search.Service.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Clarkson.Search.Api.DataGenerator
{
    public class Data
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new EmplyeeDbConext(
                serviceProvider.GetRequiredService<DbContextOptions<EmplyeeDbConext>>()))
            {
                // Look for any board games.
                if (context.Employee.Any())
                {
                    return;   // Data was already seeded
                }

                var employees = EmployeeSeed.Data();
                context.Employee.AddRange(employees);

                context.SaveChanges();
            }
        }
    }
}
