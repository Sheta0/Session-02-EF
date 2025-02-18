using Assignment_02.Configurations;
using Assignment_02.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01.Contexts
{
    class EF02DbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Student>()
                        .HasOne(S => S.Department)
                        .WithMany(D => D.Students)
                        .HasForeignKey(S => S.DepartmentId);

            modelBuilder.Entity<Course>()
                        .HasOne(C => C.Topic)
                        .WithMany(T => T.Courses)
                        .HasForeignKey(C => C.TopicId);

            modelBuilder.Entity<Department>()
                        .HasOne(D => D.Manage)
                        .WithOne(I => I.Manager)
                        .HasForeignKey<Department>(D => D.InstructorId)
                        .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Instructor>()
                        .HasOne(I => I.Department)
                        .WithMany(D => D.Instructors)
                        .HasForeignKey(I => I.DepartmentId);


            modelBuilder.ApplyConfiguration(new Stud_CourseConfigurations());
            modelBuilder.ApplyConfiguration(new Course_InstConfigurations());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = EF02; Trusted_Connection = True; TrustServerCertificate = True");
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Course_Inst> Course_Insts { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get; set; }
    }
}
