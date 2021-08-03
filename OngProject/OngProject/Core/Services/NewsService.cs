using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OngProject.Core.Interfaces.IServices;
using OngProject.Core.Interfaces;
using OngProject.Core.Interfaces.IUnitOfWork;
using OngProject.Core.Models;
using OngProject.Core.DTOs;
using OngProject.Core.Mapper;

namespace OngProject.Core.Services
{
    public class NewsService : INewsService
    {
        private readonly IUnitOfWork _unitOfWork;

        public NewsService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task Delete(int id)
        {
            return _unitOfWork.NewsRepository.Delete(id);
        }

        public Task<IEnumerable<NewsModel>> GetAll()
        {
            return _unitOfWork.NewsRepository.GetAll();
        }

        public async Task<NewsDto> GetById(int id)
        {
            var mapper = new EntityMapper();
            var news = await _unitOfWork.NewsRepository.GetById(id);
            var newsDto = mapper.FromNewsToNewsDto(news);
            return newsDto;
        }

        public Task Insert(NewsModel newsModel)
        {
            return _unitOfWork.NewsRepository.Insert(newsModel);
        }

        public Task Update(NewsModel newsModel)
        {
            return _unitOfWork.NewsRepository.Update(newsModel);

        }

        public bool UserExists(int Id)
        {
            return _unitOfWork.NewsRepository.EntityExists(Id);
        }
    }
}
