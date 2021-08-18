using OngProject.Core.DTOs;
using OngProject.Core.Interfaces.IServices;
using OngProject.Core.Interfaces.IServices.AWS;
using OngProject.Core.Interfaces.IUnitOfWork;
using OngProject.Core.Mapper;
using OngProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.Core.Services
{
    public class TestimonialsService : ITestimonialsService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IImagenService _imagenService;

        public TestimonialsService(IUnitOfWork unitOfWork, IImagenService imagenService)
        {
            _unitOfWork = unitOfWork;
            _imagenService = imagenService;
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                await _unitOfWork.TestimonialsRepository.Delete(id);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public async Task<TestimonialsModel> GetById(int id)
        {
            return await _unitOfWork.TestimonialsRepository.GetById(id);
        }

        public async Task<TestimonialsModel> Post(CreateTestimonialsDto testimonialsCreateDto)
        {
            var mapper = new EntityMapper();
            var testimonials = mapper.FromCreateTestimonialsDtoToTestimonials(testimonialsCreateDto);

            await _unitOfWork.TestimonialsRepository.Insert(testimonials);
            await _unitOfWork.SaveChangesAsync();

            return testimonials;
        }

        public bool EntityExist(int id)
        {
            return _unitOfWork.TestimonialsRepository.EntityExists(id);
        }
    }
}
