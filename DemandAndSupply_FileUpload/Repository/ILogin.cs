using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemandAndSupply_FileUpload.Models;

namespace DemandAndSupply_FileUpload.Repository
{
    public interface ILogin
    {
        Task<LoginRegistration> AddLoginDetailsAsync(LoginRegistration loginTable);
        Task<LoginRegistration> AuthenticateUserAsync(string email, string password,string department);
    }
}