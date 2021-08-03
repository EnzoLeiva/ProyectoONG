using Microsoft.AspNetCore.Mvc;
using OngProject.Core.DTOs;
using OngProject.Core.Interfaces.IServices;
using OngProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OngProject.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {

        private readonly ICommentService _iCommentService;
        public CommentController(ICommentService iCommentService)
        {
            _iCommentService = iCommentService;
        }
        [HttpGet("/comments")]
        public Task<IEnumerable<CommentDto>> GetAllComment()
        {
            IQueryable<CommentDto> query = (IQueryable<CommentDto>)_iCommentService.GetAllComments();
            var commentsByDesc = query.OrderByDescending(c => c.CreatedAt);

            return (Task<IEnumerable<CommentDto>>)commentsByDesc;
        }

    }
}
