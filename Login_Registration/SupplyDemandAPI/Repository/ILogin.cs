using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SupplyDemandAPI.Models;

namespace SupplyDemandAPI.Repository
{
    public interface ILogin
    {
        Task<Login> AddLoginDetailsAsync(Login loginTable);
        Task<Login> AuthenticateUserAsync(string email, string password,string department);
    }
}