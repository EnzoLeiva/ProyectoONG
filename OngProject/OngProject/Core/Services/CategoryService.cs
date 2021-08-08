using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OngProject.Core.DTOs;
using OngProject.Core.Interfaces;
using OngProject.Core.Interfaces.IUnitOfWork;
using OngProject.Core.Mapper;
using OngProject.Core.Models;
using OngProject.Infrastructure;

namespace OngProject.Core.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<CategoryDto>> GetAll()
        {
            var mapper = new EntityMapper();
            var categories = await _unitOfWork.CategoryRepository.GetAll();
            var categoriesDto = categories.Select(c => mapper.FromCategoryToCategoryDto(c)).ToList();
            return categoriesDto;
        }
        public Task<CategoryModel> GetById(int Id)
        {
            return _unitOfWork.CategoryRepository.GetById(Id);
        }
        public async Task<CategoryModel> Post([FromForm] CategoryCreateDto categoryCreateDto)
        {
            var mapper = new EntityMapper();
            var category = mapper.FromCategoryCreateDtoToCategory(categoryCreateDto);

            await _unitOfWork.CategoryRepository.Insert(category);
            await _unitOfWork.SaveChangesAsync();

            return category;
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
        public async Task<CategoryModel> Put([FromForm] CategoryCreateDto updateCategoryDto, int id)
        {
            var mapper = new EntityMapper();
            var category = mapper.FromCategoryCreateDtoToCategory(updateCategoryDto);

            category.Id = id;

            await _unitOfWork.CategoryRepository.Update(category);
            await _unitOfWork.SaveChangesAsync();

            return category;
        }

        public bool EntityExists(int id)
        {
            return _unitOfWork.CategoryRepository.EntityExists(id);
        }
    }
}
