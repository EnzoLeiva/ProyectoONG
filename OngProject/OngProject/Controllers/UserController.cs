using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OngProject.Core.DTOs;
using OngProject.Core.DTOs.Auth;
using OngProject.Core.Interfaces.IServices;
using OngProject.Core.Interfaces.IUnitOfWork;
using OngProject.Core.Models;
using OngProject.Core.Services;
using OngProject.Core.Services.Auth;
using OngProject.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.Controllers
{
    
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IAuthService _auth;
        public UserController(IUserService userService, IAuthService auth)
        {
            this._userService = userService;
            this._auth = auth;
        }

        [HttpPost("/auth/register")]
        public async Task<ActionResult<UserDto>> Register([FromBody] RegisterDTO request)
        {
            try
            {
                var user = await this._auth.register(request);

                if (user != null)
                {
                    return Ok(user);
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
           

            return new StatusCodeResult(StatusCodes.Status500InternalServerError);
        }

        [HttpPost("/auth/login")]
        public async Task<ActionResult<UserDto>> Login([FromBody] LoginDTO request)
        {
             var user = await this._auth.login(request);

            if(user == null)
            {
                return NotFound();
            }

             return Ok(user);
            
        }

        [HttpDelete("/users/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (!_userService.UserExists(id))
                return NotFound();

            bool response = await _userService.DeleteUser(id);

            if (response == true)
            {
                return Ok();
            }
            else
            {
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }

        
        [HttpGet("/users")]
        public async Task<IEnumerable<UserModel>> GetUsers()
        {
            return await _userService.GetUsers();
        }
    }
}
