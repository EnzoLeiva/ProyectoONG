
using OngProject.Core.Interfaces.IServices;
using OngProject.Core.Interfaces.IUnitOfWork;
using OngProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OngProject.Core.DTOs;
using OngProject.Core.Mapper;


namespace OngProject.Core.Services
{
    public class UserService: IUserService
    {

        private readonly IUnitOfWork _unitOfWork;
        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> DeleteUser(int Id)
        {

            try
            {
                await _unitOfWork.UserRepository.Delete(Id);
                await _unitOfWork.SaveChangesAsync();
                
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public bool UserExists(int Id)
        {
            return _unitOfWork.UserRepository.EntityExists(Id);
        }

        public async Task<IEnumerable<UserModel>> GetUsers()
        {
            return await _unitOfWork.UserRepository.GetAll();
        }

        public async Task<UserInfoDto> GetUserById(int Id)
        {
            UserModel user = await _unitOfWork.UserRepository.GetById(Id);
            EntityMapper mapper = new EntityMapper();
            UserInfoDto userInfoDto = mapper.FromUserModelToUserInfoDto(user);

            return userInfoDto;
        }
    }
}
