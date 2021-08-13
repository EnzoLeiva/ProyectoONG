using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OngProject.Core.DTOs;
using OngProject.Core.Interfaces;
using OngProject.Core.Mapper;
using OngProject.Core.Models;

namespace OngProject.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("/categories")]
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

        [HttpPost]

        public async Task<IActionResult> Post([FromForm] CategoryCreateDto categoryCreateDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            try
            {
                var response = await _iCategoryService.Post(categoryCreateDto);

                return CreatedAtAction("POST", response);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        [HttpPut("{id}")]

        public async Task<IActionResult> Put([FromForm] CategoryCreateDto updateCategoryDto, int id)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            try
            {
                var categoryExists = await _iCategoryService.GetById(id);

                if(categoryExists == null) 
                {
                    return NotFound("category inexistent");
                }
                else
                {
                    var res = await _iCategoryService.Put(updateCategoryDto, id);
                    
                    return Ok(res);

                }

                
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

    }
}
