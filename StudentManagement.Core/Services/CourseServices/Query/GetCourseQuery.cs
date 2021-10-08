using Microsoft.EntityFrameworkCore;
using StudentManagement.Core.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Core.Services.CourseServices.Query
{
    public class GetCourseQuery
    {
        private readonly IApplicationDbContext _context;

        public GetCourseQuery(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<CourseQueryVM>> GetAllCourses()
        {
            try
            {
                List<CourseQueryVM> queryVM = new List<CourseQueryVM>();

                var SelectedCourses = await _context.Courses.ToListAsync();

                foreach (var TempCourses in SelectedCourses)
                {
                    queryVM.Add(
                        new CourseQueryVM()
                        {
                            Name = TempCourses.Name,
                            Description = TempCourses.Description,
                            Type = TempCourses.Type,
                            Active = TempCourses.Active
                        });
                }

                return queryVM;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public async Task<CourseQueryVM> GetCourseById(int Id)
        {
            try
            {
                CourseQueryVM queryVM = new CourseQueryVM();

                var SelectedCourse = await _context.Courses.FirstOrDefaultAsync(s => s.Id == Id);

                return new CourseQueryVM()
                {
                    Name = SelectedCourse.Name,
                    Description = SelectedCourse.Description,
                    Type = SelectedCourse.Type,
                    Active = SelectedCourse.Active

                };

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
