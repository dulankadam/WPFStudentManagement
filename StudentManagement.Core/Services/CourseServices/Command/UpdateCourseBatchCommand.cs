using Microsoft.EntityFrameworkCore;
using StudentManagement.Core.Common.Interfaces;
using StudentManagement.Domain.Models.Courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Core.Services.CourseServices.Command
{
    public class UpdateCourseBatchCommand
    {
        private readonly IApplicationDbContext _context;

        public UpdateCourseBatchCommand(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Update(Course course)
        {
            try
            {
                var searchCourse = await _context.Courses.FirstOrDefaultAsync(s => s.Id == course.Id);

                if (searchCourse != null)
                {
                    searchCourse.Name = course.Name;
                    searchCourse.Description = course.Description;
                    searchCourse.Type = course.Type;
                    searchCourse.Active = course.Active;
                }

                _context.Courses.Add(searchCourse);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
