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
        public SlideDto FromSlideToSlideDto(SlideModel slide)
        {
            var slideDto = new SlideDto()
            {
                ImageUrl = slide.ImageUrl,
                Order = slide.Order
            };

            return slideDto;
        }
        public CommentDto FromCommentToCommentDto(CommentModel comment)
        {
            var commentDto = new CommentDto() { Body = comment.Body };

            return commentDto;
        }
    }

}

        public OrganizationDto FromOrganizationToOrganizationDto(OrganizationModel organization)
        {
            var organizationDto = new OrganizationDto()
            {
                Name = organization.Name,
                Image = organization.Image,
                Phone = organization.Phone,
                FacebookUrl = organization.FacebookUrl,
                LinkedinUrl = organization.LinkedinUrl,
                InstagramUrl = organization.InstagramUrl,
            };

            return organizationDto;
        }
    }
}
