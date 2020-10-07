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
        Task<IResponse> AddUserWithRole(RegisterationModel user, string Role);
        Task<IResponse> Update(UserUpdateModel user);
        IResponse GetUsers(UserSeachModel search);
        Task<IResponse> ChangePassword(UserChangePasswordModel changePassword,int loggedInUser);

    }
}
