﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OngProject.Core.DTOs;
using OngProject.Core.Interfaces.IServices;
using OngProject.Core.Interfaces.IServices.AWS;
using OngProject.Core.Interfaces.IUnitOfWork;
using OngProject.Core.Mapper;
using OngProject.Core.Models;
using OngProject.Infrastructure.Data;
namespace OngProject.Core.Services
{
    public class ActivitiesService : IActivitiesService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IImagenService _imagenService;

        public ActivitiesService(IUnitOfWork unitOfWork, IImagenService imagenService)
        {
            _unitOfWork = unitOfWork;
            _imagenService = imagenService;
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

        public async Task<ActivitiesModel> Post(ActivitiesCreateDto activitiesCreateDto)
        {
            var mapper = new EntityMapper();
            var activities = mapper.FromActivitiesCreateDtoToActivities(activitiesCreateDto);

            if (activitiesCreateDto.Image != null)
                await _imagenService.Save(activities.Image, activitiesCreateDto.Image);

            await _unitOfWork.ActivitiesRepository.Insert(activities);
            await _unitOfWork.SaveChangesAsync();
            return activities;
        }

        public Task Update(ActivitiesModel activitiesModel)
        {
            return _unitOfWork.ActivitiesRepository.Update(activitiesModel);
        }
    }

}

