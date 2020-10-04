using Core.Domain.Entity.Access;
using Core.Domain.UOW;
using Core.Domain.ViewModel;
using Core.Domain.ViewModel.Access;
using Core.Infrastructure.Service.Users;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.User
{
    public class UserService : IUserService
    {
        private UserManager<AppUser> userManager;
        public readonly IUOW UOW;
        public readonly IResponse response;
        public UserService(IUOW uow_, IResponse response_, UserManager<AppUser> userManager_)
        {
            userManager = userManager_;
            UOW = uow_;
            response = response_;
        }


        public async Task<IResponse> AddUserWithRole(RegisterationModel user, string Role)
        {
            AppUser newAppUser = new AppUser
            {
                UserName = user.UserName,
                Email = user.Email,
                EmailConfirmed = true,
                CostPerHour = user.CostPerHour,
            };
            var result = await userManager.CreateAsync(newAppUser, user.Password);
            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(newAppUser, Role);
            }
            else
            {
                response.error_EN = result.Errors.Select(e => e.Description).FirstOrDefault();
                response.status = false;
            }
            return response;
        }

        public IResponse GetUsers(UserSeachModel search)
        {
            var (result, totalRows) = UOW.Users.UsersFilter(search);
            response.pagesTotalRows = totalRows;
            float all_pages = (float)totalRows / search.pageSize;
            response.pagesTotalNumber = (int)Math.Ceiling(all_pages);
            response.pageSize = search.pageSize;
            response.pageNumber = search.pageNumber;
            response.data = result;
            return response;
        }
    }
}
