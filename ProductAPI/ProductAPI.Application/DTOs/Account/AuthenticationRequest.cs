using System;
using System.Collections.Generic;
using System.Text;

namespace ProductAPI.Application.DTOs.Account
{
    public class AuthenticationRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
