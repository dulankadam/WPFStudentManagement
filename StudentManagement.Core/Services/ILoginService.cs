using StudentManagement.Domain.Models.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Core.Services
{
    public interface ILoginService
    {
        Task<Login> ValidateLoginCredentials(string username, string Password);
    }
}
