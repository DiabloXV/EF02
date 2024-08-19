using EF02.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Configurations
{
    //public class StudentConfiguration : IEntityTypeConfiguration<Student>
    //{
    //    public void Configure(EntityTypeBuilder<Student> builder)
    //    {
    //        builder.HasKey(s => s.ID);

    //        builder.Property(s => s.FName)
    //            .IsRequired()
    //            .HasMaxLength(50);

    //        builder.Property(s => s.LName)
    //            .IsRequired()
    //            .HasMaxLength(50);

    //        builder.Property(s => s.Age)
    //            .IsRequired();

    //        builder.HasOne(s => s.Department)
    //            .WithMany(d => d.Students)
    //        .HasForeignKey(s => s.Dep_Id);
    //    }
    //}

    //public class DepartmentConfiguration : IEntityTypeConfiguration<Depratment>
    //{
    //    public void Configure(EntityTypeBuilder<Depratment> builder)
    //    {
    //        builder.HasKey(d => d.ID);

    //        builder.Property(d => d.Name)
    //            .IsRequired()
    //            .HasMaxLength(100);

    //        builder.Property(d => d.HiringDate)
    //            .IsRequired();

    //        builder.HasMany(d => d.Instructors)
    //            .WithOne(i => i.Department)
    //            .HasForeignKey(i => i.Dept_ID);
    //    }
    //}

    //public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    //{
    //    public void Configure(EntityTypeBuilder<Instructor> builder)
    //    {
    //        builder.HasKey(i => i.ID);

    //        builder.Property(i => i.Name)
    //            .IsRequired()
    //            .HasMaxLength(100);

    //        builder.Property(i => i.Salary)
    //            .HasColumnType("decimal(18,2)");

    //        builder.Property(i => i.Bonus)
    //            .HasColumnType("decimal(18,2)");

    //        builder.Property(i => i.HourRate)
    //            .HasColumnType("decimal(18,2)");

    //        builder.HasOne(i => i.Department)
    //            .WithMany(d => d.Instructors)
    //            .HasForeignKey(i => i.Dept_ID);
    //    }
    //}

    //public class CourseConfiguration : IEntityTypeConfiguration<Course>
    //{
    //    public void Configure(EntityTypeBuilder<Course> builder)
    //    {
    //        builder.HasKey(c => c.ID);

    //        builder.Property(c => c.Name)
    //            .IsRequired()
    //            .HasMaxLength(100);

    //        builder.Property(c => c.Duration)
    //            .IsRequired();

    //        builder.HasOne(c => c.Topic)
    //            .WithMany(t => t.Courses)
    //            .HasForeignKey(c => c.Top_ID);
    //    }
    //}

    //public class TopicConfiguration : IEntityTypeConfiguration<Topic>
    //{
    //    public void Configure(EntityTypeBuilder<Topic> builder)
    //    {
    //        builder.HasKey(t => t.ID);

    //        builder.Property(t => t.Name)
    //            .IsRequired()
    //            .HasMaxLength(100);
    //    }
    //}


    //public class SchoolContext : DbContext
    //{
    //    public DbSet<Student> Students { get; set; }
    //    public DbSet<Department> Departments { get; set; }
    //    public DbSet<Instructor> Instructors { get; set; }
    //    public DbSet<Course> Courses { get; set; }
    //    public DbSet<Topic> Topics { get; set; }

    //    protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    {
    //        modelBuilder.ApplyConfiguration(new StudentConfiguration());
    //        modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
    //        modelBuilder.ApplyConfiguration(new InstructorConfiguration());
    //        modelBuilder.ApplyConfiguration(new CourseConfiguration());
    //        modelBuilder.ApplyConfiguration(new TopicConfiguration());
    //    }
    //}
}