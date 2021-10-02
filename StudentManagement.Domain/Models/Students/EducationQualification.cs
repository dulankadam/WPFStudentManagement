using StudentManagement.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Domain.Models.Students
{
    public class EducationQualification : ModelBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime QualifiedDate { get; set; }

        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
    }
}
