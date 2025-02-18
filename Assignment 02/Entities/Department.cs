using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02.Entities
{
    class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? InstructorId { get; set; }
        public DateTime HiringDate { get; set; }

        // Navigation properties
        public Instructor? Manage { get; set; }
        public List<Student> Students { get; set; }
        public List<Instructor> Instructors { get; set; }
    }
}
