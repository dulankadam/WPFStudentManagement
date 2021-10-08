using StudentManagement.Core.Common.Interfaces;
using StudentManagement.Domain.Models.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StudentManagement.Core.Services.StudentServices.Command
{
    public class CreateStudentBatchCommand
    {
        private readonly IApplicationDbContext _context;

        public CreateStudentBatchCommand(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(Student student, CancellationToken cancellationToken)
        {
            await _context.Students.AddRangeAsync(student);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
