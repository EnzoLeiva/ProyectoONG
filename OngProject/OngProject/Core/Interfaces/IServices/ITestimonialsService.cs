using OngProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.Core.Interfaces.IServices
{
    public interface ITestimonialsService
    {
        public Task<bool> Delete(int id);
        public bool EntityExist(int id);
    }
}
