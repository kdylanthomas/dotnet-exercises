using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;

namespace MVC_Intro.Models
{
    public class DataContext : DbContext
    {
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Department> Department { get; set; }

        protected override void OnModelCreating (DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .ToTable("Employee")
                .HasKey(e => e.EmployeeId);

            modelBuilder.Entity<Department>()
                .ToTable("Department")
                .HasKey(d => d.DepartmentId);
        }
    }
}