using OngProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.Core.Interfaces
{
    public interface IMemberService
    {
        public Task<IEnumerable<MemberModel>> GetMembers();
    }
}
