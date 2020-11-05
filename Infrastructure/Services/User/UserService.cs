using Core.Domain.Entity.Access;
using Core.Domain.UOW;
using Core.Domain.ViewModel;
using Core.Domain.ViewModel.Access;
using Core.Infrastructure.Helper;
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
        public readonly IFileHelper file;
        public UserService(IUOW uow_, IResponse response_, UserManager<AppUser> userManager_, IFileHelper file_)
        {
            userManager = userManager_;
            UOW = uow_;
            response = response_;
            file = file_;
        }


        public async Task<IResponse> AddUserWithRole(RegisterationModel user, string Role, string rootPath)
        {
            AppUser newAppUser = new AppUser
            {
                UserName = user.UserName,
                Email = user.Email,
                EmailConfirmed = true,
                CostPerHour = user.CostPerHour,
                JobTitle = user.JobTitle
            };
            var result = await userManager.CreateAsync(newAppUser, user.Password);
            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(newAppUser, Role);
                if (!String.IsNullOrEmpty(user.Base64))
                {
                    newAppUser.Photo = file.SaveImage(user.Base64, newAppUser.Id + "", "Images/Users", rootPath);
                    await userManager.UpdateAsync(newAppUser);
                }
            }
            else
            {
                response.error_EN = result.Errors.Select(e => e.Description).FirstOrDefault();
                response.status = false;
            }
            return response;
        }

        public async Task<IResponse> Update(UserUpdateModel user, int LoggedId)
        {
            var selectedUser = await userManager.FindByIdAsync(LoggedId + "");
            if (selectedUser != null)
            {
                selectedUser.UserName = user.UserName;
                selectedUser.Email = user.Email;
                selectedUser.EmailConfirmed = true;
                selectedUser.JobTitle = user.JobTitle;
                await userManager.UpdateAsync(selectedUser);
            }
            else
            {
                response.status = false;
                response.error_EN = "user doesn't exist";
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

        public async Task<IResponse> ChangePassword(UserChangePasswordModel changePassword, int loggedInUser)
        {
            var result = await userManager.FindByIdAsync(loggedInUser + "");
            if (result != null)
            {
                var isChanged = await userManager.ChangePasswordAsync(result, changePassword.OldPassword, changePassword.NewPassword);
                if (!isChanged.Succeeded)
                {
                    response.status = false;
                    response.error_EN = "Old Password Incorrect";
                }
            }
            else
            {
                response.error_EN = "User Doesn't Exist";
                response.status = false;
            }
            return response;
        }

        public async Task<IResponse> UpdateResource(AdminUpdateUser user, string rootPath)
        {
            var selectedUser = await userManager.FindByIdAsync(user.Id + "");
            if (selectedUser != null)
            {
                selectedUser.UserName = user.UserName;
                selectedUser.Email = user.Email;
                selectedUser.EmailConfirmed = true;
                selectedUser.JobTitle = user.JobTitle;
                selectedUser.CostPerHour = user.CostPerHour;
                if (!String.IsNullOrEmpty(user.Password))
                {
                    await userManager.RemovePasswordAsync(selectedUser);
                    await userManager.AddPasswordAsync(selectedUser, user.Password);
                }
                if (!String.IsNullOrEmpty(user.Base64))
                {
                    selectedUser.Photo = file.SaveImage(user.Base64, selectedUser.Id + "", "Images/Users", rootPath);
                }
                var result = await userManager.UpdateAsync(selectedUser);
                //if (String.IsNullOrEmpty(user.Role))
                //{
                //    var PreviousRole = await userManager.GetRolesAsync(selectedUser);
                //    if (PreviousRole.Count != 0)
                //    {
                //        await userManager.RemoveFromRoleAsync(selectedUser, PreviousRole.FirstOrDefault());
                //    }
                //    await userManager.AddToRoleAsync(selectedUser, user.Role);
                //}
            }
            else
            {
                response.status = false;
                response.error_EN = "user doesn't exist";
            }
            return response;
        }
        public async Task<IResponse> DeleteUserImage(int userId, string rootPath)
        {
            var selectedUser = await userManager.FindByIdAsync(userId + "");
            if (selectedUser != null)
            {
                file.DeleteImage("wwwroot/Images/Users/" + userId+".jpg");
                selectedUser.Photo = null;
                await userManager.UpdateAsync(selectedUser);
            }
            return response;
        }
    }
}
