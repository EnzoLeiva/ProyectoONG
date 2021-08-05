using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OngProject.Core.DTOs;
using OngProject.Core.Models;

namespace OngProject.Core.Interfaces
{
    public interface ICategoryService
    {
        public Task<IEnumerable<CategoryDto>> GetAll();
        public Task<CategoryModel> GetById(int Id);
        public Task<CategoryModel> Post([FromForm] CategoryCreateDto categoryCreateDto);
        public Task<bool> Delete(int Id);
        public Task Update(CategoryModel categoryModel);
        public bool EntityExists(int id);
    }
}
