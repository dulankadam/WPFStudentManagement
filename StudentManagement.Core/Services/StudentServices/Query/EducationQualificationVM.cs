using StudentManagement.Domain.Models.Base;
using StudentManagement.Domain.Models.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Core.Services.StudentServices.Query
{
    public class EducationQualificationVM : ModelBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime QualifiedDate { get; set; }

        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
    }
}
