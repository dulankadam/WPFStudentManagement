using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.Core.Common.Interfaces;
using System.Threading;
using StudentManagement.Domain.Models.Base;
using System.Reflection;
using StudentManagement.Infastructure.Presistence.Extensions.Seeds;
using StudentManagement.Domain.Models.Courses;
using StudentManagement.Domain.Models.Students;
using Microsoft.Extensions.Configuration;

namespace StudentManagement.Infastructure.Presistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        private readonly IConfiguration _configuration;

        public ApplicationDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                   _configuration.GetConnectionString("Default")
               );
            base.OnConfiguring(optionsBuilder);
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            string user = "SystemUser";

            foreach (var entry in ChangeTracker.Entries<ModelBase>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.Now;
                        entry.Entity.CreatedUser = user;
                        break;
                    case EntityState.Modified:
                        entry.Entity.UpdatedDate = DateTime.Now;
                        entry.Entity.UpdatedUser = user;
                        break;
                }
            }

            return await base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.SeedCourses();
        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<CourceSelection> CourceSelections { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<EducationQualification> EducationQualifications { get; set; }

    }
}
