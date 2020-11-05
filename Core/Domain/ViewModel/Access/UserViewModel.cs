using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.ViewModel.Access
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string JobTitle { get; set; }
        public float CostPerHour { get; set; }
        public string Role { get; set; }
        public string Photo { get; set; }
        public DateTime LastLogged { get; set; }
    }
}
