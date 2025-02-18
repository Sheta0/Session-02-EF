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
    class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> E)
        {
            E.HasKey(E => E.Id);

            E.Property(E => E.Id).UseIdentityColumn(10,10);

            E.Property(E => E.Name)
                   .IsRequired()
                   .HasMaxLength(50)
                   .HasColumnType("varchar")
                   .HasColumnName("EmployeeName");

            E.Property(E => E.Age).IsRequired(false);

            E.Property(E => E.Salary).HasColumnType("money");

            E.Property(E => E.DateOfCreation).HasDefaultValueSql("GETDATE()");
        }
    }
}
