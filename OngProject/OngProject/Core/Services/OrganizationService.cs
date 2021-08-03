using OngProject.Core.DTOs;
using OngProject.Core.Interfaces.IServices;
using OngProject.Core.Interfaces.IUnitOfWork;
using OngProject.Core.Mapper;
using OngProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.Core.Services
{
    public class OrganizationService: IOrganizationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public OrganizationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<OrganizationDto> GetById(int id)
        {
            var mapper = new EntityMapper();
            var organization = await _unitOfWork.OrganizationRepository.GetById(id);
            var organizationDto = mapper.FromOrganizationToOrganizationDto(organization);
            return organizationDto;
        }
    }
}
