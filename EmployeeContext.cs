using Microsoft.EntityFrameworkCore;

namespace Entityframework.demo
{
    internal class EmployeeContext : DbContext
    {
        private readonly string connectionString;

        public EmployeeContext(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public DbSet<Employee> Employees {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
