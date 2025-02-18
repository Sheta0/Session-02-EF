using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02.Entities
{
    class Course
    {
        [Key]
        public int CrsId { get; set; }

        public int Duration { get; set; }

        [Required]
        public string Name { get; set; }

        [StringLength(100, MinimumLength = 10)]
        public string Description { get; set; }

        public int TopicId { get; set; }

        public Topic Topic { get; set; }
        public List<Stud_Course> Students { get; set; }
        public  List<Course_Inst> Instructors { get; set; }
    }
}
