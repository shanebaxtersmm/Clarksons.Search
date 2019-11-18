using Clarksons.Search.Service.Models;
using Microsoft.EntityFrameworkCore;

namespace Clarksons.Search.Service.Contexts
{
    public class EmplyeeDbConext : DbContext
    {
        public EmplyeeDbConext(DbContextOptions options) : base(options) { }

        public virtual DbSet<Employee> Employee { get; set; }
    }
}
