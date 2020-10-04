using Core.Domain.Entity.Access;
using Core.Domain.Repository.User;
using Core.Domain.ViewModel;
using Core.Domain.ViewModel.Access;
using Domain.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Domain.Repository.User
{
    public class UserRepository : Repository<AppUser>, IUserRepository
    {
        public UserRepository(AppDbContext _Context) : base(_Context)
        {
        }

        public (IEnumerable<UserViewModel>, int) UsersFilter(UserSeachModel search)
        {
            var query = from user in Context.Users
                        join userRole in Context.UserRoles
                        on user.Id equals userRole.UserId
                        join role in Context.Roles
                        on userRole.RoleId equals role.Id
                        where((String.IsNullOrEmpty(search.keyWord) || user.UserName.Contains(search.keyWord)) &&
                            (search.UserIds.Count == 0 || search.UserIds.Contains(user.Id)) &&
                            (search.Roles.Count == 0 || search.Roles.Contains(role.Name)))
                        select new UserViewModel
                        {
                            Id = user.Id,
                            UserName = user.UserName,
                            Email = user.Email,
                            CostPerHour = user.CostPerHour,
                            Role = role.Name,
                        };
            var count = query.Count();
            var data = query.OrderBy(c => c.Id).Skip((search.pageNumber - 1) * search.pageSize).Take(search.pageSize);
            return (data, count);

        }
    }
}