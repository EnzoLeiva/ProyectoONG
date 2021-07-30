using Microsoft.AspNetCore.Mvc;
using OngProject.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestimonialsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public TestimonialsController(ApplicationDbContext context)
        {
            this._context = context;
        }
    }
}
