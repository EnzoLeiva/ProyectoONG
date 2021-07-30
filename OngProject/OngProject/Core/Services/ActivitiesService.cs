using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OngProject.Core.Interfaces.IServices;
using OngProject.Core.Interfaces.IUnitOfWork;
using OngProject.Core.Models;
using OngProject.Infrastructure.Data;
namespace OngProject.Core.Services
{
    public class ActivitiesService : IActivitiesService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ActivitiesService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task Delete(int id)
        {
            return _unitOfWork.ActivitiesRepository.Delete(id);
        }

        public Task<IEnumerable<ActivitiesModel>> GetAll()
        {
            return _unitOfWork.ActivitiesRepository.GetAll();
        }

        public Task<ActivitiesModel> GetById(int id)
        {
            return _unitOfWork.ActivitiesRepository.GetById(id);
        }

        public Task Insert(ActivitiesModel categoryModel)
        {
            return _unitOfWork.ActivitiesRepository.Insert(categoryModel);
        }

        public Task Update(ActivitiesModel categoryModel)
        {
            return _unitOfWork.ActivitiesRepository.Update(categoryModel);
        }
    }

}

