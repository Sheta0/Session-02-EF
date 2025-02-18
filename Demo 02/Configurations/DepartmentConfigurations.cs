using Demo_02.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_02.Configurations
{
    class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> D)
        {
            D.HasKey(D => D.Id);
            D.Property(D => D.Id).UseIdentityColumn(100, 100);
            D.Property(D => D.Name)
                   .IsRequired()
                   .HasMaxLength(50)
                   .HasColumnType("varchar")
                   .HasColumnName("DepartmentName");
            D.Property(D => D.DateOfCreation).HasDefaultValueSql("GETDATE()");
        }

    }
}
