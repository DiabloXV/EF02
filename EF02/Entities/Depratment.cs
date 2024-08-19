using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Entities
{
    internal class Depratment
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string HiringDate { get; set; }

        // One-to-Many relationship with Instructor
        public ICollection<Instructor> Instructors { get; set; }
    }
}
