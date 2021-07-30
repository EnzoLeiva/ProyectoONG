using OngProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.Core.Interfaces.IServices
{
    public interface ITestimonialsService
    {
        public Task<IEnumerable<TestimonialsModel>> GetAll();
        public Task<TestimonialsModel> GetById(int id);
        public Task Insert(TestimonialsModel testimonialsModel);
        public Task Delete(int id);
        public Task Update(TestimonialsModel testimonialsModel);
    }
}
