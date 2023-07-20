using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemandAndSupply_FileUpload.Models;
using Microsoft.EntityFrameworkCore;


namespace DemandAndSupply_FileUpload.Repository
{
    public class LoginRepo : ILogin
    {
        private DemandAndSupply_Db1Context _context;

        public LoginRepo(DemandAndSupply_Db1Context context)
        {
            _context = context;
        }

        #region AddLoginDetailsAsync
        public async Task<LoginRegistration> AddLoginDetailsAsync(LoginRegistration loginTable)
        {
            try
            {
                await _context.LoginRegistrations.AddAsync(loginTable);
                await _context.SaveChangesAsync();
                return loginTable;
            }
            catch(Exception)
            {
                throw;
            }
        }

        
       

        public async Task<LoginRegistration>AuthenticateUserAsync(string email, string password, string department)
        {
            try
            {
                var user = await _context.LoginRegistrations.FirstOrDefaultAsync(x => x.Email == email && x.Password == password && x.Role == department);
                return user;
            }
            catch(Exception)
            {
                throw;
            }
        }
    #endregion
    }
}