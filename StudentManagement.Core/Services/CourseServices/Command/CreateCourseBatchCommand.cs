using Microsoft.Extensions.Logging;
using StudentManagement.Core.Common.Interfaces;
using StudentManagement.Domain.Models.Courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StudentManagement.Core.Services.CourseServices.Command
{
    public class CreateCourseBatchCommand
    {
        private readonly IApplicationDbContext _context;

        public CreateCourseBatchCommand(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(Course course, CancellationToken cancellationToken)
        {
            await _context.Courses.AddRangeAsync(course);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
