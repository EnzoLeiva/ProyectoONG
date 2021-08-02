
using OngProject.Core.Interfaces.IServices;
using OngProject.Core.Interfaces.IUnitOfWork;
using OngProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.Core.Services
{
    public class UserService: IUserService
    {

        private readonly IUnitOfWork _unitOfWork;
        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task DeleteUser(int Id)
        {
            return _unitOfWork.UserRepository.Delete(Id);
        }

        public bool UserExists(int Id)
        {
            return _unitOfWork.UserRepository.EntityExists(Id);
        }
    }
}
