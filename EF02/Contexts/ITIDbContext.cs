using EF02.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Contexts
{
    internal class ITIDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = ASUSTUF ; Database = ITIC42 ;  Trusted_Connection = True ; Encrypt = False");
        }

        DbSet<Student> Students { get; set; }

        DbSet<Depratment> Departments { get; set; }

        DbSet <Instructor> Instructors { get; set; }

        DbSet<Course> Courses { get; set; }

        DbSet<Topic> Topics { get; set; }
    }
}
