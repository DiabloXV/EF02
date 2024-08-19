using EF02.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Contexts
{
    internal class SchoolContext : ITIDbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Depratment> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure Student entity
            modelBuilder.Entity<Student>()
                .HasKey(s => s.ID);

            modelBuilder.Entity<Student>()
                .Property(s => s.FName)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<Student>()
                .Property(s => s.LName)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<Student>()
                .Property(s => s.Address)
                .IsRequired();

            modelBuilder.Entity<Student>()
                .Property(s => s.Age)
                .IsRequired();

            modelBuilder.Entity<Student>()
                .HasOne(s => s.Department)
                .WithMany(d => d.Students)  // Department has many Students
                .HasForeignKey(s => s.Dep_Id);

            // Configure Department entity
            modelBuilder.Entity<Depratment>()
                .HasKey(d => d.ID);

            modelBuilder.Entity<Depratment>()
                .Property(d => d.Name)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Depratment>()
                .Property(d => d.HiringDate)
                .IsRequired();

            modelBuilder.Entity<Depratment>()
                .HasMany(d => d.Instructors)
                .WithOne(i => i.Department)
                .HasForeignKey(i => i.Dept_ID);

            modelBuilder.Entity<Depratment>()
                .HasMany(d => d.Students)
                .WithOne(s => s.Department)
                .HasForeignKey(s => s.Dep_Id);

            // Configure Instructor entity
            modelBuilder.Entity<Instructor>()
                .HasKey(i => i.ID);

            modelBuilder.Entity<Instructor>()
                .Property(i => i.Name)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Instructor>()
                .Property(i => i.Salary)
                .HasColumnType("double");

            modelBuilder.Entity<Instructor>()
                .Property(i => i.Bonus)
                .HasColumnType("double");

            modelBuilder.Entity<Instructor>()
                .Property(i => i.HourRate)
                .HasColumnType("double");

            modelBuilder.Entity<Instructor>()
                .HasOne(i => i.Department)
                .WithMany(d => d.Instructors)
                .HasForeignKey(i => i.Dept_ID);

            // Configure Course entity
            modelBuilder.Entity<Course>()
                .HasKey(c => c.ID);

            modelBuilder.Entity<Course>()
                .Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Course>()
                .Property(c => c.Duration)
                .IsRequired();

            modelBuilder.Entity<Course>()
                .Property(c => c.Description)
                .IsRequired();

            modelBuilder.Entity<Course>()
                .HasOne(c => c.Topic)
                .WithMany(t => t.Courses)  // Topic has many Courses
                .HasForeignKey(c => c.Top_ID);

            // Configure Topic entity
            modelBuilder.Entity<Topic>()
                .HasKey(t => t.ID);

            modelBuilder.Entity<Topic>()
                .Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Topic>()
                .HasMany(t => t.Courses)
                .WithOne(c => c.Topic)
                .HasForeignKey(c => c.Top_ID);
        }
    }
}
