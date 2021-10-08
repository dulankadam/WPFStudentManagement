using StudentManagement.Domain.Models.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Core.Services.StudentServices
{
    public class EducationQualificationService : IEducationQualificationSercice
    {
        public Task<bool> CreateEducationQualification(EducationQualification educationQualification)
        {
            throw new NotImplementedException();
        }

        public Task<List<EducationQualification>> GetEducationQualification()
        {
            throw new NotImplementedException();
        }

        public Task<EducationQualification> GetEducationQualificationById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateEducationQualification(EducationQualification educationQualification)
        {
            throw new NotImplementedException();
        }
    }
}
