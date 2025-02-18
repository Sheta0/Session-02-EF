using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_02.Entities
{
    class Employee
    {
        public int Id { get; set; } 
        public string Name { get; set; } 
        public int? Age { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
        public DateTime DateOfCreation { get; set; }

        [InverseProperty(nameof(Department.Manager))]
        public Department Department { get; set; }

        public int? WorkForId { get; set; } // FK

        [InverseProperty(nameof(Department.Employees))]
        public Department? WorkFor { get; set; }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}, Salary: {Salary}, Address: {Address}, DateOfCreation: {DateOfCreation}";
        }

        
    }
}
