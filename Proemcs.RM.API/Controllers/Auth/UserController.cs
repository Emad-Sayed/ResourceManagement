using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Domain.ViewModel.Access;
using Core.Infrastructure.Service.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proemcs.RM.API.Helper;

namespace Proemcs.RM.API.Controllers.Auth
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService service;
        public UserController(IUserService service_)
        {
            service = service_;
        }
        [HttpPost("CreateSuperAdmin")]
        public async Task<ActionResult> CreateSuperAdmin(RegisterationModel SuperAdmin)
        {
            var response = await service.AddUserWithRole(SuperAdmin, "SUPERADMIN");
            if (response.status == true)
                return Ok(response);
            return BadRequest(response);
        }
        [HttpPost("CreateAdmin")]
        public async Task<ActionResult> CreateAdmin(RegisterationModel Admin)
        {
            var response = await service.AddUserWithRole(Admin, "ADMIN");
            if (response.status == true)
                return Ok(response);
            return BadRequest(response);
        }
        [HttpPost("CreateResource")]
        public async Task<ActionResult> CreateResource(RegisterationModel Resource)
        {
            var response = await service.AddUserWithRole(Resource, "RESOURCE");
            if (response.status == true)
                return Ok(response);
            return BadRequest(response);
        }
        [HttpPut]
        public async Task<ActionResult> Update(UserUpdateModel user)
        {
            var response = await service.Update(user, User.GetUserId());
            if (response.status == true)
                return Ok(response);
            return NotFound(response);
        }
        [HttpPut("UpdateResource")]
        public async Task<ActionResult> UpdateResource(AdminUpdateUser user)
        {
            var response = await service.UpdateResource(user);
            if (response.status == true)
                return Ok(response);
            return NotFound(response);
        }
        [HttpGet("UserFilter")]
        public ActionResult UserFilter([FromQuery]UserSeachModel search)
        {
            var response = service.GetUsers(search);
            return Ok(response);
        }
        [HttpPut("ChangePassword")]
        public async Task<ActionResult> ChangePassword(UserChangePasswordModel changePassword)
        {
            var response = await service.ChangePassword(changePassword,User.GetUserId());
            if (response.status)
                return Ok(response);
            return BadRequest(response);
        }
    }
}
