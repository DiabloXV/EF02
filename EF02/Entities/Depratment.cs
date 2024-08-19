using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Entities
{
    internal class Depratment
    {
        //public int ID { get; set; }
        //public string Name { get; set; }
        //public string HiringDate { get; set; }

        //// One-to-Many relationship with Instructor
        //public ICollection<Instructor> Instructors { get; set; }

        #region Data Annotation
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public string HiringDate { get; set; }

        public ICollection<Instructor> Instructors { get; set; }

        public ICollection<Student> Students { get; set; }
        #endregion
    }
}
