using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OngProject.Core.DTOs;
using OngProject.Core.Interfaces.IServices;
using OngProject.Core.Mapper;
using OngProject.Core.Models;
using OngProject.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("/slides")]
    [ApiController]
    public class SlideController : ControllerBase
    {
        private readonly ISlideService _slideService;

        public SlideController(ISlideService slideService)
        {
            _slideService = slideService;
        }
       
        [HttpGet]
        public async Task<IEnumerable<SlideDto>> GetSlides()
        {
            return await _slideService.GetAll();             
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDetailsSlides(int id)
        {
            if (_slideService.EntityExists(id))
            {
                var listDetails = await _slideService.GetById(id);
                return Ok(listDetails);
            }
            else
            {
                return NotFound();
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> Post([FromForm] SlideDto slideCreateDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            try
            {
                var response = await _slideService.Post(slideCreateDto);

                return CreatedAtAction("POST", response);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }

        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (_slideService.EntityExists(id))
            {
                bool result = await _slideService.Delete(id);
                if(result)
                    return Ok();
                else
                    return BadRequest(StatusCodes.Status500InternalServerError);
            }
            else
                return NotFound();
        }
    }

}