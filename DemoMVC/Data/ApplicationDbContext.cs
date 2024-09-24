using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DemoMVC.Models;

namespace DemoMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Nguoi> Nguoi { get; set; } = default!;
        public DbSet<Sinhvien> Sinhvien { get; set;} = default!;
        public DbSet<Student> Students { get; set; } = default!;
    }
}
