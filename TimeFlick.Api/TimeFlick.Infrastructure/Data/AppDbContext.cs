using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using TimeFlick.Core.Entities;

namespace TimeFlick.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // DbSets
        public DbSet<Person> Persons { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<Attendance> Attendances { get; set; }

        // Optional: If you have Organizations
        public DbSet<Organization> Organizations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Apply entity configurations (if any)
            //modelBuilder.ApplyConfiguration(new PersonConfiguration());
            //modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            //modelBuilder.ApplyConfiguration(new DesignationConfiguration());
            //modelBuilder.ApplyConfiguration(new ShiftConfiguration());
            //modelBuilder.ApplyConfiguration(new AttendanceConfiguration());
            //modelBuilder.ApplyConfiguration(new OrganizationConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
