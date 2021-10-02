using StudentManagement.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Domain.Models.Students
{
    public class Student : ModelBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public int Gender { get; set; }
        public string ProfileImage { get; set; }
        public int MobileNumber { get; set; }
        public int StudentCategory { get; set; }        
        public bool Active { get; set; }
    }
}
