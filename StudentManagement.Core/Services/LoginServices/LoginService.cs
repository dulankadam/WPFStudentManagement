using StudentManagement.Core.Common.Interfaces;
using StudentManagement.Core.Services.LoginServices.Query;
using StudentManagement.Domain.Models.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Core.Services.LoginServices
{
    public class LoginService : ILoginService
    {
        GetLoginQuery getLoginQuery;
        private readonly IApplicationDbContext _context;

        public LoginService(IApplicationDbContext context)
        {
            _context = context;
            getLoginQuery = new GetLoginQuery(_context);
        }

        public async Task<Login> ValidateLoginCredentials(string username, string Password)
        {
            var loginUSer = await getLoginQuery.LoginValidation(username, Password);

            if(loginUSer != null)
            {
                return loginUSer;
            }
            else
            {
                return null;
            }
        }
    }
}
