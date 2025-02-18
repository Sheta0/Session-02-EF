using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02.Entities
{
    class Instructor
    {
        [Key]
        public int InstId { get; set; }

        [Column("EmpName", TypeName = "varchar")]
        [StringLength(50)]
        public string Name { get; set; }

        [Column(TypeName = "money")]
        [DataType(DataType.Currency)]
        public double Bonus { get; set; }

        [Column(TypeName = "money")]
        [DataType(DataType.Currency)]
        public double Salary { get; set; }
        public string Address { get; set; }

        [Column(TypeName = "money")]
        [DataType(DataType.Currency)]
        public decimal HourRate { get; set; }

        public int DepartmentId { get; set; }

        // Navigation properties
        public Department? Manager { get; set; }
        public Department Department { get; set; }
        public List<Course_Inst> Courses { get; set; }
    }
}
