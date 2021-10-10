using StudentManagement.Core.Services.StudentServices.Command;
using StudentManagement.Core.Services.StudentServices.Query;
using StudentManagement.Domain.Models.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Core.Services.StudentServices
{
    public class StudentService : IStudentService
    {
        public readonly CreateStudentBatchCommand _createStudent;
        public readonly GetStudentQuery getStudent;
        public readonly UpdateStudentBatchCommand updateStudent;

        public StudentService(CreateStudentBatchCommand createStudent)
        {
            _createStudent = createStudent;
        }

        public async Task<bool> CreateStudent(Student student)
        {
            try
            {
                if (student == null)
                {
                    return false;
                }

                bool result = await _createStudent.Handle(student);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<Student>> GetStudent()
        {
            try
            {
                List<Student> students = new List<Student>();
                var TempStudents = await getStudent.GetAllStudent();

                foreach (var student  in TempStudents)
                {
                    students.Add(
                        new Student()
                        {
                            FirstName = student.FirstName,
                            LastName = student.LastName,
                            Address = student.Address,
                            Age = student.Age,
                            Gender = student.Gender,
                            ProfileImage = student.ProfileImage,
                            MobileNumber = student.MobileNumber,
                            StudentCategory = student.StudentCategory,
                            Active = student.Active

                        });
                }

                return students;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Student> GetStudentById(int studentId)
        {
            try
            {               
                var TempStudents = await getStudent.GetStudentById(studentId);

                return new Student()
                {
                    FirstName = TempStudents.FirstName,
                    LastName = TempStudents.LastName,
                    Address = TempStudents.Address,
                    Age = TempStudents.Age,
                    Gender = TempStudents.Gender,
                    ProfileImage = TempStudents.ProfileImage,
                    MobileNumber = TempStudents.MobileNumber,
                    StudentCategory = TempStudents.StudentCategory,
                    Active = TempStudents.Active

                };

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> UpdateStudent(Student student)
        {
            try
            {
                if (student == null)
                {
                    return false;
                }

                return await updateStudent.Update(student);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
