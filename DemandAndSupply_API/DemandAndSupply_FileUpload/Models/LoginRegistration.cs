﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DemandAndSupply_FileUpload.Models
{
    public partial class LoginRegistration
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
