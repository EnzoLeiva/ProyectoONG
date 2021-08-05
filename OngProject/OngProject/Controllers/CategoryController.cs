using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OngProject.Core.DTOs;
using OngProject.Core.Interfaces;

namespace OngProject.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _iCategoryService;
        public CategoryController(ICategoryService iCategoryService)
        {
            _iCategoryService = iCategoryService;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (_iCategoryService.EntityExists(id))
            {


                bool response = await _iCategoryService.Delete(id);

                if (response == true)
                {
                    return Ok();
                }
                else
                {
                    return new StatusCodeResult(StatusCodes.Status500InternalServerError);
                }

            }
            else
                return NotFound();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            if (!_iCategoryService.EntityExists(id))
                return NotFound();

            var category = await _iCategoryService.GetById(id);
            return Ok(category);
        }

        [HttpGet]
        public async Task<IEnumerable<CategoryDto>> GetAll()
        {
            return await _iCategoryService.GetAll();
        }
    }
}
