using EF02.Contexts;
using EF02.Entities;
namespace EF02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //By convention
            //ITIDbContext context = new ITIDbContext();

            //CRUD
            using ( var context = new SchoolContext())
            {
                // Create
                var department = new Depratment { Name = "Computer Science", HiringDate = "2024-08-19" };
                context.Departments.Add(department);
                context.SaveChanges();

                // Read
                var students = context.Students.ToList();

                // Update
                var student = context.Students.First();
                student.FName = "UpdatedName";
                context.SaveChanges();

                // Delete
                var instructor = context.Instructors.First();
                context.Instructors.Remove(instructor);
                context.SaveChanges();
            }
        }
    }
}
