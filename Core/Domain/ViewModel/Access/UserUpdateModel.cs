using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.ViewModel.Access
{
    public class UserUpdateModel
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string JobTitle { get; set; }
    }
}
