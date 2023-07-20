using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SupplyDemandAPI.Data;
using SupplyDemandAPI.Models;
using System.Text;



namespace SupplyDemandAPI.Repository
{
    public class LoginRepository : ILogin
    {
        private SupplyDemandDbContext _context;

        public LoginRepository(SupplyDemandDbContext context)
        {
            _context = context;
        }

        #region AddLoginDetailsAsync
        public async Task<Login> AddLoginDetailsAsync(Login loginTable)
        {
            try
            {
                await _context.login.AddAsync(loginTable);
                await _context.SaveChangesAsync();
                return loginTable;
            }
            catch(Exception)
            {
                throw;
            }
        }
        #endregion

        #region AuthenticateUserAsync
        public async Task<Login> AuthenticateUserAsync(string email, string password,string department)
        {
            try
            {
                var user = await _context.login.FirstOrDefaultAsync(x => x.Email == email && x.Password == password && x.Role == department);
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