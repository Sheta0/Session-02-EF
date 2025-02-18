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
    class Stud_CourseConfigurations : IEntityTypeConfiguration<Stud_Course>
    {
        public void Configure(EntityTypeBuilder<Stud_Course> sc)
        {
            sc.HasKey(sc => new { sc.StudentId, sc.CourseId });
            sc.Property(sc => sc.Grade).IsRequired();
        }
    }
}
