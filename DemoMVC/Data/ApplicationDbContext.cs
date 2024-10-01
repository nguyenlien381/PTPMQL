using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using DemoMVC.Models;

namespace DemoMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        public DbSet<Student> Student { get; set;}
        public DbSet<DemoMVC.Models.Person> Person { get; set; } = default!;
        public DbSet<Employee> Employee { get; set;} = default!;
    }
}