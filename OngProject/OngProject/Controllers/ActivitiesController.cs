using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OngProject.Core.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class ActivitiesController : ControllerBase
    {

        private readonly IActivitiesService _iActivitiesService;

        public ActivitiesController(IActivitiesService iActivitiesService)
        {
            _iActivitiesService = iActivitiesService;
        }
    }
}
