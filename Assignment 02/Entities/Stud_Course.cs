using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02.Entities
{
    class Stud_Course
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public int Grade { get; set; }

        // Navigation properties
        //public Student Student { get; set; }
        //public Course Course { get; set; }

    }
}
