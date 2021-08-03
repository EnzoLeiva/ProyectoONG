using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OngProject.Core.Models;

namespace OngProject.Core.Interfaces
{
    public interface ICategoryService
    {
        public Task<IEnumerable<CategoryModel>> GetAll();
        public Task<CategoryModel> GetById(int Id);
        public Task Insert(CategoryModel categoryModel);
        public Task<bool> Delete(int Id);
        public Task Update(CategoryModel categoryModel);
        public bool EntityExists(int id);
    }
}
