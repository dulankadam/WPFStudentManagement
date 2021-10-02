using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentManagement.Domain.Models.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Infastructure.Presistence.Configurations.Students
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Students", "stu");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.FirstName).IsRequired();
            builder.Property(a => a.Id).UseIdentityColumn();
        }
    }
}
