using Microsoft.AspNetCore.Mvc;
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
    public class ContactsService : IContactsService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ContactsService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<ContactsModel>> GetContacts()
        {
            return await _unitOfWork.ContactsRepository.GetAll();
        }

        public async Task<ContactsModel> Post(ContactsCreateDto contactsCreateDto)
        {
            var mapper = new EntityMapper();
            var contact = mapper.FromContactsCreateDtoToContacts(contactsCreateDto);

            await _unitOfWork.ContactsRepository.Insert(contact);
            await _unitOfWork.SaveChangesAsync();

            return contact;
        }
    }
}
