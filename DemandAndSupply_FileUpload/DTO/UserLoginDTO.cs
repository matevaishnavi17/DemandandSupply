using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DemandAndSupply_FileUpload.DTO
{
    public class UserLoginDTO
    {
        [Key]
        public string Email { get; set; }
        public string Password { get; set; }
    
        public string Role { get; set; }
    }
}