using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Entity.Access;
using Core.Domain.ViewModel.Access;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Proemcs.RM.API.Controllers.Auth
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IConfiguration _config;
        private UserManager<AppUser> _userManager;
        public AuthController(IConfiguration config, UserManager<AppUser> usermanager)
        {
            _config = config;
            _userManager = usermanager;
        }
        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginModel user)
        {
            var selectedUser = await UserExists(user);
            if (selectedUser != null)
            {
                selectedUser.LastLogged = DateTime.Now;
                await _userManager.UpdateAsync(selectedUser);
                int timeExpiration = user.rememberMe ? 30 : 1;
                var (token, roles) = await GenerateToken(selectedUser, timeExpiration);
                return Ok(new
                {
                    token = token,
                    roles = roles,
                });
            }
            return Unauthorized();
        }
        private async Task<AppUser> UserExists(LoginModel user)
        {
            var selectedUser = await _userManager.FindByEmailAsync(user.username);
            var result = await _userManager.CheckPasswordAsync(selectedUser, user.password);
            if (result)
                return selectedUser;
            return null;
        }
        private async Task<(string, IList<string>)> GenerateToken(AppUser Authuser, int timeExpiration)
        {
            var rolesFormRepo = await _userManager.GetRolesAsync(Authuser);
            //Header==================
            var SecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JWT:secretkey"]));
            var credential = new SigningCredentials(SecurityKey, SecurityAlgorithms.HmacSha256);
            //Payload=================
            var Claims = new[]
            {
                new Claim("Id",Authuser.Id+""),
                new Claim("Name",Authuser.UserName+""),
                new Claim("JobTitle",Authuser.JobTitle+""),
                new Claim(JwtRegisteredClaimNames.Email,Authuser.Email),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
            };
            #region for Role Identity
            ClaimsIdentity claimsIdentity = new ClaimsIdentity(Claims, "Token");
            // Adding roles code
            // Roles property is string collection but you can modify Select code if it it's not
            claimsIdentity.AddClaims(rolesFormRepo.Select(role => new Claim(ClaimTypes.Role, role)));
            #endregion

            var Token = new JwtSecurityToken(
                issuer: "beldor@beldor.com",
                audience: "beldor@beldor.com",
                claimsIdentity.Claims,
                expires: DateTime.Now.AddDays(timeExpiration),
                signingCredentials: credential
                );

            var encodeToken = new JwtSecurityTokenHandler().WriteToken(Token);
            return (encodeToken, rolesFormRepo);
        }
    }
}
