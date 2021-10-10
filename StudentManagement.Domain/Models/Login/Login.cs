using StudentManagement.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Domain.Models.Login
{
    public class Login : ModelBase
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Addresss { get; set; }
        public int Category { get; set; }
    }
}
