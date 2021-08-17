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
using OngProject.Core.Interfaces.IServices.AWS;
using OngProject.Core.Helper;

namespace OngProject.Core.Services
{
    public class NewsService : INewsService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IImagenService _imagenService;

        public NewsService(IUnitOfWork unitOfWork, IImagenService imagenService)
        {
            _unitOfWork = unitOfWork;
            _imagenService = imagenService;
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                await _unitOfWork.NewsRepository.Delete(id);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public async Task<IEnumerable<NewsModel>> GetAll()
        {
            return await _unitOfWork.NewsRepository.GetAll();
        }

        public async Task<NewsModel> GetById(int id)
        {
           
            var news = await _unitOfWork.NewsRepository.GetById(id);
            return news;
        }

        public async Task<NewsModel> Post(NewsDto newsCreateDto)
        {
            var mapper = new EntityMapper();
            var news = mapper.FromNewsDtoToNews(newsCreateDto);

            try
            {
                await _imagenService.Save(news.Image, newsCreateDto.Image);
                await _unitOfWork.NewsRepository.Insert(news);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return news;
        }

        public Task Update(NewsModel newsModel)
        {

            return _unitOfWork.NewsRepository.Update(newsModel);

        }

        public bool NewsExists(int Id)
        {
            return _unitOfWork.NewsRepository.EntityExists(Id);
        }
    }
}
