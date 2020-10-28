using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Entity.Access
{
    public class AppUser: IdentityUser<int>
    {
        public float CostPerHour { get; set; }
        public string JobTitle { get; set; }
        public DateTime? LastLogged { get; set; }
    }
}
