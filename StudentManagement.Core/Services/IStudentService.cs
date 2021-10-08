using StudentManagement.Core.Services.StudentServices;
using StudentManagement.Domain.Models.Students;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentManagement.Core.Services
{
    public interface IStudentService
    {
        Task<bool> CreateStudent(Student student);
        Task<List<Student>> GetStudent();
        Task<Student> GetStudentById(int student);
        Task<bool> UpdateStudent(Student student);
    }
}
