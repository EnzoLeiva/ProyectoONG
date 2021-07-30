using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
<<<<<<< HEAD
using OngProject.Core.Interfaces.IServices;
=======
using OngProject.Core.Interfaces;
>>>>>>> 6983bc6fb0c3b6134a8d30b850ad91a7c3a2c216
using OngProject.Core.Interfaces.IUnitOfWork;
using OngProject.Core.Models;

namespace OngProject.Core.Services
{
    public class NewsService : INewsService
    {
        private readonly IUnitOfWork _unitOfWork;
<<<<<<< HEAD

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

=======
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
>>>>>>> 6983bc6fb0c3b6134a8d30b850ad91a7c3a2c216
        }
    }
}
