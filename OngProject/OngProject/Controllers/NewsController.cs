using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OngProject.Core.Interfaces.IServices;
using OngProject.Core.Interfaces;
using OngProject.Infrastructure.Data;


namespace OngProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {

        private readonly INewsService _inewsService;
        
        public NewsController(INewsService inewsService)

        {
            _inewsService = inewsService;

        }
    }
}
