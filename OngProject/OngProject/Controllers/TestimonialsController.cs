using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OngProject.Core.DTOs;
using OngProject.Core.Helper.Pagination;
using OngProject.Core.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("/testimonials")]
    [ApiController]
    public class TestimonialsController : Controller
    {
        private readonly ITestimonialsService _testimonialsService;

        public TestimonialsController(ITestimonialsService testimonialsService)
        {
            _testimonialsService = testimonialsService;
        }

        
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (_testimonialsService.EntityExist(id) == true)
            {
                bool response = await _testimonialsService.Delete(id);
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
            {
                return NotFound();
            }
        }
        [Authorize (Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> Post([FromForm] CreateTestimonialsDto testimonialsCreateDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            try
            {
                var response = await _testimonialsService.Post(testimonialsCreateDto);

                return CreatedAtAction("POST", response);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }

        }

        [HttpPut("{id}")]

        public async Task<IActionResult> Put([FromForm] CreateTestimonialsDto updateTestimonialsDto, int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            try
            {
                var testimonialsExists = await _testimonialsService.GetById(id);

                if (testimonialsExists == null)
                {
                    return NotFound("testimonial inexistent");
                }
                else
                {
                    var res = await _testimonialsService.Put(updateTestimonialsDto, id);

                    return Ok(res);

                }
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpGet]
        public async Task<ResponsePagination<GenericPagination<CreateTestimonialsDto>>> GetAll(int page = 1, int sizeByPage = 10)
        {
            return await _testimonialsService.GetAll(page, sizeByPage);
        }

    }
}
