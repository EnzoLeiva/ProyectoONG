using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OngProject.Core.Interfaces.IServices;
using OngProject.Core.Interfaces;
using OngProject.Infrastructure.Data;
using OngProject.Core.DTOs;
using Microsoft.AspNetCore.Authorization;

namespace OngProject.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("/news")]
    [ApiController]
    public class NewsController : ControllerBase
    {

        private readonly INewsService _inewsService;
        
        public NewsController(INewsService inewsService)

        {
            _inewsService = inewsService;

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            if (!_inewsService.NewsExists(id))
                return NotFound();

            var response = await _inewsService.GetById(id);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromForm] NewsDto newsCreateDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            try
            {
                var response = await _inewsService.Post(newsCreateDto);

                return CreatedAtAction("POST", response);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }

        }
    }
}
