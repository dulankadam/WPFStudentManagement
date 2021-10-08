using Microsoft.EntityFrameworkCore;
using StudentManagement.Core.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Core.Services.StudentServices.Query
{
    public class GetStudentQuery
    {
        private readonly IApplicationDbContext _context;

        public GetStudentQuery(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<StudentQueryVM>> GetAllStudent()
        {
            try
            {
                List<StudentQueryVM> queryVM = new List<StudentQueryVM>();

                var SelectedStudents = await _context.Students.ToListAsync();

                foreach (var TempStudents in SelectedStudents)
                {
                    queryVM.Add(
                        new StudentQueryVM()
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


                        });
                }

                return queryVM;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public async Task<StudentQueryVM> GetStudentById(int Id)
        {
            try
            {
                StudentQueryVM  queryVM = new  StudentQueryVM ();

                var SelectedStudents = await _context.Students.FirstOrDefaultAsync(s => s.Id == Id);

                return new StudentQueryVM()
                {
                    FirstName = SelectedStudents.FirstName,
                    LastName = SelectedStudents.LastName,
                    Address = SelectedStudents.Address,
                    Age = SelectedStudents.Age,
                    Gender = SelectedStudents.Gender,
                    ProfileImage = SelectedStudents.ProfileImage,
                    MobileNumber = SelectedStudents.MobileNumber,
                    StudentCategory = SelectedStudents.StudentCategory,
                    Active = SelectedStudents.Active


                };               
               
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
