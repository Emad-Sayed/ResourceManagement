using Core.Domain.ViewModel;
using Core.Domain.ViewModel.Access;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Infrastructure.Service.Users
{
    public interface IUserService
    {
        Task<IResponse> AddUserWithRole(RegisterationModel user, string Role , string pathRoot);
        Task<IResponse> Update(UserUpdateModel user, int id);
        Task<IResponse> UpdateResource(AdminUpdateUser user, string pathRoot);
        IResponse GetUsers(UserSeachModel search);
        Task<IResponse> ChangePassword(UserChangePasswordModel changePassword, int loggedInUser);
        Task<IResponse> DeleteUserImage(int userId, string rootPath);
    }
}
