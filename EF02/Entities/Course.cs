using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Entities
{
    internal class Course
    {
        //public int ID { get; set; }
        //public int Duration { get; set; }
        //public string Name { get; set; }
        //public string Description { get; set; }

        //// Many-to-One relationship with Topic
        //public int Top_ID { get; set; }
        //public Topic Topic { get; set; }

        #region Data Annotation
        [Key]
        public int ID { get; set; }

        [Required]
        public int Duration { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public string Description { get; set; }

        [ForeignKey("Topic")]
        public int Top_ID { get; set; }
        public Topic Topic { get; set; }
        #endregion
    }
}
