using Microsoft.EntityFrameworkCore;
using StudentManagement.Core.Common.Interfaces;
using StudentManagement.Core.Services.CommonServices;
using StudentManagement.Domain.Models.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Core.Services.LoginServices.Query
{
    public class GetLoginQuery
    {
        private readonly IApplicationDbContext _context;

        public GetLoginQuery(IApplicationDbContext context)
        {
            _context = context;
        }

        public Task<Login> LoginValidation(string UserName, string Password)
        {
            try
            {
                var loginResult = _context.Logins.FirstOrDefaultAsync(l => l.UserName == UserName && l.Password == HashKeyGenerateService.CreateMD5(Password));

                if (loginResult != null)
                {
                    return loginResult;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        
    }
}
