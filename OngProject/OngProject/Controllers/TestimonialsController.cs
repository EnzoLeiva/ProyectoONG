using Microsoft.AspNetCore.Mvc;
using OngProject.Core.Interfaces.IServices;
using OngProject.Core.Services;
using OngProject.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestimonialsController : ControllerBase
    {
        private readonly ITestimonialsService _testimonialsService;

        public TestimonialsController(ITestimonialsService testimonialsService)
        {
            _testimonialsService = testimonialsService;
        }
    }
}
