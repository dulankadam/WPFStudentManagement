using StudentManagement.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Domain.Models.Courses
{
    public class Course : ModelBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }
        public bool Active { get; set; }
    }
}
