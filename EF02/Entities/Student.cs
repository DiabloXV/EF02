using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Entities
{
    internal class Student
    {
        //public int ID { get; set; }
        //public string FName { get; set; }
        //public string LName { get; set; }
        //public string Address { get; set; }
        //public int Age { get; set; }

        //// Many-to-One relationship with Department
        //public int Dep_Id { get; set; }
        //public Depratment Department { get; set; }

        #region Data Annotation
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string FName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LName { get; set; }

        [Required]
        public string Address { get; set; }

        [Range(18, 100)]
        public int Age { get; set; }

        [ForeignKey("Department")]
        public int Dep_Id { get; set; }
        public Depratment Department { get; set; }
        #endregion
    }
}
