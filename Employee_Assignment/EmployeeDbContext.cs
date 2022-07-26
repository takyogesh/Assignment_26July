using Employee_Assignment.Models;
using Microsoft.EntityFrameworkCore;

namespace Employee_Assignment
{
    public class EmployeeDbContext :DbContext
    {
        public DbSet<Employee> Employees { set; get; }
        public EmployeeDbContext(DbContextOptions options) : base(options)
        {}
        public EmployeeDbContext()
        { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-00LQG0A;Initial Catalog=EmployeeWebApp;Integrated Security=True");

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Employee>().HasIndex(Emp => Emp.Email).IsUnique();
        }


    }
}
