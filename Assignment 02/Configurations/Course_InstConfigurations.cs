using Assignment_02.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02.Configurations
{
    class Course_InstConfigurations : IEntityTypeConfiguration<Course_Inst>
    {
        public void Configure(EntityTypeBuilder<Course_Inst> ci)
        {
            ci.HasKey(ci => new { ci.InstructorId, ci.CourseId });
            ci.Property(ci => ci.evaluate).IsRequired();
        }

    }
}
