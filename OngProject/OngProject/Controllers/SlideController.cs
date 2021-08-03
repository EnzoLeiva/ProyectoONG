using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OngProject.Core.DTOs;
using OngProject.Core.Interfaces.IServices;
using OngProject.Core.Mapper;
using OngProject.Core.Models;
using OngProject.Infrastructure.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class SlideController : ControllerBase
    {
        private readonly ISlideService _slideService;

        public SlideController(ISlideService slideService)
        {
            _slideService = slideService;
        }

        [Route("/slides")]
        [HttpGet]
        public async Task<IEnumerable<SlideDto>> GetSlides()
        {
            return await _slideService.GetAll();             
        }


    }


}