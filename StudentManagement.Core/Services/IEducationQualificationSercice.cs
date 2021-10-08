using StudentManagement.Domain.Models.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Core.Services
{
    public interface IEducationQualificationSercice
    {
        Task<bool> CreateEducationQualification(EducationQualification educationQualification);
        Task<List<EducationQualification>> GetEducationQualification();
        Task<EducationQualification> GetEducationQualificationById(int Id);
        Task<bool> UpdateEducationQualification(EducationQualification educationQualification);
    }
}
