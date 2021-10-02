using Microsoft.EntityFrameworkCore;
using StudentManagement.Domain.Enums;
using StudentManagement.Domain.Models.Courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Infastructure.Presistence.Extensions.Seeds
{
    public static class CourcesSeed
    {
        public static void SeedCourses(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasData(
                new Course { Id = 1, Name = "Applied Maths", Description ="Applied Maths for Genenral Degree",Type = (int)CourseTypeEnum.Degree, Active = true},
                new Course { Id = 2, Name = "Food Science", Description ="Food Science for Genenral Degree",Type = (int)CourseTypeEnum.Degree, Active = true},
                new Course { Id = 3, Name = "Anatomy", Description ="Anatomy for Medicine",Type = (int)CourseTypeEnum.Degree, Active = true},
                new Course { Id = 4, Name = "Electromics", Description ="Electromics for Computer Science",Type = (int)CourseTypeEnum.Degree, Active = true},
                new Course { Id = 5, Name = "Data Structure's And Algorithms", Description = "Data Structure's And Algorithms for Medicine", Type = (int)CourseTypeEnum.Degree, Active = true},
                new Course { Id = 6, Name = "Network Sceurity", Description = "Network Sceurity for Medicine", Type = (int)CourseTypeEnum.Degree, Active = true}
            );
        }
    }
}
