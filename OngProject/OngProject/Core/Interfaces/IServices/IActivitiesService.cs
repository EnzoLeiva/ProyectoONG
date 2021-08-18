using Microsoft.AspNetCore.Mvc;
using OngProject.Core.DTOs;
using OngProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.Core.Interfaces.IServices
{
    public interface IActivitiesService
    {
        public Task<IEnumerable<ActivitiesModel>> GetAll();
        public Task<ActivitiesModel> GetById(int Id);
        public Task Insert(ActivitiesModel categoryModel);
        public Task Delete(int Id);
        public Task Update(ActivitiesModel categoryModel);
        public Task<ActivitiesModel> Post(ActivitiesCreateDto activitiesCreateDto);
    }
}
