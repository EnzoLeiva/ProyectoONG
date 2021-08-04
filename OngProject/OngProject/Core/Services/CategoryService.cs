using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OngProject.Core.DTOs;
using OngProject.Core.Interfaces;
using OngProject.Core.Interfaces.IUnitOfWork;
using OngProject.Core.Mapper;
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
        public async Task<CategoryDto> CreateCategory (CategoryModel category)
        {
            var mapper = new EntityMapper();
            await _unitOfWork.CategoryRepository.Insert(category);
            var categoryDto = mapper.FromCategoryToCategoryDto(category);
            return categoryDto;
        }



        public async Task<bool> Delete(int Id)
        {
            try
            {
               await _unitOfWork.CategoryRepository.Delete(Id);
               await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
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
