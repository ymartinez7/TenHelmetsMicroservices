using TenHelmets.MS.Core.DTOs;
using TenHelmets.MS.Core.Entities;
using TenHelmets.MS.Core.Enums;
using TenHelmets.MS.Infrastructure.Identity;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Mime;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace TenHelmets.MS.UI.CentralManagement.WebApi.Controllers
{
    [Route("[controller]")]
    [Produces(MediaTypeNames.Application.Json)]
    public sealed class AccountsController : BaseController
    {
        private readonly UserManager<User> _userManager;

        private readonly SignInManager<User> _signInManager;

        public AccountsController(IConfiguration configuration,
            IMapper mapper,
            IHostingEnvironment environment,
            UserManager<User> userManager,
            SignInManager<User> signInManager)
            : base(configuration,
                  mapper,
                  environment)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
        }

        [HttpPost]
        [Route("Create")]
        [AllowAnonymous]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<ResponseDTO>> CreateUser(UserInfo model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(new ResponseDTO(false,
                        this.GetMessage((int)Message.InvalidModel),
                        ModelState));
                }

                var user = new User { UserName = model.Email, Email = model.Email};
                var result = await this._userManager.CreateAsync(user, model.Password);

                if (!result.Succeeded)
                {
                    return BadRequest(new ResponseDTO(false,
                        this.GetMessage((int)Message.UserOrPasswordInvalid),
                        null));
                }

                return BuildToken(model);
            }
            catch (Exception ex)
            {
                this.HandleException("AccountController.CreateUser()",
                    "Message: " + ex.Message + " Trace: " + ex.StackTrace,
                    DateTime.Now.ToString());

                return BadRequest(new ResponseDTO(false,
                    ex.Message,
                    null));
            }
        }

        [HttpPost]
        [Route("Login")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [AllowAnonymous]
        public async Task<ActionResult<ResponseDTO>> Login(UserInfo model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(new ResponseDTO(false,
                        this.GetMessage((int)Message.InvalidModel),
                        ModelState));
                }

                var result = await this._signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);

                if (!result.Succeeded)
                {
                    ModelState.AddModelError(string.Empty, "Invalid logoin attempt.");
                    return BadRequest(new ResponseDTO(false,
                        this.GetMessage((int)Message.UserOrPasswordInvalid),
                        ModelState));
                }

                return BuildToken(model);
            }
            catch (Exception ex)
            {
                this.HandleException("AccountController.Login()",
                    "Message: " + ex.Message + " Trace: " + ex.StackTrace,
                    DateTime.Now.ToString());

                return BadRequest(new ResponseDTO(false,
                    ex.Message,
                    null));
            }
        }

        private ActionResult BuildToken(UserInfo model)
        {
            var claims = new[] 
            {
                new Claim(JwtRegisteredClaimNames.UniqueName, model.Email),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this._configuration["Secret_Key"]));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expiration = DateTime.UtcNow.AddHours(5);

            JwtSecurityToken token = new JwtSecurityToken(issuer: "yourdomain.com",
                audience: "yourdomain.com",
                claims: claims,
                expires: expiration,
                signingCredentials: credentials);

            //return Ok(new
            //{
            //    new JwtSecurityTokenHandler().WriteToken(token),
            //    //Token = new JwtSecurityTokenHandler().WriteToken(token),
            //    //Expiration = expiration
            //});


            return Ok(new JwtSecurityTokenHandler().WriteToken(token));
        }
    }
}