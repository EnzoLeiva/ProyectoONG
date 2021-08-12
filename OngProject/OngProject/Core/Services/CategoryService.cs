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
using OngProject.Core.Interfaces.IServices.AWS;
using OngProject.Core.Helper;

namespace OngProject.Core.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IImagenService _imagenService;

        public CategoryService(IUnitOfWork unitOfWork, IImagenService imagenService)
        {
            _unitOfWork = unitOfWork;
            _imagenService = imagenService;
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
        public async Task<CategoryModel> Post(CategoryCreateDto categoryCreateDto)
        {
            var mapper = new EntityMapper();
            var category = mapper.FromCategoryCreateDtoToCategory(categoryCreateDto);

            
            await _imagenService.Save(category.Image, categoryCreateDto.Image);
            await _unitOfWork.CategoryRepository.Insert(category);       
            await _unitOfWork.SaveChangesAsync();


            return category;
        }

       
        public async Task<bool> Delete(int Id)
        {
            try
            {
                CategoryModel category = await GetById(Id);
                bool result = await _imagenService.Delete(category.Image);
                if (!result) // if there is an error in AWS service to delete the image
                  return false;
               
                await _unitOfWork.CategoryRepository.Delete(Id);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public async Task<CategoryModel> Put(CategoryCreateDto updateCategoryDto, int id)
        {
            var mapper = new EntityMapper();
            var category = mapper.FromCategoryCreateDtoToCategory(updateCategoryDto);

            category.Id = id;

            await _imagenService.Save(category.Image, updateCategoryDto.Image);
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
