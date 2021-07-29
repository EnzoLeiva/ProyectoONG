using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OngProject.Core.Models;
using OngProject.Infrastructure.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class SlideController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SlideController(ApplicationDbContext context)
        {
            this._context = context;
        }


    }


}