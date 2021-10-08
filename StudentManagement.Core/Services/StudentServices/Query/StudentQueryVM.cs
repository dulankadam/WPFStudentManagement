using StudentManagement.Domain.Models.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Core.Services.StudentServices.Query
{
    public class StudentQueryVM
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public int Gender { get; set; }
        public string ProfileImage { get; set; }
        public string MobileNumber { get; set; }
        public int StudentCategory { get; set; }        
        public bool Active { get; set; }     
    }
}
