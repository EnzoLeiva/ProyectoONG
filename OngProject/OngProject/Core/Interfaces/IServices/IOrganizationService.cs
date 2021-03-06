using OngProject.Core.DTOs;
using OngProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.Core.Interfaces.IServices
{
    public interface IOrganizationService
    {
        public Task<OrganizationDto> GetById(int id);
    }
}
