using Microsoft.EntityFrameworkCore;
using StudentManagement.Core.Common.Interfaces;
using StudentManagement.Domain.Models.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Core.Services.StudentServices.Command
{
    public class UpdateStudentBatchCommand
    {
        private readonly IApplicationDbContext _context;

        public UpdateStudentBatchCommand(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Update(Student student)
        {
            try
            {

                var searchStudent = await _context.Students.FirstOrDefaultAsync(s => s.Id == student.Id);

                if (searchStudent != null)
                {
                    searchStudent.FirstName = student.FirstName;
                    searchStudent.LastName = student.LastName;
                    searchStudent.Address = student.Address;
                    searchStudent.Age = student.Age;
                    searchStudent.Gender = student.Gender;
                    searchStudent.ProfileImage = student.ProfileImage;
                    searchStudent.MobileNumber = student.MobileNumber;
                    searchStudent.StudentCategory = student.StudentCategory;
                }

                _context.Students.Add(searchStudent);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
