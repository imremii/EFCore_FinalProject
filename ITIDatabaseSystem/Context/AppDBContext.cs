using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ITIDatabaseSystem.Models;
using ITIDatabaseSystem.Repository;

namespace ITIDatabaseSystem.Context
{
    public class AppDBContext : DbContext
    {
        public AppDBContext() : base()
        {
        }
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=.\\SQLEXPRESS;DataBase=ITI_DBSystem;Trusted_Connection=true;TrustServerCertificate=true";
            optionsBuilder
                .UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourse>().HasKey(sc => new { sc.StdID, sc.CrsID });

            modelBuilder.Entity<Department>()
                .HasMany(d => d.Instructors)
                .WithOne(i => i.Department)
                .HasForeignKey(i => i.Dept_ID);

            modelBuilder.Entity<Department>()
                .HasOne(d => d.InsManager)
                .WithOne(i => i.ManagedBy)
                .HasForeignKey<Department>(d => d.ManagerID);

            modelBuilder.Entity<Instructor>()
                .Property(i => i.Salary)
                .HasColumnType("decimal(8,2)");


            modelBuilder.Entity<Student>().HasData(ProjectRepository.getStudents());
            modelBuilder.Entity<Instructor>().HasData(ProjectRepository.getInstructors());
            modelBuilder.Entity<Department>().HasData(ProjectRepository.getDepartments());
            modelBuilder.Entity<Course>().HasData(ProjectRepository.getCourses());
            modelBuilder.Entity<StudentCourse>().HasData(ProjectRepository.getStudentCourses());
            modelBuilder.Entity<CourseSession>().HasData(ProjectRepository.getCourseSessions());
            modelBuilder.Entity<CourseSessionAttendance>().HasData(ProjectRepository.getCourseSessionAttendances());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<CourseSession> CourseSessions { get; set; }
        public DbSet<CourseSessionAttendance> CourseSessionAttendances { get; set; }
        
    }
}
