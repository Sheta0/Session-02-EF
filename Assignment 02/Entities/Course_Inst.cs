using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02.Entities
{
    class Course_Inst
    {
        public int InstructorId { get; set; }
        public int CourseId { get; set; }
        public int evaluate { get; set; }

        // Navigation properties
        //public Instructor Instructor { get; set; }
        //public Course Course { get; set; }
    }
}
