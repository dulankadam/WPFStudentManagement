using StudentManagement.Core.Services;
using StudentManagement.Domain.Models.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.WPF.Services
{
    public class LoginService
    {
        private readonly ILoginService loginService;
        public LoginService()
        {
                
        }

        public Task<Login> ValidateLogin(string UserName, string Password)
        {
            var result = loginService.ValidateLoginCredentials(UserName, Password);

            if(result != null)
            {
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
