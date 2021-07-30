using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OngProject.Core.Interfaces;
using OngProject.Core.Interfaces.IUnitOfWork;
using OngProject.Core.Models;

namespace OngProject.Core.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Task<IEnumerable<CategoryModel>> GetAll()
        {
            return _unitOfWork.CategoryRepository.GetAll();
        }
        public Task<CategoryModel> GetById(int Id)
        {
            return _unitOfWork.CategoryRepository.GetById(Id);
        }
        public Task Insert(CategoryModel categoryModel)
        {
            return _unitOfWork.CategoryRepository.Insert(categoryModel);
        }
        public Task Delete(int Id)
        {
            return _unitOfWork.CategoryRepository.Delete(Id);
        }
        public Task Update(CategoryModel categoryModel)
        {
            return _unitOfWork.CategoryRepository.Update(categoryModel);
        }

        public bool EntityExists(int id)
        {
            return _unitOfWork.CategoryRepository.EntityExists(id);
        }
    }
}
