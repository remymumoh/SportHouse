using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApp.Models
{
    public class UserModel: IdentityUser
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}