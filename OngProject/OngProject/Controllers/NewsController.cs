using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
<<<<<<< HEAD
using OngProject.Core.Interfaces.IServices;
=======
using OngProject.Core.Interfaces;
using OngProject.Infrastructure.Data;
>>>>>>> 6983bc6fb0c3b6134a8d30b850ad91a7c3a2c216

namespace OngProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
<<<<<<< HEAD
        private readonly INewsService _inewsService;
        
        public NewsController(INewsService inewsService)

        {

            _inewsService = inewsService;

=======
        private readonly INewsService _newsService;

        public NewsController(INewsService newsService)
        {
            _newsService = newsService;
>>>>>>> 6983bc6fb0c3b6134a8d30b850ad91a7c3a2c216
        }
    }
}
