using Microsoft.EntityFrameworkCore;
using StudentManagement.Domain.Models.Courses;
using StudentManagement.Domain.Models.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StudentManagement.Core.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
        DbSet<TModel> Set<TModel>() where TModel : class;

        public DbSet<Course> Courses { get; set; }
        public DbSet<CourceSelection> CourceSelections { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<EducationQualification> EducationQualifications { get; set; }
    }
}
