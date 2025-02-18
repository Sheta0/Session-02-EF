using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02.Entities
{
    class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigation properties
        public List<Course> Courses { get; set; }
    }
}
