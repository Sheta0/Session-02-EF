using Demo_02.Configurations;
using Demo_02.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Demo_02.Contexts
{
    class EFDemo02DbContext : DbContext
    {
        //public EFDemo02DbContext() : base()
        //{
            
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Fluent API
            //////modelBuilder.Entity<Employee>().HasKey("EmpId");
            //////modelBuilder.Entity<Employee>().HasKey(nameof(Employee.EmpId));
            ////modelBuilder.Entity<Employee>().HasKey(E => E.EmpId);

            ////modelBuilder.Entity<Employee>().Property(E => E.Name)
            ////                               .IsRequired()
            ////                               .HasMaxLength(50)
            ////                               .HasColumnType("varchar")
            ////                               .HasColumnName("EmployeeName");

            ////modelBuilder.Entity<Employee>().Property(E => E.Age)
            ////                               .IsRequired(false);

            ////modelBuilder.Entity<Employee>().Property(E => E.Salary).HasColumnType("money");

            ////modelBuilder.Entity<Employee>().Property(E => E.DateOfCreation)
            ////                               .HasDefaultValueSql("GETDATE()");

            //modelBuilder.Entity<Employee>(E =>
            //{
            //    E.HasKey(E => E.EmpId);

            //    E.Property(E => E.Name)
            //     .IsRequired()
            //     .HasMaxLength(50)
            //     .HasColumnType("varchar")
            //     .HasColumnName("EmployeeName");

            //    E.Property(E => E.Age).IsRequired(false);

            //    E.Property(E => E.Salary).HasColumnType("money");

            //    E.Property(E => E.DateOfCreation).HasDefaultValueSql("GETDATE()");
            //}); 
            #endregion

            //modelBuilder.Entity<Employee>().ToView("View_Employees");

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            #region One To One
            //modelBuilder.Entity<Employee>()
            //            .HasOne(E => E.Department)
            //            .WithOne(D => D.Manager)
            //            .HasForeignKey<Department>(D => D.EmpId);

            //modelBuilder.Entity<Department>()
            //            .HasOne(D => D.Manager)
            //            .WithOne(E => E.Department)
            //            .HasForeignKey<Department>(D => D.EmpId);
            #endregion

            #region One To Many
            //modelBuilder.Entity<Department>()
            //            .HasMany(D => D.Employees)
            //            .WithOne(E => E.WorkFor)
            //            .HasForeignKey(E => E.WorkForId); 
            #endregion

            modelBuilder.Entity<StudentCourse>()
                        .HasKey(SC => new { SC.StudentId, SC.CourseId });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // DB Connection
            optionsBuilder.UseSqlServer("Server = .; Database = EFDemo02; Trusted_Connection = True; TrustServerCertificate = True");
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
