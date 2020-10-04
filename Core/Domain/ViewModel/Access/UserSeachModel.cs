using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.ViewModel.Access
{
    public class UserSeachModel:BaseSearch
    {
        public List<int> UserIds { get; set; } = new List<int>();
        public List<string> Roles { get; set; } = new List<string>();
    }
}
