using OngProject.Core.DTOs;
using OngProject.Core.Interfaces.IServices;
using OngProject.Core.Interfaces.IUnitOfWork;
using OngProject.Core.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace OngProject.Core.Services
{
    public class CommentService : ICommentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CommentService(IUnitOfWork unitOfWOrk)
        {
            this._unitOfWork = unitOfWOrk;
        }
        
        public async Task<IEnumerable<CommentDto>> GetAllComments()
        {
            var mapper = new EntityMapper();
            var commentList = await _unitOfWork.CommentRepository.GetAll();
            var commentDtoList = commentList.OrderByDescending(c => c.CreatedAt).Select(c => mapper.FromCommentToCommentDto(c)).ToList();

            return commentDtoList;
        }

        public async Task<IEnumerable<CommentDto>> GetCommentsByPost(int idPost)
        {
            var mapper = new EntityMapper();
           
                var commentList = await _unitOfWork.CommentRepository.GetAll();
                var commentDtoList = commentList.Where(x => x.post_id == idPost).OrderByDescending(c => c.CreatedAt).Select(c => mapper.FromCommentToCommentDto(c)).ToList();
           
            
            return commentDtoList;
        }
        public async Task<bool> Delete(int Id)
        {
            try
            {
                await _unitOfWork.CommentRepository.Delete(Id);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool EntityExists(int id)
        {
            return _unitOfWork.CategoryRepository.EntityExists(id);
        }
        public async Task<bool> ValidateCreatorOrAdminAsync(ClaimsPrincipal user, int id)
        {
            var userid = user.Claims.Where(x => x.Type == "Id").FirstOrDefault()?.Value;
            var comment = await _unitOfWork.CommentRepository.GetById(id);
            if (comment == null)
            {
                return false;
            }
            if (comment.Id.Equals(userid) || user.IsInRole("Admin"))
            {
                return true;
            }
            return false;
        }
    }
}
