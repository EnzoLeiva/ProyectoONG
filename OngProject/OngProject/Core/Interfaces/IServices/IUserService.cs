using OngProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.Core.Interfaces.IServices
{
    public interface IUserService
    {
        public Task<IEnumerable<UserModel>> GetUsers();
        public Task<UserModel> GetUserById(int id);
        public Task<bool> InsertUser(UserModel user);
        public Task<bool> UpdateUser(UserModel user);
        public Task<bool> DeleteUser(int id);
    }
}
