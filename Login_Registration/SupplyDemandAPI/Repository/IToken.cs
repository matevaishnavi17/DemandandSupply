using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SupplyDemandAPI.Models;

namespace SupplyDemandAPI.Repository
{
    public interface IToken
    {
        Task<string> CreateTokenAsync(Login loginTable);
        
    }
}