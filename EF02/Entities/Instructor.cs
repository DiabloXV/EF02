using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Entities
{
    internal class Instructor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public decimal Bonus { get; set; }
        public string Address { get; set; }
        public decimal HourRate { get; set; }

        // Many-to-One relationship with Department
        public int Dept_ID { get; set; }
        public Depratment Department { get; set; }
    }
}
