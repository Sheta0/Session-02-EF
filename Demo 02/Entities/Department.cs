using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_02.Entities
{
    class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfCreation { get; set; }

        [ForeignKey(nameof(Manager))]
        public int? EmpId { get; set; } // FK
        public Employee Manager { get; set; } // Navigation Property

        public List<Employee> Employees { get; set; }
    }
}
