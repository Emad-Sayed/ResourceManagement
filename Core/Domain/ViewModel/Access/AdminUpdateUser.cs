using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.ViewModel.Access
{
    public class AdminUpdateUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string JobTitle { get; set; }
        public float CostPerHour { get; set; }
        public string Password { get; set; }
        public string Base64 { get; set; }
    }
}
