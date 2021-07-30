using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OngProject.Core.Interfaces.IServices;
using OngProject.Core.Interfaces.IUnitOfWork;
using OngProject.Core.Models;

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


        public Task<NewsModel> GetById(int id)

        {

            return _unitOfWork.NewsRepository.GetById(id);

        }


        public Task Insert(NewsModel newsModel)

        {

            return _unitOfWork.NewsRepository.Insert(newsModel);

        }


        public Task Update(NewsModel newsModel)

        {

            return _unitOfWork.NewsRepository.Update(newsModel);

        }
    }
}
