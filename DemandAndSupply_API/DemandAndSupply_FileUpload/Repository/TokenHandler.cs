using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemandAndSupply_FileUpload.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace DemandAndSupply_FileUpload.Repository
{
    public class TokenHandler : IToken
    {
       private readonly IConfiguration configuration;

        public TokenHandler(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        #region CreateTokenAsync
        public Task<string> CreateTokenAsync(LoginRegistration loginTable)
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