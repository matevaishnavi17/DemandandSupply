using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SupplyDemandAPI.Models.DTO
{
    public class UserLogin
    {
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
    
        public string Role { get; set; }
    }
}