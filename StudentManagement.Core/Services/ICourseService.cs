using StudentManagement.Domain.Models.Courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Core.Services
{
    public interface ICourseService
    {
        Task<bool> CreateCourse(Course course);
        Task<List<Course>> GetCourse();
        Task<Course> GetStudentById(int course);
        Task<bool> UpdateStudent(Course course);
    }
}
