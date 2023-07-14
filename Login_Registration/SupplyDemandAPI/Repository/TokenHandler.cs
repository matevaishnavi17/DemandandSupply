using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SupplyDemandAPI.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SupplyDemandAPI.Repository
{
    public class TokenHandler : IToken
    {
         private readonly IConfiguration configuration;

        public TokenHandler(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        #region CreateTokenAsync
        public Task<string> CreateTokenAsync(Login loginTable)
        {
            try
            {
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));

                //Creating claims
                var claims = new List<Claim>();

                claims.Add(new Claim(ClaimTypes.GivenName, loginTable.Email));

                claims.Add(new Claim(ClaimTypes.Role, loginTable.Role));

                var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(configuration["Jwt:Issuer"], configuration["Jwt:Audience"],
                    claims, expires: DateTime.Now.AddMinutes(15), signingCredentials: credentials);

                return Task.FromResult(new JwtSecurityTokenHandler().WriteToken(token));
            }

            catch (Exception)
            {
                throw;
            }
        }
        #endregion
        
    }
}