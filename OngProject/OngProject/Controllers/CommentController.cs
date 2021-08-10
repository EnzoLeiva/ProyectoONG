using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OngProject.Core.DTOs;
using OngProject.Core.Interfaces.IServices;
using OngProject.Core.Interfaces.IUnitOfWork;
using OngProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OngProject.Controllers
{
    [Route("/comments")]
    [ApiController]
    public class CommentController : ControllerBase
    {

        private readonly ICommentService _iCommentService;
        private readonly IUnitOfWork _iUnitOfWork;

        public CommentController(ICommentService iCommentService, IUnitOfWork iUnitOfWork)
        {
            _iCommentService = iCommentService;
            _iUnitOfWork = iUnitOfWork;
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IEnumerable<CommentDto>> GetAllComment()
        {
            return await _iCommentService.GetAllComments();
        }

        [HttpGet("/posts/{id_post}/comments")]
        public async Task<IEnumerable<CommentDto>> GetCommentsByPost(int id_post)
        {
           return await _iCommentService.GetCommentsByPost(id_post);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (_iCommentService.EntityExists(id))
            {
                if (!await _iCommentService.ValidateCreatorOrAdminAsync(User, id))
                {
                    return Forbid();
                }

                bool response = await _iCommentService.Delete(id);

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

    }
}
