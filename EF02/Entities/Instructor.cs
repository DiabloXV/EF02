using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Entities
{
    internal class Instructor
    {
        //public int ID { get; set; }
        //public string Name { get; set; }
        //public double Salary { get; set; }
        //public double Bonus { get; set; }
        //public string Address { get; set; }
        //public double HourRate { get; set; }

        //// Many-to-One relationship with Department
        //public int Dept_ID { get; set; }
        //public Depratment Department { get; set; }

        #region Data Annotation
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public double Salary { get; set; }   

        public double Bonus { get; set; }    

        public string Address { get; set; }

        public double HourRate { get; set; } 

        [ForeignKey("Department")]
        public int Dept_ID { get; set; }
        public Depratment Department { get; set; }
        #endregion
    }
}
