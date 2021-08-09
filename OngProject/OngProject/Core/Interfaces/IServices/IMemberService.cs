using Microsoft.AspNetCore.Mvc;
using OngProject.Core.DTOs;
using OngProject.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OngProject.Core.Interfaces
{
    public interface IMemberService
    {
        public Task<IEnumerable<MemberModel>> GetMembers();
        public Task<MemberModel> Post([FromForm] MemberCreateDto memberCreateDto); 

    }
}
