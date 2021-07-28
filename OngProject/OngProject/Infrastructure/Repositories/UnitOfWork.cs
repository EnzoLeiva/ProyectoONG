using OngProject.Core.Interfaces;
using OngProject.Core.Models;
using OngProject.Infrastructure.Data;
using OngProject.Infrastructure.Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        private readonly IBaseRepository<CategoryModel> _categoryRepository;
        private readonly IBaseRepository<ContactsModel> _contactsRepository;
        private readonly IBaseRepository<MemberModel> _memberRepository;
        private readonly IBaseRepository<RoleModel> _roleRepository;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }
        public IBaseRepository<CategoryModel> CategoryRepository => _categoryRepository ?? new BaseRepository<CategoryModel>(_context);
        public IBaseRepository<ContactsModel> ContactsRepository => _contactsRepository ?? new BaseRepository<ContactsModel>(_context);

        public IBaseRepository<MemberModel> MemberRepository => _memberRepository ?? new BaseRepository<MemberModel>(_context);

        public IBaseRepository<RoleModel> RoleRepository => _roleRepository ?? new BaseRepository<RoleModel>(_context);

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
