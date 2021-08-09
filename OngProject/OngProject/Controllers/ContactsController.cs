using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OngProject.Core.Interfaces.IServices;
using OngProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactsService _contactsService;

        public ContactsController(IContactsService contactsService)
        {
            _contactsService = contactsService;
        }
        
        [HttpGet]
        public async Task<IEnumerable<ContactsModel>> GetMembers()
        {
            return await _contactsService.GetContacts();

        }
    }
}
