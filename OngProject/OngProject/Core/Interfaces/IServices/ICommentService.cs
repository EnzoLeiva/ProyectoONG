using OngProject.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace OngProject.Core.Interfaces.IServices
{
    public interface ICommentService
    {
        public Task<IEnumerable<CommentDto>> GetAllComments();
        public Task<IEnumerable<CommentDto>> GetCommentsByPost(int idPost);
        public Task<bool> ValidateCreatorOrAdminAsync(ClaimsPrincipal user, int id);
        public Task<bool> Delete(int Id);
        public bool EntityExists(int id);
    }
}
