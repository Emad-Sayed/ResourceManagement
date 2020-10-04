using Core.Domain.Entity.Access;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Repository.User
{
    public interface IUserRepository : IRepository<AppUser>
    {
        //(IEnumerable<UserViewModel>, int) UsersFilter(BaseSearch search);
    }
}
