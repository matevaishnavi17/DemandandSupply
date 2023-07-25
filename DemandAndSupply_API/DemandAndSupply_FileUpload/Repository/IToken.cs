using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemandAndSupply_FileUpload.Models;

namespace DemandAndSupply_FileUpload.Repository
{
    public interface IToken
    {
         Task<string> CreateTokenAsync(LoginRegistration loginTable);
    }
}