using EF02.Contexts;

namespace EF02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //By convention
            ITIDbContext context = new ITIDbContext();
        }
    }
}
