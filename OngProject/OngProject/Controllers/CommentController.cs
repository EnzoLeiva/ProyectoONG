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
    [Route("[controller]")]
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
        [HttpGet("/comments")]
        public async Task<IEnumerable<CommentModel>> GetAllComment()
        {
            return await _iUnitOfWork.CommentRepository.GetAll();
        }

    }
}
