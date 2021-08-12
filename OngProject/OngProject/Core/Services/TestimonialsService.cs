using OngProject.Core.Interfaces.IServices;
using OngProject.Core.Interfaces.IServices.AWS;
using OngProject.Core.Interfaces.IUnitOfWork;
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
                TestimonialsModel testimonials = await GetById(id);
                await _imagenService.Delete(testimonials.Image);

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

        public bool EntityExist(int id)
        {
            return _unitOfWork.TestimonialsRepository.EntityExists(id);
        }
    }
}
