using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OngProject.Core.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {

        private readonly IRoleService _iRoleService;

        public RoleController(IRoleService iRoleService)
        {
            _iRoleService = iRoleService;
        }
    }
}
