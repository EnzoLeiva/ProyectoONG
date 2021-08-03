using OngProject.Core.DTOs;
using OngProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.Core.Mapper
{
    public class EntityMapper
    {
        public CommentDto FromCommentToCommentDto(CommentModel comment)
        {
            var commentDto = new CommentDto() { Body = comment.Body };
            return commentDto;
        }
    }
}
