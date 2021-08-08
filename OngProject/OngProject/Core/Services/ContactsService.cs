using OngProject.Core.Interfaces.IServices;
using OngProject.Core.Interfaces.IUnitOfWork;
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
    }
}
