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
    public class EducationQualificationsConfiguration : IEntityTypeConfiguration<EducationQualification>
    {
        public void Configure(EntityTypeBuilder<EducationQualification> builder)
        {
            builder.ToTable("EducationQualifications", "stu");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.StudentId).IsRequired();
            builder.Property(a => a.Id).UseIdentityColumn();
        }
    }
}
