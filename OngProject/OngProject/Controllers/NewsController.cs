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
using OngProject.Core.Models;
using OngProject.Core.Helper.Pagination;

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

        [Authorize(Roles = "Admin")]
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
                return BadRequest(e.Message);
            }

        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (_inewsService.NewsExists(id))
            {
                bool result = await _inewsService.Delete(id);
                if (result)
                    return Ok();
                else
                    return BadRequest(StatusCodes.Status500InternalServerError);
            }
            else
                return NotFound();
        }


        [HttpGet]
        public async Task<ResponsePagination<GenericPagination<NewsModel>>> GetAll(int page = 1, int sizeByPage = 10)
        {

            IEnumerable<NewsModel> data = await _inewsService.GetAll();
            GenericPagination<NewsModel> objGenericPagination = GenericPagination<NewsModel>.Create(data, page, sizeByPage);
            ResponsePagination<GenericPagination<NewsModel>> response = new ResponsePagination<GenericPagination<NewsModel>>(objGenericPagination);
            response.CurrentPage = objGenericPagination.CurrentPage;
            response.HasNextPage = objGenericPagination.HasNextPage;
            response.HasPreviousPage = objGenericPagination.HasPreviousPage;
            response.PageSize = objGenericPagination.PageSize;
            response.TotalPages = objGenericPagination.TotalPages;
            response.TotalRecords = objGenericPagination.TotalRecords;
            response.Data = objGenericPagination;
        
            return response;
        }
    }
}
