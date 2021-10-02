using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentManagement.Domain.Models.Courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Infastructure.Presistence.Configurations.Cources
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Courses", "crs");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Type).IsRequired();
            builder.Property(a => a.Id).UseIdentityColumn();
        }
    }
}
