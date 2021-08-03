using OngProject.Core.DTOs;
using OngProject.Core.Interfaces.IServices;
using OngProject.Core.Interfaces.IUnitOfWork;
using OngProject.Core.Mapper;
using OngProject.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.Core.Services
{
    public class SlideService : ISlideService
    {
        private readonly IUnitOfWork _unitOfWork;

        public SlideService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        } 
        
        public async Task<IEnumerable<SlideDto>> GetAll()
        {
            var mapper = new EntityMapper();
            var slideList = await _unitOfWork.SlideRepository.GetAll();
            var slidesDtoList = slideList.Select(x => mapper.FromSlideToSlideDto(x)).ToList();
            return slidesDtoList;
        }

        //public Task<SlideModel> GetById(int Id)
        //{
        //    return _unitOfWork.SlideRepository.GetById(Id);
        //}
    }
}
