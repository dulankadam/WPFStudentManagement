using Microsoft.EntityFrameworkCore;
using StudentManagement.Domain.Enums;
using StudentManagement.Domain.Models.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Infastructure.Presistence.Extensions.Seeds
{
    public static class StudentSeed
    {
        public static void SeedStudents(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
               new Student { Id = 1, FirstName = "Amal", LastName = "Silva", Address = "Colombo", Age = 22, Gender = (int)GenderEnum.Male, ProfileImage = "img01.jpg", MobileNumber = "+94123456789", StudentCategory = (int)StudentCategoryEnum.FullTime},
               new Student { Id = 1, FirstName = "Sunil", LastName = "Amarasinghe", Address = "Galle", Age = 29, Gender = (int)GenderEnum.Female, ProfileImage = "img02.jpg", MobileNumber = "+9413901311", StudentCategory = (int)StudentCategoryEnum.FullTime},
               new Student { Id = 1, FirstName = "Prasanna", LastName = "Ashoka", Address = "Matara", Age = 32, Gender = (int)GenderEnum.Male, ProfileImage = "img03.jpg", MobileNumber = "+942238987", StudentCategory = (int)StudentCategoryEnum.PartTime},
               new Student { Id = 1, FirstName = "Awishka", LastName = "Perera", Address = "Kandy", Age = 24, Gender = (int)GenderEnum.Female, ProfileImage = "img04.jpg", MobileNumber = "+9414242289", StudentCategory = (int)StudentCategoryEnum.FullTime},
               new Student { Id = 1, FirstName = "Harry", LastName = " Stringer", Address = "Colombo", Age = 21, Gender = (int)GenderEnum.Male, ProfileImage = "img05.jpg", MobileNumber = "+9419988998", StudentCategory = (int)StudentCategoryEnum.PartTime},
               new Student { Id = 1, FirstName = "Daniel", LastName = "Wringler", Address = "United Kingdom", Age = 27, Gender = (int)GenderEnum.Male, ProfileImage = "img06.jpg", MobileNumber = "+94222356789", StudentCategory = (int)StudentCategoryEnum.PartTime},
               new Student { Id = 1, FirstName = "David", LastName = "Harrop", Address = "Italy", Age = 28, Gender = (int)GenderEnum.Male, ProfileImage = "img07.jpg", MobileNumber = "+9412234789", StudentCategory = (int)StudentCategoryEnum.FullTime},
               new Student { Id = 1, FirstName = "Dilan", LastName = "Wicrama", Address = "Colombo", Age = 28, Gender = (int)GenderEnum.Male, ProfileImage = "img08.jpg", MobileNumber = "+9412309739", StudentCategory = (int)StudentCategoryEnum.PartTime}
            ) ;
        }
    }
}
