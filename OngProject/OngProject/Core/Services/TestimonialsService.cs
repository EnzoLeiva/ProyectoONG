using OngProject.Core.Interfaces.IServices;
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
        private readonly ITestimonialsService _testimonialsService;

        public TestimonialsService(IUnitOfWork unitOfWork, ITestimonialsService testimonialsService)
        {
            _unitOfWork = unitOfWork;
            _testimonialsService = testimonialsService;
        }

        public Task Delete(int id)
        {
            return _unitOfWork.TestimonialsRepository.Delete(id);
        }

        public Task<IEnumerable<TestimonialsModel>> GetAll()
        {
            return _unitOfWork.TestimonialsRepository.GetAll();
        }

        public Task<TestimonialsModel> GetById(int id)
        {
            return _unitOfWork.TestimonialsRepository.GetById(id);
        }

        public Task Insert(TestimonialsModel testimonialsModel)
        {
            return _unitOfWork.TestimonialsRepository.Insert(testimonialsModel);
        }

        public Task Update(TestimonialsModel testimonialsModel)
        {
            return _unitOfWork.TestimonialsRepository.Update(testimonialsModel);
        }
    }
}
