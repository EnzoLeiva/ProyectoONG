using OngProject.Core.Models;
using OngProject.Infrastructure.Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepository<CategoryModel> CategoryRepository { get; }
        IBaseRepository<ContactsModel> ContactsRepository { get; }
        IBaseRepository<MemberModel> MemberRepository { get; }
        IBaseRepository<RoleModel> RoleRepository { get; }

        void SaveChanges();
        Task SaveChangesAsync();
    }
}
