using StudentManagement.Domain.Models.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.WPF.ViewModels
{
    internal class StudentViewModel
    {
        public IEnumerable<Student> students { get; set; }

    }
}
