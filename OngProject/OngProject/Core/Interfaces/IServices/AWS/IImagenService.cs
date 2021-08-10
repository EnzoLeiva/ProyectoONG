using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.Core.Interfaces.IServices.AWS
{
    public interface IImagenService
    {
        public Task<String> saveImage(IFormFile image);
    }
}
