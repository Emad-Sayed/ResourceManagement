using Core.Domain.Entity.Access;
using Core.Domain.Repository.User;
using Domain.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Repository.User
{
    public class UserRepository : Repository<AppUser>, IUserRepository
    {
        public UserRepository(AppDbContext _Context) : base(_Context)
        {
        }

        //public (IEnumerable<UserViewModel>, int) UsersFilter(BaseSearch search)
        //{
        //    var query = from user in Context.Users
        //                where (user.isDeleted == false
        //                && (String.IsNullOrEmpty(search.keyWord) || user.UserName.Contains(search.keyWord)))
        //                join userRole in Context.UserRoles
        //                on user.Id equals userRole.UserId
        //                join role in Context.Roles
        //                on userRole.RoleId equals role.Id
        //                select new UserViewModel
        //                {
        //                    Id = user.Id,
        //                    UserName = user.UserName,
        //                    Email = user.Email,
        //                    Type = role.Name,
        //                };
        //    var count = query.Count();
        //    var data = query.OrderBy(c => c.Id).Skip((search.pageNumber - 1) * search.pageSize).Take(search.pageSize);
        //    return (data, count);

        //}
    }
}