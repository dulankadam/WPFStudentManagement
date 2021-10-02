using StudentManagement.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.Domain.Models.Students;

namespace StudentManagement.Domain.Models.Courses
{
    public class CourceSelection : ModelBase
    {
        public int CourceId { get; set; }
        public virtual Course Course { get; set; }

        public int StudentId { get; set; }
        public virtual Student Student { get; set; }

        public int ValidYear { get; set; }
        public bool Active { get; set; }
    }
}
