<<<<<<< HEAD
﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
=======
﻿using Microsoft.AspNetCore.Mvc;
using OngProject.Core.DTOs;
>>>>>>> 14e0f52c6ea86348ed7078ad28918db708c43f4f
using OngProject.Core.Interfaces.IServices;
using OngProject.Core.Services;
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


        [HttpPost]
        public async Task<IActionResult> Post([FromForm] ActivitiesCreateDto activitiesCreateDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            try
            {
                var response = await _iActivitiesService.Post(activitiesCreateDto);
                return CreatedAtAction("POST", response);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }

        }
    }
}
