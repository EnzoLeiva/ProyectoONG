using OngProject.Core.DTOs;
using OngProject.Core.Interfaces.IServices;
using OngProject.Core.Interfaces.IUnitOfWork;
using OngProject.Core.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OngProject.Core.Services
{
    public class CommentService : ICommentService
    {
        private readonly IUnitOfWork _unitOfWOrk;

        public CommentService(IUnitOfWork unitOfWOrk)
        {
            this._unitOfWOrk = unitOfWOrk;
        }
        
        public async Task<IEnumerable<CommentDto>> GetAllComments()
        {
            var mapper = new EntityMapper();
            var commentList = await _unitOfWOrk.CommentRepository.GetAll();
            var commentDtoList = commentList.OrderByDescending(c => c.CreatedAt).Select(c => mapper.FromCommentToCommentDto(c)).ToList();

            return commentDtoList;
        }
    }
}
