using OngProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using OngProject.Core.Interfaces.IUnitOfWork;
using Microsoft.Extensions.Configuration;
using OngProject.Core.Mapper;
using OngProject.Core.DTOs;
using OngProject.Core.DTOs.Auth;

namespace OngProject.Core.Services.Auth
{
    public class AuthService: IAuthService
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IConfiguration _configuration;
        public AuthService(IUnitOfWork unitOfWork, IConfiguration configuration)
        {
            this._unitOfWork = unitOfWork;
            this._configuration = configuration;
           
        }

        public async Task<UserDto> register(RegisterDTO register)
        {
            var userExists = await _unitOfWork.UserRepository.GetByEmail(register.email);

            if (userExists != null)
            {
                throw new Exception("User already exists!");
            }
            else {
                try
                {
                    register.password = UserModel.ComputeSha256Hash(register.password);

                    var mapper = new EntityMapper();
                    var user = mapper.FromRegisterDtoToUser(register);
                    user.RoleModel = await _unitOfWork.RoleRepository.GetById(2);

                    await _unitOfWork.UserRepository.Insert(user);
                    await _unitOfWork.SaveChangesAsync();

                    if (user != null)
                    {
                        var token = GetToken(user);
                        var map = new EntityMapper();
                        return map.FromUserToUserDto(user, token);
                    }

                    return null;
                }
                catch (Exception e)
                {
                    return null;
                }
            }
             
           
        }

        public async Task<UserDto> login(LoginDTO login)
        {
            var user = await _unitOfWork.UserRepository.GetByEmail(login.email);  

            if(user != null && (user.password == UserModel.ComputeSha256Hash(login.password)))
            {
                var token = GetToken(user);

                var mapper = new EntityMapper();
                return mapper.FromUserToUserDto(user, token);
            }

            return null;
        }
        public string GetToken(UserModel user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();

            var key = Encoding.ASCII.GetBytes(_configuration["JWT:Secret"]);

            var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Email, user.email),
                    new Claim(ClaimTypes.Role, user.RoleModel?.Name),

                };

            var authSigningKey = new SymmetricSecurityKey(key);

            var token = new JwtSecurityToken(
                expires: DateTime.Now.AddHours(1),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                );

            return tokenHandler.WriteToken(token);
        }

       
    }
}
