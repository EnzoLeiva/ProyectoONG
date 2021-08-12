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
            string photo = null;
            if(register.photo!=null)
             photo = GetNameImage("user");

            var user = new UserModel()
            {
                firstName = register.firstName,
                lastName = register.lastName,
                email = register.email,
                password = register.password,
                photo = photo
            };

            return user;
        }
        public CategoryModel FromCategoryCreateDtoToCategory(CategoryCreateDto categoryCreateDto)
        {
            if (categoryCreateDto == null)
            {
                return null;
            }

            string image = null;
            if (categoryCreateDto.Image != null)
                image = GetNameImage("category");

            return new CategoryModel
            {
                Description = categoryCreateDto.Description,
                Image = image,
                Name = categoryCreateDto.Name,
            };
        }

        public MemberModel FromMemberCreateDtoToMember(MemberCreateDto memberCreateDto)
        {
            if (memberCreateDto == null)
            {
                return null;
            }

            string image = null;
            if (memberCreateDto.Image != null)
                image = GetNameImage("member");

            return new MemberModel
            {
                Name = memberCreateDto.Name,
                FacebookUrl = memberCreateDto.FacebookUrl,
                InstagramUrl = memberCreateDto.InstagramUrl,
                LinkedinUrl = memberCreateDto.LinkedinUrl,
                Image = image,
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

        public UserInfoDto FromUserModelToUserInfoDto(UserModel user)
        {
            if (user == null)
            {
                return null;
            }

            return new UserInfoDto
            {
                firstName = user.firstName,
                lastName = user.lastName,
                email = user.email,
                photo = user.photo,
                roleId = user.roleId
            };
        }
        public TestimonialsModel FromCreateTestimonialsDtoToTestimonials(CreateTestimonialsDto testimonialsCreateDto)
        {
            if (testimonialsCreateDto == null)
            {
                return null;
            }
            return new TestimonialsModel
            {
                Name = testimonialsCreateDto.Name,
                Content = testimonialsCreateDto.Content
            };
        }
        public string GetNameImage(string nameModel)
        {
            string image = DateTime.Now.ToString();
            image = image.Replace(":", "");
            image = image.Replace("/", "");
            image = image.Replace(" ", "");
            image = nameModel+"_" + image;

            return image;
        }

    }
}
