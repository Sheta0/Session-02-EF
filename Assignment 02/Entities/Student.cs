using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02.Entities
{
    class Student
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string? LName { get; set; }
        public string Address { get; set; }
        public int? Age { get; set; }
        public int DepartmentId { get; set; }

        // Navigation properties
        public Department Department { get; set; }
        public List<Stud_Course> Courses { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, FName: {FName}, LName: {LName}, Address: {Address}, Age: {Age}, DepartmentId: {DepartmentId}";
        }
    }
}
