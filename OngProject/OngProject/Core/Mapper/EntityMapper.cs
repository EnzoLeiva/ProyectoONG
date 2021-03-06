using OngProject.Core.DTOs;
using OngProject.Core.DTOs.Auth;
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

        public NewsDto FromNewsToNewsDto(NewsModel news)
        {
            var newsDto = new NewsDto()
            {
                Name = news.Name,
                Image = news.Image,
                Content = news.Content
            };

            return newsDto;
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

        public CategoryDto FromCategoryToCategoryDto(CategoryModel category)
        {
            var categoryDto = new CategoryDto()
            {
                Name = category.Name
            };
            return categoryDto;
        }

        public UserDto FromUserToUserDto(UserModel user, string token)
        {
            var userDto = new UserDto()
            {
                Name = $"{user.firstName} {user.lastName}",
                Email = user.email,
                Token = token
            };

            return userDto;
        }

        public UserModel FromRegisterDtoToUser(RegisterDTO register)
        {
            var user = new UserModel()
            {
                firstName = register.firstName,
                lastName = register.lastName,
                email = register.email,
                password = register.password
            };

            return user;
        }
        public CategoryModel FromCategoryCreateDtoToCategory(CategoryCreateDto categoryCreateDto)
        {
            if (categoryCreateDto == null)
            {
                return null;
            }
            return new CategoryModel
            {
                Description = categoryCreateDto.Description,
                Image = "category_" + categoryCreateDto.Name,
                Name = categoryCreateDto.Name,
            };
        }

        public MemberModel FromMemberCreateDtoToMember(MemberCreateDto memberCreateDto)
        {
            if (memberCreateDto == null)
            {
                return null;
            }
            return new MemberModel
            {
                Name = memberCreateDto.Name,
                FacebookUrl = memberCreateDto.FacebookUrl,
                InstagramUrl = memberCreateDto.InstagramUrl,
                LinkedinUrl = memberCreateDto.LinkedinUrl,
                Image = memberCreateDto.Image,
                Description = memberCreateDto.Description
            };
        }

        public NewsModel FromNewsDtoToNews(NewsDto newsCreateDto)
        {
            if (newsCreateDto == null)
            {
                return null;
            }
            return new NewsModel
            {
                Name = newsCreateDto.Name,
                Content = newsCreateDto.Content,
                Image = "news_" + newsCreateDto.Image,
                CategoryId = newsCreateDto.CategoryId

            };
        }

    }
}
