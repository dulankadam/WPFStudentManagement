using StudentManagement.Core.Services.CourseServices.Command;
using StudentManagement.Core.Services.CourseServices.Query;
using StudentManagement.Domain.Models.Courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Core.Services.CourseServices
{
    public class CourseService : ICourseService
    {
        public readonly CreateCourseBatchCommand createCourse;
        public readonly GetCourseQuery getCourse;
        public readonly UpdateCourseBatchCommand updateCourse;

        public async Task<bool> CreateCourse(Course course)
        {
            try
            {
                if (course == null)
                {
                    return false;
                }

                bool result = await createCourse.Handle(course);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<Course>> GetCourse()
        {
            try
            {
                List<Course> courses = new List<Course>();
                var TempCourses = await getCourse.GetAllCourses();

                foreach (var SelectedCourse in TempCourses)
                {
                    courses.Add(
                        new Course()
                        {
                            Name = SelectedCourse.Name,
                            Description = SelectedCourse.Description,
                            Type = SelectedCourse.Type,
                            Active = SelectedCourse.Active

                        }) ;
                }

                return courses;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Course> GetStudentById(int courseId)
        {
            try
            {
                var TempCourse = await getCourse.GetCourseById(courseId);

                return new Course()
                {

                    Name = TempCourse.Name,
                    Description = TempCourse.Description,
                    Type = TempCourse.Type,
                    Active = TempCourse.Active

                };

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> UpdateStudent(Course course)
        {
            try
            {
                if (course == null)
                {
                    return false;
                }

                return await updateCourse.Update(course);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
