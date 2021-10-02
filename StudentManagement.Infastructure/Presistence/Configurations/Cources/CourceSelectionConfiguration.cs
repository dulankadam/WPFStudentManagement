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
    public class CourceSelectionCOnfiguration : IEntityTypeConfiguration<CourceSelection>
    {
        public void Configure(EntityTypeBuilder<CourceSelection> builder)
        {
            builder.ToTable("CourceSelections", "crs");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.StudentId).IsRequired();
            builder.Property(a => a.CourceId).IsRequired();
            builder.Property(a => a.ValidYear).IsRequired();
            builder.Property(a => a.Id).UseIdentityColumn();
        }
    }
}
